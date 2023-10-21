using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 拒绝审批任务 请求体
/// <para>对于单个审批任务进行拒绝操作。拒绝后审批流程结束。</para>
/// <para>接口ID：7114621541589762051</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/task/reject</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2freject</para>
/// </summary>
public record PostApprovalV4TasksRejectBodyDto
{
    /// <summary>
    /// <para>审批定义 Code</para>
    /// <para>**示例值**："7C468A54-8745-2245-9675-08B7C63E7A85"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例 Code</para>
    /// <para>**示例值**："81D31358-93AF-92D6-7425-01A5D67C4E71"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("instance_code")]
    public string InstanceCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>根据user_id_type填写操作用户id</para>
    /// <para>**示例值**："f7cb567e"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>意见</para>
    /// <para>**示例值**："OK"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// <para>任务 ID， 审批实例详情task_list中id</para>
    /// <para>**示例值**："12345"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("task_id")]
    public string TaskId { get; set; } = string.Empty;
}
