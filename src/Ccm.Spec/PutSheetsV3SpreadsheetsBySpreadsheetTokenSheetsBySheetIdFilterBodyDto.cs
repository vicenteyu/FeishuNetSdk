namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 更新筛选 请求体
/// <para>更新子表筛选范围中的列筛选条件。</para>
/// <para>接口ID：6966945328390684674</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter%2fupdate</para>
/// </summary>
public record PutSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterBodyDto
{
    /// <summary>
    /// <para>更新筛选条件的列</para>
    /// <para>**示例值**："E"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("col")]
    public string Col { get; set; } = string.Empty;

    /// <summary>
    /// <para>筛选条件</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("condition")]
    public ConditionSuffix Condition { get; set; } = new();

    /// <summary></summary>
    public record ConditionSuffix
    {
        /// <summary>
        /// <para>筛选类型</para>
        /// <para>**示例值**："number"</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("filter_type")]
        public string FilterType { get; set; } = string.Empty;

        /// <summary>
        /// <para>比较类型</para>
        /// <para>**示例值**："less"</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("compare_type")]
        public string? CompareType { get; set; }

        /// <summary>
        /// <para>筛选参数</para>
        /// <para>**示例值**：6</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("expected")]
        public string[] Expected { get; set; } = Array.Empty<string>();
    }
}
