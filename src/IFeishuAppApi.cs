using FeishuNetSdk.Attributes;
using WebApiClientCore;
using WebApiClientCore.Attributes;
using WebApiClientCore.Parameters;

namespace FeishuNetSdk;
/// <summary>
/// 获取用户凭证（AppAccessToken）的接口
/// </summary>
[EnableLoggingFilter]
[IgnoreStatusExceptionFilter]
[HttpHost("https://open.feishu.cn/"), JsonReturn, OAuthToken]
public interface IFeishuAppApi : IHttpApi
{
    /// <summary>
    /// <para>【身份验证】获取 user_access_token（小程序）</para>
    /// <para>接口ID：6907569745298817026</para>
    /// <para>接口文档：https://open.feishu.cn/document/uYjL24iN/ukjM04SOyQjL5IDN</para>
    /// <para>Authorization：app_access_token</para>
    /// <para>通过 [login](https://open.feishu.cn/document/uYjL24iN/uYzMuYzMuYzM)接口获取到登录凭证`code`后，开发者可以通过服务器发送请求的方式获取 session_key 和 用户凭证信息。</para>
    /// <para>本接口适用于 [小程序登录](https://open.feishu.cn/document/uYjL24iN/uETO5QjLxkTO04SM5kDN) 及[小组件登录](https://open.feishu.cn/document/uAjLw4CM/uYjL24iN/block/guide/open-ability/block-login)。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    [HttpPost("/open-apis/mina/v2/tokenLoginValidate")]
    System.Threading.Tasks.Task<FeishuResponse<Auth.Spec.PostMinaV2TokenLoginValidateResponseDto>> PostMinaV2TokenLoginValidateAsync(
        [JsonContent] Auth.Spec.PostMinaV2TokenLoginValidateBodyDto dto);

    /// <summary>
    /// <para>【身份验证】JSAPI 临时授权凭证</para>
    /// <para>接口ID：6911312738021720065</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uYTM5UjL2ETO14iNxkTN/h5_js_sdk/authorization</para>
    /// <para>Authorization：tenant_access_token、user_access_token、app_access_token</para>
    /// <para>该接口用于返回调用 JSAPI 临时调用凭证，使用该凭证，在调用 JSAPI 时，请求不会被拦截</para>
    /// <para>由于获取 jsapi_ticket 的api调用次数非常有限，频繁刷新 jsapi_ticket 会导致api调用受限，影响自身业务，开发者需要在自己的服务全局缓存jsapi_ticket 。</para>
    /// </summary>
    [HttpPost("/open-apis/jssdk/ticket/get")]
    System.Threading.Tasks.Task<FeishuResponse<Auth.Spec.PostJssdkTicketGetResponseDto>> PostJssdkTicketGetAsync();

    /// <summary>
    /// <para>【身份验证】刷新 user_access_token</para>
    /// <para>接口ID：7180265937329520644</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/authen-v1/refresh_access_token/create</para>
    /// <para>Authorization：app_access_token</para>
    /// <para>user_access_token 的最大有效期是 2小时左右。当 user_access_token 过期时，可以调用本接口获取新的 user_access_token。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    [Obsolete("历史版本")]
    [HttpPost("/open-apis/authen/v1/refresh_access_token")]
    System.Threading.Tasks.Task<FeishuResponse<Auth.PostAuthenV1RefreshAccessTokenResponseDto>> PostAuthenV1RefreshAccessTokenAsync(
        [JsonContent] Auth.PostAuthenV1RefreshAccessTokenBodyDto dto);

    /// <summary>
    /// <para>【身份验证】获取 user_access_token</para>
    /// <para>接口ID：7180265937329553412</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/authen-v1/access_token/create</para>
    /// <para>Authorization：app_access_token</para>
    /// <para>根据[登录预授权码](https://open.feishu.cn/document/ukTMukTMukTM/ukzN4UjL5cDO14SO3gTN) code 获取 `user_access_token`。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    [Obsolete("历史版本")]
    [HttpPost("/open-apis/authen/v1/access_token")]
    System.Threading.Tasks.Task<FeishuResponse<Auth.PostAuthenV1AccessTokenResponseDto>> PostAuthenV1AccessTokenAsync(
        [JsonContent] Auth.PostAuthenV1AccessTokenBodyDto dto);

    /// <summary>
    /// <para>【身份验证】刷新 user_access_token</para>
    /// <para>接口ID：7277403063290707996</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/authen-v1/oidc-refresh_access_token/create</para>
    /// <para>Authorization：app_access_token</para>
    /// <para>user_access_token 的最大有效期是 2小时左右。当 user_access_token 过期时，可以调用本接口获取新的 user_access_token。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    [HttpPost("/open-apis/authen/v1/oidc/refresh_access_token")]
    System.Threading.Tasks.Task<FeishuResponse<Auth.PostAuthenV1OidcRefreshAccessTokenResponseDto>> PostAuthenV1OidcRefreshAccessTokenAsync(
        [JsonContent] Auth.PostAuthenV1OidcRefreshAccessTokenBodyDto dto);

    /// <summary>
    /// <para>【身份验证】获取 user_access_token（网页应用）</para>
    /// <para>接口ID：7277403063290724380</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/authen-v1/oidc-access_token/create</para>
    /// <para>Authorization：app_access_token</para>
    /// <para>根据[登录预授权码](https://open.feishu.cn/document/common-capabilities/sso/api/obtain-oauth-code) 返回 code 获取 `user_access_token`。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    [HttpPost("/open-apis/authen/v1/oidc/access_token")]
    System.Threading.Tasks.Task<FeishuResponse<Auth.PostAuthenV1OidcAccessTokenResponseDto>> PostAuthenV1OidcAccessTokenAsync(
        [JsonContent] Auth.PostAuthenV1OidcAccessTokenBodyDto dto);
}

