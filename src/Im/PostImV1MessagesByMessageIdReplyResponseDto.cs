// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1MessagesByMessageIdReplyResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>回复消息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 回复消息 响应体
/// <para>调用该接口回复指定消息。回复的内容支持文本、富文本、卡片、群名片、个人名片、图片、视频、文件等多种类型。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- 回复用户消息（即单聊消息）时，用户需要在机器人的[可用范围](https://open.feishu.cn/document/home/introduction-to-scope-and-authorization/availability)内。</para>
/// <para>- 回复群消息时，机器人需要在群中，且拥有发言权限。</para>
/// <para>## 使用限制</para>
/// <para>为避免消息发送频繁对用户造成打扰，向同一用户发送消息的限频为 ==5 QPS==、向同一群组发送消息的限频为群内机器人共享 ==5 QPS==。</para>
/// <para>接口ID：6946222929790500892</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/reply</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2freply</para>
/// </summary>
public record PostImV1MessagesByMessageIdReplyResponseDto
{
    /// <summary>
    /// <para>消息 ID。成功回复消息后，由系统生成的唯一 ID 标识。后续对消息的管理维护操作均需要使用该 ID。</para>
    /// <para>必填：否</para>
    /// <para>示例值：om_dc13264520392913993dd051dba21dcf</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }

    /// <summary>
    /// <para>根消息 ID。在有多个回复的消息树中，`root_id` 为根消息的 `message_id`。如果回复的是话题，则 `root_id` 为话题内根消息的 `message_id`。关于 `root_id` 的更多说明，参见[消息管理概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/intro)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：om_40eb06e7b84dc71c03e009ad3c754195</para>
    /// </summary>
    [JsonPropertyName("root_id")]
    public string? RootId { get; set; }

    /// <summary>
    /// <para>父消息 ID。在有多个回复的消息树中，`parent_id` 为当前消息上一层的消息 `message_id`。如果回复的是话题，则 `parent_id` 始终为话题内根消息的 `message_id`。关于 `parent_id` 的更多说明，参见[消息管理概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/intro)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：om_d4be107c616aed9c1da8ed8068570a9f</para>
    /// </summary>
    [JsonPropertyName("parent_id")]
    public string? ParentId { get; set; }

    /// <summary>
    /// <para>消息所属的话题 ID（不返回说明该消息不是话题形式的消息）。了解话题可参见[话题概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/thread-introduction)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：omt_d4be107c616a</para>
    /// </summary>
    [JsonPropertyName("thread_id")]
    public string? ThreadId { get; set; }

    /// <summary>
    /// <para>消息类型。</para>
    /// <para>**可能值有**：</para>
    /// <para>- text：文本</para>
    /// <para>- post：富文本</para>
    /// <para>- image：图片</para>
    /// <para>- file：文件</para>
    /// <para>- audio：语音</para>
    /// <para>- media：视频</para>
    /// <para>- sticker：表情包</para>
    /// <para>- interactive：卡片</para>
    /// <para>- share_chat：分享群名片</para>
    /// <para>- share_user：分享个人名片</para>
    /// <para>必填：否</para>
    /// <para>示例值：interactive</para>
    /// </summary>
    [JsonPropertyName("msg_type")]
    public string? MsgType { get; set; }

    /// <summary>
    /// <para>消息生成的时间戳。单位：毫秒</para>
    /// <para>必填：否</para>
    /// <para>示例值：1615380573411</para>
    /// </summary>
    [JsonPropertyName("create_time")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// <para>消息更新的时间戳。单位：毫秒</para>
    /// <para>必填：否</para>
    /// <para>示例值：1615380573411</para>
    /// </summary>
    [JsonPropertyName("update_time")]
    public string? UpdateTime { get; set; }

    /// <summary>
    /// <para>当前消息是否被撤回。回复消息时只会返回 false，表示未被撤回。</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    /// <summary>
    /// <para>当前消息是否被更新。回复消息时只会返回 false，表示未被更新。</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("updated")]
    public bool? Updated { get; set; }

    /// <summary>
    /// <para>消息所属的群 ID。你可以调用[获取群信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat/get)接口，根据群 ID 获取群详情。</para>
    /// <para>必填：否</para>
    /// <para>示例值：oc_5ad11d72b830411d72b836c20</para>
    /// </summary>
    [JsonPropertyName("chat_id")]
    public string? ChatId { get; set; }

    /// <summary>
    /// <para>当前消息的发送者信息。</para>
    /// <para>必填：否</para>
    /// <para>示例值：object</para>
    /// </summary>
    [JsonPropertyName("sender")]
    public PostImV1MessagesByMessageIdReplyResponseDtoSender? Sender { get; set; }

    /// <summary>
    /// <para>当前消息的发送者信息。</para>
    /// </summary>
    public record PostImV1MessagesByMessageIdReplyResponseDtoSender
    {
        /// <summary>
        /// <para>发送者的 ID。</para>
        /// <para>必填：是</para>
        /// <para>示例值：cli_9f427eec54ae901b</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>发送者的 ID 类型。</para>
        /// <para>**可能值有：**</para>
        /// <para>- `open_id`：表示发送者为用户，且返回的 ID 是用户的 open_id。</para>
        /// <para>- `app_id`：表示发送者为应用，且返回的 ID 是应用的 app_id。</para>
        /// <para>必填：是</para>
        /// <para>示例值：app_id</para>
        /// </summary>
        [JsonPropertyName("id_type")]
        public string IdType { get; set; } = string.Empty;

        /// <summary>
        /// <para>发送者类型。</para>
        /// <para>**可能值有：**</para>
        /// <para>- `user`: 用户</para>
        /// <para>- `app`: 应用</para>
        /// <para>- `anonymous`: 匿名</para>
        /// <para>- `unknown`: 未知</para>
        /// <para>必填：是</para>
        /// <para>示例值：app</para>
        /// </summary>
        [JsonPropertyName("sender_type")]
        public string SenderType { get; set; } = string.Empty;

        /// <summary>
        /// <para>租户唯一标识。该标识用来识别租户，也可以用来获取租户访问凭证（tenant_access_token）。</para>
        /// <para>必填：否</para>
        /// <para>示例值：736588c9260f175e</para>
        /// </summary>
        [JsonPropertyName("tenant_key")]
        public string? TenantKey { get; set; }
    }

    /// <summary>
    /// <para>通过 `body` 内的 `content` 参数，返回当前的消息内容。</para>
    /// <para>必填：否</para>
    /// <para>示例值：json结构</para>
    /// </summary>
    [JsonPropertyName("body")]
    public MessageBody? Body { get; set; }

    /// <summary>
    /// <para>通过 `body` 内的 `content` 参数，返回当前的消息内容。</para>
    /// </summary>
    public record MessageBody
    {
        /// <summary>
        /// <para>消息内容，JSON 结构序列化后的字符串，不同消息类型（`msg_type`）对应不同内容。</para>
        /// <para>必填：是</para>
        /// <para>示例值：{\"text\":\"@_user_1 test content\"}</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>发送的消息内，被 @ 的用户列表。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("mentions")]
    public Mention[]? Mentions { get; set; }

    /// <summary>
    /// <para>发送的消息内，被 @ 的用户列表。</para>
    /// </summary>
    public record Mention
    {
        /// <summary>
        /// <para>被 @ 的用户序号。例如，第 3 个被 @ 到的成员，取值为 `@_user_3`。</para>
        /// <para>必填：是</para>
        /// <para>示例值：@_user_1</para>
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// <para>被 @ 的用户的 open_id。</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_155184d1e73cbfb8973e5a9e698e74f2</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>被 @ 的用户的 ID 类型，目前仅支持 `open_id` (了解[什么是 Open ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id))。</para>
        /// <para>必填：是</para>
        /// <para>示例值：open_id</para>
        /// </summary>
        [JsonPropertyName("id_type")]
        public string IdType { get; set; } = string.Empty;

        /// <summary>
        /// <para>被 @ 的用户姓名。</para>
        /// <para>必填：是</para>
        /// <para>示例值：Tom</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>租户唯一标识。该标识用来识别被 @ 用户的租户，也可以用来获取租户访问凭证（tenant_access_token）。</para>
        /// <para>必填：否</para>
        /// <para>示例值：736588c9260f175e</para>
        /// </summary>
        [JsonPropertyName("tenant_key")]
        public string? TenantKey { get; set; }
    }

    /// <summary>
    /// <para>合并转发消息中，上一层级的消息 ID，仅在合并转发场景会有返回值。了解 upper_message_id 可参见[消息管理概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/intro)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：om_40eb06e7b84dc71c03e009ad3c754195</para>
    /// </summary>
    [JsonPropertyName("upper_message_id")]
    public string? UpperMessageId { get; set; }
}
