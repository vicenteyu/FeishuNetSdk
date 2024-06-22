namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 设置单元格样式  响应体
/// <para>设置单元格中数据的样式。支持设置字体、背景、边框等样式。</para>
/// <para>接口ID：6907569523176783873</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/set-cell-style</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukjMzUjL5IzM14SOyMTN</para>
/// </summary>
public record PutSheetsV2SpreadsheetsBySpreadsheetTokenStyleResponseDto
{
    /// <summary>
    /// <para>更新的单元格信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("updates")]
    public UpdatesSuffix? Updates { get; set; }

    /// <summary></summary>
    public record UpdatesSuffix
    {
        /// <summary>
        /// <para>工作表的版本号。从 0 开始计数，更新一次版本号加一。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("revision")]
        public int? Revision { get; set; }

        /// <summary>
        /// <para>电子表格的 token</para>
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
        /// <para>设置样式的单元格总数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("updatedCells")]
        public int? UpdatedCells { get; set; }
    }
}
