// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取筛选 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取筛选 响应体
/// <para>获取子表的详细筛选信息</para>
/// <para>接口ID：6966945328390651906</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter%2fget</para>
/// </summary>
public record GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterResponseDto
{
    /// <summary>
    /// <para>筛选信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sheet_filter_info")]
    public GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterResponseDtoSheetFilterInfo? SheetFilterInfo { get; set; }

    /// <summary>
    /// <para>筛选信息</para>
    /// </summary>
    public record GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterResponseDtoSheetFilterInfo
    {
        /// <summary>
        /// <para>筛选应用范围</para>
        /// <para>必填：是</para>
        /// <para>示例值：xxxxxx!A1:H14</para>
        /// </summary>
        [JsonPropertyName("range")]
        public string Range { get; set; } = string.Empty;

        /// <summary>
        /// <para>筛选出来隐藏的行</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("filtered_out_rows")]
        public int[] FilteredOutRows { get; set; } = Array.Empty<int>();

        /// <summary>
        /// <para>sheet的筛选条件</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("filter_infos")]
        public FilterInfo[] FilterInfos { get; set; } = Array.Empty<FilterInfo>();

        /// <summary>
        /// <para>sheet的筛选条件</para>
        /// </summary>
        public record FilterInfo
        {
            /// <summary>
            /// <para>设置了筛选条件的列</para>
            /// <para>必填：是</para>
            /// <para>示例值：E</para>
            /// </summary>
            [JsonPropertyName("col")]
            public string Col { get; set; } = string.Empty;

            /// <summary>
            /// <para>筛选条件</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("conditions")]
            public Condition[] Conditions { get; set; } = Array.Empty<Condition>();

            /// <summary>
            /// <para>筛选条件</para>
            /// </summary>
            public record Condition
            {
                /// <summary>
                /// <para>筛选类型</para>
                /// <para>必填：是</para>
                /// <para>示例值：number</para>
                /// </summary>
                [JsonPropertyName("filter_type")]
                public string FilterType { get; set; } = string.Empty;

                /// <summary>
                /// <para>比较类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：less</para>
                /// </summary>
                [JsonPropertyName("compare_type")]
                public string? CompareType { get; set; }

                /// <summary>
                /// <para>筛选参数</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("expected")]
                public string[] Expected { get; set; } = Array.Empty<string>();
            }
        }
    }
}
