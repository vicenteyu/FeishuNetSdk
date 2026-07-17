// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-17
//
// Last Modified By : yxr
// Last Modified On : 2026-07-17
// ************************************************************************
// <copyright file="PostApprovalV4TasksSubscriptionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>订阅审批任务状态变更事件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 订阅审批任务状态变更事件 请求体
/// <para>当应用[订阅审批事件](https://open.feishu.cn/document/ukTMukTMukTM/uUTNz4SN1MjL1UzM)后，对于事件type为[审批任务状态变更事件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/task/events/status_changed)的事件</para>
/// <para>需要调用该接口指定需要接收通知的审批任务范围，指定后才可以接收到对应范围内的事件。</para>
/// <para>接口ID：7663359183039761673</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/task/subscription</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2fsubscription</para>
/// </summary>
public record PostApprovalV4TasksSubscriptionBodyDto
{
    /// <summary>
    /// <para>订阅类型，用于指定需要接收通知的审批任务范围。</para>
    /// <para>必填：是</para>
    /// <para>示例值：INVOLVED_APPROVAL</para>
    /// <para>可选值：<list type="bullet">
    /// <item>INVOLVED_APPROVAL：订阅自身作为审批人的参与类审批任务通知</item>
    /// <item>MANAGED_APPROVAL：订阅自身作为审批管理员的管理类审批任务通知</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("subscription_type")]
    public string SubscriptionType { get; set; } = string.Empty;
}
