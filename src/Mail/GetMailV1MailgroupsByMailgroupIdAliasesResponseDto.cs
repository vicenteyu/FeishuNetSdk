// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetMailV1MailgroupsByMailgroupIdAliasesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取邮件组所有别名 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 获取邮件组所有别名 响应体
/// <para>获取邮件组所有别名。</para>
/// <para>接口ID：6993152083270172673</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-alias/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-alias%2flist</para>
/// </summary>
public record GetMailV1MailgroupsByMailgroupIdAliasesResponseDto
{
    /// <summary>
    /// <para>邮件组别名</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public EmailAlias[]? Items { get; set; }

    /// <summary>
    /// <para>邮件组别名</para>
    /// </summary>
    public record EmailAlias
    {
        /// <summary>
        /// <para>主邮箱地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxx@xx.xxx</para>
        /// </summary>
        [JsonPropertyName("primary_email")]
        public string? PrimaryEmail { get; set; }

        /// <summary>
        /// <para>邮箱别名</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxx@xx.xxx</para>
        /// </summary>
        [JsonPropertyName("email_alias")]
        public string? EmailAliasSuffix { get; set; }
    }
}
