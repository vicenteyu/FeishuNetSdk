using Newtonsoft.Json;
namespace FeishuNetSdk.Mail;
/// <summary>
/// 查询所有公共邮箱 响应体
/// <para>分页批量获取公共邮箱列表。</para>
/// <para>接口ID：6954915601882955779</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/public-mailbox/public_mailbox/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox%2flist</para>
/// </summary>
public record GetMailV1PublicMailboxesResponseDto
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxx</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>公共邮箱列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public PublicMailbox[]? Items { get; set; }

    /// <summary>
    /// <para>公共邮箱列表</para>
    /// </summary>
    public record PublicMailbox
    {
        /// <summary>
        /// <para>公共邮箱唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxxxxxxxxxxxxxx</para>
        /// </summary>
        [JsonProperty("public_mailbox_id")]
        public string? PublicMailboxId { get; set; }

        /// <summary>
        /// <para>公共邮箱地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：test_public_mailbox@xxx.xx</para>
        /// </summary>
        [JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// <para>公共邮箱名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：testpublicmailbox</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}
