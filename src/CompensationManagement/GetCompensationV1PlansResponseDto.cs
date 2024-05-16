namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 批量查询薪资方案 响应体
/// <para>批量查询薪资方案</para>
/// <para>接口ID：7314129756769812484</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/plan/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2fplan%2flist</para>
/// </summary>
public record GetCompensationV1PlansResponseDto
{
    /// <summary>
    /// <para>薪资方案信息列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("items")]
    public PlanDetail[] Items { get; set; } = Array.Empty<PlanDetail>();

    /// <summary>
    /// <para>薪资方案信息列表</para>
    /// </summary>
    public record PlanDetail
    {
        /// <summary>
        /// <para>薪资方案ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：2134193289</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>薪资方案版本ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：129738122</para>
        /// </summary>
        [JsonPropertyName("tid")]
        public string Tid { get; set; } = string.Empty;

        /// <summary>
        /// <para>薪资方案名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：基本月薪方案</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>薪资方案描述</para>
        /// <para>必填：是</para>
        /// <para>示例值：基本月薪方案描述</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// <para>薪资方案生效时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：2022-10-20</para>
        /// </summary>
        [JsonPropertyName("effective_date")]
        public string EffectiveDate { get; set; } = string.Empty;

        /// <summary>
        /// <para>薪资方案适用范围</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("plan_scope")]
        public PlanDetailPlanScope? PlanScope { get; set; }

        /// <summary>
        /// <para>薪资方案适用范围</para>
        /// </summary>
        public record PlanDetailPlanScope
        {
            /// <summary>
            /// <para>是否全部范围</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_all")]
            public bool? IsAll { get; set; }

            /// <summary>
            /// <para>方案适用范围条件组</para>
            /// <para>必填：否</para>
            /// <para>最大长度：30</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("plan_conditions")]
            public PlanCondition[]? PlanConditions { get; set; }

            /// <summary>
            /// <para>方案适用范围条件组</para>
            /// </summary>
            public record PlanCondition
            {
                /// <summary>
                /// <para>适用范围左值</para>
                /// <para>必填：否</para>
                /// <para>示例值：7</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：部门</item>
                /// <item>2：部门（包含下级部门）</item>
                /// <item>3：工作地点</item>
                /// <item>4：工作地点（包含下级地点）</item>
                /// <item>5：公司</item>
                /// <item>6：公司（包含下级公司）</item>
                /// <item>7：序列</item>
                /// <item>8：序列（包含子序列）</item>
                /// <item>9：职务</item>
                /// <item>10：职级</item>
                /// <item>11：人员类型</item>
                /// <item>12：招聘类型</item>
                /// <item>13：国家/地区</item>
                /// <item>14：职等</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("left_type")]
                public int? LeftType { get; set; }

                /// <summary>
                /// <para>适用范围操作</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：包含</item>
                /// <item>2：不包含</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("operator")]
                public int? Operator { get; set; }

                /// <summary>
                /// <para>部门ID，详细信息可以通过[批量查询部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get)接口查询获得</para>
                /// <para>工作地点ID，详细信息可以通过[批量查询地点](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)接口查询获得</para>
                /// <para>成本中心ID，详细信息可以通过[搜索成本中心信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口查询获得</para>
                /// <para>职务ID，详细信息可以通过[批量查询职务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/list)接口查询获得</para>
                /// <para>职级ID，详细信息可以通过[通过职级 ID 批量获取职级信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_level/batch_get)接口查询获得</para>
                /// <para>序列ID，详细信息可以通过[通过序列 ID 批量获取序列信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_family/batch_get)接口查询获得</para>
                /// <para>人员类型ID，详细信息可以通过[批量查询人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/list)接口查询获得</para>
                /// <para>必填：否</para>
                /// <para>示例值：21341234</para>
                /// </summary>
                [JsonPropertyName("right_value")]
                public string[]? RightValue { get; set; }
            }
        }

        /// <summary>
        /// <para>币种ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：341324121</para>
        /// </summary>
        [JsonPropertyName("currency_id")]
        public string? CurrencyId { get; set; }

        /// <summary>
        /// <para>开启试用期薪酬状态</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("probation_salary_status")]
        public bool ProbationSalaryStatus { get; set; }

        /// <summary>
        /// <para>方案关联的薪资项</para>
        /// <para>必填：是</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("plan_items")]
        public PlanItem[] PlanItems { get; set; } = Array.Empty<PlanItem>();

        /// <summary>
        /// <para>方案关联的薪资项</para>
        /// </summary>
        public record PlanItem
        {
            /// <summary>
            /// <para>定薪方式</para>
            /// <para>必填：否</para>
            /// <para>示例值：manual</para>
            /// <para>可选值：<list type="bullet">
            /// <item>manual：手动输入</item>
            /// <item>formula：公式计算</item>
            /// <item>fixed：固定值</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("adjustment_type")]
            public string? AdjustmentType { get; set; }

            /// <summary>
            /// <para>薪资项ID，详细信息可以通过[批量查询薪资项](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/item/list)接口查询获得</para>
            /// <para>必填：否</para>
            /// <para>示例值：21341234</para>
            /// </summary>
            [JsonPropertyName("item_id")]
            public string? ItemId { get; set; }

            /// <summary>
            /// <para>方案关联薪资项逻辑配置</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("plan_item_logic")]
            public AdjustmentLogic? PlanItemLogic { get; set; }

            /// <summary>
            /// <para>方案关联薪资项逻辑配置</para>
            /// </summary>
            public record AdjustmentLogic
            {
                /// <summary>
                /// <para>固定值</para>
                /// <para>必填：否</para>
                /// <para>示例值：60</para>
                /// </summary>
                [JsonPropertyName("fixed")]
                public string? Fixed { get; set; }

                /// <summary>
                /// <para>公式配置</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("formula")]
                public AdjustmentLogicFormula? Formula { get; set; }

                /// <summary>
                /// <para>公式配置</para>
                /// </summary>
                public record AdjustmentLogicFormula
                {
                    /// <summary>
                    /// <para>公式表达式</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：${0} +${1}</para>
                    /// </summary>
                    [JsonPropertyName("expr")]
                    public string? Expr { get; set; }

                    /// <summary>
                    /// <para>公式参数列表</para>
                    /// <para>必填：否</para>
                    /// <para>最大长度：20</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("formula_params")]
                    public FormulaParam[]? FormulaParams { get; set; }

                    /// <summary>
                    /// <para>公式参数列表</para>
                    /// </summary>
                    public record FormulaParam
                    {
                        /// <summary>
                        /// <para>引用类型</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：引用薪资项</item>
                        /// <item>2：引用薪资指标</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("ref_type")]
                        public int? RefType { get; set; }

                        /// <summary>
                        /// <para>引用类型ID</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：23143242</para>
                        /// </summary>
                        [JsonPropertyName("id")]
                        public string? Id { get; set; }
                    }
                }
            }

            /// <summary>
            /// <para>试用期薪酬类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：percentum</para>
            /// <para>可选值：<list type="bullet">
            /// <item>percentum：百分比</item>
            /// <item>manual_input：手动输入</item>
            /// <item>none：不区分试用期和转正薪酬</item>
            /// <item>fixed：固定值</item>
            /// <item>formula：公式计算</item>
            /// <item>not_set：未设置试用期</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("probation_discount_type")]
            public string? ProbationDiscountType { get; set; }

            /// <summary>
            /// <para>试用期薪酬百分比</para>
            /// <para>必填：否</para>
            /// <para>示例值：80.00</para>
            /// </summary>
            [JsonPropertyName("probation_discount_percentum")]
            public string? ProbationDiscountPercentum { get; set; }
        }

        /// <summary>
        /// <para>方案关联的薪资统计指标</para>
        /// <para>必填：是</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("plan_indicators")]
        public PlanIndicator[] PlanIndicators { get; set; } = Array.Empty<PlanIndicator>();

        /// <summary>
        /// <para>方案关联的薪资统计指标</para>
        /// </summary>
        public record PlanIndicator
        {
            /// <summary>
            /// <para>薪资统计指标ID，详细信息可以通过[批量查询薪资统计指标](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/indicator/list)接口查询获得</para>
            /// <para>必填：是</para>
            /// <para>示例值：13243432</para>
            /// </summary>
            [JsonPropertyName("indicator_id")]
            public string IndicatorId { get; set; } = string.Empty;

            /// <summary>
            /// <para>方案关联薪资统计指标逻辑配置</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("plan_indicator_logic")]
            public AdjustmentLogic? PlanIndicatorLogic { get; set; }

            /// <summary>
            /// <para>方案关联薪资统计指标逻辑配置</para>
            /// </summary>
            public record AdjustmentLogic
            {
                /// <summary>
                /// <para>固定值</para>
                /// <para>必填：否</para>
                /// <para>示例值：60</para>
                /// </summary>
                [JsonPropertyName("fixed")]
                public string? Fixed { get; set; }

                /// <summary>
                /// <para>公式配置</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("formula")]
                public AdjustmentLogicFormula? Formula { get; set; }

                /// <summary>
                /// <para>公式配置</para>
                /// </summary>
                public record AdjustmentLogicFormula
                {
                    /// <summary>
                    /// <para>公式表达式</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：${0} +${1}</para>
                    /// </summary>
                    [JsonPropertyName("expr")]
                    public string? Expr { get; set; }

                    /// <summary>
                    /// <para>公式参数列表</para>
                    /// <para>必填：否</para>
                    /// <para>最大长度：20</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("formula_params")]
                    public FormulaParam[]? FormulaParams { get; set; }

                    /// <summary>
                    /// <para>公式参数列表</para>
                    /// </summary>
                    public record FormulaParam
                    {
                        /// <summary>
                        /// <para>引用类型</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：引用薪资项</item>
                        /// <item>2：引用薪资指标</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("ref_type")]
                        public int? RefType { get; set; }

                        /// <summary>
                        /// <para>引用类型ID</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：23143242</para>
                        /// </summary>
                        [JsonPropertyName("id")]
                        public string? Id { get; set; }
                    }
                }
            }
        }

        /// <summary>
        /// <para>多语言名称</para>
        /// <para>必填：是</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("i18n_names")]
        public I18nContent[] I18nNames { get; set; } = Array.Empty<I18nContent>();

        /// <summary>
        /// <para>多语言名称</para>
        /// </summary>
        public record I18nContent
        {
            /// <summary>
            /// <para>语言版本，例如：“zh-CN”、“en-US”</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh_cn</para>
            /// </summary>
            [JsonPropertyName("locale")]
            public string? Locale { get; set; }

            /// <summary>
            /// <para>语言名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：中文名称</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }

        /// <summary>
        /// <para>多语言描述</para>
        /// <para>必填：是</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("i18n_descriptions")]
        public I18nContent[] I18nDescriptions { get; set; } = Array.Empty<I18nContent>();
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：123412344</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool HasMore { get; set; }
}
