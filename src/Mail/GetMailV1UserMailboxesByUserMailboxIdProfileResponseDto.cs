// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="GetMailV1UserMailboxesByUserMailboxIdProfileResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取用户邮箱信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 获取用户邮箱信息 响应体
/// <para>用于在用户身份下获取自己的邮箱主地址</para>
/// <para>接口ID：7620282151846448348</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox/profile</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox%2fprofile</para>
/// </summary>
public record GetMailV1UserMailboxesByUserMailboxIdProfileResponseDto
{
    /// <summary>
    /// <para>用户主邮箱地址</para>
    /// <para>必填：否</para>
    /// <para>示例值：abc@abc.com</para>
    /// </summary>
    [JsonPropertyName("primary_email_address")]
    public string? PrimaryEmailAddress { get; set; }
}
