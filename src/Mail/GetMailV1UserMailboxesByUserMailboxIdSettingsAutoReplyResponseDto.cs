// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-20
//
// Last Modified By : yxr
// Last Modified On : 2026-11-20
// ************************************************************************
// <copyright file="GetMailV1UserMailboxesByUserMailboxIdSettingsAutoReplyResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取自动回复 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 获取自动回复 响应体
/// <para>获取指定用户邮箱的自动回复设置及回复内容。</para>
/// <para>接口ID：7695747058687036629</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-setting/get_auto_reply</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-setting%2fget_auto_reply</para>
/// </summary>
public record GetMailV1UserMailboxesByUserMailboxIdSettingsAutoReplyResponseDto
{
    /// <summary>
    /// <para>是否开启自动回复。</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// <para>自动回复正文 HTML。开启自动回复时不能为空。</para>
    /// <para>必填：否</para>
    /// <para>示例值：&lt;p&gt;Out of office&lt;/p&gt;</para>
    /// </summary>
    [JsonPropertyName("content_html")]
    public string? ContentHtml { get; set; }

    /// <summary>
    /// <para>自动回复正文摘要。</para>
    /// <para>必填：否</para>
    /// <para>示例值：Out of office</para>
    /// </summary>
    [JsonPropertyName("content_summary")]
    public string? ContentSummary { get; set; }

    /// <summary>
    /// <para>开始时间，Unix 毫秒级时间戳字符串；0 表示立即生效。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1786723200000</para>
    /// </summary>
    [JsonPropertyName("start_time")]
    public string? StartTime { get; set; }

    /// <summary>
    /// <para>结束时间，Unix 毫秒级时间戳字符串；0 表示不设结束时间。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1787068799999</para>
    /// </summary>
    [JsonPropertyName("end_time")]
    public string? EndTime { get; set; }

    /// <summary>
    /// <para>自动回复时间范围对应的 UTC 偏移秒数。</para>
    /// <para>必填：否</para>
    /// <para>示例值：28800</para>
    /// </summary>
    [JsonPropertyName("time_zone")]
    public string? TimeZone { get; set; }

    /// <summary>
    /// <para>是否仅向租户内成员发送自动回复。</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("only_send_to_tenant")]
    public bool? OnlySendToTenant { get; set; }

    /// <summary>
    /// <para>最后更新时间，Unix 毫秒级时间戳字符串。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1786723200000</para>
    /// </summary>
    [JsonPropertyName("last_updated_time")]
    public string? LastUpdatedTime { get; set; }

    /// <summary>
    /// <para>自动回复正文中通过 cid 引用的内联图片。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("images")]
    public UserMailboxAutoReplyImage[]? Images { get; set; }

    /// <summary>
    /// <para>自动回复正文中通过 cid 引用的内联图片。</para>
    /// </summary>
    public record UserMailboxAutoReplyImage
    {
        /// <summary>
        /// <para>图片文件名。</para>
        /// <para>必填：否</para>
        /// <para>示例值：logo.png</para>
        /// <para>最大长度：1024</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("image_name")]
        public string? ImageName { get; set; }

        /// <summary>
        /// <para>图片文件的 file_key。</para>
        /// <para>必填：否</para>
        /// <para>示例值：file_v3_abc</para>
        /// <para>最大长度：256</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("file_key")]
        public string? FileKey { get; set; }

        /// <summary>
        /// <para>图片在 HTML 中的 cid。</para>
        /// <para>必填：否</para>
        /// <para>示例值：image001</para>
        /// <para>最大长度：1024</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("cid")]
        public string? Cid { get; set; }

        /// <summary>
        /// <para>图片大小，单位为字节。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1024</para>
        /// <para>最大长度：32</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("file_size")]
        public string? FileSize { get; set; }
    }
}
