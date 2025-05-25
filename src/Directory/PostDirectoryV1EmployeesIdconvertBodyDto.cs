// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="PostDirectoryV1EmployeesIdconvertBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>转换员工 ID 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 转换员工 ID 请求体
/// <para>转换员工 ID</para>
/// <para>接口ID：7419214646853107716</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/idconvert</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fidconvert</para>
/// </summary>
public record PostDirectoryV1EmployeesIdconvertBodyDto
{
    /// <summary>
    /// <para>用户ID列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("employee_ids")]
    public string[] EmployeeIds { get; set; } = Array.Empty<string>();
}
