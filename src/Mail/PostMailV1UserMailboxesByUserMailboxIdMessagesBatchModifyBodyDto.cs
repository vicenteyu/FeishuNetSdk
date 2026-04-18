// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="PostMailV1UserMailboxesByUserMailboxIdMessagesBatchModifyBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量修改邮件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 批量修改邮件 请求体
/// <para>批量修改邮件标签、所属文件夹、已读未读状态，可进行加旗标、归档、移至垃圾邮件等操作。不支持移入邮件进入已删除文件夹，如需，请使用批量删除邮件接口。</para>
/// <para>接口ID：7626215228942879700</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-message/batch_modify</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-message%2fbatch_modify</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdMessagesBatchModifyBodyDto
{
    /// <summary>
    /// <para>需要修改的邮件ID，可通过列出邮件接口、收信事件通知等方式获得</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("message_ids")]
    public string[]? MessageIds { get; set; }

    /// <summary>
    /// <para>待添加的标签。可选值包括：UNREAD、IMPORTANT、OTHER、FLAGGED，以及自定义标签 ID。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("add_label_ids")]
    public string[]? AddLabelIds { get; set; }

    /// <summary>
    /// <para>待移除的标签。可选值包括：UNREAD、IMPORTANT、OTHER、FLAGGED，以及自定义标签 ID。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("remove_label_ids")]
    public string[]? RemoveLabelIds { get; set; }

    /// <summary>
    /// <para>需要移入的文件夹。支持INBOX、SENT、SPAM、ARCHIVED以及自定义文件夹ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：INBOX</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("add_folder")]
    public string? AddFolder { get; set; }
}
