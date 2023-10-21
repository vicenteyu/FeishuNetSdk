using Newtonsoft.Json;
namespace FeishuNetSdk.Event.Spec;
/// <summary>
/// 获取事件出口 IP 响应体
/// <para>飞书开放平台向应用配置的回调地址推送事件时，是通过特定的 IP 发送出去的，应用可以通过本接口获取所有相关的 IP 地址。</para>
/// <para>接口ID：7083805115594227714</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/event-subscription-guide/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYDNxYjL2QTM24iN0EjN%2fevent-v1%2foutbound_ip%2flist</para>
/// </summary>
public record GetEventV1OutboundIpResponseDto
{
    /// <summary>
    /// <para>outbound ip</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("ip_list")]
    public string[]? IpList { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }
}
