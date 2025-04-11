// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-04-11
//
// Last Modified By : yxr
// Last Modified On : 2025-04-11
// ************************************************************************
// <copyright file="GetMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取邮件详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 获取邮件详情 响应体
/// <para>获取邮件详情</para>
/// <para>接口ID：7275929163676139523</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-message/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-message%2fget</para>
/// </summary>
public record GetMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdResponseDto
{
    /// <summary>
    /// <para>邮件体</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("message")]
    public GetMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdResponseDtoMessage? Message { get; set; }

    /// <summary>
    /// <para>邮件体</para>
    /// </summary>
    public record GetMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdResponseDtoMessage
    {
        /// <summary>
        /// <para>主题</para>
        /// <para>必填：否</para>
        /// <para>示例值：邮件标题</para>
        /// </summary>
        [JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// <para>收件人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("to")]
        public MailAddress[]? Tos { get; set; }

        /// <summary>
        /// <para>收件人</para>
        /// </summary>
        public record MailAddress
        {
            /// <summary>
            /// <para>邮件地址</para>
            /// <para>必填：是</para>
            /// <para>示例值：mike@outlook.com</para>
            /// </summary>
            [JsonPropertyName("mail_address")]
            public string MailAddressSuffix { get; set; } = string.Empty;

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：Mike</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }

        /// <summary>
        /// <para>抄送</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("cc")]
        public MailAddress[]? Ccs { get; set; }

        /// <summary>
        /// <para>秘送</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("bcc")]
        public MailAddress[]? Bccs { get; set; }

        /// <summary>
        /// <para>发件人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("head_from")]
        public MailAddress? HeadFrom { get; set; }

        /// <summary>
        /// <para>正文(base64url)</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxxx</para>
        /// </summary>
        [JsonPropertyName("body_html")]
        public string? BodyHtml { get; set; }

        /// <summary>
        /// <para>创建/收/发信时间（毫秒）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1682377086000</para>
        /// </summary>
        [JsonPropertyName("internal_date")]
        public string? InternalDate { get; set; }

        /// <summary>
        /// <para>邮件状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1（收信）2（发信）3（草稿）</para>
        /// </summary>
        [JsonPropertyName("message_state")]
        public int? MessageState { get; set; }

        /// <summary>
        /// <para>RFC协议id</para>
        /// <para>必填：否</para>
        /// <para>示例值：ay0azrJDvbs3FJAg@outlook.com</para>
        /// </summary>
        [JsonPropertyName("smtp_message_id")]
        public string? SmtpMessageId { get; set; }

        /// <summary>
        /// <para>邮件id</para>
        /// <para>必填：否</para>
        /// <para>示例值：tfuh9N4WnzU6jdDw=</para>
        /// </summary>
        [JsonPropertyName("message_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// <para>正文纯文本(base64url)</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxxxx</para>
        /// </summary>
        [JsonPropertyName("body_plain_text")]
        public string? BodyPlainText { get; set; }

        /// <summary>
        /// <para>邮件附件列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：501</para>
        /// </summary>
        [JsonPropertyName("attachments")]
        public Attachment[]? Attachments { get; set; }

        /// <summary>
        /// <para>邮件附件列表</para>
        /// </summary>
        public record Attachment
        {
            /// <summary>
            /// <para>附件文件名</para>
            /// <para>必填：是</para>
            /// <para>示例值：helloworld.txt</para>
            /// </summary>
            [JsonPropertyName("filename")]
            public string Filename { get; set; } = string.Empty;

            /// <summary>
            /// <para>附件 id</para>
            /// <para>必填：否</para>
            /// <para>示例值：YQqYbQHoQoDqXjxWKhJbo8Gicjf</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>附件类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>最大值：2</para>
            /// <para>最小值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：普通附件</item>
            /// <item>2：超大附件</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("attachment_type")]
            public int? AttachmentType { get; set; }
        }

        /// <summary>
        /// <para>会话id</para>
        /// <para>必填：否</para>
        /// <para>示例值：tfuh9N4WnzU6jdDw=</para>
        /// </summary>
        [JsonPropertyName("thread_id")]
        public string? ThreadId { get; set; }
    }
}
