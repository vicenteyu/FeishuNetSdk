// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除行列 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 删除行列 响应体
/// <para>该接口用于删除电子表格中的指定行或列。</para>
/// <para>接口ID：6907569524100382721</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/sheet-rowcol/-delete-rows-or-columns</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fucjMzUjL3IzM14yNyMTN</para>
/// </summary>
public record DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeResponseDto
{
    /// <summary>
    /// <para>一共删除的行数或列数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("delCount")]
    public int? DelCount { get; set; }

    /// <summary>
    /// <para>删除的维度。枚举值：</para>
    /// <para>- `ROWS`：行</para>
    /// <para>- `COLUMNS`：列</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("majorDimension")]
    public string? MajorDimension { get; set; }
}
