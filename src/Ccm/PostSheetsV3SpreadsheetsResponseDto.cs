namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建电子表格 响应体
/// <para>在云空间指定目录下创建电子表格。可自定义表格标题。不支持带内容创建表格。</para>
/// <para>接口ID：6969763153149476865</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet%2fcreate</para>
/// </summary>
public record PostSheetsV3SpreadsheetsResponseDto
{
    /// <summary>
    /// <para>电子表格的基础信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("spreadsheet")]
    public PostSheetsV3SpreadsheetsResponseDtoSpreadsheet? Spreadsheet { get; set; }

    /// <summary>
    /// <para>电子表格的基础信息</para>
    /// </summary>
    public record PostSheetsV3SpreadsheetsResponseDtoSpreadsheet
    {
        /// <summary>
        /// <para>电子表格标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：Sales sheet</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>文件夹 token</para>
        /// <para>必填：否</para>
        /// <para>示例值：fldbcO1UuPz8VwnpPx5a92abcef</para>
        /// </summary>
        [JsonPropertyName("folder_token")]
        public string? FolderToken { get; set; }

        /// <summary>
        /// <para>电子表格的 URL 链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://example.feishu.cn/sheets/Iow7sNNEphp3WbtnbCscPqabcef</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>电子表格 token</para>
        /// <para>必填：否</para>
        /// <para>示例值：Iow7sNNEphp3WbtnbCscPqabcef</para>
        /// </summary>
        [JsonPropertyName("spreadsheet_token")]
        public string? SpreadsheetToken { get; set; }
    }
}
