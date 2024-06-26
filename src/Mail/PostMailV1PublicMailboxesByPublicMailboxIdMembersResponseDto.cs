// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostMailV1PublicMailboxesByPublicMailboxIdMembersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加公共邮箱成员 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 添加公共邮箱成员 响应体
/// <para>向公共邮箱添加单个成员。</para>
/// <para>接口ID：6954915601883103235</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/public-mailbox/public_mailbox-member/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox-member%2fcreate</para>
/// </summary>
public record PostMailV1PublicMailboxesByPublicMailboxIdMembersResponseDto
{
    /// <summary>
    /// <para>公共邮箱内成员唯一标识（在请求体中不用填）</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxxxxxxxxxxxxxx</para>
    /// </summary>
    [JsonPropertyName("member_id")]
    public string? MemberId { get; set; }

    /// <summary>
    /// <para>租户内用户的唯一标识（当成员类型是USER时有值）</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxxxxxxxxx</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>成员类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：USER</para>
    /// <para>可选值：<list type="bullet">
    /// <item>USER：内部用户</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
