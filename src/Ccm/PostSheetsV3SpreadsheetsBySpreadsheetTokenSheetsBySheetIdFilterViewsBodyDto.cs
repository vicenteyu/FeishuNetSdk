// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建筛选视图 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建筛选视图 请求体
/// <para>指定电子表格工作表的筛选范围，创建一个筛选视图。</para>
/// <para>接口ID：6970504825797672963</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter_view/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter_view%2fcreate</para>
/// </summary>
public record PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsBodyDto
{
    /// <summary>
    /// <para>自定义筛选视图 ID。不填将由系统生成。长度需为 10 字符。字符可以是 0-9 数字、a-z、A-Z 字母或其组合。</para>
    /// <para>必填：否</para>
    /// <para>示例值：pH9hbVcCXA</para>
    /// </summary>
    [JsonPropertyName("filter_view_id")]
    public string? FilterViewId { get; set; }

    /// <summary>
    /// <para>自定义筛选视图名称。不填将由系统生成。长度不超过100 个字符。</para>
    /// <para>必填：否</para>
    /// <para>示例值：筛选视图 1</para>
    /// </summary>
    [JsonPropertyName("filter_view_name")]
    public string? FilterViewName { get; set; }

    /// <summary>
    /// <para>筛选视图的筛选范围。该参数必填，请忽略必填列的“否”。支持以下五种写法，了解更多，参考[筛选指南](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter/filter-user-guide)。</para>
    /// <para>- `sheetId`：填写实际的工作表 ID，表示将筛选应用于整表</para>
    /// <para>- `sheetId!{开始行索引}:{结束行索引}`：填写工作表 ID 和行数区间，表示将筛选应用于整行</para>
    /// <para>- `sheetId!{开始列索引}:{结束列索引}`：填写工作表 ID 和列的区间，表示将筛选应用于整列</para>
    /// <para>- `sheetId!{开始单元格}:{结束单元格}`：填写工作表 ID 和单元格区间，表示将筛选应用于单元格选定的区域中</para>
    /// <para>- `sheetId!{开始单元格}:{结束列索引}`：填写工作表 ID、起始单元格和结束列，表示省略结束行，使用表格的最后行作为结束行</para>
    /// <para>必填：否</para>
    /// <para>示例值：8fe9d6!C1:H14</para>
    /// </summary>
    [JsonPropertyName("range")]
    public string? Range { get; set; }
}
