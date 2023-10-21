using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 更新筛选条件 请求体
/// <para>更新筛选视图范围的某列的筛选条件，condition id 即为列的字母号。{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=sheets&version=v3&resource=spreadsheet.sheet.filter_view.condition&method=update)</para>
/// <para>接口ID：6970504825797541891</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter_view/spreadsheet-sheet-filter_view-condition/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter_view-condition%2fupdate</para>
/// </summary>
public record PutSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdConditionsByConditionIdBodyDto
{
    /// <summary>
    /// <para>筛选类型</para>
    /// <para>**示例值**："number"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("filter_type")]
    public string? FilterType { get; set; }

    /// <summary>
    /// <para>比较类型</para>
    /// <para>**示例值**："less"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("compare_type")]
    public string? CompareType { get; set; }

    /// <summary>
    /// <para>筛选参数</para>
    /// <para>**示例值**：6</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("expected")]
    public string[]? Expected { get; set; }
}
