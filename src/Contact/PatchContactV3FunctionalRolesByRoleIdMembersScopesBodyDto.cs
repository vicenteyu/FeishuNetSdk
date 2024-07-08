// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchContactV3FunctionalRolesByRoleIdMembersScopesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量设置角色成员管理范围 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 批量设置角色成员管理范围 请求体
/// <para>调用该接口为指定角色内的一个或多个角色成员设置管理范围。管理范围是指角色成员可以管理的部门范围。</para>
/// <para>接口ID：7200215886841118748</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role-member/scopes</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role-member%2fscopes</para>
/// </summary>
public record PatchContactV3FunctionalRolesByRoleIdMembersScopesBodyDto
{
    /// <summary>
    /// <para>角色成员的用户 ID 列表，以 `["xxx", "yyy"]` 数组格式进行传值。ID 类型需要和查询参数 user_id_type 的取值保持一致。</para>
    /// <para>必填：是</para>
    /// <para>示例值：["qwer"]</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("members")]
    public string[] Members { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>设置角色成员可管理的部门范围（部门 ID 列表），以 `["xxx", "yyy"]` 数组格式进行传值。ID 类型需要和查询参数 department_id_type 的取值保持一致。</para>
    /// <para>部门 API 提供了多种获取部门 ID 的方式，如[获取子部门列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/children)、[获取父部门信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/parent)、[搜索部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/search)，你可以选择合适的 API 进行查询。</para>
    /// <para>**注意**：不支持为角色成员设置根部门（部门 ID 为 0）的管理范围。</para>
    /// <para>必填：是</para>
    /// <para>示例值：["adasd"]</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("departments")]
    public string[] Departments { get; set; } = Array.Empty<string>();
}
