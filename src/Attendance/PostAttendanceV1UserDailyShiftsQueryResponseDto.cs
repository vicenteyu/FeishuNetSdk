// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAttendanceV1UserDailyShiftsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询排班表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 查询排班表 响应体
/// <para>支持查询多个用户的排班情况，注意此接口返回的是用户维度的排班结果，与页面功能并不对应。可以通过返回结果中的group_id查询考勤组[按 ID 查询考勤组](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/group/get) ，shift_id查询班次[按 ID 查询班次](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/shift/get) 。查询的时间跨度不能超过 30 天。</para>
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
        /// <para>考勤组 ID，可用于[按 ID 查询考勤组](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/group/get)</para>
        /// <para>必填：是</para>
        /// <para>示例值：6737202939523236110</para>
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; } = string.Empty;

        /// <summary>
        /// <para>班次 ID，可用于[按 ID 查询班次](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/shift/get)</para>
        /// <para>必填：是</para>
        /// <para>示例值：6753520403404030215</para>
        /// </summary>
        [JsonPropertyName("shift_id")]
        public string ShiftId { get; set; } = string.Empty;

        /// <summary>
        /// <para>月份，格式yyyyMM</para>
        /// <para>必填：是</para>
        /// <para>示例值：202101</para>
        /// </summary>
        [JsonPropertyName("month")]
        public int Month { get; set; }

        /// <summary>
        /// <para>用户 ID，与employee_type对应</para>
        /// <para>必填：是</para>
        /// <para>示例值：abd754f7</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>月内日期，最多31天</para>
        /// <para>必填：是</para>
        /// <para>示例值：21</para>
        /// </summary>
        [JsonPropertyName("day_no")]
        public int DayNo { get; set; }
    }
}
