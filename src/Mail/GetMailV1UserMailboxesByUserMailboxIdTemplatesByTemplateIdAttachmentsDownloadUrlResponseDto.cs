// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-11
//
// Last Modified By : yxr
// Last Modified On : 2026-05-11
// ************************************************************************
// <copyright file="GetMailV1UserMailboxesByUserMailboxIdTemplatesByTemplateIdAttachmentsDownloadUrlResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取模板附件下载链接 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 获取模板附件下载链接 响应体
/// <para>获取指定邮件模板下的附件下载链接。用于在已知模板 ID 与附件 ID 的场景下，二次获取附件的有效访问 URL，便于在用户端预览或下载邮件模板中的附件资源。</para>
/// <para>接口ID：7636620599011888079</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-template/download_url</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-template%2fdownload_url</para>
/// </summary>
public record GetMailV1UserMailboxesByUserMailboxIdTemplatesByTemplateIdAttachmentsDownloadUrlResponseDto
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
        /// <para>示例值：https://api-drive-stream.feishu.cn/space/api/box/stream/download/authcode/?code=YTZiZGViMDg3NzRjMzEwOWRkMGI1MTJlYmQxYTFmYTBfZTA5ZjZiOWU4NDYzMzkxMDUyOTIxMzBmNTVjMjAyZTFfSUQ6NzI4MTE4Nzg1OTE5NTc3Mjk0N18xNjk1ODg4NjQyOjE2OTU4ODg3MDJfVjM</para>
        /// </summary>
        [JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }
    }

    /// <summary>
    /// <para>附件下载链接获取失败原因列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("failed_reasons")]
    public AttachmentDownloadFailedReason[]? FailedReasons { get; set; }

    /// <summary>
    /// <para>附件下载链接获取失败原因列表</para>
    /// </summary>
    public record AttachmentDownloadFailedReason
    {
        /// <summary>
        /// <para>附件 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：YQqYbQHoQoDqXjxWKhJbo8Gicjf</para>
        /// <para>最大长度：1024</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("attachment_id")]
        public string? AttachmentId { get; set; }

        /// <summary>
        /// <para>失败原因</para>
        /// <para>必填：否</para>
        /// <para>示例值：attachment_not_found</para>
        /// <para>最大长度：1024</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }
    }
}
