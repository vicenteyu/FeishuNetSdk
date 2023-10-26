using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 获取旧版文档中的电子表格元数据 响应体
/// <para>该接口用于根据 docToken 获取文档中的电子表格的元数据。 </para>
/// <para>接口ID：6907569744330833921</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/document/obtain-sheet-meta-info-in-doc</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuADOzUjLwgzM14CM4MTN</para>
/// </summary>
public record GetDocV2ByDocTokenSheetMetaResponseDto
{
    /// <summary>
    /// <para>sheet 的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("spreadsheetToken")]
    public string? SpreadsheetToken { get; set; }

    /// <summary>
    /// <para>doc 下的 sheet 属性</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("sheets")]
    public Sheet[]? Sheets { get; set; }

    /// <summary></summary>
    public record Sheet
    {
        /// <summary>
        /// <para>sheet 的 id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("sheetId")]
        public string? SheetId { get; set; }

        /// <summary>
        /// <para>sheet 的标题</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>该 sheet 的位置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// <para>该 sheet 的行数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("rowCount")]
        public int? RowCount { get; set; }

        /// <summary>
        /// <para>该 sheet 的列数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("columnCount")]
        public int? ColumnCount { get; set; }
    }
}
