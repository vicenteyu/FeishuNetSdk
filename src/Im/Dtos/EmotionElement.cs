// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="EmotionElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>表情消息</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 表情消息
    /// </summary>
    /// <param name="EmojiType">表情类型，部分可选值请参见表情文案。</param>
    public record EmotionElement([property: JsonPropertyName("emoji_type")] string EmojiType = "") : Element("emotion");
}
