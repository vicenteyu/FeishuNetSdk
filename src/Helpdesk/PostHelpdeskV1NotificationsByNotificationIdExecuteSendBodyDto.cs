using Newtonsoft.Json;
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 执行推送 请求体
/// <para>审核通过后调用此接口设置推送时间，等待调度系统调度，发送消息。</para>
/// <para>接口ID：6999529163292540930</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/notification/execute_send</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fnotification%2fexecute_send</para>
/// </summary>
public record PostHelpdeskV1NotificationsByNotificationIdExecuteSendBodyDto
{
    /// <summary>
    /// <para>发送时间戳(毫秒)</para>
    /// <para>必填：是</para>
    /// <para>示例值：1624326025000</para>
    /// </summary>
    [JsonProperty("send_at")]
    public string SendAt { get; set; } = string.Empty;
}
