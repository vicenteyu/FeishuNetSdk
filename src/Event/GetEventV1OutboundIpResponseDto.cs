namespace FeishuNetSdk.Event;
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
    /// <para>示例值：1.1.1.1</para>
    /// </summary>
    [JsonPropertyName("ip_list")]
    public string[]? IpList { get; set; }

    /// <summary>
    /// <para>分页下次调用的page_token值</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxx</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有分页数据</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
