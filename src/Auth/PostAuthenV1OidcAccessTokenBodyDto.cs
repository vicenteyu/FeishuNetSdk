namespace FeishuNetSdk.Auth;
/// <summary>
/// 获取 user_access_token 请求体
/// <para>根据[登录预授权码](https://open.feishu.cn/document/common-capabilities/sso/api/obtain-oauth-code) 返回 code 获取 `user_access_token`。</para>
/// <para>接口ID：7277403063290724380</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/authen-v1/oidc-access_token/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fauthen-v1%2foidc-access_token%2fcreate</para>
/// </summary>
public record PostAuthenV1OidcAccessTokenBodyDto
{
    /// <summary>
    /// <para>授权类型，**固定值**</para>
    /// <para>必填：是</para>
    /// <para>示例值：authorization_code</para>
    /// </summary>
    [JsonPropertyName("grant_type")]
    public string GrantType { get; set; } = string.Empty;

    /// <summary>
    /// <para>登录预授权码，调用[登录预授权码](https://open.feishu.cn/document/common-capabilities/sso/api/obtain-oauth-code) 获取code</para>
    /// <para>必填：是</para>
    /// <para>示例值：xMSldislSkdK</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; } = string.Empty;
}
