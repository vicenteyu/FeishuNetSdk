// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetDocxV1DocumentsByDocumentIdRawContentResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取文档纯文本内容 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取文档纯文本内容 响应体
/// <para>获取文档的纯文本内容。</para>
/// <para>## 前提条件</para>
/// <para>调用此接口前，请确保当前调用身份（tenant_access_token 或 user_access_token）已有云文档的阅读、编辑等文档权限，否则接口将返回 HTTP 403 或 400 状态码。了解更多，参考[如何为应用或用户开通文档权限](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#16c6475a)。</para>
/// <para>接口ID：7079983676051013634</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document/raw_content</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument%2fraw_content</para>
/// </summary>
public record GetDocxV1DocumentsByDocumentIdRawContentResponseDto
{
    /// <summary>
    /// <para>文档纯文本</para>
    /// <para>必填：否</para>
    /// <para>示例值：云文档\n多人实时协同，插入一切元素。不仅是在线文档，更是强大的创作和互动工具\n云文档：专为协作而生\n</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }
}
