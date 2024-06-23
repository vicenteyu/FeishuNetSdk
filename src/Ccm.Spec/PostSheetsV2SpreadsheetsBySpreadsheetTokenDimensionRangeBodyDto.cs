// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>增加行列 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 增加行列 请求体
/// <para>该接口用于在电子表格中增加空白行或列。</para>
/// <para>接口ID：6907569744333864961</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/sheet-rowcol/add-rows-or-columns</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUjMzUjL1IzM14SNyMTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeBodyDto
{
    /// <summary>
    /// <para>需要增加行列的维度信息</para>
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
        /// <para>更新的维度。可选值：</para>
        /// <para>- `ROWS`：行</para>
        /// <para>- `COLUMNS`：列</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("majorDimension")]
        public string MajorDimension { get; set; } = string.Empty;

        /// <summary>
        /// <para>要增加的行数或列数。取值范围为 (0,5000]</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("length")]
        public int Length { get; set; }
    }
}
