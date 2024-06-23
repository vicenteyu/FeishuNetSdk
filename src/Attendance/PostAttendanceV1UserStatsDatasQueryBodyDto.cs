// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAttendanceV1UserStatsDatasQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询统计数据 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 查询统计数据 请求体
/// <para>查询日度统计或月度统计的统计数据。</para>
/// <para>接口ID：7044467124773568513</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_stats_data/query-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_stats_data%2fquery</para>
/// </summary>
public record PostAttendanceV1UserStatsDatasQueryBodyDto
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
    /// <para>示例值：month</para>
    /// <para>可选值：<list type="bullet">
    /// <item>daily：日度统计</item>
    /// <item>month：月度统计</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("stats_type")]
    public string StatsType { get; set; } = string.Empty;

    /// <summary>
    /// <para>开始时间</para>
    /// <para>必填：是</para>
    /// <para>示例值：20210316</para>
    /// </summary>
    [JsonPropertyName("start_date")]
    public int StartDate { get; set; }

    /// <summary>
    /// <para>结束时间</para>
    /// <para>（时间间隔不超过 31 天）</para>
    /// <para>必填：是</para>
    /// <para>示例值：20210323</para>
    /// </summary>
    [JsonPropertyName("end_date")]
    public int EndDate { get; set; }

    /// <summary>
    /// <para>查询的用户 ID 列表</para>
    /// <para>（用户数量不超过 200）</para>
    /// <para>* 必填字段(已全部升级到新系统，新系统要求必填)</para>
    /// <para>必填：否</para>
    /// <para>示例值：["ec8ddg56","4dbb52f2","4167842e"]</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[]? UserIds { get; set; }

    /// <summary>
    /// <para>是否需要历史数据</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("need_history")]
    public bool? NeedHistory { get; set; }

    /// <summary>
    /// <para>只展示当前考勤组</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("current_group_only")]
    public bool? CurrentGroupOnly { get; set; }

    /// <summary>
    /// <para>操作者的 user_id。</para>
    /// <para>* 不同的操作者（管理员）的每个报表可能有不同的字段设置，系统将根据 user_id 查询指定报表的统计数据。</para>
    /// <para>* 必填字段（已全部升级到新系统，新系统要求该字段必填）。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ec8ddg56</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }
}
