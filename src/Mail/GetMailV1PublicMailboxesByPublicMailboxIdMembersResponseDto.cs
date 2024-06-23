// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetMailV1PublicMailboxesByPublicMailboxIdMembersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询所有公共邮箱成员信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 查询所有公共邮箱成员信息 响应体
/// <para>分页批量获取公共邮箱成员列表。</para>
/// <para>接口ID：6954915601883004931</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/public-mailbox/public_mailbox-member/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox-member%2flist</para>
/// </summary>
public record GetMailV1PublicMailboxesByPublicMailboxIdMembersResponseDto
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxx</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>公共邮箱成员列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public PublicMailboxMember[]? Items { get; set; }

    /// <summary>
    /// <para>公共邮箱成员列表</para>
    /// </summary>
    public record PublicMailboxMember
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
}
