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
// <summary>内推账号提现对账接口 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 内推账号提现对账接口 响应体
/// <para>定时将时间段内的账户充值信息同步到招聘，与招聘实际提取金额做对比，保证系统异常或其他意外情况发生时，双方系统可及时监控到充值异常等错误</para>
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
        /// <para>账户ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6930815272790114324</para>
        /// </summary>
        [JsonPropertyName("account_id")]
        public string? AccountId { get; set; }

        /// <summary>
        /// <para>招聘系统内的提取金额</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("total_withdraw_reward_info")]
        public BonusAmount? TotalWithdrawRewardInfo { get; set; }

        /// <summary>
        /// <para>招聘系统内的提取金额</para>
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

        /// <summary>
        /// <para>商城实际充值金额</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("total_recharge_reward_info")]
        public BonusAmount? TotalRechargeRewardInfo { get; set; }
    }
}
