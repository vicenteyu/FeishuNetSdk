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
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ukDNz4SO0MjL5QzM/auth-v3/auth/app_access_token</para>
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
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ukDNz4SO0MjL5QzM/auth-v3/auth/tenant_access_token_internal</para>
    /// <para>自建应用通过此接口获取 `tenant_access_token`。</para>
    /// <para>**说明：** `tenant_access_token` 的最大有效期是 2 小时。如果在有效期小于 30 分钟的情况下，调用本接口，会返回一个新的 `tenant_access_token`，这会同时存在两个有效的 `tenant_access_token`。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    [HttpPost("/open-apis/auth/v3/tenant_access_token/internal")]
    System.Threading.Tasks.Task<Auth.Spec.PostAuthV3TenantAccessTokenInternalResponseDto> PostAuthV3TenantAccessTokenInternalAsync(
        [JsonContent] Auth.Spec.PostAuthV3TenantAccessTokenInternalBodyDto dto);

    /// <summary>
    /// <para>【身份验证】商店应用获取 tenant_access_token</para>
    /// <para>接口ID：6995779366223740932</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ukDNz4SO0MjL5QzM/auth-v3/auth/tenant_access_token</para>
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
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ukDNz4SO0MjL5QzM/auth-v3/auth/app_ticket_resend</para>
    /// <para>飞书开放平台每隔 1 小时会给应用推送一次最新的 `app_ticket`，应用也可以主动调用此接口，触发飞书开放平台进行即时推送。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    [HttpPost("/open-apis/auth/v3/app_ticket/resend")]
    System.Threading.Tasks.Task<FeishuResponse> PostAuthV3AppTicketResendAsync(
        [JsonContent] Auth.Spec.PostAuthV3AppTicketResendBodyDto dto);

    /// <summary>
    /// <para>【身份验证】自建应用获取 app_access_token</para>
    /// <para>接口ID：6995779366223822852</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ukDNz4SO0MjL5QzM/auth-v3/auth/app_access_token_internal</para>
    /// <para>自建应用通过此接口获取`app_access_token`。</para>
    /// <para>**说明：** `app_access_token` 的最大有效期是 2 小时。如果在有效期小于 30 分钟的情况下，调用本接口，会返回一个新的 `app_access_token`，这会同时存在两个有效的 `app_access_token`。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    [HttpPost("/open-apis/auth/v3/app_access_token/internal")]
    System.Threading.Tasks.Task<Auth.Spec.PostAuthV3AppAccessTokenInternalResponseDto> PostAuthV3AppAccessTokenInternalAsync(
        [JsonContent] Auth.Spec.PostAuthV3AppAccessTokenInternalBodyDto dto);
}

