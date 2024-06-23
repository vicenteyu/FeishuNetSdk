// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetAttendanceV1UserSettingsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询用户人脸识别信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 批量查询用户人脸识别信息 请求体
/// <para>批量查询授权内员工的用户设置信息，包括人脸照片文件 ID、人脸照片更新时间。</para>
/// <para>接口ID：7044467124773584897</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_setting/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_setting%2fquery</para>
/// </summary>
public record GetAttendanceV1UserSettingsQueryBodyDto
{
    /// <summary>
    /// <para>employee_no 或 employee_id 列表</para>
    /// <para>必填：是</para>
    /// <para>示例值：["abd754f7"]</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[] UserIds { get; set; } = Array.Empty<string>();
}
