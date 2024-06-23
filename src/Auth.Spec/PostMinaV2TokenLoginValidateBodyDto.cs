// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostMinaV2TokenLoginValidateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取 user_access_token（小程序） 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Auth.Spec;
/// <summary>
/// 获取 user_access_token（小程序） 请求体
/// <para>通过 [login](https://open.feishu.cn/document/uYjL24iN/uYzMuYzMuYzM)接口获取到登录凭证`code`后，开发者可以通过服务器发送请求的方式获取 session_key 和 用户凭证信息。</para>
/// <para>本接口适用于 [小程序登录](https://open.feishu.cn/document/uYjL24iN/uETO5QjLxkTO04SM5kDN) 及[小组件登录](https://open.feishu.cn/document/uAjLw4CM/uYjL24iN/block/guide/open-ability/block-login)。</para>
/// <para>接口ID：6907569745298817026</para>
/// <para>文档地址：https://open.feishu.cn/document/client-docs/gadget/-web-app-api/open-ability/login/code2session</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuYjL24iN%2fukjM04SOyQjL5IDN</para>
/// </summary>
public record PostMinaV2TokenLoginValidateBodyDto
{
    /// <summary>
    /// <para>[登录](https://open.feishu.cn/document/uYjL24iN/uYzMuYzMuYzM)时获取的 code</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; } = string.Empty;
}
