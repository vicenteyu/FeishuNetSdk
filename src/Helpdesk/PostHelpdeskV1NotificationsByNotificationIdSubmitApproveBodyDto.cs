namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 提交审核 请求体
/// <para>正常情况下调用创建推送接口后，就可以调用提交审核接口，如果创建人是服务台owner则会自动审核通过，否则会通知服务台owner审核此推送信息。</para>
/// <para>接口ID：6999529163292508162</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/notification/submit_approve</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fnotification%2fsubmit_approve</para>
/// </summary>
public record PostHelpdeskV1NotificationsByNotificationIdSubmitApproveBodyDto
{
    /// <summary>
    /// <para>提交审批理由</para>
    /// <para>必填：是</para>
    /// <para>示例值：测试发送消息</para>
    /// </summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; } = string.Empty;
}
