// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetDocV2ByDocTokenContentResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取旧版文档富文本内容 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 获取旧版文档富文本内容 响应体
/// <para>此接口只支持获取旧版文档富文本内容。要获取新版文档（文档类型：`docx`）的富文本内容，调用以下接口：</para>
/// <para>- [获取文档所有块](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block/list)</para>
/// <para>- [获取指定块](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block/get)</para>
/// <para>- [获取指定块下所有子块](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block-children/get)</para>
/// <para>接口ID：6908984614439845890</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docs/content/get-document</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDM2YjL1AjN24SNwYjN</para>
/// </summary>
public record GetDocV2ByDocTokenContentResponseDto
{
    /// <summary>
    /// <para>详情参考[文档数据结构](https://open.feishu.cn/document/ukTMukTMukTM/ukDM2YjL5AjN24SOwYjN)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// <para>文档当前版本号</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }
}
