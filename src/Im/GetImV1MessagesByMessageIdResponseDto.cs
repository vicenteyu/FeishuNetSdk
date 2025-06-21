// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetImV1MessagesByMessageIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取指定消息的内容 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 获取指定消息的内容 响应体
/// <para>调用该接口通过消息的 `message_id` 查询消息内容。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- 机器人必须在消息所属的群组内。</para>
/// <para>接口ID：6946222929790451740</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fget</para>
/// </summary>
public record GetImV1MessagesByMessageIdResponseDto
{
    /// <summary>
    /// <para>消息内容。</para>
    /// <para>**注意**：如果查询的消息类型为合并转发（merge_forward），则返回的 `items` 中会包含 1 条合并转发消息和 N 条子消息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Message[]? Items { get; set; }

    /// <summary>
    /// <para>消息内容。</para>
    /// <para>**注意**：如果查询的消息类型为合并转发（merge_forward），则返回的 `items` 中会包含 1 条合并转发消息和 N 条子消息。</para>
    /// </summary>
    public record Message
    {
        /// <summary>
        /// <para>消息 ID。</para>
        /// <para>必填：否</para>
        /// <para>示例值：om_dc13264520392913993dd051dba21dcf</para>
        /// </summary>
        [JsonPropertyName("message_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// <para>根消息 ID，仅在回复消息场景会有返回值。了解 root_id 可参见[消息管理概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/intro)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：om_40eb06e7b84dc71c03e009ad3c754195</para>
        /// </summary>
        [JsonPropertyName("root_id")]
        public string? RootId { get; set; }

        /// <summary>
        /// <para>父消息 ID，仅在回复消息场景会有返回值。了解 parent_id 可参见[消息管理概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/intro)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：om_d4be107c616aed9c1da8ed8068570a9f</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// <para>消息所属的话题 ID（不返回说明该消息非话题消息）。了解话题可参见[话题概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/thread-introduction)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：omt_d4be107c616a</para>
        /// </summary>
        [JsonPropertyName("thread_id")]
        public string? ThreadId { get; set; }

        /// <summary>
        /// <para>消息类型。类型定义参考[接收消息内容](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/im-v1/message/events/message_content)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：text</para>
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
        /// <para>消息是否被撤回或删除。</para>
        /// <para>- true：是，如果是被撤回的消息，content 参数没有返回值。</para>
        /// <para>- false：否</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// <para>消息是否被更新。</para>
        /// <para>- true：是</para>
        /// <para>- false：否</para>
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
        /// <para>消息的发送者信息。</para>
        /// <para>必填：否</para>
        /// <para>示例值：object</para>
        /// </summary>
        [JsonPropertyName("sender")]
        public MessageSender? Sender { get; set; }

        /// <summary>
        /// <para>消息的发送者信息。</para>
        /// </summary>
        public record MessageSender
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
            /// <para>- 如果发送者是应用，类型为 `app_id`。</para>
            /// <para>- 如果发送者为用户，类型与查询参数 `user_id_type` 的取值一致。</para>
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
            /// <para>**注意**：</para>
            /// <para>- 卡片消息内容与在卡片搭建工具中获取的卡片 JSON 不一致，暂不支持返回原始卡片 JSON。</para>
            /// <para>- 暂不支持返回 JSON 2.0 卡片的具体内容。</para>
            /// <para>必填：是</para>
            /// <para>示例值：{\"text\":\"test content\"}</para>
            /// </summary>
            [JsonPropertyName("content")]
            public string Content { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>消息内被 @ 的用户或机器人列表。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("mentions")]
        public Mention[]? Mentions { get; set; }

        /// <summary>
        /// <para>消息内被 @ 的用户或机器人列表。</para>
        /// </summary>
        public record Mention
        {
            /// <summary>
            /// <para>被 @ 的用户或机器人序号。例如，第 3 个被 @ 到的成员，取值为 `@_user_3`。</para>
            /// <para>必填：是</para>
            /// <para>示例值：@_user_1</para>
            /// </summary>
            [JsonPropertyName("key")]
            public string Key { get; set; } = string.Empty;

            /// <summary>
            /// <para>被 @ 的用户或机器人的 ID。</para>
            /// <para>**注意**：</para>
            /// <para>- 当不填写 `user_id_type`时，该字段将返回被 @ 的用户或机器人的 open_id。</para>
            /// <para>- 当填写 `user_id_type` 时，该字段将返回 @ 的用户对应类型的 ID（open_id、union_id 或 user_id）或机器人的 app_id。</para>
            /// <para>必填：是</para>
            /// <para>示例值：ou_155184d1e73cbfb8973e5a9e698e74f2</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string Id { get; set; } = string.Empty;

            /// <summary>
            /// <para>被 @ 的用户或机器人 ID 类型。</para>
            /// <para>必填：是</para>
            /// <para>示例值：open_id</para>
            /// </summary>
            [JsonPropertyName("id_type")]
            public string IdType { get; set; } = string.Empty;

            /// <summary>
            /// <para>被 @ 的用户或机器人的姓名。</para>
            /// <para>必填：是</para>
            /// <para>示例值：Tom</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string Name { get; set; } = string.Empty;

            /// <summary>
            /// <para>租户唯一标识。该标识用来识别被 @ 用户或机器人的租户，也可以用来获取租户访问凭证（tenant_access_token）。</para>
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
}
