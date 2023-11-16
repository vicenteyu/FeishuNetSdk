namespace FeishuNetSdk.Mail;
/// <summary>
/// 创建邮件组别名 响应体
/// <para>创建邮件组别名。</para>
/// <para>接口ID：6993201646486536194</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-alias/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-alias%2fcreate</para>
/// </summary>
public record PostMailV1MailgroupsByMailgroupIdAliasesResponseDto
{
    /// <summary>
    /// <para>邮件组别名</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("mailgroup_alias")]
    public EmailAlias? MailgroupAlias { get; set; }

    /// <summary>
    /// <para>邮件组别名</para>
    /// </summary>
    public record EmailAlias
    {
        /// <summary>
        /// <para>主邮箱地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxx@xx.xxx</para>
        /// </summary>
        [JsonPropertyName("primary_email")]
        public string? PrimaryEmail { get; set; }

        /// <summary>
        /// <para>邮箱别名</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxx@xx.xxx</para>
        /// </summary>
        [JsonPropertyName("email_alias")]
        public string? EmailAliasSuffix { get; set; }
    }
}
