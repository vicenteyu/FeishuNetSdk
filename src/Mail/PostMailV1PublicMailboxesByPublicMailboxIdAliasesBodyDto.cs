// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostMailV1PublicMailboxesByPublicMailboxIdAliasesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建公共邮箱别名 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 创建公共邮箱别名 请求体
/// <para>创建公共邮箱别名。</para>
/// <para>接口ID：6993201646486470658</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/public-mailbox/public_mailbox-alias/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox-alias%2fcreate</para>
/// </summary>
public record PostMailV1PublicMailboxesByPublicMailboxIdAliasesBodyDto
{
    /// <summary>
    /// <para>邮箱别名</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxx@xx.xxx</para>
    /// </summary>
    [JsonPropertyName("email_alias")]
    public string? EmailAlias { get; set; }
}
