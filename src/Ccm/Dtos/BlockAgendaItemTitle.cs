// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockAgendaItemTitle.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>议程项标题 Block</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>议程项标题 Block</para>
/// </summary>
public record BlockAgendaItemTitle
{
    /// <summary>
    /// <para>文本元素</para>
    /// <para>必填：是</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("elements")]
    public TextElement[] Elements { get; set; } = [];

    /// <summary>
    /// <para>对齐方式</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：居左排版</item>
    /// <item>2：居中排版</item>
    /// <item>3：居右排版</item>
    /// </list></para>
    /// <para>默认值：1</para>
    /// </summary>
    [JsonPropertyName("align")]
    public int? Align { get; set; }
}