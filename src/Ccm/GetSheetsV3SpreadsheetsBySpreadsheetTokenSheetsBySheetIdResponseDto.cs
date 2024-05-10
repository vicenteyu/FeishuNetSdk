namespace FeishuNetSdk.Ccm;
/// <summary>
/// 查询工作表 响应体
/// <para>该接口用于通过工作表ID查询工作表属性信息。</para>
/// <para>接口ID：7120425077330935836</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet%2fget</para>
/// </summary>
public record GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdResponseDto
{
    /// <summary>
    /// <para>工作表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sheet")]
    public GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdResponseDtoSheet? Sheet { get; set; }

    /// <summary>
    /// <para>工作表</para>
    /// </summary>
    public record GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdResponseDtoSheet
    {
        /// <summary>
        /// <para>工作表id</para>
        /// <para>必填：否</para>
        /// <para>示例值：sxj5ws</para>
        /// </summary>
        [JsonPropertyName("sheet_id")]
        public string? SheetId { get; set; }

        /// <summary>
        /// <para>工作表标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：title</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>工作表索引位置，索引从 0 开始计数。</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// <para>工作表是否被隐藏</para>
        /// <para>- `true`：表示被隐藏</para>
        /// <para>- `false`：表示未被隐藏</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// <para>单元格属性，仅当 `resource_type=sheet` 时返回</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("grid_properties")]
        public GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdResponseDtoSheetGridProperties? GridProperties { get; set; }

        /// <summary>
        /// <para>单元格属性，仅当 `resource_type=sheet` 时返回</para>
        /// </summary>
        public record GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdResponseDtoSheetGridProperties
        {
            /// <summary>
            /// <para>冻结的行数量</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("frozen_row_count")]
            public int? FrozenRowCount { get; set; }

            /// <summary>
            /// <para>冻结的列数量</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("frozen_column_count")]
            public int? FrozenColumnCount { get; set; }

            /// <summary>
            /// <para>工作表的行数</para>
            /// <para>必填：否</para>
            /// <para>示例值：200</para>
            /// </summary>
            [JsonPropertyName("row_count")]
            public int? RowCount { get; set; }

            /// <summary>
            /// <para>工作表的列数量</para>
            /// <para>必填：否</para>
            /// <para>示例值：20</para>
            /// </summary>
            [JsonPropertyName("column_count")]
            public int? ColumnCount { get; set; }
        }

        /// <summary>
        /// <para>工作表类型</para>
        /// <para>- `sheet`：工作表</para>
        /// <para>- `bitable`：多维表格，[多维表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/bitable-overview)</para>
        /// <para>- `#UNSUPPORTED_TYPE`：不支持的类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：sheet</para>
        /// </summary>
        [JsonPropertyName("resource_type")]
        public string? ResourceType { get; set; }

        /// <summary>
        /// <para>合并单元格的相关信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("merges")]
        public MergeRange[]? Merges { get; set; }

        /// <summary>
        /// <para>合并单元格的相关信息</para>
        /// </summary>
        public record MergeRange
        {
            /// <summary>
            /// <para>起始行</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("start_row_index")]
            public int? StartRowIndex { get; set; }

            /// <summary>
            /// <para>结束行</para>
            /// <para>必填：否</para>
            /// <para>示例值：-</para>
            /// </summary>
            [JsonPropertyName("end_row_index")]
            public int? EndRowIndex { get; set; }

            /// <summary>
            /// <para>起始列</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("start_column_index")]
            public int? StartColumnIndex { get; set; }

            /// <summary>
            /// <para>结束列</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("end_column_index")]
            public int? EndColumnIndex { get; set; }
        }
    }
}
