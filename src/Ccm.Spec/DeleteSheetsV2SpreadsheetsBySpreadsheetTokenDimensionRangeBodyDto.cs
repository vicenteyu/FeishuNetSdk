// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除行列 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 删除行列 请求体
/// <para>该接口用于删除电子表格中的指定行或列。</para>
/// <para>接口ID：6907569524100382721</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/sheet-rowcol/-delete-rows-or-columns</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fucjMzUjL3IzM14yNyMTN</para>
/// </summary>
public record DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeBodyDto
{
    /// <summary>
    /// <para>需要删除行列的范围信息。将删除 [startIndex,endIndex] 区间内的行或列</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("dimension")]
    public DimensionSuffix Dimension { get; set; } = new();

    /// <summary></summary>
    public record DimensionSuffix
    {
        /// <summary>
        /// <para>工作表的 ID。调用[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query)获取 ID</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("sheetId")]
        public string SheetId { get; set; } = string.Empty;

        /// <summary>
        /// <para>删除的维度。可选值：</para>
        /// <para>- `ROWS`：行</para>
        /// <para>- `COLUMNS`：列</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("majorDimension")]
        public string MajorDimension { get; set; } = string.Empty;

        /// <summary>
        /// <para>要删除的行或列的起始位置，从 1 开始计数。若 `startIndex` 为 3，则从第 3 行或列开始删除。包含第 3 行或列。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("startIndex")]
        public int StartIndex { get; set; }

        /// <summary>
        /// <para>要删除的行或列结束的位置。从 1 开始计数。若 `endIndex` 为 7，则删除至第 7 行或列结束。包含第 7 行或列。</para>
        /// <para>示例：当 `majorDimension` 为 `ROWS`、 `startIndex` 为 3、`endIndex` 为 7 时，则删除第 3、4、5、6、7 行的数据，共删除 5 行。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("endIndex")]
        public int EndIndex { get; set; }
    }
}
