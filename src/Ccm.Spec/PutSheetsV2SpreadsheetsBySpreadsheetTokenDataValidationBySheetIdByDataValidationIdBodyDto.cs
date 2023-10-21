using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 更新下拉列表设置 请求体
/// <para>该接口根据 spreadsheetToken 、sheetId、dataValidationId 更新下拉列表的属性。</para>
/// <para>接口ID：6943917246700322818</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/datavalidation/update-datavalidation</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fdatavalidation%2fupdate-datavalidation</para>
/// </summary>
public record PutSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBySheetIdByDataValidationIdBodyDto
{
    /// <summary>
    /// <para>下拉列表填"list"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("dataValidationType")]
    public string DataValidationType { get; set; } = string.Empty;

    /// <summary>
    /// <para>下拉列表规则属性</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("dataValidation")]
    public DataValidationSuffix? DataValidation { get; set; }

    public record DataValidationSuffix
    {
        /// <summary>
        /// <para>下拉列表选项值, 需为字符串,不能包含","，选项值最长100字符,选项个数最多500个</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("conditionValues")]
        public string[] ConditionValues { get; set; } = Array.Empty<string>();

        /// <summary>
        /// <para>可选属性</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("options")]
        public Option? Options { get; set; }

        public record Option
        {
            /// <summary>
            /// <para>单选填false, 多选填true，不填默认为false</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("multipleValues")]
            public bool? MultipleValues { get; set; }

            /// <summary>
            /// <para>是否设置颜色和胶囊样式, 不填默认为false</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("highlightValidData")]
            public bool? HighlightValidData { get; set; }

            /// <summary>
            /// <para>当highlightValidData为true时，color需填颜色,与conditionValues中的值一一对应。需是RGB16进制格式,如"#fffd00"</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("colors")]
            public string[]? Colors { get; set; }
        }
    }
}
