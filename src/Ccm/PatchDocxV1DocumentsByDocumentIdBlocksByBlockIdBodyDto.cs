// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchDocxV1DocumentsByDocumentIdBlocksByBlockIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新块的内容 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 更新块的内容 请求体
/// <para>更新指定的块。</para>
/// <para>接口ID：7068199542315286556</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document-block/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument-block%2fpatch</para>
/// </summary>
public record PatchDocxV1DocumentsByDocumentIdBlocksByBlockIdBodyDto
{
    /// <summary>
    /// <para>更新文本元素请求</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("update_text_elements")]
    public UpdateTextElementsRequest? UpdateTextElements { get; set; }

    /// <summary>
    /// <para>更新文本元素请求</para>
    /// </summary>
    public record UpdateTextElementsRequest
    {
        /// <summary>
        /// <para>更新的文本元素列表，单次更新中 reminder 上限 30 个，mention_doc 上限 50 个，mention_user 上限 100 个</para>
        /// <para>必填：是</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("elements")]
        public Dtos.TextElement[] Elements { get; set; } = Array.Empty<Dtos.TextElement>();
    }

    /// <summary>
    /// <para>更新文本样式请求</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("update_text_style")]
    public UpdateTextStyleRequest? UpdateTextStyle { get; set; }

    /// <summary>
    /// <para>更新文本样式请求</para>
    /// </summary>
    public record UpdateTextStyleRequest
    {
        /// <summary>
        /// <para>文本样式</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("style")]
        public Dtos.TextStyle Style { get; set; } = new();

        /// <summary>
        /// <para>应更新的字段，必须至少指定一个字段。例如，要调整 Block 对齐方式，请设置 fields 为 [1]。</para>
        /// <para>必填：是</para>
        /// <para>示例值：修改的文字样式属性</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：修改 Block 的对齐方式</item>
        /// <item>2：修改 todo block 的完成状态</item>
        /// <item>3：修改 block 的折叠状态</item>
        /// <item>4：修改代码块的语言类型</item>
        /// <item>5：修改代码块的折叠状态</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("fields")]
        public int[] Fields { get; set; } = Array.Empty<int>();
    }

    /// <summary>
    /// <para>更新表格属性请求</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("update_table_property")]
    public UpdateTablePropertyRequest? UpdateTableProperty { get; set; }

    /// <summary>
    /// <para>更新表格属性请求</para>
    /// </summary>
    public record UpdateTablePropertyRequest
    {
        /// <summary>
        /// <para>表格列宽</para>
        /// <para>必填：是</para>
        /// <para>示例值：100</para>
        /// <para>最小值：50</para>
        /// </summary>
        [JsonPropertyName("column_width")]
        public int ColumnWidth { get; set; }

        /// <summary>
        /// <para>需要修改列宽的表格列的索引</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("column_index")]
        public int ColumnIndex { get; set; }
    }

    /// <summary>
    /// <para>表格插入新行请求</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("insert_table_row")]
    public InsertTableRowRequest? InsertTableRow { get; set; }

    /// <summary>
    /// <para>表格插入新行请求</para>
    /// </summary>
    public record InsertTableRowRequest
    {
        /// <summary>
        /// <para>插入的行在表格中的索引。（-1表示在表格末尾插入一行）</para>
        /// <para>必填：是</para>
        /// <para>示例值：-1</para>
        /// <para>最小值：-1</para>
        /// </summary>
        [JsonPropertyName("row_index")]
        public int RowIndex { get; set; }
    }

    /// <summary>
    /// <para>表格插入新列请求</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("insert_table_column")]
    public InsertTableColumnRequest? InsertTableColumn { get; set; }

    /// <summary>
    /// <para>表格插入新列请求</para>
    /// </summary>
    public record InsertTableColumnRequest
    {
        /// <summary>
        /// <para>插入的列在表格中的索引。（-1表示在表格末尾插入一列）</para>
        /// <para>必填：是</para>
        /// <para>示例值：-1</para>
        /// <para>最小值：-1</para>
        /// </summary>
        [JsonPropertyName("column_index")]
        public int ColumnIndex { get; set; }
    }

    /// <summary>
    /// <para>表格批量删除行请求</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("delete_table_rows")]
    public DeleteTableRowsRequest? DeleteTableRows { get; set; }

    /// <summary>
    /// <para>表格批量删除行请求</para>
    /// </summary>
    public record DeleteTableRowsRequest
    {
        /// <summary>
        /// <para>行开始索引（区间左闭右开）</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("row_start_index")]
        public int RowStartIndex { get; set; }

        /// <summary>
        /// <para>行结束索引（区间左闭右开）</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>最小值：1</para>
        /// </summary>
        [JsonPropertyName("row_end_index")]
        public int RowEndIndex { get; set; }
    }

    /// <summary>
    /// <para>表格批量删除列请求</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("delete_table_columns")]
    public DeleteTableColumnsRequest? DeleteTableColumns { get; set; }

    /// <summary>
    /// <para>表格批量删除列请求</para>
    /// </summary>
    public record DeleteTableColumnsRequest
    {
        /// <summary>
        /// <para>列开始索引（区间左闭右开）</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("column_start_index")]
        public int ColumnStartIndex { get; set; }

        /// <summary>
        /// <para>列结束索引（区间左闭右开）</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>最小值：1</para>
        /// </summary>
        [JsonPropertyName("column_end_index")]
        public int ColumnEndIndex { get; set; }
    }

    /// <summary>
    /// <para>表格合并单元格请求</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("merge_table_cells")]
    public MergeTableCellsRequest? MergeTableCells { get; set; }

    /// <summary>
    /// <para>表格合并单元格请求</para>
    /// </summary>
    public record MergeTableCellsRequest
    {
        /// <summary>
        /// <para>行起始索引（区间左闭右开）</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("row_start_index")]
        public int RowStartIndex { get; set; }

        /// <summary>
        /// <para>行结束索引（区间左闭右开）</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>最小值：1</para>
        /// </summary>
        [JsonPropertyName("row_end_index")]
        public int RowEndIndex { get; set; }

        /// <summary>
        /// <para>列起始索引（区间左闭右开）</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("column_start_index")]
        public int ColumnStartIndex { get; set; }

        /// <summary>
        /// <para>列结束索引（区间左闭右开）</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>最小值：1</para>
        /// </summary>
        [JsonPropertyName("column_end_index")]
        public int ColumnEndIndex { get; set; }
    }

    /// <summary>
    /// <para>表格取消单元格合并状态请求</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("unmerge_table_cells")]
    public UnmergeTableCellsRequest? UnmergeTableCells { get; set; }

    /// <summary>
    /// <para>表格取消单元格合并状态请求</para>
    /// </summary>
    public record UnmergeTableCellsRequest
    {
        /// <summary>
        /// <para>table 行索引</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("row_index")]
        public int RowIndex { get; set; }

        /// <summary>
        /// <para>table 列索引</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("column_index")]
        public int ColumnIndex { get; set; }
    }

    /// <summary>
    /// <para>分栏插入新的分栏列请求</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("insert_grid_column")]
    public InsertGridColumnRequest? InsertGridColumn { get; set; }

    /// <summary>
    /// <para>分栏插入新的分栏列请求</para>
    /// </summary>
    public record InsertGridColumnRequest
    {
        /// <summary>
        /// <para>插入列索引，从 1 开始，如 1 表示在第一列后插入，注意不允许传 0（-1表示在最后一列后插入）</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>最小值：-1</para>
        /// </summary>
        [JsonPropertyName("column_index")]
        public int ColumnIndex { get; set; }
    }

    /// <summary>
    /// <para>分栏删除列请求</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("delete_grid_column")]
    public DeleteGridColumnRequest? DeleteGridColumn { get; set; }

    /// <summary>
    /// <para>分栏删除列请求</para>
    /// </summary>
    public record DeleteGridColumnRequest
    {
        /// <summary>
        /// <para>删除列索引，从 0 开始，如 0 表示删除第一列（-1表示删除最后一列）</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// <para>最小值：-1</para>
        /// </summary>
        [JsonPropertyName("column_index")]
        public int ColumnIndex { get; set; }
    }

    /// <summary>
    /// <para>更新分栏列宽比例请求</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("update_grid_column_width_ratio")]
    public UpdateGridColumnWidthRatioRequest? UpdateGridColumnWidthRatio { get; set; }

    /// <summary>
    /// <para>更新分栏列宽比例请求</para>
    /// </summary>
    public record UpdateGridColumnWidthRatioRequest
    {
        /// <summary>
        /// <para>更新列宽比例时，需要传入所有列宽占比</para>
        /// <para>必填：是</para>
        /// <para>示例值：50</para>
        /// <para>最大长度：99</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("width_ratios")]
        public int[] WidthRatios { get; set; } = Array.Empty<int>();
    }

    /// <summary>
    /// <para>替换图片请求</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("replace_image")]
    public ReplaceImageRequest? ReplaceImage { get; set; }

    /// <summary>
    /// <para>替换图片请求</para>
    /// </summary>
    public record ReplaceImageRequest
    {
        /// <summary>
        /// <para>图片 token</para>
        /// <para>必填：是</para>
        /// <para>示例值：boxbckbfvfcqEg22hAzN8Dh9gJd</para>
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>替换附件请求</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("replace_file")]
    public ReplaceFileRequest? ReplaceFile { get; set; }

    /// <summary>
    /// <para>替换附件请求</para>
    /// </summary>
    public record ReplaceFileRequest
    {
        /// <summary>
        /// <para>附件 token</para>
        /// <para>必填：是</para>
        /// <para>示例值：boxbckbfvfcqEg22hAzN8Dh9gJd</para>
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>更新文本元素及样式请求</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("update_text")]
    public UpdateTextRequest? UpdateText { get; set; }

    /// <summary>
    /// <para>更新文本元素及样式请求</para>
    /// </summary>
    public record UpdateTextRequest
    {
        /// <summary>
        /// <para>更新的文本元素列表，单次更新中 reminder 上限 30 个，mention_doc 上限 50 个，mention_user 上限 100 个</para>
        /// <para>必填：是</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("elements")]
        public Dtos.TextElement[] Elements { get; set; } = Array.Empty<Dtos.TextElement>();

        /// <summary>
        /// <para>更新的文本样式</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("style")]
        public Dtos.TextStyle Style { get; set; } = new();

        /// <summary>
        /// <para>文本样式中应更新的字段，必须至少指定一个字段。例如，要调整 Block 对齐方式，请设置 fields 为 [1]。</para>
        /// <para>必填：是</para>
        /// <para>示例值：[1]</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：修改 Block 的对齐方式</item>
        /// <item>2：修改 todo block 的完成状态</item>
        /// <item>3：修改 block 的折叠状态</item>
        /// <item>4：修改代码块的语言类型</item>
        /// <item>5：修改代码块的折叠状态</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("fields")]
        public int[] Fields { get; set; } = Array.Empty<int>();
    }
}
