// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建筛选 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建筛选 请求体
/// <para>在电子表格工作表的指定范围内，设置筛选条件，创建筛选。</para>
/// <para>接口ID：6966945328390668290</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter%2fcreate</para>
/// </summary>
public record PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterBodyDto
{
    /// <summary>
    /// <para>设置筛选的应用范围。支持以下五种写法，了解更多，参考[筛选指南](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter/filter-user-guide)。</para>
    /// <para>- `sheetId`：填写实际的工作表 ID，表示将筛选应用于整表</para>
    /// <para>- `sheetId!{开始行索引}:{结束行索引}` ：填写工作表 ID 和行数区间，表示将筛选应用于整行</para>
    /// <para>- `sheetId!{开始列索引}:{结束列索引}`：填写工作表 ID 和列的区间，表示将筛选应用于整列</para>
    /// <para>- `sheetId!{开始单元格}:{结束单元格}`：填写工作表 ID 和单元格区间，表示将筛选应用于单元格选定的区域中</para>
    /// <para>- `sheetId!{开始单元格}:{结束列索引}`：填写工作表 ID、起始单元格和结束列，表示省略结束行，使用表格的最后行作为结束行</para>
    /// <para>必填：是</para>
    /// <para>示例值：8fe9d6!A1:H14</para>
    /// </summary>
    [JsonPropertyName("range")]
    public string Range { get; set; } = string.Empty;

    /// <summary>
    /// <para>设置应用筛选条件的列。</para>
    /// <para>必填：是</para>
    /// <para>示例值：E</para>
    /// </summary>
    [JsonPropertyName("col")]
    public string Col { get; set; } = string.Empty;

    /// <summary>
    /// <para>设置筛选条件。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("condition")]
    public PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterBodyDtoCondition Condition { get; set; } = new();

    /// <summary>
    /// <para>设置筛选条件。</para>
    /// </summary>
    public record PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterBodyDtoCondition
    {
        /// <summary>
        /// <para>筛选类型，枚举值如下所示。了解更多，参考[筛选指南](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter/filter-user-guide)。</para>
        /// <para>- multiValue ：多值筛选</para>
        /// <para>- number ：数字筛选</para>
        /// <para>- text ：文本筛选</para>
        /// <para>- color ：颜色筛选</para>
        /// <para>- clear ：清除某列的筛选条件</para>
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
        /// <para>示例值：6</para>
        /// </summary>
        [JsonPropertyName("expected")]
        public string[] Expected { get; set; } = Array.Empty<string>();
    }
}
