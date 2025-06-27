// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-15
//
// Last Modified By : yxr
// Last Modified On : 2025-03-08
// ************************************************************************
// <copyright file="GetPayrollV1CostAllocationReportsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询成本分摊报表汇总数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Payroll;
/// <summary>
/// 查询成本分摊报表汇总数据 响应体
/// <para>根据算薪期间和成本分摊方案id获取成本分摊汇总数据。调用接口前，需在payroll 系统中打开「财务过账」开关，并且完成发布成本分摊报表。</para>
/// <para>接口ID：7319164056023253020</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/cost_allocation_report/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fcost_allocation_report%2flist</para>
/// </summary>
public record GetPayrollV1CostAllocationReportsResponseDto
{
    /// <summary>
    /// <para>期间，成本分摊报表对应的年月</para>
    /// <para>必填：否</para>
    /// <para>示例值：2023-11</para>
    /// </summary>
    [JsonPropertyName("pay_period")]
    public string? PayPeriod { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：6823630319749580302</para>
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
    /// <para>报表名称</para>
    /// <para>必填：否</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("cost_allocation_report_names")]
    public I18nContent[]? CostAllocationReportNames { get; set; }

    /// <summary>
    /// <para>报表名称</para>
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
    /// <para>汇总数据</para>
    /// <para>必填：否</para>
    /// <para>最大长度：2000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("cost_allocation_report_datas")]
    public CostAllocationReportData[]? CostAllocationReportDatas { get; set; }

    /// <summary>
    /// <para>汇总数据</para>
    /// </summary>
    public record CostAllocationReportData
    {
        /// <summary>
        /// <para>数据维度汇总</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("data_summary_dimensions")]
        public DataSummaryDimension[]? DataSummaryDimensions { get; set; }

        /// <summary>
        /// <para>数据维度汇总</para>
        /// </summary>
        public record DataSummaryDimension
        {
            /// <summary>
            /// <para>层级</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>最大值：1000</para>
            /// <para>最小值：1</para>
            /// </summary>
            [JsonPropertyName("dimension_level")]
            public int? DimensionLevel { get; set; }

            /// <summary>
            /// <para>类型：</para>
            /// <para>公司主体 - 1</para>
            /// <para>成本中心 - 2</para>
            /// <para>部门 - 3</para>
            /// <para>薪资组 - 4</para>
            /// <para>人员类型 - 5</para>
            /// <para>雇佣状态 - 6</para>
            /// <para>转正状态 - 7</para>
            /// <para>职务 - 8</para>
            /// <para>序列 - 9</para>
            /// <para>职级 - 10</para>
            /// <para>工时制度 - 11</para>
            /// <para>合同类型 - 12</para>
            /// <para>算薪项 - 13</para>
            /// <para>自定义维度 - 100</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>最大值：1000</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("dimension_type")]
            public int? DimensionType { get; set; }

            /// <summary>
            /// <para>维度ID，需要根据dimension_type再次转换，如：当dimension_type为1时，该值表示公司主体的ID。</para>
            /// <para>对应的接口映射如下：</para>
            /// <para>dimension_type = 1 [公司主体](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/company/batch_get)</para>
            /// <para>dimension_type = 2 [成本中心](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)</para>
            /// <para>dimension_type = 3 [部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/get)</para>
            /// <para>dimension_type = 4 [薪资组](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/payroll-v1/paygroup/list)</para>
            /// <para>dimension_type = 5 [人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/get)</para>
            /// <para>dimension_type = 8 [职务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/get)</para>
            /// <para>dimension_type = 9 [序列](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_family/batch_get)</para>
            /// <para>dimension_type = 10 [职级](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_level/batch_get)</para>
            /// <para>dimension_type = 11 [工时制度](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/get)</para>
            /// <para>必填：否</para>
            /// <para>示例值：6823630319749580306</para>
            /// </summary>
            [JsonPropertyName("dimension_value_id")]
            public string? DimensionValueId { get; set; }

            /// <summary>
            /// <para>算薪项汇总维度时，当算薪项是特定枚举值，会使用该字段返回枚举值ID以及枚举值Key，业务需要获取枚举对象的详情信息，可根据ID去对应的对象中查找，其中枚举对象的映射如下：</para>
            /// <para>workCalendar [工作日历](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/leave/work_calendar)</para>
            /// <para>location [地点](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/location/batch_get)</para>
            /// <para>company [公司主体](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/company/batch_get)</para>
            /// <para>costCenter [成本中心](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)</para>
            /// <para>department [部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/get)</para>
            /// <para>employeeType [人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/get)</para>
            /// <para>job [职务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/get)</para>
            /// <para>jobFamily [序列](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_family/batch_get)</para>
            /// <para>jobLevel [职级](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_level/batch_get)</para>
            /// <para>workingHoursType [工时制度](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/get)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("enum_dimension")]
            public EnumObject? EnumDimension { get; set; }

            /// <summary>
            /// <para>算薪项汇总维度时，当算薪项是特定枚举值，会使用该字段返回枚举值ID以及枚举值Key，业务需要获取枚举对象的详情信息，可根据ID去对应的对象中查找，其中枚举对象的映射如下：</para>
            /// <para>workCalendar [工作日历](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/leave/work_calendar)</para>
            /// <para>location [地点](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/location/batch_get)</para>
            /// <para>company [公司主体](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/company/batch_get)</para>
            /// <para>costCenter [成本中心](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)</para>
            /// <para>department [部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/get)</para>
            /// <para>employeeType [人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/get)</para>
            /// <para>job [职务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/get)</para>
            /// <para>jobFamily [序列](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_family/batch_get)</para>
            /// <para>jobLevel [职级](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_level/batch_get)</para>
            /// <para>workingHoursType [工时制度](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/get)</para>
            /// </summary>
            public record EnumObject
            {
                /// <summary>
                /// <para>枚举对象ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：7188920315914207276</para>
                /// <para>最大长度：25</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("enum_value_id")]
                public string? EnumValueId { get; set; }

                /// <summary>
                /// <para>枚举对象</para>
                /// <para>必填：否</para>
                /// <para>示例值：company</para>
                /// <para>最大长度：100</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("enum_key")]
                public string? EnumKey { get; set; }
            }

            /// <summary>
            /// <para>维度引用对象的基础信息，当维度为引用类型字段才会有值，目前支持的引用对象类型见type</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("dimension_value_lookup_info")]
            public DataSummaryDimensionDimensionValueLookupInfo? DimensionValueLookupInfo { get; set; }

            /// <summary>
            /// <para>维度引用对象的基础信息，当维度为引用类型字段才会有值，目前支持的引用对象类型见type</para>
            /// </summary>
            public record DataSummaryDimensionDimensionValueLookupInfo
            {
                /// <summary>
                /// <para>引用对象类型，类型对应的对象映射包括不仅限：</para>
                /// <para>type = company [公司主体](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/company/batch_get)</para>
                /// <para>type = cost_center [成本中心](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)</para>
                /// <para>type = department [部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/get)</para>
                /// <para>type = pay_group [薪资组](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/payroll-v1/paygroup/list)</para>
                /// <para>type = employee_type [人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/get)</para>
                /// <para>type = job [职务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/get)</para>
                /// <para>type = job_family [序列](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_family/batch_get)</para>
                /// <para>type = job_level [职级](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_level/batch_get)</para>
                /// <para>type = working_hours_type [工时制度](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/get)</para>
                /// <para>必填：否</para>
                /// <para>示例值：work_calendar</para>
                /// </summary>
                [JsonPropertyName("type")]
                public string? Type { get; set; }

                /// <summary>
                /// <para>引用对象的id，可根据相关API查询到对象的完整信息</para>
                /// <para>必填：否</para>
                /// <para>示例值：6961286846093788621</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>引用对象的code，目前下面的对象会有code：</para>
                /// <para>type = company [公司主体](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/company/batch_get)</para>
                /// <para>type = cost_center [成本中心](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)</para>
                /// <para>type = department [部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/get)</para>
                /// <para>type = job [职务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/get)</para>
                /// <para>type = job_family [序列](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_family/batch_get)</para>
                /// <para>type = job_level [职级](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_level/batch_get)</para>
                /// <para>type = location [地点](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/location/batch_get)</para>
                /// <para>必填：否</para>
                /// <para>示例值：D1230011115</para>
                /// </summary>
                [JsonPropertyName("code")]
                public string? Code { get; set; }
            }

            /// <summary>
            /// <para>维度名称，算薪项、自定义维度使用</para>
            /// <para>必填：否</para>
            /// <para>最大长度：200</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("dimension_names")]
            public I18nContent[]? DimensionNames { get; set; }

            /// <summary>
            /// <para>维度名称，算薪项、自定义维度使用</para>
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

                /// <summary>
                /// <para>名称对应的实体id</para>
                /// <para>需要根据dimension_type再次转换，如：当dimension_type为13时，该值表示算薪项的ID。</para>
                /// <para>必填：否</para>
                /// <para>示例值：名称</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }
            }

            /// <summary>
            /// <para>数据维度表头，算薪项、自定义维度使用</para>
            /// <para>必填：否</para>
            /// <para>最大长度：200</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("dimension_titles")]
            public I18nContent[]? DimensionTitles { get; set; }
        }

        /// <summary>
        /// <para>成本项数据</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("compensation_cost_item")]
        public CostAllocationReportDataCompensationCostItem? CompensationCostItem { get; set; }

        /// <summary>
        /// <para>成本项数据</para>
        /// </summary>
        public record CostAllocationReportDataCompensationCostItem
        {
            /// <summary>
            /// <para>发薪人数</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// <para>最大值：1000000</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("number_of_individuals_for_payment")]
            public int? NumberOfIndividualsForPayment { get; set; }

            /// <summary>
            /// <para>成本项数据</para>
            /// <para>必填：否</para>
            /// <para>最大长度：10000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("compensation_costs")]
            public CompensationCost[]? CompensationCosts { get; set; }

            /// <summary>
            /// <para>成本项数据</para>
            /// </summary>
            public record CompensationCost
            {
                /// <summary>
                /// <para>成本项值</para>
                /// <para>必填：否</para>
                /// <para>示例值：123456.78</para>
                /// <para>最大长度：100</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("compensation_cost_value")]
                public string? CompensationCostValue { get; set; }

                /// <summary>
                /// <para>成本项名称</para>
                /// <para>必填：否</para>
                /// <para>最大长度：200</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("i18n_names")]
                public I18nContent[]? I18nNames { get; set; }

                /// <summary>
                /// <para>成本项名称</para>
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
        }
    }
}
