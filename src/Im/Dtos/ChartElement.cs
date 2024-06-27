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
    public record ChartElement([property: JsonPropertyName("aspect_ratio")] string? AspectRatio = null,
        [property: JsonPropertyName("color_theme")] string? ColorTheme = null,
        [property: JsonPropertyName("height")] string? Height = null,
        [property: JsonPropertyName("preview")] bool? Preview = null,
        [property: JsonPropertyName("chart_spec")] object? ChartSpec = null) : Element("chart")
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Values"></param>
        public record Data([property: JsonPropertyName("id")] string? Id = null,
            [property: JsonPropertyName("values")] Dictionary<string, object>[] Values = default!);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Visible"></param>
        /// <param name="Style"></param>
        public record Label([property: JsonPropertyName("visible")] bool? Visible = null,
            [property: JsonPropertyName("style")] Style? Style = null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Min"></param>
        /// <param name="Max"></param>
        public record Range([property: JsonPropertyName("min")] decimal? Min = null,
            [property: JsonPropertyName("max")] decimal? Max = null);

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Subtext"></param>
        /// <param name="Visible"></param>
        public record Title([property: JsonPropertyName("text")] string Text = "",
            [property: JsonPropertyName("subtext")] string[]? Subtext = null,
            [property: JsonPropertyName("visible")] bool? Visible = null);

        /// <summary>
        /// 
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
        /// 
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
        /// 
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
        /// 
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
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="YField"></param>
        public abstract record YFieldSpec(string Type,
            [property: JsonPropertyName("yField")] string? YField = null)
            : Spec(Type);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="XField"></param>
        public abstract record XFieldSpec(string Type,
            [property: JsonPropertyName("xField")] string[]? XField = null)
            : YFieldSpec(Type);

        /// <summary>
        /// 折线图
        /// </summary>
        public record LineSpec() : XFieldSpec("line");

        /// <summary>
        /// 面积图
        /// </summary>
        public record AreaSpec() : XFieldSpec("area");

        /// <summary>
        /// 柱状图
        /// </summary>
        /// <param name="SeriesField"></param>
        /// <param name="Legends"></param>
        public record BarYSpec([property: JsonPropertyName("seriesField")] string SeriesField = "",
            [property: JsonPropertyName("legends")] Legends? Legends = null) : XFieldSpec("bar");

        /// <summary>
        /// 条形图
        /// </summary>
        /// <param name="Direction"></param>
        public record BarXSpec([property: JsonPropertyName("direction")] string Direction = "") : XFieldSpec("bar");

        /// <summary>
        /// 环图
        /// </summary>
        /// <param name="OuterRadius"></param>
        /// <param name="InnerRadius"></param>
        /// <param name="CategoryField"></param>
        /// <param name="ValueField"></param>
        /// <param name="Legends"></param>
        /// <param name="Label"></param>
        public record PieESpec([property: JsonPropertyName("outerRadius")] decimal OuterRadius = default,
            [property: JsonPropertyName("innerRadius")] decimal InnerRadius = default,
            [property: JsonPropertyName("categoryField")] string CategoryField = "",
            [property: JsonPropertyName("valueField")] string ValueField = "",
            [property: JsonPropertyName("legends")] Legends? Legends = null,
            [property: JsonPropertyName("label")] Label? Label = null) : Spec("pie");

        /// <summary>
        /// 饼图
        /// </summary>
        /// <param name="OuterRadius"></param>
        /// <param name="CategoryField"></param>
        /// <param name="ValueField"></param>
        /// <param name="Legends"></param>
        /// <param name="Label"></param>
        /// <param name="Padding"></param>
        public record PieFSpec([property: JsonPropertyName("outerRadius")] decimal OuterRadius = default,
            [property: JsonPropertyName("categoryField")] string CategoryField = "",
            [property: JsonPropertyName("valueField")] string ValueField = "",
            [property: JsonPropertyName("legends")] Legends? Legends = null,
            [property: JsonPropertyName("label")] Label? Label = null,
            [property: JsonPropertyName("padding")] Padding? Padding = null) : Spec("pie");

        /// <summary>
        /// 组合图
        /// </summary>
        /// <param name="Series"></param>
        /// <param name="Axes"></param>
        /// <param name="Legends"></param>
        public record CommonSpec([property: JsonPropertyName("series")] Series[]? Series = null,
            [property: JsonPropertyName("axes")] Axes[]? Axes = null,
            [property: JsonPropertyName("legends")] Legends? Legends = null) : Spec("common");

        /// <summary>
        /// 漏斗图
        /// </summary>
        /// <param name="CategoryField"></param>
        /// <param name="ValueField"></param>
        /// <param name="IsTransform"></param>
        /// <param name="TransformLabel"></param>
        /// <param name="OuterLabel"></param>
        /// <param name="Label"></param>
        public record FunnelSpec([property: JsonPropertyName("categoryField")] string CategoryField = "",
            [property: JsonPropertyName("valueField")] string ValueField = "",
            [property: JsonPropertyName("isTransform")] bool IsTransform = true,
            [property: JsonPropertyName("transformLabel")] FunnelSpec.TransformLabelSuffix TransformLabel = default!,
            [property: JsonPropertyName("outerLabel")] FunnelSpec.OuterLabelSuffix OuterLabel = default!,
            [property: JsonPropertyName("label")] Label? Label = null) : Spec("funnel")
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="Visible"></param>
            public record TransformLabelSuffix([property: JsonPropertyName("visible")] bool Visible = true);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Visible"></param>
            public record OuterLabelSuffix([property: JsonPropertyName("visible")] bool Visible = true);
        }

        /// <summary>
        /// 散点图
        /// </summary>
        /// <param name="Axes"></param>
        public record ScatterSpec([property: JsonPropertyName("axes")] Axes[]? Axes = null) : XFieldSpec("scatter");

        /// <summary>
        /// 雷达图
        /// </summary>
        /// <param name="CategoryField"></param>
        /// <param name="ValueField"></param>
        /// <param name="Area"></param>
        /// <param name="OuterRadius"></param>
        /// <param name="Axes"></param>
        public record RadarSpec([property: JsonPropertyName("categoryField")] string CategoryField = "",
            [property: JsonPropertyName("valueField")] string ValueField = "",
            [property: JsonPropertyName("area")] RadarSpec.AreaSuffix? Area = null,
            [property: JsonPropertyName("outerRadius")] decimal OuterRadius = default,
            [property: JsonPropertyName("axes")] Axes[]? Axes = null) : Spec("radar")
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="Visible"></param>
            public record AreaSuffix([property: JsonPropertyName("visible")] bool Visible = true);
        }

        /// <summary>
        /// 条形进度图
        /// </summary>
        /// <param name="Direction"></param>
        /// <param name="SeriesField"></param>
        /// <param name="Axes"></param>
        public record LinearProgressSpec([property: JsonPropertyName("direction")] string Direction = "",
            [property: JsonPropertyName("seriesField")] string SeriesField = "",
            [property: JsonPropertyName("axes")] Axes[]? Axes = null) : XFieldSpec("linearProgress");

        /// <summary>
        /// 环形进度图
        /// </summary>
        /// <param name="CategoryField"></param>
        /// <param name="ValueField"></param>
        /// <param name="SeriesField"></param>
        /// <param name="Radius"></param>
        /// <param name="InnerRadius"></param>
        /// <param name="CornerRadius"></param>
        /// <param name="Progress"></param>
        /// <param name="Indicator"></param>
        /// <param name="Legends"></param>
        public record CircularProgressSpec([property: JsonPropertyName("categoryField")] string CategoryField = "",
            [property: JsonPropertyName("valueField")] string ValueField = "",
            [property: JsonPropertyName("seriesField")] string SeriesField = "",
            [property: JsonPropertyName("radius")] decimal Radius = default,
            [property: JsonPropertyName("innerRadius")] decimal InnerRadius = default,
            [property: JsonPropertyName("cornerRadius")] decimal CornerRadius = default,
            [property: JsonPropertyName("progress")] CircularProgressSpec.ProgressSuffix Progress = default!,
            [property: JsonPropertyName("indicator")] CircularProgressSpec.IndicatorSuffix Indicator = default!,
            [property: JsonPropertyName("legends")] Legends? Legends = null) : Spec("circularProgress")
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="Style"></param>
            public record ProgressSuffix([property: JsonPropertyName("style")] Style Style = default!);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Title"></param>
            /// <param name="Content"></param>
            /// <param name="Trigger"></param>
            /// <param name="Visible"></param>
            public record IndicatorSuffix([property: JsonPropertyName("title")] IndicatorSuffix.TitleSuffix Title = default!,
                [property: JsonPropertyName("content")] IndicatorSuffix.ContentSuffix[] Content = default!,
                [property: JsonPropertyName("trigger")] string Trigger = "",
                [property: JsonPropertyName("visible")] bool Visible = true)
            {
                /// <summary>
                /// 
                /// </summary>
                /// <param name="Field"></param>
                /// <param name="Visible"></param>
                /// <param name="AutoLimit"></param>
                public record TitleSuffix([property: JsonPropertyName("field")] string Field = "",
                    [property: JsonPropertyName("visible")] bool Visible = true,
                    [property: JsonPropertyName("autoLimit")] bool AutoLimit = true);

                /// <summary>
                /// 
                /// </summary>
                /// <param name="Field"></param>
                /// <param name="Visible"></param>
                public record ContentSuffix([property: JsonPropertyName("field")] string Field = "",
                    [property: JsonPropertyName("visible")] bool Visible = true);
            }
        }

        /// <summary>
        /// 词云
        /// </summary>
        /// <param name="NameField"></param>
        /// <param name="ValueField"></param>
        /// <param name="SeriesField"></param>
        public record WordCloudSpec([property: JsonPropertyName("nameField")] string NameField = "",
            [property: JsonPropertyName("valueField")] string ValueField = "",
            [property: JsonPropertyName("seriesField")] string SeriesField = "") : Spec("wordCloud");
    }
}
