// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="PostMailV1UserMailboxesByUserMailboxIdDraftsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建草稿 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 创建草稿 响应体
/// <para>根据指定的内容创建草稿</para>
/// <para>接口ID：7620478754624441276</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-draft/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-draft%2fcreate</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdDraftsResponseDto
{
    /// <summary>
    /// <para>草稿内容</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("draft")]
    public DraftSuffix? Draft { get; set; }

    /// <summary>
    /// <para>草稿内容</para>
    /// </summary>
    public record DraftSuffix
    {
        /// <summary>
        /// <para>草稿ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：268dce11-85f7-427d-8756-6be3abc850fd</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>草稿内容</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("message")]
        public MessageSuffix? Message { get; set; }

        /// <summary>
        /// <para>草稿内容</para>
        /// </summary>
        public record MessageSuffix
        {
            /// <summary>
            /// <para>MIME邮件数据，基于base64url编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：Q29udGVudC1UeXBlOiB0ZXh0L3BsYWluOyBjaGFyc2V0PSJ1cy1hc2NpaSIKTUlNRS1WZXJzaW9uOiAxLjAKQ29udGVudC1UcmFuc2Zlci1FbmNvZGluZzogN2JpdAp0bzogdG9AeHh4Lnh4CmZyb206IHNlbmRlckB4eHgueHgKc3ViamVjdDogdGhpcyBpcyBhIHN1YmplY3QKCnRoaXMgaXMgdGhlIG1lc3NhZ2UgYm9keS4=</para>
            /// <para>最大长度：52428800</para>
            /// </summary>
            [JsonPropertyName("raw")]
            public string? Raw { get; set; }

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
            /// <para>密送</para>
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
            /// <para>邮件状态，1（收信）2（发信）3（草稿）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
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
            /// <para>正文纯文本(base64url)</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxxxx</para>
            /// </summary>
            [JsonPropertyName("body_plain_text")]
            public string? BodyPlainText { get; set; }

            /// <summary>
            /// <para>会话id</para>
            /// <para>必填：否</para>
            /// <para>示例值：tfuh9N4WnzU6jdDw=</para>
            /// </summary>
            [JsonPropertyName("thread_id")]
            public string? ThreadId { get; set; }

            /// <summary>
            /// <para>邮件正文纯文本内容的前100个字符，基于base64url编码，用于快速预览邮件核心内容，无需解码完整正文</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxxxx</para>
            /// </summary>
            [JsonPropertyName("body_preview")]
            public string? BodyPreview { get; set; }

            /// <summary>
            /// <para>标签ID</para>
            /// <para>必填：否</para>
            /// <para>最大长度：500</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("label_ids")]
            public string[]? LabelIds { get; set; }

            /// <summary>
            /// <para>文件夹ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：INBOX</para>
            /// </summary>
            [JsonPropertyName("folder_id")]
            public string? FolderId { get; set; }

            /// <summary>
            /// <para>In-Reply-To邮件头</para>
            /// <para>必填：否</para>
            /// <para>示例值：06d20.dbf451a3.808a.475a.acc9.1363dfd20f36@larksuite.com</para>
            /// </summary>
            [JsonPropertyName("in_reply_to")]
            public string? InReplyTo { get; set; }

            /// <summary>
            /// <para>Reply-To邮件头</para>
            /// <para>必填：否</para>
            /// <para>示例值：06d20.dbf451a3.808a.475a.acc9.1363dfd20f36@larksuite.com</para>
            /// </summary>
            [JsonPropertyName("reply_to")]
            public string? ReplyTo { get; set; }

            /// <summary>
            /// <para>邮件优先级</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：无优先级</item>
            /// <item>1：高优先级</item>
            /// <item>3：正常优先级</item>
            /// <item>5：低优先级</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("priority_type")]
            public string? PriorityType { get; set; }

            /// <summary>
            /// <para>安全信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("security_level")]
            public SecurityLevelSuffix? SecurityLevel { get; set; }

            /// <summary>
            /// <para>安全信息</para>
            /// </summary>
            public record SecurityLevelSuffix
            {
                /// <summary>
                /// <para>是否风险邮件</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("is_risk")]
                public bool? IsRisk { get; set; }

                /// <summary>
                /// <para>风险邮件等级</para>
                /// <para>必填：否</para>
                /// <para>示例值：WARNING</para>
                /// <para>可选值：<list type="bullet">
                /// <item>WARNING：警告</item>
                /// <item>DANGER：危险</item>
                /// <item>INFO：提示</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("risk_banner_level")]
                public string? RiskBannerLevel { get; set; }

                /// <summary>
                /// <para>风险邮件原因</para>
                /// <para>必填：否</para>
                /// <para>示例值：IMPERSONATE_DOMAIN</para>
                /// <para>可选值：<list type="bullet">
                /// <item>NO_REASON：未知</item>
                /// <item>IMPERSONATE_DOMAIN：相似域名仿冒</item>
                /// <item>IMPERSONATE_KP_NAME：KP姓名仿冒</item>
                /// <item>UNAUTH_EXTERNAL：未认证外部域名</item>
                /// <item>MALICIOUS_URL：恶意链接</item>
                /// <item>MALICIOUS_ATTACHMENT：高危附件</item>
                /// <item>PHISHING：钓鱼邮件</item>
                /// <item>IMPERSONATE_PARTNER：仿冒合作伙伴</item>
                /// <item>EXTERNAL_ENCRYPTION_ATTACHMENT：外部邮件携带加密附件</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("risk_banner_reason")]
                public string? RiskBannerReason { get; set; }

                /// <summary>
                /// <para>发件人是否外部邮件</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("is_header_from_external")]
                public bool? IsHeaderFromExternal { get; set; }

                /// <summary>
                /// <para>代发或伪造邮件展示SPF或DKIM域名</para>
                /// <para>必填：否</para>
                /// <para>示例值：larksuite.com</para>
                /// </summary>
                [JsonPropertyName("via_domain")]
                public string? ViaDomain { get; set; }

                /// <summary>
                /// <para>垃圾邮件原因</para>
                /// <para>必填：否</para>
                /// <para>示例值：USER_REPORT</para>
                /// <para>可选值：<list type="bullet">
                /// <item>USER_REPORT：用户曾标记邮件是垃圾邮件</item>
                /// <item>USER_BLOCK：用户曾将发件人的邮件标记为垃圾邮件</item>
                /// <item>ANTI_SPAM：系统判为垃圾邮件</item>
                /// <item>USER_RULE：命中收信规则进入垃圾邮件</item>
                /// <item>BLOCK_DOMIN：用户已拦截来自该域名的邮件</item>
                /// <item>BLOCK_ADDRESS：用户已拦截来自该邮件地址的邮件</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("spam_banner_type")]
                public string? SpamBannerType { get; set; }

                /// <summary>
                /// <para>命中的收信规则ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：7618365627924925388</para>
                /// </summary>
                [JsonPropertyName("spam_user_rule_id")]
                public string? SpamUserRuleId { get; set; }

                /// <summary>
                /// <para>命中用户黑名单的地址或域名信息</para>
                /// <para>必填：否</para>
                /// <para>示例值：larksuite.com</para>
                /// </summary>
                [JsonPropertyName("spam_banner_info")]
                public string? SpamBannerInfo { get; set; }
            }

            /// <summary>
            /// <para>References邮件头</para>
            /// <para>必填：否</para>
            /// <para>示例值：&lt;5678.abcd@test.com&gt;\r\n\t&lt;1234.abcd@message-id&gt;</para>
            /// </summary>
            [JsonPropertyName("references")]
            public string? References { get; set; }
        }
    }
}
