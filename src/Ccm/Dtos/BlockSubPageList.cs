// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockSubPageList.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新版 Wiki 子目录 Block</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>新版 Wiki 子目录 Block</para>
/// </summary>
public record BlockSubPageList
{
    /// <summary>
    /// <para>知识库节点 token，仅支持知识库文档创建子页面列表，且需传入当前页面的 wiki token</para>
    /// <para>必填：是</para>
    /// <para>示例值：Ub47wVI7AikG9wkgnpSbFyabcef</para>
    /// <para>最大长度：27</para>
    /// <para>最小长度：27</para>
    /// </summary>
    [JsonPropertyName("wiki_token")]
    public string WikiToken { get; set; } = string.Empty;
}