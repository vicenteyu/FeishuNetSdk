// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-20
//
// Last Modified By : yxr
// Last Modified On : 2026-11-20
// ************************************************************************
// <copyright file="GetMailV1UserMailboxesByUserMailboxIdSettingsAutoReplyImagesDownloadUrlResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取自动回复图片下载链接 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 获取自动回复图片下载链接 响应体
/// <para>获取指定用户邮箱自动回复图片的临时下载链接。请先调用「获取自动回复」接口，从自动回复图片附件中获取 file_key，再调用本接口批量获取下载链接。</para>
/// <para>接口ID：7695747058687003861</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-setting/download_url_auto_reply_image</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-setting%2fdownload_url_auto_reply_image</para>
/// </summary>
public record GetMailV1UserMailboxesByUserMailboxIdSettingsAutoReplyImagesDownloadUrlResponseDto
{
    /// <summary>
    /// <para>下载链接列表。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("download_urls")]
    public AttachmentDownloadUrlItem[]? DownloadUrls { get; set; }

    /// <summary>
    /// <para>下载链接列表。</para>
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
    /// <para>下载链接获取失败原因列表。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("failed_reasons")]
    public AttachmentDownloadFailedReason[]? FailedReasons { get; set; }

    /// <summary>
    /// <para>下载链接获取失败原因列表。</para>
    /// </summary>
    public record AttachmentDownloadFailedReason
    {
        /// <summary>
        /// <para>附件 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ZQqYbQHoQoDqXjxWKhJbo8Gicjf</para>
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
