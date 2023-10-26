using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 订阅审批事件 请求体
/// <para>为了更好地提升接口文档的的易理解性，我们对文档进行了升级，请尽快迁移至[新版本&gt;&gt;](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/subscribe)应用订阅 approval_code 后，该应用就可以收到该审批定义对应实例的事件通知。同一应用只需要订阅一次，无需重复订阅。</para>
/// <para>当应用不希望再收到审批事件时，可以使用取消订阅接口进行取消，取消后将不再给应用推送消息。</para>
/// <para>订阅和取消订阅都是应用维度的，多个应用可以同时订阅同一个 approval_code，每个应用都能收到审批事件。</para>
/// <para>接口ID：6907569742384922626</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-native-approval/subscribe-to-an-approvals-event-</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fucDOyUjL3gjM14yN4ITN</para>
/// </summary>
public record PostApprovalOpenapiV2SubscriptionSubscribeBodyDto
{
    /// <summary>
    /// <para>审批定义唯一标识</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;
}
