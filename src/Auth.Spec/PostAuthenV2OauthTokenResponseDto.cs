// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2026-07-05
// ************************************************************************
// <copyright file="PostAuthenV2OauthTokenResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取 user_access_token（v2 版本） 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Auth.Spec;
/// <summary>
/// 获取 user_access_token（v2 版本） 响应体
/// <para>本接口已成为历史版本，不推荐使用。请使用最新版本：[获取 user_access_token ](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/authentication-management/access-token/get-user-access-token-v3)。</para>
/// <para>迁移到 v3 时，主要关注以下变化：</para>
/// <para>- 令牌端点由 `https://open.feishu.cn/open-apis/authen/v2/oauth/token` 变更为 `https://accounts.feishu.cn/oauth/v3/token`。</para>
/// <para>- 新增 v3 的一个重要原因，是修正 v2 在 PKCE 校验上的兼容性问题：如果授权阶段未传递 `code_challenge`，但换取 token 时传递了 `code_verifier`，v2 不会拒绝该请求；v3 会按 PKCE 语义拒绝这类请求。</para>
/// <para>- `code_verifier` 的使用方式与 v2 保持一致：未启用 PKCE 时可继续不传；已启用且正确使用 PKCE 时，可沿用现有 `code_verifier` 生成和传递逻辑直接迁移到 v3。</para>
/// <para>- 除上述差异外，请求参数和响应结构与 v2 保持一致。迁移时，需要切换接口地址，并确认 `client_secret`、`code_verifier` 的传参方式符合 v3 要求。</para>
/// <para>如果你当前没有启用 PKCE，或者已经正确使用 PKCE，可以直接迁移到 v3；如果你当前存在“未传 `code_challenge`，但传了 `code_verifier`”的情况，则需要先修正 PKCE 参数传递逻辑后再迁移。</para>
/// <para>接口ID：7435312925587914755</para>
/// <para>文档地址：https://open.feishu.cn/document/authentication-management/access-token/get-user-access-token</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fauthentication-management%2faccess-token%2fget-user-access-token</para>
/// </summary>
public record PostAuthenV2OauthTokenResponseDto
{
    /// <summary>
    /// <para>错误码，为 0 时表明请求成功，非 0 表示失败，请参照下文[错误码](#错误码)一节进行相应处理</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

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
    /// <para>用于刷新 `user_access_token`，详见[刷新 user_access_token](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/authentication-management/access-token/refresh-user-access-token)。该字段仅在请求成功且用户授予 `offline_access` 权限时返回。</para>
    /// <para>`refresh_token` 仅能被使用一次。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("refresh_token")]
    public string? RefreshToken { get; set; }

    /// <summary>
    /// <para>即 `refresh_token` 的有效期，单位为秒，仅在返回 `refresh_token` 时返回。</para>
    /// <para>建议在到期前调用[刷新 user_access_token](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/authentication-management/access-token/refresh-user-access-token) 接口获取新的 `refresh_token`。</para>
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
    /// <para>本次请求所获得的 `access_token` 实际具备的权限列表，以空格分隔。服务端会根据情况对申请的 scope 进行裁剪，最终实际授予的权限范围请以该字段为准。该字段仅在请求成功时返回。</para>
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
