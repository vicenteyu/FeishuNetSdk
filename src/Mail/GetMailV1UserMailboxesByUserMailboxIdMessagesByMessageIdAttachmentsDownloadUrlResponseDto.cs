// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-04-11
//
// Last Modified By : yxr
// Last Modified On : 2025-04-11
// ************************************************************************
// <copyright file="GetMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdAttachmentsDownloadUrlResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取附件下载链接 响应体小组件访问数据</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 获取附件下载链接 响应体
/// <para>获取附件下载链接</para>
/// <para>接口ID：7296319822873657346</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-message/user_mailbox-message-attachment/download_url</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-message-attachment%2fdownload_url</para>
/// </summary>
public record GetMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdAttachmentsDownloadUrlResponseDto
{
    /// <summary>
    /// <para>下载链接列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("download_urls")]
    public AttachmentDownloadUrlItem[]? DownloadUrls { get; set; }

    /// <summary>
    /// <para>下载链接列表</para>
    /// </summary>
    public record AttachmentDownloadUrlItem
    {
        /// <summary>
        /// <para>附件 id</para>
        /// <para>必填：否</para>
        /// <para>示例值：YQqYbQHoQoDqXjxWKhJbo8Gicjf</para>
        /// </summary>
        [JsonPropertyName("attachment_id")]
        public string? AttachmentId { get; set; }

        /// <summary>
        /// <para>下载链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://api-drive-stream.blmpb.com/space/api/box/stream/download/authcode/?code=YTZiZGViMDg3NzRjMzEwOWRkMGI1MTJlYmQxYTFmYTBfZTA5ZjZiOWU4NDYzMzkxMDUyOTIxMzBmNTVjMjAyZTFfSUQ6NzI4MTE4Nzg1OTE5NTc3Mjk0N18xNjk1ODg4NjQyOjE2OTU4ODg3MDJfVjM</para>
        /// </summary>
        [JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }
    }

    /// <summary>
    /// <para>获取失败的附件 id 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("failed_ids")]
    public string[]? FailedIds { get; set; }
}
