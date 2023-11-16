namespace FeishuNetSdk.Mail;
/// <summary>
/// 获取邮件组权限成员 响应体
/// <para>获取邮件组单个权限成员信息。</para>
/// <para>接口ID：6954915601883054083</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-permission_member/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-permission_member%2fget</para>
/// </summary>
public record GetMailV1MailgroupsByMailgroupIdPermissionMembersByPermissionMemberIdResponseDto
{
    /// <summary>
    /// <para>权限组内成员唯一标识（在请求体中不用填）</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxxxxxxxxxxxxxx</para>
    /// </summary>
    [JsonPropertyName("permission_member_id")]
    public string? PermissionMemberId { get; set; }

    /// <summary>
    /// <para>租户内用户的唯一标识（当成员类型是USER时有值）</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxxxxxxxxx</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>租户内部门的唯一标识（当成员类型是DEPARTMENT时有值）</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxxxxxxxxx</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// <para>成员邮箱地址（当成员类型是MAIL_GROUP/PUBLIC_MAILBOX时有值）</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxx@xx.x</para>
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// <para>成员类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：USER</para>
    /// <para>可选值：<list type="bullet">
    /// <item>USER：内部用户</item>
    /// <item>DEPARTMENT：部门</item>
    /// <item>MAIL_GROUP：邮件组</item>
    /// <item>PUBLIC_MAILBOX：公共邮箱</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
