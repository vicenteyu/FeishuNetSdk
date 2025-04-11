// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="PostAuthenV2OauthTokenBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取 user_access_token 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Auth.Spec;
/// <summary>
/// 获取 user_access_token 请求体
/// <para>OAuth 令牌接口，可用于获取 &lt;code&gt;user_access_token&lt;/code&gt; 以及 &lt;code&gt;refresh_token&lt;/code&gt;。&lt;code&gt;user_access_token&lt;/code&gt; 为用户访问凭证，使用该凭证可以以用户身份调用 OpenAPI。&lt;code&gt;refresh_token&lt;/code&gt; 为刷新凭证，可以用来获取新的 &lt;code&gt;user_access_token&lt;/code&gt;。</para>
/// <para>接口ID：7435312925587914755</para>
/// <para>文档地址：https://open.feishu.cn/document/authentication-management/access-token/get-user-access-token</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fauthentication-management%2faccess-token%2fget-user-access-token</para>
/// </summary>
public record PostAuthenV2OauthTokenBodyDto
{
    /// <summary>
    /// <para>授权类型。</para>
    /// <para>**固定值：**`authorization_code`</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("grant_type")]
    public string GrantType { get; } = "authorization_code";

    /// <summary>
    /// <para>应用的 App ID。应用凭证 App ID 和 App Secret 获取方式：</para>
    /// <para>1. 登录[飞书开发者后台](https://open.feishu.cn/app)。</para>
    /// <para>2. 进入应用详情页，在左侧导航栏，单击 **凭证与基础信息**。</para>
    /// <para>3. 在 **应用凭证** 区域，获取并保存 **App ID** 和 **App Secret**。</para>
    /// <para>**示例值：**`cli_a5ca35a685b0x26e`</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("client_id")]
    public string ClientId { get; set; } = string.Empty;

    /// <summary>
    /// <para>应用的 App Secret。应用凭证 App ID 和 App Secret 获取方式：</para>
    /// <para>1. 登录[飞书开发者后台](https://open.feishu.cn/app)。</para>
    /// <para>2. 进入应用详情页，在左侧导航栏，单击 **凭证与基础信息**。</para>
    /// <para>3. 在 **应用凭证** 区域，获取并保存 **App ID** 和 **App Secret**。</para>
    /// <para>**示例值：**`baBqE5um9LbFGDy3X7LcfxQX1sqpXlwy`</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("client_secret")]
    public string ClientSecret { get; set; } = string.Empty;

    /// <summary>
    /// <para>授权码，详见[获取授权码](https://open.feishu.cn/document/common-capabilities/sso/api/obtain-oauth-code)。</para>
    /// <para>**示例值：**`a61hb967bd094dge949h79bbexd16dfe`</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; } = string.Empty;

    /// <summary>
    /// <para>在构造授权页页面链接时所拼接的应用回调地址。</para>
    /// <para>网页应用授权场景必填，且需要**严格**与获取授权码时设置的 `redirect_uri` 保持一致，小程序授权场景无需传递</para>
    /// <para>**示例值：**`https://example.com/api/oauth/callback`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("redirect_uri")]
    public string? RedirectUri { get; set; }

    /// <summary>
    /// <para>在发起授权前，本地生成的随机字符串，用于 PKCE（Proof Key for Code Exchange）流程。使用 PKCE 时，该值为必填项。</para>
    /// <para>有关 PKCE 的详细介绍，请参阅 [RFC 7636 - Proof Key for Code Exchange by OAuth Public Clients](https://datatracker.ietf.org/doc/html/rfc7636)。</para>
    /// <para>**长度限制：** 最短 43 字符，最长 128 字符</para>
    /// <para>**可用字符集：** [A-Z] / [a-z] / [0-9] / "-" / "." / "_" / "~"</para>
    /// <para>**示例值：**`TxYmzM4PHLBlqm5NtnCmwxMH8mFlRWl_ipie3O0aVzo`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("code_verifier")]
    public string? CodeVerifier { get; set; }

    /// <summary>
    /// <para>用于缩减 `user_access_token` 的权限范围。如果未指定，生成的 `user_access_token` 将包含用户授权时的所有权限。请务必注意该列表中不得包含重复项（错误码 20067）以及未授权项（错误码 20068）。</para>
    /// <para>**说明**：</para>
    /// <para>- 多次调用当前接口缩减不同的权限不会叠加。例如，第一调用该接口缩减了权限 A，则 `user_access_token` 不包含权限 A；第二次调用该接口缩减了权限 B，则 `user_access_token` 不包含权限 B。</para>
    /// <para>- 生效的权限列表可通过本接口返回值 scope 查看。</para>
    /// <para>**格式要求：** 以空格分隔的 `scope` 列表</para>
    /// <para>**示例值：**`auth:user.id:read task:task:read`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}
