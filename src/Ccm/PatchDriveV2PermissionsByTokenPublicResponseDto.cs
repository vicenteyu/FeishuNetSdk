// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchDriveV2PermissionsByTokenPublicResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新云文档权限设置 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 更新云文档权限设置 响应体
/// <para>更新指定云文档的权限设置，包括是否允许内容被分享到组织外、谁可以查看、添加、移除协作者、谁可以复制内容等设置。</para>
/// <para>接口ID：7224057619119128580</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-public/patch-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIzNzUjLyczM14iM3MTN%2fdrive-v2%2fpermission-public%2fpatch</para>
/// </summary>
public record PatchDriveV2PermissionsByTokenPublicResponseDto
{
    /// <summary>
    /// <para>本次更新后的文档权限设置。如权限设置未更新，则不返回对应参数。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("permission_public")]
    public PatchDriveV2PermissionsByTokenPublicResponseDtoPermissionPublic? PermissionPublic { get; set; }

    /// <summary>
    /// <para>本次更新后的文档权限设置。如权限设置未更新，则不返回对应参数。</para>
    /// </summary>
    public record PatchDriveV2PermissionsByTokenPublicResponseDtoPermissionPublic
    {
        /// <summary>
        /// <para>允许内容被分享到组织外</para>
        /// <para>必填：否</para>
        /// <para>示例值：open</para>
        /// <para>可选值：<list type="bullet">
        /// <item>open：打开，即允许内容被分享到组织外</item>
        /// <item>closed：关闭，即不允许内容被分享到组织外</item>
        /// <item>allow_share_partner_tenant：仅允许分享给关联组织</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("external_access_entity")]
        public string? ExternalAccessEntity { get; set; }

        /// <summary>
        /// <para>谁可以创建副本、打印、下载</para>
        /// <para>必填：否</para>
        /// <para>示例值：anyone_can_view</para>
        /// <para>可选值：<list type="bullet">
        /// <item>anyone_can_view：拥有可阅读权限的用户</item>
        /// <item>anyone_can_edit：拥有可编辑权限的用户</item>
        /// <item>only_full_access：拥有可管理权限（包括我）的用户</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("security_entity")]
        public string? SecurityEntity { get; set; }

        /// <summary>
        /// <para>谁可以评论</para>
        /// <para>必填：否</para>
        /// <para>示例值：anyone_can_view</para>
        /// <para>可选值：<list type="bullet">
        /// <item>anyone_can_view：拥有可阅读权限的用户</item>
        /// <item>anyone_can_edit：拥有可编辑权限的用户</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("comment_entity")]
        public string? CommentEntity { get; set; }

        /// <summary>
        /// <para>从组织维度，设置谁可以查看、添加、移除协作者</para>
        /// <para>必填：否</para>
        /// <para>示例值：anyone</para>
        /// <para>可选值：<list type="bullet">
        /// <item>anyone：所有可阅读或编辑此文档的用户</item>
        /// <item>same_tenant：组织内所有可阅读或编辑此文档的用户</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("share_entity")]
        public string? ShareEntity { get; set; }

        /// <summary>
        /// <para>谁可以添加和管理协作者-协作者维度</para>
        /// <para>必填：否</para>
        /// <para>示例值：collaborator_can_view</para>
        /// <para>可选值：<list type="bullet">
        /// <item>collaborator_can_view：拥有可阅读权限的协作者</item>
        /// <item>collaborator_can_edit：拥有可编辑权限的协作者</item>
        /// <item>collaborator_full_access：拥有可管理权限（包括我）的协作者</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("manage_collaborator_entity")]
        public string? ManageCollaboratorEntity { get; set; }

        /// <summary>
        /// <para>链接分享设置</para>
        /// <para>必填：否</para>
        /// <para>示例值：tenant_readable</para>
        /// <para>可选值：<list type="bullet">
        /// <item>tenant_readable：组织内获得链接的人可阅读</item>
        /// <item>tenant_editable：组织内获得链接的人可编辑</item>
        /// <item>partner_tenant_readable：关联组织的人可阅读</item>
        /// <item>partner_tenant_editable：关联组织的人可编辑</item>
        /// <item>anyone_readable：互联网上获得链接的任何人可阅读（仅 external_access_entity=“open” 时有效）</item>
        /// <item>anyone_editable：互联网上获得链接的任何人可编辑（仅 external_access_entity=“open” 时有效）</item>
        /// <item>closed：关闭链接分享</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("link_share_entity")]
        public string? LinkShareEntity { get; set; }

        /// <summary>
        /// <para>谁可以复制内容</para>
        /// <para>必填：否</para>
        /// <para>示例值：anyone_can_view</para>
        /// <para>可选值：<list type="bullet">
        /// <item>anyone_can_view：拥有可阅读权限的用户</item>
        /// <item>anyone_can_edit：拥有可编辑权限的用户</item>
        /// <item>only_full_access：拥有可管理权限（包括我）的协作者</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("copy_entity")]
        public string? CopyEntity { get; set; }

        /// <summary>
        /// <para>知识库中的子页面是否已限制权限，不再继承父级页面的权限设置。</para>
        /// <para>**枚举值有：**</para>
        /// <para>- `true`: 已限制权限</para>
        /// <para>- `false`: 未限制权限</para>
        /// <para>**提示**：当知识库中的子页面权限范围小于父级页面时，该页面权限将默认限制权限。</para>
        /// <para>![image.png](//sf3-cn.feishucdn.com/obj/open-platform-opendoc/a99780710c3f7e5e390280ff6d87fc47_HIjzKDxscr.png?maxWidth=200)</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("lock_switch")]
        public bool? LockSwitch { get; set; }
    }
}
