// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSpeechToTextV1SpeechFileRecognizeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>识别语音文件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别语音文件 响应体
/// <para>语音文件识别接口，上传整段语音文件进行一次性识别。接口适合 60 秒以内音频识别。</para>
/// <para>接口ID：6949829039872032769</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/speech_to_text-v1/file_recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fspeech_to_text-v1%2fspeech%2ffile_recognize</para>
/// </summary>
public record PostSpeechToTextV1SpeechFileRecognizeResponseDto
{
    /// <summary>
    /// <para>语音识别后的文本信息</para>
    /// <para>必填：是</para>
    /// <para>示例值：你好，使用飞书吧</para>
    /// </summary>
    [JsonPropertyName("recognition_text")]
    public string RecognitionText { get; set; } = string.Empty;
}
