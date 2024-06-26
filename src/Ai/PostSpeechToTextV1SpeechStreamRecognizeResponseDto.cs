// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSpeechToTextV1SpeechStreamRecognizeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>识别流式语音 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别流式语音 响应体
/// <para>语音流式接口，将整个音频文件分片进行传入模型。能够实时返回数据。建议每个音频分片的大小为 100-200ms。</para>
/// <para>接口ID：6949829039872016385</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/speech_to_text-v1/stream_recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fspeech_to_text-v1%2fspeech%2fstream_recognize</para>
/// </summary>
public record PostSpeechToTextV1SpeechStreamRecognizeResponseDto
{
    /// <summary>
    /// <para>16 位 String 随机串作为同一数据流的标识</para>
    /// <para>必填：是</para>
    /// <para>示例值：asd1234567890ddd</para>
    /// </summary>
    [JsonPropertyName("stream_id")]
    public string StreamId { get; set; } = string.Empty;

    /// <summary>
    /// <para>数据流分片的序号，序号从 0 开始，每次请求递增 1</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("sequence_id")]
    public int SequenceId { get; set; }

    /// <summary>
    /// <para>语音流识别后的文本信息</para>
    /// <para>必填：是</para>
    /// <para>示例值：你好，尝试使用一下飞书吧</para>
    /// </summary>
    [JsonPropertyName("recognition_text")]
    public string RecognitionText { get; set; } = string.Empty;
}
