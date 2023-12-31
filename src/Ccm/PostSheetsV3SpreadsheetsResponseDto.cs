namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建表格 响应体
/// <para>在指定目录下创建表格</para>
/// <para>接口ID：6969763153149476865</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet%2fcreate</para>
/// </summary>
public record PostSheetsV3SpreadsheetsResponseDto
{
    /// <summary>
    /// <para>表格</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("spreadsheet")]
    public PostSheetsV3SpreadsheetsResponseDtoSpreadsheet? Spreadsheet { get; set; }

    /// <summary>
    /// <para>表格</para>
    /// </summary>
    public record PostSheetsV3SpreadsheetsResponseDtoSpreadsheet
    {
        /// <summary>
        /// <para>表格标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：title</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>文件夹token，获取方式见[如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN)</para>
        /// <para>必填：否</para>
        /// <para>示例值：fldcnMsNb*****hIW9IjG1LVswg</para>
        /// </summary>
        [JsonPropertyName("folder_token")]
        public string? FolderToken { get; set; }

        /// <summary>
        /// <para>文档url</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://example.feishu.cn/sheets/shtcnmBA*****yGehy8</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>表格token</para>
        /// <para>必填：否</para>
        /// <para>示例值：shtcnmBA*****yGehy8</para>
        /// </summary>
        [JsonPropertyName("spreadsheet_token")]
        public string? SpreadsheetToken { get; set; }
    }
}
