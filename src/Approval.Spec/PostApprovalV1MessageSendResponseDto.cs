// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalV1MessageSendResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发送审批 Bot 消息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 发送审批 Bot 消息 响应体
/// <para>此接口可以用来通过飞书审批的 Bot 推送消息给用户，当有新的审批待办，或者审批待办的状态有更新时，可以通过飞书审批的 Bot 告知用户。如果出现推送成功，但是没有收到消息，可能是因为开通了审批机器人的聚合推送。</para>
/// <para>接口ID：6907569742384906242</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/message/send-bot-messages</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugDNyYjL4QjM24CO0IjN</para>
/// </summary>
public record PostApprovalV1MessageSendResponseDto
{
    /// <summary>
    /// <para>消息 ID，用于[更新审批 Bot 消息](https://open.feishu.cn/document/ukTMukTMukTM/uAjNyYjLwYjM24CM2IjN)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }
}
