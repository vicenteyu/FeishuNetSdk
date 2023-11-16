namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 创建筛选 请求体
/// <para>在子表内创建筛选。</para>
/// <para>接口ID：6966945328390668290</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter%2fcreate</para>
/// </summary>
public record PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterBodyDto
{
    /// <summary>
    /// <para>筛选应用范围</para>
    /// <para>**示例值**："xxxxxx!C1:H14"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("range")]
    public string Range { get; set; } = string.Empty;

    /// <summary>
    /// <para>设置筛选条件的列</para>
    /// <para>**示例值**："E"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("col")]
    public string Col { get; set; } = string.Empty;

    /// <summary>
    /// <para>筛选的条件</para>
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
