// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="GetHireV1ReferralAccountGetAccountAssetsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询内推账户 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 查询内推账户 响应体
/// <para>根据账户 ID 查询内推账户信息。</para>
/// <para>接口ID：7418831232862601217</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/get_account_assets</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_account%2fget_account_assets</para>
/// </summary>
public record GetHireV1ReferralAccountGetAccountAssetsResponseDto
{
    /// <summary>
    /// <para>账户信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("account")]
    public GetHireV1ReferralAccountGetAccountAssetsResponseDtoAccount? Account { get; set; }

    /// <summary>
    /// <para>账户信息</para>
    /// </summary>
    public record GetHireV1ReferralAccountGetAccountAssetsResponseDtoAccount
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
        public GetHireV1ReferralAccountGetAccountAssetsResponseDtoAccountAssets? Assets { get; set; }

        /// <summary>
        /// <para>账户资产</para>
        /// </summary>
        public record GetHireV1ReferralAccountGetAccountAssetsResponseDtoAccountAssets
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

        /// <summary>
        /// <para>账户绑定的内推人信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("referrer")]
        public AccountReferrer? Referrer { get; set; }

        /// <summary>
        /// <para>账户绑定的内推人信息</para>
        /// </summary>
        public record AccountReferrer
        {
            /// <summary>
            /// <para>内推人 ID，与入参`user_id_type`类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：7413952589321914668</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>内推人名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>内推人名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>内推人中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>内推人英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：zhangSan</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>内推人邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：27188272xxxx1.com</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string? Email { get; set; }

            /// <summary>
            /// <para>内推人手机</para>
            /// <para>必填：否</para>
            /// <para>示例值：1879087xxx8</para>
            /// </summary>
            [JsonPropertyName("mobile")]
            public string? Mobile { get; set; }
        }
    }
}
