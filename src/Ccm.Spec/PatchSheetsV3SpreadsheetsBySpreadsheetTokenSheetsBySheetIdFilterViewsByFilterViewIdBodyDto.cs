using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 更新筛选视图 请求体
/// <para>更新筛选视图的名字或者筛选范围。名字长度不超过100，不能重复即子表内唯一；筛选范围不超过子表的最大范围。</para>
/// <para>接口ID：6970504825797591043</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter_view/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter_view%2fpatch</para>
/// </summary>
public record PatchSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdBodyDto
{
    /// <summary>
    /// <para>筛选视图名字</para>
    /// <para>**示例值**："筛选视图 1"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("filter_view_name")]
    public string? FilterViewName { get; set; }

    /// <summary>
    /// <para>筛选视图的筛选范围</para>
    /// <para>**示例值**："0b**12!C1:H14"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("range")]
    public string? Range { get; set; }
}
