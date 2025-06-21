// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockGrid.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>分栏 Block</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>分栏 Block</para>
/// </summary>
public record BlockGrid
{
    /// <summary>
    /// <para>分栏列数量</para>
    /// <para>必填：是</para>
    /// <para>示例值：2</para>
    /// <para>最大值：5</para>
    /// <para>最小值：2</para>
    /// </summary>
    [JsonPropertyName("column_size")]
    public int ColumnSize { get; set; }
}