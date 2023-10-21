using Newtonsoft.Json;
namespace FeishuNetSdk.Mail;
/// <summary>
/// 修改公共邮箱部分信息 响应体
/// <para>更新公共邮箱部分字段，没有填写的字段不会被更新。</para>
/// <para>接口ID：6954915601883136003</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/public-mailbox/public_mailbox/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox%2fpatch</para>
/// </summary>
public record PatchMailV1PublicMailboxesByPublicMailboxIdResponseDto
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
