// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-26
//
// Last Modified By : yxr
// Last Modified On : 2024-09-27
// ************************************************************************
// <copyright file="PostHireV1ReferralAccountByReferralAccountIdDeactivateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>停用内推账户 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 停用内推账户 响应体
/// <para>停用内推账户，停用后，将不再发送[「内推账户余额变更事件」](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/events/assets_update)，也无法通过[「提取内推账号余额」](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/withdraw)提取。</para>
/// <para>接口ID：7252281835550867458</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/referral_account/deactivate</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_account%2fdeactivate</para>
/// </summary>
public record PostHireV1ReferralAccountByReferralAccountIdDeactivateResponseDto
{
    /// <summary>
    /// <para>账户信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("account")]
    public PostHireV1ReferralAccountByReferralAccountIdDeactivateResponseDtoAccount? Account { get; set; }

    /// <summary>
    /// <para>账户信息</para>
    /// </summary>
    public record PostHireV1ReferralAccountByReferralAccountIdDeactivateResponseDtoAccount
    {
        /// <summary>
        /// <para>账户ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6942778198054125570</para>
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        /// <summary>
        /// <para>账户资产</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("assets")]
        public PostHireV1ReferralAccountByReferralAccountIdDeactivateResponseDtoAccountAssets? Assets { get; set; }

        /// <summary>
        /// <para>账户资产</para>
        /// </summary>
        public record PostHireV1ReferralAccountByReferralAccountIdDeactivateResponseDtoAccountAssets
        {
            /// <summary>
            /// <para>已确认的奖励</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("confirmed_bonus")]
            public BonusAmount? ConfirmedBonus { get; set; }

            /// <summary>
            /// <para>已确认的奖励</para>
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

                /// <summary>
                /// <para>现金奖励</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("cash_bonus")]
                public Cash[]? CashBonus { get; set; }

                /// <summary>
                /// <para>现金奖励</para>
                /// </summary>
                public record Cash
                {
                    /// <summary>
                    /// <para>币种，详情可查看：[枚举常量介绍](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/enum)中「币种（currency）枚举定义」</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：CNY</para>
                    /// </summary>
                    [JsonPropertyName("currency_type")]
                    public string CurrencyType { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>数额，保留到小数点后两位</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：100</para>
                    /// </summary>
                    [JsonPropertyName("amount")]
                    public decimal Amount { get; set; }
                }
            }
        }

        /// <summary>
        /// <para>账户状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：可用</item>
        /// <item>2：停用</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }
    }
}
