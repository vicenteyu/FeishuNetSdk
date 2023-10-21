using Newtonsoft.Json;
namespace FeishuNetSdk.Authen.Spec;
/// <summary>
/// 获取登录预授权码 响应体
/// <para>调用本接口获取用户的登录预授权码 code。登录预授权码的有效期是 5 分钟，且只能被使用一次。</para>
/// <para>**说明**：本接口适用于用户登录网页应用场景。当用户在飞书内打开网页应用时，会跳转到飞书登录界面，用户授权后，会自动跳转到重定向 URL，并携带飞书开放平台返回的登录预授权码 code。有关重定向 URL 的详细介绍，请参考[获取 user_access_token](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/authen-v1/access_token/create)。</para>
/// <para>接口ID：6907569744329932801</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/login-state-management/obtain-code</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukzN4UjL5cDO14SO3gTN</para>
/// </summary>
public record GetAuthenV1IndexResponseDto
{
    /// <summary>
    /// <para>重定向 URL，即请求中传入的重定向 URL</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("redirect_uri")]
    public string? RedirectUri { get; set; }

    /// <summary>
    /// <para>登录预授权码</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("code")]
    public string? Code { get; set; }

    /// <summary>
    /// <para>即请求中传入的 state 参数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("state")]
    public string? State { get; set; }
}
