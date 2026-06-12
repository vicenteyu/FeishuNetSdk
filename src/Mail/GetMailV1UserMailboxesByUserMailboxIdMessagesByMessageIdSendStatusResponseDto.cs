// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="GetMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdSendStatusResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询邮件发送状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 查询邮件发送状态 响应体
/// <para>查询指定邮件的发送状态，返回邮件业务标识 ID 及各收件人的投递状态、最后更新时间。调用前需先通过发送邮件接口获取返回的邮件业务标识 ID（message_id），再使用该 ID 查询发送状态。</para>
/// <para>接口ID：7649297073556982987</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-message/send_status</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-message%2fsend_status</para>
/// </summary>
public record GetMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdSendStatusResponseDto
{
    /// <summary>
    /// <para>邮件业务标识 ID，与请求路径中的 message_id 对应。</para>
    /// <para>必填：否</para>
    /// <para>示例值：197c5d72e22e1d78</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }

    /// <summary>
    /// <para>收件人投递状态列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("details")]
    public SendStatusDetail[]? Details { get; set; }

    /// <summary>
    /// <para>收件人投递状态列表</para>
    /// </summary>
    public record SendStatusDetail
    {
        /// <summary>
        /// <para>收件人信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("recipient")]
        public MailAddress? Recipient { get; set; }

        /// <summary>
        /// <para>收件人信息</para>
        /// </summary>
        public record MailAddress
        {
            /// <summary>
            /// <para>邮件地址</para>
            /// <para>必填：是</para>
            /// <para>示例值：mike@outlook.com</para>
            /// </summary>
            [JsonPropertyName("mail_address")]
            public string MailAddressSuffix { get; set; } = string.Empty;

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：Mike</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }

        /// <summary>
        /// <para>投递状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：正在投递</item>
        /// <item>2：投递失败重试</item>
        /// <item>3：投递失败退信</item>
        /// <item>4：投递成功</item>
        /// <item>5：待审批</item>
        /// <item>6：审批拒绝</item>
        /// <item>0：未知</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// <para>最后更新时间（Unix 时间戳，秒）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1700000000</para>
        /// <para>最大值：170000000000</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("last_updated_time")]
        public int? LastUpdatedTime { get; set; }
    }
}
