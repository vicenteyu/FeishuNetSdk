// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量创建条件格式 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 批量创建条件格式 请求体
/// <para>在电子表格工作表的指定区域中，为满足指定条件的单元格和单元格中的数据设置样式。支持跨工作表创建多个条件格式。</para>
/// <para>使用限制：</para>
/// <para>- 单次调用该接口，最多支持创建 10 个条件格式。</para>
/// <para>- 单个工作表中最多支持 20 个条件格式。</para>
/// <para>接口ID：6939784115499892764</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/conditionformat/condition-format-set</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fconditionformat%2fcondition-format-set</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchCreateBodyDto
{
    /// <summary>
    /// <para>要创建的条件格式的信息。最多可创建 10 个条件格式。</para>
    /// <para>**注意**：</para>
    /// <para>响应体中将返回每个条件格式的设置结果，包括成功或具体的失败信息。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("sheet_condition_formats")]
    public SheetConditionFormat[] SheetConditionFormats { get; set; } = Array.Empty<SheetConditionFormat>();

    /// <summary></summary>
    public record SheetConditionFormat
    {
        /// <summary>
        /// <para>电子表格工作表的 ID。调用[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query)获取 ID。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("sheet_id")]
        public string SheetId { get; set; } = string.Empty;

        /// <summary>
        /// <para>条件格式的详细信息</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("condition_format")]
        public ConditionFormatSuffix ConditionFormat { get; set; } = new();

        /// <summary></summary>
        public record ConditionFormatSuffix
        {
            /// <summary>
            /// <para>条件格式应用的范围，支持以下五种写法，了解更多，参考[条件格式指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/conditionformat/condition-format-guide)。</para>
            /// <para>- `sheetId`：填写工作表 ID，表示将条件格式应用于整表</para>
            /// <para>- `sheetId!{开始行索引}:{结束行索引}`：填写工作表 ID 和行数区间，表示将条件格式应用于整行</para>
            /// <para>- `sheetId!{开始列索引}:{结束列索引}`：填写工作表 ID 和列的区间，表示将条件格式应用于整列</para>
            /// <para>- `sheetId!{开始单元格}:{结束单元格}`：填写工作表 ID 和单元格区间，表示将条件格式应用于单元格选定的区域中</para>
            /// <para>- `sheetId!{开始单元格}:{结束列索引}`：填写工作表 ID、起始单元格和结束列，表示省略结束行，使用表格的最后行作为结束行</para>
            /// <para>**注意**：</para>
            /// <para>- 每个范围的区间不可超过表格的行总数和列总数</para>
            /// <para>- 每个范围的 sheetId 的值必须与 `sheet_id` 参数的值一致</para>
            /// <para>**示例值**：["40a7b0!C3:C3"]</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("ranges")]
            public string[] Ranges { get; set; } = Array.Empty<string>();

            /// <summary>
            /// <para>创建条件时的规则类型。可选值：</para>
            /// <para>- containsBlanks：为空</para>
            /// <para>- notContainsBlanks：不为空</para>
            /// <para>- duplicateValues：重复值</para>
            /// <para>- uniqueValues：唯一值</para>
            /// <para>- cellIs：限定值范围</para>
            /// <para>- containsText：包含内容</para>
            /// <para>- timePeriod：日期</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("rule_type")]
            public string RuleType { get; set; } = string.Empty;

            /// <summary>
            /// <para>`rule_type` 参数对应的具体属性信息</para>
            /// <para>**注意**：</para>
            /// <para>当 `rule_type` 为 containsBlanks（为空）、notContainsBlanks（不为空）、duplicateValues（重复值）或 uniqueValues（唯一值）时，无需传入 `attrs` 参数。了解更多，参考[条件格式指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/conditionformat/condition-format-guide)。</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("attrs")]
            public Attr[] Attrs { get; set; } = Array.Empty<Attr>();

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
                /// <para>时间范围。当 `rule_type` 为 `timePeriod` 时，该参数必填，且 `operator` 参数仅支持 `is`。可选值：</para>
                /// <para>- yesterday：昨天</para>
                /// <para>- today：今天</para>
                /// <para>- tomorrow：明天</para>
                /// <para>- last7Days：最近 7 天</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("time_period")]
                public string? TimePeriod { get; set; }

                /// <summary>
                /// <para>公式。当 `rule_type` 为 `cellIs` 时，该参数必填。</para>
                /// <para>**注意**：</para>
                /// <para>- 当 `operator` 为 `between` 或 `notBetween` 时，需要填写两个元素，其他情况下只需填一个元素，值为用户自定义。</para>
                /// <para>- 填写的值若是数字类型，需填写为如 `"1"` 的格式；若是文本类型，需填写为 `"\"aaaaa\""` 格式。即文本需要用 "" 包裹并转义。了解更多示例，请参考[条件格式指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/conditionformat/condition-format-guide)。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("formula")]
                public string[]? Formula { get; set; }

                /// <summary>
                /// <para>文本。当 `rule_type` 为 `containsText` 时，该参数必填。值为用户自定义。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("text")]
                public string? Text { get; set; }
            }

            /// <summary>
            /// <para>条件格式的样式。支持设置字体样式、文本装饰、字体颜色和背景颜色。</para>
            /// <para>**注意**：</para>
            /// <para>`style` 不可设置为 `""`。默认不传该值，即不设置样式。</para>
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
                /// <para>设置字体颜色。需填写字体颜色的十六进制代码。如 #faf1d1。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("fore_color")]
                public string? ForeColor { get; set; }

                /// <summary>
                /// <para>设置背景颜色。需填写背景颜色的十六进制代码。如 #faf1d1。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("back_color")]
                public string? BackColor { get; set; }
            }
        }
    }
}
