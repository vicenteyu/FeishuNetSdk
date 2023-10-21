using Newtonsoft.Json;
namespace FeishuNetSdk.HumanAuthentication.Spec;
/// <summary>
/// 录入身份信息 请求体
/// <para>该接口用于录入实名认证的身份信息，在唤起有源活体认证前，需要使用该接口进行实名认证。{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=human_authentication&version=v1&resource=identity&method=create)</para>
/// <para>接口ID：6940461543747305500</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/human_authentication-v1/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fhuman_authentication-v1%2fidentity%2fcreate</para>
/// </summary>
public record PostHumanAuthenticationV1IdentitiesBodyDto
{
    /// <summary>
    /// <para>姓名</para>
    /// <para>**示例值**："张三"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("identity_name")]
    public string IdentityName { get; set; } = string.Empty;

    /// <summary>
    /// <para>身份证号</para>
    /// <para>**示例值**："4xxxxxxxx"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("identity_code")]
    public string IdentityCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>手机号</para>
    /// <para>**示例值**："13xxxxxxx"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("mobile")]
    public string? Mobile { get; set; }
}
