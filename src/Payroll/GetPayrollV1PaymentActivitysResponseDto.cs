// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-03-14
//
// Last Modified By : yxr
// Last Modified On : 2025-03-14
// ************************************************************************
// <copyright file="GetPayrollV1PaymentActivitysResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询发薪活动列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Payroll;
/// <summary>
/// 查询发薪活动列表 响应体
/// <para>根据「发薪日起止范围」、「发薪活动状态」和「分页参数」查询发薪活动列表。</para>
/// <para>接口ID：7411460155089518595</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/payment_activity/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fpayment_activity%2flist</para>
/// </summary>
public record GetPayrollV1PaymentActivitysResponseDto : IPageableResponse<GetPayrollV1PaymentActivitysResponseDto.PaymentActivity>
{
    /// <inheritdoc/>
    [JsonIgnore]
    public PaymentActivity[]? Items => PaymentActivitys;

    /// <summary>
    /// <para>发薪活动列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("payment_activitys")]
    public PaymentActivity[]? PaymentActivitys { get; set; }

    /// <summary>
    /// <para>发薪活动列表</para>
    /// </summary>
    public record PaymentActivity
    {
        /// <summary>
        /// <para>发薪活动唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：7202076988667019308</para>
        /// <para>最大长度：50</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string? ActivityId { get; set; }

        /// <summary>
        /// <para>发薪活动名称</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("activity_names")]
        public I18nContent[]? ActivityNames { get; set; }

        /// <summary>
        /// <para>发薪活动名称</para>
        /// </summary>
        public record I18nContent
        {
            /// <summary>
            /// <para>语种</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh_cn</para>
            /// <para>默认值：zh_cn</para>
            /// </summary>
            [JsonPropertyName("locale")]
            public string? Locale { get; set; }

            /// <summary>
            /// <para>语种对应的值</para>
            /// <para>必填：否</para>
            /// <para>示例值：名称</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }

        /// <summary>
        /// <para>发薪活动发薪日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-10-31</para>
        /// <para>最大长度：99</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("pay_date")]
        public string? PayDate { get; set; }

        /// <summary>
        /// <para>发薪总笔数</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// <para>最大值：10000000</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("total_number_of_payroll")]
        public int? TotalNumberOfPayroll { get; set; }

        /// <summary>
        /// <para>关联的算薪活动个数</para>
        /// <para>必填：否</para>
        /// <para>示例值：1000</para>
        /// <para>最大值：100000</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("number_of_calculation_activities")]
        public int? NumberOfCalculationActivities { get; set; }

        /// <summary>
        /// <para>发薪活动关联的算薪活动详情</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("calculation_activities")]
        public CalculationActivity[]? CalculationActivities { get; set; }

        /// <summary>
        /// <para>发薪活动关联的算薪活动详情</para>
        /// </summary>
        public record CalculationActivity
        {
            /// <summary>
            /// <para>算薪活动唯一标识</para>
            /// <para>必填：否</para>
            /// <para>示例值：7371828319837012009</para>
            /// <para>最大长度：50</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("calculation_activity_id")]
            public string? CalculationActivityId { get; set; }

            /// <summary>
            /// <para>算薪活动名称</para>
            /// <para>必填：否</para>
            /// <para>最大长度：10000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("calculation_activity_names")]
            public I18nContent[]? CalculationActivityNames { get; set; }

            /// <summary>
            /// <para>算薪活动名称</para>
            /// </summary>
            public record I18nContent
            {
                /// <summary>
                /// <para>语种</para>
                /// <para>必填：否</para>
                /// <para>示例值：zh_cn</para>
                /// <para>默认值：zh_cn</para>
                /// </summary>
                [JsonPropertyName("locale")]
                public string? Locale { get; set; }

                /// <summary>
                /// <para>语种对应的值</para>
                /// <para>必填：否</para>
                /// <para>示例值：名称</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }
        }

        /// <summary>
        /// <para>发薪活动审批状态，其中：100-待确认发薪名单；150-待提交审批；200-审批中；300-审批被拒绝；350-审批被撤回；360-审批被撤销；375-审批通过；400-已封存。</para>
        /// <para>必填：否</para>
        /// <para>示例值：400</para>
        /// <para>最大值：10000</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("activity_status")]
        public int? ActivityStatus { get; set; }
    }

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
}
