// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="PostAuthenV2OauthRefreshTokenBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>刷新 user_access_token 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Auth.Spec;
/// <summary>
/// 刷新 user_access_token 请求体
/// <para>OAuth 令牌接口，可用于刷新 &lt;code&gt;user_access_token&lt;/code&gt; 以及获取新的 &lt;code&gt;refresh_token&lt;/code&gt;。</para>
/// <para>接口ID：7435312925587898371</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/authentication-management/access-token/refresh-user-access-token</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fauthentication-management%2faccess-token%2frefresh-user-access-token</para>
/// </summary>
public record PostAuthenV2OauthRefreshTokenBodyDto
{
    /// <summary>
    /// <para>授权类型。</para>
    /// <para>**固定值：**`refresh_token`</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("grant_type")]
    public string GrantType { get; } = "refresh_token";

    /// <summary>
    /// <para>应用的 App ID，可以在开发者后台中的应用详情页面找到该值。</para>
    /// <para>**示例值：**`cli_a5ca35a685b0x26e`</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("client_id")]
    public string ClientId { get; set; } = string.Empty;

    /// <summary>
    /// <para>应用的 App Secret，可以在开发者后台中的应用详情页面找到该值，详见：[如何获取应用的 App ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-app-id)。</para>
    /// <para>**示例值：**`baBqE5um9LbFGDy3X7LcfxQX1sqpXlwy`</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("client_secret")]
    public string ClientSecret { get; set; } = string.Empty;

    /// <summary>
    /// <para>刷新令牌，用于刷新 `user_access_token` 以及 `refresh_token`。</para>
    /// <para>请务必注意本接口仅支持[获取 user_access_token](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/authentication-management/access-token/get-user-access-token)和[刷新 user_access_token](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/authentication-management/access-token/refresh-user-access-token)接口返回的 `refresh_token`</para>
    /// <para>**示例值：**`eyJhbGciOiJFUzI1NiIs**********XXOYOZz1mfgIYHwM8ZJA`</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("refresh_token")]
    public string RefreshToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>用于缩减 `user_access_token` 的权限范围。如果未指定，生成的 `user_access_token` 将包含用户授权时的所有权限。请务必注意该列表中不得包含重复项以及未授权项。</para>
    /// <para>**说明**：多次调用当前接口缩减不同的权限不会叠加。例如，第一调用该接口缩减了权限 A，则 `user_access_token` 不包含权限 A；第二次调用该接口缩减了权限 B，则 `user_access_token` 不包含权限 B。</para>
    /// <para>**格式要求：** 以空格分隔的 `scope` 列表</para>
    /// <para>**示例值：**`auth:user.id:read task:task:read`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}
