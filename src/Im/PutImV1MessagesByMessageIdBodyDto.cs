using Newtonsoft.Json;
namespace FeishuNetSdk.Im;
/// <summary>
/// 编辑消息 请求体
/// <para>编辑已发送的消息内容，当前支持编辑文本、富文本消息。如需更新消息卡片，请参考[更新应用发送的消息卡片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/patch)。</para>
/// <para>接口ID：7239186075281358852</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fupdate</para>
/// </summary>
public record PutImV1MessagesByMessageIdBodyDto
{
    /// <summary>
    /// <para>消息的类型，当前仅支持文本（text）和富文本（post）类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：text</para>
    /// </summary>
    [JsonProperty("msg_type")]
    public string MsgType { get; set; } = string.Empty;

    /// <summary>
    /// <para>消息内容，JSON结构序列化后的字符串。不同msg_type对应不同内容，具体格式说明参考：[发送消息Content](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/im-v1/message/create_json)</para>
    /// <para>**注意：**</para>
    /// <para>- JSON字符串需进行转义，如换行符转义后为`\\n`</para>
    /// <para>- 文本消息请求体最大不能超过150KB</para>
    /// <para>- 富文本消息请求体最大不能超过30KB</para>
    /// <para>必填：是</para>
    /// <para>示例值：{\"text\":\"testcontent\"}</para>
    /// </summary>
    [JsonProperty("content")]
    public string Content { get; set; } = string.Empty;
}
