// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="GetCompensationV1SocialPlansResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>根据生效日期分页查询参保方案 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 根据生效日期分页查询参保方案 响应体
/// <para>通过生效日期effective_date参数过滤并分页返回结果</para>
/// <para>接口ID：7420038908975448066</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/social_plan/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2fsocial_plan%2flist</para>
/// </summary>
public record GetCompensationV1SocialPlansResponseDto : IPageableResponse<GetCompensationV1SocialPlansResponseDto.SocialPlan>
{
    /// <summary>
    /// <para>方案列表</para>
    /// </summary>
    [JsonIgnore]
    public SocialPlan[]? Items => Plans;

    /// <summary>
    /// <para>方案列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("plans")]
    public SocialPlan[]? Plans { get; set; }

    /// <summary>
    /// <para>方案列表</para>
    /// </summary>
    public record SocialPlan
    {
        /// <summary>
        /// <para>参保方案ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7198027289165088300</para>
        /// <para>最大长度：64</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; } = string.Empty;

        /// <summary>
        /// <para>参保方案版本ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7198027289165055532</para>
        /// <para>最大长度：64</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("plan_tid")]
        public string PlanTid { get; set; } = string.Empty;

        /// <summary>
        /// <para>参保方案名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n Name { get; set; } = new();

        /// <summary>
        /// <para>参保方案名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：2024年度社保方案</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：2024 Social Insurance Plan</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>生效时间，yyyy-MM-dd</para>
        /// <para>必填：是</para>
        /// <para>示例值：2024-01-01</para>
        /// <para>最大长度：11</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("effective_date")]
        public string EffectiveDate { get; set; } = string.Empty;

        /// <summary>
        /// <para>是否启用</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// <para>险种类型. social_insurance: 社保; provident_fund: 公积金</para>
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
        /// <para>参保方案适用范围</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("scope")]
        public SocialPlanScope? Scope { get; set; }

        /// <summary>
        /// <para>参保方案适用范围</para>
        /// </summary>
        public record SocialPlanScope
        {
            /// <summary>
            /// <para>是否适用于全部</para>
            /// <para>必填：是</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_all")]
            public bool IsAll { get; set; }

            /// <summary>
            /// <para>rules：配置的条件规则。返回两层结构：[条件组[条件]]。多个 [条件组] 之间是 或 的关系，一个条件组内的多个 [条件] 是 且 的关系。</para>
            /// <para>比如：rules: [[1,2],[3,4]]，业务含义为：(1 and 2) or (3 and 4)</para>
            /// <para>rules [][]social_plan_condition 适用范围</para>
            /// <para>- left_type int 可选值有：</para>
            /// <para>``1``：参保城市</para>
            /// <para>``2``：缴纳主体</para>
            /// <para>- operator int 可选值有：</para>
            /// <para>``1``：包含</para>
            /// <para>- right_values []string</para>
            /// <para>- 当left_type=1时，是参保城市ID</para>
            /// <para>- 当left_type=2时，是缴纳主体ID</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("rules")]
            public SocialPlanCondition[][]? Rules { get; set; }

            /// <summary>
            /// <para>rules：配置的条件规则。返回两层结构：[条件组[条件]]。多个 [条件组] 之间是 或 的关系，一个条件组内的多个 [条件] 是 且 的关系。</para>
            /// <para>比如：rules: [[1,2],[3,4]]，业务含义为：(1 and 2) or (3 and 4)</para>
            /// <para>rules [][]social_plan_condition 适用范围</para>
            /// <para>- left_type int 可选值有：</para>
            /// <para>``1``：参保城市</para>
            /// <para>``2``：缴纳主体</para>
            /// <para>- operator int 可选值有：</para>
            /// <para>``1``：包含</para>
            /// <para>- right_values []string</para>
            /// <para>- 当left_type=1时，是参保城市ID</para>
            /// <para>- 当left_type=2时，是缴纳主体ID</para>
            /// </summary>
            public record SocialPlanCondition
            {
                /// <summary>
                /// <para>适用范围左值</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>最大值：2</para>
                /// <para>最小值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：参保城市</item>
                /// <item>2：缴纳主体</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("left_type")]
                public int? LeftType { get; set; }

                /// <summary>
                /// <para>适用范围操作</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>最大值：2</para>
                /// <para>最小值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：包含</item>
                /// <item>2：不包含</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("operator")]
                public int? Operator { get; set; }

                /// <summary>
                /// <para>适用范围右值</para>
                /// <para>必填：否</para>
                /// <para>最大长度：5000</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("right_values")]
                public string[]? RightValues { get; set; }
            }
        }

        /// <summary>
        /// <para>参保信息</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("item_detail")]
        public SocialPlanItemDetail[] ItemDetails { get; set; } = [];

        /// <summary>
        /// <para>参保信息</para>
        /// </summary>
        public record SocialPlanItemDetail
        {
            /// <summary>
            /// <para>险种ID，可通过[获取险种配置列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/social_insurance/list)接口查询</para>
            /// <para>必填：是</para>
            /// <para>示例值：7200725830765987372</para>
            /// <para>最大长度：64</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("item_id")]
            public string ItemId { get; set; } = string.Empty;

            /// <summary>
            /// <para>险种名</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("item_name")]
            public I18n ItemName { get; set; } = new();

            /// <summary>
            /// <para>险种名</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：医疗保险</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：medical insurance</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>个人缴纳配置</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("item_setting_of_person")]
            public SocialPlanItemSetting ItemSettingOfPerson { get; set; } = new();

            /// <summary>
            /// <para>个人缴纳配置</para>
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
                /// <para>示例值：9.0</para>
                /// <para>最大长度：5</para>
                /// <para>最小长度：1</para>
                /// </summary>
                [JsonPropertyName("payment_ratio")]
                public string PaymentRatio { get; set; } = string.Empty;

                /// <summary>
                /// <para>缴纳金舍入规则。rounding: 四舍五入; round_up: 向上舍入; round_down: 向下舍入</para>
                /// <para>必填：是</para>
                /// <para>示例值：rounding</para>
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
            /// <para>企业缴纳配置</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("item_setting_of_company")]
            public SocialPlanItemSetting ItemSettingOfCompany { get; set; } = new();

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
            public int[] PaymentMonths { get; set; } = [];
        }

        /// <summary>
        /// <para>备注</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("remark")]
        public I18n Remark { get; set; } = new();
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
