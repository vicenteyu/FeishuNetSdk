// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1MessagesByMessageIdReplyBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>回复消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 回复消息 请求体
/// <para>调用该接口回复指定消息。回复的内容支持文本、富文本、卡片、群名片、个人名片、图片、视频、文件等多种类型。</para>
/// <para>接口ID：6946222929790500892</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/reply</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2freply</para>
/// </summary>
public record PostImV1MessagesByMessageIdReplyBodyDto
{
    /// <summary>
    /// <para>消息内容，JSON 结构序列化后的字符串。该参数的取值与 `msg_type` 对应，例如 `msg_type` 取值为 `text`，则该参数需要传入文本类型的内容。</para>
    /// <para>**注意：**</para>
    /// <para>- JSON 字符串需进行转义。例如，换行符 `\n` 转义后为 `\\n`。</para>
    /// <para>- 文本消息请求体最大不能超过 150 KB。</para>
    /// <para>- 卡片消息、富文本消息请求体最大不能超过 30 KB。</para>
    /// <para>- 如果使用卡片模板（template_id）发送消息，实际大小也包含模板对应的卡片数据大小。</para>
    /// <para>- 如果消息中包含样式标签，会使实际消息体长度大于您输入的请求体长度。</para>
    /// <para>- 图片需要先[上传图片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/image/create)，然后使用图片的 Key 发消息。</para>
    /// <para>- 音频、视频、文件需要先[上传文件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/file/create)，然后使用文件的 Key 发消息。</para>
    /// <para>了解不同类型的消息内容格式、使用限制，可参见[发送消息内容](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/im-v1/message/create_json)。</para>
    /// <para>必填：是</para>
    /// <para>示例值：`{\"text\":\"test content\"}`</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// <para>消息类型。</para>
    /// <para>**可选值有**：</para>
    /// <para>- text：文本</para>
    /// <para>- post：富文本</para>
    /// <para>- image：图片</para>
    /// <para>- file：文件</para>
    /// <para>- audio：语音</para>
    /// <para>- media：视频</para>
    /// <para>- sticker：表情包</para>
    /// <para>- interactive：卡片</para>
    /// <para>- share_card：分享群名片</para>
    /// <para>- share_user：分享个人名片</para>
    /// <para>不同消息类型的详细介绍，参见[发送消息内容](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/im-v1/message/create_json)。</para>
    /// <para>必填：是</para>
    /// <para>示例值：text</para>
    /// </summary>
    [JsonPropertyName("msg_type")]
    public string MsgType { get; set; } = string.Empty;

    /// <summary>
    /// <para>是否以话题形式回复。取值为 true 时将以话题形式回复。</para>
    /// <para>**注意**：如果要回复的消息已经是话题形式的消息，则默认以话题形式进行回复。</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("reply_in_thread")]
    public bool? ReplyInThread { get; set; }

    /// <summary>
    /// <para>自定义设置的唯一字符串序列，用于在回复消息时请求去重。不填则表示不去重。持有相同 uuid 的请求，在 1 小时内至多成功回复一条消息。</para>
    /// <para>**注意**：你可以参考示例值自定义参数值。当回复的内容不同时，如果传入了该参数，则需要在每次请求时都更换该参数的取值。</para>
    /// <para>必填：否</para>
    /// <para>示例值：选填，每次调用前请更换，如a0d69e20-1dd1-458b-k525-dfeca4015204</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}
