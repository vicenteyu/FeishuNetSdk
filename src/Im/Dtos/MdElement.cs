// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="MdElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>markdown 内容</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// markdown 内容
    /// </summary>
    /// <param name="Text">markdown 内容</param>
    public record MdElement([property: JsonPropertyName("text")] string Text = "") : Element("md");
}
