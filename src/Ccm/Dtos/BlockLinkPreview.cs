// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockLinkPreview.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>链接预览 Block</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>链接预览 Block</para>
/// </summary>
public record BlockLinkPreview
{
    /// <summary>
    /// <para>链接</para>
    /// <para>必填：是</para>
    /// <para>示例值：https://applink.feishu.cn/client/message/link/open?token=Al7F******Q%3D</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;

    /// <summary>
    /// <para>链接类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：MessageLink</para>
    /// <para>可选值：<list type="bullet">
    /// <item>MessageLink：消息链接</item>
    /// <item>Undefined：未定义的链接类型</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("url_type")]
    public string UrlType { get; set; } = string.Empty;
}