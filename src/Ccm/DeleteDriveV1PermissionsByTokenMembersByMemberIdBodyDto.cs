// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-04
// ************************************************************************
// <copyright file="DeleteDriveV1PermissionsByTokenMembersByMemberIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>移除协作者权限 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 移除云文档协作者权限 请求体
/// <para>通过云文档 token 和协作者 ID 移除指定云文档协作者的权限。</para>
/// <para>接口ID：6998069547745214492</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-member/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-member%2fdelete</para>
/// </summary>
public record DeleteDriveV1PermissionsByTokenMembersByMemberIdBodyDto
{
    /// <summary>
    /// <para>协作者类型</para>
    /// <para>**注意**：当 `member_type` 参数为 `wikispaceid` 时必须传该参数</para>
    /// <para>**默认值**：""</para>
    /// <para>必填：否</para>
    /// <para>示例值：user</para>
    /// <para>可选值：<list type="bullet">
    /// <item>user：用户</item>
    /// <item>chat：群组</item>
    /// <item>department：组织架构</item>
    /// <item>group：用户组</item>
    /// <item>wiki_space_member：知识库成员。在知识库启用了成员分组功能后不支持该参数</item>
    /// <item>wiki_space_viewer：知识库可阅读成员。仅在知识库启用了成员分组功能后才支持该参数</item>
    /// <item>wiki_space_editor：知识库可编辑成员。仅在知识库启用了成员分组功能后才支持该参数</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// <para>协作者的权限角色类型。当云文档类型为 wiki 即知识库节点时，该参数有效。</para>
    /// <para>必填：否</para>
    /// <para>示例值：container</para>
    /// <para>可选值：<list type="bullet">
    /// <item>container：当前页面及子页面</item>
    /// <item>single_page：仅当前页面，当且仅当在知识库文档中该参数有效</item>
    /// </list></para>
    /// <para>默认值：container</para>
    /// </summary>
    [JsonPropertyName("perm_type")]
    public string? PermType { get; set; }
}
