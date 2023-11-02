using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取电子表格信息 响应体
/// <para>该接口用于获取电子表格的基础信息。</para>
/// <para>接口ID：7120425077330919452</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet%2fget</para>
/// </summary>
public record GetSheetsV3SpreadsheetsBySpreadsheetTokenResponseDto
{
    /// <summary>
    /// <para>电子表格属性</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("spreadsheet")]
    public GetSpreadsheet? Spreadsheet { get; set; }

    /// <summary>
    /// <para>电子表格属性</para>
    /// </summary>
    public record GetSpreadsheet
    {
        /// <summary>
        /// <para>电子表格标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：title</para>
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>电子表格owner</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_xxxxxxxxxxxx</para>
        /// </summary>
        [JsonProperty("owner_id")]
        public string? OwnerId { get; set; }

        /// <summary>
        /// <para>电子表格token</para>
        /// <para>必填：否</para>
        /// <para>示例值：shtxxxxxxxxxxxxxx</para>
        /// </summary>
        [JsonProperty("token")]
        public string? Token { get; set; }

        /// <summary>
        /// <para>电子表格url</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://example.feishu.cn/sheets/shtcnmBA*****yGehy8</para>
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }
    }
}
