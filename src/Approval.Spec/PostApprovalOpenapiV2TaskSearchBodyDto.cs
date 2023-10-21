using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 任务列表查询 请求体
/// <para>:::html为了更好地提升接口文档的的易理解性，我们对文档进行了升级，请尽快迁移至[新版本>>](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/task/search)该接口通过不同条件查询审批系统中符合条件的审批任务列表</para>
/// <para>接口ID：6907568073252241410</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/approval-search/task-list-query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYjMxYjL2ITM24iNyEjN</para>
/// </summary>
public record PostApprovalOpenapiV2TaskSearchBodyDto
{
    /// <summary>
    /// <para>用户 id</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批定义 code</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("approval_code")]
    public string? ApprovalCode { get; set; }

    /// <summary>
    /// <para>审批实例 code</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("instance_code")]
    public string? InstanceCode { get; set; }

    /// <summary>
    /// <para>审批实例第三方 id<br>注：和 approval_code 取并集</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("instance_external_id")]
    public string? InstanceExternalId { get; set; }

    /// <summary>
    /// <para>审批定义分组第三方 id<br>注：和 instance_code 取并集</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("group_external_id")]
    public string? GroupExternalId { get; set; }

    /// <summary>
    /// <para>审批任务标题（只有第三方审批有）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("task_title")]
    public string? TaskTitle { get; set; }

    /// <summary>
    /// <para>审批任务状态<br>PENDING:   审批中<br>APPROVED:   通过<br>REJECTED:   拒绝<br>TRANSFERRED:转交<br> DONE:      已完成<br>RM_REPEAT:  去重<br> PROCESSED:  已处理<br>注：若不设置，查询全部状态<br>若不在集合中，报错</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("task_status")]
    public string? TaskStatus { get; set; }

    /// <summary>
    /// <para>任务查询开始时间 (unix毫秒时间戳)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("task_start_time_from")]
    public int? TaskStartTimeFrom { get; set; }

    /// <summary>
    /// <para>任务查询结束时间 (unix毫秒时间戳)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("task_start_time_to")]
    public int? TaskStartTimeTo { get; set; }

    /// <summary>
    /// <para>地区（zh-CN、en-US、ja-JP）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("locale")]
    public string? Locale { get; set; }

    /// <summary>
    /// <para>查询偏移量<br>注：不得超过10000</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("offset")]
    public int? Offset { get; set; }

    /// <summary>
    /// <para>查询限制量<br>注：不得超过200<br>不设置默认查询10条数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("limit")]
    public int? Limit { get; set; }
}
