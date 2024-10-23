// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取工作表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取工作表 响应体
/// <para>根据电子表格 token 获取表格中所有工作表及其属性信息，包括工作表 ID、标题、索引位置、是否被隐藏等。</para>
/// <para>## 前提条件</para>
/// <para>调用此接口前，请确保当前调用身份（tenant_access_token 或 user_access_token）已有电子表格的阅读、编辑等文档权限，否则接口将返回 HTTP 403 或 400 状态码。了解更多，参考[如何为应用或用户开通文档权限](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#16c6475a)。</para>
/// <para>接口ID：7120425077330952220</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet%2fquery</para>
/// </summary>
public record GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsQueryResponseDto
{
    /// <summary>
    /// <para>工作表列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sheets")]
    public Sheet[]? Sheets { get; set; }

    /// <summary>
    /// <para>工作表列表</para>
    /// </summary>
    public record Sheet
    {
        /// <summary>
        /// <para>工作表 ID</para>
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
        /// <para>- `true`：被隐藏</para>
        /// <para>- `false`：未被隐藏</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// <para>单元格属性，仅当 `resource_type` 为 `sheet` 即工作表类型为电子表格时返回。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("grid_properties")]
        public SheetGridProperties? GridProperties { get; set; }

        /// <summary>
        /// <para>单元格属性，仅当 `resource_type` 为 `sheet` 即工作表类型为电子表格时返回。</para>
        /// </summary>
        public record SheetGridProperties
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
        /// <para>- `bitable`：多维表格。详情参考[多维表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/bitable-overview)</para>
        /// <para>- `#UNSUPPORTED_TYPE`：不支持的类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：sheet</para>
        /// </summary>
        [JsonPropertyName("resource_type")]
        public string? ResourceType { get; set; }

        /// <summary>
        /// <para>合并单元格的相关信息。没有合并单元格则不返回。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("merges")]
        public MergeRange[]? Merges { get; set; }

        /// <summary>
        /// <para>合并单元格的相关信息。没有合并单元格则不返回。</para>
        /// </summary>
        public record MergeRange
        {
            /// <summary>
            /// <para>起始行，从 0 开始计数</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("start_row_index")]
            public int? StartRowIndex { get; set; }

            /// <summary>
            /// <para>结束行，从 0 开始计数</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("end_row_index")]
            public int? EndRowIndex { get; set; }

            /// <summary>
            /// <para>起始列，从 0 开始计数。</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("start_column_index")]
            public int? StartColumnIndex { get; set; }

            /// <summary>
            /// <para>结束列，从 0 开始计数。</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("end_column_index")]
            public int? EndColumnIndex { get; set; }
        }
    }
}
