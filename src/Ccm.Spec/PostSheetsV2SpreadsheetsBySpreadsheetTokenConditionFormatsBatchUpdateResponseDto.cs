using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 更新条件格式 响应体
/// <para>该接口用于更新已有的条件格式，单次最多支持更新10个条件格式，每个条件格式的更新会返回成功或者失败，失败的情况包括各种参数的校验。</para>
/// <para>接口ID：6939784115499925532</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/conditionformat/condition-format-update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fconditionformat%2fcondition-format-update</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchUpdateResponseDto
{
    /// <summary>
    /// <para>响应</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("responses")]
    public Response[]? Responses { get; set; }

    /// <summary></summary>
    public record Response
    {
        /// <summary>
        /// <para>sheet的Id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("sheet_id")]
        public string? SheetId { get; set; }

        /// <summary>
        /// <para>更新的条件格式id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("cf_id")]
        public string? CfId { get; set; }

        /// <summary>
        /// <para>条件格式更新状态码，0表示成功，非0表示失败</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("res_code")]
        public int? ResCode { get; set; }

        /// <summary>
        /// <para>条件格式更新返回的状态信息，空表示成功，不空表示失败原因</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("res_msg")]
        public string? ResMsg { get; set; }
    }
}
