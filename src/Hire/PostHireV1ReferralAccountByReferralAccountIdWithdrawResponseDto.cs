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
// <summary>全额提取内推账户余额 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 全额提取内推账户余额 响应体
/// <para>通过账号 ID 全额提取内推账号下的积分。全额提现后，内推人在飞书招聘系统中的积分余额会变为 0，对应的积分奖励状态也会变为「已发放」。</para>
/// <para>接口ID：7252281835550883842</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/withdraw</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_account%2fwithdraw</para>
/// </summary>
public record PostHireV1ReferralAccountByReferralAccountIdWithdrawResponseDto
{
    /// <summary>
    /// <para>提取单 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6942778198054125570</para>
    /// </summary>
    [JsonPropertyName("external_order_id")]
    public string? ExternalOrderId { get; set; }

    /// <summary>
    /// <para>交易时间，毫秒时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1683634459543</para>
    /// </summary>
    [JsonPropertyName("trans_time")]
    public string? TransTime { get; set; }

    /// <summary>
    /// <para>提取详情</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("withdrawal_details")]
    public BonusAmount? WithdrawalDetails { get; set; }

    /// <summary>
    /// <para>提取详情</para>
    /// </summary>
    public record BonusAmount
    {
        /// <summary>
        /// <para>提取的积分数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("point_bonus")]
        public int? PointBonus { get; set; }
    }
}
