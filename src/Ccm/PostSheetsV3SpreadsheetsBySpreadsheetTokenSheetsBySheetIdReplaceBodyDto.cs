// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdReplaceBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>替换单元格 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 替换单元格 请求体
/// <para>在指定范围内，查找并替换符合查找条件的单元格。</para>
/// <para>## 使用限制</para>
/// <para>单次最多可替换 5,000 个单元格。</para>
/// <para>接口ID：6982374372208607234</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/replace</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet%2freplace</para>
/// </summary>
public record PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdReplaceBodyDto
{
    /// <summary>
    /// <para>指定查找单元格的条件。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("find_condition")]
    public PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdReplaceBodyDtoFindCondition FindCondition { get; set; } = new();

    /// <summary>
    /// <para>指定查找单元格的条件。</para>
    /// </summary>
    public record PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdReplaceBodyDtoFindCondition
    {
        /// <summary>
        /// <para>查找范围。格式为 `&lt;sheetId&gt;!&lt;开始位置&gt;:&lt;结束位置&gt;`。其中：</para>
        /// <para>- `sheetId` 为工作表 ID，通过[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query) 获取</para>
        /// <para>- `&lt;开始位置&gt;:&lt;结束位置&gt;` 为工作表中单元格的范围，数字表示行索引，字母表示列索引。如 `A2:B2` 表示该工作表第 2 行的 A 列到 B 列。`range`支持四种写法，详情参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
        /// <para>必填：是</para>
        /// <para>示例值：PNIfrm!A1:C5</para>
        /// </summary>
        [JsonPropertyName("range")]
        public string Range { get; set; } = string.Empty;

        /// <summary>
        /// <para>是否忽略查找字符串的大小写，默认为 false。</para>
        /// <para>- `true`：忽略字符串中字母大小写差异</para>
        /// <para>- `false`：区分字符串中字母大小写</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("match_case")]
        public bool? MatchCase { get; set; }

        /// <summary>
        /// <para>字符串是否需要完全匹配整个单元格，默认值为 false。</para>
        /// <para>- `true`：完全匹配单元格，比如 `find` 参数 取值为 "hello"，则单元格中的内容必须为 "hello" 才会匹配替换</para>
        /// <para>- `false`：允许部分匹配单元格，比如 `find` 取值为 "hello"，则单元格中的内容包含 "hello" 即可匹配替换</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("match_entire_cell")]
        public bool? MatchEntireCell { get; set; }

        /// <summary>
        /// <para>是否使用正则表达式查找，默认值为 false。</para>
        /// <para>- `true`：使用正则表达式</para>
        /// <para>- `false`：不使用正则表达式</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("search_by_regex")]
        public bool? SearchByRegex { get; set; }

        /// <summary>
        /// <para>是否仅搜索单元格公式，默认值为 false。</para>
        /// <para>- `true`：仅搜索单元格公式</para>
        /// <para>- `false`：仅搜索单元格内容</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("include_formulas")]
        public bool? IncludeFormulas { get; set; }
    }

    /// <summary>
    /// <para>查找的字符串。当`search_by_regex` 字段为 true 时，你需填入正则表达式。</para>
    /// <para>必填：是</para>
    /// <para>示例值：hello</para>
    /// </summary>
    [JsonPropertyName("find")]
    public string Find { get; set; } = string.Empty;

    /// <summary>
    /// <para>替换的字符串</para>
    /// <para>必填：是</para>
    /// <para>示例值：world</para>
    /// </summary>
    [JsonPropertyName("replacement")]
    public string Replacement { get; set; } = string.Empty;
}
