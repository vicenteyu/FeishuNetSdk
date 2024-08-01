// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-01
//
// Last Modified By : yxr
// Last Modified On : 2024-08-01
// ************************************************************************
// <copyright file="PostAttendanceV1ArchiveRuleUploadReportResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>写入归档报表结果 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 写入归档报表结果 响应体
/// <para>写入归档报表结果，对应假勤管理-考勤统计-报表-[归档报表](https://example.feishu.cn/people/workforce-management/manage/statistics/report)页签，点击报表名称进入后的导入功能。可以将数据直接写入归档报表。</para>
/// <para>接口ID：7368679915980914690</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/archive_rule/upload_report</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2farchive_rule%2fupload_report</para>
/// </summary>
public record PostAttendanceV1ArchiveRuleUploadReportResponseDto
{
    /// <summary>
    /// <para>无效的code</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("invalid_code")]
    public string[]? InvalidCode { get; set; }

    /// <summary>
    /// <para>无效的member_id，对应employee_type</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("invalid_member_id")]
    public string[]? InvalidMemberId { get; set; }
}
