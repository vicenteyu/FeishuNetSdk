// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="HireReferralAccountAssetsUpdateV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>内推账户余额变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire.Events;
/// <summary>
/// 内推账户余额变更 事件体
/// <para>当内推账户余额发生变更（增加或者减少）时，触发该事件。该事件将推送变更后的账户余额信息。收到事件后，如需将余额提现到三方平台发放给用户，请使用接口 [全额提取内推账号余额](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/withdraw)。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=hire&amp;version=v1&amp;resource=referral_account&amp;event=assets_update)</para>
/// <para>接口ID：7252281835550916610</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/events/assets_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_account%2fevents%2fassets_update</para>
/// </summary>
public record HireReferralAccountAssetsUpdateV1EventBodyDto() : EventBodyDto("hire.referral_account.assets_update_v1")
{
    /// <summary>
    /// <para>账户 ID， 同一用户在同一租户同一应用中账户唯一</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("account_id")]
    public string? AccountId { get; set; }

    /// <summary>
    /// <para>账户余额信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("assets")]
    public AssetsSuffix? Assets { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record AssetsSuffix
    {
        /// <summary>
        /// <para>已确认的奖励</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("confirmed_bonus")]
        public BonusAmount? ConfirmedBonus { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public record BonusAmount
    {
        /// <summary>
        /// <para>积分奖励</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("point_bonus")]
        public int? PointBonus { get; set; }
    }

    /// <summary>
    /// <para>变更事件戳（单位：毫秒）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("modify_time")]
    public string? ModifyTime { get; set; }
}
