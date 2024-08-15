// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostOpticalCharRecognitionV1ImageBasicRecognizeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>识别图片中的文字 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别图片中的文字 请求体
/// <para>可识别图片中的文字，按图片中的区域划分，分段返回文本列表。</para>
/// <para>## 注意事项</para>
/// <para>- 单租户限流为 20QPS，即同租户下的应用共享本租户的 20 QPS 限流。</para>
/// <para>- 该接口不支持通过飞书个人版调试。</para>
/// <para>接口ID：6949829039872000001</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/optical_char_recognition-v1/basic_recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2foptical_char_recognition-v1%2fimage%2fbasic_recognize</para>
/// </summary>
public record PostOpticalCharRecognitionV1ImageBasicRecognizeBodyDto
{
    /// <summary>
    /// <para>base64 后的图片数据</para>
    /// <para>必填：否</para>
    /// <para>示例值：base64后的图片二进制数据</para>
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }
}
