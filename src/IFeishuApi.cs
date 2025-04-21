// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="IFeishuApi.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取应用访问凭证（AccessToken）的接口</summary>
// ************************************************************************
using FeishuNetSdk.Attributes;
using WebApiClientCore;
using WebApiClientCore.Attributes;
using WebApiClientCore.Parameters;

namespace FeishuNetSdk;
/// <summary>
/// 获取应用访问凭证（AccessToken）的接口
/// </summary>
[EnableLoggingFilter]
[IgnoreStatusExceptionFilter]
[HttpHost("https://open.feishu.cn/"), JsonReturn]
public interface IFeishuApi : IHttpApi
{
    /// <summary>
    /// <para>【身份验证】商店应用获取 app_access_token</para>
    /// <para>接口ID：6995779366223708164</para>
    /// <para>接口文档：https://open.feishu.cn/document/server-docs/authentication-management/access-token/app_access_token</para>
    /// <para>商店应用通过此接口获取`app_access_token`。</para>
    /// <para>**说明：** `app_access_token` 的最大有效期是 2 小时。如果在有效期小于 30 分钟的情况下，调用本接口，会返回一个新的 `app_access_token`，这会同时存在两个有效的 `app_access_token`。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    [HttpPost("/open-apis/auth/v3/app_access_token")]
    System.Threading.Tasks.Task<Auth.Spec.PostAuthV3AppAccessTokenResponseDto> PostAuthV3AppAccessTokenAsync(
        [JsonContent] Auth.Spec.PostAuthV3AppAccessTokenBodyDto dto);

    /// <summary>
    /// <para>【身份验证】自建应用获取 tenant_access_token</para>
    /// <para>接口ID：6995779366223724548</para>
    /// <para>接口文档：https://open.feishu.cn/document/server-docs/authentication-management/access-token/tenant_access_token_internal</para>
    /// <para>自建应用通过此接口获取 `tenant_access_token`。</para>
    /// <para>注意事项：</para>
    /// <para>`tenant_access_token` 的最大有效期是 2 小时。</para>
    /// <para>- 剩余有效期小于 30 分钟时，调用本接口会返回一个新的 `tenant_access_token`，这会同时存在两个有效的 `tenant_access_token`。</para>
    /// <para>- 剩余有效期大于等于 30 分钟时，调用本接口会返回原有的 `tenant_access_token`。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    [HttpPost("/open-apis/auth/v3/tenant_access_token/internal")]
    System.Threading.Tasks.Task<Auth.Spec.PostAuthV3TenantAccessTokenInternalResponseDto> PostAuthV3TenantAccessTokenInternalAsync(
        [JsonContent] Auth.Spec.PostAuthV3TenantAccessTokenInternalBodyDto dto);

    /// <summary>
    /// <para>【身份验证】商店应用获取 tenant_access_token</para>
    /// <para>接口ID：6995779366223740932</para>
    /// <para>接口文档：https://open.feishu.cn/document/server-docs/authentication-management/access-token/tenant_access_token</para>
    /// <para>商店应用通过此接口获取`tenant_access_token`。</para>
    /// <para>**说明** **：** `tenant_access_token` 的最大有效期是 2 小时。如果在有效期小于 30 分钟的情况下，调用本接口，会返回一个新的 `tenant_access_token`，这会同时存在两个有效的 `tenant_access_token`。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    [HttpPost("/open-apis/auth/v3/tenant_access_token")]
    System.Threading.Tasks.Task<Auth.Spec.PostAuthV3TenantAccessTokenResponseDto> PostAuthV3TenantAccessTokenAsync(
        [JsonContent] Auth.Spec.PostAuthV3TenantAccessTokenBodyDto dto);

    /// <summary>
    /// <para>【身份验证】重新获取 app_ticket</para>
    /// <para>接口ID：6995779366223757316</para>
    /// <para>接口文档：https://open.feishu.cn/document/server-docs/authentication-management/access-token/app_ticket_resend</para>
    /// <para>开放平台每隔 1 小时会向应用推送 app_ticket 事件，事件体内包含了 app_ticket。应用也可以主动调用此接口，触发开放平台即时推送 app_ticket 事件。了解事件信息可参见[app_ticket 事件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v6/event/app_ticket-events)。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    [HttpPost("/open-apis/auth/v3/app_ticket/resend")]
    System.Threading.Tasks.Task<FeishuResponse> PostAuthV3AppTicketResendAsync(
        [JsonContent] Auth.Spec.PostAuthV3AppTicketResendBodyDto dto);

    /// <summary>
    /// <para>【身份验证】自建应用获取 app_access_token</para>
    /// <para>接口ID：6995779366223822852</para>
    /// <para>接口文档：https://open.feishu.cn/document/server-docs/authentication-management/access-token/app_access_token_internal</para>
    /// <para>自建应用通过此接口获取`app_access_token`。</para>
    /// <para>**说明：** `app_access_token` 的最大有效期是 2 小时。</para>
    /// <para>- 如果在有效期小于 30 分钟的情况下，调用本接口，会返回一个新的 `app_access_token`，这会同时存在两个有效的 `app_access_token`。</para>
    /// <para>- 如果在有效期大于等于 30 分钟的情况下，调用本接口，会返回原有的 `app_access_token`。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    [HttpPost("/open-apis/auth/v3/app_access_token/internal")]
    System.Threading.Tasks.Task<Auth.Spec.PostAuthV3AppAccessTokenInternalResponseDto> PostAuthV3AppAccessTokenInternalAsync(
        [JsonContent] Auth.Spec.PostAuthV3AppAccessTokenInternalBodyDto dto);

    /// <summary>
    /// <para>【身份验证】刷新 user_access_token</para>
    /// <para>接口ID：7435312925587898371</para>
    /// <para>接口文档：https://open.feishu.cn/document/authentication-management/access-token/refresh-user-access-token</para>
    /// <para>OAuth 令牌接口，可用于刷新 &lt;code&gt;user_access_token&lt;/code&gt; 以及获取新的 &lt;code&gt;refresh_token&lt;/code&gt;。</para>
    /// <para>字段权限要求：<list type="bullet">
    /// <item>offline_access</item>
    /// </list></para>
    /// </summary>
    /// <param name="dto">请求体</param>
    [HttpPost("/open-apis/authen/v2/oauth/token")]
    System.Threading.Tasks.Task<FeishuResponse<Auth.Spec.PostAuthenV2OauthRefreshTokenResponseDto>> PostAuthenV2OauthRefreshTokenAsync(
        [JsonContent] Auth.Spec.PostAuthenV2OauthRefreshTokenBodyDto dto);

    /// <summary>
    /// <para>【身份验证】获取 user_access_token</para>
    /// <para>接口ID：7435312925587914755</para>
    /// <para>接口文档：https://open.feishu.cn/document/authentication-management/access-token/get-user-access-token</para>
    /// <para>OAuth 令牌接口，可用于获取 &lt;code&gt;user_access_token&lt;/code&gt; 以及 &lt;code&gt;refresh_token&lt;/code&gt;。&lt;code&gt;user_access_token&lt;/code&gt; 为用户访问凭证，使用该凭证可以以用户身份调用 OpenAPI。&lt;code&gt;refresh_token&lt;/code&gt; 为刷新凭证，可以用来获取新的 &lt;code&gt;user_access_token&lt;/code&gt;。</para>
    /// <para>字段权限要求：<list type="bullet">
    /// <item>offline_access</item>
    /// </list></para>
    /// </summary>
    /// <param name="dto">请求体</param>
    [HttpPost("/open-apis/authen/v2/oauth/token")]
    System.Threading.Tasks.Task<FeishuResponse<Auth.Spec.PostAuthenV2OauthTokenResponseDto>> PostAuthenV2OauthTokenAsync(
        [JsonContent] Auth.Spec.PostAuthenV2OauthTokenBodyDto dto);

    /// <summary>
    /// 获取长连接地址
    /// </summary>
    /// <param name="dto">请求体</param>
    [HttpPost("/callback/ws/endpoint")]
    System.Threading.Tasks.Task<FeishuResponse<Auth.Spec.PostCallbackWsEndpointResponseDto>> PostCallbackWsEndpointAsync(
        [JsonContent] Auth.Spec.PostCallbackWsEndpointBodyDto dto);
}

