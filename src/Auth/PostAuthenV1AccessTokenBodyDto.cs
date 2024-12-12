// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAuthenV1AccessTokenBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取 user_access_token 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Auth;
/// <summary>
/// 获取 user_access_token 请求体
/// <para>根据[登录预授权码](https://open.feishu.cn/document/ukTMukTMukTM/ukzN4UjL5cDO14SO3gTN) code 获取 `user_access_token`。</para>
/// <para>接口ID：7180265937329553412</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/access-token/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fauthen-v1%2faccess_token%2fcreate</para>
/// </summary>
public record PostAuthenV1AccessTokenBodyDto
{
    /// <summary>
    /// <para>授权类型，**固定值**：</para>
    /// <para>必填：是</para>
    /// <para>示例值：authorization_code</para>
    /// </summary>
    [JsonPropertyName("grant_type")]
    public string GrantType { get; } = "authorization_code";

    /// <summary>
    /// <para>登录预授权码，调用[获取登录预授权码](https://open.feishu.cn/document/ukTMukTMukTM/ukzN4UjL5cDO14SO3gTN)接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：xMSldislSkdK</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; } = string.Empty;
}
