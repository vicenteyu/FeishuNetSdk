// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchDriveV2PermissionsByTokenPublicBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新云文档权限设置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 更新云文档权限设置 请求体
/// <para>更新指定云文档的权限设置，包括是否允许内容被分享到组织外、谁可以查看、添加、移除协作者、谁可以复制内容等设置。</para>
/// <para>接口ID：7224057619119128580</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-public/patch-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIzNzUjLyczM14iM3MTN%2fdrive-v2%2fpermission-public%2fpatch</para>
/// </summary>
public record PatchDriveV2PermissionsByTokenPublicBodyDto
{
    /// <summary>
    /// <para>是否允许内容被分享到组织外</para>
    /// <para>必填：否</para>
    /// <para>示例值：open</para>
    /// <para>可选值：<list type="bullet">
    /// <item>open：打开，即允许内容被分享到组织外 **注意**：内容是否支持分享到组织外，还与企业的安全设置相关。如果文档位于知识库中，还与知识空间的安全设置相关。</item>
    /// <item>closed：关闭，即不允许内容被分享到组织外</item>
    /// <item>allow_share_partner_tenant：仅允许内容分享给关联组织。了解关联组织，参考飞书帮助中心文档[关联组织介绍](https://www.feishu.cn/hc/zh-CN/articles/657083794612-%E5%85%B3%E8%81%94%E7%BB%84%E7%BB%87%E4%BB%8B%E7%BB%8D)。 **注意**：只有企业管理后台设置仅允许关联组织分享，才能设置为该值。</item>
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
    /// <para>从协作者维度，设置谁可以查看、添加、移除协作者</para>
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
    /// <item>partner_tenant_readable：[关联组织](https://www.feishu.cn/hc/zh-CN/articles/657083794612-%E5%85%B3%E8%81%94%E7%BB%84%E7%BB%87%E4%BB%8B%E7%BB%8D)的人可阅读 **注意**：只有企业管理后台设置仅允许关联组织分享，才能设置为该值。</item>
    /// <item>partner_tenant_editable：[关联组织](https://www.feishu.cn/hc/zh-CN/articles/657083794612-%E5%85%B3%E8%81%94%E7%BB%84%E7%BB%87%E4%BB%8B%E7%BB%8D)的人可编辑 **注意**：只有企业管理后台设置仅允许关联组织分享，才能设置为该值。</item>
    /// <item>anyone_readable：互联网上获得链接的任何人可阅读（仅external_access=“open” 时有效）</item>
    /// <item>anyone_editable：互联网上获得链接的任何人可编辑（仅 external_access=“open” 时有效）</item>
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
}
