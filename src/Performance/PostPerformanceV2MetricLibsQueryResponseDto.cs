// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-07-02
// ************************************************************************
// <copyright file="PostPerformanceV2MetricLibsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取指标库信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取指标库信息 响应体
/// <para>获取指标库的信息</para>
/// <para>接口ID：7380276358332661761</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/metric_lib/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_lib%2fquery</para>
/// </summary>
public record PostPerformanceV2MetricLibsQueryResponseDto
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
            /// <para>指标字段 ID。 系统预置的指标字段 ID 分别为：指标 1；权重 2；指标单位 3；目标值 4；完成值 5；完成说明 7。更多指标字段详情可通过【[获取指标字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/metric_field/query)】接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：7296701873237786643</para>
            /// </summary>
            [JsonPropertyName("field_id")]
            public string? FieldId { get; set; }

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
            /// <para>示例值：90</para>
            /// </summary>
            [JsonPropertyName("field_value")]
            public string? FieldValue { get; set; }
        }

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
        /// <para>数据源录入人 ID</para>
        /// <para>必填：否</para>
        /// <para>最大长度：50</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("data_source_inputters")]
        public User[]? DataSourceInputters { get; set; }

        /// <summary>
        /// <para>数据源录入人 ID</para>
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

        /// <summary>
        /// <para>可用范围</para>
        /// <para>必填：否</para>
        /// <para>示例值：admins_and_reviewees</para>
        /// <para>可选值：<list type="bullet">
        /// <item>admins_and_reviewees：admins_and_reviewees</item>
        /// <item>only_admins：仅允许管理员下发</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("range_of_availability")]
        public string? RangeOfAvailability { get; set; }

        /// <summary>
        /// <para>状态是否为启用</para>
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
