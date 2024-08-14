// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchUpdateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量更新条件格式 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 批量更新条件格式 响应体
/// <para>更新已有的条件格式。支持跨工作表更新多个条件格式。该接口为全量更新接口，若非必填参数不传值，将改变原有配置。</para>
/// <para>使用限制：</para>
/// <para>单次调用该接口，最多支持更新 10 个条件格式。</para>
/// <para>接口ID：6939784115499925532</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/conditionformat/condition-format-update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fconditionformat%2fcondition-format-update</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchUpdateResponseDto
{
    /// <summary>
    /// <para>响应信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("responses")]
    public Response[]? Responses { get; set; }

    /// <summary></summary>
    public record Response
    {
        /// <summary>
        /// <para>工作表的 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sheet_id")]
        public string? SheetId { get; set; }

        /// <summary>
        /// <para>更新的条件格式的 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("cf_id")]
        public string? CfId { get; set; }

        /// <summary>
        /// <para>条件格式更新的状态码。0 表示成功创建，非 0 表示失败。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("res_code")]
        public int? ResCode { get; set; }

        /// <summary>
        /// <para>条件格式更新返回的状态信息，success 表示成功，非 success 将返回失败原因。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("res_msg")]
        public string? ResMsg { get; set; }
    }
}
