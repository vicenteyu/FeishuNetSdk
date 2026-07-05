// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-05
//
// Last Modified By : yxr
// Last Modified On : 2026-07-05
// ************************************************************************
// <copyright file="PostOAuthV1RevokeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>撤销 user_access_token或refresh_token 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Auth.Spec;
/// <summary>
/// 撤销 user_access_token或refresh_token 请求体
/// <para>OAuth 令牌接口，可用于撤销 &lt;code&gt;user_access_token&lt;/code&gt; 或 &lt;code&gt;refresh_token&lt;/code&gt;。</para>
/// <para>接口ID：7649652220288208063</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/authentication-management/login-state-management/revoke-token</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fauthentication-management%2flogin-state-management%2frevoke-token</para>
/// </summary>
public record PostOAuthV1RevokeBodyDto
{
    /// <summary>
    /// <para>需要撤销的 token，支持传入 `user_access_token` 或 `refresh_token`。</para>
    /// <para>- 当 `token` 参数传入 `user_access_token` 时，仅当前 `user_access_token` 失效；若对应的 `refresh_token` 仍有效，可继续通过[刷新 user_access_token](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/authentication-management/access-token/refresh-user-access-token)获取新的 `user_access_token`。</para>
    /// <para>- 当 `token` 参数传入 `refresh_token` 时，会使当前授权关系下的刷新能力失效。此时如需重新获取访问凭证，请重新走[获取 user_access_token](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/authentication-management/access-token/get-user-access-token)流程。</para>
    /// <para>**示例值：**`eyJhbGciOiJFUzI1NiIs**********XXOYOZz1mfgIYHwM8ZJA`</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("token")]
    public string Token { get; set; } = string.Empty;

    /// <summary>
    /// <para>应用的 App ID。仅当你选择在请求体中传递客户端凭证，而不是使用 `HTTP Basic Authorization` 时需要提供。应用凭证 App ID 和 App Secret 获取方式：</para>
    /// <para>1. 登录[飞书开发者后台](https://open.feishu.cn/app)。</para>
    /// <para>2. 进入应用详情页，在左侧导航栏，单击 **凭证与基础信息**。</para>
    /// <para>3. 在 **应用凭证** 区域，获取并保存 **App ID** 和 **App Secret**。</para>
    /// <para>**示例值：**`cli_a5ca35a685b0x26e`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("client_id")]
    public string? ClientId { get; set; }

    /// <summary>
    /// <para>应用的 App Secret。仅当你选择在请求体中传递客户端凭证，而不是使用 `HTTP Basic Authorization` 时需要提供。应用凭证 App ID 和 App Secret 获取方式：</para>
    /// <para>1. 登录[飞书开发者后台](https://open.feishu.cn/app)。</para>
    /// <para>2. 进入应用详情页，在左侧导航栏，单击 **凭证与基础信息**。</para>
    /// <para>3. 在 **应用凭证** 区域，获取并保存 **App ID** 和 **App Secret**。</para>
    /// <para>**示例值：**`baBqE5um9LbF*************1sqpXlwy`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("client_secret")]
    public string? ClientSecret { get; set; }

    /// <summary>
    /// <para>token 类型提示参数，用于帮助服务端更快定位 token 类型。</para>
    /// <para>仅用于提示 `token` 参数传入的是 `user_access_token` 还是 `refresh_token`；服务端会基于 `token` 参数的实际内容自动识别类型。</para>
    /// <para>**可选值：**</para>
    /// <para>- `access_token`：表示传入的 `token` 预期为 `user_access_token`</para>
    /// <para>- `refresh_token`：表示传入的 `token` 预期为 `refresh_token`</para>
    /// <para>**注意：**</para>
    /// <para>- 当前参数仅作提示使用，不会影响服务端最终采用的撤销维度。</para>
    /// <para>- 如果不传该参数，服务端会自动识别 token 类型。</para>
    /// <para>- 如果传入除 `access_token`、`refresh_token` 外的其他值，接口会报错。</para>
    /// <para>**示例值：**`refresh_token`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("token_type_hint")]
    public string? TokenTypeHint { get; set; }
}
