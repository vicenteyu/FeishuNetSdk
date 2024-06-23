// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchMailV1MailgroupsByMailgroupIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>修改邮件组部分信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 修改邮件组部分信息 请求体
/// <para>更新邮件组部分字段，没有填写的字段不会被更新。</para>
/// <para>接口ID：6954915601882710019</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup%2fpatch</para>
/// </summary>
public record PatchMailV1MailgroupsByMailgroupIdBodyDto
{
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
    /// <para>示例值：testmailgroup</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>邮件组描述</para>
    /// <para>必填：否</para>
    /// <para>示例值：mailgroupfortesting</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

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
