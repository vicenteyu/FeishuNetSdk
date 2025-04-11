// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-04-11
//
// Last Modified By : yxr
// Last Modified On : 2025-04-11
// ************************************************************************
// <copyright file="GetMailV1UserMailboxesByUserMailboxIdEventSubscriptionResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取订阅状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 获取订阅状态 响应体
/// <para>获取订阅状态</para>
/// <para>接口ID：7275929163676237827</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-event/subscription</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-event%2fsubscription</para>
/// </summary>
public record GetMailV1UserMailboxesByUserMailboxIdEventSubscriptionResponseDto
{
    /// <summary>
    /// <para>订阅的事件列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("event_types")]
    public int[]? EventTypes { get; set; }
}
