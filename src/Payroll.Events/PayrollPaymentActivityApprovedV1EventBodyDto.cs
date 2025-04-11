// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-03-14
//
// Last Modified By : yxr
// Last Modified On : 2025-03-14
// ************************************************************************
// <copyright file="PayrollPaymentActivityApprovedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发薪活动封存 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Payroll.Events;
/// <summary>
/// 发薪活动封存 事件体
/// <para>当发薪活动封存后，订阅这个事件的应用会收到事件。</para>
/// <para>一个发薪活动封存后，可能会向事件监听方发送多条 `activity_id` 相同的事件通知，事件监听方需要针对 `activity_id` 做好幂等处理。</para>
/// <para>{使用示例}(url=/api/tools/api_explore/api_explore_config?project=payroll&amp;version=v1&amp;resource=payment_activity&amp;event=approved)</para>
/// <para>接口ID：7411460155089534979</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/payment_activity/events/approved</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fpayment_activity%2fevents%2fapproved</para>
/// </summary>
public record PayrollPaymentActivityApprovedV1EventBodyDto() : EventBodyDto("payroll.payment_activity.approved_v1")
{
    /// <summary>
    /// <para>封存的发薪活动 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("activity_id")]
    public string? ActivityId { get; set; }
}
