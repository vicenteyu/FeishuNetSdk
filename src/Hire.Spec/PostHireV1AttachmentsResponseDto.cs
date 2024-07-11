// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-01
// ************************************************************************
// <copyright file="PostHireV1AttachmentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建附件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire.Spec;
/// <summary>
/// 创建附件 响应体
/// <para>在招聘系统中上传附件文件，上传的附件为通用附件。</para>
/// <para>接口ID：6921988678870040577</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/attachment/create_attachment</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDN1YjLyQTN24iM0UjN%2fcreate_attachment</para>
/// </summary>
public record PostHireV1AttachmentsResponseDto
{
    /// <summary>
    /// <para>附件文件 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// <para>上传文件的文件名</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>上传文件的 URL，有效期为 30 分钟</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
