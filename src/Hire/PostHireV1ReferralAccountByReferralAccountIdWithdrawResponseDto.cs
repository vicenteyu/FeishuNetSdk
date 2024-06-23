// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHireV1ReferralAccountByReferralAccountIdWithdrawResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>全额提取内推账号余额 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 全额提取内推账号余额 响应体
/// <para>支持通过账号 ID 全额提取内推账号下的积分或现金奖励。调用前，请确认已完成[「注册外部系统内推账户」](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/create)并获取到账号 ID。提现后，内推人的对应积分或现金余额将变为 0，扣减后对应奖励将在招聘系统同步标记为「已发放」</para>
/// <para>接口ID：7252281835550883842</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/withdraw</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_account%2fwithdraw</para>
/// </summary>
public record PostHireV1ReferralAccountByReferralAccountIdWithdrawResponseDto
{
    /// <summary>
    /// <para>请求时传入的提现单ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6942778198054125570</para>
    /// </summary>
    [JsonPropertyName("external_order_id")]
    public string? ExternalOrderId { get; set; }

    /// <summary>
    /// <para>交易时间戳，需要保存，用于统一交易时间，方便对账</para>
    /// <para>必填：否</para>
    /// <para>示例值：1683634459543</para>
    /// </summary>
    [JsonPropertyName("trans_time")]
    public string? TransTime { get; set; }

    /// <summary>
    /// <para>本次提现金额明细</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("withdrawal_details")]
    public BonusAmount? WithdrawalDetails { get; set; }

    /// <summary>
    /// <para>本次提现金额明细</para>
    /// </summary>
    public record BonusAmount
    {
        /// <summary>
        /// <para>积分奖励</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("point_bonus")]
        public int? PointBonus { get; set; }
    }
}
