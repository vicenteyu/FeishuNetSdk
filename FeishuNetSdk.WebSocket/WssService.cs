// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-07
//
// Last Modified By : yxr
// Last Modified On : 2025-08-27
// ************************************************************************
// <copyright file="WssService.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>启用长连接服务</summary>
// ************************************************************************
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using WatsonWebsocket;

namespace FeishuNetSdk.WebSocket
{
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
    /// <para>长连接模式的消息推送为 集群模式，不支持广播，即如果同一应用部署了多个客户端（client），那么只有其中随机一个客户端会收到消息。</para>
    /// <para>如果同一应用部署了多个客户端（client），那么只有其中随机一个客户端会收到消息。</para>
    /// <para>如果同一应用部署了多个客户端（client），那么只有其中随机一个客户端会收到消息。</para>
    /// <para>务必注意：仅建议在测试环境使用长连接模式，不当使用则可能导致正式环境的事件消息被误收！！！</para>
    /// </summary>
    public class WssService(
        IFeishuApi feishuApi,
        IOptionsMonitor<FeishuNetSdkOptions> options,
        ILogger<WssService> logger,
        Services.IEventCallbackServiceProvider eventCallback)
        : BackgroundService
    {
        private readonly Lock _clientLock = new();
        private WatsonWsClient? _wsClient;
        private int _reconnectAttempts = 0;
        private const int MaxReconnectAttempts = 10;
        private const int ReconnectInterval = 5000;
        private CancellationTokenSource? _messageProcessingCts;
        private static readonly JsonSerializerOptions serializerOptions = new()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
        /// <summary>
        /// 服务启动
        /// </summary>
        /// <param name="stoppingToken"></param>
        /// <returns></returns>
        protected override async System.Threading.Tasks.Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // 创建与 stoppingToken 联动的取消令牌源
            _messageProcessingCts = CancellationTokenSource.CreateLinkedTokenSource(stoppingToken);
            await StartConnectAsync(stoppingToken);
        }
        /// <summary>
        /// 服务停止
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override async System.Threading.Tasks.Task StopAsync(CancellationToken cancellationToken)
        {
            // 安全释放资源：先取消消息处理，再关闭连接
            lock (_clientLock)
            {
                if (_wsClient != null)
                {
                    _wsClient.ServerConnected -= ServerConnected;
                    _wsClient.ServerDisconnected -= ServerDisconnected;
                    _wsClient.MessageReceived -= MessageReceived;
                }
            }
            // 原子释放取消令牌源
            var cts = _messageProcessingCts;
            _messageProcessingCts = null;
            cts?.Cancel();
            cts?.Dispose();
            // 关闭 WebSocket 连接
            if (_wsClient?.Connected == true)
            {
                await _wsClient.StopAsync();
            }
            _wsClient?.Dispose();
            _wsClient = null;
            await base.StopAsync(cancellationToken);
        }
        private async Task<string> GetWssEndpointAsync(CancellationToken stoppingToken)
        {
            try
            {
                var result = await feishuApi.PostCallbackWsEndpointAsync(new()
                {
                    AppId = options.CurrentValue.AppId,
                    AppSecret = options.CurrentValue.AppSecret
                }, stoppingToken);
                if (result?.IsSuccess != true || string.IsNullOrEmpty(result?.Data?.Url))
                    throw new InvalidOperationException(result?.Msg ?? "获取 WSS 端点失败");
                return result.Data.Url;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "获取 WSS 端点时出现异常");
                throw;
            }
        }
        private async System.Threading.Tasks.Task StartConnectAsync(CancellationToken stoppingToken)
        {
            try
            {
                var endpoint = await GetWssEndpointAsync(stoppingToken);
                var newClient = new WatsonWsClient(new Uri(endpoint));

                // 订阅新客户端事件
                newClient.ServerConnected += ServerConnected;
                newClient.ServerDisconnected += ServerDisconnected;
                newClient.MessageReceived += MessageReceived;
                newClient.Logger = s =>
                {
                    if (logger.IsEnabled(LogLevel.Information))
                        logger.LogInformation("WsClient 消息：{s}", s);
                };
                // 线程安全替换客户端
                lock (_clientLock)
                {
                    _wsClient?.Dispose(); // 释放旧客户端
                    _wsClient = newClient;
                }
                await newClient.StartAsync();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "启动连接时出现异常");
                await TryReconnectAsync(stoppingToken);
            }
        }

        private async void MessageReceived(object? sender, MessageReceivedEventArgs e)
        {
            if (sender is not WatsonWsClient client || e.Data.Count == 0) return;
            // 复制数据避免事件参数生命周期问题
            var dataCopy = new byte[e.Data.Count];
            e.Data.CopyTo(dataCopy);
            var dataSegment = new ArraySegment<byte>(dataCopy);
            // 获取当前有效的取消令牌
            var cts = _messageProcessingCts;
            var cancellationToken = cts?.Token ?? CancellationToken.None;
            try
            {
                await ProcessMessageAsync(client, dataSegment, cancellationToken);
            }
            catch (OperationCanceledException)
            {
                logger.LogInformation("消息处理已取消");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "处理消息时出现异常");
            }
        }

        private async System.Threading.Tasks.Task ProcessMessageAsync(WatsonWsClient client, ArraySegment<byte> data, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            // 反序列化消息帧
            var frame = ProtoBuf.Serializer.Deserialize<Frame>(data.AsSpan());
            if (frame == null)
            {
                if (logger.IsEnabled(LogLevel.Error))
                    logger.LogError("消息帧反序列化失败，数据长度：{Length}", data.Count);
                return;
            }
            // 处理业务逻辑
            var inJson = frame.PayloadToJson() ?? throw new InvalidDataException("消息 payload 为空");

            if (logger.IsEnabled(LogLevel.Debug))
                logger.LogDebug("WSS收到的入参：{json}", inJson);

            var result = await eventCallback.HandleAsync(inJson, cancellationToken);

            if (!result.Success)
            {
                if (logger.IsEnabled(LogLevel.Debug))
                    logger.LogDebug("WSS收到的处理结果：{error}", result.Error);
                return;
            }

            var dto_string = JsonSerializer.Serialize(result.Dto, serializerOptions);
            var dto_bytes = Encoding.UTF8.GetBytes(dto_string);
            var dto_response_body = new { code = 200, data = result.Dto == null ? null : dto_bytes };
            // 构建响应消息
            var responseJson = JsonSerializer.Serialize(dto_response_body, serializerOptions);

            if (logger.IsEnabled(LogLevel.Debug))
                logger.LogDebug("WSS 出参：{json}", responseJson);

            cancellationToken.ThrowIfCancellationRequested();
            // 发送响应
            using var messageStream = new MemoryStream();
            frame.Payload = Encoding.UTF8.GetBytes(responseJson);
            ProtoBuf.Serializer.Serialize(messageStream, frame);

            if (messageStream.TryGetBuffer(out var arraySegment))
            {
                try
                {
                    await client.SendAsync(arraySegment, System.Net.WebSockets.WebSocketMessageType.Binary, cancellationToken);
                }
                catch when (cancellationToken.IsCancellationRequested)
                {
                    logger.LogError("消息被取消发送");
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "发送响应消息时出现异常");
                }
            }
        }

        private async void ServerDisconnected(object? sender, EventArgs e)
        {
            if (logger.IsEnabled(LogLevel.Warning))
                logger.LogWarning("长连接已断开，尝试第 {Attempt} 次重连（间隔 {Interval}ms）", _reconnectAttempts + 1, ReconnectInterval);
            var cts = _messageProcessingCts;
            await TryReconnectAsync(cts?.Token ?? CancellationToken.None);
        }

        private void ServerConnected(object? sender, EventArgs e)
        {
            logger.LogInformation("长连接已成功建立");
            _reconnectAttempts = 0; // 重置重连计数器
        }

        private async System.Threading.Tasks.Task TryReconnectAsync(CancellationToken stoppingToken)
        {
            if (_reconnectAttempts >= MaxReconnectAttempts)
            {
                if (logger.IsEnabled(LogLevel.Error))
                    logger.LogError("已达最大重连次数 ({Max})，停止重连", MaxReconnectAttempts);
                return;
            }
            _reconnectAttempts++;
            try
            {
                // 延迟重连，支持外部取消
                await System.Threading.Tasks.Task.Delay(ReconnectInterval, stoppingToken);
                await StartConnectAsync(stoppingToken);
            }
            catch (OperationCanceledException)
            {
                logger.LogError("重连过程被取消（服务可能正在停止）");
            }
        }
    }
}
