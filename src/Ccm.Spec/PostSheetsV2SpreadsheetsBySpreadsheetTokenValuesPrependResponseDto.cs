namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 插入数据 响应体
/// <para>根据 [SpreadsheetToken](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview#6d80ef81) 在其**特定工作表的指定范围**的开始位置上方增加若干行，并填充相应的数据。这里的工作表和范围是通过接口请求体中的`range`属性来确定的，例如：</para>
/// <para>"range": "8fe9d6!A2:B2"</para>
/// <para>接口ID：6907569742384398338</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/prepend-data</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIjMzUjLyIzM14iMyMTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesPrependResponseDto
{
    /// <summary>
    /// <para>spreadsheet 的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("spreadsheetToken")]
    public string? SpreadsheetToken { get; set; }

    /// <summary>
    /// <para>写入的范围</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tableRange")]
    public string? TableRange { get; set; }

    /// <summary>
    /// <para>sheet 的版本号</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("revision")]
    public int? Revision { get; set; }

    /// <summary>
    /// <para>插入数据的范围、行列数等</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("updates")]
    public Update? Updates { get; set; }

    /// <summary></summary>
    public record Update
    {
        /// <summary>
        /// <para>spreadsheet 的 token</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("spreadsheetToken")]
        public string? SpreadsheetToken { get; set; }

        /// <summary>
        /// <para>写入的范围</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("updatedRange")]
        public string? UpdatedRange { get; set; }

        /// <summary>
        /// <para>写入的行数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("updatedRows")]
        public int? UpdatedRows { get; set; }

        /// <summary>
        /// <para>写入的列数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("updatedColumns")]
        public int? UpdatedColumns { get; set; }

        /// <summary>
        /// <para>写入的单元格总数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("updatedCells")]
        public int? UpdatedCells { get; set; }

        /// <summary>
        /// <para>sheet 的版本号</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("revision")]
        public int? Revision { get; set; }
    }
}
