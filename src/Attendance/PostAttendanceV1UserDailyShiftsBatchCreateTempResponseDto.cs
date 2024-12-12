// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-12
//
// Last Modified By : yxr
// Last Modified On : 2024-12-12
// ************************************************************************
// <copyright file="PostAttendanceV1UserDailyShiftsBatchCreateTempResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建或修改临时排班 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 创建或修改临时排班 响应体
/// <para>可在排班表上创建或修改临时班次，并用于排班。目前支持按日期对一位或多位人员进行排临时班次。</para>
/// <para>临时排班为付费功能，如需使用请联系您的客户经理。</para>
/// <para>接口ID：7446612629576892419</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/user_daily_shift/batch_create_temp</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_daily_shift%2fbatch_create_temp</para>
/// </summary>
public record PostAttendanceV1UserDailyShiftsBatchCreateTempResponseDto
{
    /// <summary>
    /// <para>临时班表信息列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("user_tmp_daily_shifts")]
    public UserTmpDailyShift[]? UserTmpDailyShifts { get; set; }

    /// <summary>
    /// <para>临时班表信息列表</para>
    /// </summary>
    public record UserTmpDailyShift
    {
        /// <summary>
        /// <para>考勤组 ID，可用于[按 ID 查询考勤组](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/group/get)</para>
        /// <para>必填：是</para>
        /// <para>示例值：6737202939523236110</para>
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; } = string.Empty;

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
        /// <para>示例值：20240120</para>
        /// </summary>
        [JsonPropertyName("date")]
        public int Date { get; set; }

        /// <summary>
        /// <para>班次名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：临时早班</para>
        /// </summary>
        [JsonPropertyName("shift_name")]
        public string ShiftName { get; set; } = string.Empty;

        /// <summary>
        /// <para>打卡规则</para>
        /// <para>必填：是</para>
        /// <para>最大长度：6</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("punch_time_simple_rules")]
        public PunchTimeSimpleRule[] PunchTimeSimpleRules { get; set; } = Array.Empty<PunchTimeSimpleRule>();

        /// <summary>
        /// <para>打卡规则</para>
        /// </summary>
        public record PunchTimeSimpleRule
        {
            /// <summary>
            /// <para>上班时间</para>
            /// <para>必填：是</para>
            /// <para>示例值：9：00</para>
            /// </summary>
            [JsonPropertyName("on_time")]
            public string OnTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>下班时间</para>
            /// <para>必填：是</para>
            /// <para>示例值：18：00</para>
            /// </summary>
            [JsonPropertyName("off_time")]
            public string OffTime { get; set; } = string.Empty;
        }
    }
}
