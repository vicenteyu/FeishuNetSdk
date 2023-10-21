using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 重新提交审批任务 请求体
/// <para>对于单个退回到发起人的审批任务进行重新发起操作。发起后审批流程会流转到下一个审批人。</para>
/// <para>接口ID：7127897901158842396</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/task/resubmit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2fresubmit</para>
/// </summary>
public record PostApprovalV4TasksResubmitBodyDto
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
    /// <para>**示例值**："{\"text\":\"评论\",\"file_codes\":[\"ABCD1232s\",\"ABC12334d22\"]}"</para>
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

    /// <summary>
    /// <para>json 数组，控件值，同创建审批实例接口中form字段</para>
    /// <para>**示例值**："[{\"id\":\"user_name\", \"type\": \"input\", \"value\":\"test\"}]"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("form")]
    public string Form { get; set; } = string.Empty;
}
