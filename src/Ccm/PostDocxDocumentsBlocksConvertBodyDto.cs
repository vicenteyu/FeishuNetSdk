// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-21
//
// Last Modified By : yxr
// Last Modified On : 2025-06-21
// ************************************************************************
// <copyright file="PostDocxDocumentsBlocksConvertBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>转换为文档块 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// Markdown/HTML 内容转换为文档块 请求体
/// <para>将 HTML/Markdown 格式的内容转换为文档块</para>
/// <para>接口ID：7514526156452954140</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document/convert</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument%2fconvert</para>
/// </summary>
public record PostDocxDocumentsBlocksConvertBodyDto
{
    /// <summary>
    /// <para>内容类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：markdown</para>
    /// <para>可选值：<list type="bullet">
    /// <item>markdown：Markdown 格式</item>
    /// <item>html：HTML 格式</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("content_type")]
    public string ContentType { get; set; } = string.Empty;

    /// <summary>
    /// <para>文本内容</para>
    /// <para>必填：是</para>
    /// <para>示例值：**第一段为加粗文本**\n\n```\n第二段为代码块\n```</para>
    /// <para>最大长度：10485760</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;
}
