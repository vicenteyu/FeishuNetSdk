// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-07-02
// ************************************************************************
// <copyright file="PostPerformanceV2MetricTemplatesQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取指标模板信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取指标模板信息 响应体
/// <para>获取指标模板的信息</para>
/// <para>接口ID：7380276358332710913</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/metric_template/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_template%2fquery</para>
/// </summary>
public record PostPerformanceV2MetricTemplatesQueryResponseDto
{
    /// <summary>
    /// <para>指标模板信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public MetricTemplate[]? Items { get; set; }

    /// <summary>
    /// <para>指标模板信息</para>
    /// </summary>
    public record MetricTemplate
    {
        /// <summary>
        /// <para>指标模板ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7296488199415660563</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>模版名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>模版名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：体验</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：Interactive experience</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>模板描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public I18n? Description { get; set; }

        /// <summary>
        /// <para>状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：to_be_configured</para>
        /// <para>可选值：<list type="bullet">
        /// <item>to_be_configured：待完成配置</item>
        /// <item>to_be_activated：待启用</item>
        /// <item>enabled：已启用</item>
        /// <item>disabled：已停用</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// <para>是否分人群设置指标</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_set_by_group")]
        public bool? IsSetByGroup { get; set; }

        /// <summary>
        /// <para>指标总分计算方式</para>
        /// <para>必填：否</para>
        /// <para>示例值：weight</para>
        /// <para>可选值：<list type="bullet">
        /// <item>review_manually：手动评估</item>
        /// <item>sum：加和计算</item>
        /// <item>weight：加权计算</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("total_metric_score_method")]
        public string? TotalMetricScoreMethod { get; set; }

        /// <summary>
        /// <para>指标权重计算方式</para>
        /// <para>必填：否</para>
        /// <para>示例值：sum_of_metric_weights_for_each_dimension_equals_100</para>
        /// <para>可选值：<list type="bullet">
        /// <item>sum_of_metric_weights_for_each_dimension_equals_1：每个维度内的指标权重之和等于 100%</item>
        /// <item>total_sum_of_all_metric_weight_equals_1：全部指标权重之和等于 100%</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("metric_weight_method")]
        public string? MetricWeightMethod { get; set; }

        /// <summary>
        /// <para>指标维度列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：999999999</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("metric_dimensions")]
        public MetricDimension[]? MetricDimensions { get; set; }

        /// <summary>
        /// <para>指标维度列表</para>
        /// </summary>
        public record MetricDimension
        {
            /// <summary>
            /// <para>所属人群分组 ID，模板分人群设置指标时，指标维度按照人群分组；未分人群设置时该值为空</para>
            /// <para>必填：否</para>
            /// <para>示例值：7296753366268215316</para>
            /// </summary>
            [JsonPropertyName("group_id")]
            public string? GroupId { get; set; }

            /// <summary>
            /// <para>指标维度 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7296753366268215316</para>
            /// </summary>
            [JsonPropertyName("metric_dimension_id")]
            public string? MetricDimensionId { get; set; }

            /// <summary>
            /// <para>指标维度名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>指标维度名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：体验</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：Interactive experience</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>每条指标的评估规则 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7296701873237786643</para>
            /// </summary>
            [JsonPropertyName("evaluation_rule_id_for_each_metric")]
            public string? EvaluationRuleIdForEachMetric { get; set; }

            /// <summary>
            /// <para>维度权重，如果没有设置则返回为空（备注：和 0 区分）</para>
            /// <para>必填：否</para>
            /// <para>示例值：90</para>
            /// </summary>
            [JsonPropertyName("dimension_weight")]
            public string? DimensionWeight { get; set; }
        }

        /// <summary>
        /// <para>指标列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：999999999</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("metrics")]
        public MetricInTemplate[]? Metrics { get; set; }

        /// <summary>
        /// <para>指标列表</para>
        /// </summary>
        public record MetricInTemplate
        {
            /// <summary>
            /// <para>所属人群分组 ID，模板分人群设置指标时，指标维度按照人群分组；未分人群设置时该值为空</para>
            /// <para>必填：否</para>
            /// <para>示例值：7272581996315099155</para>
            /// </summary>
            [JsonPropertyName("group_id")]
            public string? GroupId { get; set; }

            /// <summary>
            /// <para>指标 ID（备注：指标的统一标识 ID。如果模板存在分组，需要+分组 ID 才能标识到指标模板唯一的指标）</para>
            /// <para>必填：否</para>
            /// <para>示例值：7272581996315099155</para>
            /// </summary>
            [JsonPropertyName("metric_id")]
            public string? MetricId { get; set; }

            /// <summary>
            /// <para>指标名称，指标在该模板中的名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：销售额</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>指标类型 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7272581996315099155</para>
            /// </summary>
            [JsonPropertyName("type_id")]
            public string? TypeId { get; set; }

            /// <summary>
            /// <para>指标字段信息</para>
            /// <para>必填：否</para>
            /// <para>最大长度：999999999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("fields")]
            public MetricFieldInTemplate[]? Fields { get; set; }

            /// <summary>
            /// <para>指标字段信息</para>
            /// </summary>
            public record MetricFieldInTemplate
            {
                /// <summary>
                /// <para>指标字段 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：7272581996315099155</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>字段填写方式设置</para>
                /// <para>必填：否</para>
                /// <para>示例值：admin</para>
                /// <para>可选值：<list type="bullet">
                /// <item>admin：管理员统一配置</item>
                /// <item>data_source_inputter：数据源录入人填写</item>
                /// <item>reviewee：被评估人填写</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("input_setting")]
                public string? InputSetting { get; set; }

                /// <summary>
                /// <para>字段值</para>
                /// <para>必填：否</para>
                /// <para>示例值：100</para>
                /// </summary>
                [JsonPropertyName("filed_value")]
                public string? FiledValue { get; set; }
            }

            /// <summary>
            /// <para>指标是否引自指标库</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_from_library")]
            public bool? IsFromLibrary { get; set; }

            /// <summary>
            /// <para>评分设置类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：score_by_formula</para>
            /// <para>可选值：<list type="bullet">
            /// <item>socre_manually：手动评分</item>
            /// <item>score_by_formula：公式评分</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("scoring_setting_type")]
            public string? ScoringSettingType { get; set; }

            /// <summary>
            /// <para>数据源录入人</para>
            /// <para>必填：否</para>
            /// <para>最大长度：999999999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("data_source_inputters")]
            public User[]? DataSourceInputters { get; set; }

            /// <summary>
            /// <para>数据源录入人</para>
            /// </summary>
            public record User
            {
                /// <summary>
                /// <para>用户的 open_id</para>
                /// <para>必填：否</para>
                /// <para>示例值：od-asd2dasdasd</para>
                /// </summary>
                [JsonPropertyName("open_id")]
                public string? OpenId { get; set; }

                /// <summary>
                /// <para>用户的 user_id，取值与user_id_type一致</para>
                /// <para>必填：否</para>
                /// <para>示例值：ou-ux987dsf6x</para>
                /// </summary>
                [JsonPropertyName("user_id")]
                public string? UserId { get; set; }
            }
        }

        /// <summary>
        /// <para>人群分组</para>
        /// <para>必填：否</para>
        /// <para>最大长度：999999999</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("groups")]
        public MetricGroup[]? Groups { get; set; }

        /// <summary>
        /// <para>人群分组</para>
        /// </summary>
        public record MetricGroup
        {
            /// <summary>
            /// <para>人群分组ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7296466589195436051</para>
            /// </summary>
            [JsonPropertyName("group_id")]
            public string? GroupId { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：分组1</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }
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
