// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="PostDirectoryV1DepartmentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建部门 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 创建部门 响应体
/// <para>本接口用于在企业下创建部门</para>
/// <para>接口ID：7359428154233536516</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/department/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fdepartment%2fcreate</para>
/// </summary>
public record PostDirectoryV1DepartmentsResponseDto
{
    /// <summary>
    /// <para>部门ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：eesdasd</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string? DepartmentId { get; set; }
}
