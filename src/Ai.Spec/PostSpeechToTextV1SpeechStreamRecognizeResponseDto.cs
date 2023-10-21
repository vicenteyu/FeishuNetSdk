using Newtonsoft.Json;
namespace FeishuNetSdk.Ai.Spec;
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
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("stream_id")]
    public string? StreamId { get; set; }

    /// <summary>
    /// <para>数据流分片的序号，序号从 0 开始，每次请求递增 1</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("sequence_id")]
    public int? SequenceId { get; set; }

    /// <summary>
    /// <para>语音流识别后的文本信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("recognition_text")]
    public string? RecognitionText { get; set; }
}
