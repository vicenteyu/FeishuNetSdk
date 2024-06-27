// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="ColumnSetElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>分栏组件</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 分栏组件
    /// </summary>
    /// <param name="HorizontalSpacing">
    /// 各列之间的水平分栏间距。取值：
    /// <list type="bullet">
    /// <item>default：默认间距，8px</item>
    /// <item>small：窄间距，4px</item>
    /// <item>large：大间距，12px</item>
    /// <item>[0,28px]：自定义间距</item>
    /// </list>
    /// </param>
    /// <param name="HorizontalAlign">
    /// 列容器水平对齐的方式。可取值：
    /// <para>首行列的上外边距强制为 0，末行列的下外边距强制为 0。</para>
    /// <list type="bullet">
    /// <item>left：左对齐</item>
    /// <item>center：居中对齐</item>
    /// <item>right：右对齐</item>
    /// </list>
    /// </param>
    /// <param name="Margin">
    /// 列的外边距。值的取值范围为 [0,28]px。可选值：
    /// <list type="bullet">
    /// <item>单值，如 "10px"，表示列的四个外边距都为 10 px。</item>
    /// <item>多值，如 "4px 12px 4px 12px"，表示列的上、右、下、左的外边距分别为 4px，12px，4px，12px。四个值必填，使用空格间隔。</item>
    /// </list>
    /// </param>
    /// <param name="FlexMode">
    /// 移动端和 PC 端的窄屏幕下，各列的自适应方式。取值：
    /// <list type="bullet">
    /// <item>none：不做布局上的自适应，在窄屏幕下按比例压缩列宽度</item>
    /// <item>stretch：列布局变为行布局，且每列（行）宽度强制拉伸为 100%，所有列自适应为上下堆叠排布</item>
    /// <item>flow：列流式排布（自动换行），当一行展示不下一列时，自动换至下一行展示</item>
    /// <item>bisect：两列等分布局</item>
    /// <item>trisect：三列等分布局</item>
    /// </list>
    /// </param>
    /// <param name="BackgroundStyle">
    /// 分栏的背景色样式。可取值：
    /// <list type="bullet">
    /// <item>default：默认的白底样式，客户端深色主题下为黑底样式</item>
    /// <item>卡片支持的颜色枚举值和 RGBA 语法自定义颜色。参考颜色枚举值。</item>
    /// </list>
    /// </param>
    /// <param name="Columns">分栏中列的配置。</param>
    /// <param name="Action">设置点击分栏时的交互配置。当前仅支持跳转交互。如果布局容器内有交互组件，则优先响应交互组件定义的交互。</param>
    public record ColumnSetElement([property: JsonPropertyName("horizontal_spacing")] string? HorizontalSpacing = null,
        [property: JsonPropertyName("horizontal_align")] string? HorizontalAlign = null,
        [property: JsonPropertyName("margin")] string? Margin = null,
        [property: JsonPropertyName("flex_mode")] string? FlexMode = null,
        [property: JsonPropertyName("background_style")] string? BackgroundStyle = null,
        [property: JsonPropertyName("columns")] ColumnElement[] Columns = default!,
        [property: JsonPropertyName("action")] ColumnAction? Action = null) : Element("column_set");
}
