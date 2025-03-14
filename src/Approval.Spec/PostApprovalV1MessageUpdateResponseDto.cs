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
/// <para>此接口可以根据审批bot消息id及相应状态，更新相应的审批bot消息，只能更新审批状态，以及审批同意/拒绝后的标题或者查看详情的文案。例如，给用户推送了审批待办消息，当用户处理该消息后，可以将之前推送的Bot消息更新为已审批。</para>
/// <para>**注意：该接口只能更新模板为 1008「收到审批待办」的卡片。**</para>
/// <para>接口ID：6907569743419752450</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/message/update-bot-messages</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuAjNyYjLwYjM24CM2IjN</para>
/// </summary>
public record PostApprovalV1MessageUpdateResponseDto
{
    /// <summary>
    /// <para>消息 id ，用于卡片更新、撤回</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string MessageId { get; set; } = string.Empty;
}
