// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostMailV1MailgroupsByMailgroupIdAliasesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建邮件组别名 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 创建邮件组别名 请求体
/// <para>创建邮件组别名。</para>
/// <para>接口ID：6993201646486536194</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-alias/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-alias%2fcreate</para>
/// </summary>
public record PostMailV1MailgroupsByMailgroupIdAliasesBodyDto
{
    /// <summary>
    /// <para>邮箱别名</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxx@xx.xxx</para>
    /// </summary>
    [JsonPropertyName("email_alias")]
    public string? EmailAlias { get; set; }
}
