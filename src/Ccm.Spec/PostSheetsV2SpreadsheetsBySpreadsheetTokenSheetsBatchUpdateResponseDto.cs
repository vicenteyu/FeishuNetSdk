using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 操作工作表 响应体
/// <para>该接口用于根据 spreadsheetToken 操作表格，如增加工作表，复制工作表、删除工作表。</para>
/// <para>该接口和 [更新工作表属性](https://open.feishu.cn/document/ukTMukTMukTM/ugjMzUjL4IzM14COyMTN) 的请求地址相同，但参数不同，调用前请仔细阅读文档。</para>
/// <para>接口ID：6907569745299439618</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet/operate-sheets</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYTMzUjL2EzM14iNxMTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenSheetsBatchUpdateResponseDto
{
    /// <summary>
    /// <para>返回本次相关操作工作表的结果</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("replies")]
    public Reply[]? Replies { get; set; }

    public record Reply
    {
        /// <summary>
        /// <para>增加工作表的属性</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("addSheet")]
        public Sheet? AddSheet { get; set; }

        /// <summary>
        /// <para>复制工作表的属性</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("copySheet")]
        public Sheet? CopySheet { get; set; }

        public record Sheet
        {
            /// <summary>
            /// <para>表格属性</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("properties")]
            public Property? Properties { get; set; }
            public record Property
            {
                /// <summary>
                /// <para>sheetId</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("sheetId")]
                public string? SheetId { get; set; }

                /// <summary>
                /// <para>工作表标题</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("title")]
                public string? Title { get; set; }

                /// <summary>
                /// <para>工作表位置</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("index")]
                public int? Index { get; set; }
            }
        }

        /// <summary>
        /// <para>删除工作表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("deleteSheet")]
        public DeleteSheetSuffix? DeleteSheet { get; set; }

        public record DeleteSheetSuffix
        {
            /// <summary>
            /// <para>删除工作表是否成功</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("result")]
            public bool? Result { get; set; }

            /// <summary>
            /// <para>sheetId</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("sheetId")]
            public string? SheetId { get; set; }
        }
    }

}
