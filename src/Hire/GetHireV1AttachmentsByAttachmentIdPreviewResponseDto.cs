// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetHireV1AttachmentsByAttachmentIdPreviewResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取附件预览信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取附件预览信息 响应体
/// <para>根据附件 ID 获取附件预览信息。</para>
/// <para>接口ID：6964631863168647171</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/attachment/preview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fattachment%2fpreview</para>
/// </summary>
public record GetHireV1AttachmentsByAttachmentIdPreviewResponseDto
{
    /// <summary>
    /// <para>预览链接，有效期为 30 分钟</para>
    /// <para>必填：是</para>
    /// <para>示例值：https://xxx.feishu.cn/hire/file/blob/ZXlKaGJHY2lPaUpJVXpJMU5pS3==/</para>
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;
}
