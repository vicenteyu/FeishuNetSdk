namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 修改电子表格属性 请求体
/// <para>该接口用于修改电子表格的属性</para>
/// <para>接口ID：7120425077330903068</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet%2fpatch</para>
/// </summary>
public record PatchSheetsV3SpreadsheetsBySpreadsheetTokenBodyDto
{
    /// <summary>
    /// <para>表格标题</para>
    /// <para>**示例值**："title"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
