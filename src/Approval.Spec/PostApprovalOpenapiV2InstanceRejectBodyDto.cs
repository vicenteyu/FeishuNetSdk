namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 审批任务拒绝 请求体
/// <para>为了更好地提升接口文档的的易理解性，我们对文档进行了升级，请尽快迁移至[新版本&gt;&gt;](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/task/reject)对于单个审批任务进行拒绝操作。拒绝后审批流程结束。</para>
/// <para>接口ID：6907569742384283650</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-native-approval/approval-task-reject</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQDNyUjL0QjM14CN0ITN</para>
/// </summary>
public record PostApprovalOpenapiV2InstanceRejectBodyDto
{
    /// <summary>
    /// <para>审批定义 Code</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例 Code</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string InstanceCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>用户open_id，如果没有user_id，必须要有open_id</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("open_id")]
    public string OpenId { get; set; } = string.Empty;

    /// <summary>
    /// <para>操作用户</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>任务 ID</para>
    /// <para>审批实例详情task_list中id，详情请参考[](https://open.feishu.cn/document/ukTMukTMukTM/uEDNyUjLxQjM14SM0ITN)</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string TaskId { get; set; } = string.Empty;

    /// <summary>
    /// <para>意见</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}
