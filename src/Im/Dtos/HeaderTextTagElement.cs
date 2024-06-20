namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 标题文本标签元素
    /// </summary>
    /// <param name="Text">标题标签的内容。基于文本组件的 plain_text 模式定义内容。</param>
    /// <param name="Color">标题标签的颜色，默认为蓝色（blue）。可选值与示例效果参见下文的 标签样式表。
    /// <list type="bullet">
    /// <item>blue</item>
    /// <item>wathet</item>
    /// <item>turquoise</item>
    /// <item>green</item>
    /// <item>yellow</item>
    /// <item>orange</item>
    /// <item>red</item>
    /// <item>carmine</item>
    /// <item>violet</item>
    /// <item>purple</item>
    /// <item>indigo</item>
    /// <item>grey</item>
    /// <item>default</item>
    /// </list>
    /// </param>
    public record HeaderTextTagElement([property: JsonPropertyName("text")] PlainTextElement? Text = null,
        [property: JsonPropertyName("color")] string? Color = null) : Element("text_tag");



}
