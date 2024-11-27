// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-27
//
// Last Modified By : yxr
// Last Modified On : 2024-11-27
// ************************************************************************
// <copyright file="PostMailV1UserMailboxesByUserMailboxIdMessagesSendBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发送邮件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 发送邮件 请求体
/// <para>发送邮件</para>
/// <para>接口ID：7205136193486356481</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/user_mailbox-message/send</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-message%2fsend</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdMessagesSendBodyDto
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
        /// <para>示例值：user@xxx.xx</para>
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
    /// <para>正文</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxxx</para>
    /// </summary>
    [JsonPropertyName("body_html")]
    public string? BodyHtml { get; set; }

    /// <summary>
    /// <para>正文纯文本</para>
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
        /// <para>附件的正文，使用 base64url 编码（支持的文件最大 37MB）</para>
        /// <para>必填：是</para>
        /// <para>示例值：aGVsbG8gd29ybGQK</para>
        /// <para>最大长度：51729750</para>
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; } = string.Empty;

        /// <summary>
        /// <para>附件文件名</para>
        /// <para>必填：是</para>
        /// <para>示例值：helloworld.txt</para>
        /// </summary>
        [JsonPropertyName("filename")]
        public string Filename { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>会话id</para>
    /// <para>必填：否</para>
    /// <para>示例值：tfuh9N4WnzU6jdDw=</para>
    /// </summary>
    [JsonPropertyName("thread_id")]
    public string? ThreadId { get; set; }
}
