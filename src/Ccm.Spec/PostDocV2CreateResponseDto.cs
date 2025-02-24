// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDocV2CreateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建旧版文档 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 创建旧版文档 响应体
/// <para>此接口已废弃，不允许应用再调用该接口，若继续调用将返回 95054 的错误码。</para>
/// <para>要创建文档，请使用[创建文档](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document/create)接口。</para>
/// <para>接口ID：6908984614439829506</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docs/apiRef/create-document</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugDM2YjL4AjN24COwYjN</para>
/// </summary>
public record PostDocV2CreateResponseDto
{
    /// <summary>
    /// <para>新建文档的token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("objToken")]
    public string? ObjToken { get; set; }

    /// <summary>
    /// <para>新建文档的访问链接</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
