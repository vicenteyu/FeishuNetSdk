// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-26
//
// Last Modified By : yxr
// Last Modified On : 2024-06-26
// ************************************************************************
// <copyright file="PostAttendanceV1UserTaskRemedysQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取补卡记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 获取补卡记录 请求体
/// <para>补卡：用户通过审批的方式，在某一次上/下班的打卡时间范围内，补充一条打卡记录，用以修正用户的考勤结果。本接口专用于获取员工的补卡记录（无页面功能对应）</para>
/// <para>接口ID：7044467124773666817</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_task_remedy/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_task_remedy%2fquery</para>
/// </summary>
public record PostAttendanceV1UserTaskRemedysQueryBodyDto
{
    /// <summary>
    /// <para>employee_no 或 employee_id 列表。传入的ID类型需要与employee_type的取值一致</para>
    /// <para>必填：是</para>
    /// <para>示例值：["abd754f7"]</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[] UserIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>查询的起始时间，精确到秒的时间戳</para>
    /// <para>必填：是</para>
    /// <para>示例值：1566641088</para>
    /// </summary>
    [JsonPropertyName("check_time_from")]
    public string CheckTimeFrom { get; set; } = string.Empty;

    /// <summary>
    /// <para>查询的结束时间，精确到秒的时间戳</para>
    /// <para>必填：是</para>
    /// <para>示例值：1592561088</para>
    /// </summary>
    [JsonPropertyName("check_time_to")]
    public string CheckTimeTo { get; set; } = string.Empty;

    /// <summary>
    /// <para>查询依据的时间类型（默认依据PeriodTime，如果使用非默认的，非特定租户不支持）</para>
    /// <para>必填：否</para>
    /// <para>示例值：PeriodTime</para>
    /// <para>可选值：<list type="bullet">
    /// <item>PeriodTime：单据作用时间</item>
    /// <item>CreateTime：单据创建时间（目前暂不支持）</item>
    /// <item>UpdateTime：单据状态更新时间（灰度中，暂不开放）</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("check_date_type")]
    public string? CheckDateType { get; set; }

    /// <summary>
    /// <para>查询状态（不填默认查询已通过状态）</para>
    /// <para>必填：否</para>
    /// <para>示例值：2</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：待审批</item>
    /// <item>1：未通过</item>
    /// <item>2：已通过</item>
    /// <item>3：已取消</item>
    /// <item>4：已撤回</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }
}
