// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-04
// ************************************************************************
// <copyright file="PostDriveV1PermissionsByTokenMembersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>增加协作者权限 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 增加协作者权限 响应体
/// <para>该接口用于根据云文档的 token 给用户增加文档的权限。</para>
/// <para>## 注意事项</para>
/// <para>- 调用该接口需要调用身份有该云文档添加协作者的权限。添加协作者的权限可通过云文档设置中的「谁可以查看、添加、移除协作者」等选项进行控制。</para>
/// <para>- 调用该接口时，需要调用身份与被授权对象满足 **可见性** ，例如：</para>
/// <para>- 添加用户协作者：需要调用身份与被授权对象为联系人或同组织内可搜索，且互相未屏蔽。</para>
/// <para>- 添加群协作者：需要调用身份在群内。要使用 `tenant_access_token` 身份添加群协作者，则需要将该应用作为机器人添加至群组中，使应用对群可见。</para>
/// <para>- 添加部门协作者：需要调用身份对部门可见。由于应用对企业内的组织架构都不可见，所以暂不支持通过 `tenant_access_token` 添加部门协作者。</para>
/// <para>- 目前不支持将应用直接添加到文件夹作为协作者（添加成功后实际仍然没有权限）。如果希望给应用授予文件夹的权限，请将应用作为群机器人添加到群组内，然后授予该群组可管理权限。</para>
/// <para>接口ID：6987581166854635521</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-member/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-member%2fcreate</para>
/// </summary>
public record PostDriveV1PermissionsByTokenMembersResponseDto
{
    /// <summary>
    /// <para>本次添加权限的用户信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("member")]
    public BaseMember? Member { get; set; }

    /// <summary>
    /// <para>本次添加权限的用户信息</para>
    /// </summary>
    public record BaseMember
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
        /// <item>wikispaceid：知识空间 ID</item>
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
        /// <para>必填：否</para>
        /// <para>示例值：user</para>
        /// <para>可选值：<list type="bullet">
        /// <item>user：用户</item>
        /// <item>chat：群组</item>
        /// <item>department：组织架构</item>
        /// <item>group：用户组</item>
        /// <item>wiki_space_member：知识库成员</item>
        /// <item>wiki_space_viewer：知识库可阅读成员</item>
        /// <item>wiki_space_editor：知识库可编辑成员</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
