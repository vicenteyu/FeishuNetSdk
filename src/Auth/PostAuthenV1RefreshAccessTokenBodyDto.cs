// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAuthenV1RefreshAccessTokenBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>刷新 user_access_token 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Auth;
/// <summary>
/// 刷新 user_access_token 请求体
/// <para>user_access_token 的最大有效期是 2小时左右。当 user_access_token 过期时，可以调用本接口获取新的 user_access_token。</para>
/// <para>接口ID：7180265937329520644</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/access-token/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fauthen-v1%2frefresh_access_token%2fcreate</para>
/// </summary>
public record PostAuthenV1RefreshAccessTokenBodyDto
{
    /// <summary>
    /// <para>授权类型，**固定值**</para>
    /// <para>必填：是</para>
    /// <para>示例值：refresh_token</para>
    /// </summary>
    [JsonPropertyName("grant_type")]
    public string GrantType { get; } = "refresh_token";

    /// <summary>
    /// <para>刷新和获取user_access_token接口均返回 `refresh_token`，**每次请求，请注意使用最新获取到的`refresh_token`**</para>
    /// <para>必填：是</para>
    /// <para>示例值：ur-oQ0mMq6MCcueAv0pwx2fQQhxqv__CbLu6G8ySFwafeKww2Def2BJdOkW3.9gCFM.LBQgFri901QaqeuL</para>
    /// </summary>
    [JsonPropertyName("refresh_token")]
    public string RefreshToken { get; set; } = string.Empty;
}
