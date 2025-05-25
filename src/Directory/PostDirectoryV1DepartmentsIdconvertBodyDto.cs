// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="PostDirectoryV1DepartmentsIdconvertBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>转换部门 ID 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 转换部门 ID 请求体
/// <para>转换部门 ID</para>
/// <para>接口ID：7419214646853206020</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/department/idconvert</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fdepartment%2fidconvert</para>
/// </summary>
public record PostDirectoryV1DepartmentsIdconvertBodyDto
{
    /// <summary>
    /// <para>部门ID列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("department_ids")]
    public string[] DepartmentIds { get; set; } = Array.Empty<string>();
}
