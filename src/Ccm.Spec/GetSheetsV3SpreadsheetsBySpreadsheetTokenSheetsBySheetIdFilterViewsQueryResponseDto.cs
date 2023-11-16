namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 查询筛选视图 响应体
/// <para>查询子表内所有的筛选视图基本信息，包括 id、name 和 range</para>
/// <para>接口ID：6970504825797574659</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter_view/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter_view%2fquery</para>
/// </summary>
public record GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsQueryResponseDto
{
    /// <summary>
    /// <para>子表的所有筛选视图信息，id、name、range</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public FilterView[]? Items { get; set; }

    /// <summary></summary>
    public record FilterView
    {
        /// <summary>
        /// <para>筛选视图 id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("filter_view_id")]
        public string? FilterViewId { get; set; }

        /// <summary>
        /// <para>筛选视图名字</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("filter_view_name")]
        public string? FilterViewName { get; set; }

        /// <summary>
        /// <para>筛选视图的筛选范围</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("range")]
        public string? Range { get; set; }
    }
}
