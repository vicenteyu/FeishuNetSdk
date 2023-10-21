using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 更新条件格式 请求体
/// <para>该接口用于更新已有的条件格式，单次最多支持更新10个条件格式，每个条件格式的更新会返回成功或者失败，失败的情况包括各种参数的校验。</para>
/// <para>接口ID：6939784115499925532</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/conditionformat/condition-format-update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fconditionformat%2fcondition-format-update</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchUpdateBodyDto
{
    /// <summary>
    /// <para>表格的条件格式信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("sheet_condition_formats")]
    public SheetConditionFormat[] SheetConditionFormats { get; set; } = Array.Empty<SheetConditionFormat>();

    public record SheetConditionFormat
    {
        /// <summary>
        /// <para>sheet的id</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("sheet_id")]
        public string SheetId { get; set; } = string.Empty;

        /// <summary>
        /// <para>一个条件格式的详细信息</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("condition_format")]
        public ConditionFormatSuffix ConditionFormat { get; set; } = new();

        public record ConditionFormatSuffix
        {
            /// <summary>
            /// <para>需要更新的条件格式id，会校验id是否存在</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonProperty("cf_id")]
            public string CfId { get; set; } = string.Empty;

            /// <summary>
            /// <para>条件格式应用的范围，支持：sheetId（整表）；sheetId!1:2（整行）；sheetId!A:B（整列）；sheetId!A1:B2（普通范围）；sheetId!A1:C（应用至最后一行）。应用范围不能超过表格的行总数和列总数，sheetId要与参数的sheetId一致</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonProperty("ranges")]
            public string[] Ranges { get; set; } = Array.Empty<string>();

            /// <summary>
            /// <para>条件格式规则类型，目前只有7种：***containsBlanks（为空）、notContainsBlanks（不为空）、duplicateValues（重复值）、uniqueValues（唯一值）、cellIs（限定值范围）、containsText（包含内容）、timePeriod（日期）***</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonProperty("rule_type")]
            public string RuleType { get; set; } = string.Empty;

            /// <summary>
            /// <para>rule_type对应的具体属性信息，详见 [条件格式指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/conditionformat/condition-format-guide)</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonProperty("attrs")]
            public Attr[] Attrs { get; set; } = Array.Empty<Attr>();

            public record Attr
            {
                /// <summary>
                /// <para>操作方法</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("operator")]
                public string? Operator { get; set; }

                /// <summary>
                /// <para>时间范围</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("time_period")]
                public string? TimePeriod { get; set; }

                /// <summary>
                /// <para>格式</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("formula")]
                public string[]? Formula { get; set; }

                /// <summary>
                /// <para>文本</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("text")]
                public string? Text { get; set; }
            }

            /// <summary>
            /// <para>条件格式样式，只支持以下样式，以下样式每个参数都可选，但是不能设置空的style</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("style")]
            public StyleSuffix? Style { get; set; }

            public record StyleSuffix
            {
                /// <summary>
                /// <para>字体样式</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("font")]
                public FontSuffix? Font { get; set; }

                public record FontSuffix
                {
                    /// <summary>
                    /// <para>加粗</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("bold")]
                    public bool? Bold { get; set; }

                    /// <summary>
                    /// <para>斜体</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("italic")]
                    public bool? Italic { get; set; }
                }

                /// <summary>
                /// <para>文本装饰 ，0 默认，1 下划线，2 删除线 ，3 下划线和删除线</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("text_decoration")]
                public int? TextDecoration { get; set; }

                /// <summary>
                /// <para>字体颜色</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("fore_color")]
                public string? ForeColor { get; set; }

                /// <summary>
                /// <para>背景颜色</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("back_color")]
                public string? BackColor { get; set; }
            }
        }
    }
}
