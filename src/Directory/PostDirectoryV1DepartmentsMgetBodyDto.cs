// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="PostDirectoryV1DepartmentsMgetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取部门信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 批量获取部门信息 请求体
/// <para>本接口用于批量根据部门的ID查询部门的详情。</para>
/// <para>接口ID：7359428234122854404</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/department/mget</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fdepartment%2fmget</para>
/// </summary>
public record PostDirectoryV1DepartmentsMgetBodyDto
{
    /// <summary>
    /// <para>部门ID，与department_id_type类型保持一致</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("department_ids")]
    public string[] DepartmentIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>需要查询的字段列表。将按照传递的字段列表返回有权限的行、列数据。不传则不会返回任何字段[了解更多：字段枚举说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/directory-v1/field-enumeration)</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("required_fields")]
    public string[] RequiredFields { get; set; } = Array.Empty<string>();
}
