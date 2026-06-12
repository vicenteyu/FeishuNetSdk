// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="PutMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdModifyBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>修改邮件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 修改邮件 请求体
/// <para>修改邮件标签、所属文件夹、已读未读状态，可为邮件添加旗标、归档、移入垃圾邮件等操作。不支持移动邮件到已删除文件夹，如需，请使用删除邮件接口。</para>
/// <para>接口ID：7626215228942945236</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-message/modify</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-message%2fmodify</para>
/// </summary>
public record PutMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdModifyBodyDto
{
    /// <summary>
    /// <para>待添加的标签 ID 列表。可选值包括 UNREAD、IMPORTANT、OTHER、FLAGGED，以及自定义标签 ID。该参数与 remove_label_ids、add_folder 均为可选且可组合；与 remove_label_ids 同时设置时，会在同一次请求中分别添加和移除对应标签，请勿在两个列表中传入同一标签 ID。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("add_label_ids")]
    public string[]? AddLabelIds { get; set; }

    /// <summary>
    /// <para>待移除的标签 ID 列表。可选值包括 UNREAD、IMPORTANT、OTHER、FLAGGED，以及自定义标签 ID。该参数与 add_label_ids、add_folder 均为可选且可组合；与 add_label_ids 同时设置时，会在同一次请求中分别移除和添加对应标签，请勿在两个列表中传入同一标签 ID。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("remove_label_ids")]
    public string[]? RemoveLabelIds { get; set; }

    /// <summary>
    /// <para>需要移入的文件夹 ID。支持 INBOX、SENT、SPAM、ARCHIVED 以及自定义文件夹 ID。该参数与 add_label_ids、remove_label_ids 均为可选且可组合；设置后会在同一次请求中将邮件移动到指定文件夹，若仅需调整标签可不传该字段。</para>
    /// <para>必填：否</para>
    /// <para>示例值：INBOX</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("add_folder")]
    public string? AddFolder { get; set; }
}
