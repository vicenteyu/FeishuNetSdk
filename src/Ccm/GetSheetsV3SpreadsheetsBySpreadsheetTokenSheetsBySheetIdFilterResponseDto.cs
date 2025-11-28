// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取筛选 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取筛选 响应体
/// <para>获取电子表格中工作表的详细筛选信息，包括筛选的应用范围、筛选条件、被筛选条件过滤掉的行。</para>
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
        /// <para>筛选的应用范围</para>
        /// <para>必填：是</para>
        /// <para>示例值：8fe9d6!A1:H14</para>
        /// </summary>
        [JsonPropertyName("range")]
        public string Range { get; set; } = string.Empty;

        /// <summary>
        /// <para>被筛选条件过滤掉的行。从 1 开始索引。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("filtered_out_rows")]
        public int[] FilteredOutRows { get; set; } = [];

        /// <summary>
        /// <para>工作表的筛选条件</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("filter_infos")]
        public FilterInfo[] FilterInfos { get; set; } = [];

        /// <summary>
        /// <para>工作表的筛选条件</para>
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
            public Condition[] Conditions { get; set; } = [];

            /// <summary>
            /// <para>筛选条件</para>
            /// </summary>
            public record Condition
            {
                /// <summary>
                /// <para>筛选类型，枚举值如下所示。了解更多，参考[筛选指南](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter/filter-user-guide)。</para>
                /// <para>- multiValue ：多值筛选</para>
                /// <para>- number ：数字筛选</para>
                /// <para>- text ：文本筛选</para>
                /// <para>- color ：颜色筛选</para>
                /// <para>- clear ：清除筛选</para>
                /// <para>必填：是</para>
                /// <para>示例值：number</para>
                /// </summary>
                [JsonPropertyName("filter_type")]
                public string FilterType { get; set; } = string.Empty;

                /// <summary>
                /// <para>比较类型。不同筛选类型的比较类型的枚举值不同，详情参考[筛选指南](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter/filter-user-guide)。</para>
                /// <para>必填：否</para>
                /// <para>示例值：less</para>
                /// </summary>
                [JsonPropertyName("compare_type")]
                public string? CompareType { get; set; }

                /// <summary>
                /// <para>筛选参数。不同筛选类型的筛选参数限制不同，详情参考[筛选指南](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter/filter-user-guide)。</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("expected")]
                public string[] Expected { get; set; } = [];
            }
        }
    }
}
