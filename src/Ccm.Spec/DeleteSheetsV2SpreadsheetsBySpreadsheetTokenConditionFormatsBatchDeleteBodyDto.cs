namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 删除条件格式 请求体
/// <para>该接口用于删除已有的条件格式，单次最多支持删除10个条件格式，每个条件格式的删除会返回成功或者失败，失败的情况包括各种参数的校验。</para>
/// <para>接口ID：6939784115499859996</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/conditionformat/condition-format-delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fconditionformat%2fcondition-format-delete</para>
/// </summary>
public record DeleteSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchDeleteBodyDto
{
    /// <summary>
    /// <para>表格条件格式id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sheet_cf_ids")]
    public SheetCfId[]? SheetCfIds { get; set; }

    /// <summary></summary>
    public record SheetCfId
    {
        /// <summary>
        /// <para>sheet的id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sheet_id")]
        public string? SheetId { get; set; }

        /// <summary>
        /// <para>条件格式id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("cf_id")]
        public string? CfId { get; set; }
    }
}
