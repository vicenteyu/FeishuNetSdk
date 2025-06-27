// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAuthenV1OidcAccessTokenBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取 user_access_token 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Auth;
/// <summary>
/// 获取 user_access_token 请求体
/// <para>本接口已成为历史版本，不推荐使用。请使用最新版本：[获取 user_access_token ](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/authentication-management/access-token/get-user-access-token)</para>
/// <para>。</para>
/// <para>根据[登录预授权码](https://open.feishu.cn/document/common-capabilities/sso/api/obtain-oauth-code) 返回 code 获取 `user_access_token`。</para>
/// <para>接口ID：7277403063290724380</para>
/// <para>文档地址：https://open.feishu.cn/document/historic-version/authen/create-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fauthen-v1%2foidc-access_token%2fcreate</para>
/// </summary>
public record PostAuthenV1OidcAccessTokenBodyDto
{
    /// <summary>
    /// <para>授权类型，**固定值**</para>
    /// <para>必填：是</para>
    /// <para>示例值：authorization_code</para>
    /// </summary>
    [JsonPropertyName("grant_type")]
    public string GrantType { get; } = "authorization_code";

    /// <summary>
    /// <para>登录预授权码，调用[登录预授权码](https://open.feishu.cn/document/common-capabilities/sso/api/obtain-oauth-code) 获取code</para>
    /// <para>必填：是</para>
    /// <para>示例值：xMSldislSkdK</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; } = string.Empty;
}
