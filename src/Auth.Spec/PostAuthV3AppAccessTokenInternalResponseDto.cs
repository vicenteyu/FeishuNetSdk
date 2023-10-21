using Newtonsoft.Json;
namespace FeishuNetSdk.Auth.Spec;
/// <summary>
/// 自建应用获取 app_access_token 响应体
/// <para>自建应用通过此接口获取`app_access_token`。{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=auth&version=v3&resource=app_access_token&method=internal)</para>
/// <para>**说明：** `app_access_token` 的最大有效期是 2 小时。如果在有效期小于 30 分钟的情况下，调用本接口，会返回一个新的 `app_access_token`，这会同时存在两个有效的 `app_access_token`。</para>
/// <para>接口ID：6995779366223822852</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/access-token/app_access_token_internal</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukDNz4SO0MjL5QzM%2fauth-v3%2fauth%2fapp_access_token_internal</para>
/// </summary>
public record PostAuthV3AppAccessTokenInternalResponseDto
{
    /// <summary>
    /// <para>应用访问凭证</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("app_access_token")]
    public string AppAccessToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>`app_access_token` 的过期时间，单位为秒</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("expire")]
    public long Expire { get; set; }
}
