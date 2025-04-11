// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="PostHireV1ReferralAccountEnableBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>启用内推账户 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 启用内推账户 请求体
/// <para>根据账户 ID 启用账户，启用后可通过[「内推账户余额变更事件」](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/events/assets_update)监听余额变更、通过[「全额提取内推账户余额」](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/withdraw)提取余额。</para>
/// <para>接口ID：7418831232862584833</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/referral_account/enable</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_account%2fenable</para>
/// </summary>
public record PostHireV1ReferralAccountEnableBodyDto
{
    /// <summary>
    /// <para>账户 ID，注册账户后获取：[注册内推账户](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/create)</para>
    /// <para>必填：否</para>
    /// <para>示例值：6942778198054125570</para>
    /// </summary>
    [JsonPropertyName("referral_account_id")]
    public string? ReferralAccountId { get; set; }
}
