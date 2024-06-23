// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHireV1ReferralAccountByReferralAccountIdWithdrawBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>全额提取内推账号余额 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 全额提取内推账号余额 请求体
/// <para>支持通过账号 ID 全额提取内推账号下的积分或现金奖励。调用前，请确认已完成[「注册外部系统内推账户」](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/create)并获取到账号 ID。提现后，内推人的对应积分或现金余额将变为 0，扣减后对应奖励将在招聘系统同步标记为「已发放」</para>
/// <para>接口ID：7252281835550883842</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/withdraw</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_account%2fwithdraw</para>
/// </summary>
public record PostHireV1ReferralAccountByReferralAccountIdWithdrawBodyDto
{
    /// <summary>
    /// <para>请求提现的奖励类型</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("withdraw_bonus_type")]
    public int[]? WithdrawBonusType { get; set; }

    /// <summary>
    /// <para>提现单ID，请求时由请求方提供，后续关于本次提现操作的交互都以此提现单ID为标识进行，需要保证唯一,用于保证提现的幂等性，传入重复ID会返回对应提现单提取的金额明细</para>
    /// <para>必填：否</para>
    /// <para>示例值：6942778198054125570</para>
    /// </summary>
    [JsonPropertyName("external_order_id")]
    public string? ExternalOrderId { get; set; }
}
