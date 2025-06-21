// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockChatCard.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>群聊卡片 Block</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>群聊卡片 Block</para>
/// </summary>
public record BlockChatCard
{
    /// <summary>
    /// <para>群聊天会话 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：oc_2e2ef17a54207c68efdf998554ef27e3</para>
    /// </summary>
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; } = string.Empty;

    /// <summary>
    /// <para>对齐方式</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：居左排版</item>
    /// <item>2：居中排版</item>
    /// <item>3：居右排版</item>
    /// </list></para>
    /// <para>默认值：1</para>
    /// </summary>
    [JsonPropertyName("align")]
    public int? Align { get; set; }
}
