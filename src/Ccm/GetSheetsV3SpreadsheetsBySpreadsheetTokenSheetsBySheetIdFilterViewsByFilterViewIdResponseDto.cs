// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取筛选视图 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取筛选视图 响应体
/// <para>获取指定筛选视图的信息，包括 ID、名称和筛选范围。</para>
/// <para>接口ID：6970504825797558275</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter_view/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter_view%2fget</para>
/// </summary>
public record GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdResponseDto
{
    /// <summary>
    /// <para>筛选视图的信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("filter_view")]
    public GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdResponseDtoFilterView? FilterView { get; set; }

    /// <summary>
    /// <para>筛选视图的信息</para>
    /// </summary>
    public record GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdResponseDtoFilterView
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
