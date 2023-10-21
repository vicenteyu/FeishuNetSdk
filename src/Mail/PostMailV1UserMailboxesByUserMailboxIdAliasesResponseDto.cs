using Newtonsoft.Json;
namespace FeishuNetSdk.Mail;
/// <summary>
/// 创建用户邮箱别名 响应体
/// <para>创建用户邮箱别名。</para>
/// <para>接口ID：7034854712587763714</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/user_mailbox-alias/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-alias%2fcreate</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdAliasesResponseDto
{
    /// <summary>
    /// <para>用户邮箱别名</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("user_mailbox_alias")]
    public EmailAlias? UserMailboxAlias { get; set; }

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
        [JsonProperty("primary_email")]
        public string? PrimaryEmail { get; set; }

        /// <summary>
        /// <para>邮箱别名</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxx@xx.xxx</para>
        /// </summary>
        [JsonProperty("email_alias")]
        public string? EmailAliasSuffix { get; set; }
    }
}
