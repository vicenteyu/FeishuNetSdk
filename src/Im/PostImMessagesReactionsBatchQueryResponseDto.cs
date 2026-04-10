// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-11
//
// Last Modified By : yxr
// Last Modified On : 2026-04-11
// ************************************************************************
// <copyright file="PostImMessagesReactionsBatchQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取消息表情回复 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 批量获取消息表情回复 响应体
/// <para>支持批量分页的获取消息上的表情详情、支持批量获取消息上表情的统计</para>
/// <para>## 前提条件</para>
/// <para>- 应用身份调用接口需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- 调用当前接口的机器人或者用户，需要在待查询的消息所属的会话内。</para>
/// <para>## 使用限制</para>
/// <para>已被撤回的消息、消息不可见等情况无法获取表情回复列表。</para>
/// <para>接口ID：7626724000588991682</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message-reaction/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage-reaction%2fbatch_query</para>
/// </summary>
public record PostImMessagesReactionsBatchQueryResponseDto
{
    /// <summary>
    /// <para>成功获取到的表情列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("success_msg_reaction_details")]
    public SuccessMsgReactionDetail[]? SuccessMsgReactionDetails { get; set; }

    /// <summary>
    /// <para>成功获取到的表情列表</para>
    /// </summary>
    public record SuccessMsgReactionDetail
    {
        /// <summary>
        /// <para>消息id</para>
        /// <para>必填：否</para>
        /// <para>示例值：om_a8f2294b************a1a38afaac9d</para>
        /// </summary>
        [JsonPropertyName("message_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// <para>是否还有更多项</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
        /// <para>必填：否</para>
        /// <para>示例值：NzYxNDA2NjMyNzA3Mzg1Mjk0NDoy</para>
        /// </summary>
        [JsonPropertyName("page_token")]
        public string? PageToken { get; set; }

        /// <summary>
        /// <para>表情实体</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("message_reaction_items")]
        public Reaction[]? MessageReactionItems { get; set; }

        /// <summary>
        /// <para>表情实体</para>
        /// </summary>
        public record Reaction
        {
            /// <summary>
            /// <para>表情ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ZCaCIjUBVVWSrm5L-3ZTw****</para>
            /// </summary>
            [JsonPropertyName("reaction_id")]
            public string? ReactionId { get; set; }

            /// <summary>
            /// <para>操作者信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("operator")]
            public OperatorSuffix? Operator { get; set; }

            /// <summary>
            /// <para>操作者信息</para>
            /// </summary>
            public record OperatorSuffix
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
                /// <item>app：应用</item>
                /// <item>user：用户</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("operator_type")]
                public string OperatorType { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>表情添加时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1626086391570</para>
            /// </summary>
            [JsonPropertyName("action_time")]
            public string? ActionTime { get; set; }

            /// <summary>
            /// <para>表情类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：SMILE</para>
            /// </summary>
            [JsonPropertyName("emoji_type")]
            public string? EmojiType { get; set; }
        }
    }

    /// <summary>
    /// <para>每条消息上所有表情的数量统计</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("success_msg_reaction_counts")]
    public SuccessMsgReactionCount[]? SuccessMsgReactionCounts { get; set; }

    /// <summary>
    /// <para>每条消息上所有表情的数量统计</para>
    /// </summary>
    public record SuccessMsgReactionCount
    {
        /// <summary>
        /// <para>消息ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：om_8964d1b4*********2b31383276113</para>
        /// </summary>
        [JsonPropertyName("message_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// <para>消息上不同表情的数量</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("reaction_count")]
        public ReactionCount[]? ReactionCounts { get; set; }

        /// <summary>
        /// <para>消息上不同表情的数量</para>
        /// </summary>
        public record ReactionCount
        {
            /// <summary>
            /// <para>表情类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：LAUGH</para>
            /// </summary>
            [JsonPropertyName("reaction_type")]
            public string? ReactionType { get; set; }

            /// <summary>
            /// <para>表情数量</para>
            /// <para>必填：否</para>
            /// <para>示例值：20</para>
            /// </summary>
            [JsonPropertyName("count")]
            public string? Count { get; set; }
        }
    }

    /// <summary>
    /// <para>未成功获取的消息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("fail_msg_reaction_details")]
    public FailMsgReactionDetail[]? FailMsgReactionDetails { get; set; }

    /// <summary>
    /// <para>未成功获取的消息</para>
    /// </summary>
    public record FailMsgReactionDetail
    {
        /// <summary>
        /// <para>消息id</para>
        /// <para>必填：否</para>
        /// <para>示例值：om_8964d1b4*********2b31383276113</para>
        /// </summary>
        [JsonPropertyName("message_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// <para>获取表情失败的原因</para>
        /// <para>必填：否</para>
        /// <para>示例值：invalid</para>
        /// <para>可选值：<list type="bullet">
        /// <item>invalid：无效的消息ID</item>
        /// <item>invalid_page_token：该消息对应的page_token无效</item>
        /// <item>no_permission：操作者对该消息无权限</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("fail_reason")]
        public string? FailReason { get; set; }
    }
}
