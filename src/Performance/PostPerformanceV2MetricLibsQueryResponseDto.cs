// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-11-29
// ************************************************************************
// <copyright file="PostPerformanceV2MetricLibsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取指标列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取指标列表 响应体
/// <para>获取指标库中的指标信息，如指标名称、指标类型、指标标签和指标字段等信息。可通过指标启用状态、指标类型、指标可用范围等筛选条件获取指定范围的指标信息。</para>
/// <para>接口ID：7380276358332661761</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/metric_template/query-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_lib%2fquery</para>
/// </summary>
public record PostPerformanceV2MetricLibsQueryResponseDto : IPageableResponse<PostPerformanceV2MetricLibsQueryResponseDto.MetricInLibrary>
{
    /// <summary>
    /// <para>指标信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public MetricInLibrary[]? Items { get; set; }

    /// <summary>
    /// <para>指标信息</para>
    /// </summary>
    public record MetricInLibrary
    {
        /// <summary>
        /// <para>指标 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7272581996315099155</para>
        /// </summary>
        [JsonPropertyName("metric_id")]
        public string? MetricId { get; set; }

        /// <summary>
        /// <para>指标名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：销售额</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>指标类型 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7272578300650717203</para>
        /// </summary>
        [JsonPropertyName("type_id")]
        public string? TypeId { get; set; }

        /// <summary>
        /// <para>指标标签信息</para>
        /// <para>必填：否</para>
        /// <para>最大长度：999999</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("tags")]
        public MetricTag[]? Tags { get; set; }

        /// <summary>
        /// <para>指标标签信息</para>
        /// </summary>
        public record MetricTag
        {
            /// <summary>
            /// <para>指标标签 ID，详情可查看：[获取指标标签信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/metric_tag/list)</para>
            /// <para>必填：否</para>
            /// <para>示例值：7302271694582841364</para>
            /// <para>最大长度：999999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("tag_id")]
            public string? TagId { get; set; }

            /// <summary>
            /// <para>标签名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("tag_name")]
            public I18n? TagName { get; set; }

            /// <summary>
            /// <para>标签名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>标签中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：体验</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>标签英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Interactive experience</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }

        /// <summary>
        /// <para>指标字段信息</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("fields")]
        public MetricFieldInLibrary[]? Fields { get; set; }

        /// <summary>
        /// <para>指标字段信息</para>
        /// </summary>
        public record MetricFieldInLibrary
        {
            /// <summary>
            /// <para>指标字段 ID，详情可查看：[获取指标字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/metric_field/query)</para>
            /// <para>必填：否</para>
            /// <para>示例值：7296701873237786643</para>
            /// </summary>
            [JsonPropertyName("field_id")]
            public string? FieldId { get; set; }

            /// <summary>
            /// <para>指标字段填写设置类型</para>
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
            /// <para>指标字段值</para>
            /// <para>必填：否</para>
            /// <para>示例值：90</para>
            /// </summary>
            [JsonPropertyName("field_value")]
            public string? FieldValue { get; set; }

            /// <summary>
            /// <para>字段值，当字段为人员信息时有值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("field_value_person")]
            public User? FieldValuePerson { get; set; }

            /// <summary>
            /// <para>字段值，当字段为人员信息时有值</para>
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
        /// <para>指标评分设置类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：score_by_formula</para>
        /// <para>可选值：<list type="bullet">
        /// <item>score_manually：手动评分</item>
        /// <item>score_by_formula：公式评分</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("scoring_setting_type")]
        public string? ScoringSettingType { get; set; }

        /// <summary>
        /// <para>指标评分公式</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("scoring_formula")]
        public Formula? ScoringFormula { get; set; }

        /// <summary>
        /// <para>指标评分公式</para>
        /// </summary>
        public record Formula
        {
            /// <summary>
            /// <para>公式 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7302271694582841364</para>
            /// <para>最大长度：999999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("formula_id")]
            public string? FormulaId { get; set; }

            /// <summary>
            /// <para>公式名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：示例公式</para>
            /// <para>最大长度：999999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("formula_name")]
            public string? FormulaName { get; set; }

            /// <summary>
            /// <para>公式详情</para>
            /// <para>必填：否</para>
            /// <para>示例值：1 + 1</para>
            /// <para>最大长度：999999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("formula_details")]
            public string? FormulaDetails { get; set; }
        }

        /// <summary>
        /// <para>指标数据源录入人 ID</para>
        /// <para>必填：否</para>
        /// <para>最大长度：50</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("data_source_inputters")]
        public User[]? DataSourceInputters { get; set; }

        /// <summary>
        /// <para>指标数据源录入人 ID</para>
        /// </summary>
        public record User
        {
            /// <summary>
            /// <para>指标数据源录入人的 open_id</para>
            /// <para>必填：否</para>
            /// <para>示例值：od-asd2dasdasd</para>
            /// </summary>
            [JsonPropertyName("open_id")]
            public string? OpenId { get; set; }

            /// <summary>
            /// <para>指标数据源录入人的 user_id，取值与入参 `user_id_type` 类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou-ux987dsf6x</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }
        }

        /// <summary>
        /// <para>指标可用范围</para>
        /// <para>必填：否</para>
        /// <para>示例值：admins_and_reviewees</para>
        /// <para>可选值：<list type="bullet">
        /// <item>admins_and_reviewees：允许管理员下发和被评估人选用</item>
        /// <item>only_admins：仅允许管理员下发</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("range_of_availability")]
        public string? RangeOfAvailability { get; set; }

        /// <summary>
        /// <para>指标状态是否为启用</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }
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
