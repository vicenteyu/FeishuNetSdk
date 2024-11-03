// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1ChatsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建群 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 创建群 响应体
/// <para>创建群聊，创建时支持设置群头像、群名称、群主以及群类型等配置，同时支持邀请群成员、群机器人入群。</para>
/// <para>## 前提条件</para>
/// <para>应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>## 使用限制</para>
/// <para>商店应用无法使用用户的 user_id，因此使用商店应用调用本接口时用户 ID 类型请选择 open_id 或者 union_id。</para>
/// <para>## 注意事项</para>
/// <para>- 如果你需要在已创建的群聊内邀请用户或机器人入群，可调用[将用户或机器人拉入群聊](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-members/create)接口。</para>
/// <para>- 调用 API 只能创建普通消息群，消息形式可以选择对话消息或者话题消息。如果你需要直接创建话题群，请通过飞书客户端创建群组，创建时群模式选择 **话题**。</para>
/// <para>接口ID：6946222931479379969</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat%2fcreate</para>
/// </summary>
public record PostImV1ChatsResponseDto
{
    /// <summary>
    /// <para>群 ID。建议保存该 ID，后续[向群发送消息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/create)、[更新群信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat/update)以及[将用户或机器人拉入群聊](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-members/create)等群组相关的操作均需使用该 ID。</para>
    /// <para>必填：否</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </summary>
    [JsonPropertyName("chat_id")]
    public string? ChatId { get; set; }

    /// <summary>
    /// <para>群头像 URL</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://p3-lark-file.byteimg.com/img/lark-avatar-staging/default-avatar_44ae0ca3-e140-494b-956f-78091e348435~100x100.jpg</para>
    /// </summary>
    [JsonPropertyName("avatar")]
    public string? Avatar { get; set; }

    /// <summary>
    /// <para>群名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：测试群名称</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>群描述</para>
    /// <para>必填：否</para>
    /// <para>示例值：测试群描述</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>群国际化名称</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("i18n_names")]
    public PostImV1ChatsResponseDtoI18nNames? I18nNames { get; set; }

    /// <summary>
    /// <para>群国际化名称</para>
    /// </summary>
    public record PostImV1ChatsResponseDtoI18nNames
    {
        /// <summary>
        /// <para>中文名</para>
        /// <para>必填：否</para>
        /// <para>示例值：群聊</para>
        /// </summary>
        [JsonPropertyName("zh_cn")]
        public string? ZhCn { get; set; }

        /// <summary>
        /// <para>英文名</para>
        /// <para>必填：否</para>
        /// <para>示例值：group chat</para>
        /// </summary>
        [JsonPropertyName("en_us")]
        public string? EnUs { get; set; }

        /// <summary>
        /// <para>日文名</para>
        /// <para>必填：否</para>
        /// <para>示例值：グループチャット</para>
        /// </summary>
        [JsonPropertyName("ja_jp")]
        public string? JaJp { get; set; }
    }

    /// <summary>
    /// <para>群主 ID，ID 类型与查询参数中的 ==user_id_type== 对应；不同 ID 的说明参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
    /// <para>**注意**：当群主是机器人时，该字段不返回</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7d8a6e6df7621556ce0d21922b676706ccs</para>
    /// </summary>
    [JsonPropertyName("owner_id")]
    public string? OwnerId { get; set; }

    /// <summary>
    /// <para>群主 ID 类型，与查询参数中的 ==user_id_type== 取值相同。</para>
    /// <para>**注意**：当群主是机器人时，该字段不返回</para>
    /// <para>必填：否</para>
    /// <para>示例值：open_id</para>
    /// </summary>
    [JsonPropertyName("owner_id_type")]
    public string? OwnerIdType { get; set; }

    /// <summary>
    /// <para>谁可以加急</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_members</para>
    /// <para>可选值：<list type="bullet">
    /// <item>only_owner：仅群主和管理员</item>
    /// <item>all_members：所有成员</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("urgent_setting")]
    public string? UrgentSetting { get; set; }

    /// <summary>
    /// <para>谁可以发起视频会议</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_members</para>
    /// <para>可选值：<list type="bullet">
    /// <item>only_owner：仅群主和管理员</item>
    /// <item>all_members：所有成员</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("video_conference_setting")]
    public string? VideoConferenceSetting { get; set; }

    /// <summary>
    /// <para>谁可以邀请用户或机器人入群</para>
    /// <para>**可选值有**：</para>
    /// <para>- `only_owner`：仅群主和管理员</para>
    /// <para>- `all_members`：所有成员</para>
    /// <para>必填：否</para>
    /// <para>示例值：all members</para>
    /// </summary>
    [JsonPropertyName("add_member_permission")]
    public string? AddMemberPermission { get; set; }

    /// <summary>
    /// <para>群分享权限</para>
    /// <para>**可选值有**：</para>
    /// <para>- `allowed`：允许</para>
    /// <para>- `not_allowed`：不允许</para>
    /// <para>必填：否</para>
    /// <para>示例值：allowed</para>
    /// </summary>
    [JsonPropertyName("share_card_permission")]
    public string? ShareCardPermission { get; set; }

    /// <summary>
    /// <para>谁可以 at 所有人</para>
    /// <para>**可选值有**：</para>
    /// <para>- `only_owner`：仅群主和管理员</para>
    /// <para>- `all_members`：所有成员</para>
    /// <para>必填：否</para>
    /// <para>示例值：all members</para>
    /// </summary>
    [JsonPropertyName("at_all_permission")]
    public string? AtAllPermission { get; set; }

    /// <summary>
    /// <para>群编辑权限</para>
    /// <para>**可选值有**：</para>
    /// <para>- `only_owner`：仅群主和管理员</para>
    /// <para>- `all_members`：所有成员</para>
    /// <para>必填：否</para>
    /// <para>示例值：all members</para>
    /// </summary>
    [JsonPropertyName("edit_permission")]
    public string? EditPermission { get; set; }

    /// <summary>
    /// <para>群消息形式</para>
    /// <para>**可选值有**：</para>
    /// <para>- `chat`：对话消息</para>
    /// <para>- `thread`：话题消息</para>
    /// <para>必填：否</para>
    /// <para>示例值：chat</para>
    /// </summary>
    [JsonPropertyName("group_message_type")]
    public string? GroupMessageType { get; set; }

    /// <summary>
    /// <para>群模式</para>
    /// <para>**可选值有**：</para>
    /// <para>- `group`：群组</para>
    /// <para>必填：否</para>
    /// <para>示例值：group</para>
    /// </summary>
    [JsonPropertyName("chat_mode")]
    public string? ChatMode { get; set; }

    /// <summary>
    /// <para>群类型</para>
    /// <para>**可选值有**：</para>
    /// <para>- `private`：私有群</para>
    /// <para>- `public`：公开群</para>
    /// <para>必填：否</para>
    /// <para>示例值：private</para>
    /// </summary>
    [JsonPropertyName("chat_type")]
    public string? ChatType { get; set; }

    /// <summary>
    /// <para>群标签，如有多个，则按照下列顺序返回第一个</para>
    /// <para>**可选值有**：</para>
    /// <para>- `inner`：内部群</para>
    /// <para>- `tenant`：公司群</para>
    /// <para>- `department`：部门群</para>
    /// <para>- `edu`：教育群</para>
    /// <para>- `meeting`：会议群</para>
    /// <para>- `customer_service`：客服群</para>
    /// <para>必填：否</para>
    /// <para>示例值：inner</para>
    /// </summary>
    [JsonPropertyName("chat_tag")]
    public string? ChatTag { get; set; }

    /// <summary>
    /// <para>是否是外部群</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("external")]
    public bool? External { get; set; }

    /// <summary>
    /// <para>租户在飞书上的唯一标识，用来换取对应的 tenant_access_token，也可以用作租户在应用里面的唯一标识</para>
    /// <para>必填：否</para>
    /// <para>示例值：736588c9260f175e</para>
    /// </summary>
    [JsonPropertyName("tenant_key")]
    public string? TenantKey { get; set; }

    /// <summary>
    /// <para>入群消息可见性</para>
    /// <para>**可选值有**：</para>
    /// <para>- `only_owner`：仅群主和管理员可见</para>
    /// <para>- `all_members`：所有成员可见</para>
    /// <para>- `not_anyone`：任何人均不可见</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_members</para>
    /// </summary>
    [JsonPropertyName("join_message_visibility")]
    public string? JoinMessageVisibility { get; set; }

    /// <summary>
    /// <para>出群消息可见性</para>
    /// <para>**可选值有**：</para>
    /// <para>- `only_owner`：仅群主和管理员可见</para>
    /// <para>- `all_members`：所有成员可见</para>
    /// <para>- `not_anyone`：任何人均不可见</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_members</para>
    /// </summary>
    [JsonPropertyName("leave_message_visibility")]
    public string? LeaveMessageVisibility { get; set; }

    /// <summary>
    /// <para>加群审批</para>
    /// <para>**可选值有**：</para>
    /// <para>- `no_approval_required`：无需审批</para>
    /// <para>- `approval_required`：需要审批</para>
    /// <para>必填：否</para>
    /// <para>示例值：no_approval_required</para>
    /// </summary>
    [JsonPropertyName("membership_approval")]
    public string? MembershipApproval { get; set; }

    /// <summary>
    /// <para>发言权限</para>
    /// <para>**可选值有**：</para>
    /// <para>- `only_owner`：仅群主和管理员</para>
    /// <para>- `all_members`：所有成员</para>
    /// <para>- `moderator_list`：指定群成员</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_members</para>
    /// </summary>
    [JsonPropertyName("moderation_permission")]
    public string? ModerationPermission { get; set; }

    /// <summary>
    /// <para>保密模式设置</para>
    /// <para>**注意**：仅企业旗舰版支持设置保密模式。保密模式的适用版本与功能介绍，参见[会话保密模式](https://www.feishu.cn/hc/zh-CN/articles/418691056559)。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("restricted_mode_setting")]
    public PostImV1ChatsResponseDtoRestrictedModeSetting? RestrictedModeSetting { get; set; }

    /// <summary>
    /// <para>保密模式设置</para>
    /// <para>**注意**：仅企业旗舰版支持设置保密模式。保密模式的适用版本与功能介绍，参见[会话保密模式](https://www.feishu.cn/hc/zh-CN/articles/418691056559)。</para>
    /// </summary>
    public record PostImV1ChatsResponseDtoRestrictedModeSetting
    {
        /// <summary>
        /// <para>保密模式是否开启</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("status")]
        public bool? Status { get; set; }

        /// <summary>
        /// <para>允许截屏录屏</para>
        /// <para>必填：否</para>
        /// <para>示例值：all_members</para>
        /// <para>可选值：<list type="bullet">
        /// <item>all_members：所有成员允许截屏录屏</item>
        /// <item>not_anyone：所有成员禁止截屏录屏</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("screenshot_has_permission_setting")]
        public string? ScreenshotHasPermissionSetting { get; set; }

        /// <summary>
        /// <para>允许下载消息中图片、视频和文件</para>
        /// <para>必填：否</para>
        /// <para>示例值：all_members</para>
        /// <para>可选值：<list type="bullet">
        /// <item>all_members：所有成员允许下载资源</item>
        /// <item>not_anyone：所有成员禁止下载资源</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("download_has_permission_setting")]
        public string? DownloadHasPermissionSetting { get; set; }

        /// <summary>
        /// <para>允许复制和转发消息</para>
        /// <para>必填：否</para>
        /// <para>示例值：all_members</para>
        /// <para>可选值：<list type="bullet">
        /// <item>all_members：所有成员允许复制和转发消息</item>
        /// <item>not_anyone：所有成员禁止复制和转发消息</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("message_has_permission_setting")]
        public string? MessageHasPermissionSetting { get; set; }
    }

    /// <summary>
    /// <para>隐藏群成员人数设置</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_members</para>
    /// <para>可选值：<list type="bullet">
    /// <item>all_members：所有群成员可见</item>
    /// <item>only_owner：仅群主群管理员可见</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("hide_member_count_setting")]
    public string? HideMemberCountSetting { get; set; }
}
