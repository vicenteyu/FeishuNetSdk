// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalV1MessageUpdateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新审批 Bot 消息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 更新审批 Bot 消息 响应体
/// <para>调用[发送审批 Bot 消息](https://open.feishu.cn/document/ukTMukTMukTM/ugDNyYjL4QjM24CO0IjN)接口后，可根据审批 Bot 消息 ID 及审批相应的状态，更新审批 Bot 消息。例如，给审批人推送了审批待办消息，当审批人通过审批后，可以将之前推送的 Bot 消息更新为已审批。</para>
/// <para>使用限制：</para>
/// <para>- 只能更新审批状态，以及审批同意或拒绝后的标题或者查看详情的文案。</para>
/// <para>- 只能更新模板为 1008「收到审批待办」的卡片。</para>
/// <para>- 只支持更新 30 天以内的审批 bot 消息。</para>
/// <para>接口ID：6907569743419752450</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/message/update-bot-messages</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuAjNyYjLwYjM24CM2IjN</para>
/// </summary>
public record PostApprovalV1MessageUpdateResponseDto
{
    /// <summary>
    /// <para>消息 ID，用于继续更新审批 Bot 消息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }
}
