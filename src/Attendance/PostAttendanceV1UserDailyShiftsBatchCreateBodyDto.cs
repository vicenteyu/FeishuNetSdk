// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAttendanceV1UserDailyShiftsBatchCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建或修改排班表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 创建或修改排班表 请求体
/// <para>排班表是用来描述考勤组内人员每天按哪个班次进行上班。目前排班表支持按一个整月对一位或多位人员进行排班。当用户的排班数据不存在时会进行创建，当用户的排班数据存在时会按照入参信息进行修改。注意：每人每天只能在一个考勤组中。</para>
/// <para>接口ID：7044467124773388289</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_daily_shift/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_daily_shift%2fbatch_create</para>
/// </summary>
public record PostAttendanceV1UserDailyShiftsBatchCreateBodyDto
{
    /// <summary>
    /// <para>排班表信息列表（数量限制50以内）</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("user_daily_shifts")]
    public UserDailyShift[] UserDailyShifts { get; set; } = Array.Empty<UserDailyShift>();

    /// <summary>
    /// <para>排班表信息列表（数量限制50以内）</para>
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
        /// <para>班次 ID，获取方式：1）[按名称查询班次](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/shift/query) 2）[创建班次](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/shift/create)。传入0代表休息。</para>
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
        /// <para>日期</para>
        /// <para>必填：是</para>
        /// <para>示例值：21</para>
        /// </summary>
        [JsonPropertyName("day_no")]
        public int DayNo { get; set; }
    }

    /// <summary>
    /// <para>操作人uid，与employee_type对应。如果您未操作[考勤管理后台“API 接入”流程](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/attendance-development-guidelines)，则此字段为必填字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：dd31248a</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public string? OperatorId { get; set; }
}
