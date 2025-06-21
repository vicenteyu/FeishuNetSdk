// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PatchDocxV1ChatsByChatIdAnnouncementBlocksBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量更新群公告块的内容 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 批量更新群公告块的内容 请求体
/// <para>接口ID：7450053428095549468</para>
/// <para>文档地址：https://open.feishu.cn/document/group/upgraded-group-announcement/chat-announcement-block/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fchat-announcement-block%2fbatch_update</para>
/// </summary>
public record PatchDocxV1ChatsByChatIdAnnouncementBlocksBatchUpdateBodyDto
{
    /// <summary>
    /// <para>批量更新 Block</para>
    /// <para>必填：否</para>
    /// <para>最大长度：200</para>
    /// </summary>
    [JsonPropertyName("requests")]
    public UpdateBlockRequest[]? Requests { get; set; }

    /// <summary>
    /// <para>批量更新 Block</para>
    /// </summary>
    public record UpdateBlockRequest
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
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("style")]
            public Dtos.TextStyle Style { get; set; } = new();

            /// <summary>
            /// <para>应更新的字段，必须至少指定一个字段。例如，要调整 Block 对齐方式，请设置 fields 为 [1]。</para>
            /// <para>必填：是</para>
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
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// <para>最小值：50</para>
            /// </summary>
            [JsonPropertyName("column_width")]
            public int? ColumnWidth { get; set; }

            /// <summary>
            /// <para>需要修改列宽的表格列的索引（修改表格列宽时必填）</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("column_index")]
            public int? ColumnIndex { get; set; }

            /// <summary>
            /// <para>设置首行为标题行</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("header_row")]
            public bool? HeaderRow { get; set; }

            /// <summary>
            /// <para>设置首列为标题列</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("header_column")]
            public bool? HeaderColumn { get; set; }
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
            /// <para>示例值：boxbcVA91JtFgNhaCgy6s6wK4he</para>
            /// </summary>
            [JsonPropertyName("token")]
            public string Token { get; set; } = string.Empty;

            /// <summary>
            /// <para>图片宽度，单位 px</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("width")]
            public int? Width { get; set; }

            /// <summary>
            /// <para>图片高度，单位 px</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("height")]
            public int? Height { get; set; }

            /// <summary>
            /// <para>对齐方式</para>
            /// <para>必填：否</para>
            /// <para>示例值：2</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：居左排版</item>
            /// <item>2：居中排版</item>
            /// <item>3：居右排版</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("align")]
            public int? Align { get; set; }
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
            /// </summary>
            [JsonPropertyName("token")]
            public string Token { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>Block 唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：doxcnSS4ouQkQEouGSUkTg9NJPe</para>
        /// </summary>
        [JsonPropertyName("block_id")]
        public string? BlockId { get; set; }

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
            /// </summary>
            [JsonPropertyName("fields")]
            public int[] Fields { get; set; } = Array.Empty<int>();
        }

        /// <summary>
        /// <para>更新任务 Block 请求</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("update_task")]
        public UpdateTaskRequest? UpdateTask { get; set; }

        /// <summary>
        /// <para>更新任务 Block 请求</para>
        /// </summary>
        public record UpdateTaskRequest
        {
            /// <summary>
            /// <para>任务 ID。该字段仅在首次更新 Task Block 时生效，更新成功后，后续请求中将忽略该字段。</para>
            /// <para>必填：否</para>
            /// <para>示例值：ba5040f4-8116-4042-ab3c-254e5cfe3ce7</para>
            /// </summary>
            [JsonPropertyName("task_id")]
            public string? TaskId { get; set; }

            /// <summary>
            /// <para>折叠状态，字段为空时不更新折叠状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("folded")]
            public bool? Folded { get; set; }
        }
    }
}
