namespace FeishuNetSdk.Helpdesk.Spec;
/// <summary>
/// 获取全部工单自定义字段 请求体
/// <para>该接口用于获取全部工单自定义字段。</para>
/// <para>接口ID：6955768699895955458</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket_customized_field/list-ticket-customized-fields</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket_customized_field%2flist-ticket-customized-fields</para>
/// </summary>
public record GetHelpdeskV1TicketCustomizedFieldsBodyDto
{
    /// <summary>
    /// <para>是否可见</para>
    /// <para>**示例值**：true</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("visible")]
    public bool? Visible { get; set; }
}
