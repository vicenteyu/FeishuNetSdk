using FeishuNetSdk.Attributes;
using Newtonsoft.Json;
using WebApiClientCore;
using WebApiClientCore.Attributes;
using WebApiClientCore.Parameters;

namespace FeishuNetSdk;
/// <summary>
/// 获取应用访问凭证（AccessToken）的接口
/// </summary>
[IgnoreStatusExceptionFilter, LoggingFilter]
[HttpHost("https://open.feishu.cn/"), JsonNetReturn]
public interface IFeishuApi : IHttpApi
{
    /// <summary>
    /// <para>【身份验证】自建应用获取 tenant_access_token</para>
    /// <para>接口ID：6995779366223724548</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ukDNz4SO0MjL5QzM/auth-v3/auth/tenant_access_token_internal</para>
    /// <para>自建应用通过此接口获取 `tenant_access_token`。</para>
    /// <para>**说明：** `tenant_access_token` 的最大有效期是 2 小时。如果在有效期小于 30 分钟的情况下，调用本接口，会返回一个新的 `tenant_access_token`，这会同时存在两个有效的 `tenant_access_token`。</para>
    /// </summary>
    [HttpPost("/open-apis/auth/v3/tenant_access_token/internal")]
    System.Threading.Tasks.Task<Auth.Spec.PostAuthV3TenantAccessTokenInternalResponseDto> PostAuthV3TenantAccessTokenInternalAsync(
        [JsonNetContent] Auth.Spec.PostAuthV3TenantAccessTokenInternalBodyDto dto);

    /// <summary>
    /// <para>【身份验证】自建应用获取 app_access_token</para>
    /// <para>接口ID：6995779366223822852</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ukDNz4SO0MjL5QzM/auth-v3/auth/app_access_token_internal</para>
    /// <para>自建应用通过此接口获取`app_access_token`。</para>
    /// <para>**说明：** `app_access_token` 的最大有效期是 2 小时。如果在有效期小于 30 分钟的情况下，调用本接口，会返回一个新的 `app_access_token`，这会同时存在两个有效的 `app_access_token`。</para>
    /// </summary>
    [HttpPost("/open-apis/auth/v3/app_access_token/internal")]
    System.Threading.Tasks.Task<Auth.Spec.PostAuthV3AppAccessTokenInternalResponseDto> PostAuthV3AppAccessTokenInternalAsync(
        [JsonNetContent] Auth.Spec.PostAuthV3AppAccessTokenInternalBodyDto dto);

    /// <summary>
    /// <para>【身份验证】商店应用获取 app_access_token</para>
    /// <para>接口ID：6995779366223708164</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ukDNz4SO0MjL5QzM/auth-v3/auth/app_access_token</para>
    /// <para>商店应用通过此接口获取`app_access_token`。</para>
    /// <para>**说明：** `app_access_token` 的最大有效期是 2 小时。如果在有效期小于 30 分钟的情况下，调用本接口，会返回一个新的 `app_access_token`，这会同时存在两个有效的 `app_access_token`。</para>
    /// </summary>
    [HttpPost("/open-apis/auth/v3/app_access_token")]
    System.Threading.Tasks.Task<Auth.Spec.PostAuthV3AppAccessTokenResponseDto> PostAuthV3AppAccessTokenAsync(
        [JsonNetContent] Auth.Spec.PostAuthV3AppAccessTokenBodyDto dto);

    /// <summary>
    /// <para>【身份验证】商店应用获取 tenant_access_token</para>
    /// <para>接口ID：6995779366223740932</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ukDNz4SO0MjL5QzM/auth-v3/auth/tenant_access_token</para>
    /// <para>商店应用通过此接口获取`tenant_access_token`。</para>
    /// <para>**说明** **：** `tenant_access_token` 的最大有效期是 2 小时。如果在有效期小于 30 分钟的情况下，调用本接口，会返回一个新的 `tenant_access_token`，这会同时存在两个有效的 `tenant_access_token`。</para>
    /// </summary>
    [HttpPost("/open-apis/auth/v3/tenant_access_token")]
    System.Threading.Tasks.Task<Auth.Spec.PostAuthV3TenantAccessTokenResponseDto> PostAuthV3TenantAccessTokenAsync(
        [JsonNetContent] Auth.Spec.PostAuthV3TenantAccessTokenBodyDto dto);

    /// <summary>
    /// <para>【身份验证】重新获取 app_ticket</para>
    /// <para>接口ID：6995779366223757316</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ukDNz4SO0MjL5QzM/auth-v3/auth/app_ticket_resend</para>
    /// <para>飞书开放平台每隔 1 小时会给应用推送一次最新的 `app_ticket`，应用也可以主动调用此接口，触发飞书开放平台进行即时推送。</para>
    /// </summary>
    [HttpPost("/open-apis/auth/v3/app_ticket/resend")]
    System.Threading.Tasks.Task<FeishuResponse> PostAuthV3AppTicketResendAsync(
        [JsonNetContent] Auth.Spec.PostAuthV3AppTicketResendBodyDto dto);

    /// <summary>
    /// <para>【身份验证】获取登录预授权码</para>
    /// <para>接口ID：6907569744329932801</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ukzN4UjL5cDO14SO3gTN</para>
    /// <para>调用本接口获取用户的登录预授权码 code。登录预授权码的有效期是 5 分钟，且只能被使用一次。</para>
    /// <para>**说明**：本接口适用于用户登录网页应用场景。当用户在飞书内打开网页应用时，会跳转到飞书登录界面，用户授权后，会自动跳转到重定向 URL，并携带飞书开放平台返回的登录预授权码 code。有关重定向 URL 的详细介绍，请参考[获取 user_access_token](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/authen-v1/access_token/create)。</para>
    /// </summary>
    /// <param name="redirect_uri">
    /// <para>必填：是</para>
    /// <para>重定向 URL，需要经过 Encode 处理</para>
    /// <para>1. 重定向 URL 使用于网页应用。可以在开发者后台，**应用功能 > 网页** 页面启用网页功能，并配置桌面端主页和移动端主页</para>
    /// <para>2. 调用本接口前，需要在开发者后台的 **安全设置** 页面，配置重定向 URL，支持配置多个。只有在重定向 URL 列表中的 URL 才会通过开放平台的安全校验</para>
    /// </param>
    /// <param name="app_id">
    /// <para>必填：是</para>
    /// <para>应用 ID，可以在开发者后台的 **凭证与基础信息** 页面查看 `app_id`。有关 `app_id` 的详细介绍，请参考[通用参数](https://open.feishu.cn/document/ukTMukTMukTM/uYTM5UjL2ETO14iNxkTN/terminology)</para>
    /// </param>
    /// <param name="state">
    /// <para>必填：否</para>
    /// <para>用来维护请求和回调状态的附加字符串， 在授权完成回调时会附加此参数，应用可以根据此字符串来判断上下文关系</para>
    /// </param>
    [HttpGet("/open-apis/authen/v1/index?redirect_uri={REDIRECT_URI}&amp;app_id={APPID}&amp;state={STATE}")]
    System.Threading.Tasks.Task<FeishuResponse<Authen.Spec.GetAuthenV1IndexResponseDto>> GetAuthenV1IndexAsync(
        [PathQuery] string redirect_uri,
        [PathQuery] string app_id,
        [PathQuery] string? state);
}

