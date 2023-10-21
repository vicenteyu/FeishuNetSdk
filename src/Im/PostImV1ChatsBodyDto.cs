using Newtonsoft.Json;
namespace FeishuNetSdk.Im;
/// <summary>
/// 创建群 请求体
/// <para>创建群并设置群头像、群名、群描述等。</para>
/// <para>接口ID：6946222931479379969</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat%2fcreate</para>
/// </summary>
public record PostImV1ChatsBodyDto
{
    /// <summary>
    /// <para>群头像对应的 Image Key，可通过[上传图片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/image/create)获取（注意：上传图片的 ==image_type== 需要指定为 ==avatar==）</para>
    /// <para>必填：否</para>
    /// <para>示例值：default-avatar_44ae0ca3-e140-494b-956f-78091e348435</para>
    /// </summary>
    [JsonProperty("avatar")]
    public string? Avatar { get; set; }

    /// <summary>
    /// <para>群名称</para>
    /// <para>**注意：**</para>
    /// <para>- 公开群名称的长度不得少于2个字符</para>
    /// <para>- 私有群若未填写群名称，群名称默认设置为 ”`(无主题)`“</para>
    /// <para>必填：否</para>
    /// <para>示例值：测试群名称</para>
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>群描述</para>
    /// <para>必填：否</para>
    /// <para>示例值：测试群描述</para>
    /// </summary>
    [JsonProperty("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>群国际化名称</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("i18n_names")]
    public PostImV1ChatsBodyDtoI18nNames? I18nNames { get; set; }

    /// <summary>
    /// <para>群国际化名称</para>
    /// </summary>
    public record PostImV1ChatsBodyDtoI18nNames
    {
        /// <summary>
        /// <para>中文名</para>
        /// <para>必填：否</para>
        /// <para>示例值：群聊</para>
        /// </summary>
        [JsonProperty("zh_cn")]
        public string? ZhCn { get; set; }

        /// <summary>
        /// <para>英文名</para>
        /// <para>必填：否</para>
        /// <para>示例值：groupchat</para>
        /// </summary>
        [JsonProperty("en_us")]
        public string? EnUs { get; set; }

        /// <summary>
        /// <para>日文名</para>
        /// <para>必填：否</para>
        /// <para>示例值：グループチャット</para>
        /// </summary>
        [JsonProperty("ja_jp")]
        public string? JaJp { get; set; }
    }

    /// <summary>
    /// <para>创建群时指定的群主，不填时指定建群的机器人为群主。群主 ID值应与查询参数中的 ==user_id_type== 对应；推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7d8a6e6df7621556ce0d21922b676706ccs</para>
    /// </summary>
    [JsonProperty("owner_id")]
    public string? OwnerId { get; set; }

    /// <summary>
    /// <para>创建群时邀请的群成员，ID 类型在查询参数 ==user_id_type== 中指定；推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</para>
    /// <para>**注意**：</para>
    /// <para>- 最多同时邀请 50 个用户</para>
    /// <para>- 为便于在客户端查看效果，建议调试接口时加入开发者自身ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：["ou_7d8a6e6df7621556ce0d21922b676706ccs"]</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonProperty("user_id_list")]
    public string[]? UserIdList { get; set; }

    /// <summary>
    /// <para>创建群时邀请的群机器人；可参考[如何获取应用的 App ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-app-id)来获取应用的App ID</para>
    /// <para>**注意：**</para>
    /// <para>- 操作此接口的机器人会自动入群，无需重复填写</para>
    /// <para>- 拉机器人入群请使用`app_id`</para>
    /// <para>- 最多同时邀请5个机器人，并且群组最多容纳 15 个机器人</para>
    /// <para>必填：否</para>
    /// <para>示例值：["cli_a10fbf7e94b8d01d"]</para>
    /// <para>最大长度：5</para>
    /// </summary>
    [JsonProperty("bot_id_list")]
    public string[]? BotIdList { get; set; }

    /// <summary>
    /// <para>群模式</para>
    /// <para>**可选值有**：</para>
    /// <para>- `group`：群组</para>
    /// <para>必填：否</para>
    /// <para>示例值：group</para>
    /// <para>默认值：group</para>
    /// </summary>
    [JsonProperty("chat_mode")]
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
    [JsonProperty("chat_type")]
    public string? ChatType { get; set; }

    /// <summary>
    /// <para>入群消息可见性</para>
    /// <para>**可选值有**：</para>
    /// <para>- `only_owner`：仅群主和管理员可见</para>
    /// <para>- `all_members`：所有成员可见</para>
    /// <para>- `not_anyone`：任何人均不可见</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_members</para>
    /// <para>默认值：all_members</para>
    /// </summary>
    [JsonProperty("join_message_visibility")]
    public string? JoinMessageVisibility { get; set; }

    /// <summary>
    /// <para>退群消息可见性</para>
    /// <para>**可选值有**：</para>
    /// <para>- `only_owner`：仅群主和管理员可见</para>
    /// <para>- `all_members`：所有成员可见</para>
    /// <para>- `not_anyone`：任何人均不可见</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_members</para>
    /// <para>默认值：all_members</para>
    /// </summary>
    [JsonProperty("leave_message_visibility")]
    public string? LeaveMessageVisibility { get; set; }

    /// <summary>
    /// <para>加群审批</para>
    /// <para>**可选值有**：</para>
    /// <para>- `no_approval_required`：无需审批</para>
    /// <para>- `approval_required`：需要审批</para>
    /// <para>必填：否</para>
    /// <para>示例值：no_approval_required</para>
    /// <para>默认值：no_approval_required</para>
    /// </summary>
    [JsonProperty("membership_approval")]
    public string? MembershipApproval { get; set; }

    /// <summary>
    /// <para>保密模式设置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("restricted_mode_setting")]
    public PostImV1ChatsBodyDtoRestrictedModeSetting? RestrictedModeSetting { get; set; }

    /// <summary>
    /// <para>保密模式设置</para>
    /// </summary>
    public record PostImV1ChatsBodyDtoRestrictedModeSetting
    {
        /// <summary>
        /// <para>保密模式是否开启</para>
        /// <para>**注意**：</para>
        /// <para>- status为true时，screenshot_has_permission_setting、download_has_permission_setting、message_has_permission_setting不能全为all_members。</para>
        /// <para>- status为false时，screenshot_has_permission_setting、download_has_permission_setting、message_has_permission_setting不能存在not_anyone。</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("status")]
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
        [JsonProperty("screenshot_has_permission_setting")]
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
        [JsonProperty("download_has_permission_setting")]
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
        [JsonProperty("message_has_permission_setting")]
        public string? MessageHasPermissionSetting { get; set; }
    }

    /// <summary>
    /// <para>谁可以加急</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_members</para>
    /// <para>可选值：<list type="bullet">
    /// <item>only_owner：仅群主和管理员</item>
    /// <item>all_members：所有成员</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("urgent_setting")]
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
    [JsonProperty("video_conference_setting")]
    public string? VideoConferenceSetting { get; set; }

    /// <summary>
    /// <para>谁可以编辑群信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_members</para>
    /// <para>可选值：<list type="bullet">
    /// <item>only_owner：仅群主和管理员</item>
    /// <item>all_members：所有成员</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("edit_permission")]
    public string? EditPermission { get; set; }
}
