// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1MessagesMergeForwardBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>合并转发消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 合并转发消息 请求体
/// <para>将来自同一个会话内的多条消息，合并转发给指定的用户、群聊或话题。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)</para>
/// <para>- 向用户合并转发消息时，用户需要在机器人的[可用范围](https://open.feishu.cn/document/home/introduction-to-scope-and-authorization/availability)内。</para>
/// <para>- 向群组合并转发消息，机器人需要在该群组中，且拥有发言权限。</para>
/// <para>- 合并转发生成的新消息的消息内容为固定值==Merged and Forwarded Message==，其中的子消息可以使用[获取指定消息的内容](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/get)接口获取。</para>
/// <para>## 使用限制</para>
/// <para>- 不支持合并转发[系统消息（system）](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/im-v1/message/create_json#e159cb73)。</para>
/// <para>- 不支持合并转发来自不同群聊的消息。</para>
/// <para>- 不支持同时合并转发来自多个话题中的消息。</para>
/// <para>- 不支持同时合并转发普通消息与话题中的消息。</para>
/// <para>- 不支持再次合并转发 **合并转发消息中的子消息**（含有==upper_message_id==字段的消息）。</para>
/// <para>- 为避免消息发送频繁对用户造成打扰，向同一用户发送消息的限频为 ==5 QPS==、向同一群组发送消息的限频为群内机器人共享 ==5 QPS==。</para>
/// <para>接口ID：7210967154035638275</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/merge_forward</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fmerge_forward</para>
/// </summary>
public record PostImV1MessagesMergeForwardBodyDto
{
    /// <summary>
    /// <para>消息接收者 ID，ID 类型与 `receive_id_type` 的值一致。</para>
    /// <para>必填：是</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </summary>
    [JsonPropertyName("receive_id")]
    public string ReceiveId { get; set; } = string.Empty;

    /// <summary>
    /// <para>待转发的消息 ID 列表，列表内的消息必须来自同一个会话。ID 获取方式：</para>
    /// <para>- 调用[发送消息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/create)接口后，从响应结果的 `message_id` 参数获取。</para>
    /// <para>- 监听[接收消息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/events/receive)事件，当触发该事件后可以从事件体内获取消息的 `message_id`。</para>
    /// <para>- 调用[获取会话历史消息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/list)接口，从响应结果的 `message_id` 参数获取。</para>
    /// <para>必填：是</para>
    /// <para>示例值：["om_d862083dd13b61cc009e66c40a0f0a56", "om_61244dab1ef11257621dcd7g0e256651"]</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("message_id_list")]
    public string[] MessageIdList { get; set; } = [];
}
