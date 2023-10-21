using Newtonsoft.Json;
namespace FeishuNetSdk.Ai.Spec;
/// <summary>
/// 翻译文本 响应体
/// <para>机器翻译 (MT)，支持以下语种互译：</para>
/// <para>"zh": 汉语；</para>
/// <para>"zh-Hant": 繁体汉语；</para>
/// <para>"en": 英语；</para>
/// <para>"ja": 日语；</para>
/// <para>"ru": 俄语；</para>
/// <para>"de": 德语；</para>
/// <para>"fr": 法语；</para>
/// <para>"it": 意大利语；</para>
/// <para>"pl": 波兰语；</para>
/// <para>"th": 泰语；</para>
/// <para>"hi": 印地语；</para>
/// <para>"id": 印尼语；</para>
/// <para>"es": 西班牙语；</para>
/// <para>"pt": 葡萄牙语；</para>
/// <para>"ko": 朝鲜语；</para>
/// <para>"vi": 越南语；{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=translation&version=v1&resource=text&method=translate)</para>
/// <para>接口ID：6949829039871983617</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/translation-v1/translate</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2ftranslation-v1%2ftext%2ftranslate</para>
/// </summary>
public record PostTranslationV1TextTranslateResponseDto
{
    /// <summary>
    /// <para>翻译后的文本</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("text")]
    public string? Text { get; set; }
}
