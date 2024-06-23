// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSheetsV2SpreadsheetsBySpreadsheetTokenMergeCellsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>合并单元格 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 合并单元格 请求体
/// <para>合并电子表格工作表中的单元格。</para>
/// <para>接口ID：6907569742387707906</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/merge-cells</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukDNzUjL5QzM14SO0MTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenMergeCellsBodyDto
{
    /// <summary>
    /// <para>要合并的单元格的范围，格式为 `&lt;sheetId&gt;!&lt;开始位置&gt;:&lt;结束位置&gt;`。其中：</para>
    /// <para>- `sheetId` 为工作表 ID，通过[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query) 获取。</para>
    /// <para>- `&lt;开始位置&gt;:&lt;结束位置&gt;` 为工作表中单元格的范围，数字表示行索引，字母表示列索引。如 `A2:B2` 表示该工作表第 2 行的 A 列到 B 列。`range`支持四种写法，详情参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("range")]
    public string Range { get; set; } = string.Empty;

    /// <summary>
    /// <para>指定合并单元格的方式。可选值：</para>
    /// <para>- MERGE_ALL：合并所有单元格，即将选定区域内的所有单元格合并成一个单元格</para>
    /// <para>- MERGE_ROWS：按行合并，即在选定的区域内，将同一行相邻的单元格合并成一个单元格</para>
    /// <para>- MERGE_COLUMNS：按列合并，即在选定的区域内，将同一列中相邻的单元格合并成一个单元格</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("mergeType")]
    public string MergeType { get; set; } = string.Empty;
}
