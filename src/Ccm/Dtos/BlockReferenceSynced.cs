// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockReferenceSynced.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>引用同步块</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>引用同步块</para>
/// </summary>
public record BlockReferenceSynced
{
    /// <summary>
    /// <para>源文档的文档 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：doxcnSS4ouQkQEouGSUkTgabcef</para>
    /// </summary>
    [JsonPropertyName("source_document_id")]
    public string? SourceDocumentId { get; set; }

    /// <summary>
    /// <para>源同步块的 Block ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：doxcnePuYufKa49ISjhD8Iabcef</para>
    /// </summary>
    [JsonPropertyName("source_block_id")]
    public string? SourceBlockId { get; set; }
}