namespace FeishuNetSdk.Attendance;
/// <summary>
/// 查询排班表 响应体
/// <para>支持查询多个用户的排班情况，查询的时间跨度不能超过 30 天。</para>
/// <para>接口ID：7044467124773552129</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_daily_shift/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_daily_shift%2fquery</para>
/// </summary>
public record PostAttendanceV1UserDailyShiftsQueryResponseDto
{
    /// <summary>
    /// <para>班表信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_daily_shifts")]
    public UserDailyShift[]? UserDailyShifts { get; set; }

    /// <summary>
    /// <para>班表信息列表</para>
    /// </summary>
    public record UserDailyShift
    {
        /// <summary>
        /// <para>考勤组 ID，获取方式：1）[创建或修改考勤组](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/group/create) 2）[按名称查询考勤组](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/group/search) 3）[获取打卡结果](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/user_task/query)</para>
        /// <para>必填：是</para>
        /// <para>示例值：6737202939523236110</para>
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; } = string.Empty;

        /// <summary>
        /// <para>班次 ID，获取方式：1）[按名称查询班次](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/shift/query) 2）[创建班次](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/shift/create)</para>
        /// <para>必填：是</para>
        /// <para>示例值：6753520403404030215</para>
        /// </summary>
        [JsonPropertyName("shift_id")]
        public string ShiftId { get; set; } = string.Empty;

        /// <summary>
        /// <para>月份</para>
        /// <para>必填：是</para>
        /// <para>示例值：202101</para>
        /// </summary>
        [JsonPropertyName("month")]
        public int Month { get; set; }

        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：abd754f7</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>日期</para>
        /// <para>必填：是</para>
        /// <para>示例值：21</para>
        /// </summary>
        [JsonPropertyName("day_no")]
        public int DayNo { get; set; }
    }
}
