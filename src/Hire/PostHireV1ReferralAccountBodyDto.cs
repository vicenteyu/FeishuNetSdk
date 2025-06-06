// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-26
//
// Last Modified By : yxr
// Last Modified On : 2024-06-26
// ************************************************************************
// <copyright file="PostHireV1ReferralAccountBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>注册内推账户 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 注册内推账户 请求体
/// <para>通过内推人的手机号或邮箱注册「内推奖励账户」。注册后，可通过[查询内推账户](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/get_account_assets)接口获取内推账户 ID、积分余额、现金余额等，可通过[「全额提取内推账号余额」](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/withdraw)接口提取账户余额，可通过[启动内推账户](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/enable)、[「停用内推账户」](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/deactivate)接口启/停用账户。</para>
/// <para>接口ID：7252281835550932994</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/referral_account/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_account%2fcreate</para>
/// </summary>
public record PostHireV1ReferralAccountBodyDto
{
    /// <summary>
    /// <para>电话，该参数与 email 参数必传一个</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("mobile")]
    public PostHireV1ReferralAccountBodyDtoMobile? Mobile { get; set; }

    /// <summary>
    /// <para>电话，该参数与 email 参数必传一个</para>
    /// </summary>
    public record PostHireV1ReferralAccountBodyDtoMobile
    {
        /// <summary>
        /// <para>电话国际区号，遵守国际统一标准，请参考[百度百科-国际长途电话区号](https://baike.baidu.com/item/%E5%9B%BD%E9%99%85%E9%95%BF%E9%80%94%E7%94%B5%E8%AF%9D%E5%8C%BA%E5%8F%B7%E8%A1%A8/12803495?fr=ge_ala)</para>
        /// <para>必填：否</para>
        /// <para>示例值：86</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// <para>手机号码，在传 mobile 参数的情况下必传</para>
        /// <para>必填：否</para>
        /// <para>示例值：18900001111</para>
        /// </summary>
        [JsonPropertyName("number")]
        public string? Number { get; set; }
    }

    /// <summary>
    /// <para>邮箱，该参数与 mobile 参数必传一个</para>
    /// <para>必填：否</para>
    /// <para>示例值：hire@open.com</para>
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}
