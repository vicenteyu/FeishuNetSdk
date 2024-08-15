// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFindResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查找单元格 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 查找单元格 响应体
/// <para>在指定范围内查找符合查找条件的单元格。</para>
/// <para>## 注意事项</para>
/// <para>请求参数 `range` 所指定的范围不可大于实际数据区域，否则将报错。例如，当工作表只有 200 行、而 `range` 参数的范围为 1 到 201 行时，接口将返回 1310202 错误码。</para>
/// <para>接口ID：6982374372208590850</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/find</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet%2ffind</para>
/// </summary>
public record PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFindResponseDto
{
    /// <summary>
    /// <para>符合条件的信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("find_result")]
    public FindReplaceResult? FindResult { get; set; }

    /// <summary>
    /// <para>符合条件的信息</para>
    /// </summary>
    public record FindReplaceResult
    {
        /// <summary>
        /// <para>符合查找条件的单元格数组，不包含公式</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("matched_cells")]
        public string[]? MatchedCells { get; set; }

        /// <summary>
        /// <para>符合查找条件的含有公式的单元格数组</para>
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
