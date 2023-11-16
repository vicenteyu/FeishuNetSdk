namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别文件中的食品经营许可证 响应体
/// <para>食品经营许可证识别接口，支持JPG/JPEG/PNG/BMP四种文件类型的一次性的识别。</para>
/// <para>接口ID：7249730096956719107</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/ai/document_ai-v1/food_manage_license/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2ffood_manage_license%2frecognize</para>
/// </summary>
public record PostDocumentAiV1FoodManageLicenseRecognizeResponseDto
{
    /// <summary>
    /// <para>食品经营许可证信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("food_manage_license")]
    public PostDocumentAiV1FoodManageLicenseRecognizeResponseDtoFoodManageLicense? FoodManageLicense { get; set; }

    /// <summary>
    /// <para>食品经营许可证信息</para>
    /// </summary>
    public record PostDocumentAiV1FoodManageLicenseRecognizeResponseDtoFoodManageLicense
    {
        /// <summary>
        /// <para>识别出的实体列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("entities")]
        public FoodManageEntity[]? Entities { get; set; }

        /// <summary>
        /// <para>识别出的实体列表</para>
        /// </summary>
        public record FoodManageEntity
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
            /// <item>license_number：许可证编号</item>
            /// <item>domicile：住所</item>
            /// <item>legal_representative：法定代表人(负责人)</item>
            /// <item>credit_code：社会信用代码(身份证号)</item>
            /// <item>operator：经营者名称</item>
            /// <item>premise：经营场所</item>
            /// <item>daily_supervisor：日常监督管理人员</item>
            /// <item>daily_supervisory_authorities：日常监督管理机构</item>
            /// <item>main_body：主体业态</item>
            /// <item>operating_item：经营项目</item>
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
