// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>增加行列 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 增加行列 响应体
/// <para>该接口用于在电子表格中增加空白行或列。</para>
/// <para>接口ID：6907569744333864961</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/sheet-rowcol/add-rows-or-columns</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUjMzUjL1IzM14SNyMTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeResponseDto
{
    /// <summary>
    /// <para>增加的行数或列数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("addCount")]
    public int? AddCount { get; set; }

    /// <summary>
    /// <para>增加的表格维度。枚举值：</para>
    /// <para>- `ROWS`：行</para>
    /// <para>- `COLUMNS`：列</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("majorDimension")]
    public string? MajorDimension { get; set; }
}
