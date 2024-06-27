// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdConditionsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建筛选条件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建筛选条件 响应体
/// <para>在筛选视图的指定列创建筛选条件，包括筛选的类型、比较类型、筛选参数等。</para>
/// <para>接口ID：6970504825797705731</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter_view/spreadsheet-sheet-filter_view-condition/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter_view-condition%2fcreate</para>
/// </summary>
public record PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdConditionsResponseDto
{
    /// <summary>
    /// <para>创建的筛选条件</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("condition")]
    public FilterViewCondition? Condition { get; set; }

    /// <summary>
    /// <para>创建的筛选条件</para>
    /// </summary>
    public record FilterViewCondition
    {
        /// <summary>
        /// <para>设置筛选条件的列</para>
        /// <para>必填：否</para>
        /// <para>示例值：E</para>
        /// </summary>
        [JsonPropertyName("condition_id")]
        public string? ConditionId { get; set; }

        /// <summary>
        /// <para>筛选类型。枚举值如下所示。了解更多，参考[筛选条件指南](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter_view-condition/filter-view-condition-user-guide)。</para>
        /// <para>- hiddenValue：隐藏值筛选</para>
        /// <para>- number：数字筛选</para>
        /// <para>- text：文本筛选</para>
        /// <para>- color：颜色筛选</para>
        /// <para>必填：否</para>
        /// <para>示例值：number</para>
        /// </summary>
        [JsonPropertyName("filter_type")]
        public string? FilterType { get; set; }

        /// <summary>
        /// <para>比较类型。了解更多，参考[筛选条件指南](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter_view-condition/filter-view-condition-user-guide)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：less</para>
        /// </summary>
        [JsonPropertyName("compare_type")]
        public string? CompareType { get; set; }

        /// <summary>
        /// <para>筛选参数。了解更多，参考[筛选条件指南](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter_view-condition/filter-view-condition-user-guide)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：6</para>
        /// </summary>
        [JsonPropertyName("expected")]
        public string[]? Expected { get; set; }
    }
}
