// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-06
//
// Last Modified By : yxr
// Last Modified On : 2025-05-06
// ************************************************************************
// <copyright file="DeleteMailV1PublicMailboxesByPublicMailboxIdRemoveToRecycleBinBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>将公共邮箱移至回收站 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 将公共邮箱移至回收站 请求体
/// <para>将公共邮箱移至回收站</para>
/// <para>接口ID：7296319822873673730</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/public-mailbox/public_mailbox/remove_to_recycle_bin</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox%2fremove_to_recycle_bin</para>
/// </summary>
public record DeleteMailV1PublicMailboxesByPublicMailboxIdRemoveToRecycleBinBodyDto
{
    /// <summary>
    /// <para>接收删除邮件的邮箱地址，不填则删除该公共邮箱的邮件</para>
    /// <para>必填：否</para>
    /// <para>示例值：user@xxx.xx</para>
    /// </summary>
    [JsonPropertyName("to_mail_address")]
    public string? ToMailAddress { get; set; }
}
