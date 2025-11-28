// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="PutSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新筛选 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 更新筛选 请求体
/// <para>在电子表格工作表筛选范围中，更新指定列的筛选条件。</para>
/// <para>接口ID：6966945328390684674</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter%2fupdate</para>
/// </summary>
public record PutSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterBodyDto
{
    /// <summary>
    /// <para>指定要更新筛选条件的列。</para>
    /// <para>必填：是</para>
    /// <para>示例值：G</para>
    /// </summary>
    [JsonPropertyName("col")]
    public string Col { get; set; } = string.Empty;

    /// <summary>
    /// <para>设置筛选条件。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("condition")]
    public PutSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterBodyDtoCondition Condition { get; set; } = new();

    /// <summary>
    /// <para>设置筛选条件。</para>
    /// </summary>
    public record PutSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterBodyDtoCondition
    {
        /// <summary>
        /// <para>筛选类型，枚举值如下所示。了解更多，参考[筛选指南](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter/filter-user-guide)。</para>
        /// <para>- multiValue ：多值筛选</para>
        /// <para>- number ：数字筛选</para>
        /// <para>- text ：文本筛选</para>
        /// <para>- color ：颜色筛选</para>
        /// <para>- clear ：清除某列的筛选条件</para>
        /// <para>必填：是</para>
        /// <para>示例值：text</para>
        /// </summary>
        [JsonPropertyName("filter_type")]
        public string FilterType { get; set; } = string.Empty;

        /// <summary>
        /// <para>比较类型。不同筛选类型的比较类型的枚举值不同，详情参考[筛选指南](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter/filter-user-guide)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：beginsWith</para>
        /// </summary>
        [JsonPropertyName("compare_type")]
        public string? CompareType { get; set; }

        /// <summary>
        /// <para>筛选参数。不同筛选类型的筛选参数限制不同，详情参考[筛选指南](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter/filter-user-guide)。</para>
        /// <para>必填：是</para>
        /// <para>示例值：6</para>
        /// </summary>
        [JsonPropertyName("expected")]
        public string[] Expected { get; set; } = [];
    }
}
