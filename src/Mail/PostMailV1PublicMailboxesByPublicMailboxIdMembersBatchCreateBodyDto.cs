// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostMailV1PublicMailboxesByPublicMailboxIdMembersBatchCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量添加公共邮箱成员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 批量添加公共邮箱成员 请求体
/// <para>一次请求可以给一个公共邮箱添加多个成员。</para>
/// <para>接口ID：7187647376462921732</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/public-mailbox/public_mailbox-member/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox-member%2fbatch_create</para>
/// </summary>
public record PostMailV1PublicMailboxesByPublicMailboxIdMembersBatchCreateBodyDto
{
    /// <summary>
    /// <para>本次调用添加的公共邮箱成员列表</para>
    /// <para>必填：是</para>
    /// <para>最大长度：200</para>
    /// </summary>
    [JsonPropertyName("items")]
    public PublicMailboxMember[] Items { get; set; } = Array.Empty<PublicMailboxMember>();

    /// <summary>
    /// <para>本次调用添加的公共邮箱成员列表</para>
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
