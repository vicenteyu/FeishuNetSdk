// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-07
//
// Last Modified By : yxr
// Last Modified On : 2026-05-26
// ************************************************************************
// <copyright file="WssService.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>启用长连接服务</summary>
// ************************************************************************
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Buffers;
using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Reactive.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Websocket.Client;
using STask = System.Threading.Tasks.Task;

namespace FeishuNetSdk.WebSocket;

/// <summary>
/// 长连接服务
/// <para>优势：</para>
/// <para>测试阶段无需使用内网穿透工具，通过长连接模式在本地开发环境中即可接收事件回调。</para>
/// <para>只在建连时进行鉴权，后续事件推送均为明文数据，无需再处理解密和验签逻辑。</para>
/// <para>只需保证运行环境具备访问公网能力即可，无需提供公网 IP 或域名。</para>
/// <para>无需部署防火墙和配置白名单。</para>
/// <para></para>
/// <para>注意事项：</para>
/// <para>长连接模式仅支持企业自建应用。</para>
/// <para>与 将事件发送至开发者服务器 方式的要求相同，长连接模式下接收到消息后，也需要在 3 秒内处理完成，否则会触发超时重推机制。</para>
/// <para>每个应用最多建立 50 个连接（在配置长连接时，每初始化一个 client 就是一个连接）。</para>
/// <para>长连接模式的消息推送为 集群模式，不支持广播。</para>
/// <para>如果同一应用部署了多个客户端（client），那么只有其中随机一个客户端会收到消息。</para>
/// <para>务必注意：仅建议在测试环境使用长连接模式，不当使用则可能导致正式环境的事件消息被误收！！！</para>
/// </summary>
public class WssService(
    IFeishuApi feishuApi,
    IOptionsMonitor<FeishuNetSdkOptions> options,
    ILogger<WssService> logger,
    Services.IEventCallbackServiceProvider eventCallback) : BackgroundService
{
    private bool _disposed = false;
    private WebsocketClient? _wsClient;
    private IDisposable? _messageSubscription;
    private IDisposable? _disconnectionSubscription;

    private readonly SemaphoreSlim _swapUrlSemaphore = new(1, 1);
    private readonly SemaphoreSlim _reconnectSemaphore = new(1, 1);

    private readonly ConcurrentDictionary<Guid, STask> _runningTasks = new();
    private readonly SemaphoreSlim _concurrentConsumerSemaphore = new(20, 20);

    private static readonly ConcurrentDictionary<string, MessageAssembleSlot> _assemblyPool = new();

    private static readonly JsonSerializerOptions serializerOptions = new()
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    private class MessageAssembleSlot
    {
        public int TotalCount { get; set; } = 1;
        public Dictionary<int, (byte[] Buffer, int Length)> Chunks { get; } = [];
        public Frame? LastArrivedFrame { get; set; }
        public DateTime LastActiveTime { get; set; } = DateTime.UtcNow;
        public bool IsStaticOrCompleted { get; set; } = false;
    }

    /// <summary>
    /// 10秒主巡检循环
    /// </summary>
    protected override async STask ExecuteAsync(CancellationToken cancellationToken)
    {
        logger.LogInformation("【服务启动】长连接已就绪。");
        await TryInitializeAndStartAsync(cancellationToken);

        while (!cancellationToken.IsCancellationRequested)
        {
            try
            {
                await STask.Delay(10000, cancellationToken);
                CleanExpiredAssemblySlots();

                if (_wsClient == null || !_wsClient.IsRunning)
                {
                    if (await _reconnectSemaphore.WaitAsync(0, CancellationToken.None))
                    {
                        try
                        {
                            if (_wsClient == null || !_wsClient.IsRunning)
                            {
                                logger.LogWarning("【长连接】巡检发现连接处于断开状态，尝试换取新端点...");
                                await TryInitializeAndStartAsync(cancellationToken);
                            }
                        }
                        finally
                        {
                            _reconnectSemaphore.Release();
                        }
                    }
                }
            }
            catch (TaskCanceledException) { break; }
            catch (Exception ex)
            {
                logger.LogError(ex, "【长连接】巡检状态机发生未知错误。");
            }
        }

        if (!_runningTasks.IsEmpty)
        {
            logger.LogInformation("【服务停止】正在等待所有进行中的长连接事件回调完成...");
            try
            {
                await STask.WhenAny(STask.WhenAll(_runningTasks.Values), STask.Delay(5000, CancellationToken.None));
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "【服务停止】等待进行中的任务完成时遭遇异常");
            }
        }
    }

    /// <summary>
    /// 核心状态对齐方法（单例不重构，只进行热更新 URL 和 物理拉起）
    /// </summary>
    private async STask TryInitializeAndStartAsync(CancellationToken cancellationToken)
    {
        await _swapUrlSemaphore.WaitAsync(cancellationToken);

        try
        {
            logger.LogInformation("【长连接】正在尝试换取飞书网关...");
            string initialUrl = await GetWssEndpointAsync(cancellationToken);

            if (_wsClient == null)
            {
                var factory = new Func<ClientWebSocket>(() =>
                        new ClientWebSocket { Options = { KeepAliveInterval = TimeSpan.FromSeconds(30) } });

                _wsClient = new WebsocketClient(new Uri(initialUrl), factory)
                {
                    ReconnectTimeout = null, // 禁用应用层心跳预测
                    ErrorReconnectTimeout = TimeSpan.FromSeconds(5) // 5 秒物理重连
                };

                RegisterMessagePipeline(cancellationToken);
                RegisterDisconnectionPipeline(cancellationToken);

                await _wsClient.Start();
                logger.LogInformation("【长连接】通道首次初始化并成功连接。");
            }
            else
            {
                _wsClient.Url = new Uri(initialUrl);
                logger.LogInformation("【长连接】已成功更新连接。");

                if (!_wsClient.IsStarted)
                {
                    await _wsClient.Start();
                }
            }
        }
        catch (Exception ex)
        {
            logger.LogWarning("【长连接】获取网关或刷新连接失败，网络可能仍未恢复 (原因: {Msg})。等待下一轮巡检...", ex.Message);
        }
        finally
        {
            _swapUrlSemaphore.Release();
        }
    }

    /// <summary>
    /// 消息接收管道
    /// </summary>
    private void RegisterMessagePipeline(CancellationToken cancellationToken)
    {
        _messageSubscription = _wsClient?.MessageReceived.Subscribe(msg =>
        {
            if (msg.MessageType == WebSocketMessageType.Binary && msg.Binary != null)
            {
                int dataLength = msg.Binary.Length;

                byte[] preciseBuffer = new byte[dataLength];
                Array.Copy(msg.Binary, 0, preciseBuffer, 0, dataLength);

                (Frame? completedFrame, string? eventId) = TryReassembleMessage(preciseBuffer, dataLength);

                if (completedFrame != null)
                {
                    var taskId = Guid.NewGuid();
                    var runningTask = STask.Run(async () =>
                    {
                        await _concurrentConsumerSemaphore.WaitAsync(CancellationToken.None);
                        try
                        {
                            await ProcessMessageAsync(completedFrame, eventId, cancellationToken);
                        }
                        finally
                        {
                            _concurrentConsumerSemaphore.Release();
                            _runningTasks.TryRemove(taskId, out _);
                        }
                    }, cancellationToken);

                    _runningTasks.TryAdd(taskId, runningTask);
                }
            }
            else if (msg.MessageType == WebSocketMessageType.Text && !string.IsNullOrEmpty(msg.Text))
            {
                if (msg.Text.Equals("ping", StringComparison.OrdinalIgnoreCase))
                {
                    logger.LogDebug("【长连接】收到 ping 帧。");
                }
            }
        });
    }

    /// <summary>
    /// 被动断线管道
    /// </summary>
    private void RegisterDisconnectionPipeline(CancellationToken _)
    {
        _disconnectionSubscription = _wsClient?.DisconnectionHappened.Subscribe(info =>
        {
            if (info.Type == DisconnectionType.Exit || info.Type == DisconnectionType.ByUser)
                return;

            logger.LogWarning("【长连接】底层通道遭遇意外断开 (原因: {Type})。等待巡检热刷新...", info.Type);
        });
    }

    /// <summary>
    /// 报文反序列化与分片组装
    /// </summary>
    private (Frame?, string?) TryReassembleMessage(byte[] preciseBuffer, int dataLength)
    {
        string? eventId = null;
        byte[]? allocatedChunkBuffer = null;
        string? instanceId = null;
        try
        {
            Frame frame;
            var memorySource = new ReadOnlyMemory<byte>(preciseBuffer, 0, dataLength);
            frame = ProtoBuf.Serializer.Deserialize<Frame>(memorySource);

            if (frame == null || frame.Payload.IsEmpty)
            {
                return (null, null);
            }

            int totalChunks = 1;
            int chunkIndex = 0;
            bool isFragmented = false;

            if (frame.Headers != null && frame.Headers.Count > 0)
            {
                frame.Headers.TryGetValue("instance_id", out instanceId);
                frame.Headers.TryGetValue("trace_id", out eventId);

                if (frame.Headers.TryGetValue("sum", out var _sum) && frame.Headers.TryGetValue("seq", out var _seq))
                {
                    isFragmented = true;
                    totalChunks = int.Parse(_sum);
                    chunkIndex = int.Parse(_seq);
                }
            }

            ReadOnlyMemory<byte> payloadMemory = frame.Payload;

            if (string.IsNullOrEmpty(instanceId) || !isFragmented)
            {
                frame.Payload = new ReadOnlyMemory<byte>(payloadMemory.ToArray());
                return (frame, eventId);
            }

            var slot = _assemblyPool.GetOrAdd(instanceId, _ => new MessageAssembleSlot { TotalCount = totalChunks });
            byte[] payloadChunkBuffer = ArrayPool<byte>.Shared.Rent(payloadMemory.Length);
            allocatedChunkBuffer = payloadChunkBuffer;

            payloadMemory.Span.CopyTo(payloadChunkBuffer);

            Frame? finalCombinedFrame = null;
            bool isCompleted = false;

            lock (slot)
            {
                if (slot.IsStaticOrCompleted)
                {
                    ArrayPool<byte>.Shared.Return(payloadChunkBuffer);
                    allocatedChunkBuffer = null;
                    return (null, eventId);
                }

                slot.LastActiveTime = DateTime.UtcNow;
                slot.Chunks[chunkIndex] = (payloadChunkBuffer, payloadMemory.Length);
                allocatedChunkBuffer = null;
                slot.LastArrivedFrame = frame;

                if (slot.Chunks.Count == slot.TotalCount)
                {
                    isCompleted = true;
                    slot.IsStaticOrCompleted = true;
                    finalCombinedFrame = slot.LastArrivedFrame;
                }
            }

            if (isCompleted && finalCombinedFrame != null)
            {
                if (_assemblyPool.TryRemove(instanceId, out _))
                {
                    int totalBytes = 0;
                    for (int i = 0; i < slot.TotalCount; i++)
                    {
                        if (slot.Chunks.TryGetValue(i, out var chunk)) totalBytes += chunk.Length;
                    }

                    byte[] combinedPayload = ArrayPool<byte>.Shared.Rent(totalBytes);
                    int currentOffset = 0;

                    try
                    {
                        for (int i = 0; i < slot.TotalCount; i++)
                        {
                            if (slot.Chunks.TryGetValue(i, out var chunk))
                            {
                                chunk.Buffer.AsSpan(0, chunk.Length).CopyTo(combinedPayload.AsSpan(currentOffset));
                                currentOffset += chunk.Length;

                                ArrayPool<byte>.Shared.Return(chunk.Buffer);
                            }
                        }
                    }
                    finally
                    {
                        slot.Chunks.Clear();
                    }

                    finalCombinedFrame.Headers?.TryAdd("x-pool-rented", "true");
                    finalCombinedFrame.Payload = new ReadOnlyMemory<byte>(combinedPayload, 0, totalBytes);
                }
                else
                {
                    return (null, eventId);
                }
            }

            return (finalCombinedFrame, eventId);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "【长连接】EventID: {eventId} 组装处理出现异常", eventId);
            if (allocatedChunkBuffer != null)
            {
                ArrayPool<byte>.Shared.Return(allocatedChunkBuffer);
                allocatedChunkBuffer = null;
            }
            if (!string.IsNullOrEmpty(instanceId) && _assemblyPool.TryRemove(instanceId, out var failedSlot))
            {
                lock (failedSlot)
                {
                    failedSlot.IsStaticOrCompleted = true;
                    foreach (var chunk in failedSlot.Chunks.Values)
                    {
                        ArrayPool<byte>.Shared.Return(chunk.Buffer);
                    }
                    failedSlot.Chunks.Clear();
                }
            }
            return (null, null);
        }
    }

    /// <summary>
    /// 执行业务事件消费
    /// </summary>
    private async STask ProcessMessageAsync(Frame completeFrame, string? eventId, CancellationToken cancellationToken)
    {
        using var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        cts.CancelAfter(TimeSpan.FromMilliseconds(3500));

        try
        {
            if (!TryParsePayload(completeFrame.Payload, out var jsonPayloadNode) || jsonPayloadNode is null)
            {
                return;
            }

            var result = await eventCallback.HandleAsync(jsonPayloadNode, cts.Token);

            if (result.Error is not null)
            {
                throw new InvalidOperationException($"【长连接】事件回调执行失败: {result.Error}");
            }

            cts.Token.ThrowIfCancellationRequested();
            await SendWebSocketAckAsync(completeFrame, result, cts.Token);

            if (logger.IsEnabled(LogLevel.Debug))
                logger.LogDebug("【长连接】EventID: {eventid} 响应完成", eventId);
        }
        catch (OperationCanceledException)
        {
            logger.LogError("【长连接】EventID: {eventId} 业务消费或 ACK 响应超时（飞书限制为3秒）", eventId);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "【长连接】核心业务帧在执行消费时发生异常");
        }
        finally
        {
            // 大分片内存池回收
            bool isRented = completeFrame.Headers?.Any(h => h.Key == "x-pool-rented" && h.Value == "true") ?? false;
            if (isRented)
            {
                if (MemoryMarshal.TryGetArray(completeFrame.Payload, out ArraySegment<byte> segment) && segment.Array != null)
                {
                    ArrayPool<byte>.Shared.Return(segment.Array);
                }
            }
        }

        static bool TryParsePayload(ReadOnlyMemory<byte> payload, out JsonNode? node)
        {
            node = null;
            var span = payload.Span;

            span = span.Trim((byte)0x00);

            if (span.SequenceEqual("ping"u8)) return false;
            if (span.Length == 0 || (span[0] != (byte)'{' && span[0] != (byte)'[')) return false;

            node = JsonNode.Parse(span) ?? throw new InvalidDataException();
            return true;
        }
    }

    private async STask SendWebSocketAckAsync(Frame requestFrame,
        Services.EventCallbackServiceProvider.HandleResult result,
        CancellationToken cancellationToken)
    {
        try
        {
            byte[]? dto_bytes = null;
            if (result.Dto is not null)
            {
                var dto_string = JsonSerializer.Serialize(result.Dto, serializerOptions);
                dto_bytes = Encoding.UTF8.GetBytes(dto_string);
            }
            var dto_response_body = new { code = 200, data = dto_bytes };

            var responseJson = JsonSerializer.Serialize(dto_response_body, serializerOptions);

            if (logger.IsEnabled(LogLevel.Debug))
                logger.LogDebug("【长连接】出参：{json}", responseJson);

            cancellationToken.ThrowIfCancellationRequested();

            var ackFrame = new Frame
            {
                SeqID = requestFrame.SeqID,
                LogID = requestFrame.LogID,
                LogIDNew = requestFrame.LogIDNew,
                Service = requestFrame.Service,
                Method = 2,
                Headers = requestFrame.Headers.ToDictionary(),
                Payload = new ReadOnlyMemory<byte>(Encoding.UTF8.GetBytes(responseJson))
            };

            using var messageStream = new MemoryStream();
            ProtoBuf.Serializer.Serialize(messageStream, ackFrame);

            if (_wsClient != null && _wsClient.IsRunning)
            {
                await _wsClient.SendInstant(messageStream.ToArray());
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "【长连接】ACK 异常");
        }
    }

    private async Task<string> GetWssEndpointAsync(CancellationToken cancellationToken)
    {
        try
        {
            var result = await feishuApi.PostCallbackWsEndpointAsync(new()
            {
                AppId = options.CurrentValue.AppId,
                AppSecret = options.CurrentValue.AppSecret
            }, cancellationToken);

            if (result?.IsSuccess != true || string.IsNullOrEmpty(result?.Data?.Url))
                throw new InvalidOperationException(result?.Msg ?? $"获取 WSS 端点失败，Code：{result?.Code}");

            return result.Data.Url;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "【长连接】获取 WSS 端点异常：{msg}", ex.Message);
            throw;
        }
    }

    private void CleanExpiredAssemblySlots()
    {
        try
        {
            var now = DateTime.UtcNow;
            var expiredKeys = _assemblyPool
                .Where(kvp => (now - kvp.Value.LastActiveTime).TotalSeconds > 60)
                .Select(kvp => kvp.Key)
                .ToList();

            foreach (var key in expiredKeys)
            {
                if (_assemblyPool.TryRemove(key, out var expiredSlot))
                {
                    lock (expiredSlot)
                    {
                        expiredSlot.IsStaticOrCompleted = true;
                        logger.LogWarning("【长连接】检测到分片组装超时（InstanceId: {Key}），已强制回收并释放。", key);
                        foreach (var chunk in expiredSlot.Chunks.Values)
                        {
                            ArrayPool<byte>.Shared.Return(chunk.Buffer);
                        }
                        expiredSlot.Chunks.Clear();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "【长连接】清理超时分片缓存时遭遇未知异常");
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public override void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
        base.Dispose();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="disposing"></param>
    protected virtual void Dispose(bool disposing)
    {
        if (_disposed) return;

        if (disposing)
        {
            logger?.LogInformation("【服务注销】彻底销毁长连接网关，安全释放管道。");

            _messageSubscription?.Dispose();
            _disconnectionSubscription?.Dispose();
            _swapUrlSemaphore?.Dispose();
            _reconnectSemaphore?.Dispose();
            _concurrentConsumerSemaphore?.Dispose();

            foreach (var kvp in _assemblyPool)
            {
                foreach (var chunk in kvp.Value.Chunks.Values)
                {
                    ArrayPool<byte>.Shared.Return(chunk.Buffer);
                }
            }
            _assemblyPool.Clear();
            _runningTasks.Clear();

            _wsClient?.Dispose();
            _wsClient = null;
        }

        _disposed = true;
    }

    /// <summary>
    /// 
    /// </summary>
    ~WssService()
    {
        Dispose(false);
    }
}