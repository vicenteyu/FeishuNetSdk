// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHireV1OffersByOfferIdInternOfferStatusResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新实习 Offer 入/离职状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新实习 Offer 入/离职状态 响应体
/// <para>对「实习待入职」状态的实习 Offer 确认入职、放弃入职，或对「实习已入职」状态的实习 Offer 操作离职。</para>
/// <para>接口ID：7143222622736957442</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/offer/intern_offer_status</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer%2fintern_offer_status</para>
/// </summary>
public record PostHireV1OffersByOfferIdInternOfferStatusResponseDto
{
    /// <summary>
    /// <para>Offer ID，详细信息请参考[获取 Offer 信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/offer)</para>
    /// <para>必填：否</para>
    /// <para>示例值：6949805467799537964</para>
    /// </summary>
    [JsonPropertyName("offer_id")]
    public string? OfferId { get; set; }

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
    /// <para>入职表单信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("onboarding_info")]
    public InternOfferOnboardingInfo? OnboardingInfo { get; set; }

    /// <summary>
    /// <para>入职表单信息</para>
    /// </summary>
    public record InternOfferOnboardingInfo
    {
        /// <summary>
        /// <para>实际入职日期</para>
        /// <para>**值格式**："YYYY-MM-DD"</para>
        /// <para>必填：是</para>
        /// <para>示例值：2022-01-01</para>
        /// </summary>
        [JsonPropertyName("actual_onboarding_date")]
        public string ActualOnboardingDate { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>离职表单信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("offboarding_info")]
    public InternOfferOffboardingInfo? OffboardingInfo { get; set; }

    /// <summary>
    /// <para>离职表单信息</para>
    /// </summary>
    public record InternOfferOffboardingInfo
    {
        /// <summary>
        /// <para>实际离职日期</para>
        /// <para>**值格式**："YYYY-MM-DD"</para>
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
