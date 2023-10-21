using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 更新表格属性 响应体
/// <para>该接口用于根据 spreadsheetToken 更新表格属性，如更新表格标题。</para>
/// <para>接口ID：6907569742384201730</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/sheets/update-spreadsheet-properties</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fucTMzUjL3EzM14yNxMTN</para>
/// </summary>
public record PutSheetsV2SpreadsheetsBySpreadsheetTokenPropertiesResponseDto
{
    /// <summary>
    /// <para>spreadsheet 的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("spreadsheetToken")]
    public string? SpreadsheetToken { get; set; }

    /// <summary>
    /// <para>spreadsheet 的标题</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("title")]
    public string? Title { get; set; }
}
