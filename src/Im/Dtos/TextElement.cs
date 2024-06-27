// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="TextElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>文本消息</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 文本消息
    /// </summary>
    /// <param name="Text">文本内容</param>
    /// <param name="UnEscape">表示是不是 unescape 解码，默认为 false ，不用可以不填。</param>
    /// <param name="Style">用于配置文本内容加粗、下划线、删除线和斜体样式，可选值分别为bold、underline、lineThrough与italic，非可选值将被忽略。</param>
    public record TextElement([property: JsonPropertyName("text")] string Text = "",
        [property: JsonPropertyName("un_escape")] bool UnEscape = false,
        [property: JsonPropertyName("style")] string[]? Style = null) : Element("text");
}
