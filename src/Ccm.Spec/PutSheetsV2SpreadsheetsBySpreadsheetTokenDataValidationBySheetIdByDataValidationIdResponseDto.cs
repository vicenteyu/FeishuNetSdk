// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PutSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBySheetIdByDataValidationIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新下拉列表设置 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 更新下拉列表设置 响应体
/// <para>该接口根据 spreadsheetToken 、sheetId、dataValidationId 更新下拉列表的属性。</para>
/// <para>接口ID：6943917246700322818</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/datavalidation/update-datavalidation</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fdatavalidation%2fupdate-datavalidation</para>
/// </summary>
public record PutSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBySheetIdByDataValidationIdResponseDto
{
    /// <summary>
    /// <para>spreadsheet的token</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("spreadsheetToken")]
    public string SpreadsheetToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>工作表 sheet 的 id</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("sheetId")]
    public string SheetId { get; set; } = string.Empty;

    /// <summary></summary>
    [JsonPropertyName("dataValidation")]
    public DataValidationSuffix? DataValidation { get; set; }

    /// <summary></summary>
    public record DataValidationSuffix
    {
        /// <summary>
        /// <para>唯一标示id</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("dataValidationId")]
        public int DataValidationId { get; set; }

        /// <summary>
        /// <para>下拉列表为"list"</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("dataValidationType")]
        public string DataValidationType { get; set; } = string.Empty;

        /// <summary>
        /// <para>下拉列表选项值</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("conditionValues")]
        public string[] ConditionValues { get; set; } = Array.Empty<string>();

        /// <summary>
        /// <para>可选属性</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("options")]
        public Option? Options { get; set; }

        /// <summary></summary>
        public record Option
        {
            /// <summary>
            /// <para>单选填false, 多选填true</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("multipleValues")]
            public bool? MultipleValues { get; set; }

            /// <summary>
            /// <para>是否设置颜色和胶囊样式</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("highlightValidData")]
            public bool? HighlightValidData { get; set; }

            /// <summary>
            /// <para>当highlightValidData为true时，colorValueMap的key与conditionValues中的值一一对应，value为对应的颜色参数。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("colorValueMap")]
            public Dictionary<string, string>? ColorValueMap { get; set; }
        }
    }
}
