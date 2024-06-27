// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="ColumnElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>分栏-列</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 分栏-列
    /// </summary>
    /// <param name="BackgroundStyle">
    /// 列的背景色样式。可取值：
    /// <list type="bullet">
    /// <item>default：默认的白底样式，客户端深色主题下为黑底样式</item>
    /// <item>卡片支持的颜色枚举值和 RGBA 语法自定义颜色。参考颜色枚举值</item>
    /// </list>
    /// </param>
    /// <param name="Width">
    /// 列宽度。仅 flex_mode 为 none 时，生效此属性。取值：
    /// <list type="bullet">
    /// <item>auto：列宽度与列内元素宽度一致</item>
    /// <item>weighted：列宽度按 weight 参数定义的权重分布</item>
    /// <item>具体数值，如 100px。取值范围为 [16,600]px。V7.4 及以上版本支持该枚举</item>
    /// </list>
    /// </param>
    /// <param name="Weight">
    /// 当 width 字段取值为 weighted 时生效，表示当前列的宽度占比。取值范围为 1 ~ 5 之间的整数。
    /// </param>
    /// <param name="VerticalAlign">
    /// 列垂直居中的方式。可取值：
    /// <list type="bullet">
    /// <item>top：上对齐</item>
    /// <item>center：居中对齐</item>
    /// <item>bottom：下对齐</item>
    /// </list>
    /// </param>
    /// <param name="VerticalSpacing">
    /// 列内组件的纵向间距。取值：
    /// <list type="bullet">
    /// <item>default：默认间距，8px</item>
    /// <item>medium：中等间距</item>
    /// <item>large：大间距</item>
    /// <item>具体数值，如 8px。取值范围为 [0,28]px</item>
    /// </list>
    /// </param>
    /// <param name="Padding">
    /// 列的内边距。值的取值范围为 [0,28]px。可选值：
    /// <list type="bullet">
    /// <item>单值，如 "10px"，表示列的四个外边距都为 10 px。</item>
    /// <item>多值，如 "4px 12px 4px 12px"，表示列的上、右、下、左的外边距分别为 4px，12px，4px，12px。四个值必填，使用空格间隔。</item>
    /// </list>
    /// </param>
    /// <param name="Elements">列容器中内嵌的组件。可内嵌组件参考上文嵌套关系。</param>
    /// <param name="Action">设置点击列时的交互配置。当前仅支持跳转交互。如果布局容器内有交互组件，则优先响应交互组件定义的交互。</param>
    public record ColumnElement([property: JsonPropertyName("background_style")] string? BackgroundStyle = null,
        [property: JsonPropertyName("width")] string? Width = null,
        [property: JsonPropertyName("weight")] int? Weight = null,
        [property: JsonPropertyName("vertical_align")] string? VerticalAlign = null,
        [property: JsonPropertyName("vertical_spacing")] string? VerticalSpacing = null,
        [property: JsonPropertyName("padding")] string? Padding = null,
        [property: JsonPropertyName("elements")] object[] Elements = default!,
        [property: JsonPropertyName("action")] ColumnAction? Action = null) : Element("column");
}
