// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-08-16
// ************************************************************************
// <copyright file="GetSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询下拉列表设置 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 查询下拉列表设置 响应体
/// <para>查询电子表格工作表中指定范围的下拉列表的设置信息。</para>
/// <para>使用限制：</para>
/// <para>单次查询范围不得超过 5000 行、100列。</para>
/// <para>接口ID：6943917246700306434</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/datavalidation/query-datavalidation</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fdatavalidation%2fquery-datavalidation</para>
/// </summary>
public record GetSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationResponseDto
{
    /// <summary>
    /// <para>电子表格的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("spreadsheetToken")]
    public string? SpreadsheetToken { get; set; }

    /// <summary>
    /// <para>工作表的 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sheetId")]
    public string? SheetId { get; set; }

    /// <summary>
    /// <para>工作表的版本号。从 0 开始计数，更新一次版本号加一。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("revision")]
    public int? Revision { get; set; }

    /// <summary>
    /// <para>下拉列表数组， 不存在时为空</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("dataValidations")]
    public DataValidation[]? DataValidations { get; set; }

    /// <summary></summary>
    public record DataValidation
    {
        /// <summary>
        /// <para>下拉列表所属的范围，按照列进行聚合。</para>
        /// <para>例如 4d30c6 子表中，A1、A2、A4、B1、B2 都是该下拉列表，则该下拉列表对应的 Ranges 为["4d30c6!A1:A2","4d30c6!A4:A4","4d30c6!B1:B2"]</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("ranges")]
        public string[]? Ranges { get; set; }

        /// <summary>
        /// <para>数据验证的类型。下拉列表为 "list"。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("dataValidationType")]
        public string? DataValidationType { get; set; }

        /// <summary>
        /// <para>下拉列表选项的值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("conditionValues")]
        public string[]? ConditionValues { get; set; }

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
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("multipleValues")]
            public bool? MultipleValues { get; set; }

            /// <summary>
            /// <para>是否为下拉选项设置颜色。可选值：</para>
            /// <para>- false：不设置颜色</para>
            /// <para>- true：为下拉选项设置颜色</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("highlightValidData")]
            public bool? HighlightValidData { get; set; }

            /// <summary>
            /// <para>指定的下拉选项的颜色。格式为 RGB 十六进制，如 "#fffd00"。颜色将与 conditionValues 中的值按顺序一一对应。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("colorValueMap")]
            public Dictionary<string, string>? ColorValueMap { get; set; }
        }
    }
}
