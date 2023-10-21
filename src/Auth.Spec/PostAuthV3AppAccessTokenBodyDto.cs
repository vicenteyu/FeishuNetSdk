using Newtonsoft.Json;
namespace FeishuNetSdk.Auth.Spec;
/// <summary>
/// 商店应用获取 app_access_token 请求体
/// <para>商店应用通过此接口获取`app_access_token`。</para>
/// <para>**说明：** `app_access_token` 的最大有效期是 2 小时。如果在有效期小于 30 分钟的情况下，调用本接口，会返回一个新的 `app_access_token`，这会同时存在两个有效的 `app_access_token`。</para>
/// <para>接口ID：6995779366223708164</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/access-token/app_access_token</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukDNz4SO0MjL5QzM%2fauth-v3%2fauth%2fapp_access_token</para>
/// </summary>
public record PostAuthV3AppAccessTokenBodyDto
{
    /// <summary>
    /// <para>应用唯一标识，创建应用后获得。有关`app_id` 的详细介绍。请参考[通用参数](https://open.feishu.cn/document/ukTMukTMukTM/uYTM5UjL2ETO14iNxkTN/terminology)介绍</para>
    /// <para>**示例值：** "cli_slkdjalasdkjasd"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("app_id")]
    public string AppId { get; set; } = string.Empty;

    /// <summary>
    /// <para>应用秘钥，创建应用后获得。有关 `app_secret` 的详细介绍，请参考[通用参数](https://open.feishu.cn/document/ukTMukTMukTM/uYTM5UjL2ETO14iNxkTN/terminology)介绍</para>
    /// <para>**示例值：** "dskLLdkasdjlasdKK"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("app_secret")]
    public string AppSecret { get; set; } = string.Empty;

    /// <summary>
    /// <para>平台定时推送给应用的临时凭证，通过事件监听机制获得。有关 `app_ticket` 的详细介绍，请参考[通用参数](https://open.feishu.cn/document/ukTMukTMukTM/uYTM5UjL2ETO14iNxkTN/terminology)</para>
    /// <para>**示例值：** "dskLLdkasd"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("app_ticket")]
    public string AppTicket { get; set; } = string.Empty;
}
