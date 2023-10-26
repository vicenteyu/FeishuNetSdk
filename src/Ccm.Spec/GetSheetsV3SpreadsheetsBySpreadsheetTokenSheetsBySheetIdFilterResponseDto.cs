using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 获取筛选 响应体
/// <para>获取子表的详细筛选信息</para>
/// <para>接口ID：6966945328390651906</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter%2fget</para>
/// </summary>
public record GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterResponseDto
{
    /// <summary>
    /// <para>筛选信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("sheet_filter_info")]
    public SheetFilterInfoSuffix? SheetFilterInfo { get; set; }

    /// <summary></summary>
    public record SheetFilterInfoSuffix
    {
        /// <summary>
        /// <para>筛选应用范围</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("range")]
        public string? Range { get; set; }

        /// <summary>
        /// <para>筛选出来隐藏的行</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("filtered_out_rows")]
        public int[]? FilteredOutRows { get; set; }

        /// <summary>
        /// <para>sheet的筛选条件</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("filter_infos")]
        public FilterInfo[]? FilterInfos { get; set; }

        /// <summary></summary>
        public record FilterInfo
        {
            /// <summary>
            /// <para>设置了筛选条件的列</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("col")]
            public string? Col { get; set; }

            /// <summary>
            /// <para>筛选条件</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("conditions")]
            public Condition[]? Conditions { get; set; }

            /// <summary></summary>
            public record Condition
            {
                /// <summary>
                /// <para>筛选类型</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("filter_type")]
                public string? FilterType { get; set; }

                /// <summary>
                /// <para>比较类型</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("compare_type")]
                public string? CompareType { get; set; }

                /// <summary>
                /// <para>筛选参数</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("expected")]
                public string[]? Expected { get; set; }
            }
        }
    }
}
