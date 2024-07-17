// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-18
//
// Last Modified By : yxr
// Last Modified On : 2024-07-18
// ************************************************************************
// <copyright file="PostSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>设置下拉列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 设置下拉列表 响应体
/// <para>在电子表格工作表中为指定区域添加下拉列表选项，并设置下拉列表的属性，包括是否支持多选、设置下拉选项样式等。若一个数据区域中已有数据，支持将有效数据直接转为下拉列表中的选项。</para>
/// <para>使用限制：</para>
/// <para>单次调用该接口，最多支持为 5,000 行、100 列设置下拉列表。</para>
/// <para>接口ID：6943917246700290050</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/datavalidation/set-dropdown</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fdatavalidation%2fset-dropdown</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationResponseDto
{
    /// <summary>
    /// <para>状态码，0 代表成功</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("code")]
    public int Code { get; set; }
}
