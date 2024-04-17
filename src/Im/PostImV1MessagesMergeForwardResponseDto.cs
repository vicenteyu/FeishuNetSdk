namespace FeishuNetSdk.Im;
/// <summary>
/// 合并转发消息 响应体
/// <para>将来自同一个群聊中的多条消息合并转发给指定用户、群聊或话题。</para>
/// <para>接口ID：7210967154035638275</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/merge_forward</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fmerge_forward</para>
/// </summary>
public record PostImV1MessagesMergeForwardResponseDto
{
    /// <summary>
    /// <para>合并转发生成的新消息</para>
    /// <para>必填：否</para>
    /// <para>示例值：--</para>
    /// </summary>
    [JsonPropertyName("message")]
    public PostImV1MessagesMergeForwardResponseDtoMessage? Message { get; set; }

    /// <summary>
    /// <para>合并转发生成的新消息</para>
    /// </summary>
    public record PostImV1MessagesMergeForwardResponseDtoMessage
    {
        /// <summary>
        /// <para>消息id，说明参见：[消息ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/intro#ac79c1c2)</para>
        /// <para>必填：否</para>
        /// <para>示例值：om_dc13264520392913993dd051dba21dcf</para>
        /// </summary>
        [JsonPropertyName("message_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// <para>根消息id，用于回复消息场景，说明参见：[消息ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/intro#ac79c1c2)</para>
        /// <para>必填：否</para>
        /// <para>示例值：om_40eb06e7b84dc71c03e009ad3c754195</para>
        /// </summary>
        [JsonPropertyName("root_id")]
        public string? RootId { get; set; }

        /// <summary>
        /// <para>父消息的id，用于回复消息场景，说明参见：[消息ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/intro#ac79c1c2)</para>
        /// <para>必填：否</para>
        /// <para>示例值：om_d4be107c616aed9c1da8ed8068570a9f</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// <para>消息所属的话题 ID（不返回说明该消息非话题消息），说明参见：[话题介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/thread-introduction)</para>
        /// <para>必填：否</para>
        /// <para>示例值：omt_d4be107c616a</para>
        /// </summary>
        [JsonPropertyName("thread_id")]
        public string? ThreadId { get; set; }

        /// <summary>
        /// <para>消息类型 包括：text、post、image、file、audio、media、sticker、interactive、share_chat、share_user等，类型定义请参考[接收消息Content](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/im-v1/message/events/message_content)</para>
        /// <para>必填：否</para>
        /// <para>示例值：card</para>
        /// </summary>
        [JsonPropertyName("msg_type")]
        public string? MsgType { get; set; }

        /// <summary>
        /// <para>消息生成的时间戳（毫秒）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1609296809</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>消息更新的时间戳（毫秒）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1609336806</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// <para>消息是否被撤回</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// <para>消息是否被更新</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("updated")]
        public bool? Updated { get; set; }

        /// <summary>
        /// <para>所属的群</para>
        /// <para>必填：否</para>
        /// <para>示例值：oc_5ad11d72b830411d72b836c20</para>
        /// </summary>
        [JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// <para>发送者，可以是用户或应用</para>
        /// <para>必填：否</para>
        /// <para>示例值：object</para>
        /// </summary>
        [JsonPropertyName("sender")]
        public PostImV1MessagesMergeForwardResponseDtoMessageSender? Sender { get; set; }

        /// <summary>
        /// <para>发送者，可以是用户或应用</para>
        /// </summary>
        public record PostImV1MessagesMergeForwardResponseDtoMessageSender
        {
            /// <summary>
            /// <para>该字段标识发送者的id</para>
            /// <para>必填：是</para>
            /// <para>示例值：cli_9f427eec54ae901b</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string Id { get; set; } = string.Empty;

            /// <summary>
            /// <para>该字段标识发送者的id类型</para>
            /// <para>**可选值有：**</para>
            /// <para>- `open_id`</para>
            /// <para>- `app_id`</para>
            /// <para>必填：是</para>
            /// <para>示例值：app_id</para>
            /// </summary>
            [JsonPropertyName("id_type")]
            public string IdType { get; set; } = string.Empty;

            /// <summary>
            /// <para>该字段标识发送者的类型</para>
            /// <para>**可选值有：**</para>
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
            /// <para>为租户在飞书上的唯一标识，用来换取对应的tenant_access_token，也可以用作租户在应用里面的唯一标识</para>
            /// <para>必填：否</para>
            /// <para>示例值：736588c9260f175e</para>
            /// </summary>
            [JsonPropertyName("tenant_key")]
            public string? TenantKey { get; set; }
        }

        /// <summary>
        /// <para>消息内容</para>
        /// <para>必填：否</para>
        /// <para>示例值：json结构</para>
        /// </summary>
        [JsonPropertyName("body")]
        public MessageBody? Body { get; set; }

        /// <summary>
        /// <para>消息内容</para>
        /// </summary>
        public record MessageBody
        {
            /// <summary>
            /// <para>消息内容，json结构序列化后的字符串。不同msg_type对应不同内容。消息类型 包括：text、post、image、file、audio、media、sticker、interactive、share_chat、share_user等，类型定义请参考：[接收消息内容](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/im-v1/message/events/message_content)</para>
            /// <para>必填：是</para>
            /// <para>示例值：text:测试消息</para>
            /// </summary>
            [JsonPropertyName("content")]
            public string Content { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>被@的用户或机器人的id列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("mentions")]
        public Mention[]? Mentions { get; set; }

        /// <summary>
        /// <para>被@的用户或机器人的id列表</para>
        /// </summary>
        public record Mention
        {
            /// <summary>
            /// <para>被@的用户或机器人的序号。例如，第3个被@到的成员，值为“@_user_3”</para>
            /// <para>必填：是</para>
            /// <para>示例值：1@_user_1</para>
            /// </summary>
            [JsonPropertyName("key")]
            public string Key { get; set; } = string.Empty;

            /// <summary>
            /// <para>被@的用户或者机器人的open_id</para>
            /// <para>必填：是</para>
            /// <para>示例值：ou_155184d1e73cbfb8973e5a9e698e74f2</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string Id { get; set; } = string.Empty;

            /// <summary>
            /// <para>被@的用户或机器人 id 类型，目前仅支持 `open_id` ([什么是 Open ID？](https://open.feishu.cn/document/home/user-identity-introduction/open-id))</para>
            /// <para>必填：是</para>
            /// <para>示例值：open_id</para>
            /// </summary>
            [JsonPropertyName("id_type")]
            public string IdType { get; set; } = string.Empty;

            /// <summary>
            /// <para>被@的用户或机器人的姓名</para>
            /// <para>必填：是</para>
            /// <para>示例值：Tom</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string Name { get; set; } = string.Empty;

            /// <summary>
            /// <para>为租户在飞书上的唯一标识，用来换取对应的tenant_access_token，也可以用作租户在应用里面的唯一标识</para>
            /// <para>必填：否</para>
            /// <para>示例值：736588c9260f175e</para>
            /// </summary>
            [JsonPropertyName("tenant_key")]
            public string? TenantKey { get; set; }
        }

        /// <summary>
        /// <para>合并转发消息中，上一层级的消息id message_id，说明参见：[消息ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/intro#ac79c1c2)</para>
        /// <para>必填：否</para>
        /// <para>示例值：om_40eb06e7b84dc71c03e00ida3c754892</para>
        /// </summary>
        [JsonPropertyName("upper_message_id")]
        public string? UpperMessageId { get; set; }
    }

    /// <summary>
    /// <para>无效的消息ID列表，如不存在的消息、已被撤回的消息、不可见的历史消息、不支持的消息类型等。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("invalid_message_id_list")]
    public string[]? InvalidMessageIdList { get; set; }
}
