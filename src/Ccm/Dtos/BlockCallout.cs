// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockCallout.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>高亮块 Block</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>高亮块 Block</para>
/// </summary>
public record BlockCallout
{
    /// <summary>
    /// <para>高亮块背景色</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：浅红色</item>
    /// <item>2：浅橙色</item>
    /// <item>3：浅黄色</item>
    /// <item>4：浅绿色</item>
    /// <item>5：浅蓝色</item>
    /// <item>6：浅紫色</item>
    /// <item>7：浅灰色</item>
    /// <item>8：暗红色</item>
    /// <item>9：暗橙色</item>
    /// <item>10：暗黄色</item>
    /// <item>11：暗绿色</item>
    /// <item>12：暗蓝色</item>
    /// <item>13：暗紫色</item>
    /// <item>14：暗灰色</item>
    /// <item>15：暗银灰色</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("background_color")]
    public int? BackgroundColor { get; set; }

    /// <summary>
    /// <para>边框色</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：红色</item>
    /// <item>2：橙色</item>
    /// <item>3：黄色</item>
    /// <item>4：绿色</item>
    /// <item>5：蓝色</item>
    /// <item>6：紫色</item>
    /// <item>7：灰色</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("border_color")]
    public int? BorderColor { get; set; }

    /// <summary>
    /// <para>文字颜色</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：粉红色</item>
    /// <item>2：橙色</item>
    /// <item>3：黄色</item>
    /// <item>4：绿色</item>
    /// <item>5：蓝色</item>
    /// <item>6：紫色</item>
    /// <item>7：灰色</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("text_color")]
    public int? TextColor { get; set; }

    /// <summary>
    /// <para>高亮块图标</para>
    /// <para>必填：否</para>
    /// <para>示例值：pushpin</para>
    /// </summary>
    [JsonPropertyName("emoji_id")]
    public string? EmojiId { get; set; }
}