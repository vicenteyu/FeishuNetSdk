namespace FeishuNetSdk.Ai.Spec;
/// <summary>
/// 识别文本语种 响应体
/// <para>机器翻译 (MT)，支持 100 多种语言识别，返回符合 ISO 639-1 标准。</para>
/// <para>接口ID：6949829039872049153</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/translation-v1/detect</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2ftranslation-v1%2ftext%2fdetect</para>
/// </summary>
public record PostTranslationV1TextDetectResponseDto
{
    /// <summary>
    /// <para>识别的文本语种，返回符合 ISO 639-1 标准</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }
}
