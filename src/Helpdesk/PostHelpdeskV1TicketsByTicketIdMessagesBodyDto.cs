using Newtonsoft.Json;
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 发送工单消息 请求体
/// <para>该接口用于发送工单消息。</para>
/// <para>接口ID：6955768699895758850</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket-message/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket-message%2fcreate</para>
/// </summary>
public record PostHelpdeskV1TicketsByTicketIdMessagesBodyDto
{
    /// <summary>
    /// <para>消息类型；text：纯文本；post：富文本</para>
    /// <para>必填：是</para>
    /// <para>示例值：post</para>
    /// </summary>
    [JsonProperty("msg_type")]
    public string MsgType { get; set; } = string.Empty;

    /// <summary>
    /// <para>- 纯文本，参考[发送文本消息](https://open.feishu.cn/document/ukTMukTMukTM/uUjNz4SN2MjL1YzM)中的content；</para>
    /// <para>- 富文本，参考[发送富文本消息](https://open.feishu.cn/document/ukTMukTMukTM/uMDMxEjLzATMx4yMwETM)中的content</para>
    /// <para>必填：是</para>
    /// <para>示例值：{ "msg_type": "post", "content": { "post": { "zh_cn": { "title": "this is title", "content": [ [ { "tag": "text", "un_escape": true, "text": "第一行 :" }, { "tag": "a", "text": "超链接", "href": "http://www.feishu.cn" } ], [ { "tag": "text", "text": "第二行 :" }, { "tag": "text", "text": "文本测试" } ] ] } } } }</para>
    /// </summary>
    [JsonProperty("content")]
    public string Content { get; set; } = string.Empty;
}
