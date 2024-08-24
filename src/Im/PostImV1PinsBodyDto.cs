// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1PinsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>Pin 消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// Pin 消息 请求体
/// <para>Pin 一条指定的消息。Pin 消息的效果可参见[Pin 消息概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/pin/pin-overview)。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- Pin 消息时，机器人必须在消息所属的会话内。</para>
/// <para>## 使用限制</para>
/// <para>- 当前操作者不可见的消息无法 Pin。</para>
/// <para>- 对同一条消息的 Pin 操作不能超过 5 QPS。</para>
/// <para>## 注意事项</para>
/// <para>如果消息已经被 Pin，则该接口会返回该 Pin 的操作信息。</para>
/// <para>接口ID：7138313270488858626</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/pin/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fpin%2fcreate</para>
/// </summary>
public record PostImV1PinsBodyDto
{
    /// <summary>
    /// <para>待 Pin 的消息 ID。ID 获取方式：</para>
    /// <para>- 调用[发送消息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/create)接口后，从响应结果的 `message_id` 参数获取。</para>
    /// <para>- 监听[接收消息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/events/receive)事件，当触发该事件后可以从事件体内获取消息的 `message_id`。</para>
    /// <para>- 调用[获取会话历史消息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/list)接口，从响应结果的 `message_id` 参数获取。</para>
    /// <para>必填：是</para>
    /// <para>示例值：om_dc13264520392913993dd051dba21dcf</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string MessageId { get; set; } = string.Empty;
}
