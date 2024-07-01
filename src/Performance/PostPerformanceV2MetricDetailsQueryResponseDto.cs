// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-07-02
// ************************************************************************
// <copyright file="PostPerformanceV2MetricDetailsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取指定周期被评估人的关键指标详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 批量获取指定周期被评估人的关键指标详情 响应体
/// <para>批量获取指定周期中被评估人的关键指标详情</para>
/// <para>接口ID：7380276358332743681</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/metric_detail/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_detail%2fquery</para>
/// </summary>
public record PostPerformanceV2MetricDetailsQueryResponseDto
{
    /// <summary>
    /// <para>周期ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7291278856547794964</para>
    /// </summary>
    [JsonPropertyName("semester_id")]
    public string? SemesterId { get; set; }

    /// <summary>
    /// <para>指标明细列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("reviewee_metrics")]
    public RevieweeMetric[]? RevieweeMetrics { get; set; }

    /// <summary>
    /// <para>指标明细列表</para>
    /// </summary>
    public record RevieweeMetric
    {
        /// <summary>
        /// <para>被评估人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("reviewee_user_id")]
        public User? RevieweeUserId { get; set; }

        /// <summary>
        /// <para>被评估人</para>
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
        /// <para>被评估人在该周期所属的指标模板 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7294570803306168339</para>
        /// </summary>
        [JsonPropertyName("metric_template_id")]
        public string? MetricTemplateId { get; set; }

        /// <summary>
        /// <para>被评估人在周期下的指标明细数据</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("metric_details")]
        public MetricDetail? MetricDetails { get; set; }

        /// <summary>
        /// <para>被评估人在周期下的指标明细数据</para>
        /// </summary>
        public record MetricDetail
        {
            /// <summary>
            /// <para>指标 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7272581996315099155</para>
            /// </summary>
            [JsonPropertyName("metric_id")]
            public string? MetricId { get; set; }

            /// <summary>
            /// <para>指标名称，指标在该明细数据中的名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：示例指标</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>指标字段信息</para>
            /// <para>必填：否</para>
            /// <para>最大长度：10000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("fields")]
            public MetricFieldInDetails[]? Fields { get; set; }

            /// <summary>
            /// <para>指标字段信息</para>
            /// </summary>
            public record MetricFieldInDetails
            {
                /// <summary>
                /// <para>指标字段 ID。 系统预置的指标字段 ID 分别为：指标 1；权重 2；指标单位 3；目标值 4；完成值 5；完成说明 7。更多指标字段详情可通过【[获取指标字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/metric_field/query)】接口获取</para>
                /// <para>必填：否</para>
                /// <para>示例值：7296082067266207764</para>
                /// </summary>
                [JsonPropertyName("field_id")]
                public string? FieldId { get; set; }

                /// <summary>
                /// <para>字段值</para>
                /// <para>必填：否</para>
                /// <para>示例值：90</para>
                /// </summary>
                [JsonPropertyName("field_value")]
                public string? FieldValue { get; set; }
            }

            /// <summary>
            /// <para>指标所属的指标维度 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7303895818346430484</para>
            /// </summary>
            [JsonPropertyName("dimension_id")]
            public string? DimensionId { get; set; }

            /// <summary>
            /// <para>指标维度名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("dimension_name")]
            public I18n? DimensionName { get; set; }

            /// <summary>
            /// <para>指标维度名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：体验</para>
                /// <para>最大长度：999999999</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：Interactive experience</para>
                /// <para>最大长度：999999999</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>指标维度的维度权重，如果没有设置则返回为空</para>
            /// <para>必填：否</para>
            /// <para>示例值：90%</para>
            /// </summary>
            [JsonPropertyName("dimension_weight")]
            public string? DimensionWeight { get; set; }

            /// <summary>
            /// <para>指标添加来源</para>
            /// <para>必填：否</para>
            /// <para>示例值：admin</para>
            /// <para>可选值：<list type="bullet">
            /// <item>reviewee：被评估人添加</item>
            /// <item>admin：管理员添加</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("add_from")]
            public string? AddFrom { get; set; }

            /// <summary>
            /// <para>指标是否引自指标库</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_from_library")]
            public bool? IsFromLibrary { get; set; }
        }
    }
}
