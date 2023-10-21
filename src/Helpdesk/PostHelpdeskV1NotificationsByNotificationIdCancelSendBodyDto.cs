using Newtonsoft.Json;
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 取消推送 请求体
/// <para>取消推送接口，审核通过后待调度可以调用，发送过程中可以调用（会撤回已发送的消息），发送完成后可以需要推送（会撤回所有已发送的消息）。</para>
/// <para>接口ID：6999529163292557314</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/notification/cancel_send</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fnotification%2fcancel_send</para>
/// </summary>
public record PostHelpdeskV1NotificationsByNotificationIdCancelSendBodyDto
{
    /// <summary>
    /// <para>是否召回已发送的消息,新人入职消息同样适用</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("is_recall")]
    public bool IsRecall { get; set; }
}
