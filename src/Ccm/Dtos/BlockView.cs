// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockView.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>视图 Block</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>视图 Block</para>
/// </summary>
public record BlockView
{
    /// <summary>
    /// <para>视图类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：卡片视图</item>
    /// <item>2：预览视图</item>
    /// <item>3：内联视图</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("view_type")]
    public int? ViewType { get; set; }
}
