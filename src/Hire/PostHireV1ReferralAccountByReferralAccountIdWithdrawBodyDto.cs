// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-27
// ************************************************************************
// <copyright file="PostHireV1ReferralAccountByReferralAccountIdWithdrawBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>全额提取内推账户余额 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 全额提取内推账户余额 请求体
/// <para>通过账户 ID 全额提取内推账户下的积分/现金。全额提现后，内推人在飞书招聘系统中的积分/现金余额会变为 0，对应的积分/现金奖励状态也会变为「已发放」。</para>
/// <para>接口ID：7252281835550883842</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/referral_account/withdraw</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_account%2fwithdraw</para>
/// </summary>
public record PostHireV1ReferralAccountByReferralAccountIdWithdrawBodyDto
{
    /// <summary>
    /// <para>提取的奖励类型</para>
    /// <para>必填：是</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：积分</item>
    /// <item>2：现金</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("withdraw_bonus_type")]
    public int[] WithdrawBonusType { get; set; } = Array.Empty<int>();

    /// <summary>
    /// <para>外部提取单 ID，由请求方提供，用于保证接口的幂等性，需要保证唯一。传入重复 ID 会返回原 ID 对应的提取详情</para>
    /// <para>必填：是</para>
    /// <para>示例值：6942778198054125570</para>
    /// </summary>
    [JsonPropertyName("external_order_id")]
    public string ExternalOrderId { get; set; } = string.Empty;
}
