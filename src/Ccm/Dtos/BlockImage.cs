// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockImage.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>图片 Block</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>图片 Block</para>
/// </summary>
public record BlockImage
{
    /// <summary>
    /// <para>宽度，单位 px</para>
    /// <para>必填：否</para>
    /// <para>示例值：4069</para>
    /// </summary>
    [JsonPropertyName("width")]
    public int? Width { get; set; }

    /// <summary>
    /// <para>高度，单位 px</para>
    /// <para>必填：否</para>
    /// <para>示例值：2480</para>
    /// </summary>
    [JsonPropertyName("height")]
    public int? Height { get; set; }

    /// <summary>
    /// <para>图片 Token</para>
    /// <para>必填：否</para>
    /// <para>示例值：boxbcVA91JtFgNhaCgy6s6wK4he</para>
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
    /// <para>默认值：2</para>
    /// </summary>
    [JsonPropertyName("align")]
    public int? Align { get; set; }

    /// <summary>
    /// <para>图片描述</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("caption")]
    public BlockImageCaption? Caption { get; set; }

    /// <summary>
    /// <para>图片描述</para>
    /// </summary>
    public record BlockImageCaption
    {
        /// <summary>
        /// <para>描述的文本内容</para>
        /// <para>必填：否</para>
        /// <para>示例值：caption</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }
    }
}
