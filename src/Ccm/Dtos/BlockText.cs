// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockText.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>文本 Block</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>文本 Block</para>
/// </summary>
public record BlockText
{
    /// <summary>
    /// <para>文本样式</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("style")]
    public TextStyle? Style { get; set; }

    /// <summary>
    /// <para>文本元素</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("elements")]
    public TextElement[] Elements { get; set; } = [];
}
