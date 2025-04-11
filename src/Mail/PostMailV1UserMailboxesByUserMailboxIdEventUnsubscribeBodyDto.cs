// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-04-11
//
// Last Modified By : yxr
// Last Modified On : 2025-04-11
// ************************************************************************
// <copyright file="PostMailV1UserMailboxesByUserMailboxIdEventUnsubscribeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>取消订阅 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 取消订阅 请求体
/// <para>取消订阅</para>
/// <para>接口ID：7275929163676254211</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-event/unsubscribe</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-event%2funsubscribe</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdEventUnsubscribeBodyDto
{
    /// <summary>
    /// <para>事件类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>最大值：1</para>
    /// <para>最小值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：邮件相关事件</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("event_type")]
    public int EventType { get; set; }
}
