namespace FeishuNetSdk.Mail;
/// <summary>
/// 批量获取邮件组权限成员 响应体
/// <para>分页批量获取邮件组权限成员列表。</para>
/// <para>接口ID：6954915601882808323</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-permission_member/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-permission_member%2flist</para>
/// </summary>
public record GetMailV1MailgroupsByMailgroupIdPermissionMembersResponseDto
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
    /// <para>邮件组权限成员列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public MailgroupPermissionMember[]? Items { get; set; }

    /// <summary>
    /// <para>邮件组权限成员列表</para>
    /// </summary>
    public record MailgroupPermissionMember
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
}
