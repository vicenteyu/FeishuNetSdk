// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockBoard.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>画板 Block</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>画板 Block</para>
/// </summary>
public record BlockBoard
{
    /// <summary>
    /// <para>画板 token</para>
    /// <para>必填：否</para>
    /// <para>示例值：EfSPwsv03hVDKJbh1FWczJbWn90</para>
    /// </summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }

    /// <summary>
    /// <para>对齐方式</para>
    /// <para>必填：否</para>
    /// <para>示例值：2</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：居左排版</item>
    /// <item>2：居中排版</item>
    /// <item>3：居右排版</item>
    /// </list></para>
    /// <para>默认值：1</para>
    /// </summary>
    [JsonPropertyName("align")]
    public int? Align { get; set; }

    /// <summary>
    /// <para>宽度，单位 px；不填时自动适应文档宽度；值超出文档最大宽度时，页面渲染为文档最大宽度</para>
    /// <para>必填：否</para>
    /// <para>示例值：300</para>
    /// <para>最小值：90</para>
    /// </summary>
    [JsonPropertyName("width")]
    public int? Width { get; set; }

    /// <summary>
    /// <para>高度，单位 px；不填时自动根据画板内容计算；值超出屏幕两倍高度时，页面渲染为屏幕两倍高度</para>
    /// <para>必填：否</para>
    /// <para>示例值：300</para>
    /// <para>最小值：90</para>
    /// </summary>
    [JsonPropertyName("height")]
    public int? Height { get; set; }
}