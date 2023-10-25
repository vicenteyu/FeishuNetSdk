using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 注册外部系统内推账户 请求体
/// <para>支持通过内推人的手机号或邮箱注册「内推奖励账号」。注册后，可获取对应内推人的账号 ID，并查询、操作对应内推人的积分和奖励余额，配合接口：[「内推账户余额变更事件」](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/events/assets_update)、[「全额提取内推账号余额」](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/withdraw)。如需停用账户，可调用[「停用外部系统内推账户」](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/deactivate)</para>
/// <para>接口ID：7252281835550932994</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral_account/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_account%2fcreate</para>
/// </summary>
public record PostHireV1ReferralAccountBodyDto
{
    /// <summary>
    /// <para>电话</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("mobile")]
    public PostHireV1ReferralAccountBodyDtoMobile? Mobile { get; set; }

    /// <summary>
    /// <para>电话</para>
    /// </summary>
    public record PostHireV1ReferralAccountBodyDtoMobile
    {
        /// <summary>
        /// <para>国家代码</para>
        /// <para>必填：否</para>
        /// <para>示例值：86</para>
        /// </summary>
        [JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// <para>手机号码</para>
        /// <para>必填：否</para>
        /// <para>示例值：18900001111</para>
        /// </summary>
        [JsonProperty("number")]
        public string? Number { get; set; }
    }

    /// <summary>
    /// <para>邮箱</para>
    /// <para>必填：否</para>
    /// <para>示例值：hire@open.com</para>
    /// </summary>
    [JsonProperty("email")]
    public string? Email { get; set; }
}
