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
/// <para>文档地址：https://open.feishu.cn/document/authentication-management/access-token/refresh-user-access-token</para>
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
    /// <para>该参数用于缩减 `user_access_token` 的权限范围。</para>
    /// <para>例如：</para>
    /// <para>1. 在[获取授权码](https://open.feishu.cn/document/common-capabilities/sso/api/obtain-oauth-code)时通过 `scope` 参数授权了 `contact:user.base:readonly contact:contact.base:readonly contact:user.employee:readonly` 三个权限。</para>
    /// <para>2. 在当前接口可通过 `scope` 参数传入 `contact:user.base:readonly`，将 `user_access_token` 的权限缩减为 `contact:user.base:readonly` 这一个。</para>
    /// <para>**注意**：</para>
    /// <para>- 如果不指定当前参数，生成的 `user_access_token` 将包含用户授权时的所有权限。</para>
    /// <para>- 当前参数不能传入重复的权限，否则会接口调用会报错，返回错误码 20067。</para>
    /// <para>- 当前参数不能传入未授权的权限（即[获取授权码](https://open.feishu.cn/document/common-capabilities/sso/api/obtain-oauth-code)时用户已授权范围外的其他权限），否则接口调用会报错，返回错误码 20068。</para>
    /// <para>- 多次调用当前接口缩减权限的范围不会叠加。例如，用户授予了权限 A 和 B，第一次调用该接口缩减为权限 A，则 `user_access_token` 只包含权限 A；第二次调用该接口缩减为权限 B，则 `user_access_token` 只包含权限 B。</para>
    /// <para>- 生效的权限列表可通过本接口返回值 scope 查看。</para>
    /// <para>**格式要求：** 以空格分隔的 `scope` 列表</para>
    /// <para>**示例值：**`auth:user.id:read task:task:read`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}
