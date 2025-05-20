// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-24
// ************************************************************************
// <copyright file="GetAttendanceV1ArchiveRuleResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询所有归档规则 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 查询所有归档规则 响应体
/// <para>查询所有归档规则，对应后台假勤管理-考勤统计-报表-[归档报表](https://example.feishu.cn/people/workforce-management/manage/statistics/report)功能</para>
/// <para>接口ID：7368679915980947458</para>
/// <para>文档地址：https://open.feishu.cn/document/attendance-v1/archive_rule/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2farchive_rule%2flist</para>
/// </summary>
public record GetAttendanceV1ArchiveRuleResponseDto : IPageableResponse<GetAttendanceV1ArchiveRuleResponseDto.ArchiveReportMeta>
{
    /// <summary>
    /// <para>分页查询结果项</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public ArchiveReportMeta[]? Items { get; set; }

    /// <summary>
    /// <para>分页查询结果项</para>
    /// </summary>
    public record ArchiveReportMeta
    {
        /// <summary>
        /// <para>引用报表 ID，暂时无用</para>
        /// <para>必填：否</para>
        /// <para>示例值：7341290237441605652</para>
        /// </summary>
        [JsonPropertyName("report_id")]
        public string? ReportId { get; set; }

        /// <summary>
        /// <para>引用报表name</para>
        /// <para>必填：否</para>
        /// <para>示例值：月报汇总</para>
        /// </summary>
        [JsonPropertyName("report_name")]
        public I18nMap? ReportName { get; set; }

        /// <summary>
        /// <para>引用报表name</para>
        /// </summary>
        public record I18nMap
        {
            /// <summary>
            /// <para>中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("zh")]
            public string? Zh { get; set; }

            /// <summary>
            /// <para>英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：alice</para>
            /// </summary>
            [JsonPropertyName("en")]
            public string? En { get; set; }

            /// <summary>
            /// <para>日文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("ja")]
            public string? Ja { get; set; }
        }

        /// <summary>
        /// <para>归档报表规则ID，可用于[查询归档报表表头](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/archive_rule/user_stats_fields_query)</para>
        /// <para>必填：否</para>
        /// <para>示例值：7341290237441605652</para>
        /// </summary>
        [JsonPropertyName("archive_rule_id")]
        public string? ArchiveRuleId { get; set; }

        /// <summary>
        /// <para>归档报表name</para>
        /// <para>必填：否</para>
        /// <para>示例值：归档全员</para>
        /// </summary>
        [JsonPropertyName("archive_rule_name")]
        public I18nMap? ArchiveRuleName { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxx</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
