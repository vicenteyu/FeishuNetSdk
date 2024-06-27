// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询筛选视图 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 查询筛选视图 响应体
/// <para>查询电子表格指定工作表的所有筛选视图及其基本信息，包括视图 ID、视图名称和筛选范围。</para>
/// <para>接口ID：6970504825797574659</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter_view/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter_view%2fquery</para>
/// </summary>
public record GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsQueryResponseDto
{
    /// <summary>
    /// <para>筛选视图及其基本信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public FilterView[]? Items { get; set; }

    /// <summary>
    /// <para>筛选视图及其基本信息</para>
    /// </summary>
    public record FilterView
    {
        /// <summary>
        /// <para>筛选视图 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：pH9hbVcCXA</para>
        /// </summary>
        [JsonPropertyName("filter_view_id")]
        public string? FilterViewId { get; set; }

        /// <summary>
        /// <para>筛选视图名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：筛选视图 1</para>
        /// </summary>
        [JsonPropertyName("filter_view_name")]
        public string? FilterViewName { get; set; }

        /// <summary>
        /// <para>筛选视图的筛选范围</para>
        /// <para>必填：否</para>
        /// <para>示例值：8fe9d6!C1:H14</para>
        /// </summary>
        [JsonPropertyName("range")]
        public string? Range { get; set; }
    }
}
