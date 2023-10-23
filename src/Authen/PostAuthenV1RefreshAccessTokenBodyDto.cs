using Newtonsoft.Json;
namespace FeishuNetSdk.Authen;
/// <summary>
/// 刷新 user_access_token 请求体
/// <para>`user_access_token` 的最大有效期是 6900 秒。当 `user_access_token` 过期时，可以调用本接口获取新的 `user_access_token`。</para>
/// <para>接口ID：7180265937329520644</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/access-token/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fauthen-v1%2frefresh_access_token%2fcreate</para>
/// </summary>
public record PostAuthenV1RefreshAccessTokenBodyDto
{
    /// <summary>
    /// <para>授权类型，**固定值**</para>
    /// <para>必填：是</para>
    /// <para>示例值：refresh_token</para>
    /// </summary>
    [JsonProperty("grant_type")]
    public string GrantType { get; set; } = string.Empty;

    /// <summary>
    /// <para>刷新 `user_access_token` 需要的凭证</para>
    /// <para>获取user_access_token接口和本接口均返回 `refresh_token`，**每次请求，请注意使用最新获取到的`refresh_token`**</para>
    /// <para>必填：是</para>
    /// <para>示例值：ur-oQ0mMq6MCcueAv0pwx2fQQhxqv__CbLu6G8ySFwafeKww2Def2BJdOkW3.9gCFM.LBQgFri901QaqeuL</para>
    /// </summary>
    [JsonProperty("refresh_token")]
    public string RefreshToken { get; set; } = string.Empty;
}
