namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 操作工作表 请求体
/// <para>根据电子表格的 token 对工作表进行操作，包括增加工作表、复制工作表、删除工作表。</para>
/// <para>该接口和 [更新工作表属性](https://open.feishu.cn/document/ukTMukTMukTM/ugjMzUjL4IzM14COyMTN) 的请求地址相同，但参数不同，调用前请仔细阅读文档。</para>
/// <para>接口ID：6907569745299439618</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet/operate-sheets</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYTMzUjL2EzM14iNxMTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenSheetsBatchUpdateBodyDto
{
    /// <summary>
    /// <para>支持增加、复制、和删除工作表。一次请求可以同时进行多个操作。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("requests")]
    public Request[] Requests { get; set; } = Array.Empty<Request>();

    /// <summary></summary>
    public record Request
    {
        /// <summary>
        /// <para>增加工作表。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("addSheet")]
        public AddsheetSuffix? AddSheet { get; set; }

        /// <summary></summary>
        public record AddsheetSuffix
        {
            /// <summary>
            /// <para>工作表属性</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("properties")]
            public Property Properties { get; set; } = new();

            /// <summary></summary>
            public record Property
            {
                /// <summary>
                /// <para>新增工作表的标题</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// <para>新增工作表的位置。不填默认在工作表的第 0 索引位置增加工作表。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("index")]
                public int? Index { get; set; }
            }
        }

        /// <summary>
        /// <para>复制工作表。复制的新工作表位于源工作表索引位置之后。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("copySheet")]
        public CopysheetSuffix? CopySheet { get; set; }

        /// <summary></summary>
        public record CopysheetSuffix
        {
            /// <summary>
            /// <para>需要复制的工作表资源</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("source")]
            public Sheet Source { get; set; } = new();

            /// <summary>
            /// <para>新工作表的属性</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("destination")]
            public DestinationSuffix Destination { get; set; } = new();

            /// <summary></summary>
            public record DestinationSuffix
            {
                /// <summary>
                /// <para>新工作表名称。不填默认为“源工作表名称”+“(副本_源工作表的 `index` 值)”，如 “Sheet1(副本_0)”。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("title")]
                public string? Title { get; set; }
            }
        }
        /// <summary>
        /// <para>删除工作表。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("deleteSheet")]
        public Sheet? DeleteSheet { get; set; }

        /// <summary></summary>
        public record Sheet
        {
            /// <summary>
            /// <para>要删除的工作表的 ID。调用[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query)获取 ID</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("sheetId")]
            public string SheetId { get; set; } = string.Empty;
        }
    }
}
