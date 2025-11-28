// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-03-14
//
// Last Modified By : yxr
// Last Modified On : 2025-03-14
// ************************************************************************
// <copyright file="PostPayrollV1PaymentDetailQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询发薪明细 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Payroll;
/// <summary>
/// 批量查询发薪明细 请求体
/// <para>根据 __发薪活动 ID 列表__ 、__发薪日起止时间__ 和 __飞书人事雇佣 ID 列表__ 分页查询发薪明细列表和关联的算薪明细分段数据。</para>
/// <para>## 注意事项</para>
/// <para>1. 批量查询发薪明细接口提供的请求参数中，用户必须填写「__发薪日起止时间__（pay_period_start_date，pay_period_end_date）」或「__发薪活动 ID 列表__」，当传入的三个参数均为空时，开放接口将返回 2500006 错误码。</para>
/// <para>2. 每一次调用接口时，系统最多会扫描 __50__ 个发薪活动，当用户传入的查询条件命中的发薪活动个数大于 __50__ 时，开放接口将根据查询参数返回 2500003 或 2500008 错误码，请合理使用查询参数。</para>
/// <para>3. 开放接口中的「员工的飞书人事雇佣 ID 列表（employee_ids）」参数为必填。</para>
/// <para>接口ID：7431973248228638722</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/payment_detail/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fpayment_detail%2fquery</para>
/// </summary>
public record PostPayrollV1PaymentDetailQueryBodyDto
{
    /// <summary>
    /// <para>页码，第一页从 1 开始</para>
    /// <para>必填：是</para>
    /// <para>示例值：100</para>
    /// <para>最大值：100000</para>
    /// <para>最小值：1</para>
    /// </summary>
    [JsonPropertyName("page_index")]
    public int PageIndex { get; set; }

    /// <summary>
    /// <para>每页大小，范围为：[1, 100]</para>
    /// <para>必填：是</para>
    /// <para>示例值：10</para>
    /// </summary>
    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }

    /// <summary>
    /// <para>算薪项 ID 列表，调用[批量查询算薪项](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/payroll-v1/acct_item/list)接口后，可以从返回结果中获取到算薪项 ID。</para>
    /// <para>1. 当前参数传空时，接口会返回发薪明细中所有的算薪项；</para>
    /// <para>2. 当前参数不为空时，接口只返回发薪明细中与 acct_item_ids 存在交集的算薪项。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("acct_item_ids")]
    public string[]? AcctItemIds { get; set; }

    /// <summary>
    /// <para>员工的飞书人事雇佣 ID 列表，__该参数为必填__，调用[搜索员工信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口后，可以从返回结果中获取到飞书人事雇佣 ID。</para>
    /// <para>注：调用[搜索员工信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口时，查询入参 user_id_type 应为 people_corehr_id。</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("employee_ids")]
    public string[] EmployeeIds { get; set; } = [];

    /// <summary>
    /// <para>发薪日开始时间，格式：YYYY-MM-dd，[pay_period_start_date, pay_period_end_date] 是一个左闭右闭区间。</para>
    /// <para>必填：否</para>
    /// <para>示例值：2024-01-01</para>
    /// </summary>
    [JsonPropertyName("pay_period_start_date")]
    public string? PayPeriodStartDate { get; set; }

    /// <summary>
    /// <para>发薪日结束时间，格式：YYYY-MM-dd，[pay_period_start_date, pay_period_end_date] 是一个左闭右闭区间。</para>
    /// <para>1. pay_period_start_date 不得晚于 pay_period_end_date 。</para>
    /// <para>2. [pay_period_start_date, pay_period_end_date] 最大间隔为 12 个月。</para>
    /// <para>必填：否</para>
    /// <para>示例值：2024-01-31</para>
    /// </summary>
    [JsonPropertyName("pay_period_end_date")]
    public string? PayPeriodEndDate { get; set; }

    /// <summary>
    /// <para>发薪活动 ID 列表，调用[查询发薪活动列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/payroll-v1/payment_activity/list)接口后，可以从返回结果中获取到发薪活动 ID。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("activity_ids")]
    public string[]? ActivityIds { get; set; }

    /// <summary>
    /// <para>是否需要查询算薪明细的分段信息，如果不传该参数或传 false ，那么只返回发薪活动明细数据；如果该参数传了 true，那么同时返回发薪明细对应的算薪明细分段数据。</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("include_segment_data")]
    public bool? IncludeSegmentData { get; set; }
}
