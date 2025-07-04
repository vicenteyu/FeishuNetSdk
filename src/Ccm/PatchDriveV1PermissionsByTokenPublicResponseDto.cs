// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchDriveV1PermissionsByTokenPublicResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新云文档权限设置 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 更新云文档权限设置 响应体
/// <para>更新指定云文档的权限设置，包括是否允许内容被分享到组织外、谁可以查看、添加、移除协作者、谁可以复制内容等设置。</para>
/// <para>接口ID：6987581166854651905</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-public/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-public%2fpatch</para>
/// </summary>
public record PatchDriveV1PermissionsByTokenPublicResponseDto
{
    /// <summary>
    /// <para>本次更新后的文档权限设置。如权限设置未更新，则不返回对应参数。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("permission_public")]
    public PatchDriveV1PermissionsByTokenPublicResponseDtoPermissionPublic? PermissionPublic { get; set; }

    /// <summary>
    /// <para>本次更新后的文档权限设置。如权限设置未更新，则不返回对应参数。</para>
    /// </summary>
    public record PatchDriveV1PermissionsByTokenPublicResponseDtoPermissionPublic
    {
        /// <summary>
        /// <para>是否允许内容被分享到组织外</para>
        /// <para>**枚举值有：**</para>
        /// <para>- `true`: 允许</para>
        /// <para>- `false`: 不允许</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("external_access")]
        public bool? ExternalAccess { get; set; }

        /// <summary>
        /// <para>谁可以复制内容、创建副本、打印、下载</para>
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
        /// <para>可评论设置</para>
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
        /// <para>谁可以添加和管理协作者</para>
        /// <para>必填：否</para>
        /// <para>示例值：anyone</para>
        /// <para>可选值：<list type="bullet">
        /// <item>anyone：所有可阅读或编辑此文档的用户</item>
        /// <item>same_tenant：组织内所有可阅读或编辑此文档的用户</item>
        /// <item>only_full_access：拥有可管理权限（包括我）的用户</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("share_entity")]
        public string? ShareEntity { get; set; }

        /// <summary>
        /// <para>链接分享设置</para>
        /// <para>必填：否</para>
        /// <para>示例值：tenant_readable</para>
        /// <para>可选值：<list type="bullet">
        /// <item>tenant_readable：组织内获得链接的人可阅读</item>
        /// <item>tenant_editable：组织内获得链接的人可编辑</item>
        /// <item>anyone_readable：互联网上获得链接的任何人可阅读</item>
        /// <item>anyone_editable：互联网上获得链接的任何人可编辑</item>
        /// <item>closed：关闭链接分享</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("link_share_entity")]
        public string? LinkShareEntity { get; set; }

        /// <summary>
        /// <para>是否允许非「可管理权限」的人分享到组织外。</para>
        /// <para>**枚举值有：**</para>
        /// <para>- `true`: 允许</para>
        /// <para>- `false`: 不允许</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("invite_external")]
        public bool? InviteExternal { get; set; }

        /// <summary>
        /// <para>节点加锁状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("lock_switch")]
        public bool? LockSwitch { get; set; }
    }
}
