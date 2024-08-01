// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-01
//
// Last Modified By : yxr
// Last Modified On : 2024-08-01
// ************************************************************************
// <copyright file="PostAttendanceV1ArchiveRuleDelReportBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除归档报表行数据 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 删除归档报表行数据 请求体
/// <para>按月份、用户和归档规则ID直接删除归档报表行数据</para>
/// <para>接口ID：7368679915980931074</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/archive_rule/del_report</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2farchive_rule%2fdel_report</para>
/// </summary>
public record PostAttendanceV1ArchiveRuleDelReportBodyDto
{
    /// <summary>
    /// <para>月份，格式yyyyMM</para>
    /// <para>必填：否</para>
    /// <para>示例值：202409</para>
    /// </summary>
    [JsonPropertyName("month")]
    public string? Month { get; set; }

    /// <summary>
    /// <para>操作者ID，对应employee_type</para>
    /// <para>必填：是</para>
    /// <para>示例值：a111xd</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public string OperatorId { get; set; } = string.Empty;

    /// <summary>
    /// <para>归档规则id，可根据[查询所有归档规则](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/archive_rule/list)获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("archive_rule_id")]
    public string? ArchiveRuleId { get; set; }

    /// <summary>
    /// <para>用户id，对应employee_type</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[]? UserIds { get; set; }
}
