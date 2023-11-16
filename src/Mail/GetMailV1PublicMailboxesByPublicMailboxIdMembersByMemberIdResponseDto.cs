namespace FeishuNetSdk.Mail;
/// <summary>
/// 查询指定公共邮箱成员信息 响应体
/// <para>获取公共邮箱单个成员信息。</para>
/// <para>接口ID：6954915601882693635</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/public-mailbox/public_mailbox-member/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox-member%2fget</para>
/// </summary>
public record GetMailV1PublicMailboxesByPublicMailboxIdMembersByMemberIdResponseDto
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
