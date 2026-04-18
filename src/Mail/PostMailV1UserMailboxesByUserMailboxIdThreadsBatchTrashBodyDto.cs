// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="PostMailV1UserMailboxesByUserMailboxIdThreadsBatchTrashBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量删除邮件会话 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 批量删除邮件会话 请求体
/// <para>批量将指定的邮件会话移入已删除文件夹</para>
/// <para>接口ID：7626215228942912468</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-thread/batch_trash</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-thread%2fbatch_trash</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdThreadsBatchTrashBodyDto
{
    /// <summary>
    /// <para>邮箱会话ID，可通过列出邮件会话接口获取</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("thread_ids")]
    public string[]? ThreadIds { get; set; }
}
