using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 创建筛选视图 响应体
/// <para>根据传入的参数创建一个筛选视图。Id 和 名字可选，不填的话会默认生成；range 必填。Id 长度为10，由 0-9、a-z、A-Z 组合生成。名字长度不超过100。单个子表内的筛选视图个数不超过 150。</para>
/// <para>接口ID：6970504825797672963</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter_view/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter_view%2fcreate</para>
/// </summary>
public record PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsResponseDto
{
    /// <summary>
    /// <para>创建的筛选视图的 id 、name、range</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("filter_view")]
    public FilterViewSuffix? FilterView { get; set; }

    /// <summary></summary>
    public record FilterViewSuffix
    {
        /// <summary>
        /// <para>筛选视图 id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("filter_view_id")]
        public string? FilterViewId { get; set; }

        /// <summary>
        /// <para>筛选视图名字</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("filter_view_name")]
        public string? FilterViewName { get; set; }

        /// <summary>
        /// <para>筛选视图的筛选范围</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("range")]
        public string? Range { get; set; }
    }
}
