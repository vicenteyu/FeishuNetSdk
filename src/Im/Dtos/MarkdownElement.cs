// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="MarkdownElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>富文本的（Markdown）</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 富文本的（Markdown）
    /// </summary>
    /// <param name="Icon"></param>
    /// <param name="Content">文本内容</param>
    /// <param name="TextSize">文本大小。
    /// <para>可取值如下所示。如果你填写了其它值，卡片将展示为 normal 字段对应的字号。你也可分别为移动端和桌面端定义不同的字号，详细步骤参考下文 为移动端和桌面端定义不同的字号。</para>
    /// <list type="bullet">
    /// <item>heading-0：特大标题（30px）</item>
    /// <item>heading-1：一级标题（24px）</item>
    /// <item>heading-2：二级标题（20 px）</item>
    /// <item>heading-3：三级标题（18px）</item>
    /// <item>heading-4：四级标题（16px）</item>
    /// <item>heading：标题（16px）</item>
    /// <item>normal：正文（14px）</item>
    /// <item>notation：辅助信息（12px）</item>
    /// <item>xxxx-large：30px</item>
    /// <item>xxx-large：24px</item>
    /// <item>xx-large：20px</item>
    /// <item>x-large：18px</item>
    /// <item>large：16px</item>
    /// <item>medium：14px</item>
    /// <item>small：12px</item>
    /// <item>x-small：10px</item>
    /// </list>
    /// </param>
    /// <param name="TextAlign">文本对齐方式
    /// <list type="bullet">
    /// <item>left：左对齐</item>
    /// <item>center：居中对齐</item>
    /// <item>right：右对齐</item>
    /// </list>
    /// </param>
    /// <param name="Href">配置差异化跳转链接，实现“不同设备跳转链接不同”的效果。</param>
    public record MarkdownElement(object? Icon = null,
        [property: JsonPropertyName("content")] string Content = "",
        [property: JsonPropertyName("text_size")] string? TextSize = null,
        [property: JsonPropertyName("text_align")] string? TextAlign = null,
        [property: JsonPropertyName("href")] MarkdownElement.HrefSuffix? Href = null) : Element("markdown")
    {
        /// <summary>
        /// 文本图标
        /// </summary>
        [JsonPropertyName("icon")]
        public object? Icon { get; set; } = Icon;

        /// <summary>
        /// 配置差异化跳转链接，实现“不同设备跳转链接不同”的效果。
        /// </summary>
        /// <param name="UrlVal">URL 的变量。</param>
        public record HrefSuffix([property: JsonPropertyName("urlVal")] UrlLink? UrlVal = null);
    }
}
