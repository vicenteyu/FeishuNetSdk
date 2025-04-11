// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDocumentAiV1HealthCertificateRecognizeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>识别文件中的健康证 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别文件中的健康证 响应体
/// <para>健康证识别接口，支持JPG/JPEG/PNG/BMP四种文件类型的一次性的识别。文件大小需要小于10M。</para>
/// <para>接口ID：7319756481343766532</para>
/// <para>文档地址：https://open.feishu.cn/document/ai/document_ai-v1/health_certificate/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fhealth_certificate%2frecognize</para>
/// </summary>
public record PostDocumentAiV1HealthCertificateRecognizeResponseDto
{
    /// <summary>
    /// <para>健康证信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("health_certificate")]
    public PostDocumentAiV1HealthCertificateRecognizeResponseDtoHealthCertificate? HealthCertificate { get; set; }

    /// <summary>
    /// <para>健康证信息</para>
    /// </summary>
    public record PostDocumentAiV1HealthCertificateRecognizeResponseDtoHealthCertificate
    {
        /// <summary>
        /// <para>识别出的实体类型</para>
        /// <para>必填：否</para>
        /// <para>最大长度：22</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("entities")]
        public HealthCertificateEntity[]? Entities { get; set; }

        /// <summary>
        /// <para>识别出的实体类型</para>
        /// </summary>
        public record HealthCertificateEntity
        {
            /// <summary>
            /// <para>识别的字段种类</para>
            /// <para>必填：否</para>
            /// <para>示例值：id_number</para>
            /// <para>可选值：<list type="bullet">
            /// <item>name：姓名</item>
            /// <item>issued_by：发证机关</item>
            /// <item>date_of_handling：办证日期</item>
            /// <item>date_of_issue：发证日期</item>
            /// <item>date_of_medical_examination：体检日期</item>
            /// <item>valid_date：有效日期</item>
            /// <item>other_date：其他日期</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>识别出字段的文本信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }
    }
}
