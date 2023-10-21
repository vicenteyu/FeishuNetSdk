using Newtonsoft.Json;
namespace FeishuNetSdk.Admin.Spec;
/// <summary>
/// 重置用户的企业邮箱密码 请求体
/// <para>重置用户的企业邮箱密码，仅当用户的邮箱和企业邮箱(别名)一致时生效，可用于处理飞书企业邮箱登录死锁的问题。</para>
/// <para>邮箱死锁：当用户的登录凭证与飞书企业邮箱一致时，目前飞书登录流程要求用户输入验证码，由于飞书邮箱无单独的帐号体系，则未登录时无法收取邮箱验证码，即陷入死锁。</para>
/// <para>接口ID：7081092146976161796</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/admin-v1/password/reset</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fadmin-v1%2fpassword%2freset</para>
/// </summary>
public record PostAdminV1PasswordResetBodyDto
{
    /// <summary>
    /// <para>需要重置的密码参数，不少于8个字符，字母、数字和符号，至少三选二</para>
    /// <para>**示例值**：1234abcd</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("password")]
    public PasswordSuffix Password { get; set; } = new();

    public record PasswordSuffix
    {
        /// <summary>
        /// <para>企业邮箱密码</para>
        /// <para>**示例值**："abcd*efg"</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("ent_email_password")]
        public string EntEmailPassword { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>待修改密码的用户ID，只针对邮箱登录凭证与企业邮箱(包括别名)相等的用户生效</para>
    /// <para>**示例值**："abc123"</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `200` 字符</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("user_id")]
    public string UserId { get; set; } = string.Empty;
}
