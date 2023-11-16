namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 取消订阅审批事件 请求体
/// <para>为了更好地提升接口文档的的易理解性，我们对文档进行了升级，请尽快迁移至[新版本&gt;&gt;](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/unsubscribe)取消订阅 approval_code 后，无法再收到该审批定义对应实例的事件通知。</para>
/// <para>接口ID：6907569524100546561</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-native-approval/cancel-a-subscription-to-an-approvals-event</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugDOyUjL4gjM14CO4ITN</para>
/// </summary>
public record PostApprovalOpenapiV2SubscriptionUnsubscribeBodyDto
{
    /// <summary>
    /// <para>审批定义唯一标识</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;
}
