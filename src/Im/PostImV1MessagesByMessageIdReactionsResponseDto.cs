// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1MessagesByMessageIdReactionsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加消息表情回复 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 添加消息表情回复 响应体
/// <para>给指定消息添加指定类型的表情回复。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- 调用当前接口的机器人或者用户，需要在待添加表情回复的消息所属的会话内。</para>
/// <para>## 使用限制</para>
/// <para>- 已被撤回的消息无法添加表情回复。</para>
/// <para>- [系统消息（system）](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/im-v1/message/create_json#e159cb73)无法添加表情回复。</para>
/// <para>接口ID：6990603997012312066</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-reaction/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage-reaction%2fcreate</para>
/// </summary>
public record PostImV1MessagesByMessageIdReactionsResponseDto
{
    /// <summary>
    /// <para>表情回复 ID。为消息添加表情回复后，会获得该表情回复的唯一标识 ID，后续使用该 ID 可以[删除消息表情回复](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message-reaction/delete)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ZCaCIjUBVVWSrm5L-3ZTw*************sNa8dHVplEzzSfJVUVLMLcS_</para>
    /// </summary>
    [JsonPropertyName("reaction_id")]
    public string? ReactionId { get; set; }

    /// <summary>
    /// <para>添加消息表情回复的操作人。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator")]
    public PostImV1MessagesByMessageIdReactionsResponseDtoOperator? Operator { get; set; }

    /// <summary>
    /// <para>添加消息表情回复的操作人。</para>
    /// </summary>
    public record PostImV1MessagesByMessageIdReactionsResponseDtoOperator
    {
        /// <summary>
        /// <para>操作人 ID，具体的取值与 `operator_type` 相关：</para>
        /// <para>- 当 `operator_type` 取值 `app` 时返回机器人的应用 ID（app_id）。</para>
        /// <para>- 当 `operator_type` 取值 `user` 时返回用户的 open_id。</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_ff0b7ba35fb********67dfc8b885136</para>
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; } = string.Empty;

        /// <summary>
        /// <para>操作人身份。</para>
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
    /// <para>添加消息表情回复的时间。Unix 时间戳，单位：ms</para>
    /// <para>必填：否</para>
    /// <para>示例值：1663054162546</para>
    /// </summary>
    [JsonPropertyName("action_time")]
    public string? ActionTime { get; set; }

    /// <summary>
    /// <para>表情类型</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("reaction_type")]
    public Emoji? ReactionType { get; set; }

    /// <summary>
    /// <para>表情类型</para>
    /// </summary>
    public record Emoji
    {
        /// <summary>
        /// <para>emoji 类型。emoji_type 值对应的表情参考[表情文案说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message-reaction/emojis-introduce)。</para>
        /// <para>必填：是</para>
        /// <para>示例值：SMILE</para>
        /// </summary>
        [JsonPropertyName("emoji_type")]
        public string EmojiType { get; set; } = string.Empty;
    }
}
