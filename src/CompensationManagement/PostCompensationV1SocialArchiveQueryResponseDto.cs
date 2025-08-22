// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="PostCompensationV1SocialArchiveQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取员工参保档案 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 批量获取员工参保档案 响应体
/// <para>通过用户ID列表和生效日期查询</para>
/// <para>接口ID：7420038908975398914</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/social_archive/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2fsocial_archive%2fquery</para>
/// </summary>
public record PostCompensationV1SocialArchiveQueryResponseDto
{
    /// <summary>
    /// <para>参保档案列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("archives")]
    public SocialArchive[] Archives { get; set; } = Array.Empty<SocialArchive>();

    /// <summary>
    /// <para>参保档案列表</para>
    /// </summary>
    public record SocialArchive
    {
        /// <summary>
        /// <para>员工ID，与入参 user_id_type 类型一致</para>
        /// <para>必填：是</para>
        /// <para>示例值：9960875</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>员工参保档案，包含社保、公积金档案</para>
        /// <para>必填：是</para>
        /// <para>最大长度：8</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("details")]
        public SocialArchiveDetail[] Details { get; set; } = Array.Empty<SocialArchiveDetail>();

        /// <summary>
        /// <para>员工参保档案，包含社保、公积金档案</para>
        /// </summary>
        public record SocialArchiveDetail
        {
            /// <summary>
            /// <para>调整说明</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("description")]
            public I18n Description { get; set; } = new();

            /// <summary>
            /// <para>调整说明</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>2024年社保基数调整</para>
                /// <para>必填：否</para>
                /// <para>示例值：中文名称</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Social Insurance Contribution Record</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>类型。social_insurance: 社保; provident_fund: 公积金</para>
            /// <para>必填：是</para>
            /// <para>示例值：social_insurance</para>
            /// <para>可选值：<list type="bullet">
            /// <item>social_insurance：社保</item>
            /// <item>provident_fund：公积金</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("insurance_type")]
            public string InsuranceType { get; set; } = string.Empty;

            /// <summary>
            /// <para>参保状态，非「参保」状态下，基数、险种数据等为空</para>
            /// <para>必填：是</para>
            /// <para>示例值：contribution</para>
            /// <para>最大长度：32</para>
            /// <para>最小长度：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>contribution：参保</item>
            /// <item>not_contribution：不参保</item>
            /// <item>stopped_contribution：停保</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("insurance_status")]
            public string InsuranceStatus { get; set; } = string.Empty;

            /// <summary>
            /// <para>员工参保档案ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7202347584043501100</para>
            /// <para>最大长度：64</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>员工参保档案调整记录ID（根据档案生效时间查询对应年月的调整记录）</para>
            /// <para>必填：否</para>
            /// <para>示例值：7202347584043566636</para>
            /// <para>最大长度：64</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("tid")]
            public string? Tid { get; set; }

            /// <summary>
            /// <para>参保方案ID，详细信息可通过[查询参保方案](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/social_plan/query)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：7200668421690885676</para>
            /// <para>最大长度：32</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("plan_id")]
            public string? PlanId { get; set; }

            /// <summary>
            /// <para>参保方案版本ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7200668421690852908</para>
            /// <para>最大长度：32</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("plan_tid")]
            public string? PlanTid { get; set; }

            /// <summary>
            /// <para>参保城市ID，可通过[获取地点信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)接口查询详细信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：7152398273176192556</para>
            /// <para>最大长度：64</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("location_id")]
            public string? LocationId { get; set; }

            /// <summary>
            /// <para>社保缴纳主体ID，可通过[获取公司主体](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/company/batch_get)接口查询详细信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：7096372135576618540</para>
            /// <para>最大长度：64</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("company_id")]
            public string? CompanyId { get; set; }

            /// <summary>
            /// <para>社保账户类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：associated_company</para>
            /// <para>最大长度：64</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("account_type")]
            public string? AccountType { get; set; }

            /// <summary>
            /// <para>社保账号</para>
            /// <para>必填：否</para>
            /// <para>示例值：ac123456</para>
            /// <para>最大长度：64</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("insurance_account")]
            public string? InsuranceAccount { get; set; }

            /// <summary>
            /// <para>申报缴纳基数，单位：元</para>
            /// <para>必填：否</para>
            /// <para>示例值：1000.10</para>
            /// <para>最大长度：16</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("base_salary")]
            public string? BaseSalary { get; set; }

            /// <summary>
            /// <para>险种数据详情</para>
            /// <para>必填：否</para>
            /// <para>最大长度：32</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("insurance_details")]
            public SocialArchiveItem[]? InsuranceDetails { get; set; }

            /// <summary>
            /// <para>险种数据详情</para>
            /// </summary>
            public record SocialArchiveItem
            {
                /// <summary>
                /// <para>险种ID，可通过[获取险种配置列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/social_insurance/list)接口查询</para>
                /// <para>必填：是</para>
                /// <para>示例值：111223</para>
                /// <para>最大长度：20</para>
                /// <para>最小长度：1</para>
                /// </summary>
                [JsonPropertyName("insurance_id")]
                public string InsuranceId { get; set; } = string.Empty;

                /// <summary>
                /// <para>企业缴纳金额，单位：元</para>
                /// <para>必填：是</para>
                /// <para>示例值：2000.20</para>
                /// <para>最大长度：32</para>
                /// <para>最小长度：1</para>
                /// </summary>
                [JsonPropertyName("company_deduction")]
                public string CompanyDeduction { get; set; } = string.Empty;

                /// <summary>
                /// <para>企业缴纳配置</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("company_setting")]
                public SocialPlanItemSetting CompanySetting { get; set; } = new();

                /// <summary>
                /// <para>企业缴纳配置</para>
                /// </summary>
                public record SocialPlanItemSetting
                {
                    /// <summary>
                    /// <para>基数下限，浮点数，保留二位小数，单位：元</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1000.00</para>
                    /// <para>最大长度：20</para>
                    /// <para>最小长度：1</para>
                    /// </summary>
                    [JsonPropertyName("lower_limit")]
                    public string LowerLimit { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>基数上限，浮点数，保留二位小数，单位：元</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：2000.00</para>
                    /// <para>最大长度：20</para>
                    /// <para>最小长度：1</para>
                    /// </summary>
                    [JsonPropertyName("upper_limit")]
                    public string UpperLimit { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>缴纳比例，浮点数，默认填充到二位小数，支持输入到四位，单位为 %</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：8.00</para>
                    /// <para>最大长度：5</para>
                    /// <para>最小长度：1</para>
                    /// </summary>
                    [JsonPropertyName("payment_ratio")]
                    public string PaymentRatio { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>缴纳金舍入规则。rounding: 四舍五入; round_up: 向上舍入; round_down: 向下舍入</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：round_down</para>
                    /// <para>最大长度：64</para>
                    /// <para>最小长度：4</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>rounding：四舍五入</item>
                    /// <item>round_up：向上舍入</item>
                    /// <item>round_down：向下舍入</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("payment_rounding_rule")]
                    public string PaymentRoundingRule { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>缴纳金小数位数，0位小数-6位小数之间选择</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：2</para>
                    /// <para>最大值：6</para>
                    /// <para>最小值：0</para>
                    /// </summary>
                    [JsonPropertyName("payment_decimals")]
                    public int PaymentDecimals { get; set; }

                    /// <summary>
                    /// <para>附加固定金额，浮点数，保留二位小数，单位：元</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：200.00</para>
                    /// <para>最大长度：20</para>
                    /// <para>最小长度：1</para>
                    /// </summary>
                    [JsonPropertyName("fixed_payment")]
                    public string FixedPayment { get; set; } = string.Empty;
                }

                /// <summary>
                /// <para>个人缴纳金额，单位：元</para>
                /// <para>必填：是</para>
                /// <para>示例值：1000.20</para>
                /// <para>最大长度：32</para>
                /// <para>最小长度：1</para>
                /// </summary>
                [JsonPropertyName("personal_deduction")]
                public string PersonalDeduction { get; set; } = string.Empty;

                /// <summary>
                /// <para>个人缴纳配置</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("personal_setting")]
                public SocialPlanItemSetting PersonalSetting { get; set; } = new();

                /// <summary>
                /// <para>缴纳频率</para>
                /// <para>必填：是</para>
                /// <para>示例值：monthly</para>
                /// <para>最大长度：64</para>
                /// <para>最小长度：4</para>
                /// <para>可选值：<list type="bullet">
                /// <item>annually：每年</item>
                /// <item>monthly：每月</item>
                /// <item>quarterly：每季度</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("payment_frequency")]
                public string PaymentFrequency { get; set; } = string.Empty;

                /// <summary>
                /// <para>缴纳月份，1月～12月</para>
                /// <para>必填：是</para>
                /// <para>最大长度：12</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("payment_months")]
                public int[] PaymentMonths { get; set; } = Array.Empty<int>();
            }

            /// <summary>
            /// <para>档案生效时间，yyyy-MM-dd</para>
            /// <para>必填：否</para>
            /// <para>示例值：2024-01-01</para>
            /// <para>最大长度：11</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("effective_date")]
            public string? EffectiveDate { get; set; }
        }
    }
}
