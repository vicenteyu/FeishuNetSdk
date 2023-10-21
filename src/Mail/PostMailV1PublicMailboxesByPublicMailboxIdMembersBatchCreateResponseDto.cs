using Newtonsoft.Json;
namespace FeishuNetSdk.Mail;
/// <summary>
/// 批量添加公共邮箱成员 响应体
/// <para>一次请求可以给一个公共邮箱添加多个成员。</para>
/// <para>接口ID：7187647376462921732</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/public-mailbox/public_mailbox-member/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox-member%2fbatch_create</para>
/// </summary>
public record PostMailV1PublicMailboxesByPublicMailboxIdMembersBatchCreateResponseDto
{
    /// <summary>
    /// <para>添加成功后的公共邮箱成员信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public PublicMailboxMember[]? Items { get; set; }

    /// <summary>
    /// <para>添加成功后的公共邮箱成员信息列表</para>
    /// </summary>
    public record PublicMailboxMember
    {
        /// <summary>
        /// <para>公共邮箱内成员唯一标识（在请求体中不用填）</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxxxxxxxxxxxxxx</para>
        /// </summary>
        [JsonProperty("member_id")]
        public string? MemberId { get; set; }

        /// <summary>
        /// <para>租户内用户的唯一标识（当成员类型是USER时有值）</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxxxxxxxxx</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>成员类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：USER</para>
        /// <para>可选值：<list type="bullet">
        /// <item>USER：内部用户</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }
    }
}
