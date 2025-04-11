// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-04-11
//
// Last Modified By : yxr
// Last Modified On : 2025-04-11
// ************************************************************************
// <copyright file="MailUserMailboxEventMessageReceivedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>收信通知 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail.Events;
/// <summary>
/// 收信通知 事件体
/// <para>收信通知{使用示例}(url=/api/tools/api_explore/api_explore_config?project=mail&amp;version=v1&amp;resource=user_mailbox.event&amp;event=message_received)</para>
/// <para>接口ID：7275929163676041219</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-event/events/message_received</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-event%2fevents%2fmessage_received</para>
/// </summary>
public record MailUserMailboxEventMessageReceivedV1EventBodyDto() : EventBodyDto("mail.user_mailbox.event.message_received_v1")
{
    /// <summary>
    /// <para>收信的邮箱</para>
    /// <para>**字段权限要求**：</para>
    /// <para>- mail:user_mailbox.event.mail_address:read : 获取事件中的邮箱地址字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("mail_address")]
    public string? MailAddress { get; set; }

    /// <summary>
    /// <para>邮件 id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }

    /// <summary>
    /// <para>收到邮件的邮箱类型</para>
    /// <para>**可选值有**：</para>
    /// <para>1:个人邮箱,2:公共邮箱</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 取值范围：`1` ～ `2`</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：个人邮箱</item>
    /// <item>2：公共邮箱</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("mailbox_type")]
    public int? MailboxType { get; set; }

    /// <summary>
    /// <para>订阅者</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("subscriber")]
    public SubscriberSuffix? Subscriber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record SubscriberSuffix
    {
        /// <summary>
        /// <para>收到邮件的用户 id 列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_ids")]
        public UserIdSuffix[]? UserIds { get; set; }
    }
}
