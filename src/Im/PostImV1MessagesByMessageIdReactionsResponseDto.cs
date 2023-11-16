namespace FeishuNetSdk.Im;
/// <summary>
/// 添加消息表情回复 响应体
/// <para>给指定消息添加指定类型的表情回复（reaction即表情回复，本文档统一用“reaction”代称）。</para>
/// <para>接口ID：6990603997012312066</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-reaction/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage-reaction%2fcreate</para>
/// </summary>
public record PostImV1MessagesByMessageIdReactionsResponseDto
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
    public PostImV1MessagesByMessageIdReactionsResponseDtoOperator? Operator { get; set; }

    /// <summary>
    /// <para>添加reaction的操作人</para>
    /// </summary>
    public record PostImV1MessagesByMessageIdReactionsResponseDtoOperator
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
        /// <para>示例值：SMILE</para>
        /// </summary>
        [JsonPropertyName("emoji_type")]
        public string EmojiType { get; set; } = string.Empty;
    }
}
