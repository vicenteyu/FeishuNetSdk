// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockTable.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>表格 Block</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>表格 Block</para>
/// </summary>
public record BlockTable
{
    /// <summary>
    /// <para>单元格数组，数组元素为 Table Cell Block 的 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("cells")]
    public string[]? Cells { get; set; }

    /// <summary>
    /// <para>表格属性</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("property")]
    public TableProperty Property { get; set; } = new();

    /// <summary>
    /// <para>表格属性</para>
    /// </summary>
    public record TableProperty
    {
        /// <summary>
        /// <para>行数</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>最小值：1</para>
        /// </summary>
        [JsonPropertyName("row_size")]
        public int RowSize { get; set; }

        /// <summary>
        /// <para>列数</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>最小值：1</para>
        /// </summary>
        [JsonPropertyName("column_size")]
        public int ColumnSize { get; set; }

        /// <summary>
        /// <para>列宽，单位px</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// <para>默认值：100</para>
        /// </summary>
        [JsonPropertyName("column_width")]
        public int[]? ColumnWidth { get; set; }

        /// <summary>
        /// <para>单元格合并信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("merge_info")]
        public TableMergeInfo[]? MergeInfos { get; set; }

        /// <summary>
        /// <para>单元格合并信息</para>
        /// </summary>
        public record TableMergeInfo
        {
            /// <summary>
            /// <para>从当前行索引起被合并的连续行数</para>
            /// <para>必填：否</para>
            /// <para>示例值：2</para>
            /// <para>最小值：1</para>
            /// </summary>
            [JsonPropertyName("row_span")]
            public int? RowSpan { get; set; }

            /// <summary>
            /// <para>从当前列索引起被合并的连续列数</para>
            /// <para>必填：否</para>
            /// <para>示例值：2</para>
            /// <para>最小值：1</para>
            /// </summary>
            [JsonPropertyName("col_span")]
            public int? ColSpan { get; set; }
        }

        /// <summary>
        /// <para>设置首行为标题行</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// <para>默认值：false</para>
        /// </summary>
        [JsonPropertyName("header_row")]
        public bool? HeaderRow { get; set; }

        /// <summary>
        /// <para>设置首列为标题列</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// <para>默认值：false</para>
        /// </summary>
        [JsonPropertyName("header_column")]
        public bool? HeaderColumn { get; set; }
    }
}
