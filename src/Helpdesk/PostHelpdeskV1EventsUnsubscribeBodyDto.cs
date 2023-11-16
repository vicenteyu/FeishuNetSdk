namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 取消订阅服务台事件 请求体
/// <para>本接口用于取消订阅服务台事件。</para>
/// <para>接口ID：6955768699896053762</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/event/unsubscribe</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fevent%2funsubscribe</para>
/// </summary>
public record PostHelpdeskV1EventsUnsubscribeBodyDto
{
    /// <summary>
    /// <para>event list to unsubscribe</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("events")]
    public Event[] Events { get; set; } = Array.Empty<Event>();

    /// <summary>
    /// <para>event list to unsubscribe</para>
    /// </summary>
    public record Event
    {
        /// <summary>
        /// <para>事件类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：helpdesk.ticket_message</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>事件子类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：ticket_message.created_v1</para>
        /// </summary>
        [JsonPropertyName("subtype")]
        public string Subtype { get; set; } = string.Empty;
    }
}
