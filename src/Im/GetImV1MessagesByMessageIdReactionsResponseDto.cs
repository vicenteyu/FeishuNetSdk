namespace FeishuNetSdk.Im;
/// <summary>
/// 获取消息表情回复 响应体
/// <para>获取指定消息的特定类型表情回复列表（reaction即表情回复，本文档统一用“reaction”代称）。</para>
/// <para>接口ID：6990603997012279298</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-reaction/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage-reaction%2flist</para>
/// </summary>
public record GetImV1MessagesByMessageIdReactionsResponseDto
{
    /// <summary>
    /// <para> 查询指定reaction_type返回的reaction列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("items")]
    public MessageReaction[] Items { get; set; } = Array.Empty<MessageReaction>();

    /// <summary>
    /// <para> 查询指定reaction_type返回的reaction列表</para>
    /// </summary>
    public record MessageReaction
    {
        /// <summary>
        /// <para>reaction资源ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ZCaCIjUBVVWSrm5L-3ZTw*************sNa8dHVplEzzSfJVUVLMLcS_</para>
        /// </summary>
        [JsonPropertyName("reaction_id")]
        public string? ReactionId { get; set; }

        /// <summary>
        /// <para>添加reaction的操作人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("operator")]
        public MessageReactionOperator? Operator { get; set; }

        /// <summary>
        /// <para>添加reaction的操作人</para>
        /// </summary>
        public record MessageReactionOperator
        {
            /// <summary>
            /// <para>操作人ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：ou_ff0b7ba35fb********67dfc8b885136</para>
            /// </summary>
            [JsonPropertyName("operator_id")]
            public string OperatorId { get; set; } = string.Empty;

            /// <summary>
            /// <para>操作人身份，用户或应用</para>
            /// <para>必填：是</para>
            /// <para>示例值：user</para>
            /// <para>可选值：<list type="bullet">
            /// <item>app："app"</item>
            /// <item>user："user"</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("operator_type")]
            public string OperatorType { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>reaction动作的的unix timestamp(单位:ms)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1663054162546</para>
        /// </summary>
        [JsonPropertyName("action_time")]
        public string? ActionTime { get; set; }

        /// <summary>
        /// <para>reaction资源类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("reaction_type")]
        public Emoji? ReactionType { get; set; }

        /// <summary>
        /// <para>reaction资源类型</para>
        /// </summary>
        public record Emoji
        {
            /// <summary>
            /// <para>emoji类型 [emoji类型列举](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message-reaction/emojis-introduce)</para>
            /// <para>必填：是</para>
            /// <para>示例值：Actionunavailableasthemessagehasbeendeleted.</para>
            /// </summary>
            [JsonPropertyName("emoji_type")]
            public string EmojiType { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：SMILE</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string PageToken { get; set; } = string.Empty;
}
