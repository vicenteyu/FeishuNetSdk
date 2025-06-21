// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockJiraIssue.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>Jira Issue</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>Jira Issue</para>
/// </summary>
public record BlockJiraIssue
{
    /// <summary>
    /// <para>Jira issue ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：12345</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// <para>Jira issue key</para>
    /// <para>必填：否</para>
    /// <para>示例值：Project-123</para>
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}