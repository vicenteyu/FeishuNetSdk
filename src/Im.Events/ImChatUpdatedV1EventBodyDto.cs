// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ImChatUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>群配置修改 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Events;
/// <summary>
/// 群配置修改 事件体
/// <para>群组配置被修改后触发此事件，在该群组内的、已订阅当前事件的应用机器人将会收到事件通知。修改操作包含：</para>
/// <para>- 转移群主</para>
/// <para>- 修改群基本信息，包括：群头像、群名称、群描述、群国际化名称</para>
/// <para>- 修改群权限，包括：加人入群权限、群编辑权限、at 所有人权限、群分享权限等{使用示例}(url=/api/tools/api_explore/api_explore_config?project=im&amp;version=v1&amp;resource=chat&amp;event=updated)</para>
/// <para>接口ID：6946222929790615580</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat%2fevents%2fupdated</para>
/// </summary>
public record ImChatUpdatedV1EventBodyDto() : EventBodyDto("im.chat.updated_v1")
{
    /// <summary>
    /// <para>群组 ID，详细介绍参见[群 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("chat_id")]
    public string? ChatId { get; set; }

    /// <summary>
    /// <para>修改群配置的操作者的 ID 信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public UserIdSuffix? OperatorId { get; set; }

    /// <summary>
    /// <para>是否是外部群</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("external")]
    public bool? External { get; set; }

    /// <summary>
    /// <para>操作者的租户 Key，为租户在飞书上的唯一标识，用来换取对应的tenant_access_token，也可以用作租户在应用中的唯一标识。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_tenant_key")]
    public string? OperatorTenantKey { get; set; }

    /// <summary>
    /// <para>更新后的群信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("after_change")]
    public ChatChange? AfterChange { get; set; }

    /// <summary>
    /// <para>更新前的群信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("before_change")]
    public ChatChange? BeforeChange { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record ChatChange
    {
        /// <summary>
        /// <para>群头像</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// <para>群名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>群描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>群国际化名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_names")]
        public I18nLanguage<string>? I18nNames { get; set; }

        /// <summary>
        /// <para>谁可以邀请成员（用户或机器人）入群</para>
        /// <para>**可选值有**：</para>
        /// <para>- all_members：所有成员</para>
        /// <para>- only_owner：仅群主和管理员</para>
        /// <para>- unknown：未设置</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>- all_members：所有成员</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("add_member_permission")]
        public string? AddMemberPermission { get; set; }

        /// <summary>
        /// <para>群分享权限</para>
        /// <para>**可选值有**：</para>
        /// <para>- allowed：允许</para>
        /// <para>- not_allowed：不允许</para>
        /// <para>- unknown：未设置</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>- allowed：允许</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("share_card_permission")]
        public string? ShareCardPermission { get; set; }

        /// <summary>
        /// <para>谁可以 at 所有人</para>
        /// <para>**可选值有**：</para>
        /// <para>- all_members：所有成员</para>
        /// <para>- only_owner：仅群主和管理员</para>
        /// <para>- unknown：未设置</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>- all_members：所有成员</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("at_all_permission")]
        public string? AtAllPermission { get; set; }

        /// <summary>
        /// <para>谁可以编辑群</para>
        /// <para>**可选值有**：</para>
        /// <para>- all_members：所有成员</para>
        /// <para>- only_owner：仅群主和管理员</para>
        /// <para>- unknown：未设置</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>- all_members：所有成员</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("edit_permission")]
        public string? EditPermission { get; set; }

        /// <summary>
        /// <para>加群是否需要审批</para>
        /// <para>**可选值有**：</para>
        /// <para>- no_approval_required：无需审批</para>
        /// <para>- approval_required：需要审批</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>- no_approval_required：无需审批</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("membership_approval")]
        public string? MembershipApproval { get; set; }

        /// <summary>
        /// <para>入群提示消息的可见性</para>
        /// <para>**可选值有**：</para>
        /// <para>- only_owner：仅群主和管理员可见</para>
        /// <para>- all_members：所有成员可见</para>
        /// <para>- not_anyone：任何人均不可见</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>- only_owner：仅群主和管理员可见</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("join_message_visibility")]
        public string? JoinMessageVisibility { get; set; }

        /// <summary>
        /// <para>出群消息可见性</para>
        /// <para>**可选值有**：</para>
        /// <para>- only_owner：仅群主和管理员可见</para>
        /// <para>- all_members：所有成员可见</para>
        /// <para>- not_anyone：任何人均不可见</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>- only_owner：仅群主和管理员可见</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("leave_message_visibility")]
        public string? LeaveMessageVisibility { get; set; }

        /// <summary>
        /// <para>发言权限</para>
        /// <para>**可选值有**：</para>
        /// <para>- all_members：所有成员</para>
        /// <para>- only_owner：仅群主和管理员</para>
        /// <para>**说明**：发言权限为指定群成员时，需要参考 `moderator_list` 参数。</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>- all_members：所有成员</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("moderation_permission")]
        public string? ModerationPermission { get; set; }

        /// <summary>
        /// <para>群主 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("owner_id")]
        public UserIdSuffix? OwnerId { get; set; }

        /// <summary>
        /// <para>防泄密模式设置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("restricted_mode_setting")]
        public RestrictedModeSettingSuffix? RestrictedModeSetting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record RestrictedModeSettingSuffix
        {
            /// <summary>
            /// <para>防泄密模式是否开启</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("status")]
            public bool? Status { get; set; }

            /// <summary>
            /// <para>允许截屏录屏</para>
            /// <para>**可选值有**：</para>
            /// <para>all_members:所有成员允许截屏录屏,not_anyone:所有成员禁止截屏录屏</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>all_members：所有成员允许截屏录屏</item>
            /// <item>not_anyone：所有成员禁止截屏录屏</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("screenshot_has_permission_setting")]
            public string? ScreenshotHasPermissionSetting { get; set; }

            /// <summary>
            /// <para>允许下载消息中图片、视频和文件</para>
            /// <para>**可选值有**：</para>
            /// <para>all_members:所有成员允许下载资源,not_anyone:所有成员禁止下载资源</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>all_members：所有成员允许下载资源</item>
            /// <item>not_anyone：所有成员禁止下载资源</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("download_has_permission_setting")]
            public string? DownloadHasPermissionSetting { get; set; }

            /// <summary>
            /// <para>允许复制和转发消息</para>
            /// <para>**可选值有**：</para>
            /// <para>all_members:所有成员允许复制和转发消息,not_anyone:所有成员禁止复制和转发消息</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>all_members：所有成员允许复制和转发消息</item>
            /// <item>not_anyone：所有成员禁止复制和转发消息</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("message_has_permission_setting")]
            public string? MessageHasPermissionSetting { get; set; }
        }

        /// <summary>
        /// <para>群消息形式</para>
        /// <para>**可选值有**：</para>
        /// <para>- chat：会话消息</para>
        /// <para>- thread：话题消息</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>- chat：会话消息</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("group_message_type")]
        public string? GroupMessageType { get; set; }
    }

    /// <summary>
    /// <para>群可发言成员名单的变更信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("moderator_list")]
    public ModeratorListSuffix? ModeratorList { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record ModeratorListSuffix
    {
        /// <summary>
        /// <para>被添加进可发言名单的用户列表（该列表中一定有群主）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("added_member_list")]
        public ListEventModerator[]? AddedMemberList { get; set; }

        /// <summary>
        /// <para>被移除出可发言名单的用户列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("removed_member_list")]
        public ListEventModerator[]? RemovedMemberList { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public record ListEventModerator
    {
        /// <summary>
        /// <para>租户 Key，为租户在飞书上的唯一标识，用来换取对应的tenant_access_token，也可以用作租户在应用中的唯一标识。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("tenant_key")]
        public string? TenantKey { get; set; }

        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public UserIdSuffix? UserId { get; set; }
    }
}
