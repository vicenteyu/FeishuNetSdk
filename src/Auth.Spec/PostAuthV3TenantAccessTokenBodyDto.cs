// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAuthV3TenantAccessTokenBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>商店应用获取 tenant_access_token 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Auth.Spec;
/// <summary>
/// 商店应用获取 tenant_access_token 请求体
/// <para>商店应用通过此接口获取`tenant_access_token`。</para>
/// <para>**说明** **：** `tenant_access_token` 的最大有效期是 2 小时。如果在有效期小于 30 分钟的情况下，调用本接口，会返回一个新的 `tenant_access_token`，这会同时存在两个有效的 `tenant_access_token`。</para>
/// <para>接口ID：6995779366223740932</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/access-token/tenant_access_token</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukDNz4SO0MjL5QzM%2fauth-v3%2fauth%2ftenant_access_token</para>
/// </summary>
public record PostAuthV3TenantAccessTokenBodyDto
{
    /// <summary>
    /// <para>应用访问凭证，通过[商店应用获取 app_access_token](https://open.feishu.cn/document/ukTMukTMukTM/ukDNz4SO0MjL5QzM/auth-v3/auth/app_access_token)接口获取</para>
    /// <para>**示例值：** "a-32bd8551db2f081cbfd26293f27516390b9feb04"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("app_access_token")]
    public string AppAccessToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>租户在飞书上的唯一标识，也可以理解为企业标识</para>
    /// <para>可以通过如下方式获取：</para>
    /// <para>- 企业开通应用时，开放平台推送给应用，具体可参考[首次启用应用](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v6/event/app-first-enabled)</para>
    /// <para>- 用户登录到小程序、H5 应用或者浏览器应用时，在用户的身份信息中获取</para>
    /// <para>**示例值**："73658811060f175d"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("tenant_key")]
    public string TenantKey { get; set; } = string.Empty;
}
