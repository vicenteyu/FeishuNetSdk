// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="PlainTextElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>普通文本</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 普通文本
    /// </summary>
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
    /// <param name="TextColor">
    /// 文本的颜色。仅在 tag 为 plain_text 时生效。可取值：
    /// <list type="bullet">
    /// <item>default：客户端浅色主题模式下为黑色；客户端深色主题模式下为白色</item>
    /// <item>颜色的枚举值。详情参考颜色枚举值</item>
    /// </list>
    /// </param>
    /// <param name="TextAlign">
    /// 文本对齐方式。可取值：
    /// <list type="bullet">
    /// <item>left：左对齐</item>
    /// <item>center：居中对齐</item>
    /// <item>right：右对齐</item>
    /// </list>
    /// </param>
    /// <param name="Lines">内容最大显示行数，超出设置行的内容用 ... 省略。</param>
    public record PlainTextElement([property: JsonPropertyName("content")] string Content = "",
        [property: JsonPropertyName("text_size")] string? TextSize = null,
        [property: JsonPropertyName("text_color")] string? TextColor = null,
        [property: JsonPropertyName("text_align")] string? TextAlign = null,
        [property: JsonPropertyName("lines")] int? Lines = null) : Element("plain_text"), IAmDivTextElement, IAmNoteElement;
}
