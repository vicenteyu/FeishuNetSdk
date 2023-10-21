using Newtonsoft.Json;
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 订阅服务台事件 请求体
/// <para>本接口用于订阅服务台事件。</para>
/// <para>接口ID：6955768699895873538</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/event/subscribe</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fevent%2fsubscribe</para>
/// </summary>
public record PostHelpdeskV1EventsSubscribeBodyDto
{
    /// <summary>
    /// <para>可订阅的事件列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("events")]
    public Event[] Events { get; set; } = Array.Empty<Event>();

    /// <summary>
    /// <para>可订阅的事件列表</para>
    /// </summary>
    public record Event
    {
        /// <summary>
        /// <para>事件类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：helpdesk.ticket_message</para>
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>事件子类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：ticket_message.created_v1</para>
        /// </summary>
        [JsonProperty("subtype")]
        public string Subtype { get; set; } = string.Empty;
    }
}
