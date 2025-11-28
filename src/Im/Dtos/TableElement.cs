// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="TableElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>表格组件</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 表格组件
    /// </summary>
    /// <param name="Columns">列对象数组。详见下方 column 字段说明。</param>
    /// <param name="Rows">行对象数组。与列定义对应的数据。用 "name":VALUE 的形式，定义每一行的数据内容。name即你自定义的列标记。</param>
    /// <param name="PageSize">每页最大展示的数据行数。支持 [1,10] 整数。</param>
    /// <param name="RowHeight">
    /// 表格的行高。单元格高度如无法展示一整行内容，则上下裁剪内容。可取值：
    /// <list type="bullet">
    /// <item>low：低</item>
    /// <item>middle：中</item>
    /// <item>high：高</item>
    /// <item>[32,124]px：自定义行高，单位为像素，如 40px。取值范围是 [32,124]</item>
    /// </list>
    /// </param>
    /// <param name="HeaderStyle">表头样式风格。详见下方 header_style 字段说明。</param>
    public record TableElement(TableElement.Column[]? Columns = default,
        Dictionary<string, object>[]? Rows = default,
        [property: JsonPropertyName("page_size")] int? PageSize = null,
        [property: JsonPropertyName("row_height")] string? RowHeight = null,
        [property: JsonPropertyName("header_style")] TableElement.Style? HeaderStyle = null) : Element("table")
    {
        /// <summary>
        /// 列对象数组
        /// </summary>
        [property: JsonPropertyName("columns")]
        public Column[] Columns { get; set; } = Columns ?? [];

        /// <summary>
        /// 行对象数组
        /// </summary>
        [property: JsonPropertyName("rows")]
        public Dictionary<string, object>[] Rows { get; set; } = Rows ?? [];

        /// <summary>
        /// 用于设置表头的样式、风格等
        /// </summary>
        /// <param name="TextAlign">
        /// 表头文本对齐方式。可取值：
        /// <list type="bullet">
        /// <item>left：左对齐</item>
        /// <item>center：居中对齐</item>
        /// <item>right：右对齐</item>
        /// </list>
        /// </param>
        /// <param name="TextSize">
        /// 表头文本大小。可取值：
        /// <list type="bullet">
        /// <item>normal：正文（14px）</item>
        /// <item>heading：标题（16px）</item>
        /// </list>
        /// </param>
        /// <param name="BackgroundStyle">
        /// 表头背景色。可取值：
        /// <list type="bullet">
        /// <item>grey：灰色</item>
        /// <item>none：无背景色</item>
        /// </list>
        /// </param>
        /// <param name="TextColor">
        /// 文本颜色。可取值：
        /// <list type="bullet">
        /// <item>default：客户端浅色主题模式下为黑色；客户端深色主题模式下为白色</item>
        /// <item>grey：灰色</item>
        /// </list>
        /// </param>
        /// <param name="Bold">
        /// 表头文本是否加粗。可取值：
        /// <list type="bullet">
        /// <item>true：加粗</item>
        /// <item>false：不加粗</item>
        /// </list>
        /// </param>
        /// <param name="Lines">表头文本的行数。支持大于等于 1 的整数。</param>
        public record Style([property: JsonPropertyName("text_align")] string? TextAlign = null,
            [property: JsonPropertyName("text_size")] string? TextSize = null,
            [property: JsonPropertyName("background_style")] string? BackgroundStyle = null,
            [property: JsonPropertyName("text_color")] string? TextColor = null,
            [property: JsonPropertyName("bold")] bool? Bold = null,
            [property: JsonPropertyName("lines")] int? Lines = null);

        /// <summary>
        /// 用于定义表格的列。最多支持添加 10 列，超出 10 列的内容不展示。
        /// </summary>
        /// <param name="Name">自定义列的标记。用于唯一指定行数据对象数组中，需要将数据填充至这一行的具体哪个单元格中。</param>
        /// <param name="DataType">列数据类型。可选值：
        /// <list type="bullet">
        /// <item>text：不带格式的普通文本。为 data_type 默认值。</item>
        /// <item>lark_md：支持部分 markdown 格式的文本。飞书 v7.10 及之后版本支持。详情参考普通文本-lark_md 支持的 Markdown 语法</item>
        /// <item>options：选项标签</item>
        /// <item>number：数字。默认在单元格中右对齐展示。若选择该数据类型，你可继续在 column 中添加 format 字段，设置数字的格式属性</item>
        /// <item>persons：人员列表。为用户名称+头像样式</item>
        /// <item>date：日期时间。需输入 Unix 标准毫秒级时间戳，飞书客户端将按用户本地时区展示日期时间。飞书 v7.6 及之后版本支持</item>
        /// <item>markdown：支持完整 Markdown 语法的文本内容。详情参考富文本（Markdown）组件。飞书 v7.14 及之后版本支持</item>
        /// </list>
        /// </param>
        /// <param name="DisplayName">在表头展示的列名称。不填或为空则不展示列名称。</param>
        /// <param name="Width">
        /// 列宽度。可取值：
        /// <list type="bullet">
        /// <item>auto：自适应内容宽度</item>
        /// <item>自定义宽度：自定义表格的列宽度，如 120px。取值范围是 [80px,600px] 的整数</item>
        /// <item>自定义宽度百分比：自定义列宽度占当前表格画布宽度的百分比（表格画布宽度 = 卡片宽度-卡片左右内边距），如 25%。取值范围是 [1%,100%]</item>
        /// </list>
        /// </param>
        /// <param name="HorizontalAlign">
        /// 列内数据对齐方式。可选值：
        /// <list type="bullet">
        /// <item>left：左对齐</item>
        /// <item>center：居中对齐</item>
        /// <item>right：右对齐</item>
        /// </list>
        /// </param>
        /// <param name="Format">该字段仅当 data_type 为 number 时生效，你可以在该字段内选择设置小数点位数、货币单位以及千分位样式。</param>
        public record Column([property: JsonPropertyName("name")] string Name = "",
            [property: JsonPropertyName("data_type")] string DataType = "",
            [property: JsonPropertyName("display_name")] string? DisplayName = null,
            [property: JsonPropertyName("width")] string? Width = null,
            [property: JsonPropertyName("horizontal_align")] string? HorizontalAlign = null,
            [property: JsonPropertyName("format")] Column.FormatSuffix? Format = null)
        {
            /// <summary>
            /// 仅当 data_type 为 number 时生效，你可以在该字段内选择设置小数点位数、货币单位以及千分位样式。
            /// </summary>
            /// <param name="Precision">数字的小数点位数。默认不限制小数点位数，原样透传展示开发者输入的数字。可填 0~10 的整数。小数点位数为 0 表示取整数。</param>
            /// <param name="Symbol">数字前的货币单位。不填或为空不展示。可填 1 个字符的货币单位文本，如 “¥”。</param>
            /// <param name="Separator">是否生效按千分位逗号分割的数字样式。</param>
            public record FormatSuffix([property: JsonPropertyName("precision")] int? Precision = null,
                [property: JsonPropertyName("symbol")] string? Symbol = null,
                [property: JsonPropertyName("separator")] bool? Separator = null);
        }
    }
}
