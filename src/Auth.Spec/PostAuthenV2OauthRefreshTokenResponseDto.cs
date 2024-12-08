// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="PostAuthenV2OauthRefreshTokenResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>刷新 user_access_token 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Auth.Spec;
/// <summary>
/// 刷新 user_access_token 响应体
/// <para>OAuth 令牌接口，可用于刷新 &lt;code&gt;user_access_token&lt;/code&gt; 以及获取新的 &lt;code&gt;refresh_token&lt;/code&gt;。</para>
/// <para>接口ID：7435312925587898371</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/authentication-management/access-token/refresh-user-access-token</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fauthentication-management%2faccess-token%2frefresh-user-access-token</para>
/// </summary>
public record PostAuthenV2OauthRefreshTokenResponseDto
{
    /// <summary>
    /// <para>错误码，为 0 时表明请求成功，非 0 表示失败，请参照下文错误码一节妥善处理</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// <para>即 `user_access_token`，仅在请求成功时返回</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("access_token")]
    public string? AccessToken { get; set; }

    /// <summary>
    /// <para>即 `user_access_token` 的有效期，单位为秒，仅在请求成功时返回</para>
    /// <para>建议使用该字段以确定 `user_access_token` 的过期时间，不要硬编码有效期</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("expires_in")]
    public int? ExpiresIn { get; set; }

    /// <summary>
    /// <para>用于刷新 `user_access_token`，该字段仅在请求成功且用户授予 `offline_access` 权限时返回：</para>
    /// <para>- offline_access : 离线访问已授权数据</para>
    /// <para>如果你在获取 `user_access_token` 时设置了 `scope` 请求参数，且需要返回 `refresh_token`，则需要在 `scope` 参数中包括 `offline_access`。另外，`refresh_token` 仅能被使用一次。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("refresh_token")]
    public string? RefreshToken { get; set; }

    /// <summary>
    /// <para>即 `refresh_token` 的有效期，单位为秒，仅在返回 `refresh_token` 时返回</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("refresh_token_expires_in")]
    public int? RefreshTokenExpiresIn { get; set; }

    /// <summary>
    /// <para>值固定为 `Bearer`，仅在请求成功时返回</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("token_type")]
    public string? TokenType { get; set; }

    /// <summary>
    /// <para>本次请求所获得的 `access_token` 所具备的权限列表，以空格分隔，仅在请求成功时返回</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>
    /// <para>错误类型，仅在请求失败时返回</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    /// <summary>
    /// <para>具体的错误信息，仅在请求失败时返回</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("error_description")]
    public string? ErrorDescription { get; set; }
}
