namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 发送工单消息 响应体
/// <para>该接口用于发送工单消息。</para>
/// <para>接口ID：6955768699895758850</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket-message/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket-message%2fcreate</para>
/// </summary>
public record PostHelpdeskV1TicketsByTicketIdMessagesResponseDto
{
    /// <summary>
    /// <para>chat消息open ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：om_8baa3656c7b41900d29bf9104bf5310b</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }
}
