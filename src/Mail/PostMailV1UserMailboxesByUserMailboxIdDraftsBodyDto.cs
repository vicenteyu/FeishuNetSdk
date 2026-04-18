// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="PostMailV1UserMailboxesByUserMailboxIdDraftsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建草稿 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 创建草稿 请求体
/// <para>根据指定的内容创建草稿</para>
/// <para>接口ID：7620478754624441276</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-draft/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-draft%2fcreate</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdDraftsBodyDto
{
    /// <summary>
    /// <para>base64url 编码的完整 RFC 5822（EML）邮件内容，包含所有邮件头（Subject、From、To、Cc、Bcc 等）和邮件正文（含内联图片和附件的 MIME 结构）。原始EML大小不可超过37.5MB。</para>
    /// <para>必填：否</para>
    /// <para>示例值：Q29udGVudC1UeXBlOiB0ZXh0L3BsYWluOyBjaGFyc2V0PSJ1cy1hc2NpaSIKTUlNRS1WZXJzaW9uOiAxLjAKQ29udGVudC1UcmFuc2Zlci1FbmNvZGluZzogN2JpdAp0bzogInRvIiA8dG9AeHh4Lnh4Pgpmcm9tOiAiZnJvbSIgPGZyb21AeHh4Lnh4PgpzdWJqZWN0OiB0aGlzIGlzIGEgc3ViamVjdAoKdGhpcyBpcyB0aGUgbWVzc2FnZSBib2R5Lg</para>
    /// </summary>
    [JsonPropertyName("raw")]
    public string? Raw { get; set; }
}
