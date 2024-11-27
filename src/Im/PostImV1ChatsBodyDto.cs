// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1ChatsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建群 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 创建群 请求体
/// <para>创建群聊，创建时支持设置群头像、群名称、群主以及群类型等配置，同时支持邀请群成员、群机器人入群。</para>
/// <para>## 前提条件</para>
/// <para>应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>## 使用限制</para>
/// <para>商店应用无法使用用户的 user_id，因此使用商店应用调用本接口时用户 ID 类型请选择 open_id 或者 union_id。</para>
/// <para>## 注意事项</para>
/// <para>- 如果你需要在已创建的群聊内邀请用户或机器人入群，可调用[将用户或机器人拉入群聊](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-members/create)接口。</para>
/// <para>- 调用 API 只能创建普通消息群，消息形式可以选择对话消息或者话题消息。如果你需要直接创建话题群，请通过飞书客户端创建群组，创建时群模式选择 **话题**。</para>
/// <para>- 已添加外部共享能力的机器人，允许在创建群时将外部企业用户和内部用户同时添加到群组中，这样创建的群为外部群。详情参见[机器人支持外部群和外部用户单聊](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/develop-robots/add-bot-to-external-group)。</para>
/// <para>接口ID：6946222931479379969</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat%2fcreate</para>
/// </summary>
public record PostImV1ChatsBodyDto
{
    /// <summary>
    /// <para>群头像对应的 Image Key</para>
    /// <para>- 可通过[上传图片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/image/create)获取（注意：上传图片的 ==image_type== 需要指定为 ==avatar==）</para>
    /// <para>- 不传值则使用系统默认头像</para>
    /// <para>必填：否</para>
    /// <para>示例值：default-avatar_44ae0ca3-e140-494b-956f-78091e348435</para>
    /// </summary>
    [JsonPropertyName("avatar")]
    public string? Avatar { get; set; }

    /// <summary>
    /// <para>群名称</para>
    /// <para>**注意：**</para>
    /// <para>- 建议群名称不超过 60 字符</para>
    /// <para>- 公开群名称的长度不得少于 2 个字符</para>
    /// <para>- 私有群若未填写群名称，群名称默认设置为 `(无主题)`</para>
    /// <para>必填：否</para>
    /// <para>示例值：测试群名称</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>群描述，建议不超过 100 字符</para>
    /// <para>**默认值**：空</para>
    /// <para>必填：否</para>
    /// <para>示例值：测试群描述</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>群国际化名称</para>
    /// <para>**注意**：</para>
    /// <para>- 建议不超过 60 字符</para>
    /// <para>- 不设置国际化名称，则默认展示 `name` 参数对应的名称</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("i18n_names")]
    public PostImV1ChatsBodyDtoI18nNames? I18nNames { get; set; }

    /// <summary>
    /// <para>群国际化名称</para>
    /// <para>**注意**：</para>
    /// <para>- 建议不超过 60 字符</para>
    /// <para>- 不设置国际化名称，则默认展示 `name` 参数对应的名称</para>
    /// </summary>
    public record PostImV1ChatsBodyDtoI18nNames
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
    /// <para>创建群时指定的群主，不填时指定建群的机器人为群主。群主 ID 类型在查询参数 ==user_id_type== 中指定；推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</para>
    /// <para>**注意**：开启对外共享能力的机器人在创建外部群时，机器人不能为群主，必须指定某一用户作为群主。此外，添加外部用户进群时，外部用户必须和群主已成为飞书好友。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7d8a6e6df7621556ce0d21922b676706ccs</para>
    /// </summary>
    [JsonPropertyName("owner_id")]
    public string? OwnerId { get; set; }

    /// <summary>
    /// <para>创建群时邀请的群成员，不填则不邀请成员。ID 类型在查询参数 ==user_id_type== 中指定；推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</para>
    /// <para>**注意**：</para>
    /// <para>- 最多同时邀请 50 个用户</para>
    /// <para>- 为便于在客户端查看效果，建议调试接口时加入开发者自身 ID</para>
    /// <para>- 如果需要邀请外部用户，则外部用户必须和群主已成为飞书好友</para>
    /// <para>- 如何获取外部用户的 open_id，参考[获取外部用户的 open_id](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/develop-robots/add-bot-to-external-group#c38b1d97)</para>
    /// <para>必填：否</para>
    /// <para>示例值：["ou_7d8a6e6df7621556ce0d21922b676706ccs"]</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("user_id_list")]
    public string[]? UserIdList { get; set; }

    /// <summary>
    /// <para>创建群时邀请的群机器人，不填则不邀请机器人。可参考[如何获取应用的 App ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-app-id)来获取应用的 App ID</para>
    /// <para>**注意：**</para>
    /// <para>- 操作此接口的机器人会自动入群，无需重复填写</para>
    /// <para>- 拉机器人入群请使用 `app_id`</para>
    /// <para>- 最多同时邀请 5 个机器人，且邀请后群组中机器人数量不能超过 15 个</para>
    /// <para>必填：否</para>
    /// <para>示例值：["cli_a10fbf7e94b8d01d"]</para>
    /// <para>最大长度：5</para>
    /// </summary>
    [JsonPropertyName("bot_id_list")]
    public string[]? BotIdList { get; set; }

    /// <summary>
    /// <para>群消息形式</para>
    /// <para>必填：否</para>
    /// <para>示例值：chat</para>
    /// <para>可选值：<list type="bullet">
    /// <item>chat：对话消息</item>
    /// <item>thread：话题消息</item>
    /// </list></para>
    /// <para>默认值：chat</para>
    /// </summary>
    [JsonPropertyName("group_message_type")]
    public string? GroupMessageType { get; set; }

    /// <summary>
    /// <para>群模式</para>
    /// <para>**可选值有**：</para>
    /// <para>- `group`：群组</para>
    /// <para>必填：否</para>
    /// <para>示例值：group</para>
    /// <para>默认值：group</para>
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
    /// <para>默认值：private</para>
    /// </summary>
    [JsonPropertyName("chat_type")]
    public string? ChatType { get; set; }

    /// <summary>
    /// <para>成员入群提示消息的可见性</para>
    /// <para>**可选值有**：</para>
    /// <para>- `only_owner`：仅群主和管理员可见</para>
    /// <para>- `all_members`：所有成员可见</para>
    /// <para>- `not_anyone`：任何人均不可见</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_members</para>
    /// <para>默认值：all_members</para>
    /// </summary>
    [JsonPropertyName("join_message_visibility")]
    public string? JoinMessageVisibility { get; set; }

    /// <summary>
    /// <para>成员退群提示消息的可见性</para>
    /// <para>**可选值有**：</para>
    /// <para>- `only_owner`：仅群主和管理员可见</para>
    /// <para>- `all_members`：所有成员可见</para>
    /// <para>- `not_anyone`：任何人均不可见</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_members</para>
    /// <para>默认值：all_members</para>
    /// </summary>
    [JsonPropertyName("leave_message_visibility")]
    public string? LeaveMessageVisibility { get; set; }

    /// <summary>
    /// <para>加群是否需要审批</para>
    /// <para>**可选值有**：</para>
    /// <para>- `no_approval_required`：无需审批</para>
    /// <para>- `approval_required`：需要审批</para>
    /// <para>必填：否</para>
    /// <para>示例值：no_approval_required</para>
    /// <para>默认值：no_approval_required</para>
    /// </summary>
    [JsonPropertyName("membership_approval")]
    public string? MembershipApproval { get; set; }

    /// <summary>
    /// <para>保密模式设置</para>
    /// <para>**注意**：保密模式适用于企业旗舰版。适用版本与功能介绍参见[会话保密模式](https://www.feishu.cn/hc/zh-CN/articles/418691056559)。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("restricted_mode_setting")]
    public PostImV1ChatsBodyDtoRestrictedModeSetting? RestrictedModeSetting { get; set; }

    /// <summary>
    /// <para>保密模式设置</para>
    /// <para>**注意**：保密模式适用于企业旗舰版。适用版本与功能介绍参见[会话保密模式](https://www.feishu.cn/hc/zh-CN/articles/418691056559)。</para>
    /// </summary>
    public record PostImV1ChatsBodyDtoRestrictedModeSetting
    {
        /// <summary>
        /// <para>保密模式是否开启</para>
        /// <para>**可选值有**：</para>
        /// <para>- true：开启。设置为 ture 时，`screenshot_has_permission_setting`、`download_has_permission_setting`、`message_has_permission_setting` 不能全为 `all_members`。</para>
        /// <para>- false：不开启。设置为 false 时，`screenshot_has_permission_setting`、`download_has_permission_setting`、`message_has_permission_setting` 不能存在 `not_anyone`。</para>
        /// <para>**默认值**：false</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("status")]
        public bool? Status { get; set; }

        /// <summary>
        /// <para>允许截屏录屏</para>
        /// <para>**默认值**：all_members</para>
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
        /// <para>**默认值**：all_members</para>
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
        /// <para>**默认值**：all_members</para>
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
    /// <para>谁可以加急</para>
    /// <para>**默认值**：all_members</para>
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
    /// <para>**默认值**：all_members</para>
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
    /// <para>谁可以编辑群信息</para>
    /// <para>**默认值**：all_members</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_members</para>
    /// <para>可选值：<list type="bullet">
    /// <item>only_owner：仅群主和管理员</item>
    /// <item>all_members：所有成员</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("edit_permission")]
    public string? EditPermission { get; set; }

    /// <summary>
    /// <para>隐藏群成员人数设置</para>
    /// <para>**默认值**：all_members</para>
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
