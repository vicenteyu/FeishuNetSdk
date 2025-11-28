// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAttendanceV1UserDailyShiftsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询排班表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 查询排班表 请求体
/// <para>支持查询多个用户的排班情况，注意此接口返回的是用户维度的排班结果，与页面功能并不对应。可以通过返回结果中的group_id查询考勤组[按 ID 查询考勤组](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/group/get) ，shift_id查询班次[按 ID 查询班次](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/shift/get) 。查询的时间跨度不能超过 30 天。</para>
/// <para>接口ID：7044467124773552129</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_daily_shift/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_daily_shift%2fquery</para>
/// </summary>
public record PostAttendanceV1UserDailyShiftsQueryBodyDto
{
    /// <summary>
    /// <para>employee_no 或 employee_id 列表，与employee_type对应。最多50人。</para>
    /// <para>必填：是</para>
    /// <para>示例值：["abd754f7"]</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[] UserIds { get; set; } = [];

    /// <summary>
    /// <para>查询的起始工作日，格式为yyyyMMdd</para>
    /// <para>必填：是</para>
    /// <para>示例值：20190817</para>
    /// </summary>
    [JsonPropertyName("check_date_from")]
    public int CheckDateFrom { get; set; }

    /// <summary>
    /// <para>查询的结束工作日，格式为yyyyMMdd</para>
    /// <para>必填：是</para>
    /// <para>示例值：20190820</para>
    /// </summary>
    [JsonPropertyName("check_date_to")]
    public int CheckDateTo { get; set; }
}
