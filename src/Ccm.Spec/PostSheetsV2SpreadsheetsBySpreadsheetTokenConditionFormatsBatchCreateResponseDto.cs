// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchCreateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建条件格式 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 创建条件格式 响应体
/// <para>该接口用于创建新的条件格式，单次最多支持增加10个条件格式，每个条件格式的设置会返回成功或者失败，失败的情况包括各种参数的校验。</para>
/// <para>接口ID：6939784115499892764</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/conditionformat/condition-format-set</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fconditionformat%2fcondition-format-set</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchCreateResponseDto
{
    /// <summary>
    /// <para>响应</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("responses")]
    public Response[]? Responses { get; set; }

    /// <summary></summary>
    public record Response
    {
        /// <summary>
        /// <para>sheet的Id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sheet_id")]
        public string? SheetId { get; set; }

        /// <summary>
        /// <para>设置成功的条件格式id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("cf_id")]
        public string? CfId { get; set; }

        /// <summary>
        /// <para>条件格式设置状态码，0表示成功，非0表示失败</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("res_code")]
        public int? ResCode { get; set; }

        /// <summary>
        /// <para>条件格式设置返回的状态信息，空表示成功，非空表示失败原因</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("res_msg")]
        public string? ResMsg { get; set; }
    }
}
