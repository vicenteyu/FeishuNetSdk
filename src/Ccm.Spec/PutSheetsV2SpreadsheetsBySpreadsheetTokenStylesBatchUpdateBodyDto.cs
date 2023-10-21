using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 批量设置单元格样式  请求体
/// <para>该接口用于根据 spreadsheetToken 、range和样式信息 批量更新单元格样式；单次写入不超过5000行，100列。建议在设置边框样式时，每次更新的单元格数量不要超过30000个。</para>
/// <para>接口ID：6907569742383923202</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/batch-set-cell-style</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuAzMzUjLwMzM14CMzMTN</para>
/// </summary>
public record PutSheetsV2SpreadsheetsBySpreadsheetTokenStylesBatchUpdateBodyDto
{
    /// <summary>
    /// <para>请求数据</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("data")]
    public DataItem[] Data { get; set; } = Array.Empty<DataItem>();

    public record DataItem
    {
        /// <summary>
        /// <para>查询范围，包含 sheetId 与单元格范围两部分，目前支持四种索引方式，详见 [在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("ranges")]
        public string[] Ranges { get; set; } = Array.Empty<string>();

        /// <summary>
        /// <para>需要更新的样式</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("style")]
        public StyleSuffix Style { get; set; } = new();

        public record StyleSuffix
        {
            /// <summary>
            /// <para>字体相关样式</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("font")]
            public FontSuffix? Font { get; set; }

            public record FontSuffix
            {
                /// <summary>
                /// <para>是否加粗</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("bold")]
                public bool? Bold { get; set; }

                /// <summary>
                /// <para>是否斜体</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("italic")]
                public bool? Italic { get; set; }

                /// <summary>
                /// <para>字体大小 字号大小为9~36 行距固定为1.5，如:10pt/1.5</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("fontSize")]
                public string? FontSize { get; set; }
            }

            /// <summary>
            /// <para>文本装饰 ，0 默认，1 下划线，2 删除线 ，3 下划线和删除线</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("textDecoration")]
            public int? TextDecoration { get; set; }

            /// <summary>
            /// <para>数字格式，详见附录 [sheet支持数字格式类型](https://open.feishu.cn/document/ukTMukTMukTM/uMjM2UjLzIjN14yMyYTN)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("formatter")]
            public string? Formatter { get; set; }

            /// <summary>
            /// <para>水平对齐，0 左对齐，1 中对齐，2 右对齐</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("hAlign")]
            public int? HAlign { get; set; }

            /// <summary>
            /// <para>垂直对齐， 0 上对齐，1 中对齐， 2 下对齐</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("vAlign")]
            public int? VAlign { get; set; }

            /// <summary>
            /// <para>字体颜色</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("foreColor")]
            public string? ForeColor { get; set; }

            /// <summary>
            /// <para>背景颜色</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("backColor")]
            public string? BackColor { get; set; }

            /// <summary>
            /// <para>边框类型，可选 "FULL_BORDER"，"OUTER_BORDER"，"INNER_BORDER"，"NO_BORDER"，"LEFT_BORDER"，"RIGHT_BORDER"，"TOP_BORDER"，"BOTTOM_BORDER"</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("borderType")]
            public string? BorderType { get; set; }

            /// <summary>
            /// <para>边框颜色</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("borderColor")]
            public string? BorderColor { get; set; }

            /// <summary>
            /// <para>是否清除所有格式,默认 false</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("clean")]
            public bool? Clean { get; set; }
        }
    }
}
