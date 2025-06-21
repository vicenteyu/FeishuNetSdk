// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockTask.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>任务 Block</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>任务 Block</para>
/// </summary>
public record BlockTask
{
    /// <summary>
    /// <para>任务 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：ba5040f4-8116-4042-ab3c-254e5cfe3ce7</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }

    /// <summary>
    /// <para>折叠状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("folded")]
    public bool? Folded { get; set; }
}
