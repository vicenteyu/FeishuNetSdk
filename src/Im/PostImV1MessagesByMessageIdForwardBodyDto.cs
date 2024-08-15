// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1MessagesByMessageIdForwardBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>转发消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 转发消息 请求体
/// <para>调用该接口将一条指定的消息转发给用户、群聊或话题。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- 向用户转发消息时，用户需要在机器人的[可用范围](https://open.feishu.cn/document/home/introduction-to-scope-and-authorization/availability)内。</para>
/// <para>- 向群组转发消息时，机器人需要在该群组中，且拥有发言权限。</para>
/// <para>## 使用限制</para>
/// <para>- 不支持转发红包、投票、语音、日程转让、系统消息、加密消息类型。</para>
/// <para>- 不支持二次转发 **合并转发消息中的子消息**（即含有`upper_message_id`字段的消息）。</para>
/// <para>- 为避免消息发送频繁对用户造成打扰，向同一用户发送消息的限频为 ==5 QPS==、向同一群组发送消息的限频为群内机器人共享 ==5 QPS==。</para>
/// <para>接口ID：7210967154035621891</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/forward</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fforward</para>
/// </summary>
public record PostImV1MessagesByMessageIdForwardBodyDto
{
    /// <summary>
    /// <para>消息接收者 ID，ID 类型与 `receive_id_type` 的值一致。</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_a0553eda9014c201e6969b478895c230</para>
    /// </summary>
    [JsonPropertyName("receive_id")]
    public string ReceiveId { get; set; } = string.Empty;
}
