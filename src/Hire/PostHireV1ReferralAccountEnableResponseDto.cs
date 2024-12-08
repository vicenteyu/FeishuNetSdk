// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="PostHireV1ReferralAccountEnableResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>启用内推账户 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 启用内推账户 响应体
/// <para>根据账户 ID 启用账户，启用后可通过[「内推账户余额变更事件」](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/events/assets_update)监听余额变更、通过[「全额提取内推账户余额」](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/withdraw)提取余额。</para>
/// <para>接口ID：7418831232862584833</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/enable</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_account%2fenable</para>
/// </summary>
public record PostHireV1ReferralAccountEnableResponseDto
{
    /// <summary>
    /// <para>账户信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("account")]
    public PostHireV1ReferralAccountEnableResponseDtoAccount? Account { get; set; }

    /// <summary>
    /// <para>账户信息</para>
    /// </summary>
    public record PostHireV1ReferralAccountEnableResponseDtoAccount
    {
        /// <summary>
        /// <para>账户 ID</para>
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
        public PostHireV1ReferralAccountEnableResponseDtoAccountAssets? Assets { get; set; }

        /// <summary>
        /// <para>账户资产</para>
        /// </summary>
        public record PostHireV1ReferralAccountEnableResponseDtoAccountAssets
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
                    public float Amount { get; set; }
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
