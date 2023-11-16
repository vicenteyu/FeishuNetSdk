namespace FeishuNetSdk.Hire;
/// <summary>
/// 内推账号提现对账接口 请求体
/// <para>定时将时间段内的账户充值信息同步到招聘，与招聘实际提取金额做对比，保证系统异常或其他意外情况发生时，双方系统可及时监控到充值异常等错误</para>
/// <para>接口ID：7252281835550900226</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/reconciliation</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_account%2freconciliation</para>
/// </summary>
public record PostHireV1ReferralAccountReconciliationBodyDto
{
    /// <summary>
    /// <para>按时间范围进行对账时 时间段的起始交易时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：1685416831621</para>
    /// </summary>
    [JsonPropertyName("start_trans_time")]
    public string? StartTransTime { get; set; }

    /// <summary>
    /// <para>按时间范围进行对账时 时间段的截止交易时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：1685416831622</para>
    /// </summary>
    [JsonPropertyName("end_trans_time")]
    public string? EndTransTime { get; set; }

    /// <summary>
    /// <para>交易信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("trade_details")]
    public TradeDetail[]? TradeDetails { get; set; }

    /// <summary>
    /// <para>交易信息</para>
    /// </summary>
    public record TradeDetail
    {
        /// <summary>
        /// <para>账户ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6930815272790114324</para>
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        /// <summary>
        /// <para>时间段内该账户在积分商城的实际充值金额</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("total_recharge_reward_info")]
        public BonusAmount? TotalRechargeRewardInfo { get; set; }

        /// <summary>
        /// <para>时间段内该账户在积分商城的实际充值金额</para>
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
}
