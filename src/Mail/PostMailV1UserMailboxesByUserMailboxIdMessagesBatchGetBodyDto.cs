// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="PostMailV1UserMailboxesByUserMailboxIdMessagesBatchGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取邮件详情 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 批量获取邮件详情 请求体
/// <para>通过指定邮件ID，获取对应邮件的标签、文件夹、摘要、正文、html、附件等信息。</para>
/// <para>接口ID：7620282151846333660</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-message/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-message%2fbatch_get</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdMessagesBatchGetBodyDto
{
    /// <summary>
    /// <para>需要获取的邮件内容</para>
    /// <para>必填：否</para>
    /// <para>示例值：full</para>
    /// <para>可选值：<list type="bullet">
    /// <item>full：全文，包括标签、文件夹、主题、收发件人、纯文本、HTML等信息</item>
    /// <item>plain_text_full：全文，只返回纯文本正文内容，不返回HTML。返回内容包括标签、文件夹、主题、收发件人、纯文本等信息</item>
    /// <item>metadata：邮件元数据信息，包括标签、文件夹、主题、收发件人、摘要等信息，不返回正文内容</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>
    /// <para>需要的邮件ID，可以通过列出邮件列表、收信事件通知等方式获得</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("message_ids")]
    public string[]? MessageIds { get; set; }
}
