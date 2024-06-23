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
/// <para>给指定消息添加指定类型的表情回复（reaction即表情回复，本文档统一用“reaction”代称）。</para>
/// <para>接口ID：6990603997012312066</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-reaction/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage-reaction%2fcreate</para>
/// </summary>
public record PostImV1MessagesByMessageIdReactionsBodyDto
{
    /// <summary>
    /// <para>reaction资源类型</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("reaction_type")]
    public Emoji ReactionType { get; set; } = new();

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
