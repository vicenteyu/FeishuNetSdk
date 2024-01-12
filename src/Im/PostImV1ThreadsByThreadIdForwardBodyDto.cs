namespace FeishuNetSdk.Im;
/// <summary>
/// 转发话题 请求体
/// <para>向用户、群聊或话题转发一个话题。</para>
/// <para>接口ID：7322036039857700865</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/thread/forward</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fthread%2fforward</para>
/// </summary>
public record PostImV1ThreadsByThreadIdForwardBodyDto
{
    /// <summary>
    /// <para>依据receive_id_type的值，填写对应的转发目标的ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </summary>
    [JsonPropertyName("receive_id")]
    public string ReceiveId { get; set; } = string.Empty;
}
