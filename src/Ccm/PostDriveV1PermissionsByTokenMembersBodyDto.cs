// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-04
// ************************************************************************
// <copyright file="PostDriveV1PermissionsByTokenMembersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>增加协作者权限 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 增加协作者权限 请求体
/// <para>该接口用于根据文件的 token 给用户增加文档的权限。</para>
/// <para>接口ID：6987581166854635521</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-member/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-member%2fcreate</para>
/// </summary>
public record PostDriveV1PermissionsByTokenMembersBodyDto
{
    /// <summary>
    /// <para>协作者 ID 类型，与协作者 ID 需要对应</para>
    /// <para>必填：是</para>
    /// <para>示例值：openid</para>
    /// <para>可选值：<list type="bullet">
    /// <item>email：飞书邮箱</item>
    /// <item>openid：开放平台 ID</item>
    /// <item>unionid：开放平台 UnionID</item>
    /// <item>openchat：开放平台群组 ID</item>
    /// <item>opendepartmentid：开放平台部门 ID</item>
    /// <item>userid：用户自定义 ID</item>
    /// <item>groupid：自定义用户组 ID</item>
    /// <item>wikispaceid：知识空间 ID - **注意**：仅知识库文档支持该参数，当需要操作知识库文档里的「知识库成员」类型协作者时传该参数</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("member_type")]
    public string MemberType { get; set; } = string.Empty;

    /// <summary>
    /// <para>协作者 ID，与协作者 ID 类型需要对应</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_67e5ecb64ce1c0bd94612c17999db411</para>
    /// </summary>
    [JsonPropertyName("member_id")]
    public string MemberId { get; set; } = string.Empty;

    /// <summary>
    /// <para>协作者对应的权限角色</para>
    /// <para>**注意：** 妙记还不支持可管理角色</para>
    /// <para>必填：是</para>
    /// <para>示例值：view</para>
    /// <para>可选值：<list type="bullet">
    /// <item>view：可阅读角色</item>
    /// <item>edit：可编辑角色</item>
    /// <item>full_access：可管理角色</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("perm")]
    public string Perm { get; set; } = string.Empty;

    /// <summary>
    /// <para>协作者的权限角色类型</para>
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
    /// <item>wiki_space_member：知识库成员 - **注意**：在知识库启用了成员分组功能后不支持该参数</item>
    /// <item>wiki_space_viewer：知识库可阅读成员 - **注意**：仅在知识库启用了成员分组功能后才支持该参数</item>
    /// <item>wiki_space_editor：知识库可编辑成员 - **注意**：仅在知识库启用了成员分组功能后才支持该参数</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
