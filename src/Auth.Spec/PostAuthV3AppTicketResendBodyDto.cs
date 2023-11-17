namespace FeishuNetSdk.Auth.Spec;
/// <summary>
/// 重新获取 app_ticket 请求体
/// <para>飞书开放平台每隔 1 小时会给应用推送一次最新的 `app_ticket`，应用也可以主动调用此接口，触发飞书开放平台进行即时推送。</para>
/// <para>接口ID：6995779366223757316</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/access-token/app_ticket_resend</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukDNz4SO0MjL5QzM%2fauth-v3%2fauth%2fapp_ticket_resend</para>
/// </summary>
public record PostAuthV3AppTicketResendBodyDto
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
