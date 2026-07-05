// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-05
//
// Last Modified By : yxr
// Last Modified On : 2026-07-05
// ************************************************************************
// <copyright file="PostOAuthV1RevokeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>撤销 user_access_token或refresh_token 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Auth.Spec;
/// <summary>
/// 撤销 user_access_token或refresh_token 响应体
/// <para>OAuth 令牌接口，可用于撤销 &lt;code&gt;user_access_token&lt;/code&gt; 或 &lt;code&gt;refresh_token&lt;/code&gt;。</para>
/// <para>接口ID：7649652220288208063</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/authentication-management/login-state-management/revoke-token</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fauthentication-management%2flogin-state-management%2frevoke-token</para>
/// </summary>
public record PostOAuthV1RevokeResponseDto
{
    /// <summary>
    /// <para>错误码，仅在请求失败时返回</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>
    /// <para>错误类型，仅在请求失败时返回</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    /// <summary>
    /// <para>具体错误信息，仅在请求失败时返回</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("error_description")]
    public string? ErrorDescription { get; set; }
}
