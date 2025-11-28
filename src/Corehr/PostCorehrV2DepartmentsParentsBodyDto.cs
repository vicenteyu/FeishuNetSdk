// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2DepartmentsParentsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取父部门信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 获取父部门信息 请求体
/// <para>该接口用来递归获取部门的父部门信息，并按照由子到父的顺序返回有权限的父部门信息列表。</para>
/// <para>接口ID：7236202966714957826</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/department/parents</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fparents</para>
/// </summary>
public record PostCorehrV2DepartmentsParentsBodyDto
{
    /// <summary>
    /// <para>部门 ID 列表，一次性最多传入 100 个部门 ID</para>
    /// <para>- 调用[【创建部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/create)[【搜索部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/search)等接口可以返回部门ID</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("department_id_list")]
    public string[] DepartmentIdList { get; set; } = [];
}
