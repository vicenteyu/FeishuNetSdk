// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-07
//
// Last Modified By : yxr
// Last Modified On : 2026-05-22
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
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Websocket.Client;

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
/// <para>如果同一应用部署了多个客户端（client），那么只有其中随机一个客户端会收到消息。</para>
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

    private class MessageAssembleSlot
    {
        public int TotalCount { get; set; } = 1;
        public Dictionary<int, (byte[] Buffer, int Length)> Chunks { get; } = [];
        public Frame? LastArrivedFrame { get; set; }
    }

    private static readonly ConcurrentDictionary<string, MessageAssembleSlot> _assemblyPool = new();

    private static readonly JsonSerializerOptions serializerOptions = new()
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    /// <summary>
    /// 服务启动
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    protected override async System.Threading.Tasks.Task ExecuteAsync(CancellationToken cancellationToken)
    {
        logger.LogInformation("【服务启动】长连接已就绪。");
        await TryInitializeAndStartAsync(cancellationToken);

        while (!cancellationToken.IsCancellationRequested)
        {
            try
            {
                await System.Threading.Tasks.Task.Delay(10000, cancellationToken);

                if (_wsClient == null || !_wsClient.IsRunning)
                {
                    if (await _reconnectSemaphore.WaitAsync(0, cancellationToken))
                    {
                        try
                        {
                            if (_wsClient == null || !_wsClient.IsRunning)
                            {
                                logger.LogWarning("【长连接】检测到正处于「停止」状态，正在尝试连接...");
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
            catch (TaskCanceledException) { }
            catch (Exception ex)
            {
                logger.LogError(ex, "【长连接】巡检状态机发生未知错误。");
            }
        }
    }

    private async Task<bool> TryInitializeAndStartAsync(CancellationToken cancellationToken)
    {
        if (!await _swapUrlSemaphore.WaitAsync(0, CancellationToken.None)) return false;

        try
        {
            logger.LogInformation("【长连接】正在尝试初始化...");

            if (_wsClient != null)
            {
                await _wsClient.Stop(WebSocketCloseStatus.NormalClosure, "Re-init reset");
            }

            string initialUrl = await GetWssEndpointAsync(cancellationToken);

            if (_wsClient == null)
            {
                var factory = new Func<ClientWebSocket>(() =>
                    new ClientWebSocket { Options = { KeepAliveInterval = TimeSpan.FromSeconds(30) } });

                _wsClient = new WebsocketClient(new Uri(initialUrl), factory)
                {
                    ReconnectTimeout = null
                };

                RegisterMessagePipeline(cancellationToken);
                RegisterDisconnectionPipeline(cancellationToken);
                await _wsClient.Start();
                logger.LogInformation("【长连接】首次建立成功。");
            }
            else
            {
                _wsClient.Url = new Uri(initialUrl);
                await _wsClient.Reconnect();
                logger.LogInformation("【长连接】已成功切换至新端点。");
            }

            return true;
        }
        catch (Exception ex)
        {
            logger.LogError("【长连接】网络可能仍未恢复，遭遇异常: {Message}", ex.Message);
            return false;
        }
        finally
        {
            _swapUrlSemaphore.Release();
        }
    }

    private void RegisterMessagePipeline(CancellationToken cancellationToken)
    {
        _messageSubscription = _wsClient?.MessageReceived.Subscribe(msg =>
        {
            if (msg.MessageType == WebSocketMessageType.Binary && msg.Binary != null)
            {
                int dataLength = msg.Binary.Length;

                byte[] rentedBuffer = ArrayPool<byte>.Shared.Rent(dataLength);
                Array.Copy(msg.Binary, 0, rentedBuffer, 0, dataLength);

                (Frame? completedFrame, string? eventId) = TryReassembleMessage(rentedBuffer, dataLength);

                if (completedFrame != null)
                {
                    _ = System.Threading.Tasks.Task.Run(async () =>
                        await ProcessMessageAsync(completedFrame, eventId, cancellationToken), cancellationToken);
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

    private void RegisterDisconnectionPipeline(CancellationToken cancellationToken)
    {
        _disconnectionSubscription = _wsClient?.DisconnectionHappened.Subscribe(info =>
        {
            if (info.Type == DisconnectionType.Exit || info.Type == DisconnectionType.ByUser)
                return;

            logger.LogWarning("【长连接】遭遇意外断开，类型: {Type}。正在触发 Reconnect 重连...", info.Type);

            _ = System.Threading.Tasks.Task.Run(async () =>
            {
                await TryInitializeAndStartAsync(cancellationToken);
            }, cancellationToken);
        });
    }

    private (Frame?, string?) TryReassembleMessage(byte[] rentedBuffer, int dataLength)
    {
        string? eventId = null;
        try
        {
            Frame frame;
            var memorySource = new ReadOnlyMemory<byte>(rentedBuffer, 0, dataLength);
            frame = ProtoBuf.Serializer.Deserialize<Frame>(memorySource);

            if (frame == null || frame.Payload.IsEmpty)
            {
                ArrayPool<byte>.Shared.Return(rentedBuffer);
                return (null, null);
            }

            string? instanceId = null;
            int totalChunks = 1;
            int chunkIndex = 0;
            bool isFragmented = false;

            if (frame.Headers != null && frame.Headers.Length > 0)
            {
                var instanceIdHeader = frame.Headers.FirstOrDefault(h => h.Key == "instance_id");
                var sumHeader = frame.Headers.FirstOrDefault(h => h.Key == "sum");
                var seqHeader = frame.Headers.FirstOrDefault(h => h.Key == "seq");
                var eventIdHeader = frame.Headers.FirstOrDefault(h => h.Key == "trace_id");

                if (eventIdHeader != null) eventId = eventIdHeader.Value;
                if (instanceIdHeader != null) instanceId = instanceIdHeader.Value;
                if (sumHeader != null && seqHeader != null)
                {
                    isFragmented = true;
                    totalChunks = int.Parse(sumHeader.Value);
                    chunkIndex = int.Parse(seqHeader.Value);
                }
            }

            ReadOnlyMemory<byte> payloadMemory = frame.Payload;

            if (string.IsNullOrEmpty(instanceId) || !isFragmented)
            {
                byte[] singlePayload = new byte[payloadMemory.Length];
                payloadMemory.Span.CopyTo(singlePayload);

                frame.Payload = new ReadOnlyMemory<byte>(singlePayload);

                ArrayPool<byte>.Shared.Return(rentedBuffer);
                return (frame, eventId);
            }

            var slot = _assemblyPool.GetOrAdd(instanceId, _ => new MessageAssembleSlot { TotalCount = totalChunks });

            byte[] payloadChunkBuffer = ArrayPool<byte>.Shared.Rent(payloadMemory.Length);

            payloadMemory.Span.CopyTo(payloadChunkBuffer);

            ArrayPool<byte>.Shared.Return(rentedBuffer);

            Frame? finalCombinedFrame = null;

            lock (slot)
            {
                slot.Chunks[chunkIndex] = (payloadChunkBuffer, payloadMemory.Length);
                slot.LastArrivedFrame = frame;

                if (slot.Chunks.Count == slot.TotalCount)
                {
                    _assemblyPool.TryRemove(instanceId, out _);

                    finalCombinedFrame = slot.LastArrivedFrame;

                    int totalBytes = slot.Chunks.Values.Sum(c => c.Length);
                    byte[] combinedPayload = new byte[totalBytes];

                    int currentOffset = 0;
                    for (int i = 0; i < slot.TotalCount; i++)
                    {
                        var chunk = slot.Chunks[i];

                        chunk.Buffer.AsSpan(0, chunk.Length).CopyTo(combinedPayload.AsSpan(currentOffset));
                        currentOffset += chunk.Length;

                        ArrayPool<byte>.Shared.Return(chunk.Buffer);
                    }

                    finalCombinedFrame.Payload = new ReadOnlyMemory<byte>(combinedPayload);
                }
            }

            return (finalCombinedFrame, eventId);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "【长连接】EventID: {eventId} 出现异常", eventId);
            ArrayPool<byte>.Shared.Return(rentedBuffer);
            return (null, null);
        }
    }

    private async System.Threading.Tasks.Task ProcessMessageAsync(Frame completeFrame, string? eventId, CancellationToken cancellationToken)
    {
        try
        {
            string jsonText = Encoding.UTF8.GetString(completeFrame.Payload.Span).Trim();

            if (jsonText.Equals("ping", StringComparison.OrdinalIgnoreCase)) return;
            if (!jsonText.StartsWith('{') && !jsonText.StartsWith('[')) return;

            var jsonPayloadNode = JsonNode.Parse(jsonText) ?? throw new InvalidDataException();

            var result = await eventCallback.HandleAsync(jsonPayloadNode, cancellationToken);

            if (result.Error is not null)
            {
                throw new InvalidOperationException($"【长连接】事件回调执行失败: {result.Error}");
            }

            cancellationToken.ThrowIfCancellationRequested();

            await SendWebSocketAckAsync(completeFrame, result, cancellationToken);

            if (logger.IsEnabled(LogLevel.Debug))
                logger.LogDebug("【长连接】EventID: {eventid} 响应完成", eventId);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "【长连接】核心业务帧时发生未知崩塌");
        }
    }

    private async System.Threading.Tasks.Task SendWebSocketAckAsync(Frame requestFrame,
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
                Headers = requestFrame.Headers,
                Payload = new ReadOnlyMemory<byte>(Encoding.UTF8.GetBytes(responseJson))
            };

            // 序列化回包并送入网络物理通道
            using var messageStream = new MemoryStream();
            ProtoBuf.Serializer.Serialize(messageStream, ackFrame);

            if (_wsClient != null && _wsClient.IsRunning)
            {
                _wsClient.Send(messageStream.ToArray());
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
            logger?.LogInformation("【服务注销】彻底销毁长连接网关，安全释放物理管道。");

            _messageSubscription?.Dispose();
            _disconnectionSubscription?.Dispose();
            _wsClient?.Dispose();
            _swapUrlSemaphore?.Dispose();
            _reconnectSemaphore?.Dispose();
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