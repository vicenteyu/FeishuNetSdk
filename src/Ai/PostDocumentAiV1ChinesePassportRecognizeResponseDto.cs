using Newtonsoft.Json;
namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别文件中的中国护照 响应体
/// <para>中国护照识别接口，支持JPG/JPEG/PNG/BMP四种文件类型的一次性的识别。</para>
/// <para>接口ID：7273083612789587971</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/ai/document_ai-v1/chinese_passport/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fchinese_passport%2frecognize</para>
/// </summary>
public record PostDocumentAiV1ChinesePassportRecognizeResponseDto
{
    /// <summary>
    /// <para>中国护照信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("chinese_passport")]
    public PostDocumentAiV1ChinesePassportRecognizeResponseDtoChinesePassport? ChinesePassport { get; set; }

    /// <summary>
    /// <para>中国护照信息</para>
    /// </summary>
    public record PostDocumentAiV1ChinesePassportRecognizeResponseDtoChinesePassport
    {
        /// <summary>
        /// <para>识别出的实体类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("entities")]
        public ChinesePassportEntity[]? Entities { get; set; }

        /// <summary>
        /// <para>识别出的实体类型</para>
        /// </summary>
        public record ChinesePassportEntity
        {
            /// <summary>
            /// <para>识别的字段种类</para>
            /// <para>必填：否</para>
            /// <para>示例值：full_name_cn</para>
            /// <para>可选值：<list type="bullet">
            /// <item>full_name_cn：中文姓名</item>
            /// <item>full_name_en：英文格式姓名</item>
            /// <item>date_of_birth：出生日期</item>
            /// <item>date_of_expiry：有效期至</item>
            /// <item>place_of_issue：签发地点</item>
            /// <item>passport_number：护照号码</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>识别出字段的文本信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonProperty("value")]
            public string? Value { get; set; }
        }
    }
}
