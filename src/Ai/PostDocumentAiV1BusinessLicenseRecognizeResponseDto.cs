// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDocumentAiV1BusinessLicenseRecognizeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>识别文件中的营业执照 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别文件中的营业执照 响应体
/// <para>营业执照识别接口，支持JPG/JPEG/PNG/BMP/PDF五种文件类型的一次性的识别。</para>
/// <para>接口ID：7249730096956735491</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/ai/document_ai-v1/business_license/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fbusiness_license%2frecognize</para>
/// </summary>
public record PostDocumentAiV1BusinessLicenseRecognizeResponseDto
{
    /// <summary>
    /// <para>营业执照信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("business_license")]
    public PostDocumentAiV1BusinessLicenseRecognizeResponseDtoBusinessLicense? BusinessLicense { get; set; }

    /// <summary>
    /// <para>营业执照信息</para>
    /// </summary>
    public record PostDocumentAiV1BusinessLicenseRecognizeResponseDtoBusinessLicense
    {
        /// <summary>
        /// <para>识别出的实体类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("entities")]
        public BusinessEntity[]? Entities { get; set; }

        /// <summary>
        /// <para>识别出的实体类型</para>
        /// </summary>
        public record BusinessEntity
        {
            /// <summary>
            /// <para>识别的字段种类</para>
            /// <para>必填：否</para>
            /// <para>示例值：legal_representative</para>
            /// <para>可选值：<list type="bullet">
            /// <item>certificate_type：证书类型</item>
            /// <item>unified_social_credit_code：统一社会信用代码</item>
            /// <item>company_name：公司名称</item>
            /// <item>company_type：公司类型</item>
            /// <item>domicile：住所</item>
            /// <item>legal_representative：法定代表人</item>
            /// <item>registered_capital：注册资本</item>
            /// <item>established_time：成立日期</item>
            /// <item>established_date：营业期限</item>
            /// <item>business_scope：经营范围</item>
            /// <item>website：企业信用信息公示系统网址</item>
            /// <item>approval_date：核准日期</item>
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
