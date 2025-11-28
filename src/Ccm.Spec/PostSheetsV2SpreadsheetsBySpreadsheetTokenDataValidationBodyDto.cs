// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>设置下拉列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 设置下拉列表 请求体
/// <para>在电子表格工作表中为指定区域添加下拉列表选项，并设置下拉列表的属性，包括是否支持多选、设置下拉选项样式等。若一个数据区域中已有数据，支持将有效数据直接转为下拉列表中的选项。</para>
/// <para>使用限制：</para>
/// <para>单次调用该接口，最多支持为 5,000 行、100 列设置下拉列表。</para>
/// <para>接口ID：6943917246700290050</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/datavalidation/set-dropdown</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fdatavalidation%2fset-dropdown</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBodyDto
{
    /// <summary>
    /// <para>设置下拉选项的范围。格式为 `&lt;sheetId&gt;!&lt;开始位置&gt;:&lt;结束位置&gt;`。其中：</para>
    /// <para>- `sheetId` 为工作表 ID，通过[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query) 获取。</para>
    /// <para>- `&lt;开始位置&gt;:&lt;结束位置&gt;` 为工作表中单元格的范围，数字表示行索引，字母表示列索引。如 `A2:B2` 表示该工作表第 2 行的 A 列到 B 列。`range`支持四种写法，详情参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>**示例值**："8fe9d6!C1:H14"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("range")]
    public string Range { get; set; } = string.Empty;

    /// <summary>
    /// <para>数据验证的类型。支持下拉列表，请填写 "list"。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("dataValidationType")]
    public string DataValidationType { get; set; } = string.Empty;

    /// <summary>
    /// <para>下拉列表规则属性</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("dataValidation")]
    public DataValidationSuffix DataValidation { get; set; } = new();

    /// <summary></summary>
    public record DataValidationSuffix
    {
        /// <summary>
        /// <para>下拉列表选项的值。</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 单个值需为字符串类型且不能包含 ","</para>
        /// <para>- 单个值的长度不可超过 100 字符</para>
        /// <para>- 选项值的个数不可超过 500 个</para>
        /// <para>**示例值**：["2", "89", "3","2"]</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("conditionValues")]
        public string[] ConditionValues { get; set; } = [];

        /// <summary>
        /// <para>下拉选项其它配置，包括是否支持多选、是否设置下拉选项样式等。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("options")]
        public Option? Options { get; set; }

        /// <summary></summary>
        public record Option
        {
            /// <summary>
            /// <para>是否支持多选选项。可选值：</para>
            /// <para>- false：不支持多选</para>
            /// <para>- true：支持多选</para>
            /// <para>**默认值**：false，即不支持多选选项</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("multipleValues")]
            public bool? MultipleValues { get; set; }

            /// <summary>
            /// <para>是否为下拉选项设置颜色。可选值：</para>
            /// <para>- false：不设置颜色</para>
            /// <para>- true：为下拉选项设置颜色。需进一步配置 colors 参数</para>
            /// <para>**默认值**：false，即不设置颜色</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("highlightValidData")]
            public bool? HighlightValidData { get; set; }

            /// <summary>
            /// <para>指定下拉选项的颜色。格式为 RGB 16 进制，如 "#fffd00"。当 `highlightValidData` 为 true 时，该参数必填。颜色将与 conditionValues 中的值按顺序一一对应。</para>
            /// <para>**示例值**：["#1FB6C1", "#F006C2", "#FB16C3","#FFB6C1"]</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("colors")]
            public string[]? Colors { get; set; }
        }
    }
}
