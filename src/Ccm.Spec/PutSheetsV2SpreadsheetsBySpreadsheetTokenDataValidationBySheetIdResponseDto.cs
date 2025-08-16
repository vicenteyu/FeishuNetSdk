// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-08-16
// ************************************************************************
// <copyright file="PutSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBySheetIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新下拉列表设置 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 更新下拉列表设置 响应体
/// <para>更新电子表格工作表中单个下拉列表的设置，支持更新下拉列表的选项和属性，包括是否支持多选、下拉选项的样式等。</para>
/// <para>接口ID：6943917246700322818</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/datavalidation/update-datavalidation</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fdatavalidation%2fupdate-datavalidation</para>
/// </summary>
public record PutSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBySheetIdResponseDto
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
    /// <para>下拉列表规则的属性</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("dataValidation")]
    public DataValidationSuffix? DataValidation { get; set; }

    /// <summary></summary>
    public record DataValidationSuffix
    {
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