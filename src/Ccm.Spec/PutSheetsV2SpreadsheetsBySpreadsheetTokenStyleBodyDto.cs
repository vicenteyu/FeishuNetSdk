// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PutSheetsV2SpreadsheetsBySpreadsheetTokenStyleBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>设置单元格样式  请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 设置单元格样式  请求体
/// <para>设置单元格中数据的样式。支持设置字体、背景、边框等样式。</para>
/// <para>接口ID：6907569523176783873</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/set-cell-style</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukjMzUjL5IzM14SOyMTN</para>
/// </summary>
public record PutSheetsV2SpreadsheetsBySpreadsheetTokenStyleBodyDto
{
    /// <summary>
    /// <para>设置单元格样式。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("appendStyle")]
    public AppendStyleSuffix AppendStyle { get; set; } = new();

    /// <summary></summary>
    public record AppendStyleSuffix
    {
        /// <summary>
        /// <para>⁣设置样式的范围。格式为 `&lt;sheetId&gt;!&lt;开始位置&gt;:&lt;结束位置&gt;`。其中：</para>
        /// <para>- `sheetId` 为工作表 ID，通过[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query) 获取。</para>
        /// <para>- `&lt;开始位置&gt;:&lt;结束位置&gt;` 为工作表中单元格的范围，数字表示行索引，字母表示列索引。如 `A2:B2` 表示该工作表第 2 行的 A 列到 B 列。`range`支持四种写法，详情参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("range")]
        public string Range { get; set; } = string.Empty;

        /// <summary>
        /// <para>需要更新的样式</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("style")]
        public StyleSuffix Style { get; set; } = new();

        /// <summary></summary>
        public record StyleSuffix
        {
            /// <summary>
            /// <para>字体相关样式</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("font")]
            public FontSuffix? Font { get; set; }

            /// <summary></summary>
            public record FontSuffix
            {
                /// <summary>
                /// <para>是否加粗。默认值 false。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("bold")]
                public bool? Bold { get; set; }

                /// <summary>
                /// <para>是否斜体。默认值 false。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("italic")]
                public bool? Italic { get; set; }

                /// <summary>
                /// <para>字体大小，如 10pt/1.5。其中 10pt 表示字号，取值范围为 [9,36]pt。1.5 为行距，固定为 1.5px。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("fontSize")]
                public string? FontSize { get; set; }

                /// <summary>
                /// <para>是否清除字体格式，默认为 false。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("clean")]
                public bool? Clean { get; set; }
            }

            /// <summary>
            /// <para>文本的其它样式，可选值：</para>
            /// <para>- 0：默认样式，不加下划线和删除线</para>
            /// <para>- 1：下划线</para>
            /// <para>- 2：删除线</para>
            /// <para>- 3： 下划线和删除线</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("textDecoration")]
            public int? TextDecoration { get; set; }

            /// <summary>
            /// <para>数字格式，详见[电子表格支持的数字格式类型](https://open.feishu.cn/document/ukTMukTMukTM/uMjM2UjLzIjN14yMyYTN)。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("formatter")]
            public string? Formatter { get; set; }

            /// <summary>
            /// <para>水平对齐方式。可选值：</para>
            /// <para>- 0：左对齐</para>
            /// <para>- 1：中对齐</para>
            /// <para>- 2：右对齐</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("hAlign")]
            public int? HAlign { get; set; }

            /// <summary>
            /// <para>垂直对齐方式。可选值：</para>
            /// <para>- 0：上对齐</para>
            /// <para>- 1：中对齐</para>
            /// <para>- 2：下对齐</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("vAlign")]
            public int? VAlign { get; set; }

            /// <summary>
            /// <para>字体颜色，用十六进制颜色代码表示。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("foreColor")]
            public string? ForeColor { get; set; }

            /// <summary>
            /// <para>背景颜色，用十六进制颜色代码表示。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("backColor")]
            public string? BackColor { get; set; }

            /// <summary>
            /// <para>边框类型，可选值：</para>
            /// <para>- FULL_BORDER：全边框，即四周都有边框</para>
            /// <para>- OUTER_BORDER：外边框，只有外侧有边框</para>
            /// <para>- INNER_BORDER：内边框，只有内部有边框</para>
            /// <para>- NO_BORDER：无边框，即没有任何边框</para>
            /// <para>- LEFT_BORDER：左边框，只有左侧有边框</para>
            /// <para>- RIGHT_BORDER：右边框，只有右侧有边框</para>
            /// <para>- TOP_BORDER：上边框，只有顶部有边框</para>
            /// <para>- BOTTOM_BORDER：下边框，只有底部有边框</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("borderType")]
            public string? BorderType { get; set; }

            /// <summary>
            /// <para>边框颜色，用十六进制颜色代码表示。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("borderColor")]
            public string? BorderColor { get; set; }

            /// <summary>
            /// <para>是否清除所有格式。默认值为 false。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("clean")]
            public bool? Clean { get; set; }
        }
    }
}
