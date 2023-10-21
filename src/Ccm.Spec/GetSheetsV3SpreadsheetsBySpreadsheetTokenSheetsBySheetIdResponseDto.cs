using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
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
    [JsonProperty("sheet")]
    public SheetSuffix? Sheet { get; set; }

    public record SheetSuffix
    {
        /// <summary>
        /// <para>工作表id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("sheet_id")]
        public string? SheetId { get; set; }

        /// <summary>
        /// <para>工作表标题</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>工作表索引位置，索引从 0 开始计数。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// <para>工作表是否被隐藏</para>
        /// <para>- `true`：表示被隐藏</para>
        /// <para>- `false`：表示未被隐藏</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// <para>单元格属性</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("grid_properties")]
        public GridProperty? GridProperties { get; set; }

        public record GridProperty
        {
            /// <summary>
            /// <para>冻结的行数量</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("frozen_row_count")]
            public int? FrozenRowCount { get; set; }

            /// <summary>
            /// <para>冻结的列数量</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("frozen_column_count")]
            public int? FrozenColumnCount { get; set; }

            /// <summary>
            /// <para>工作表的行数</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("row_count")]
            public int? RowCount { get; set; }

            /// <summary>
            /// <para>工作表的列数量</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("column_count")]
            public int? ColumnCount { get; set; }
        }

        /// <summary>
        /// <para>工作表类型</para>
        /// <para>- `sheet`：工作表</para>
        /// <para>- `bitable`：多维表格，[多维表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/bitable-overview)</para>
        /// <para>- `#UNSUPPORTED_TYPE`：不支持的类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("resource_type")]
        public string? ResourceType { get; set; }

        /// <summary>
        /// <para>合并单元格的相关信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("merges")]
        public MergeRange[]? Merges { get; set; }

        public record MergeRange
        {
            /// <summary>
            /// <para>起始行</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("start_row_index")]
            public int? StartRowIndex { get; set; }

            /// <summary>
            /// <para>结束行</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("end_row_index")]
            public int? EndRowIndex { get; set; }

            /// <summary>
            /// <para>起始列</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("start_column_index")]
            public int? StartColumnIndex { get; set; }

            /// <summary>
            /// <para>结束列</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("end_column_index")]
            public int? EndColumnIndex { get; set; }
        }
    }
}
