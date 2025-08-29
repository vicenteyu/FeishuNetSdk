// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-30
//
// Last Modified By : yxr
// Last Modified On : 2025-08-30
// ************************************************************************
// <copyright file="PostCompensationV1RecurringPaymentQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询经常性支付记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 查询经常性支付记录 响应体
/// <para>通过筛选条件，批量查询经常性支付记录</para>
/// <para>接口ID：7441804833880227844</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/recurring_payment/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2frecurring_payment%2fquery</para>
/// </summary>
public record PostCompensationV1RecurringPaymentQueryResponseDto : IPageableResponse<PostCompensationV1RecurringPaymentQueryResponseDto.RecurringPayment>
{
    /// <summary>
    /// <para>经常性支付授予记录</para>
    /// </summary>
    [JsonPropertyName("items")]
    public RecurringPayment[]? Items => Records;

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>经常性支付授予记录</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("records")]
    public RecurringPayment[]? Records { get; set; }

    /// <summary>
    /// <para>经常性支付授予记录</para>
    /// </summary>
    public record RecurringPayment
    {
        /// <summary>
        /// <para>经常性支付记录id</para>
        /// <para>必填：否</para>
        /// <para>示例值：7397033607132351532</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>外部幂等id，由上游业务决定</para>
        /// <para>必填：否</para>
        /// <para>示例值：7402510801304718380_7309316347007764012_7402523725868058156_1726070400000_10000</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string? UniqueId { get; set; }

        /// <summary>
        /// <para>员工id，具体类型由入参中的 user_id_type 指定</para>
        /// <para>必填：否</para>
        /// <para>示例值：7337149697626801708</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>薪酬项id</para>
        /// <para>必填：否</para>
        /// <para>示例值：7411039006180312620</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// <para>发放方式</para>
        /// <para>必填：否</para>
        /// <para>示例值：with_salary</para>
        /// <para>可选值：<list type="bullet">
        /// <item>with_salary：随工资发放</item>
        /// <item>with_cash：现金发放</item>
        /// <item>with_physical_distribution：实物发放</item>
        /// <item>with_year_end_bonus：随年终奖发放</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("issuance_type")]
        public string? IssuanceType { get; set; }

        /// <summary>
        /// <para>单次发放金额</para>
        /// <para>必填：否</para>
        /// <para>示例值：24.00</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("each_amount")]
        public string? EachAmount { get; set; }

        /// <summary>
        /// <para>发放开始日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2024-01-10</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("start_date")]
        public string? StartDate { get; set; }

        /// <summary>
        /// <para>发放结束日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2025-01-20</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("end_date")]
        public string? EndDate { get; set; }

        /// <summary>
        /// <para>发放频率</para>
        /// <para>必填：否</para>
        /// <para>示例值：year</para>
        /// <para>可选值：<list type="bullet">
        /// <item>year：年</item>
        /// <item>half_year：半年</item>
        /// <item>quarterly：季度</item>
        /// <item>bimonthly：双月</item>
        /// <item>month：月</item>
        /// <item>biweekly：双周</item>
        /// <item>week：周</item>
        /// <item>day：日</item>
        /// <item>hour：小时</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("issuance_period")]
        public string? IssuancePeriod { get; set; }

        /// <summary>
        /// <para>币种id</para>
        /// <para>必填：否</para>
        /// <para>示例值：6863329932261459464</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("currency_id")]
        public string? CurrencyId { get; set; }

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
