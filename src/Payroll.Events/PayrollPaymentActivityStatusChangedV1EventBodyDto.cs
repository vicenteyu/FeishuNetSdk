// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-03-14
//
// Last Modified By : yxr
// Last Modified On : 2025-03-14
// ************************************************************************
// <copyright file="PayrollPaymentActivityStatusChangedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发薪活动变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Payroll.Events;
/// <summary>
/// 发薪活动变更 事件体
/// <para>当发薪活动发生变更后，订阅这个事件的应用会收到事件。当前仅审批通过、审批撤销、跳过审批、封存、取消封存，会发送该事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=payroll&amp;version=v1&amp;resource=payment_activity&amp;event=status_changed)</para>
/// <para>接口ID：7441890276475158531</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/payroll-v1/payment_activity/events/status_changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fpayment_activity%2fevents%2fstatus_changed</para>
/// </summary>
public record PayrollPaymentActivityStatusChangedV1EventBodyDto() : EventBodyDto("payroll.payment_activity.status_changed_v1")
{
    /// <summary>
    /// <para>发薪活动ID，详情可查看[查询发薪活动列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/payroll-v1/payment_activity/list)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("activity_id")]
    public string? ActivityId { get; set; }

    /// <summary>
    /// <para>发薪活动变更类型</para>
    /// <para>- 2：封存</para>
    /// <para>- 3：取消封存</para>
    /// <para>- 4：撤销审批</para>
    /// <para>- 5：跳过审批</para>
    /// <para>- 6：审批通过</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 取值范围：`0` ～ `10000`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }
}
