// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHireV1ReferralAccountReconciliationResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>内推账户提现数据对账 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 内推账户提现数据对账 响应体
/// <para>对一段时间内的内推账户积分提现数据进行对账，调用方需传入调用方系统的内推账户积分变动信息。</para>
/// <para>接口ID：7252281835550900226</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/reconciliation</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_account%2freconciliation</para>
/// </summary>
public record PostHireV1ReferralAccountReconciliationResponseDto
{
    /// <summary>
    /// <para>核对失败的信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("check_failed_list")]
    public CheckFailedAccountInfo[]? CheckFailedLists { get; set; }

    /// <summary>
    /// <para>核对失败的信息</para>
    /// </summary>
    public record CheckFailedAccountInfo
    {
        /// <summary>
        /// <para>内推账户ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6930815272790114324</para>
        /// </summary>
        [JsonPropertyName("account_id")]
        public string? AccountId { get; set; }

        /// <summary>
        /// <para>飞书招聘系统内的账户积分提取数量</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("total_withdraw_reward_info")]
        public BonusAmount? TotalWithdrawRewardInfo { get; set; }

        /// <summary>
        /// <para>飞书招聘系统内的账户积分提取数量</para>
        /// </summary>
        public record BonusAmount
        {
            /// <summary>
            /// <para>积分数量</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("point_bonus")]
            public int? PointBonus { get; set; }
        }

        /// <summary>
        /// <para>调用方系统的积分变动数量</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("total_recharge_reward_info")]
        public BonusAmount? TotalRechargeRewardInfo { get; set; }
    }
}
