// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-08-14
// ************************************************************************
// <copyright file="GetSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取条件格式 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 批量获取条件格式 响应体
/// <para>根据工作表 ID 获取详细的条件格式信息，最多支持同时查询 10 个工作表的条件格式。</para>
/// <para>接口ID：6939784115499909148</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/conditionformat/condition-format-get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fconditionformat%2fcondition-format-get</para>
/// </summary>
public record GetSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsResponseDto
{
    /// <summary>
    /// <para>表格的条件格式信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sheet_condition_formats")]
    public SheetConditionFormat[]? SheetConditionFormats { get; set; }

    /// <summary></summary>
    public record SheetConditionFormat
    {
        /// <summary>
        /// <para>电子表格工作表的 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sheet_id")]
        public string? SheetId { get; set; }

        /// <summary>
        /// <para>条件格式的详细信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("condition_format")]
        public ConditionFormatSuffix? ConditionFormat { get; set; }

        /// <summary></summary>
        public record ConditionFormatSuffix
        {
            /// <summary>
            /// <para>条件格式的 ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("cf_id")]
            public string? CfId { get; set; }

            /// <summary>
            /// <para>条件格式应用的范围，支持以下枚举值，了解更多，参考[条件格式指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/conditionformat/condition-format-guide)。</para>
            /// <para>- `sheetId`：填写工作表 ID，表示将条件格式应用于整表</para>
            /// <para>- `sheetId!{开始行索引}:{结束行索引}`：填写工作表 ID 和行数区间，表示将条件格式应用于整行</para>
            /// <para>- `sheetId!{开始列索引}:{结束列索引}`：填写工作表 ID 和列的区间，表示将条件格式应用于整列</para>
            /// <para>- `sheetId!{开始单元格}:{结束单元格}`：填写工作表 ID 和单元格区间，表示将条件格式应用于单元格选定的区域中</para>
            /// <para>- `sheetId!{开始单元格}:{结束列索引}`：填写工作表 ID、起始单元格和结束列，表示省略结束行，使用表格的最后行作为结束行</para>
            /// <para>**示例值**：["40a7b0!C3:C3"]</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("ranges")]
            public string[]? Ranges { get; set; }

            /// <summary>
            /// <para>创建条件时的规则类型。枚举值：</para>
            /// <para>- containsBlanks：为空</para>
            /// <para>- notContainsBlanks：不为空</para>
            /// <para>- duplicateValues：重复值</para>
            /// <para>- uniqueValues：唯一值</para>
            /// <para>- cellIs：限定值范围</para>
            /// <para>- containsText：包含内容</para>
            /// <para>- timePeriod：日期</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("rule_type")]
            public string? RuleType { get; set; }

            /// <summary>
            /// <para>`rule_type` 参数对应的具体属性信息。了解更多，参考[条件格式指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/conditionformat/condition-format-guide)。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("attrs")]
            public Attr[]? Attrs { get; set; }

            /// <summary></summary>
            public record Attr
            {
                /// <summary>
                /// <para>操作方法。了解更多，参考[条件格式指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/conditionformat/condition-format-guide)。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("operator")]
                public string? Operator { get; set; }

                /// <summary>
                /// <para>时间范围。当 `rule_type` 为 `timePeriod` 时，返回该参数，且 `operator` 参数仅支持 `is`。枚举值：</para>
                /// <para>- yesterday：昨天</para>
                /// <para>- today：今天</para>
                /// <para>- tomorrow：明天</para>
                /// <para>- last7Days：最近 7 天</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("time_period")]
                public string? TimePeriod { get; set; }

                /// <summary>
                /// <para>公式。当 `rule_type` 为 `cellIs` 时，返回该参数。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("formula")]
                public string[]? Formula { get; set; }

                /// <summary>
                /// <para>文本。当 `rule_type` 为 `containsText` 时，返回该参数。值为用户自定义。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("text")]
                public string? Text { get; set; }
            }

            /// <summary>
            /// <para>条件格式的样式。支持设置字体样式、文本装饰、字体颜色和背景颜色。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("style")]
            public StyleSuffix? Style { get; set; }

            /// <summary></summary>
            public record StyleSuffix
            {
                /// <summary>
                /// <para>符合条件的数据的字体样式</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("font")]
                public FontSuffix? Font { get; set; }

                /// <summary></summary>
                public record FontSuffix
                {
                    /// <summary>
                    /// <para>字体是否加粗</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("bold")]
                    public bool? Bold { get; set; }

                    /// <summary>
                    /// <para>字体是否为斜体</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("italic")]
                    public bool? Italic { get; set; }
                }

                /// <summary>
                /// <para>文本装饰。为文本设置下划线或删除线。可选值：</para>
                /// <para>- 0：无下划线和删除线</para>
                /// <para>- 1：下划线</para>
                /// <para>- 2：删除线</para>
                /// <para>- 3：同时设置下划线和删除线</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("text_decoration")]
                public int? TextDecoration { get; set; }

                /// <summary>
                /// <para>字体颜色的十六进制代码。如 #faf1d1。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("fore_color")]
                public string? ForeColor { get; set; }

                /// <summary>
                /// <para>背景颜色的十六进制代码。如 #faf1d1。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("back_color")]
                public string? BackColor { get; set; }
            }
        }
    }
}
