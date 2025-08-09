// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-10
//
// Last Modified By : yxr
// Last Modified On : 2025-08-10
// ************************************************************************
// <copyright file="PostMailV1UserMailboxesByUserMailboxIdMessagesSendResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发送邮件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 发送邮件 响应体
/// <para>发送邮件</para>
/// <para>接口ID：7205136193486356481</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/user_mailbox-message/send</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-message%2fsend</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdMessagesSendResponseDto
{
    /// <summary>
    /// <para>邮件ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：48451e97-4743-4a55-a9a3-b5c656b69c05</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }

    /// <summary>
    /// <para>会话ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：14151e97-4743-4a55-a9a3-b5c656b69c05</para>
    /// </summary>
    [JsonPropertyName("thread_id")]
    public string? ThreadId { get; set; }
}
