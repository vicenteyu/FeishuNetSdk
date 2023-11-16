namespace FeishuNetSdk.Im;
/// <summary>
/// 编辑消息 响应体
/// <para>编辑已发送的消息内容，当前支持编辑文本、富文本消息。如需更新消息卡片，请参考[更新应用发送的消息卡片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/patch)。</para>
/// <para>接口ID：7239186075281358852</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fupdate</para>
/// </summary>
public record PutImV1MessagesByMessageIdResponseDto
{
    /// <summary>
    /// <para>消息id open_message_id</para>
    /// <para>必填：否</para>
    /// <para>示例值：om_dc13264520392913993dd051dba21dcf</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }

    /// <summary>
    /// <para>根消息id open_message_id</para>
    /// <para>必填：否</para>
    /// <para>示例值：om_40eb06e7b84dc71c03e009ad3c754195</para>
    /// </summary>
    [JsonPropertyName("root_id")]
    public string? RootId { get; set; }

    /// <summary>
    /// <para>父消息的id open_message_id</para>
    /// <para>必填：否</para>
    /// <para>示例值：om_d4be107c616aed9c1da8ed8068570a9f</para>
    /// </summary>
    [JsonPropertyName("parent_id")]
    public string? ParentId { get; set; }

    /// <summary>
    /// <para>消息类型 text post card image等等</para>
    /// <para>必填：否</para>
    /// <para>示例值：card</para>
    /// </summary>
    [JsonPropertyName("msg_type")]
    public string? MsgType { get; set; }

    /// <summary>
    /// <para>消息生成的时间戳(毫秒)</para>
    /// <para>必填：否</para>
    /// <para>示例值：1609296809</para>
    /// </summary>
    [JsonPropertyName("create_time")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// <para>消息更新的时间戳</para>
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
    /// <para>示例值：true</para>
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
    public PutImV1MessagesByMessageIdResponseDtoSender? Sender { get; set; }

    /// <summary>
    /// <para>发送者，可以是用户或应用</para>
    /// </summary>
    public record PutImV1MessagesByMessageIdResponseDtoSender
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
        /// <para>必填：是</para>
        /// <para>示例值：app_id</para>
        /// </summary>
        [JsonPropertyName("id_type")]
        public string IdType { get; set; } = string.Empty;

        /// <summary>
        /// <para>该字段标识发送者的类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：app</para>
        /// </summary>
        [JsonPropertyName("sender_type")]
        public string SenderType { get; set; } = string.Empty;

        /// <summary>
        /// <para>tenant key</para>
        /// <para>必填：否</para>
        /// <para>示例值：736588c9260f175e</para>
        /// </summary>
        [JsonPropertyName("tenant_key")]
        public string? TenantKey { get; set; }
    }

    /// <summary>
    /// <para>消息内容，JSON结构</para>
    /// <para>必填：否</para>
    /// <para>示例值：json结构</para>
    /// </summary>
    [JsonPropertyName("body")]
    public MessageBody? Body { get; set; }

    /// <summary>
    /// <para>消息内容，JSON结构</para>
    /// </summary>
    public record MessageBody
    {
        /// <summary>
        /// <para>消息内容，JSON字符串格式</para>
        /// <para>必填：是</para>
        /// <para>示例值：{\"text\":\"@_user_1testcontent\"}</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>被艾特的人或应用的id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("mentions")]
    public Mention[]? Mentions { get; set; }

    /// <summary>
    /// <para>被艾特的人或应用的id</para>
    /// </summary>
    public record Mention
    {
        /// <summary>
        /// <para>mention key</para>
        /// <para>必填：是</para>
        /// <para>示例值：@_user_1</para>
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户或机器人的 open_id</para>
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
        /// <para>被at用户的姓名</para>
        /// <para>必填：是</para>
        /// <para>示例值：Tom</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>tenant key</para>
        /// <para>必填：否</para>
        /// <para>示例值：736588c9260f175e</para>
        /// </summary>
        [JsonPropertyName("tenant_key")]
        public string? TenantKey { get; set; }
    }

    /// <summary>
    /// <para>合并消息的上一层级消息id open_message_id</para>
    /// <para>必填：否</para>
    /// <para>示例值：om_40eb06e7b84dc71c03e00ida3c754892</para>
    /// </summary>
    [JsonPropertyName("upper_message_id")]
    public string? UpperMessageId { get; set; }
}
