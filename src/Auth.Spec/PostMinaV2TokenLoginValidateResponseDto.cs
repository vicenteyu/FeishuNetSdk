// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostMinaV2TokenLoginValidateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取 user_access_token（小程序） 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Auth.Spec;
/// <summary>
/// 获取 user_access_token（小程序） 响应体
/// <para>通过 [login](https://open.feishu.cn/document/uYjL24iN/uYzMuYzMuYzM)接口获取到登录凭证`code`后，开发者可以通过服务器发送请求的方式获取 session_key 和 用户凭证信息。</para>
/// <para>本接口适用于 [小程序登录](https://open.feishu.cn/document/uYjL24iN/uETO5QjLxkTO04SM5kDN) 及[小组件登录](https://open.feishu.cn/document/uAjLw4CM/uYjL24iN/block/guide/open-ability/block-login)。</para>
/// <para>接口ID：6907569745298817026</para>
/// <para>文档地址：https://open.feishu.cn/document/client-docs/gadget/-web-app-api/open-ability/login/code2session</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuYjL24iN%2fukjM04SOyQjL5IDN</para>
/// </summary>
public record PostMinaV2TokenLoginValidateResponseDto
{
    /// <summary>
    /// <para>用户的[Open ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)，用于在同一个应用中对用户进行标识</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("open_id")]
    public string? OpenId { get; set; }

    /// <summary>
    /// <para>用户的[User ID](https://open.feishu.cn/document/home/user-identity-introduction/user-id)，在职员工在企业内的唯一标识</para>
    /// <para>**仅当开通以下权限后 返回该字段**：</para>
    /// <para>- contact:user.employee_id:readonly : 获取用户 user ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employee_id")]
    public string? EmployeeId { get; set; }

    /// <summary>
    /// <para>会话密钥</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("session_key")]
    public string? SessionKey { get; set; }

    /// <summary>
    /// <para>用户所在企业唯一标识</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tenant_key")]
    public string? TenantKey { get; set; }

    /// <summary>
    /// <para>[user_access_token](https://open.feishu.cn/document/ukTMukTMukTM/uMTNz4yM1MjLzUzM)，用户身份访问凭证</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("access_token")]
    public string? AccessToken { get; set; }

    /// <summary>
    /// <para>[user_access_token](https://open.feishu.cn/document/ukTMukTMukTM/uMTNz4yM1MjLzUzM)过期时间戳</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("expires_in")]
    public int? ExpiresIn { get; set; }

    /// <summary>
    /// <para>刷新用户 access_token 时使用的 token，过期时间为30天。刷新access_token 接口说明请查看[文档](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/authen-v1/authen/refresh_access_token)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("refresh_token")]
    public string? RefreshToken { get; set; }
}
