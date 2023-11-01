using Newtonsoft.Json;
namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别文件中的银行卡 响应体
/// <para>银行卡识别接口，支持JPG/JPEG/PNG/BMP四种文件类型的一次性的识别。</para>
/// <para>接口ID：7273083612789604355</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/ai/document_ai-v1/bank_card/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fbank_card%2frecognize</para>
/// </summary>
public record PostDocumentAiV1BankCardRecognizeResponseDto
{
    /// <summary>
    /// <para>银行卡信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("bank_card")]
    public PostDocumentAiV1BankCardRecognizeResponseDtoBankCard? BankCard { get; set; }

    /// <summary>
    /// <para>银行卡信息</para>
    /// </summary>
    public record PostDocumentAiV1BankCardRecognizeResponseDtoBankCard
    {
        /// <summary>
        /// <para>识别出的实体类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("entities")]
        public BankCardEntity[]? Entities { get; set; }

        /// <summary>
        /// <para>识别出的实体类型</para>
        /// </summary>
        public record BankCardEntity
        {
            /// <summary>
            /// <para>识别的字段种类</para>
            /// <para>必填：否</para>
            /// <para>示例值：card_number</para>
            /// <para>可选值：<list type="bullet">
            /// <item>card_number：银行卡卡号</item>
            /// <item>date_of_expiry：有效日期</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>识别出字段的文本信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：5184********8888</para>
            /// </summary>
            [JsonProperty("value")]
            public string? Value { get; set; }
        }
    }
}
