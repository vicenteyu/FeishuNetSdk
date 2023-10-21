using Newtonsoft.Json;
namespace FeishuNetSdk.Mail;
/// <summary>
/// 创建公共邮箱别名 响应体
/// <para>创建公共邮箱别名。</para>
/// <para>接口ID：6993201646486470658</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/public-mailbox/public_mailbox-alias/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox-alias%2fcreate</para>
/// </summary>
public record PostMailV1PublicMailboxesByPublicMailboxIdAliasesResponseDto
{
    /// <summary>
    /// <para>公共邮箱别名</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("public_mailbox_alias")]
    public EmailAlias? PublicMailboxAlias { get; set; }

    /// <summary>
    /// <para>公共邮箱别名</para>
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
