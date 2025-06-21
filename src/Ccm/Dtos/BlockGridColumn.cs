// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockGridColumn.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>分栏列 Block</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>分栏列 Block</para>
/// </summary>
public record BlockGridColumn
{
    /// <summary>
    /// <para>当前分栏列占整个分栏的比例</para>
    /// <para>必填：否</para>
    /// <para>示例值：50</para>
    /// </summary>
    [JsonPropertyName("width_ratio")]
    public int? WidthRatio { get; set; }
}
