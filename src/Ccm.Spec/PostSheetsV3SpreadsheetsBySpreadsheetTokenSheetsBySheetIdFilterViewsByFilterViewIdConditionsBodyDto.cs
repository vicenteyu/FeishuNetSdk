using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 创建筛选条件 请求体
/// <para>在筛选视图的筛选范围的某一列创建筛选条件。</para>
/// <para>接口ID：6970504825797705731</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter_view/spreadsheet-sheet-filter_view-condition/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter_view-condition%2fcreate</para>
/// </summary>
public record PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdConditionsBodyDto
{
    /// <summary>
    /// <para>设置筛选条件的列，使用字母号</para>
    /// <para>**示例值**："E"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("condition_id")]
    public string? ConditionId { get; set; }

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
