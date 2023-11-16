namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 更新表格属性 请求体
/// <para>该接口用于根据 spreadsheetToken 更新表格属性，如更新表格标题。</para>
/// <para>接口ID：6907569742384201730</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/sheets/update-spreadsheet-properties</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fucTMzUjL3EzM14yNxMTN</para>
/// </summary>
public record PutSheetsV2SpreadsheetsBySpreadsheetTokenPropertiesBodyDto
{
    /// <summary>
    /// <para>spreadsheet 的属性</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("properties")]
    public Property Properties { get; set; } = new();

    /// <summary></summary>
    public record Property
    {
        /// <summary>
        /// <para>spreadsheet 的标题，最大长度100个字符</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;
    }
}
