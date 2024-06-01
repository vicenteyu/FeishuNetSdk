namespace FeishuNetSdk.Ccm;
/// <summary>
/// 修改电子表格属性 请求体
/// <para>该接口用于修改电子表格的属性。目前支持修改电子表格标题。</para>
/// <para>接口ID：7120425077330903068</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet%2fpatch</para>
/// </summary>
public record PatchSheetsV3SpreadsheetsBySpreadsheetTokenBodyDto
{
    /// <summary>
    /// <para>新的电子表格标题。参数为空时，表格标题将显示为“未命名表格”或本地语言环境对应内容。</para>
    /// <para>必填：否</para>
    /// <para>示例值：Sales sheet</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
