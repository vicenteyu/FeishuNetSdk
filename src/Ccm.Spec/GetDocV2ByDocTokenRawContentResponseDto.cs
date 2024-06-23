// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetDocV2ByDocTokenRawContentResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取旧版文档纯文本内容 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 获取旧版文档纯文本内容 响应体
/// <para>此接口只支持查询旧版文档纯文本内容。要查询新版文档（文档类型：`docx`）的纯文本内容，使用[获取文档纯文本内容](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document/raw_content)接口。</para>
/// <para>接口ID：6907569742384857090</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docs/content/obtain-document-content</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukzNzUjL5czM14SO3MTN</para>
/// </summary>
public record GetDocV2ByDocTokenRawContentResponseDto
{
    /// <summary>
    /// <para>文本内容</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;
}
