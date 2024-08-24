// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1MessagesByMessageIdReactionsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加消息表情回复 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 添加消息表情回复 请求体
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
public record PostImV1MessagesByMessageIdReactionsBodyDto
{
    /// <summary>
    /// <para>表情类型</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("reaction_type")]
    public Emoji ReactionType { get; set; } = new();

    /// <summary>
    /// <para>表情类型</para>
    /// </summary>
    public record Emoji
    {
        /// <summary>
        /// <para>emoji 类型。支持的表情与对应的 emoji_type 值参见[表情文案说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message-reaction/emojis-introduce)。</para>
        /// <para>必填：是</para>
        /// <para>示例值：SMILE</para>
        /// </summary>
        [JsonPropertyName("emoji_type")]
        public string EmojiType { get; set; } = string.Empty;
    }
}
