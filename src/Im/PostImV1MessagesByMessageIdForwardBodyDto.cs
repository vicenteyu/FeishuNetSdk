using Newtonsoft.Json;
namespace FeishuNetSdk.Im;
/// <summary>
/// 转发消息 请求体
/// <para>向一个用户或群聊转发一条指定消息。</para>
/// <para>接口ID：7210967154035621891</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/forward</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fforward</para>
/// </summary>
public record PostImV1MessagesByMessageIdForwardBodyDto
{
    /// <summary>
    /// <para>依据`receive_id_type`的值，填写对应的转发目标的ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_a0553eda9014c201e6969b478895c230</para>
    /// </summary>
    [JsonProperty("receive_id")]
    public string ReceiveId { get; set; } = string.Empty;
}
