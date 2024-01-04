namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别流式语音 请求体
/// <para>语音流式接口，将整个音频文件分片进行传入模型。能够实时返回数据。建议每个音频分片的大小为 100-200ms。</para>
/// <para>接口ID：6949829039872016385</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/speech_to_text-v1/stream_recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fspeech_to_text-v1%2fspeech%2fstream_recognize</para>
/// </summary>
public record PostSpeechToTextV1SpeechStreamRecognizeBodyDto
{
    /// <summary>
    /// <para>语音资源</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("speech")]
    public PostSpeechToTextV1SpeechStreamRecognizeBodyDtoSpeech Speech { get; set; } = new();

    /// <summary>
    /// <para>语音资源</para>
    /// </summary>
    public record PostSpeechToTextV1SpeechStreamRecognizeBodyDtoSpeech
    {
        /// <summary>
        /// <para>pcm格式音频文件（文件识别）或音频分片（流式识别）经base64编码后的内容</para>
        /// <para>必填：否</para>
        /// <para>示例值：PdmrfE267Cd/Z9KpmNFh71A2PSJZxSp7+8upCg==</para>
        /// </summary>
        [JsonPropertyName("speech")]
        public string? Speech { get; set; }
    }

    /// <summary>
    /// <para>配置属性</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("config")]
    public StreamConfig Config { get; set; } = new();

    /// <summary>
    /// <para>配置属性</para>
    /// </summary>
    public record StreamConfig
    {
        /// <summary>
        /// <para>仅包含字母数字和下划线的 16 位字符串作为同一数据流的标识，用户生成</para>
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
        /// <para>数据流标记：1 首包，2 正常结束，等待结果返回，3 中断数据流不返回最终结果</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("action")]
        public int Action { get; set; }

        /// <summary>
        /// <para>语音格式，目前仅支持：pcm</para>
        /// <para>必填：是</para>
        /// <para>示例值：pcm</para>
        /// </summary>
        [JsonPropertyName("format")]
        public string Format { get; set; } = string.Empty;

        /// <summary>
        /// <para>引擎类型，目前仅支持：16k_auto 中英混合</para>
        /// <para>必填：是</para>
        /// <para>示例值：16k_auto</para>
        /// </summary>
        [JsonPropertyName("engine_type")]
        public string EngineType { get; set; } = string.Empty;
    }
}
