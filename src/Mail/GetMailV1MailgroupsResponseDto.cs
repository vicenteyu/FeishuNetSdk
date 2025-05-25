// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetMailV1MailgroupsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取邮件组 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 批量获取邮件组 响应体
/// <para>分页批量获取邮件组</para>
/// <para>接口ID：6954915601882988547</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup%2flist</para>
/// </summary>
public record GetMailV1MailgroupsResponseDto : IPageableResponse<GetMailV1MailgroupsResponseDto.Mailgroup>
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxx</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>邮件组列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Mailgroup[]? Items { get; set; }

    /// <summary>
    /// <para>邮件组列表</para>
    /// </summary>
    public record Mailgroup
    {
        /// <summary>
        /// <para>邮件组ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxxxxxxxxxxxxxx</para>
        /// </summary>
        [JsonPropertyName("mailgroup_id")]
        public string? MailgroupId { get; set; }

        /// <summary>
        /// <para>邮件组地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：test_mail_group@xxx.xx</para>
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// <para>邮件组名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：test mail group</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>邮件组描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：mail group for testing</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>邮件组成员数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：10</para>
        /// </summary>
        [JsonPropertyName("direct_members_count")]
        public string? DirectMembersCount { get; set; }

        /// <summary>
        /// <para>是否包含外部成员</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("include_external_member")]
        public bool? IncludeExternalMember { get; set; }

        /// <summary>
        /// <para>是否是全员邮件组</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("include_all_company_member")]
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
        [JsonPropertyName("who_can_send_mail")]
        public string? WhoCanSendMail { get; set; }
    }
}
