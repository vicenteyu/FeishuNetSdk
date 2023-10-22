using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 获取云文档权限设置V2 响应体
/// <para>该接口用于根据 filetoken 获取云文档的权限设置。</para>
/// <para>接口ID：6907569524099940353</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/permission/get-document-sharing-settings-v2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuITM3YjLyEzN24iMxcjN</para>
/// </summary>
public record PostDrivePermissionV2PublicResponseDto
{
    /// <summary>
    /// <para>可创建副本/打印/导出/复制设置：<br>"anyone_can_view" - 所有可访问此文档的用户<br>"anyone_can_edit" - 有编辑权限的用户</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("security_entity")]
    public string? SecurityEntity { get; set; }

    /// <summary>
    /// <para>可评论设置：<br>"anyone_can_view" - 所有可访问此文档的用户<br>"anyone_can_edit" - 有编辑权限的用户</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("comment_entity")]
    public string? CommentEntity { get; set; }

    /// <summary>
    /// <para>谁可以添加和管理协作者：<br>"anyone"-所有可阅读或编辑此文档的用户<br>"same_tenant"-组织内所有可阅读或编辑此文档的用户<br>"only_me"-只有我可以</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("share_entity")]
    public string? ShareEntity { get; set; }

    /// <summary>
    /// <para>链接共享：<br>"tenant_readable" - 组织内获得链接的人可阅读<br>"tenant_editable" - 组织内获得链接的人可编辑<br>"anyone_readable" - 获得链接的任何人可阅读<br>"anyone_editable" - 获得链接的任何人可编辑</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("link_share_entity")]
    public string? LinkShareEntity { get; set; }

    /// <summary>
    /// <para>是否允许分享到租户外开关</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("external_access")]
    public bool? ExternalAccess { get; set; }

    /// <summary>
    /// <para>非owner是否允许邀请外部人</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("invite_external")]
    public bool? InviteExternal { get; set; }

    /// <summary>
    /// <para>权限版本号</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("permission_version")]
    public string? PermissionVersion { get; set; }
}
