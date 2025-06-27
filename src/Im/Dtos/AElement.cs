// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="AElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>链接消息</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 链接消息
    /// </summary>
    /// <param name="Text">文本内容</param>
    /// <param name="Href">默认的链接地址，请确保链接地址的合法性，否则消息会发送失败。</param>
    /// <param name="Style">用于配置文本内容加粗、下划线、删除线和斜体样式，可选值分别为bold、underline、lineThrough与italic，非可选值将被忽略。</param>
    public record AElement([property: JsonPropertyName("text")] string Text = "",
        [property: JsonPropertyName("href")] string Href = "",
        [property: JsonPropertyName("style")] string[]? Style = null) : Element("a");
}
