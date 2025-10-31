// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-29
//
// Last Modified By : yxr
// Last Modified On : 2025-10-29
// ************************************************************************
// <copyright file="AttendanceUserTaskUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>用户任务状态变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance.Events;

/// <summary>
/// 用户任务状态变更 事件体
/// </summary>
public record AttendanceUserTaskUpdatedV1EventBodyDto() : EventBodyDto("attendance.user_task.updated_v1")
{
    /// <summary>
    /// 日期，格式为yyyyMMdd
    /// </summary>
    [JsonPropertyName("date")]
    public int Date { get; set; }

    /// <summary>
    /// 飞书管理后台 > 组织架构 > 成员与部门 > 成员详情中的用户 ID
    /// </summary>
    [JsonPropertyName("employee_id")]
    public string? EmployeeId { get; set; }

    /// <summary>
    /// 飞书管理后台 > 组织架构 > 成员与部门 > 成员详情中的工号
    /// </summary>
    [JsonPropertyName("employee_no")]
    public string? EmployeeNo { get; set; }

    /// <summary>
    /// 考勤组 ID，可用于按 ID 查询考勤组
    /// </summary>
    [JsonPropertyName("group_id")]
    public string? GroupId { get; set; }

    /// <summary>
    /// 班次 ID，可用于按 ID 查询班次
    /// </summary>
    [JsonPropertyName("shift_id")]
    public string? ShiftId { get; set; }

    /// <summary>
    /// 状态变更数组
    /// </summary>
    [JsonPropertyName("status_changes")]
    public StatusItem[] StatusChanges { get; set; } = [];

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("time_zone")]
    public string? TimeZone { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    public record StatusItem
    {
        /// <summary>
        /// 变更前打卡结果，值为：【NoNeedCheck（无需打卡），SystemCheck（系统打卡），Normal（正常），Early（早退），Late（迟到），Lack（缺卡）】
        /// </summary>
        [JsonPropertyName("before_status")]
        public string? BeforeStatus { get; set; }

        /// <summary>
        /// 变更前结果补充，值为：【None（无），ManagerModification（管理员修改），CardReplacement（补卡通过），ShiftChange（换班），Travel（出差），Leave（请假），GoOut（外出），CardReplacementApplication（补卡申请中），FieldPunch（外勤打卡）】
        /// </summary>
        [JsonPropertyName("before_supplement")]
        public string? BeforeSupplement { get; set; }

        /// <summary>
        /// 变更后打卡结果，值为：【NoNeedCheck（无需打卡），SystemCheck（系统打卡），Normal（正常），Early（早退），Late（迟到），Lack（缺卡）】
        /// </summary>
        [JsonPropertyName("current_status")]
        public string? CurrentStatus { get; set; }

        /// <summary>
        /// 变更后打卡结果补充，值为：【None（无），ManagerModification（管理员修改），CardReplacement（补卡通过），ShiftChange（换班），Travel（出差），Leave（请假），GoOut（外出），CardReplacementApplication（补卡申请中），FieldPunch（外勤打卡）】
        /// </summary>
        [JsonPropertyName("current_supplement")]
        public string? CurrentSupplement { get; set; }

        /// <summary>
        /// 任务中的第几次上下班
        /// </summary>
        [JsonPropertyName("index")]
        public int Index { get; set; }

        /// <summary>
        /// 上下班状态变更，值为：【on（上班），off（下班）】
        /// </summary>
        [JsonPropertyName("work_type")]
        public string? WorkType { get; set; }
    }
}