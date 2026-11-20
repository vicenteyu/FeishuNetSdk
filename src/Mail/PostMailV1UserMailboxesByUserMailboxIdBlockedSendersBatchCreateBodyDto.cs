// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-20
//
// Last Modified By : yxr
// Last Modified On : 2026-11-20
// ************************************************************************
// <copyright file="PostMailV1UserMailboxesByUserMailboxIdBlockedSendersBatchCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量创建拦截发件人 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 批量创建拦截发件人 请求体
/// <para>批量将发件人加入指定用户邮箱的拦截发件人名单。支持按完整邮箱地址或邮箱域名添加，单次最多 100 项。</para>
/// <para>接口ID：7695747058686971093</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-blocked_sender/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-blocked_sender%2fbatch_create</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdBlockedSendersBatchCreateBodyDto
{
    /// <summary>
    /// <para>待加入黑名单的发件人列表，单次最多 100 项</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("items")]
    public UserSenderItem[] Items { get; set; } = [];

    /// <summary>
    /// <para>待加入黑名单的发件人列表，单次最多 100 项</para>
    /// </summary>
    public record UserSenderItem
    {
        /// <summary>
        /// <para>发件人地址，根据 sender_type 不同含义不同：当 sender_type=1 时为完整邮箱地址；当 sender_type=2 时为邮箱域名</para>
        /// <para>必填：否</para>
        /// <para>示例值：marketing@example.com</para>
        /// </summary>
        [JsonPropertyName("sender")]
        public string? Sender { get; set; }

        /// <summary>
        /// <para>发件人类型。1=邮箱地址 (Address)，按完整邮箱匹配；2=域名 (Domain)，按邮箱域名匹配</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>最大值：2</para>
        /// <para>最小值：1</para>
        /// </summary>
        [JsonPropertyName("sender_type")]
        public int? SenderType { get; set; }
    }
}
