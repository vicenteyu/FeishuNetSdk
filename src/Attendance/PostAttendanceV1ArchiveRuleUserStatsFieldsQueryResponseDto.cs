// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-24
// ************************************************************************
// <copyright file="PostAttendanceV1ArchiveRuleUserStatsFieldsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询归档报表表头 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 查询归档报表表头 响应体
/// <para>查询归档报表表头，对应后台假勤管理-考勤统计-报表-[归档报表](https://example.feishu.cn/people/workforce-management/manage/statistics/report)中一个归档报表的表头信息。归档报表支持引用系统报表，可设置归档时间和数据归档周期，并且支持根据部门/人员、国家/地区、人员类型、工作地点、职级、序列、职务进行人员圈选。</para>
/// <para>接口ID：7368679915980898306</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/archive_rule/user_stats_fields_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2farchive_rule%2fuser_stats_fields_query</para>
/// </summary>
public record PostAttendanceV1ArchiveRuleUserStatsFieldsQueryResponseDto
{
    /// <summary>
    /// <para>统计数据表头</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("archive_report_fields")]
    public ArchiveField[]? ArchiveReportFields { get; set; }

    /// <summary>
    /// <para>统计数据表头</para>
    /// </summary>
    public record ArchiveField
    {
        /// <summary>
        /// <para>字段编号</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// <para>字段名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：工号</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>表头名称层级路径</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("upper_titles")]
        public string[]? UpperTitles { get; set; }
    }
}
