using Newtonsoft.Json;
namespace FeishuNetSdk.Im;
/// <summary>
/// 获取群分享链接 请求体
/// <para>获取指定群的分享链接。</para>
/// <para>接口ID：7139929321426386972</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/link</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat%2flink</para>
/// </summary>
public record PostImV1ChatsByChatIdLinkBodyDto
{
    /// <summary>
    /// <para>群分享链接有效时长，可选值week、year、permanently，分别表示7天、1年以及永久有效</para>
    /// <para>必填：否</para>
    /// <para>示例值：week</para>
    /// <para>可选值：<list type="bullet">
    /// <item>week：有效期7天</item>
    /// <item>year：有效期1年</item>
    /// <item>permanently：永久有效</item>
    /// </list></para>
    /// <para>默认值：week</para>
    /// </summary>
    [JsonProperty("validity_period")]
    public string? ValidityPeriod { get; set; }
}
