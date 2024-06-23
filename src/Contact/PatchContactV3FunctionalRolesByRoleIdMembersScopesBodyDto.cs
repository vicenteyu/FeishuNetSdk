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
/// <para>通过该接口可设置本租户下角色成员的管理范围，以便在审批等场景中应用。</para>
/// <para>接口ID：7200215886841118748</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role-member/scopes</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role-member%2fscopes</para>
/// </summary>
public record PatchContactV3FunctionalRolesByRoleIdMembersScopesBodyDto
{
    /// <summary>
    /// <para>角色修改的角色成员列表（一批用户的UserID列表)</para>
    /// <para>必填：是</para>
    /// <para>示例值：["qwer"]</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("members")]
    public string[] Members { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>角色内用户的管理范围</para>
    /// <para>必填：是</para>
    /// <para>示例值：["adasd"]</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("departments")]
    public string[] Departments { get; set; } = Array.Empty<string>();
}
