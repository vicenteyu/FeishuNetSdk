// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockBitable.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>多维表格 Block</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>多维表格 Block</para>
/// </summary>
public record BlockBitable
{
    /// <summary>
    /// <para>多维表格文档 Token。格式为 {BitableToken}_{TableID}，其中 BitableToken 是一篇多维表格的唯一标识，TableID 是一张数据表的唯一标识，使用时请注意拆分。</para>
    /// <para>必填：否</para>
    /// <para>示例值：basbcqH9FfRn3sWCCBOtdNVpCsb_tblSAh8fEwhuMXQg</para>
    /// </summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }

    /// <summary>
    /// <para>类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：数据表</item>
    /// <item>2：看板</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("view_type")]
    public int? ViewType { get; set; }
}

