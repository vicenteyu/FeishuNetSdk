// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSpeechToTextV1SpeechFileRecognizeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>识别语音文件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别语音文件 请求体
/// <para>语音文件识别接口，上传整段语音文件进行一次性识别。接口适合 60 秒以内音频识别。</para>
/// <para>接口ID：6949829039872032769</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/speech_to_text-v1/file_recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fspeech_to_text-v1%2fspeech%2ffile_recognize</para>
/// </summary>
public record PostSpeechToTextV1SpeechFileRecognizeBodyDto
{
    /// <summary>
    /// <para>语音资源</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("speech")]
    public PostSpeechToTextV1SpeechFileRecognizeBodyDtoSpeech Speech { get; set; } = new();

    /// <summary>
    /// <para>语音资源</para>
    /// </summary>
    public record PostSpeechToTextV1SpeechFileRecognizeBodyDtoSpeech
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
    public FileConfig Config { get; set; } = new();

    /// <summary>
    /// <para>配置属性</para>
    /// </summary>
    public record FileConfig
    {
        /// <summary>
        /// <para>仅包含字母数字和下划线的 16 位字符串作为文件的标识，用户生成</para>
        /// <para>必填：是</para>
        /// <para>示例值：qwe12dd34567890w</para>
        /// </summary>
        [JsonPropertyName("file_id")]
        public string FileId { get; set; } = string.Empty;

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
