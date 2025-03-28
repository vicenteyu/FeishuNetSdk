// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-07
//
// Last Modified By : yxr
// Last Modified On : 2025-03-29
// ************************************************************************
// <copyright file="WorkApprovalEventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>加班审批 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Events;
/// <summary>
/// 加班审批 事件体
/// <para>审批定义的表单包含 **加班控件组** 时，该定义下的审批实例在 **通过** 或者 **通过并撤销** 时，会触发该事件。</para>
/// <para>接口ID：7013346140632629276</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/event/special-event/overtime</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDO24iM4YjLygjN%2fevent%2fovertime</para>
/// </summary>
public record WorkApprovalEventBodyDto() : EventBodyDto("work_approval")
{
    /// <summary>
    /// <para>是否存在多时段。可能值有：</para>
    /// <para> - 1：存在多时段</para>
    /// <para> - 0：不存在多时段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("allow_multi_time_range")]
    public int? AllowMultiTimeRange { get; set; }

    /// <summary>
    /// <para>应用的 App ID。可调用获取应用信息接口查询应用详细信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("app_id")]
    public string? AppId { get; set; }

    /// <summary>
    /// <para>审批定义 Code。可调用查看指定审批定义接口查询审批定义详情。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string? ApprovalCode { get; set; }

    /// <summary>
    /// <para>审批实例 Code。可调用获取单个审批实例详情接口查询审批实例详情。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string? InstanceCode { get; set; }

    /// <summary>
    /// <para>审批提交人的 user_id。你可以调用获取单个用户信息接口，通过 user_id 获取用户信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employee_id")]
    public string? EmployeeId { get; set; }

    /// <summary>
    /// <para>审批提交人的 open_id。你可以调用获取单个用户信息接口，通过 user_id 获取用户信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("open_id")]
    public string? OpenId { get; set; }

    /// <summary>
    /// <para>审批结束时间，秒级时间戳。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("end_time")]
    public int? EndTime { get; set; }

    /// <summary>
    /// <para>审批开始时间，秒级时间戳。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("start_time")]
    public int? StartTime { get; set; }

    /// <summary>
    /// <para>租户 Key，是企业的唯一标识。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tenant_key")]
    public string? TenantKey { get; set; }

    /// <summary>
    /// <para>多时段信息，参数 allow_multi_time_range 取值为 1 时该字段有返回值。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("time_range")]
    public TimeRangeSuffix[]? TimeRange { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record TimeRangeSuffix
    {
        /// <summary>
        /// <para>加班开始时间。示例格式：2018-12-01 12:00:00</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("work_start_time")]
        public string? WorkStartTime { get; set; }

        /// <summary>
        /// <para>加班结束时间。示例格式：2018-12-02 12:00:00</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("work_end_time")]
        public string? WorkEndTime { get; set; }
    }

    /// <summary>
    /// <para>事件类型。固定值 work_approval</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// <para>每日加班明细。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("work_detail")]
    public WorkDetailSuffix[]? WorkDetail { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record WorkDetailSuffix
    {
        /// <summary>
        /// <para>加班开始时间，仅精确到天。示例格式：2018-12-01 00:00</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("start")]
        public string? Start { get; set; }

        /// <summary>
        /// <para>加班结束时间，仅精确到天。示例格式：2018-12-01 00:00</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("end")]
        public string? End { get; set; }

        /// <summary>
        /// <para>加班类型。可能值有：</para>
        /// <para> - 0：无（未关联加班规则）</para>
        /// <para> - 1：调休假</para>
        /// <para> - 2：加班费</para>
        /// <para> - 3：无（已关联加班规则）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("rule_associated")]
        public int? RuleAssociated { get; set; }

        /// <summary>
        /// <para>每日加班时长。单位：秒</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("interval")]
        public int? Interval { get; set; }
    }

    /// <summary>
    /// <para>加班开始时间。示例格式：2018-12-01 12:00:00</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("work_start_time")]
    public string? WorkStartTime { get; set; }

    /// <summary>
    /// <para>加班结束时间。示例格式：2018-12-02 12:00:00</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("work_end_time")]
    public string? WorkEndTime { get; set; }

    /// <summary>
    /// <para>加班时长。单位：秒</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("work_interval")]
    public int? WorkInterval { get; set; }

    /// <summary>
    /// <para>代多人提交用户列表。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("work_multi_imitate_users")]
    public object[]? WorkMultiImitateUsers { get; set; }

    /// <summary>
    /// <para>加班事由。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("work_reason")]
    public string? WorkReason { get; set; }

    /// <summary>
    /// <para>加班类型。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("work_type")]
    public string? WorkType { get; set; }
}
