namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 获取旧版文档中的电子表格元数据 响应体
/// <para>此接口只支持获取旧版文档数据。要获取新版文档（`docx` 类型）中的元数据，使用[获取文档元数据](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/meta/batch_query)接口。</para>
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
    [JsonPropertyName("spreadsheetToken")]
    public string? SpreadsheetToken { get; set; }

    /// <summary>
    /// <para>doc 下的 sheet 属性</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sheets")]
    public string? Sheets { get; set; }

    /// <summary>
    /// <para>sheet 的 id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sheetId")]
    public string? SheetId { get; set; }

    /// <summary>
    /// <para>sheet 的标题</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// <para>该 sheet 的位置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>
    /// <para>该 sheet 的行数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("rowCount")]
    public string? RowCount { get; set; }

    /// <summary>
    /// <para>该 sheet 的列数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("columnCount")]
    public string? ColumnCount { get; set; }
}
