namespace FeishuNetSdk.Mail;
/// <summary>
/// 获取用户邮箱所有别名 响应体
/// <para>获取用户邮箱所有别名。</para>
/// <para>接口ID：7034854712587780098</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/user_mailbox-alias/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-alias%2flist</para>
/// </summary>
public record GetMailV1UserMailboxesByUserMailboxIdAliasesResponseDto
{
    /// <summary>
    /// <para>用户邮箱别名</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public EmailAlias[]? Items { get; set; }

    /// <summary>
    /// <para>用户邮箱别名</para>
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
