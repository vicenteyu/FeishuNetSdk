// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-20
//
// Last Modified By : yxr
// Last Modified On : 2026-11-20
// ************************************************************************
// <copyright file="PostMailV1UserMailboxesByUserMailboxIdBlockedSendersBatchRemoveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量删除拦截发件人 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 批量删除拦截发件人 请求体
/// <para>批量从指定用户邮箱的拦截发件人名单中移除发件人。支持按完整邮箱地址或邮箱域名删除，单次最多 100 项。</para>
/// <para>接口ID：7695747058686954709</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-blocked_sender/batch_remove</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-blocked_sender%2fbatch_remove</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdBlockedSendersBatchRemoveBodyDto
{
    /// <summary>
    /// <para>待删除的发件人列表，每项为邮箱地址或域名。单次最多 100 项</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("senders")]
    public string[] Senders { get; set; } = [];
}
