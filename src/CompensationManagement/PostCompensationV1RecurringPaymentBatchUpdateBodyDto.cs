// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-30
//
// Last Modified By : yxr
// Last Modified On : 2025-08-30
// ************************************************************************
// <copyright file="PostCompensationV1RecurringPaymentBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量更正经常性支付记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 批量更正经常性支付记录 请求体
/// <para>批量更正经常性支付记录</para>
/// <para>接口ID：7441804833880244228</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/recurring_payment/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2frecurring_payment%2fbatch_update</para>
/// </summary>
public record PostCompensationV1RecurringPaymentBatchUpdateBodyDto
{
    /// <summary>
    /// <para>需更正的经常性支付记录</para>
    /// <para>必填：否</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("records")]
    public RecurringPaymentForUpdate[]? Records { get; set; }

    /// <summary>
    /// <para>需更正的经常性支付记录</para>
    /// </summary>
    public record RecurringPaymentForUpdate
    {
        /// <summary>
        /// <para>经常性支付记录id</para>
        /// <para>必填：是</para>
        /// <para>示例值：7397033607132351532</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>每次发放金额</para>
        /// <para>必填：是</para>
        /// <para>示例值：10.00</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("each_amount")]
        public string EachAmount { get; set; } = string.Empty;

        /// <summary>
        /// <para>发放开始时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：2024-10-20</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; } = string.Empty;

        /// <summary>
        /// <para>发放结束时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：2025-03-20</para>
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
        /// <para>原因</para>
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
