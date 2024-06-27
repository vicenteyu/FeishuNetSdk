// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="ChartElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>图表组件</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 图表组件
    /// </summary>
    /// <param name="AspectRatio">
    /// 图表的宽高比。支持以下比例：
    /// <list type="bullet">
    /// <item>1:1</item>
    /// <item>2:1</item>
    /// <item>4:3</item>
    /// <item>16:9</item>
    /// </list>
    /// </param>
    /// <param name="ColorTheme">
    /// 图表的主题样式。当图表内存在多个颜色时，可使用该字段调整颜色样式。若你在 chart_spec 字段中声明了样式类属性，该字段无效。
    /// <list type="bullet">
    /// <item>brand：默认样式，与飞书客户端主题样式一致。</item>
    /// <item>rainbow：同色系彩虹色。</item>
    /// <item>complementary：互补色。</item>
    /// <item>converse：反差色。</item>
    /// <item>primary：主色。</item>
    /// </list>
    /// </param>
    /// <param name="Height">
    /// 图表组件的高度，可取值：
    /// <list type="bullet">
    /// <item>auto：默认值，高度将根据宽高比自动计算。</item>
    /// <item>[1,999]px：自定义固定图表高度，此时宽高比属性 aspect_ratio 失效。</item>
    /// </list>
    /// </param>
    /// <param name="Preview">
    /// 图表是否可在独立窗口查看。可取值：
    /// <list type="bullet">
    /// <item>true：默认值。
    /// <para>PC 端：图表可在独立飞书窗口查看</para>
    /// <para>移动端：图表可在点击后全屏查看</para>
    /// </item>
    /// <item>false：
    /// <para>PC 端：图表不支持在独立飞书窗口查看</para>
    /// <para>移动端：图表不支持在点击后全屏查看</para>
    /// </item>
    /// </list>
    /// </param>
    /// <param name="ChartSpec">基于 VChart 的图表定义。详细用法参考 VChart 官方文档。
    /// </param>
    public partial record ChartElement([property: JsonPropertyName("aspect_ratio")] string? AspectRatio = null,
        [property: JsonPropertyName("color_theme")] string? ColorTheme = null,
        [property: JsonPropertyName("height")] string? Height = null,
        [property: JsonPropertyName("preview")] bool? Preview = null,
        [property: JsonPropertyName("chart_spec")] object? ChartSpec = null) : Element("chart")
    {
        /// <summary>
        /// 图表数据定义
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Values"></param>
        public record Data([property: JsonPropertyName("id")] string? Id = null,
            [property: JsonPropertyName("values")] Dictionary<string, object>[] Values = default!);

        /// <summary>
        /// 标签
        /// </summary>
        /// <param name="Visible"></param>
        /// <param name="Style"></param>
        public record Label([property: JsonPropertyName("visible")] bool? Visible = null,
            [property: JsonPropertyName("style")] Style? Style = null);

        /// <summary>
        /// 范围
        /// </summary>
        /// <param name="Min"></param>
        /// <param name="Max"></param>
        public record Range([property: JsonPropertyName("min")] decimal? Min = null,
            [property: JsonPropertyName("max")] decimal? Max = null);

        /// <summary>
        /// 样式
        /// </summary>
        /// <param name="TextAlign"></param>
        /// <param name="OuterPadding"></param>
        /// <param name="InnerPadding"></param>
        public record Style([property: JsonPropertyName("textAlign")] string? TextAlign = null,
            [property: JsonPropertyName("outerPadding")] int? OuterPadding = null,
            [property: JsonPropertyName("innerPadding")] int? InnerPadding = null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Visible"></param>
        public record DomainLine([property: JsonPropertyName("visible")] bool Visible = false);

        /// <summary>
        /// 标题
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Subtext"></param>
        /// <param name="Visible"></param>
        public record Title([property: JsonPropertyName("text")] string Text = "",
            [property: JsonPropertyName("subtext")] string[]? Subtext = null,
            [property: JsonPropertyName("visible")] bool? Visible = null);

        /// <summary>
        /// 内边距
        /// </summary>
        /// <param name="Left"></param>
        /// <param name="Top"></param>
        /// <param name="Right"></param>
        /// <param name="Bottom"></param>
        public record Padding([property: JsonPropertyName("left")] int? Left = null,
            [property: JsonPropertyName("top")] int? Top = null,
            [property: JsonPropertyName("right")] int? Right = null,
            [property: JsonPropertyName("bottom")] int? Bottom = null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Orient"></param>
        /// <param name="Type"></param>
        /// <param name="Label"></param>
        /// <param name="DomainLine"></param>
        /// <param name="Title"></param>
        /// <param name="Range"></param>
        public record Axes([property: JsonPropertyName("orient")] string Orient = "",
            [property: JsonPropertyName("type")] string? Type = null,
            [property: JsonPropertyName("label")] Label? Label = null,
            [property: JsonPropertyName("domainLine")] DomainLine? DomainLine = null,
            [property: JsonPropertyName("title")] Title? Title = null,
            [property: JsonPropertyName("range")] Range? Range = null);

        /// <summary>
        /// 图例
        /// </summary>
        /// <param name="Visible"></param>
        /// <param name="Position"></param>
        /// <param name="Orient"></param>
        /// <param name="Title"></param>
        public record Legends([property: JsonPropertyName("visible")] bool? Visible = null,
            [property: JsonPropertyName("position")] string? Position = null,
            [property: JsonPropertyName("orient")] string? Orient = null,
            [property: JsonPropertyName("title")] Title? Title = null);

        /// <summary>
        /// 系列
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="DataIndex"></param>
        /// <param name="DataId"></param>
        /// <param name="SeriesField"></param>
        /// <param name="Label"></param>
        public record Series(string Type,
            [property: JsonPropertyName("dataIndex")] int? DataIndex = null,
            [property: JsonPropertyName("dataId")] string? DataId = null,
            [property: JsonPropertyName("seriesField")] string SeriesField = "",
            [property: JsonPropertyName("label")] Label? Label = null) : XFieldSpec(Type);

        /// <summary>
        /// 图表抽象基类
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Title"></param>
        /// <param name="Data"></param>
        public abstract record Spec(string Type,
            [property: JsonPropertyName("title")] Title? Title = null,
            [property: JsonPropertyName("data")] Data[]? Data = null)
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("type")]
            public string Type { get; } = Type;
        }

        /// <summary>
        /// 含Y轴图表
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="YField"></param>
        public abstract record YFieldSpec(string Type,
            [property: JsonPropertyName("yField")] string? YField = null)
            : Spec(Type);

        /// <summary>
        /// 含X、Y轴图表
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="XField"></param>
        public abstract record XFieldSpec(string Type,
            [property: JsonPropertyName("xField")] string[]? XField = null)
            : YFieldSpec(Type);
    }
}
