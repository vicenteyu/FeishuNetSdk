// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-03-14
//
// Last Modified By : yxr
// Last Modified On : 2025-03-14
// ************************************************************************
// <copyright file="GetPayrollV1PaymentActivityDetailsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询发薪活动明细列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Payroll;
/// <summary>
/// 查询发薪活动明细列表 响应体
/// <para>根据「发薪活动 ID 」和「分页参数」查询发薪活动明细列表和关联的算薪明细分段数据。</para>
/// <para>## 使用场景</para>
/// <para>&gt; 当前接口仅支持查询某个发薪活动下的所有发薪明细数据，若需要查询某些员工在特定范围内的发薪明细，请使用[批量查询发薪明细](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/payroll-v1/payment_detail/query)接口。</para>
/// <para>接口ID：7411460155089502211</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/payment_detail/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fpayment_activity_detail%2flist</para>
/// </summary>
public record GetPayrollV1PaymentActivityDetailsResponseDto
{
    /// <summary>
    /// <para>发薪明细列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("payment_activity_details")]
    public PaymentActivityDetail[]? PaymentActivityDetails { get; set; }

    /// <summary>
    /// <para>发薪明细列表</para>
    /// </summary>
    public record PaymentActivityDetail
    {
        /// <summary>
        /// <para>员工的飞书人事雇佣 ID，调用[搜索员工信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口后，可以从返回结果中获取到飞书人事雇佣 ID。</para>
        /// <para>注：调用[搜索员工信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口时，查询入参 user_id_type 应为 people_corehr_id。</para>
        /// <para>必填：否</para>
        /// <para>示例值：7202076988667019308</para>
        /// </summary>
        [JsonPropertyName("employee_id")]
        public string? EmployeeId { get; set; }

        /// <summary>
        /// <para>发薪明细详情</para>
        /// <para>必填：否</para>
        /// <para>最大长度：1000000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("payment_details")]
        public PaymentAccountingItem[]? PaymentDetails { get; set; }

        /// <summary>
        /// <para>发薪明细详情</para>
        /// </summary>
        public record PaymentAccountingItem
        {
            /// <summary>
            /// <para>算薪项 ID，调用[批量查询算薪项](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/payroll-v1/acct_item/list)接口后，可以从返回结果中获取到算薪项 ID。</para>
            /// <para>注：明细中返回的部分算薪项可能不存在于[批量查询算薪项](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/payroll-v1/acct_item/list)的接口结果中。</para>
            /// <para>必填：否</para>
            /// <para>示例值：7202076988667019308</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>算薪项名称</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("accounting_item_names")]
            public I18nContent[]? AccountingItemNames { get; set; }

            /// <summary>
            /// <para>算薪项名称</para>
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
            /// <para>算薪项值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("accounting_item_value")]
            public PaymentAccountingItemAccountingItemValue? AccountingItemValue { get; set; }

            /// <summary>
            /// <para>算薪项值</para>
            /// </summary>
            public record PaymentAccountingItemAccountingItemValue
            {
                /// <summary>
                /// <para>算薪项数据原始值，当发薪明细的数据来源为「人工导入」时，如果当前算薪项类型为引用类型，那么算薪项原始值可能为空。</para>
                /// <para>必填：否</para>
                /// <para>示例值：100</para>
                /// </summary>
                [JsonPropertyName("original_value")]
                public string? OriginalValue { get; set; }

                /// <summary>
                /// <para>引用类型算薪项展示值</para>
                /// <para>必填：否</para>
                /// <para>最大长度：100000</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("reference_values")]
                public I18nContent[]? ReferenceValues { get; set; }

                /// <summary>
                /// <para>引用类型算薪项展示值</para>
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
            /// <para>算薪项分段数据</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("segment_values")]
            public SegmentValue[]? SegmentValues { get; set; }

            /// <summary>
            /// <para>算薪项分段数据</para>
            /// </summary>
            public record SegmentValue
            {
                /// <summary>
                /// <para>分段开始时间-毫秒级时间戳，[start_time, end_time] 是一个左闭右闭区间。</para>
                /// <para>必填：否</para>
                /// <para>示例值：7220356259681386540</para>
                /// </summary>
                [JsonPropertyName("start_time")]
                public string? StartTime { get; set; }

                /// <summary>
                /// <para>分段结束时间-毫秒级时间戳，[start_time, end_time] 是一个左闭右闭区间。</para>
                /// <para>必填：否</para>
                /// <para>示例值：7220356259681386540</para>
                /// </summary>
                [JsonPropertyName("end_time")]
                public string? EndTime { get; set; }

                /// <summary>
                /// <para>引用类型算薪项分段展示值</para>
                /// <para>必填：否</para>
                /// <para>最大长度：100000</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("reference_values")]
                public I18nContent[]? ReferenceValues { get; set; }

                /// <summary>
                /// <para>引用类型算薪项分段展示值</para>
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
                /// <para>算薪项分段原始值</para>
                /// <para>必填：否</para>
                /// <para>示例值：10000</para>
                /// </summary>
                [JsonPropertyName("original_value")]
                public string? OriginalValue { get; set; }
            }

            /// <summary>
            /// <para>算薪项类型，1-文本；2-金额；3-数值；4-百分比；5-日期；6-引用</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>最大值：10000</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("accounting_item_type")]
            public int? AccountingItemType { get; set; }
        }
    }

    /// <summary>
    /// <para>发薪明细总数</para>
    /// <para>必填：否</para>
    /// <para>示例值：50000</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }
}
