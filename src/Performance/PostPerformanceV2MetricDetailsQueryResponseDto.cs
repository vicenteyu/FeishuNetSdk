// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-11-29
// ************************************************************************
// <copyright file="PostPerformanceV2MetricDetailsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取被评估人关键指标结果 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取被评估人关键指标结果 响应体
/// <para>批量获取指定周期中被评估人的关键指标结果。</para>
/// <para>接口ID：7380276358332743681</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/metric_detail/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_detail%2fquery</para>
/// </summary>
public record PostPerformanceV2MetricDetailsQueryResponseDto
{
    /// <summary>
    /// <para>周期 ID，详情可查看：[获取周期](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/semester/list)</para>
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
            /// <para>用户的 user_id，与入参 `user_id_type` 类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou-ux987dsf6x</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }
        }

        /// <summary>
        /// <para>指标模板 ID，详情可查看：[获取指标模板列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/metric_template/query)</para>
        /// <para>必填：否</para>
        /// <para>示例值：7294570803306168339</para>
        /// </summary>
        [JsonPropertyName("metric_template_id")]
        public string? MetricTemplateId { get; set; }

        /// <summary>
        /// <para>指标详情</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("metric_details")]
        public MetricDetail? MetricDetails { get; set; }

        /// <summary>
        /// <para>指标详情</para>
        /// </summary>
        public record MetricDetail
        {
            /// <summary>
            /// <para>指标 ID，详情可查看：[获取指标列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/metric_lib/query)</para>
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
                /// <para>指标字段 ID，详情可查看：[获取指标字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/metric_field/query)</para>
                /// <para>必填：否</para>
                /// <para>示例值：7296082067266207764</para>
                /// </summary>
                [JsonPropertyName("field_id")]
                public string? FieldId { get; set; }

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
            /// <para>指标维度 ID</para>
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
                /// <para>指标维度中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：维度一</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>指标维度英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Dimension 1</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>指标维度权重，如果没有设置则返回为空</para>
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
