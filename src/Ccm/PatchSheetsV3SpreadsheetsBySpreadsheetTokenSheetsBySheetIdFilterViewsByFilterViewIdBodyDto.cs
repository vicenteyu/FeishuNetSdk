// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="PatchSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新筛选视图 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 更新筛选视图 请求体
/// <para>更新筛选视图的名称或筛选范围。</para>
/// <para>接口ID：6970504825797591043</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter_view/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter_view%2fpatch</para>
/// </summary>
public record PatchSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdBodyDto
{
    /// <summary>
    /// <para>筛选视图名称。长度不得超过 100 个字符，且在工作表内必须唯一。</para>
    /// <para>必填：否</para>
    /// <para>示例值：筛选视图 1</para>
    /// </summary>
    [JsonPropertyName("filter_view_name")]
    public string? FilterViewName { get; set; }

    /// <summary>
    /// <para>筛选视图的筛选范围。支持以下五种写法，了解更多，参考[筛选指南](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter/filter-user-guide)。</para>
    /// <para>- sheetId：填写实际的工作表 ID，表示将筛选应用于整表</para>
    /// <para>- sheetId!1:2 ：填写工作表 ID 和行数区间，表示将筛选应用于整行</para>
    /// <para>- sheetId!A:B ：填写工作表 ID 和列的区间，表示将筛选应用于整列</para>
    /// <para>- sheetId!A1:B2 ：填写工作表 ID 和单元格区间，表示将筛选应用于单元格选定的区域中</para>
    /// <para>- sheetId!A1:C ：填写工作表 ID、起始单元格和结束列，表示省略结束行，使用表格的最后行作为结束行</para>
    /// <para>必填：否</para>
    /// <para>示例值：8fe9d6!C1:H14</para>
    /// </summary>
    [JsonPropertyName("range")]
    public string? Range { get; set; }
}
