namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新实习 Offer 入/离职状态 请求体
/// <para>对「实习待入职」状态的实习 Offer 确认入职、放弃入职，或对「实习已入职」状态的实习 Offer 操作离职。</para>
/// <para>接口ID：7143222622736957442</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/offer/intern_offer_status</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer%2fintern_offer_status</para>
/// </summary>
public record PostHireV1OffersByOfferIdInternOfferStatusBodyDto
{
    /// <summary>
    /// <para>更新入/离职状态的操作</para>
    /// <para>必填：是</para>
    /// <para>示例值：confirm_onboarding</para>
    /// <para>可选值：<list type="bullet">
    /// <item>confirm_onboarding：确认入职</item>
    /// <item>cancel_onboarding：放弃入职</item>
    /// <item>offboard：操作离职</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("operation")]
    public string Operation { get; set; } = string.Empty;

    /// <summary>
    /// <para>入职表单信息（当 operation 为 confirm_onboarding 时，该字段必填）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("onboarding_info")]
    public InternOfferOnboardingInfo? OnboardingInfo { get; set; }

    /// <summary>
    /// <para>入职表单信息（当 operation 为 confirm_onboarding 时，该字段必填）</para>
    /// </summary>
    public record InternOfferOnboardingInfo
    {
        /// <summary>
        /// <para>实际入职日期</para>
        /// <para>必填：是</para>
        /// <para>示例值：2022-01-01</para>
        /// </summary>
        [JsonPropertyName("actual_onboarding_date")]
        public string ActualOnboardingDate { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>离职表单信息（当 operation 为 offboard 时，该字段必填）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("offboarding_info")]
    public InternOfferOffboardingInfo? OffboardingInfo { get; set; }

    /// <summary>
    /// <para>离职表单信息（当 operation 为 offboard 时，该字段必填）</para>
    /// </summary>
    public record InternOfferOffboardingInfo
    {
        /// <summary>
        /// <para>实际离职日期（实际离职日期需晚于实际入职日期）</para>
        /// <para>必填：是</para>
        /// <para>示例值：2022-03-02</para>
        /// </summary>
        [JsonPropertyName("actual_offboarding_date")]
        public string ActualOffboardingDate { get; set; } = string.Empty;

        /// <summary>
        /// <para>备注</para>
        /// <para>必填：否</para>
        /// <para>示例值：主动离职</para>
        /// </summary>
        [JsonPropertyName("notes")]
        public string? Notes { get; set; }
    }
}
