// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="PostMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdRecallResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>撤回已发送邮件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 撤回已发送邮件 响应体
/// <para>撤回指定邮件。</para>
/// <para>前置条件：邮件须已投递，且发送时间在 24 小时以内；搬家中的域名不支持撤回。</para>
/// <para>返回说明：若用户或邮件不满足撤回条件，接口仍返回 200，响应体中 recall_status 为 unavailable，recall_restriction_reason 标明具体原因。返回成功仅表示撤回请求已受理，实际撤回结果请调用「查询邮件撤回进度」接口获取。</para>
/// <para>接口ID：7629252749259934930</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-sent_message/recall</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-sent_message%2frecall</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdRecallResponseDto
{
    /// <summary>
    /// <para>撤回状态。仅当不支持撤回时返回unavailable</para>
    /// <para>必填：否</para>
    /// <para>示例值：unavailable</para>
    /// <para>可选值：<list type="bullet">
    /// <item>unavailable：邮件不可撤回</item>
    /// <item>available：邮件可撤回</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("recall_status")]
    public string? RecallStatus { get; set; }

    /// <summary>
    /// <para>不支持撤回的原因。仅当recall_status为unavailable时返回</para>
    /// <para>必填：否</para>
    /// <para>示例值：recall_not_enabled</para>
    /// <para>可选值：<list type="bullet">
    /// <item>recall_not_enabled：暂未开放撤回功能</item>
    /// <item>migration_domain：你的地址未使用Lark邮箱服务，无法在Lark内进行撤回</item>
    /// <item>sender_address_not_owned：邮件发件人地址不是用户可用发信地址</item>
    /// <item>already_recalled：邮件已发起锅撤回</item>
    /// <item>not_delivered：未发送的邮件无法撤回</item>
    /// <item>exceeded_time_limit：无法撤回 24 小时前发送的邮件</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("recall_restriction_reason")]
    public string? RecallRestrictionReason { get; set; }
}
