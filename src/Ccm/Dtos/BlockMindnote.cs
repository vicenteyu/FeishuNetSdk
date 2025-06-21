// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockMindnote.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>思维笔记 Block</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>思维笔记 Block</para>
/// </summary>
public record BlockMindnote
{
    /// <summary>
    /// <para>思维导图 token</para>
    /// <para>必填：否</para>
    /// <para>示例值：bmnbcXXGPWfJMwDfGCbCiU14c6f</para>
    /// </summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }
}
