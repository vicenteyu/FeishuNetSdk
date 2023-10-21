using Newtonsoft.Json;
namespace FeishuNetSdk.Mail;
/// <summary>
/// 批量获取邮件组管理员 响应体
/// <para>批量获取邮件组管理员。</para>
/// <para>接口ID：7172379500607668228</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-manager/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-manager%2flist</para>
/// </summary>
public record GetMailV1MailgroupsByMailgroupIdManagersResponseDto
{
    /// <summary>
    /// <para>邮件组管理员列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：200</para>
    /// </summary>
    [JsonProperty("items")]
    public MailgroupManager[]? Items { get; set; }

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

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxxxxx</para>
    /// <para>最大长度：1048576</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }
}
