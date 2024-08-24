// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1MessagesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发送消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 发送消息 请求体
/// <para>调用该接口向指定用户或者群聊发送消息。支持发送的消息类型包括文本、富文本、卡片、群名片、个人名片、图片、视频、音频、文件以及表情包等。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- 给用户发送消息时，用户需要在机器人的[可用范围](https://open.feishu.cn/document/home/introduction-to-scope-and-authorization/availability)内。</para>
/// <para>- 给群组发送消息时，机器人需要在该群组中，且在群组内拥有发言权限。</para>
/// <para>## 使用限制</para>
/// <para>- 为避免消息发送频繁对用户造成打扰，向同一用户发送消息的限频为 ==5 QPS==、向同一群组发送消息的限频为群内机器人共享 ==5 QPS==。</para>
/// <para>- 该接口仅支持在开发者后台创建的应用机器人调用，群自定义机器人无法调用该接口。了解群自定义机器人的使用方式，参见[自定义机器人使用指南](https://open.feishu.cn/document/ukTMukTMukTM/ucTM5YjL3ETO24yNxkjN)。</para>
/// <para>接口ID：6946222931479527425</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fcreate</para>
/// </summary>
public record PostImV1MessagesBodyDto
{
    /// <summary>
    /// <para>消息接收者的 ID，ID 类型与查询参数 `receive_id_type` 的取值一致。</para>
    /// <para>**注意事项**：</para>
    /// <para>- 给用户发送消息时，用户需要在机器人的[可用范围](https://open.feishu.cn/document/home/introduction-to-scope-and-authorization/availability)内。例如，你需要给企业全员发送消息，则需要将应用的可用范围设置为全体员工。</para>
    /// <para>- 给群组发送消息时，机器人需要在该群组中，且在群组内拥有发言权限。</para>
    /// <para>- 如果消息接收者为用户，推荐使用用户的 `open_id`。</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_7d8a6e6df7621556ce0d21922b676706ccs</para>
    /// </summary>
    [JsonPropertyName("receive_id")]
    public string ReceiveId { get; set; } = string.Empty;

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
    /// <para>- share_chat：分享群名片</para>
    /// <para>- share_user：分享个人名片</para>
    /// <para>- system：系统消息</para>
    /// <para>不同消息类型的详细介绍，参见[发送消息内容](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/im-v1/message/create_json)。</para>
    /// <para>必填：是</para>
    /// <para>示例值：text</para>
    /// </summary>
    [JsonPropertyName("msg_type")]
    public string MsgType { get; set; } = string.Empty;

    /// <summary>
    /// <para>消息内容，JSON 结构序列化后的字符串。该参数的取值与 `msg_type` 对应，例如 `msg_type` 取值为 `text`，则该参数需要传入文本类型的内容。</para>
    /// <para>**注意：**</para>
    /// <para>- JSON 字符串需进行转义。例如，换行符 `\n` 转义后为 `\\n`。</para>
    /// <para>- 文本消息请求体最大不能超过 150 KB。</para>
    /// <para>- 卡片消息、富文本消息请求体最大不能超过 30 KB。</para>
    /// <para>- 如果使用卡片模板（template_id）发送消息，实际大小也包含模板对应的卡片数据大小。</para>
    /// <para>- 如果消息中包含样式标签，会使实际消息体长度大于您输入的请求体长度。</para>
    /// <para>- 图片需要先[上传图片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/image/create)，然后使用图片的 Key 发消息。</para>
    /// <para>- 音频、视频、文件需要先[上传文件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/file/create)，然后使用文件的 Key 发消息。注意不能使用云文档[上传素材](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_all)接口返回的 file_token。</para>
    /// <para>了解不同类型的消息内容格式、使用限制，可参见[发送消息内容](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/im-v1/message/create_json)。</para>
    /// <para>必填：是</para>
    /// <para>示例值：{\"text\":\"test content\"}</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// <para>自定义设置的唯一字符串序列，用于在发送消息时请求去重。持有相同 uuid 的请求，在 1 小时内至多成功发送一条消息。</para>
    /// <para>**注意**：你可以参考示例值自定义参数值。当发送不同的消息内容时，如果传入了该参数，则需要在每次请求时都更换该参数的取值。</para>
    /// <para>必填：否</para>
    /// <para>示例值：选填，每次调用前请更换，如a0d69e20-1dd1-458b-k525-dfeca4015204</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}
