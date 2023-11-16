namespace FeishuNetSdk.Im;
/// <summary>
/// 更新应用发送的消息卡片 请求体
/// <para>更新应用已发送的消息卡片内容。</para>
/// <para>接口ID：6946222931479543809</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-card/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fpatch</para>
/// </summary>
public record PatchImV1MessagesByMessageIdBodyDto
{
    /// <summary>
    /// <para>消息内容 json 格式，[发送消息 content 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/im-v1/message/create_json)，参考文档中的卡片格式</para>
    /// <para>必填：是</para>
    /// <para>示例值：参考链接</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;
}
