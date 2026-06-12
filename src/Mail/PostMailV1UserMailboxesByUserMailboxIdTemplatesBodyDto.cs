// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-11
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="PostMailV1UserMailboxesByUserMailboxIdTemplatesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建邮件模板 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 创建邮件模板 请求体
/// <para>**功能说明**：在指定用户邮箱下创建一份可复用的个人邮件模板，适用于将常用邮件内容沉淀为模板以便后续快速发送同类型邮件。</para>
/// <para>**请求要求**：请求时需传入完整的模板对象，包括名称、主题、正文、收件信息、附件等。</para>
/// <para>**返回内容**：创建成功后返回完整模板内容，包含系统生成的模板 ID（template_id）。</para>
/// <para>接口ID：7636620599011953615</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-template/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-template%2fcreate</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdTemplatesBodyDto
{
    /// <summary>
    /// <para>待创建的模板内容</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("template")]
    public TemplateSuffix Template { get; set; } = new();

    /// <summary>
    /// <para>待创建的模板内容</para>
    /// </summary>
    public record TemplateSuffix
    {
        /// <summary>
        /// <para>模板名称，不超过 100 字符</para>
        /// <para>必填：是</para>
        /// <para>示例值：销售跟进模板</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>邮件主题，不超过 1000 字符</para>
        /// <para>必填：否</para>
        /// <para>示例值：关于本周订单跟进</para>
        /// <para>最大长度：1000</para>
        /// </summary>
        [JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// <para>模板正文（HTML 或纯文本）。单模板正文大小上限 3 MB（3 \* 1024 \* 1024 字节），超过将返回错误码 1230006 template content size limit exceeded。</para>
        /// <para>必填：否</para>
        /// <para>示例值：&lt;p&gt;Hi ${name},&lt;/p&gt;</para>
        /// <para>最大长度：3145728</para>
        /// </summary>
        [JsonPropertyName("template_content")]
        public string? TemplateContent { get; set; }

        /// <summary>
        /// <para>是否为纯文本模式。`true` 表示模板正文按纯文本渲染，`false` 表示按 HTML 渲染。默认 `false`（HTML 模式）。</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// <para>默认值：false</para>
        /// </summary>
        [JsonPropertyName("is_plain_text_mode")]
        public bool? IsPlainTextMode { get; set; }

        /// <summary>
        /// <para>默认收件人地址列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("tos")]
        public MailAddress[]? Tos { get; set; }

        /// <summary>
        /// <para>默认收件人地址列表</para>
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
            /// <para>收件人名称，不超过 255 个字符。</para>
            /// <para>必填：否</para>
            /// <para>示例值：Mike</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }

        /// <summary>
        /// <para>默认抄送地址列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("ccs")]
        public MailAddress[]? Ccs { get; set; }

        /// <summary>
        /// <para>默认密送地址列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("bccs")]
        public MailAddress[]? Bccs { get; set; }

        /// <summary>
        /// <para>模板附件与内嵌图片列表。添加单个附件时，通常需填写附件文件名 filename 和附件 ID id；若附件为内联图片，还需将 is_inline 设为 true 并填写 cid。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：50</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("attachments")]
        public TemplateAttachment[]? Attachments { get; set; }

        /// <summary>
        /// <para>模板附件与内嵌图片列表。添加单个附件时，通常需填写附件文件名 filename 和附件 ID id；若附件为内联图片，还需将 is_inline 设为 true 并填写 cid。</para>
        /// </summary>
        public record TemplateAttachment
        {
            /// <summary>
            /// <para>附件文件名。添加附件时需与附件 ID id 一起填写，文件名不超过 255 个字符。</para>
            /// <para>必填：否</para>
            /// <para>示例值：plan.xlsx</para>
            /// <para>最大长度：255</para>
            /// </summary>
            [JsonPropertyName("filename")]
            public string? Filename { get; set; }

            /// <summary>
            /// <para>附件 ID（Drive file_key，用于引用 Drive medias 上传接口返回的 file_key）。添加附件时需与附件文件名 filename 一起填写。</para>
            /// <para>必填：否</para>
            /// <para>示例值：boxcnrHpsg1QDqXPrJXWPwbqsKh</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>附件类型。默认值为 1，表示普通附件；设置为 2 时表示超大附件。</para>
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

            /// <summary>
            /// <para>是否为内联图片。true 表示内联图片，可在 HTML 正文中通过 cid 引用；false 表示普通非内联附件。默认 false。</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// <para>默认值：false</para>
            /// </summary>
            [JsonPropertyName("is_inline")]
            public bool? IsInline { get; set; }

            /// <summary>
            /// <para>内容 ID。仅当 is_inline 为 true 时需要填写，用于在 HTML 正文中通过 cid: 协议引用该内联图片。</para>
            /// <para>必填：否</para>
            /// <para>示例值：image1@example.com</para>
            /// <para>最大长度：255</para>
            /// </summary>
            [JsonPropertyName("cid")]
            public string? Cid { get; set; }
        }
    }
}
