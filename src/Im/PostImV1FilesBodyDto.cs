// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1FilesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传文件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 上传文件 请求体
/// <para>调用该接口将本地文件上传至开放平台，支持上传音频、视频、文档等文件类型。上传后接口会返回文件的 Key，使用该 Key 值可以调用其他 OpenAPI。例如，调用[发送消息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/create)接口，发送文件。</para>
/// <para>## 前提条件</para>
/// <para>应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>## 使用限制</para>
/// <para>文件大小不得超过 30 MB，且不允许上传空文件。</para>
/// <para>接口ID：6946222931479461889</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/file/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2ffile%2fcreate</para>
/// </summary>
public record PostImV1FilesBodyDto
{
    /// <summary>
    /// <para>待上传的文件类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：mp4</para>
    /// <para>可选值：<list type="bullet">
    /// <item>opus：OPUS 音频文件。其他格式的音频文件，请转为 OPUS 格式后上传。可使用 ffmpeg 转换格式：`ffmpeg -i SourceFile.mp3 -acodec libopus -ac 1 -ar 16000 TargetFile.opus`</item>
    /// <item>mp4：MP4 格式视频文件</item>
    /// <item>pdf：PDF 格式文件</item>
    /// <item>doc：DOC 格式文件</item>
    /// <item>xls：XLS 格式文件</item>
    /// <item>ppt：PPT 格式文件</item>
    /// <item>stream：stream 格式文件。若上传文件不属于以上枚举类型，可以使用 stream 格式</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("file_type")]
    public string FileType { get; set; } = string.Empty;

    /// <summary>
    /// <para>带后缀的文件名</para>
    /// <para>必填：是</para>
    /// <para>示例值：测试视频.mp4</para>
    /// </summary>
    [JsonPropertyName("file_name")]
    public string FileName { get; set; } = string.Empty;

    /// <summary>
    /// <para>文件的时长（视频、音频），单位：毫秒。不传值时无法显示文件的具体时长。</para>
    /// <para>必填：否</para>
    /// <para>示例值：3000</para>
    /// </summary>
    [JsonPropertyName("duration")]
    public int? Duration { get; set; }
}
