// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="DeleteSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchDeleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量删除条件格式 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 批量删除条件格式 请求体
/// <para>删除已有的条件格式。支持跨工作表删除多个条件格式。</para>
/// <para>使用限制：单次调用该接口，最多支持删除 10 个条件格式。</para>
/// <para>接口ID：6939784115499859996</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/conditionformat/condition-format-delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fconditionformat%2fcondition-format-delete</para>
/// </summary>
public record DeleteSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchDeleteBodyDto
{
    /// <summary>
    /// <para>要删除的电子表格条件格式的 ID。最多可删除 10 个条件格式。</para>
    /// <para>**注意**：</para>
    /// <para>响应体中将返回每个条件格式的删除结果，包括成功或具体的失败信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sheet_cf_ids")]
    public SheetCfId[]? SheetCfIds { get; set; }

    /// <summary></summary>
    public record SheetCfId
    {
        /// <summary>
        /// <para>电子表格工作表的 ID。调用[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query)获取 ID。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sheet_id")]
        public string? SheetId { get; set; }

        /// <summary>
        /// <para>条件格式的 ID。调用[获取条件格式](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/conditionformat/condition-format-get)获取 ID。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("cf_id")]
        public string? CfId { get; set; }
    }
}
