using Newtonsoft.Json;
namespace FeishuNetSdk.Im.Spec;
/// <summary>
/// 发送仅特定人可见的消息卡片 响应体
/// <para>用于机器人在群会话中发送仅指定用户可见的消息卡片。卡片上将展示"仅对你可见"标识。<br></para>
/// <para>![image.png](//sf3-cn.feishucdn.com/obj/open-platform-opendoc/b0ec0ce45942463381457edc7b62e144_RXYCFtfUtb.png?lazyload=true&width=1592&height=486)</para>
/// <para>接口ID：6907569523177078785</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-card/send-message-cards-that-are-only-visible-to-certain-people</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuETOyYjLxkjM24SM5IjN</para>
/// </summary>
public record PostEphemeralV1SendResponseDto
{
    /// <summary>
    /// <para>消息 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("message_id")]
    public string? MessageId { get; set; }
}
