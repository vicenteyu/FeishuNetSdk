// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-24
// ************************************************************************
// <copyright file="PostApaasV1ApplicationsByNamespaceRolesByRoleApiNameMemberBatchRemoveAuthorizationBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量删除角色成员授权 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 批量删除角色成员授权 请求体
/// <para>批量删除角色成员授权</para>
/// <para>接口ID：7417675812785487875</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/permission/application-role-member/batch_remove_authorization</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-role-member%2fbatch_remove_authorization</para>
/// </summary>
public record PostApaasV1ApplicationsByNamespaceRolesByRoleApiNameMemberBatchRemoveAuthorizationBodyDto
{
    /// <summary>
    /// <para>需要删除的用户 ID 列表，使用飞书 aPaaS 的用户 ID</para>
    /// <para>必填：否</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[]? UserIds { get; set; }

    /// <summary>
    /// <para>需要删除的部门 ID 列表，使用飞书 aPaaS 的部门 ID</para>
    /// <para>必填：否</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("department_ids")]
    public string[]? DepartmentIds { get; set; }
}
