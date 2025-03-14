// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-03-14
//
// Last Modified By : yxr
// Last Modified On : 2025-03-14
// ************************************************************************
// <copyright file="PostPayrollV1PaymentActivitysArchiveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>封存发薪活动 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Payroll;
/// <summary>
/// 封存发薪活动 请求体
/// <para>根据发薪活动ID对发薪活动进行封存。注意：仅当发薪活动状态为审批通过时，方可进行封存。</para>
/// <para>接口ID：7441890276475142147</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/payroll-v1/payment_activity/archive</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fpayment_activity%2farchive</para>
/// </summary>
public record PostPayrollV1PaymentActivitysArchiveBodyDto
{
    /// <summary>
    /// <para>发薪活动ID，可通过[查询发薪活动列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/payroll-v1/payment_activity/list)获取。</para>
    /// <para>必填：是</para>
    /// <para>示例值：7433255159377444875</para>
    /// </summary>
    [JsonPropertyName("activity_id")]
    public string ActivityId { get; set; } = string.Empty;
}
