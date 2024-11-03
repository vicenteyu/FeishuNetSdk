// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PutImV1ChatsByChatIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新群信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 更新群信息 请求体
/// <para>更新指定群的信息，包括群头像、群名称、群描述、群配置以及群主等。</para>
/// <para>## 前提条件</para>
/// <para>应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>## 使用限制</para>
/// <para>- 对于群主和群管理员，或是创建群组且具备 ==更新应用所创建群的群信息（im:chat:operate_as_owner）== 权限的机器人，可调用本接口更新所有信息。</para>
/// <para>- 对于不满足上述权限条件的群成员或机器人：</para>
/// <para>- 如果群设置中配置了 **所有群成员可编辑群信息**，则仅可更新群头像、群名称、群描述、群国际化名称信息。</para>
/// <para>- 如果群设置中配置了 **仅群主和群管理员可编辑群信息**，则无法修改任何群信息。</para>
/// <para>## 注意事项</para>
/// <para>调用该接口时，未传值的请求参数默认不更新，保持原有群信息。</para>
/// <para>接口ID：6946222931479592961</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/update-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat%2fupdate</para>
/// </summary>
public record PutImV1ChatsByChatIdBodyDto
{
    /// <summary>
    /// <para>群头像对应的 Image Key，可通过[上传图片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/image/create)获取（注意：上传图片的 ==image_type== 需要指定为 ==avatar==）</para>
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
    /// <para>必填：否</para>
    /// <para>示例值：群聊</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>群描述，建议不超过 100 字符</para>
    /// <para>必填：否</para>
    /// <para>示例值：测试群描述</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>群国际化名称，建议不超过 60 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("i18n_names")]
    public PutImV1ChatsByChatIdBodyDtoI18nNames? I18nNames { get; set; }

    /// <summary>
    /// <para>群国际化名称，建议不超过 60 字符</para>
    /// </summary>
    public record PutImV1ChatsByChatIdBodyDtoI18nNames
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
    /// <para>谁可以添加群成员，群成员包括用户或机器人</para>
    /// <para>**可选值有**：</para>
    /// <para>- `only_owner`：仅群主和管理员</para>
    /// <para>- `all_members`：所有成员</para>
    /// <para>**注意**：`add_member_permission` 和 `share_card_permission` 两个参数必须同步配置。</para>
    /// <para>- 如果 `add_member_permission` 值为 `only_owner`，则 `share_card_permission` 只能设置为 `not_allowed`。</para>
    /// <para>- 如果 `add_member_permission` 值为`all_members`，则 `share_card_permission` 只能设置为 `allowed`。</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_members</para>
    /// </summary>
    [JsonPropertyName("add_member_permission")]
    public string? AddMemberPermission { get; set; }

    /// <summary>
    /// <para>是否允许分享群</para>
    /// <para>**可选值有**：</para>
    /// <para>- `allowed`：允许</para>
    /// <para>- `not_allowed`：不允许</para>
    /// <para>**注意**：`add_member_permission` 和 `share_card_permission` 两个参数必须同步配置。</para>
    /// <para>- 如果 `add_member_permission` 值为 `only_owner`，则 `share_card_permission` 只能设置为 `not_allowed`。</para>
    /// <para>- 如果 `add_member_permission` 值为`all_members`，则 `share_card_permission` 只能设置为 `allowed`。</para>
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
    /// <para>示例值：all_members</para>
    /// </summary>
    [JsonPropertyName("at_all_permission")]
    public string? AtAllPermission { get; set; }

    /// <summary>
    /// <para>谁可以编辑群信息</para>
    /// <para>**可选值有**：</para>
    /// <para>- `only_owner`：仅群主和管理员</para>
    /// <para>- `all_members`：所有成员</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_members</para>
    /// </summary>
    [JsonPropertyName("edit_permission")]
    public string? EditPermission { get; set; }

    /// <summary>
    /// <para>新群主的用户 ID，不转让群主时无需填写。ID 类型与查询参数 user_id_type 取值一致，ID 类型推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：4d7a3c6g</para>
    /// </summary>
    [JsonPropertyName("owner_id")]
    public string? OwnerId { get; set; }

    /// <summary>
    /// <para>成员入群提示消息的可见性</para>
    /// <para>**可选值有**：</para>
    /// <para>- `only_owner`：仅群主和管理员可见</para>
    /// <para>- `all_members`：所有成员可见</para>
    /// <para>- `not_anyone`：任何人均不可见</para>
    /// <para>必填：否</para>
    /// <para>示例值：only_owner</para>
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
    /// <para>示例值：only_owner</para>
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
    /// </summary>
    [JsonPropertyName("membership_approval")]
    public string? MembershipApproval { get; set; }

    /// <summary>
    /// <para>保密模式设置</para>
    /// <para>**注意**：保密模式适用于企业旗舰版。适用版本与功能介绍参见[会话保密模式](https://www.feishu.cn/hc/zh-CN/articles/418691056559)。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("restricted_mode_setting")]
    public PutImV1ChatsByChatIdBodyDtoRestrictedModeSetting? RestrictedModeSetting { get; set; }

    /// <summary>
    /// <para>保密模式设置</para>
    /// <para>**注意**：保密模式适用于企业旗舰版。适用版本与功能介绍参见[会话保密模式](https://www.feishu.cn/hc/zh-CN/articles/418691056559)。</para>
    /// </summary>
    public record PutImV1ChatsByChatIdBodyDtoRestrictedModeSetting
    {
        /// <summary>
        /// <para>保密模式是否开启</para>
        /// <para>**可选值有**：</para>
        /// <para>- true：开启。设置为 ture 时，`screenshot_has_permission_setting`、`download_has_permission_setting`、`message_has_permission_setting` 不能全为 `all_members`。</para>
        /// <para>- false：不开启。设置为 false 时，`screenshot_has_permission_setting`、`download_has_permission_setting`、`message_has_permission_setting` 不能存在 `not_anyone`。</para>
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
    /// <para>群消息形式</para>
    /// <para>必填：否</para>
    /// <para>示例值：chat</para>
    /// <para>可选值：<list type="bullet">
    /// <item>chat：对话消息</item>
    /// <item>thread：话题消息</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("group_message_type")]
    public string? GroupMessageType { get; set; }

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
