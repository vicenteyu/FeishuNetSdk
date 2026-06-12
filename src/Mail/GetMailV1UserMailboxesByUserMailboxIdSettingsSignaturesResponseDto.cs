// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="GetMailV1UserMailboxesByUserMailboxIdSettingsSignaturesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>列出邮件签名 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 列出邮件签名 响应体
/// <para>获取用户的签名列表</para>
/// <para>接口ID：7629252749259951314</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-setting/get_signatures</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-setting%2fget_signatures</para>
/// </summary>
public record GetMailV1UserMailboxesByUserMailboxIdSettingsSignaturesResponseDto
{
    /// <summary>
    /// <para>用户邮箱签名列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("signatures")]
    public UserMailboxSignature[]? Signatures { get; set; }

    /// <summary>
    /// <para>用户邮箱签名列表</para>
    /// </summary>
    public record UserMailboxSignature
    {
        /// <summary>
        /// <para>签名 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：sig_xxxxxx</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>签名名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：我的签名</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>签名内容（HTML 格式）</para>
        /// <para>必填：否</para>
        /// <para>示例值：&lt;div&gt;Best regards&lt;/div&gt;</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// <para>签名类型，可选值：USER（用户签名）、TENANT（租户签名）</para>
        /// <para>必填：否</para>
        /// <para>示例值：USER</para>
        /// </summary>
        [JsonPropertyName("signature_type")]
        public string? SignatureType { get; set; }

        /// <summary>
        /// <para>签名适用设备类型，可选值：PC、MOBILE</para>
        /// <para>必填：否</para>
        /// <para>示例值：PC</para>
        /// </summary>
        [JsonPropertyName("signature_device")]
        public string? SignatureDevice { get; set; }

        /// <summary>
        /// <para>企业签名模板变量渲染</para>
        /// <para>必填：否</para>
        /// <para>最大长度：200</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("template_json_keys")]
        public string[]? TemplateJsonKeys { get; set; }

        /// <summary>
        /// <para>签名最后更新时间戳</para>
        /// <para>必填：否</para>
        /// <para>最大长度：500</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("images")]
        public UserMailboxSiganatureImage[]? Images { get; set; }

        /// <summary>
        /// <para>签名最后更新时间戳</para>
        /// </summary>
        public record UserMailboxSiganatureImage
        {
            /// <summary>
            /// <para>签名图片名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：logo.png</para>
            /// </summary>
            [JsonPropertyName("image_name")]
            public string? ImageName { get; set; }

            /// <summary>
            /// <para>签名图片的文件 key，用于上传和下载图片</para>
            /// <para>必填：否</para>
            /// <para>示例值：boxcnxxx</para>
            /// </summary>
            [JsonPropertyName("file_key")]
            public string? FileKey { get; set; }

            /// <summary>
            /// <para>签名图片的 Content-ID，用于在邮件中内嵌引用</para>
            /// <para>必填：否</para>
            /// <para>示例值：image001@01DA1234.5678ABCD</para>
            /// </summary>
            [JsonPropertyName("cid")]
            public string? Cid { get; set; }

            /// <summary>
            /// <para>签名图片文件大小，单位为字节</para>
            /// <para>必填：否</para>
            /// <para>示例值：102400</para>
            /// </summary>
            [JsonPropertyName("file_size")]
            public string? FileSize { get; set; }

            /// <summary>
            /// <para>签名图片宽度，单位为像素</para>
            /// <para>必填：否</para>
            /// <para>示例值：200</para>
            /// <para>最大值：10000</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("image_width")]
            public int? ImageWidth { get; set; }

            /// <summary>
            /// <para>签名图片高度，单位为像素</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// <para>最大值：10000</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("image_height")]
            public int? ImageHeight { get; set; }

            /// <summary>
            /// <para>图片下载url</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxxx</para>
            /// <para>最大长度：2048</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("download_url")]
            public string? DownloadUrl { get; set; }
        }

        /// <summary>
        /// <para>企业签名模版变量值</para>
        /// <para>必填：否</para>
        /// <para>示例值：{"BNAME": "xxxx"}</para>
        /// </summary>
        [JsonPropertyName("user_fields")]
        public object? UserFields { get; set; }
    }

    /// <summary>
    /// <para>用户邮箱签名使用情况列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("usages")]
    public UserMailboxSignatureUsage[]? Usages { get; set; }

    /// <summary>
    /// <para>用户邮箱签名使用情况列表</para>
    /// </summary>
    public record UserMailboxSignatureUsage
    {
        /// <summary>
        /// <para>邮箱地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：user@example.com</para>
        /// </summary>
        [JsonPropertyName("email_address")]
        public string? EmailAddress { get; set; }

        /// <summary>
        /// <para>发送邮件时使用的签名 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：sig_xxxxxx</para>
        /// </summary>
        [JsonPropertyName("send_mail_signature_id")]
        public string? SendMailSignatureId { get; set; }

        /// <summary>
        /// <para>回复邮件时使用的签名 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：sig_yyyyyy</para>
        /// </summary>
        [JsonPropertyName("reply_signature_id")]
        public string? ReplySignatureId { get; set; }
    }
}
