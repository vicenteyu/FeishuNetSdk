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
/// 获取附件 PDF 格式下载链接 响应体
/// <para>根据人才简历附件 ID 获取该简历附件对应的 PDF 文件的下载地址。</para>
/// <para>## 注意事项</para>
/// <para>- 本接口仅支持转换人才简历类型的附件，不支持作品附件和通用附件。</para>
/// <para>- 飞书招聘系统支持将文件后缀名为 `.doc`、`.docx`、`.ppt`、`.pptx` 和 `.txt`的人才简历附件转换为 PDF 格式。若转换 PDF 失败，该接口会返回附件原文件的下载地址。</para>
/// <para>接口ID：6964631863168647171</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/attachment/preview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fattachment%2fpreview</para>
/// </summary>
public record GetHireV1AttachmentsByAttachmentIdPreviewResponseDto
{
    /// <summary>
    /// <para>PDF 文件下载链接，有效期为 30 分钟</para>
    /// <para>必填：是</para>
    /// <para>示例值：https://xxx.feishu.cn/hire/file/blob/ZXlKaGJHY2lPaUpJVXpJMU5pS3==/</para>
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;
}
