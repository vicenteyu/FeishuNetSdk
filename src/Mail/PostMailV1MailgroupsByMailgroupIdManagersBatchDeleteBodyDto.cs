using Newtonsoft.Json;
namespace FeishuNetSdk.Mail;
/// <summary>
/// 批量删除邮件组管理员 请求体
/// <para>批量删除邮件组管理员。</para>
/// <para>接口ID：7172379500607700996</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-manager/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-manager%2fbatch_delete</para>
/// </summary>
public record PostMailV1MailgroupsByMailgroupIdManagersBatchDeleteBodyDto
{
    /// <summary>
    /// <para>邮件组管理员列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：200</para>
    /// </summary>
    [JsonProperty("mailgroup_manager_list")]
    public MailgroupManager[]? MailgroupManagerLists { get; set; }

    /// <summary>
    /// <para>邮件组管理员列表</para>
    /// </summary>
    public record MailgroupManager
    {
        /// <summary>
        /// <para>管理员用户ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxxxxx</para>
        /// <para>最大长度：1024</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string? UserId { get; set; }
    }
}
