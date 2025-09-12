// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-26
//
// Last Modified By : yxr
// Last Modified On : 2024-06-26
// ************************************************************************
// <copyright file="GetAttendanceV1ShiftsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询所有班次 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 查询所有班次 响应体
/// <para>飞书人事管理后台中假勤设置-[班次配置](https://example.feishu.cn/people/workforce-management/setting/group/shifts)中的翻页查询所有班次功能，展示班次名称、打卡规则、弹性班次规则、休息规则等</para>
/// <para>接口ID：7098332552943681538</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/shift/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fshift%2flist</para>
/// </summary>
public record GetAttendanceV1ShiftsResponseDto : IPageableResponse<GetAttendanceV1ShiftsResponseDto.Shift>
{
    /// <inheritdoc/>
    [JsonIgnore]
    public Shift[]? Items => ShiftLists;

    /// <summary>
    /// <para>班次列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("shift_list")]
    public Shift[]? ShiftLists { get; set; }

    /// <summary>
    /// <para>班次列表</para>
    /// </summary>
    public record Shift
    {
        /// <summary>
        /// <para>班次 ID</para>
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
        /// <para>弹性打卡时间，单位：分钟，设置【上班最多可晚到】与【下班最多可早走】时间，如果不设置flexible_rule则生效</para>
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
            /// <para>示例值：18:00</para>
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

            /// <summary>
            /// <para>true为需要打上班卡，false为不需要上班打卡。</para>
            /// <para>注意和接口创建时的区别：接口创建时，no_need_on传参false表示需要打上班卡，true为不需要打上班卡</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("no_need_on")]
            public bool? NoNeedOn { get; set; }

            /// <summary>
            /// <para>true为需要打下班卡，false为不需要下班打卡。</para>
            /// <para>注意和接口创建时的区别：接口创建时，no_need_off传参false表示需要打下班卡，true为不需要打下班卡</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("no_need_off")]
            public bool? NoNeedOff { get; set; }
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
            /// <para>休息开始</para>
            /// <para>必填：是</para>
            /// <para>示例值：13:00</para>
            /// </summary>
            [JsonPropertyName("rest_begin_time")]
            public string RestBeginTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>休息结束</para>
            /// <para>必填：是</para>
            /// <para>示例值：14:00</para>
            /// </summary>
            [JsonPropertyName("rest_end_time")]
            public string RestEndTime { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>加班时段（仅飞书人事企业版可用）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("overtime_rule")]
        public OvertimeRule[]? OvertimeRules { get; set; }

        /// <summary>
        /// <para>加班时段（仅飞书人事企业版可用）</para>
        /// </summary>
        public record OvertimeRule
        {
            /// <summary>
            /// <para>开始时间</para>
            /// <para>必填：是</para>
            /// <para>示例值：9:00</para>
            /// </summary>
            [JsonPropertyName("on_overtime")]
            public string OnOvertime { get; set; } = string.Empty;

            /// <summary>
            /// <para>结束时间</para>
            /// <para>必填：是</para>
            /// <para>示例值：18:00</para>
            /// </summary>
            [JsonPropertyName("off_overtime")]
            public string OffOvertime { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>日期类型，【是否弹性打卡 = ture】时，不可设置为“休息日” 可选值：1：工作日 2：休息日 示例值：（默认值）1</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("day_type")]
        public int? DayType { get; set; }

        /// <summary>
        /// <para>班外休息规则</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("overtime_rest_time_rule")]
        public RestRule[]? OvertimeRestTimeRules { get; set; }

        /// <summary>
        /// <para>晚到多久记为严重迟到，单位：分钟（优先级比原有字段高）</para>
        /// <para>必填：否</para>
        /// <para>示例值：40</para>
        /// </summary>
        [JsonPropertyName("late_minutes_as_serious_late")]
        public int? LateMinutesAsSeriousLate { get; set; }

        /// <summary>
        /// <para>半天分割规则（仅飞书人事企业版可用）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("shift_middle_time_rule")]
        public ShiftShiftMiddleTimeRule? ShiftMiddleTimeRule { get; set; }

        /// <summary>
        /// <para>半天分割规则（仅飞书人事企业版可用）</para>
        /// </summary>
        public record ShiftShiftMiddleTimeRule
        {
            /// <summary>
            /// <para>半天分割类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：按全天班次时长（含休息）的中点分割</item>
            /// <item>1：按全天班次时长（不含休息）的中点分割</item>
            /// <item>2：按休息时间分割</item>
            /// <item>3：按固定时间点分割</item>
            /// </list></para>
            /// <para>默认值：0</para>
            /// </summary>
            [JsonPropertyName("middle_time_type")]
            public int? MiddleTimeType { get; set; }

            /// <summary>
            /// <para>固定分割时间点（middle_time_type 为 3 时有效）</para>
            /// <para>必填：否</para>
            /// <para>示例值：12:00</para>
            /// </summary>
            [JsonPropertyName("fixed_middle_time")]
            public string? FixedMiddleTime { get; set; }
        }

        /// <summary>
        /// <para>晚走次日晚到配置规则</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("late_off_late_on_setting")]
        public ShiftLateOffLateOnSetting? LateOffLateOnSetting { get; set; }

        /// <summary>
        /// <para>晚走次日晚到配置规则</para>
        /// </summary>
        public record ShiftLateOffLateOnSetting
        {
            /// <summary>
            /// <para>当日晚走时间计算规则</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：弹性规则</item>
            /// <item>1：固定规则</item>
            /// </list></para>
            /// <para>默认值：0</para>
            /// </summary>
            [JsonPropertyName("late_off_base_on_time_type")]
            public int? LateOffBaseOnTimeType { get; set; }

            /// <summary>
            /// <para>次日晚到时间计算规则</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：固定规则</item>
            /// <item>1：弹性规则</item>
            /// </list></para>
            /// <para>默认值：0</para>
            /// </summary>
            [JsonPropertyName("late_on_base_on_time_type")]
            public int? LateOnBaseOnTimeType { get; set; }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：YrkvQ1wGaPVta45tkxuGiQ==</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
