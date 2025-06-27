// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAuthenV1OidcRefreshAccessTokenResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>刷新 user_access_token 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Auth;
/// <summary>
/// 刷新 user_access_token 响应体
/// <para>本接口已成为历史版本，不推荐使用。请使用最新版本：[刷新 user_access_token ](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/authentication-management/access-token/refresh-user-access-token)</para>
/// <para>。</para>
/// <para>user_access_token 的最大有效期是 2小时左右。当 user_access_token 过期时，可以调用本接口获取新的 user_access_token。</para>
/// <para>接口ID：7277403063290707996</para>
/// <para>文档地址：https://open.feishu.cn/document/historic-version/authen/create-4</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fauthen-v1%2foidc-refresh_access_token%2fcreate</para>
/// </summary>
public record PostAuthenV1OidcRefreshAccessTokenResponseDto
{
    /// <summary>
    /// <para>字段`access_token`即user_access_token，用于获取用户资源和访问某些open api</para>
    /// <para>必填：是</para>
    /// <para>示例值：u-5Dak9ZAxJ9tFUn8MaTD_BFM51FNdg5xzO0y010000HWb</para>
    /// </summary>
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>刷新 user_access_token时使用的 refresh_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：ur-6EyFQZyplb9URrOx5NtT_HM53zrJg59HXwy040400G.e</para>
    /// </summary>
    [JsonPropertyName("refresh_token")]
    public string? RefreshToken { get; set; }

    /// <summary>
    /// <para>token 类型，固定值</para>
    /// <para>必填：是</para>
    /// <para>示例值：Bearer</para>
    /// </summary>
    [JsonPropertyName("token_type")]
    public string TokenType { get; set; } = string.Empty;

    /// <summary>
    /// <para>user_access_token有效期，单位: 秒，有效时间两个小时左右，需要以返回结果为准</para>
    /// <para>必填：否</para>
    /// <para>示例值：7199</para>
    /// <para>最大值：2147483647</para>
    /// <para>最小值：0</para>
    /// </summary>
    [JsonPropertyName("expires_in")]
    public int? ExpiresIn { get; set; }

    /// <summary>
    /// <para>refresh_token有效期，单位: 秒，一般是30天左右，需要以返回结果为准</para>
    /// <para>必填：否</para>
    /// <para>示例值：2591999</para>
    /// <para>最大值：2147483647</para>
    /// <para>最小值：0</para>
    /// </summary>
    [JsonPropertyName("refresh_expires_in")]
    public int? RefreshExpiresIn { get; set; }

    /// <summary>
    /// <para>用户授予app的权限全集</para>
    /// <para>必填：否</para>
    /// <para>示例值：auth:user.id:read bitable:app</para>
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}
