// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAttendanceV1UserStatsViewsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询统计设置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 查询统计设置 请求体
/// <para>查询考勤统计支持的日度统计或月度统计的统计表头。报表的表头信息可以在考勤统计-[报表](https://example.feishu.cn/people/workforce-management/manage/statistics/report)中查询到具体的报表信息，此接口专门用于查询表头数据。注意此接口和[查询统计表头](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/user_stats_field/query)基本相同，区别点在于在兼容历史统计视图模型（历史统计数据模型可以按用户ID设置，后续统计升级为仅支持租户维度）</para>
/// <para>接口ID：7044467124773830657</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_stats_data/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_stats_view%2fquery</para>
/// </summary>
public record PostAttendanceV1UserStatsViewsQueryBodyDto
{
    /// <summary>
    /// <para>语言类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：zh</para>
    /// <para>可选值：<list type="bullet">
    /// <item>en：英语</item>
    /// <item>ja：日语</item>
    /// <item>zh：中文</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("locale")]
    public string Locale { get; set; } = string.Empty;

    /// <summary>
    /// <para>统计类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：daily</para>
    /// <para>可选值：<list type="bullet">
    /// <item>daily：日度统计</item>
    /// <item>month：月度统计</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("stats_type")]
    public string StatsType { get; set; } = string.Empty;

    /// <summary>
    /// <para>操作者的用户id，对应employee_type</para>
    /// <para>* 必填字段(系统升级后，新系统要求必填)</para>
    /// <para>必填：否</para>
    /// <para>示例值：dd31248a</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }
}
