using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 查询筛选条件 响应体
/// <para>查询一个筛选视图的所有筛选条件，返回筛选视图的筛选范围内的筛选条件。{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=sheets&version=v3&resource=spreadsheet.sheet.filter_view.condition&method=query)</para>
/// <para>接口ID：6970504825797607427</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter_view/spreadsheet-sheet-filter_view-condition/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter_view-condition%2fquery</para>
/// </summary>
public record GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdConditionsQueryResponseDto
{
    /// <summary>
    /// <para>筛选视图设置的所有筛选条件</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public FilterViewCondition[]? Items { get; set; }

    public record FilterViewCondition
    {
        /// <summary>
        /// <para>设置筛选条件的列，使用字母号</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("condition_id")]
        public string? ConditionId { get; set; }

        /// <summary>
        /// <para>筛选类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("filter_type")]
        public string? FilterType { get; set; }

        /// <summary>
        /// <para>比较类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("compare_type")]
        public string? CompareType { get; set; }

        /// <summary>
        /// <para>筛选参数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("expected")]
        public string[]? Expected { get; set; }
    }
}
