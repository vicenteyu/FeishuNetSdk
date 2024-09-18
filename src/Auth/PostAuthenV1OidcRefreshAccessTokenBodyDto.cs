// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAuthenV1OidcRefreshAccessTokenBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>刷新 user_access_token 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Auth;
/// <summary>
/// 刷新 user_access_token 请求体
/// <para>user_access_token 的最大有效期是 2小时左右。当 user_access_token 过期时，可以调用本接口获取新的 user_access_token。</para>
/// <para>接口ID：7277403063290707996</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/authen-v1/oidc-refresh_access_token/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fauthen-v1%2foidc-refresh_access_token%2fcreate</para>
/// </summary>
public record PostAuthenV1OidcRefreshAccessTokenBodyDto
{
    /// <summary>
    /// <para>授权类型，**固定值**：</para>
    /// <para>必填：是</para>
    /// <para>示例值：refresh_token</para>
    /// </summary>
    [JsonPropertyName("grant_type")]
    public string GrantType { get; set; } = string.Empty;

    /// <summary>
    /// <para>刷新和获取user_access_token接口均返回 `refresh_token`，**每次请求，请注意使用最新获取到的`refresh_token`**</para>
    /// <para>必填：是</para>
    /// <para>示例值：ur-h4_5nUXdJ4O8rqfGe.YJCwM13Gjc557xUG20hkk00f7K</para>
    /// </summary>
    [JsonPropertyName("refresh_token")]
    public string RefreshToken { get; set; } = string.Empty;
}
