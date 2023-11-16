namespace FeishuNetSdk.Mail;
/// <summary>
/// 创建邮件组成员 请求体
/// <para>向邮件组添加单个成员。</para>
/// <para>接口ID：6954915601883037699</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-member/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-member%2fcreate</para>
/// </summary>
public record PostMailV1MailgroupsByMailgroupIdMembersBodyDto
{
    /// <summary>
    /// <para>成员邮箱地址（当成员类型是EXTERNAL_USER/MAIL_GROUP/OTHER_MEMBER时有值）</para>
    /// <para>必填：否</para>
    /// <para>示例值：test_memeber@xxx.xx</para>
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

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
    /// <para>成员类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：USER</para>
    /// <para>可选值：<list type="bullet">
    /// <item>USER：内部用户</item>
    /// <item>DEPARTMENT：部门</item>
    /// <item>COMPANY：全员</item>
    /// <item>EXTERNAL_USER：外部用户</item>
    /// <item>MAIL_GROUP：邮件组</item>
    /// <item>PUBLIC_MAILBOX：memberisapublicmailbox</item>
    /// <item>OTHER_MEMBER：内部成员</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
