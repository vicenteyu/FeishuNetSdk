// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockSourceSynced.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>源同步块</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>源同步块</para>
/// </summary>
public record BlockSourceSynced
{
    /// <summary>
    /// <para>同步块独立页标题，由文本元素组成</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("elements")]
    public TextElement[]? Elements { get; set; }

    /// <summary>
    /// <para>对齐方式</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：居左排版</item>
    /// <item>2：居中排版</item>
    /// <item>3：居右排版</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("align")]
    public int? Align { get; set; }
}