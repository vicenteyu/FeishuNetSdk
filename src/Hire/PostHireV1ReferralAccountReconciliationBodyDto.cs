// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHireV1ReferralAccountReconciliationBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>内推账户提现数据对账 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 内推账户提现数据对账 请求体
/// <para>对一段时间内的内推账户积分提现数据进行对账，调用方需传入调用方系统的内推账户积分变动信息。</para>
/// <para>接口ID：7252281835550900226</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/referral_account/reconciliation</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_account%2freconciliation</para>
/// </summary>
public record PostHireV1ReferralAccountReconciliationBodyDto
{
    /// <summary>
    /// <para>对账时段的起始交易时间，毫秒时间戳</para>
    /// <para>必填：是</para>
    /// <para>示例值：1685416831621</para>
    /// </summary>
    [JsonPropertyName("start_trans_time")]
    public string StartTransTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>对账时段的截止交易时间，毫秒时间戳</para>
    /// <para>必填：是</para>
    /// <para>示例值：1685416831622</para>
    /// </summary>
    [JsonPropertyName("end_trans_time")]
    public string EndTransTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>账户积分变动信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("trade_details")]
    public TradeDetail[]? TradeDetails { get; set; }

    /// <summary>
    /// <para>账户积分变动信息</para>
    /// </summary>
    public record TradeDetail
    {
        /// <summary>
        /// <para>内推账户ID，通过[注册内推账户](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/create)生成</para>
        /// <para>必填：是</para>
        /// <para>示例值：6930815272790114324</para>
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        /// <summary>
        /// <para>时段内该账户发生在调用方系统的积分之和</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("total_recharge_reward_info")]
        public BonusAmount? TotalRechargeRewardInfo { get; set; }

        /// <summary>
        /// <para>时段内该账户发生在调用方系统的积分之和</para>
        /// </summary>
        public record BonusAmount
        {
            /// <summary>
            /// <para>变动的积分数量</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("point_bonus")]
            public int? PointBonus { get; set; }
        }
    }
}
