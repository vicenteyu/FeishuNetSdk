// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostTranslationV1TextDetectBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>识别文本语种 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别文本语种 请求体
/// <para>机器翻译 (MT)，支持 100 多种语言识别，返回符合 ISO 639-1 标准。</para>
/// <para>接口ID：6949829039872049153</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/translation-v1/detect</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2ftranslation-v1%2ftext%2fdetect</para>
/// </summary>
public record PostTranslationV1TextDetectBodyDto
{
    /// <summary>
    /// <para>需要被识别语种的文本</para>
    /// <para>必填：是</para>
    /// <para>示例值：你好</para>
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; } = string.Empty;
}
