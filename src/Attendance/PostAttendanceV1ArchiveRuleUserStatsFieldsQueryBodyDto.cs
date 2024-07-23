// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-24
// ************************************************************************
// <copyright file="PostAttendanceV1ArchiveRuleUserStatsFieldsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询归档报表表头 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 查询归档报表表头 请求体
/// <para>查询归档报表表头，对应后台假勤管理-考勤统计-报表-[归档报表](https://example.feishu.cn/people/workforce-management/manage/statistics/report)中一个归档报表的表头信息。归档报表支持引用系统报表，可设置归档时间和数据归档周期，并且支持根据部门/人员、国家/地区、人员类型、工作地点、职级、序列、职务进行人员圈选。</para>
/// <para>接口ID：7368679915980898306</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/archive_rule/user_stats_fields_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2farchive_rule%2fuser_stats_fields_query</para>
/// </summary>
public record PostAttendanceV1ArchiveRuleUserStatsFieldsQueryBodyDto
{
    /// <summary>
    /// <para>语言类型。默认为zh。</para>
    /// <para>可选值有：</para>
    /// <para>* `en`：英语</para>
    /// <para>* `ja`：日语</para>
    /// <para>* `zh`：中文</para>
    /// <para>必填：否</para>
    /// <para>示例值：zh</para>
    /// </summary>
    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    /// <summary>
    /// <para>月份，日期格式为yyyyMM。注意此字段应为必填字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：202409</para>
    /// </summary>
    [JsonPropertyName("month")]
    public string? Month { get; set; }

    /// <summary>
    /// <para>归档规则id，可根据[查询所有归档规则](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/archive_rule/list)获得。注意此字段应为必填字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("archive_rule_id")]
    public string? ArchiveRuleId { get; set; }

    /// <summary>
    /// <para>操作者id，对应employee_type。注意此字段应为必填字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：ax8ud</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public string? OperatorId { get; set; }
}
