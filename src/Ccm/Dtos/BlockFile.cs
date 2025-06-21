// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockFile.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>文件 Block</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>文件 Block</para>
/// </summary>
public record BlockFile
{
    /// <summary>
    /// <para>附件 Token</para>
    /// <para>必填：否</para>
    /// <para>示例值：boxbcOj88GDkmWGm2zsTyCBqoLb</para>
    /// </summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }

    /// <summary>
    /// <para>文件名</para>
    /// <para>必填：否</para>
    /// <para>示例值：文件名</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>视图类型，卡片视图（默认）或预览视图</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：卡片视图</item>
    /// <item>2：预览视图</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("view_type")]
    public int? ViewType { get; set; }
}