// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="DeleteImV1MessagesByMessageIdReactionsByReactionIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除消息表情回复 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 删除消息表情回复 响应体
/// <para>删除指定消息的表情回复（reaction即表情回复，本文档统一用“reaction”代称）。</para>
/// <para>接口ID：6990603997012295682</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-reaction/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage-reaction%2fdelete</para>
/// </summary>
public record DeleteImV1MessagesByMessageIdReactionsByReactionIdResponseDto
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
    public DeleteImV1MessagesByMessageIdReactionsByReactionIdResponseDtoOperator? Operator { get; set; }

    /// <summary>
    /// <para>添加reaction的操作人</para>
    /// </summary>
    public record DeleteImV1MessagesByMessageIdReactionsByReactionIdResponseDtoOperator
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
    /// <para>示例值：1626086391570</para>
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
