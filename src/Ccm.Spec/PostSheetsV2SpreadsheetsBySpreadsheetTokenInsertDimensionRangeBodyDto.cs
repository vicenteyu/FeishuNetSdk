// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSheetsV2SpreadsheetsBySpreadsheetTokenInsertDimensionRangeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>插入行列 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 插入行列 请求体
/// <para>该接口用于在电子表格的指定位置插入空白行或列。</para>
/// <para>接口ID：6907569743420194818</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/sheet-rowcol/insert-rows-or-columns</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQjMzUjL0IzM14CNyMTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenInsertDimensionRangeBodyDto
{
    /// <summary>
    /// <para>需要插入行列的维度信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("dimension")]
    public DimensionSuffix Dimension { get; set; } = new();

    /// <summary></summary>
    public record DimensionSuffix
    {
        /// <summary>
        /// <para>电子表格工作表的 ID。调用[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query)获取 ID</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("sheetId")]
        public string SheetId { get; set; } = string.Empty;

        /// <summary>
        /// <para>要更新的维度。可选值：</para>
        /// <para>- `ROWS`：行</para>
        /// <para>- `COLUMNS`：列</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("majorDimension")]
        public string MajorDimension { get; set; } = string.Empty;

        /// <summary>
        /// <para>插入的行或列的起始位置。从 0 开始计数。若 `startIndex` 为 3，则从第 4 行或列开始插入空行或列。包含第 4 行或列。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("startIndex")]
        public int StartIndex { get; set; }

        /// <summary>
        /// <para>插入的行或列结束的位置。从 0 开始计数。若 `endIndex` 为 7，则从第 8 行结束插入行。第 8 行不再插入空行。</para>
        /// <para>示例：当 `majorDimension`为 `ROWS`、 `startIndex` 为 3、`endIndex ` 为 7 时，则在第 4、5、6、7 行插入空白行，共插入 4 行。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("endIndex")]
        public int EndIndex { get; set; }
    }

    /// <summary>
    /// <para>插入的空白行或列是否继承表中的单元格样式。不填或设置为空即不继承任何样式，为默认空白样式。可选值：</para>
    /// <para>- `BEFORE`：继承起始位置的单元格的样式</para>
    /// <para>- `AFTER`：继承结束位置的单元格的样式</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("inheritStyle")]
    public string? InheritStyle { get; set; }
}
