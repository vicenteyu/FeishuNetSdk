namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 批量设置单元格样式  响应体
/// <para>该接口用于根据 spreadsheetToken 、range和样式信息 批量更新单元格样式；单次写入不超过5000行，100列。建议在设置边框样式时，每次更新的单元格数量不要超过30000个。一个区域被多个range覆盖时，仅最后一个样式会被应用。</para>
/// <para>接口ID：6907569742383923202</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/batch-set-cell-style</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuAzMzUjLwMzM14CMzMTN</para>
/// </summary>
public record PutSheetsV2SpreadsheetsBySpreadsheetTokenStylesBatchUpdateResponseDto
{
    /// <summary>
    /// <para>spreadsheet 的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("spreadsheetToken")]
    public string? SpreadsheetToken { get; set; }

    /// <summary>
    /// <para>设置样式的总行数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("totalUpdatedRows")]
    public int? TotalUpdatedRows { get; set; }

    /// <summary>
    /// <para>设置样式的总列数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("totalUpdatedColumns")]
    public int? TotalUpdatedColumns { get; set; }

    /// <summary>
    /// <para>设置样式的单元格总数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("totalUpdatedCells")]
    public int? TotalUpdatedCells { get; set; }

    /// <summary>
    /// <para>sheet 的版本号</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("revision")]
    public int? Revision { get; set; }

    /// <summary>
    /// <para>各个范围的设置单元格样式的范围、行列数等</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("responses")]
    public Response[]? Responses { get; set; }

    /// <summary></summary>
    public record Response
    {
        /// <summary>
        /// <para>spreadsheet 的 token</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("spreadsheetToken")]
        public string? SpreadsheetToken { get; set; }

        /// <summary>
        /// <para>设置样式的范围</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("updatedRange")]
        public string? UpdatedRange { get; set; }

        /// <summary>
        /// <para>设置样式的行数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("updatedRows")]
        public int? UpdatedRows { get; set; }

        /// <summary>
        /// <para>设置样式的列数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("updatedColumns")]
        public int? UpdatedColumns { get; set; }

        /// <summary>
        /// <para>设置样式的单元格数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("updatedCells")]
        public int? UpdatedCells { get; set; }
    }
}
