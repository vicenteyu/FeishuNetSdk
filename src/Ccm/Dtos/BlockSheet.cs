// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockSheet.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>电子表格 Block</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>电子表格 Block</para>
/// </summary>
public record BlockSheet
{
    /// <summary>
    /// <para>电子表格文档 Token。格式为 {SpreadsheetToken}_{SheetID}，其中 SpreadsheetToken 是一篇电子表格的唯一标识，SheetID 是一张工作表的唯一标识，使用时请注意拆分。</para>
    /// <para>必填：否</para>
    /// <para>示例值：shtbcW6ufcUtRRet7Hz6Iv4ytzg</para>
    /// </summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }

    /// <summary>
    /// <para>电子表格行数量</para>
    /// <para>必填：否</para>
    /// <para>示例值：2</para>
    /// <para>最大值：9</para>
    /// <para>最小值：1</para>
    /// </summary>
    [JsonPropertyName("row_size")]
    public int? RowSize { get; set; }

    /// <summary>
    /// <para>电子表格列数量</para>
    /// <para>必填：否</para>
    /// <para>示例值：2</para>
    /// <para>最大值：9</para>
    /// <para>最小值：1</para>
    /// </summary>
    [JsonPropertyName("column_size")]
    public int? ColumnSize { get; set; }
}
