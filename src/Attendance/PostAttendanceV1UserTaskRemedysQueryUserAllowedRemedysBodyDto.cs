// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAttendanceV1UserTaskRemedysQueryUserAllowedRemedysBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取可补卡时间 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 获取可补卡时间 请求体
/// <para>获取用户某天可以补的第几次上 / 下班卡的时间。</para>
/// <para>接口ID：7044467124773453825</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_task_remedy/query_user_allowed_remedys</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_task_remedy%2fquery_user_allowed_remedys</para>
/// </summary>
public record PostAttendanceV1UserTaskRemedysQueryUserAllowedRemedysBodyDto
{
    /// <summary>
    /// <para>用户 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：abd754f7</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>补卡日期</para>
    /// <para>必填：是</para>
    /// <para>示例值：20210104</para>
    /// </summary>
    [JsonPropertyName("remedy_date")]
    public int RemedyDate { get; set; }
}
