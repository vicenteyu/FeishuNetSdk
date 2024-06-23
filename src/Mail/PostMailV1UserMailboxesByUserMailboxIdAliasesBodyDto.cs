// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostMailV1UserMailboxesByUserMailboxIdAliasesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建用户邮箱别名 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 创建用户邮箱别名 请求体
/// <para>创建用户邮箱别名。</para>
/// <para>接口ID：7034854712587763714</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/user_mailbox-alias/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-alias%2fcreate</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdAliasesBodyDto
{
    /// <summary>
    /// <para>邮箱别名</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxx@xx.xxx</para>
    /// </summary>
    [JsonPropertyName("email_alias")]
    public string? EmailAlias { get; set; }
}
