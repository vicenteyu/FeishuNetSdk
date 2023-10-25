using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 停用外部系统内推账户 响应体
/// <para>停用后，对应的内推账号信息将无法通过接口[「内推账户余额变更事件」](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/events/assets_update)、[「提取内推账号余额」](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/withdraw)获取、修改</para>
/// <para>接口ID：7252281835550867458</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/deactivate</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_account%2fdeactivate</para>
/// </summary>
public record PostHireV1ReferralAccountByReferralAccountIdDeactivateResponseDto
{
    /// <summary>
    /// <para>账号信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("account")]
    public PostHireV1ReferralAccountByReferralAccountIdDeactivateResponseDtoAccount? Account { get; set; }

    /// <summary>
    /// <para>账号信息</para>
    /// </summary>
    public record PostHireV1ReferralAccountByReferralAccountIdDeactivateResponseDtoAccount
    {
        /// <summary>
        /// <para>账户ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6942778198054125570</para>
        /// </summary>
        [JsonProperty("account_id")]
        public string AccountId { get; set; } = string.Empty;

        /// <summary>
        /// <para>账户资产</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("assets")]
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
            [JsonProperty("confirmed_bonus")]
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
                [JsonProperty("point_bonus")]
                public int? PointBonus { get; set; }
            }
        }

        /// <summary>
        /// <para>账号状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：可用</item>
        /// <item>2：停用</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("status")]
        public int? Status { get; set; }
    }
}
