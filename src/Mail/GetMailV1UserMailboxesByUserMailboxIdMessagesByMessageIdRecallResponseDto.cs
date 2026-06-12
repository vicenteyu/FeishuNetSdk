// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="GetMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdRecallResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取邮件撤回进度 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 获取邮件撤回进度 响应体
/// <para>查询指定邮件的撤回结果详情，包括整体撤回进度、成功/失败/处理中的收件人数量，以及每个收件人的撤回状态和失败原因。</para>
/// <para>接口ID：7629252749259918546</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-sent_message/get_recall_detail</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-sent_message%2fget_recall_detail</para>
/// </summary>
public record GetMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdRecallResponseDto
{
    /// <summary>
    /// <para>整体撤回进度</para>
    /// <para>必填：否</para>
    /// <para>示例值：done</para>
    /// <para>可选值：<list type="bullet">
    /// <item>in_progress：邮件撤回中</item>
    /// <item>done：邮件撤回结束</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("recall_status")]
    public string? RecallStatus { get; set; }

    /// <summary>
    /// <para>撤回最终结果，仅recall_status为done时有意义</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_success</para>
    /// <para>可选值：<list type="bullet">
    /// <item>all_success：邮件已撤回</item>
    /// <item>all_fail：邮件撤回失败</item>
    /// <item>some_fail：部分撤回失败</item>
    /// <item>processing：邮件撤回中</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("recall_result")]
    public string? RecallResult { get; set; }

    /// <summary>
    /// <para>撤回成功的收件人数</para>
    /// <para>必填：否</para>
    /// <para>示例值：3</para>
    /// </summary>
    [JsonPropertyName("success_count")]
    public int? SuccessCount { get; set; }

    /// <summary>
    /// <para>撤回失败的收件人数</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("failure_count")]
    public int? FailureCount { get; set; }

    /// <summary>
    /// <para>处理中的收件人数</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// </summary>
    [JsonPropertyName("processing_count")]
    public int? ProcessingCount { get; set; }

    /// <summary>
    /// <para>每个收件人的撤回详情列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public RecallDetailItem[]? Items { get; set; }

    /// <summary>
    /// <para>每个收件人的撤回详情列表</para>
    /// </summary>
    public record RecallDetailItem
    {
        /// <summary>
        /// <para>收件人邮箱地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：zhangsan@example.com</para>
        /// </summary>
        [JsonPropertyName("recipient_address")]
        public string? RecipientAddress { get; set; }

        /// <summary>
        /// <para>收件人显示名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonPropertyName("recipient_name")]
        public string? RecipientName { get; set; }

        /// <summary>
        /// <para>该收件人的撤回状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：success</para>
        /// <para>可选值：<list type="bullet">
        /// <item>success：撤回成功</item>
        /// <item>fail：撤回失败</item>
        /// <item>processing：处理中</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// <para>撤回失败原因，仅status为fail时有值</para>
        /// <para>必填：否</para>
        /// <para>示例值：message_has_been_read</para>
        /// <para>可选值：<list type="bullet">
        /// <item>message_has_been_read：邮件已读</item>
        /// <item>not_using_lark_mail：不支持撤回发往外部的邮件</item>
        /// <item>not_in_the_same_tenant：收件人域名为外部域名</item>
        /// <item>invalid_address：地址已失效</item>
        /// <item>unknown：其他原因</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("fail_reason")]
        public string? FailReason { get; set; }

        /// <summary>
        /// <para>是否为邮件组地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_mailing_list")]
        public bool? IsMailingList { get; set; }

        /// <summary>
        /// <para>邮件组内成功撤回人数，仅is_mailing_list为true时有值</para>
        /// <para>必填：否</para>
        /// <para>示例值：5</para>
        /// <para>最大值：2147483647</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("mailing_list_success_count")]
        public int? MailingListSuccessCount { get; set; }

        /// <summary>
        /// <para>邮件组内撤回失败人数，仅is_mailing_list为true时有值</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>最大值：2147483647</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("mailing_list_failure_count")]
        public int? MailingListFailureCount { get; set; }

        /// <summary>
        /// <para>邮件组完成百分比0-100，仅is_mailing_list为true时有值</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// <para>最大值：2147483647</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("mailing_list_finish_percent")]
        public int? MailingListFinishPercent { get; set; }
    }
}
