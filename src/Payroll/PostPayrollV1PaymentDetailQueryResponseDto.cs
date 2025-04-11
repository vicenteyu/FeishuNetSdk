// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-03-14
//
// Last Modified By : yxr
// Last Modified On : 2025-03-14
// ************************************************************************
// <copyright file="PostPayrollV1PaymentDetailQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询发薪明细 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Payroll;
/// <summary>
/// 批量查询发薪明细 响应体
/// <para>根据 __发薪活动 ID 列表__ 、__发薪日起止时间__ 和 __飞书人事雇佣 ID 列表__ 分页查询发薪明细列表和关联的算薪明细分段数据。</para>
/// <para>## 注意事项</para>
/// <para>1. 批量查询发薪明细接口提供的请求参数中，用户必须填写「__发薪日起止时间__（pay_period_start_date，pay_period_end_date）」或「__发薪活动 ID 列表__」，当传入的三个参数均为空时，开放接口将返回 2500006 错误码。</para>
/// <para>2. 每一次调用接口时，系统最多会扫描 __50__ 个发薪活动，当用户传入的查询条件命中的发薪活动个数大于 __50__ 时，开放接口将根据查询参数返回 2500003 或 2500008 错误码，请合理使用查询参数。</para>
/// <para>3. 开放接口中的「员工的飞书人事雇佣 ID 列表（employee_ids）」参数为必填。</para>
/// <para>接口ID：7431973248228638722</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/payment_detail/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fpayment_detail%2fquery</para>
/// </summary>
public record PostPayrollV1PaymentDetailQueryResponseDto
{
    /// <summary>
    /// <para>发薪明细列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("payment_details")]
    public PaymentDetail[]? PaymentDetails { get; set; }

    /// <summary>
    /// <para>发薪明细列表</para>
    /// </summary>
    public record PaymentDetail
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
        /// <para>发薪明细所在的发薪活动 ID，调用[查询发薪活动列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/payroll-v1/payment_activity/list)接口后，可以从返回结果中获取到发薪活动 ID。</para>
        /// <para>必填：否</para>
        /// <para>示例值：7202076988667019308</para>
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string? ActivityId { get; set; }

        /// <summary>
        /// <para>发薪明细详情</para>
        /// <para>必填：否</para>
        /// <para>最大长度：1000000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("payment_accounting_items")]
        public PaymentAccountingItem[]? PaymentAccountingItems { get; set; }

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
