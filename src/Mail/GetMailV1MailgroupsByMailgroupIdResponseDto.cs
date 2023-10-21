using Newtonsoft.Json;
namespace FeishuNetSdk.Mail;
/// <summary>
/// 查询指定邮件组 响应体
/// <para>获取特定邮件组信息。</para>
/// <para>接口ID：6954915601882759171</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup%2fget</para>
/// </summary>
public record GetMailV1MailgroupsByMailgroupIdResponseDto
{
    /// <summary>
    /// <para>邮件组ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxxxxxxxxxxxxxx</para>
    /// </summary>
    [JsonProperty("mailgroup_id")]
    public string? MailgroupId { get; set; }

    /// <summary>
    /// <para>邮件组地址</para>
    /// <para>必填：否</para>
    /// <para>示例值：test_mail_group@xxx.xx</para>
    /// </summary>
    [JsonProperty("email")]
    public string? Email { get; set; }

    /// <summary>
    /// <para>邮件组名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：testmailgroup</para>
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>邮件组描述</para>
    /// <para>必填：否</para>
    /// <para>示例值：mailgroupfortesting</para>
    /// </summary>
    [JsonProperty("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>邮件组成员数量</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// </summary>
    [JsonProperty("direct_members_count")]
    public string? DirectMembersCount { get; set; }

    /// <summary>
    /// <para>是否包含外部成员</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("include_external_member")]
    public bool? IncludeExternalMember { get; set; }

    /// <summary>
    /// <para>是否是全员邮件组</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonProperty("include_all_company_member")]
    public bool? IncludeAllCompanyMember { get; set; }

    /// <summary>
    /// <para>谁可发送邮件到此邮件组</para>
    /// <para>必填：否</para>
    /// <para>示例值：ALL_INTERNAL_USERS</para>
    /// <para>可选值：<list type="bullet">
    /// <item>ANYONE：任何人</item>
    /// <item>ALL_INTERNAL_USERS：仅组织内部成员</item>
    /// <item>ALL_GROUP_MEMBERS：仅邮件组成员</item>
    /// <item>CUSTOM_MEMBERS：自定义成员</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("who_can_send_mail")]
    public string? WhoCanSendMail { get; set; }
}
