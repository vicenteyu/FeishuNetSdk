// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetAttendanceV1ShiftsByShiftIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>按 ID 查询班次 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 按 ID 查询班次 响应体
/// <para>通过班次 ID 获取班次详情。对应功能为假勤设置-[班次设置](https://example.feishu.cn/people/workforce-management/setting/group/shifts)班次列表中的具体班次，班次信息可以点击班次名称查看</para>
/// <para>接口ID：7044467124773486593</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/shift/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fshift%2fget</para>
/// </summary>
public record GetAttendanceV1ShiftsByShiftIdResponseDto
{
    /// <summary>
    /// <para>班次 ID，对应入参中的班次ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：6919358778597097404</para>
    /// </summary>
    [JsonPropertyName("shift_id")]
    public string ShiftId { get; set; } = string.Empty;

    /// <summary>
    /// <para>班次名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：早班</para>
    /// </summary>
    [JsonPropertyName("shift_name")]
    public string ShiftName { get; set; } = string.Empty;

    /// <summary>
    /// <para>打卡次数</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("punch_times")]
    public int PunchTimes { get; set; }

    /// <summary>
    /// <para>无效字段，请勿使用</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sub_shift_leader_ids")]
    public string[]? SubShiftLeaderIds { get; set; }

    /// <summary>
    /// <para>是否弹性打卡</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("is_flexible")]
    public bool? IsFlexible { get; set; }

    /// <summary>
    /// <para>弹性打卡时间,单位：分钟，设置【上班最多可晚到】与【下班最多可早走】时间，如果不设置flexible_rule则生效</para>
    /// <para>必填：否</para>
    /// <para>示例值：60</para>
    /// </summary>
    [JsonPropertyName("flexible_minutes")]
    public int? FlexibleMinutes { get; set; }

    /// <summary>
    /// <para>弹性打卡时间设置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("flexible_rule")]
    public FlexibleRule[]? FlexibleRules { get; set; }

    /// <summary>
    /// <para>弹性打卡时间设置</para>
    /// </summary>
    public record FlexibleRule
    {
        /// <summary>
        /// <para>下班最多可早走，单位：分钟（上班早到几分钟，下班可早走几分钟）</para>
        /// <para>必填：是</para>
        /// <para>示例值：60</para>
        /// </summary>
        [JsonPropertyName("flexible_early_minutes")]
        public int FlexibleEarlyMinutes { get; set; }

        /// <summary>
        /// <para>上班最多可晚到，单位：分钟（上班晚到几分钟，下班须晚走几分钟）</para>
        /// <para>必填：是</para>
        /// <para>示例值：60</para>
        /// </summary>
        [JsonPropertyName("flexible_late_minutes")]
        public int FlexibleLateMinutes { get; set; }
    }

    /// <summary>
    /// <para>不需要打下班卡</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("no_need_off")]
    public bool? NoNeedOff { get; set; }

    /// <summary>
    /// <para>打卡规则</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("punch_time_rule")]
    public PunchTimeRule[] PunchTimeRules { get; set; } = Array.Empty<PunchTimeRule>();

    /// <summary>
    /// <para>打卡规则</para>
    /// </summary>
    public record PunchTimeRule
    {
        /// <summary>
        /// <para>上班时间，格式为hh:mm</para>
        /// <para>必填：是</para>
        /// <para>示例值：9:00</para>
        /// </summary>
        [JsonPropertyName("on_time")]
        public string OnTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>下班时间，格式为hh:mm。如果是第二天凌晨2点， 则为26:00</para>
        /// <para>必填：是</para>
        /// <para>示例值：18:00， 第二天凌晨2点， 26:00</para>
        /// </summary>
        [JsonPropertyName("off_time")]
        public string OffTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>晚到多久记为迟到，单位：分钟</para>
        /// <para>必填：是</para>
        /// <para>示例值：30</para>
        /// </summary>
        [JsonPropertyName("late_minutes_as_late")]
        public int LateMinutesAsLate { get; set; }

        /// <summary>
        /// <para>晚到多久记为缺卡，单位：分钟</para>
        /// <para>必填：是</para>
        /// <para>示例值：60</para>
        /// </summary>
        [JsonPropertyName("late_minutes_as_lack")]
        public int LateMinutesAsLack { get; set; }

        /// <summary>
        /// <para>最早多久可打上班卡，单位：分钟</para>
        /// <para>必填：是</para>
        /// <para>示例值：60</para>
        /// </summary>
        [JsonPropertyName("on_advance_minutes")]
        public int OnAdvanceMinutes { get; set; }

        /// <summary>
        /// <para>早退多久记为早退，单位：分钟</para>
        /// <para>必填：是</para>
        /// <para>示例值：30</para>
        /// </summary>
        [JsonPropertyName("early_minutes_as_early")]
        public int EarlyMinutesAsEarly { get; set; }

        /// <summary>
        /// <para>早退多久记为缺卡，单位：分钟</para>
        /// <para>必填：是</para>
        /// <para>示例值：60</para>
        /// </summary>
        [JsonPropertyName("early_minutes_as_lack")]
        public int EarlyMinutesAsLack { get; set; }

        /// <summary>
        /// <para>最晚多久可打下班卡，单位：分钟</para>
        /// <para>必填：是</para>
        /// <para>示例值：60</para>
        /// </summary>
        [JsonPropertyName("off_delay_minutes")]
        public int OffDelayMinutes { get; set; }

        /// <summary>
        /// <para>晚到多久记为严重迟到，单位：分钟</para>
        /// <para>必填：否</para>
        /// <para>示例值：40</para>
        /// </summary>
        [JsonPropertyName("late_minutes_as_serious_late")]
        public int? LateMinutesAsSeriousLate { get; set; }
    }

    /// <summary>
    /// <para>晚走晚到规则（仅飞书人事企业版可用）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("late_off_late_on_rule")]
    public LateOffLateOnRule[]? LateOffLateOnRules { get; set; }

    /// <summary>
    /// <para>晚走晚到规则（仅飞书人事企业版可用）</para>
    /// </summary>
    public record LateOffLateOnRule
    {
        /// <summary>
        /// <para>晚走多久，单位：分钟</para>
        /// <para>必填：是</para>
        /// <para>示例值：60</para>
        /// </summary>
        [JsonPropertyName("late_off_minutes")]
        public int LateOffMinutes { get; set; }

        /// <summary>
        /// <para>晚到多久，单位：分钟</para>
        /// <para>必填：是</para>
        /// <para>示例值：30</para>
        /// </summary>
        [JsonPropertyName("late_on_minutes")]
        public int LateOnMinutes { get; set; }
    }

    /// <summary>
    /// <para>休息规则</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("rest_time_rule")]
    public RestRule[]? RestTimeRules { get; set; }

    /// <summary>
    /// <para>休息规则</para>
    /// </summary>
    public record RestRule
    {
        /// <summary>
        /// <para>休息开始，格式为mm:ss</para>
        /// <para>必填：是</para>
        /// <para>示例值：13:00</para>
        /// </summary>
        [JsonPropertyName("rest_begin_time")]
        public string RestBeginTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>休息结束，格式为mm:ss</para>
        /// <para>必填：是</para>
        /// <para>示例值：14:00</para>
        /// </summary>
        [JsonPropertyName("rest_end_time")]
        public string RestEndTime { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>加班规则（仅飞书人事企业版可用）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("overtime_rule")]
    public OvertimeRule[]? OvertimeRules { get; set; }

    /// <summary>
    /// <para>加班规则（仅飞书人事企业版可用）</para>
    /// </summary>
    public record OvertimeRule
    {
        /// <summary>
        /// <para>上班时间，格式为mm:ss</para>
        /// <para>必填：是</para>
        /// <para>示例值：9:00</para>
        /// </summary>
        [JsonPropertyName("on_overtime")]
        public string OnOvertime { get; set; } = string.Empty;

        /// <summary>
        /// <para>下班时间，格式为mm:ss</para>
        /// <para>必填：是</para>
        /// <para>示例值：18:00</para>
        /// </summary>
        [JsonPropertyName("off_overtime")]
        public string OffOvertime { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>是否允许在非打卡时段申请打卡</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("allow_punch_approval")]
    public bool? AllowPunchApproval { get; set; }
}
