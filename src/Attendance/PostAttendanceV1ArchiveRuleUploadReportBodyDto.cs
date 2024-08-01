// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-01
//
// Last Modified By : yxr
// Last Modified On : 2024-08-01
// ************************************************************************
// <copyright file="PostAttendanceV1ArchiveRuleUploadReportBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>写入归档报表结果 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 写入归档报表结果 请求体
/// <para>写入归档报表结果，对应假勤管理-考勤统计-报表-[归档报表](https://example.feishu.cn/people/workforce-management/manage/statistics/report)页签，点击报表名称进入后的导入功能。可以将数据直接写入归档报表。</para>
/// <para>接口ID：7368679915980914690</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/archive_rule/upload_report</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2farchive_rule%2fupload_report</para>
/// </summary>
public record PostAttendanceV1ArchiveRuleUploadReportBodyDto
{
    /// <summary>
    /// <para>月份，格式为yyyyMM</para>
    /// <para>必填：否</para>
    /// <para>示例值：202409</para>
    /// </summary>
    [JsonPropertyName("month")]
    public string? Month { get; set; }

    /// <summary>
    /// <para>操作者ID，对应employee_type</para>
    /// <para>必填：否</para>
    /// <para>示例值：ax11d</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public string? OperatorId { get; set; }

    /// <summary>
    /// <para>归档报表内容(不超过50个)</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("archive_report_datas")]
    public ArchiveReportData[]? ArchiveReportDatas { get; set; }

    /// <summary>
    /// <para>归档报表内容(不超过50个)</para>
    /// </summary>
    public record ArchiveReportData
    {
        /// <summary>
        /// <para>用户ID，对应employee_type</para>
        /// <para>必填：是</para>
        /// <para>示例值：1aaxxd</para>
        /// </summary>
        [JsonPropertyName("member_id")]
        public string MemberId { get; set; } = string.Empty;

        /// <summary>
        /// <para>考勤开始时间，格式为yyyyMMdd</para>
        /// <para>必填：是</para>
        /// <para>示例值：20210109</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>考勤结束时间，格式为yyyyMMdd</para>
        /// <para>必填：是</para>
        /// <para>示例值：20210109</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>字段结果(不超过200个)</para>
        /// <para>必填：否</para>
        /// <para>最大长度：200</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("field_datas")]
        public ArchiveFieldData[]? FieldDatas { get; set; }

        /// <summary>
        /// <para>字段结果(不超过200个)</para>
        /// </summary>
        public record ArchiveFieldData
        {
            /// <summary>
            /// <para>字段编码，可根据[查询归档报表表头](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/archive_rule/user_stats_fields_query) 获取</para>
            /// <para>必填：是</para>
            /// <para>示例值：abd754f7</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string Code { get; set; } = string.Empty;

            /// <summary>
            /// <para>字段结果值</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }
    }

    /// <summary>
    /// <para>归档规则id，可根据[查询所有归档规则](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/archive_rule/list)获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("archive_rule_id")]
    public string? ArchiveRuleId { get; set; }
}
