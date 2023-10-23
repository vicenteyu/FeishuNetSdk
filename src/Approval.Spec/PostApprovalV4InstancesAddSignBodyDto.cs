using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 审批任务加签 请求体
/// <para>对于单个审批任务进行加签操作。</para>
/// <para>接口ID：6968270299335606273</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/task/approval-task-addsign</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukTM5UjL5ETO14SOxkTN%2fapproval-task-addsign</para>
/// </summary>
public record PostApprovalV4InstancesAddSignBodyDto
{
    /// <summary>
    /// <para>审批定义 Code</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例 Code</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("instance_code")]
    public string InstanceCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>操作用户</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>任务 ID</para>
    /// <para>审批实例详情task_list中id，详情请参考[](https://open.feishu.cn/document/ukTMukTMukTM/uEDNyUjLxQjM14SM0ITN)</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("task_id")]
    public string TaskId { get; set; } = string.Empty;

    /// <summary>
    /// <para>意见</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// <para>被加签人id</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("add_sign_user_ids")]
    public string[] AddSignUserIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>1/2/3分别代表前加签/后加签/并加签</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("add_sign_type")]
    public int AddSignType { get; set; }

    /// <summary>
    /// <para>仅在前加签、后加签时需要填写，1/2 分别代表或签/会签</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("approval_method")]
    public int? ApprovalMethod { get; set; }
}
