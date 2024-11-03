// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAuthV3TenantAccessTokenInternalResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>自建应用获取 tenant_access_token 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Auth.Spec;
/// <summary>
/// 自建应用获取 tenant_access_token 响应体
/// <para>自建应用通过此接口获取 `tenant_access_token`。</para>
/// <para>注意事项：</para>
/// <para>`tenant_access_token` 的最大有效期是 2 小时。</para>
/// <para>- 剩余有效期小于 30 分钟时，调用本接口会返回一个新的 `tenant_access_token`，这会同时存在两个有效的 `tenant_access_token`。</para>
/// <para>- 剩余有效期大于等于 30 分钟时，调用本接口会返回原有的 `tenant_access_token`。</para>
/// <para>接口ID：6995779366223724548</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/access-token/tenant_access_token_internal</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukDNz4SO0MjL5QzM%2fauth-v3%2fauth%2ftenant_access_token_internal</para>
/// </summary>
public record PostAuthV3TenantAccessTokenInternalResponseDto
{
    /// <summary>
    /// <para>错误码，非 0 取值表示失败</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>
    /// <para>错误描述</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("msg")]
    public string? Msg { get; set; }

    /// <summary>
    /// <para>租户访问凭证</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tenant_access_token")]
    public string TenantAccessToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>`tenant_access_token` 的过期时间，单位为秒</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("expire")]
    public long Expire { get; set; }
}
