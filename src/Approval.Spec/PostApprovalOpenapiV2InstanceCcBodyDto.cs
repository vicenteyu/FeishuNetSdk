using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 审批实例抄送 请求体
/// <para>:::html为了更好地提升接口文档的的易理解性，我们对文档进行了升级，请尽快迁移至[新版本>>](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/cc)通过接口可以将当前审批实例抄送给其他人。</para>
/// <para>接口ID：6907569743419523074</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-native-approval/cc-instance</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuADOzYjLwgzM24CM4MjN</para>
/// </summary>
public record PostApprovalOpenapiV2InstanceCcBodyDto
{
    /// <summary>
    /// <para>审批定义 code</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例 code</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("instance_code")]
    public string InstanceCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>发起抄送的人的 user_id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>发起抄送的人的 open_id，如果传了 user_id 则优先使用 user_id，二者不能同时为空</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("open_id")]
    public string? OpenId { get; set; }

    /// <summary>
    /// <para>被抄送人的 user_id 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("cc_user_ids")]
    public string[]? CcUserIds { get; set; }

    /// <summary>
    /// <para>被抄送人的 open_id 列表，与 cc_user_ids 不可同时为空</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("cc_open_ids")]
    public string[]? CcOpenIds { get; set; }

    /// <summary>
    /// <para>抄送留言</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("comment")]
    public string? Comment { get; set; }
}
