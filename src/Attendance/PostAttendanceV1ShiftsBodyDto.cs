using Newtonsoft.Json;
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 创建班次 请求体
/// <para>班次是描述一次考勤任务时间规则的统称，比如一天打多少次卡，每次卡的上下班时间，晚到多长时间算迟到，晚到多长时间算缺卡等。</para>
/// <para>接口ID：7044467124773601281</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/shift/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fshift%2fcreate</para>
/// </summary>
public record PostAttendanceV1ShiftsBodyDto
{
    /// <summary>
    /// <para>班次名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：早班</para>
    /// </summary>
    [JsonProperty("shift_name")]
    public string ShiftName { get; set; } = string.Empty;

    /// <summary>
    /// <para>打卡次数</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonProperty("punch_times")]
    public int PunchTimes { get; set; }

    /// <summary>
    /// <para>排班组子负责人id列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("sub_shift_leader_ids")]
    public string[]? SubShiftLeaderIds { get; set; }

    /// <summary>
    /// <para>是否弹性打卡</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonProperty("is_flexible")]
    public bool? IsFlexible { get; set; }

    /// <summary>
    /// <para>弹性打卡时间，设置【上班最多可晚到】与【下班最多可早走】时间，如果不设置flexible_rule则生效</para>
    /// <para>必填：否</para>
    /// <para>示例值：60</para>
    /// </summary>
    [JsonProperty("flexible_minutes")]
    public int? FlexibleMinutes { get; set; }

    /// <summary>
    /// <para>弹性打卡时间设置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("flexible_rule")]
    public FlexibleRule[]? FlexibleRules { get; set; }

    /// <summary>
    /// <para>弹性打卡时间设置</para>
    /// </summary>
    public record FlexibleRule
    {
        /// <summary>
        /// <para>下班最多可早走（上班早到几分钟，下班可早走几分钟）</para>
        /// <para>必填：是</para>
        /// <para>示例值：60</para>
        /// </summary>
        [JsonProperty("flexible_early_minutes")]
        public int FlexibleEarlyMinutes { get; set; }

        /// <summary>
        /// <para>上班最多可晚到（上班晚到几分钟，下班须晚走几分钟）</para>
        /// <para>必填：是</para>
        /// <para>示例值：60</para>
        /// </summary>
        [JsonProperty("flexible_late_minutes")]
        public int FlexibleLateMinutes { get; set; }
    }

    /// <summary>
    /// <para>不需要打下班卡</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("no_need_off")]
    public bool? NoNeedOff { get; set; }

    /// <summary>
    /// <para>打卡规则</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("punch_time_rule")]
    public PunchTimeRule[] PunchTimeRules { get; set; } = Array.Empty<PunchTimeRule>();

    /// <summary>
    /// <para>打卡规则</para>
    /// </summary>
    public record PunchTimeRule
    {
        /// <summary>
        /// <para>上班时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：9:00</para>
        /// </summary>
        [JsonProperty("on_time")]
        public string OnTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>下班时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：18:00，第二天凌晨2点，26:00</para>
        /// </summary>
        [JsonProperty("off_time")]
        public string OffTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>晚到多久记为迟到</para>
        /// <para>必填：是</para>
        /// <para>示例值：30</para>
        /// </summary>
        [JsonProperty("late_minutes_as_late")]
        public int LateMinutesAsLate { get; set; }

        /// <summary>
        /// <para>晚到多久记为缺卡</para>
        /// <para>必填：是</para>
        /// <para>示例值：60</para>
        /// </summary>
        [JsonProperty("late_minutes_as_lack")]
        public int LateMinutesAsLack { get; set; }

        /// <summary>
        /// <para>最早多久可打上班卡</para>
        /// <para>必填：是</para>
        /// <para>示例值：60</para>
        /// </summary>
        [JsonProperty("on_advance_minutes")]
        public int OnAdvanceMinutes { get; set; }

        /// <summary>
        /// <para>早退多久记为早退</para>
        /// <para>必填：是</para>
        /// <para>示例值：30</para>
        /// </summary>
        [JsonProperty("early_minutes_as_early")]
        public int EarlyMinutesAsEarly { get; set; }

        /// <summary>
        /// <para>早退多久记为缺卡</para>
        /// <para>必填：是</para>
        /// <para>示例值：60</para>
        /// </summary>
        [JsonProperty("early_minutes_as_lack")]
        public int EarlyMinutesAsLack { get; set; }

        /// <summary>
        /// <para>最晚多久可打下班卡</para>
        /// <para>必填：是</para>
        /// <para>示例值：60</para>
        /// </summary>
        [JsonProperty("off_delay_minutes")]
        public int OffDelayMinutes { get; set; }

        /// <summary>
        /// <para>晚到多久记为严重迟到</para>
        /// <para>必填：否</para>
        /// <para>示例值：40</para>
        /// </summary>
        [JsonProperty("late_minutes_as_serious_late")]
        public int? LateMinutesAsSeriousLate { get; set; }
    }

    /// <summary>
    /// <para>晚走晚到规则</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("late_off_late_on_rule")]
    public LateOffLateOnRule[]? LateOffLateOnRules { get; set; }

    /// <summary>
    /// <para>晚走晚到规则</para>
    /// </summary>
    public record LateOffLateOnRule
    {
        /// <summary>
        /// <para>晚走多久</para>
        /// <para>必填：是</para>
        /// <para>示例值：60</para>
        /// </summary>
        [JsonProperty("late_off_minutes")]
        public int LateOffMinutes { get; set; }

        /// <summary>
        /// <para>晚到多久</para>
        /// <para>必填：是</para>
        /// <para>示例值：30</para>
        /// </summary>
        [JsonProperty("late_on_minutes")]
        public int LateOnMinutes { get; set; }
    }

    /// <summary>
    /// <para>休息规则</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("rest_time_rule")]
    public RestRule[]? RestTimeRules { get; set; }

    /// <summary>
    /// <para>休息规则</para>
    /// </summary>
    public record RestRule
    {
        /// <summary>
        /// <para>休息开始</para>
        /// <para>必填：是</para>
        /// <para>示例值：13:00</para>
        /// </summary>
        [JsonProperty("rest_begin_time")]
        public string RestBeginTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>休息结束</para>
        /// <para>必填：是</para>
        /// <para>示例值：14:00</para>
        /// </summary>
        [JsonProperty("rest_end_time")]
        public string RestEndTime { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>打卡规则</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("overtime_rule")]
    public OvertimeRule[]? OvertimeRules { get; set; }

    /// <summary>
    /// <para>打卡规则</para>
    /// </summary>
    public record OvertimeRule
    {
        /// <summary>
        /// <para>上班时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：9:00</para>
        /// </summary>
        [JsonProperty("on_overtime")]
        public string OnOvertime { get; set; } = string.Empty;

        /// <summary>
        /// <para>下班时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：18:00</para>
        /// </summary>
        [JsonProperty("off_overtime")]
        public string OffOvertime { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>是否允许在非打卡时段申请打卡</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonProperty("allow_punch_approval")]
    public bool? AllowPunchApproval { get; set; }
}
