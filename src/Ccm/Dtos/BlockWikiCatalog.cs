// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockWikiCatalog.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>Wiki 子目录 Block</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>Wiki 子目录 Block</para>
/// </summary>
public record BlockWikiCatalog
{
    /// <summary>
    /// <para>知识库 token</para>
    /// <para>必填：否</para>
    /// <para>示例值：Ub47wVl7AikG9wkgnpSbFy4EcAc</para>
    /// </summary>
    [JsonPropertyName("wiki_token")]
    public string? WikiToken { get; set; }
}