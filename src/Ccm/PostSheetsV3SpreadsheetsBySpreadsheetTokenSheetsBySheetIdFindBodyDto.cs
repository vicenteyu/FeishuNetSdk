using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 查找单元格 请求体
/// <para>在指定范围内查找符合查找条件的单元格。</para>
/// <para>接口ID：6982374372208590850</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/find</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet%2ffind</para>
/// </summary>
public record PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFindBodyDto
{
    /// <summary>
    /// <para>查找条件</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("find_condition")]
    public PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFindBodyDtoFindCondition FindCondition { get; set; } = new();

    /// <summary>
    /// <para>查找条件</para>
    /// </summary>
    public record PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFindBodyDtoFindCondition
    {
        /// <summary>
        /// <para>查找范围，参考 [名词解释 Range](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
        /// <para>必填：是</para>
        /// <para>示例值：PNIfrm!A1:C5</para>
        /// </summary>
        [JsonProperty("range")]
        public string Range { get; set; } = string.Empty;

        /// <summary>
        /// <para>是否忽略大小写，默认为 false</para>
        /// <para>- `true`：表示忽略字符串中字母大小写差异</para>
        /// <para>- `false`：表示区分字符串中字母大小写</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("match_case")]
        public bool? MatchCase { get; set; }

        /// <summary>
        /// <para>是否完全匹配整个单元格，默认值为 false</para>
        /// <para>- `true`：表示完全匹配单元格，比如 find 取值为 "hello"，则单元格中的内容必须为 "hello"</para>
        /// <para>- `false`：表示允许部分匹配单元格，比如 find 取值为 "hello"，则单元格中的内容包含 "hello" 即可</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("match_entire_cell")]
        public bool? MatchEntireCell { get; set; }

        /// <summary>
        /// <para>是否为正则匹配，默认值为 false</para>
        /// <para>- `true`：表示使用正则匹配</para>
        /// <para>- `false`：表示不使用正则匹配</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("search_by_regex")]
        public bool? SearchByRegex { get; set; }

        /// <summary>
        /// <para>是否仅搜索单元格公式，默认值为 false</para>
        /// <para>- `true`：表示仅搜索单元格公式</para>
        /// <para>- `false`：表示仅搜索单元格内容</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("include_formulas")]
        public bool? IncludeFormulas { get; set; }
    }

    /// <summary>
    /// <para>查找的字符串，当`search_by_regex`字段为 true 时，该字段为正则表达式</para>
    /// <para>必填：是</para>
    /// <para>示例值：如下 - 普通查找示例: "hello" - 正则查找示例: "[A-Z]\w+"</para>
    /// </summary>
    [JsonProperty("find")]
    public string Find { get; set; } = string.Empty;
}
