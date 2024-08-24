// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1FilesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传文件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 上传文件 响应体
/// <para>调用该接口将本地文件上传至开放平台，支持上传音频、视频、文档等文件类型。上传后接口会返回文件的 Key，使用该 Key 值可以调用其他 OpenAPI。例如，调用[发送消息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/create)接口，发送文件。</para>
/// <para>## 前提条件</para>
/// <para>应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>## 使用限制</para>
/// <para>文件大小不得超过 30 MB，且不允许上传空文件。</para>
/// <para>接口ID：6946222931479461889</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/file/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2ffile%2fcreate</para>
/// </summary>
public record PostImV1FilesResponseDto
{
    /// <summary>
    /// <para>文件的 Key</para>
    /// <para>必填：否</para>
    /// <para>示例值：file_456a92d6-c6ea-4de4-ac3f-7afcf44ac78g</para>
    /// </summary>
    [JsonPropertyName("file_key")]
    public string? FileKey { get; set; }
}
