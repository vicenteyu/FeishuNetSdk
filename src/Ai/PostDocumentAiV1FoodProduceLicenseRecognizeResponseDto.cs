using Newtonsoft.Json;
namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别文件中的食品生产许可证 响应体
/// <para>食品生产许可证识别接口，支持JPG/JPEG/PNG/BMP四种文件类型的一次性的识别。</para>
/// <para>接口ID：7249730096956702723</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/ai/document_ai-v1/food_produce_license/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2ffood_produce_license%2frecognize</para>
/// </summary>
public record PostDocumentAiV1FoodProduceLicenseRecognizeResponseDto
{
    /// <summary>
    /// <para>食品生产许可证信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("food_produce_license")]
    public PostDocumentAiV1FoodProduceLicenseRecognizeResponseDtoFoodProduceLicense? FoodProduceLicense { get; set; }

    /// <summary>
    /// <para>食品生产许可证信息</para>
    /// </summary>
    public record PostDocumentAiV1FoodProduceLicenseRecognizeResponseDtoFoodProduceLicense
    {
        /// <summary>
        /// <para>识别出的实体列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("entities")]
        public FoodProduceEntity[]? Entities { get; set; }

        /// <summary>
        /// <para>识别出的实体列表</para>
        /// </summary>
        public record FoodProduceEntity
        {
            /// <summary>
            /// <para>识别的字段种类</para>
            /// <para>必填：否</para>
            /// <para>示例值：issuer</para>
            /// <para>可选值：<list type="bullet">
            /// <item>validity_period：有效期</item>
            /// <item>issuer：签发人</item>
            /// <item>issuing_authority：发证机关</item>
            /// <item>complaints_hotline：投诉举报电话</item>
            /// <item>food_category：食品类别</item>
            /// <item>production_address：生产地址</item>
            /// <item>license_number：许可证编号</item>
            /// <item>domicile：住所</item>
            /// <item>legal_representative：法定代表人(负责人)</item>
            /// <item>credit_code：社会信用代码(身份证号)</item>
            /// <item>producer：生产者名称</item>
            /// <item>daily_supervisory_authorities：日常监督管理机构</item>
            /// <item>daily_supervisor：日常监督管理人员</item>
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
