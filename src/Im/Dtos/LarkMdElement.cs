// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="LarkMdElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>普通文本的Markdown</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 普通文本的Markdown
    /// </summary>
    /// <param name="Content">按钮上的文本，支持部分 Markdown 语法的文本内容。详情参考下文 lark_md 支持的 Markdown 语法。
    /// <para>
    /// 支持的 Markdown 语法：
    /// <list type="bullet">
    /// <item>换行：第一行\n第二行</item>
    /// <item>斜体：*斜体*</item>
    /// <item>粗体：**粗体** 或 __粗体__</item>
    /// <item>删除线：~~删除线~~</item>
    /// <item>文字链接：[文字链接](https://www.feishu.cn)</item>
    /// <item>超链接：&lt;a href='https://open.feishu.cn'&gt;&lt;/a&gt;</item>
    /// <item>@ 人：&lt;at id=all&gt;&lt;/at&gt;、&lt;at id={{open_id}}&gt;&lt;/at&gt;、&lt;at id={{user_id}}&gt;&lt;/at&gt;、&lt;at email=test@email.com&gt;&lt;/at&gt;</item>
    /// <item>彩色文本：&lt;font color=red&gt;红色&lt;/font&gt; 提示：要查看 color 枚举，参考颜色枚举值。</item>
    /// <item>emoji：😁😢🌞💼🏆❌✅</item>
    /// <item>飞书表情：:OK:&gt; 要查看表情枚举，参考表情文案说明。</item>
    /// <item>标签：&lt;text_tag color='neutral'&gt; neutral &lt;/text_tag&gt; color 的枚举值有：neutral、blue、turquoise、lime、orange、violet、indigo、wathet、green、yellow、red、purple、carmine</item>
    /// </list>
    /// </para>
    /// </param>
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
    /// <param name="TextAlign">
    /// 文本对齐方式。可取值：
    /// <list type="bullet">
    /// <item>left：左对齐</item>
    /// <item>center：居中对齐</item>
    /// <item>right：右对齐</item>
    /// </list>
    /// </param>
    /// <param name="Lines">内容最大显示行数，超出设置行的内容用 ... 省略。</param>
    public record LarkMdElement([property: JsonPropertyName("content")] string Content = "",
        [property: JsonPropertyName("text_size")] string? TextSize = null,
        [property: JsonPropertyName("text_align")] string? TextAlign = null,
        [property: JsonPropertyName("lines")] int? Lines = null) : Element("lark_md"), IAmDivTextElement, IAmNoteElement;
}
