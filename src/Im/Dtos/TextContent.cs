// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="TextContent.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>文本消息</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 文本消息
    /// </summary>
    /// <param name="Text">文本消息</param>
    public record TextContent([property: JsonPropertyName("text")] string Text = "") : MessageContent("text");

}
