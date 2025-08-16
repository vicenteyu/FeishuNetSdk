// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-27
//
// Last Modified By : yxr
// Last Modified On : 2025-08-16
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
    /// <para>eml数据</para>
    /// <para>必填：否</para>
    /// <para>示例值：U3ViamVjdDogSGVsbG8hCkZyb206ICJtaWtlIiA8bWlrZUBtaWtlLmNvbT4KTWltZS1WZXJzaW9uOiAxLjAKQ29udGVudC1UeXBlOiBtdWx0aXBhcnQvYWx0ZXJuYXRpdmU7CiBib3VuZGFyeT1iMjhmYTIyNGExZWU2ZDY3ZjE3OTViNGUxZDEwM2Q3MTBlNzM5ZWVmYjFmZjlmOWQ4NWI4M2NlOTRmMTEKRGF0ZTogV2VkLCAyMyBKdWwgMjAyNSAxNTo0NDoxOCArMDgwMApNZXNzYWdlLUlkOiA8bW9ja3V1aWRtZXNzYWdlX2lkQGxhcmsuY29tPgpUbzogImphY2siIDxqYWNrQGphY2suY29tPgoKLS1iMjhmYTIyNGExZWU2ZDY3ZjE3OTViNGUxZDEwM2Q3MTBlNzM5ZWVmYjFmZjlmOWQ4NWI4M2NlOTRmMTEKQ29udGVudC1UcmFuc2Zlci1FbmNvZGluZzogN2JpdApDb250ZW50LVR5cGU6IHRleHQvcGxhaW47IGNoYXJzZXQ9VVRGLTgKCldlbGNvbWUgdG8gTGFyayBtYWlsIQotLWIyOGZhMjI0YTFlZTZkNjdmMTc5NWI0ZTFkMTAzZDcxMGU3MzllZWZiMWZmOWY5ZDg1YjgzY2U5NGYxMQo=</para>
    /// </summary>
    [JsonPropertyName("raw")]
    public string? Raw { get; set; }

    /// <summary>
    /// <para>抄送</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("cc")]
    public MailAddress[]? Ccs { get; set; }

    /// <summary>
    /// <para>密送</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("bcc")]
    public MailAddress[]? Bccs { get; set; }

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
    /// <para>示例值：xxxx</para>
    /// </summary>
    [JsonPropertyName("body_plain_text")]
    public string? BodyPlainText { get; set; }

    /// <summary>
    /// <para>附件</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("attachments")]
    public Attachment[]? Attachments { get; set; }

    /// <summary>
    /// <para>附件</para>
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

        /// <summary>
        /// <para>是否为内联图片，true 表示是内联图片</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// <para>默认值：false</para>
        /// </summary>
        [JsonPropertyName("is_inline")]
        public bool? IsInline { get; set; }

        /// <summary>
        /// <para>内容 ID，HTML 中通过 cid: 协议引用该图片</para>
        /// <para>必填：否</para>
        /// <para>示例值：image1@example.com</para>
        /// </summary>
        [JsonPropertyName("cid")]
        public string? Cid { get; set; }
    }

    /// <summary>
    /// <para>去重键</para>
    /// <para>必填：否</para>
    /// <para>示例值：abc-ddd-eee-fff-ggg</para>
    /// </summary>
    [JsonPropertyName("dedupe_key")]
    public string? DedupeKey { get; set; }

    /// <summary>
    /// <para>EML中发件人信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("head_from")]
    public MailAddress? HeadFrom { get; set; }
}
