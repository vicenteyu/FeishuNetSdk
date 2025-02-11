// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-07
//
// Last Modified By : yxr
// Last Modified On : 2024-09-07
// ************************************************************************
// <copyright file="WssService.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>启用长连接服务</summary>
// ************************************************************************
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ProtoBuf;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using WatsonWebsocket;
using WebApiClientCore.Extensions.OAuths.Exceptions;

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
    public class WssService(IFeishuApi feishuApi, IOptionsMonitor<FeishuNetSdkOptions> options, ILogger<WssService> logger, Services.IEventCallbackServiceProvider eventCallback) : BackgroundService
    {
        private WatsonWsClient? _wsClient = null;

        private static readonly JsonSerializerOptions serializerOptions = new()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        /// <summary>
        /// 执行长连接
        /// </summary>
        protected override async System.Threading.Tasks.Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await StartConnectAsync();
        }

        /// <summary>
        /// 服务停止
        /// </summary>
        public override async System.Threading.Tasks.Task StopAsync(CancellationToken cancellationToken)
        {
            if (_wsClient?.Connected == true)
            {
                await _wsClient.StopAsync();
            }
            await base.StopAsync(cancellationToken);
        }

        private async Task<string> GetWssEndpointAsync()
        {
            var result = await feishuApi.PostCallbackWsEndpointAsync(new()
            {
                AppId = options.CurrentValue.AppId,
                AppSecret = options.CurrentValue.AppSecret
            });

            if (result?.IsSuccess != true || result?.Data?.Url == null)
                throw new TokenException(result?.Msg ?? "长连接出现异常");

            return result.Data.Url;
        }

        private async System.Threading.Tasks.Task StartConnectAsync()
        {
            var endpoint = await GetWssEndpointAsync();

            _wsClient = new WatsonWsClient(new Uri(endpoint));
            _wsClient.ServerConnected += ServerConnected;
            _wsClient.ServerDisconnected += ServerDisconnected;
            _wsClient.MessageReceived += MessageReceived;
            _wsClient.Logger = (string s) => { logger.LogInformation("{s}", s); };

            await _wsClient.StartAsync();
        }

        private async void MessageReceived(object? sender, MessageReceivedEventArgs e)
        {
            if (sender is WatsonWsClient client && e.Data.Count > 0)
            {
                var frame = Serializer.Deserialize<Frame>(e.Data.AsSpan());

                var inJson = frame?.PayloadToJson() ?? throw new Exception("无法序列化消息");
                logger.LogDebug("入参：{json}", inJson);

                try
                {
                    var result = await eventCallback.HandleAsync(inJson);
                    if (result.Success != true)
                    {
                        logger.LogError("{error}", result?.Error);
                        return;
                    }

                    var outJson = JsonSerializer.Serialize(new
                    {
                        code = 200,
                        data = result.Dto is null
                            ? null
                            : Encoding.UTF8.GetBytes(JsonSerializer.Serialize(result.Dto, serializerOptions))
                    }, serializerOptions);

                    logger.LogDebug("出参：{json}", outJson);

                    using var messageStream = new MemoryStream();
                    frame.Payload = Encoding.UTF8.GetBytes(outJson);
                    Serializer.Serialize(messageStream, frame);
                    if (messageStream.TryGetBuffer(out var arraySegment))
                    {
                        await client.SendAsync(arraySegment, System.Net.WebSockets.WebSocketMessageType.Binary);
                    }
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "事件执行异常");
                }
            }
        }

        private async void ServerDisconnected(object? sender, EventArgs e)
        {
            logger.LogInformation("长连接已断开");

            await StartConnectAsync();
        }

        private void ServerConnected(object? sender, EventArgs e)
        {
            logger.LogInformation("长连接已连接");
        }
    }
}
