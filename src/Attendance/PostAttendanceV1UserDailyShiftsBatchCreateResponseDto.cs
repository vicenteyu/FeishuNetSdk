// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-20
// ************************************************************************
// <copyright file="PostAttendanceV1UserDailyShiftsBatchCreateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建或修改排班表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 创建或修改排班表 响应体
/// <para>排班表是用来描述考勤组内人员每天按哪个班次进行上班。目前排班表支持按x月y日对一位或多位人员进行排班。当用户的排班数据不存在时会进行创建，当用户的排班数据存在时会按照入参信息进行修改。注意：每人每天只能在一个考勤组中。</para>
/// <para>接口ID：7044467124773388289</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_daily_shift/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_daily_shift%2fbatch_create</para>
/// </summary>
public record PostAttendanceV1UserDailyShiftsBatchCreateResponseDto
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
        /// <para>月份</para>
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
        /// <para>日期</para>
        /// <para>必填：是</para>
        /// <para>示例值：21</para>
        /// </summary>
        [JsonPropertyName("day_no")]
        public int DayNo { get; set; }

        /// <summary>
        /// <para>是否清空班次 (此字段优先于 shift_id，若为true ，shift_id 将失效)</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_clear_schedule")]
        public bool? IsClearSchedule { get; set; }
    }
}
