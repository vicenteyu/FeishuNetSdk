// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除下拉列表设置 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 删除下拉列表设置 响应体
/// <para>删除电子表格工作表指定范围中下拉列表的设置，但仍保留选项文本。</para>
/// <para>使用限制：单次删除请求可指定多个范围，单个范围指定的单元格不可超过 5,000 个，范围的总数不可超过 100 个。</para>
/// <para>接口ID：6943917246700257282</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/datavalidation/delete-datavalidation</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fdatavalidation%2fdelete-datavalidation</para>
/// </summary>
public record DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationResponseDto
{
    /// <summary>
    /// <para>删除下拉列表设置的结果</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("rangeResults")]
    public RangeResult[]? RangeResults { get; set; }

    /// <summary></summary>
    public record RangeResult
    {
        /// <summary>
        /// <para>要删除的范围，与请求参数中 range 的值对应。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("range")]
        public string? Range { get; set; }

        /// <summary>
        /// <para>结果信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("msg")]
        public string? Msg { get; set; }

        /// <summary>
        /// <para>是否成功删除该范围中的下拉列表设置。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>影响的单元格总数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("updatedCells")]
        public int? UpdatedCells { get; set; }
    }
}
