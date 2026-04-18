// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="GetMailV1UserMailboxesByUserMailboxIdSettingsSendAsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>列出可发信邮箱 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 列出可发信邮箱 响应体
/// <para>获取当前地址的可用于发信的邮箱地址列表</para>
/// <para>接口ID：7626215228942896084</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-setting/send_as</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-setting%2fsend_as</para>
/// </summary>
public record GetMailV1UserMailboxesByUserMailboxIdSettingsSendAsResponseDto
{
    /// <summary>
    /// <para>可发信地址。包括主地址、别名地址、邮件组。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sendable_addresses")]
    public EmailInfo[]? SendableAddresses { get; set; }

    /// <summary>
    /// <para>可发信地址。包括主地址、别名地址、邮件组。</para>
    /// </summary>
    public record EmailInfo
    {
        /// <summary>
        /// <para>邮箱地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：abc@abc.com</para>
        /// </summary>
        [JsonPropertyName("email_address")]
        public string? EmailAddress { get; set; }

        /// <summary>
        /// <para>邮箱地址类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：USER_PRIMARY</para>
        /// <para>可选值：<list type="bullet">
        /// <item>MAIL_GROUP：邮件组</item>
        /// <item>PUBLIC_MAILBOX：公共邮箱</item>
        /// <item>USER_PRIMARY：用户主地址</item>
        /// <item>USER_ALIAS：用户别名</item>
        /// <item>PUBLIC_MAILBOX_ALIAS：公共邮箱别名</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("email_type")]
        public string? EmailType { get; set; }

        /// <summary>
        /// <para>邮箱名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：Mike</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
