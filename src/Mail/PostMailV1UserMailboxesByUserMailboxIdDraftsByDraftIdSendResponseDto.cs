// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="PostMailV1UserMailboxesByUserMailboxIdDraftsByDraftIdSendResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发送草稿 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 发送草稿 响应体
/// <para>将指定的草稿发送出去</para>
/// <para>接口ID：7620478754624424892</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-draft/send</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-draft%2fsend</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdDraftsByDraftIdSendResponseDto
{
    /// <summary>
    /// <para>发送后生成的已发送邮件ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxxx</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }

    /// <summary>
    /// <para>邮件所属会话ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxxx</para>
    /// </summary>
    [JsonPropertyName("thread_id")]
    public string? ThreadId { get; set; }
}
