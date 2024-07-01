// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-07-02
// ************************************************************************
// <copyright file="PostPerformanceV2MetricDetailsImportBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量录入指定周期被评估人的关键指标详情 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 批量录入指定周期被评估人的关键指标详情 请求体
/// <para>批量录入指定周期中被评估人的关键指标详情</para>
/// <para>接口ID：7380276358332694529</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/metric_detail/import</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_detail%2fimport</para>
/// </summary>
public record PostPerformanceV2MetricDetailsImportBodyDto
{
    /// <summary>
    /// <para>周期 ID，semester_id 可通过【[获取周期](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/semester/list)】接口获得</para>
    /// <para>必填：是</para>
    /// <para>示例值：7293040702907514899</para>
    /// </summary>
    [JsonPropertyName("semester_id")]
    public string SemesterId { get; set; } = string.Empty;

    /// <summary>
    /// <para>录入记录名称，数据源录入人在录入记录页面可以查看该记录名称。如果不传则默认为「API 录入」</para>
    /// <para>必填：否</para>
    /// <para>示例值：API录入</para>
    /// <para>默认值：API录入</para>
    /// </summary>
    [JsonPropertyName("import_record_name")]
    public string? ImportRecordName { get; set; }

    /// <summary>
    /// <para>指标明细列表，一次最多50个</para>
    /// <para>必填：是</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("imported_metrics")]
    public ImportedMetric[] ImportedMetrics { get; set; } = Array.Empty<ImportedMetric>();

    /// <summary>
    /// <para>指标明细列表，一次最多50个</para>
    /// </summary>
    public record ImportedMetric
    {
        /// <summary>
        /// <para>被评估人 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_3245842393d09e9428ad4655da6e30b3</para>
        /// </summary>
        [JsonPropertyName("reviewee_user_id")]
        public string RevieweeUserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>指标 ID，指标的统一标识</para>
        /// <para>必填：是</para>
        /// <para>示例值：7272580325522276372</para>
        /// </summary>
        [JsonPropertyName("metric_id")]
        public string MetricId { get; set; } = string.Empty;

        /// <summary>
        /// <para>指标字段信息</para>
        /// <para>必填：是</para>
        /// <para>最大长度：99</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("fields")]
        public ImportedMetricField[] Fields { get; set; } = Array.Empty<ImportedMetricField>();

        /// <summary>
        /// <para>指标字段信息</para>
        /// </summary>
        public record ImportedMetricField
        {
            /// <summary>
            /// <para>指标字段 ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：7283776005142675476</para>
            /// </summary>
            [JsonPropertyName("field_id")]
            public string FieldId { get; set; } = string.Empty;

            /// <summary>
            /// <para>字段值</para>
            /// <para>必填：是</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("field_value")]
            public string FieldValue { get; set; } = string.Empty;
        }
    }
}
