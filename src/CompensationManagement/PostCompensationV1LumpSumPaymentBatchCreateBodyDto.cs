// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="PostCompensationV1LumpSumPaymentBatchCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量创建一次性支付记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 批量创建一次性支付记录 请求体
/// <para>通过传入的一次性支付记录数据，校验并创建一次性支付记录，并返回创建失败原因或创建成功数据的ID</para>
/// <para>接口ID：7429528484932812828</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/lump_sum_payment/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2flump_sum_payment%2fbatch_create</para>
/// </summary>
public record PostCompensationV1LumpSumPaymentBatchCreateBodyDto
{
    /// <summary>
    /// <para>要创建的一次性支付信息</para>
    /// <para>必填：否</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("records")]
    public LumpSumPaymentForCreate[]? Records { get; set; }

    /// <summary>
    /// <para>要创建的一次性支付信息</para>
    /// </summary>
    public record LumpSumPaymentForCreate
    {
        /// <summary>
        /// <para>外部幂等id，由上游业务决定</para>
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
        /// <para>总金额，字符串表达的数字，单位为入参中 currency_id 给定的币种</para>
        /// <para>必填：是</para>
        /// <para>示例值：2000.00</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; } = string.Empty;

        /// <summary>
        /// <para>绑定期，单位为月</para>
        /// <para>必填：是</para>
        /// <para>示例值：2</para>
        /// <para>最大值：2147483647</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("binding_period")]
        public int BindingPeriod { get; set; }

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
        /// <para>发放次数，必须与 details 的长度一致</para>
        /// <para>必填：是</para>
        /// <para>示例值：3</para>
        /// <para>最大值：2147483647</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("issuance_frequency")]
        public int IssuanceFrequency { get; set; }

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
        /// <para>所属期开始日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2024-08-01</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("reference_period_start_date")]
        public string? ReferencePeriodStartDate { get; set; }

        /// <summary>
        /// <para>所属期结束日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2024-08-01</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("reference_period_end_date")]
        public string? ReferencePeriodEndDate { get; set; }

        /// <summary>
        /// <para>发放明细列表</para>
        /// <para>必填：是</para>
        /// <para>最大长度：2147483647</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("details")]
        public LumpSumPaymentDetailForCreate[] Details { get; set; } = [];

        /// <summary>
        /// <para>发放明细列表</para>
        /// </summary>
        public record LumpSumPaymentDetailForCreate
        {
            /// <summary>
            /// <para>一次性支付明细发放金额，可转数字的字符串，单位为入参中 currency_id 给定的币种</para>
            /// <para>必填：是</para>
            /// <para>示例值：2000.00</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("issuance_amount")]
            public string IssuanceAmount { get; set; } = string.Empty;

            /// <summary>
            /// <para>发放状态</para>
            /// <para>必填：是</para>
            /// <para>示例值：to_be_issued</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>to_be_issued：应发放</item>
            /// <item>not_issued：不发放</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("issuance_status")]
            public string IssuanceStatus { get; set; } = string.Empty;

            /// <summary>
            /// <para>发放方式</para>
            /// <para>必填：是</para>
            /// <para>示例值：with_salary</para>
            /// <para>可选值：<list type="bullet">
            /// <item>with_salary：随工资发放</item>
            /// <item>with_cash：现金发放</item>
            /// <item>with_year_end_bonus：随年终奖发放</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("issuance_way")]
            public string IssuanceWay { get; set; } = string.Empty;

            /// <summary>
            /// <para>发放时间</para>
            /// <para>必填：是</para>
            /// <para>示例值：2024-08-01</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("issuance_time")]
            public string IssuanceTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>申请发放日期</para>
            /// <para>必填：是</para>
            /// <para>示例值：2025-01-20</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("belong_time")]
            public string BelongTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>发放国家ID（可通过[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)进行查询）</para>
            /// <para>必填：否</para>
            /// <para>示例值：6862995757234914824</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("issuance_country_region_id")]
            public string? IssuanceCountryRegionId { get; set; }

            /// <summary>
            /// <para>发放薪资组ID（可通过[获取薪资组基本信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/payroll-v1/paygroup/list)</para>
            /// <para>进行查询）</para>
            /// <para>必填：否</para>
            /// <para>示例值：6862995757234914824</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("issuance_pay_group_id")]
            public string? IssuancePayGroupId { get; set; }
        }

        /// <summary>
        /// <para>备注</para>
        /// <para>必填：否</para>
        /// <para>示例值：该员工表现优异，为其发放一笔奖金</para>
        /// <para>最大长度：3000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("remark")]
        public string? Remark { get; set; }
    }
}
