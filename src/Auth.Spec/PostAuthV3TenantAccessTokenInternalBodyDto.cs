// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2026-10-17
// ************************************************************************
// <copyright file="PostAuthV3TenantAccessTokenInternalBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>自建应用获取 tenant_access_token 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Auth.Spec;
/// <summary>
/// 自建应用获取 tenant_access_token 请求体
/// <para>本接口已成为历史版本，不推荐使用。请使用最新版本：[自建应用获取 tenant_access_token](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/authentication-management/access-token/tenant_access_token)</para>
/// <para>接口ID：6995779366223724548</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/access-token/tenant_access_token_internal</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukDNz4SO0MjL5QzM%2fauth-v3%2fauth%2ftenant_access_token_internal</para>
/// </summary>
public record PostAuthV3TenantAccessTokenInternalBodyDto
{
    /// <summary>
    /// <para>应用唯一标识，创建应用后获得。有关`app_id` 的详细介绍。请参考[通用参数](https://open.feishu.cn/document/ukTMukTMukTM/uYTM5UjL2ETO14iNxkTN/terminology)介绍</para>
    /// <para>**示例值：** "cli_slkdjalasdkjasd"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("app_id")]
    public string AppId { get; set; } = string.Empty;

    /// <summary>
    /// <para>应用秘钥，创建应用后获得。有关 `app_secret` 的详细介绍，请参考[通用参数](https://open.feishu.cn/document/ukTMukTMukTM/uYTM5UjL2ETO14iNxkTN/terminology)介绍</para>
    /// <para>**示例值：** "dskLLdkasdjlasdKK"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("app_secret")]
    public string AppSecret { get; set; } = string.Empty;
}
