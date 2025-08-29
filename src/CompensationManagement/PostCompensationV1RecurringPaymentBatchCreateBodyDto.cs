// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-30
//
// Last Modified By : yxr
// Last Modified On : 2025-08-30
// ************************************************************************
// <copyright file="PostCompensationV1RecurringPaymentBatchCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量创建经常性支付记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 批量创建经常性支付记录 请求体
/// <para>根据传入的参数，校验并创建经常性支付记录，返回创建失败的原因或创建成功的数据ID</para>
/// <para>接口ID：7441804833880211460</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/recurring_payment/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2frecurring_payment%2fbatch_create</para>
/// </summary>
public record PostCompensationV1RecurringPaymentBatchCreateBodyDto
{
    /// <summary>
    /// <para>要创建的经常性支付记录</para>
    /// <para>必填：否</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("records")]
    public RecurringPaymentForCreate[]? Records { get; set; }

    /// <summary>
    /// <para>要创建的经常性支付记录</para>
    /// </summary>
    public record RecurringPaymentForCreate
    {
        /// <summary>
        /// <para>经常性支付记录 unique_id，unique_id 在创建时由上游指定</para>
        /// <para>必填：是</para>
        /// <para>示例值：7402510801304718380_7309316347007764012_7402523725868058156_1726070400000_10000</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; } = string.Empty;

        /// <summary>
        /// <para>员工id，具体类型由入参中的 user_id_type 指定</para>
        /// <para>必填：是</para>
        /// <para>示例值：7337149697626801708</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>薪酬项 id（通过[【查询薪酬项】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/item/list)) 接口进行查询）</para>
        /// <para>必填：是</para>
        /// <para>示例值：7411039006180312620</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; } = string.Empty;

        /// <summary>
        /// <para>每次发放金额</para>
        /// <para>必填：是</para>
        /// <para>示例值：20.00</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("each_amount")]
        public string EachAmount { get; set; } = string.Empty;

        /// <summary>
        /// <para>发放开始时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：2024-08-01</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; } = string.Empty;

        /// <summary>
        /// <para>发放结束时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：2025-08-01</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; } = string.Empty;

        /// <summary>
        /// <para>币种 id（通过[【查询币种】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-currency/search)) 接口进行查询）</para>
        /// <para>必填：是</para>
        /// <para>示例值：6863329932261459464</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("currency_id")]
        public string CurrencyId { get; set; } = string.Empty;

        /// <summary>
        /// <para>发放方式</para>
        /// <para>必填：是</para>
        /// <para>示例值：with_salary</para>
        /// <para>可选值：<list type="bullet">
        /// <item>with_salary：随工资发放</item>
        /// <item>with_cash：现金发放</item>
        /// <item>with_physical_distribution：实物发放</item>
        /// <item>with_year_end_bonus：随年终奖发放</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("issuance_type")]
        public string IssuanceType { get; set; } = string.Empty;

        /// <summary>
        /// <para>发放频率</para>
        /// <para>必填：是</para>
        /// <para>示例值：year</para>
        /// <para>可选值：<list type="bullet">
        /// <item>year：年</item>
        /// <item>half_year：半年</item>
        /// <item>quarterly：季度</item>
        /// <item>bimonthly：双月</item>
        /// <item>month：月</item>
        /// <item>biweekly：双周</item>
        /// <item>week：周</item>
        /// <item>day：天</item>
        /// <item>hour：小时</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("issuance_period")]
        public string IssuancePeriod { get; set; } = string.Empty;

        /// <summary>
        /// <para>备注</para>
        /// <para>必填：否</para>
        /// <para>示例值：这是个备注</para>
        /// <para>最大长度：3000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// <para>发放国家id（可通过 https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search进行查询）</para>
        /// <para>必填：否</para>
        /// <para>示例值：6862995745046267400</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("issuance_country_region_id")]
        public string? IssuanceCountryRegionId { get; set; }
    }
}
