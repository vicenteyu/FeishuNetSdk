// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdReplaceResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>替换单元格 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 替换单元格 响应体
/// <para>在指定范围内，查找并替换符合查找条件的单元格。</para>
/// <para>接口ID：6982374372208607234</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/replace</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet%2freplace</para>
/// </summary>
public record PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdReplaceResponseDto
{
    /// <summary>
    /// <para>符合查找条件并替换的单元格信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("replace_result")]
    public FindReplaceResult? ReplaceResult { get; set; }

    /// <summary>
    /// <para>符合查找条件并替换的单元格信息</para>
    /// </summary>
    public record FindReplaceResult
    {
        /// <summary>
        /// <para>符合查找条件的单元格数组，不包含公式，例如 ["A1", "A2"...]。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("matched_cells")]
        public string[]? MatchedCells { get; set; }

        /// <summary>
        /// <para>符合查找条件的含有公式的单元格数组，例如 ["B3", "H7"...]。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("matched_formula_cells")]
        public string[]? MatchedFormulaCells { get; set; }

        /// <summary>
        /// <para>符合查找条件的总行数</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonPropertyName("rows_count")]
        public int? RowsCount { get; set; }
    }
}
