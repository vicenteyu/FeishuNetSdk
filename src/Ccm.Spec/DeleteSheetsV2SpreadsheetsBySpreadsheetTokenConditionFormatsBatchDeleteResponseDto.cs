// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="DeleteSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchDeleteResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量删除条件格式 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 批量删除条件格式 响应体
/// <para>删除已有的条件格式。支持跨工作表删除多个条件格式。</para>
/// <para>使用限制：单次调用该接口，最多支持删除 10 个条件格式。</para>
/// <para>接口ID：6939784115499859996</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/conditionformat/condition-format-delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fconditionformat%2fcondition-format-delete</para>
/// </summary>
public record DeleteSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchDeleteResponseDto
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
        /// <para>删除的条件格式的 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("cf_id")]
        public string? CfId { get; set; }

        /// <summary>
        /// <para>条件格式删除的状态码。0 表示成功创建，非 0 表示失败。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("res_code")]
        public int? ResCode { get; set; }

        /// <summary>
        /// <para>删除当前条件格式返回的状态信息，success 表示成功，非 success 将返回失败原因。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("res_msg")]
        public string? ResMsg { get; set; }
    }
}
