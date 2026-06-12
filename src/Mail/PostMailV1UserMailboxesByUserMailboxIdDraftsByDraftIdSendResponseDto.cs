// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="PostMailV1UserMailboxesByUserMailboxIdDraftsByDraftIdSendResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发送草稿 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 发送草稿 响应体
/// <para>发送指定草稿，并生成对应的已发送邮件和邮件会话。适用于在创建或更新草稿后触发实际发送，发送成功后返回已发送邮件 ID 和所属会话 ID。</para>
/// <para>接口ID：7620478754624424892</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-draft/send</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-draft%2fsend</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdDraftsByDraftIdSendResponseDto
{
    /// <summary>
    /// <para>发送后生成的已发送邮件ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：197c5d72e22e1d79</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }

    /// <summary>
    /// <para>邮件所属会话ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：197c5d72e22e1d78</para>
    /// </summary>
    [JsonPropertyName("thread_id")]
    public string? ThreadId { get; set; }
}
