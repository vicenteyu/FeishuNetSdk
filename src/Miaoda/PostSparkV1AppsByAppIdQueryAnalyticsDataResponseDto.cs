// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-09-05
//
// Last Modified By : yxr
// Last Modified On : 2026-09-05
// ************************************************************************
// <copyright file="PostSparkV1AppsByAppIdQueryAnalyticsDataResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取妙搭应用运营数据趋势 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 获取妙搭应用运营数据趋势 响应体
/// <para>获取妙搭应用运营数据趋势</para>
/// <para>接口ID：7679858182358010822</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/query_analytics_data</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fquery_analytics_data</para>
/// </summary>
public record PostSparkV1AppsByAppIdQueryAnalyticsDataResponseDto
{
    /// <summary>
    /// <para>序列</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("series")]
    public OpenApiAnalyticsDataSeries[]? Series { get; set; }

    /// <summary>
    /// <para>序列</para>
    /// </summary>
    public record OpenApiAnalyticsDataSeries
    {
        /// <summary>
        /// <para>指标类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：TOTAL_USER</para>
        /// <para>可选值：<list type="bullet">
        /// <item>TOTAL_USER：累计用户数</item>
        /// <item>ACTIVE_USER：活跃用户数</item>
        /// <item>NEW_USER：新增用户数</item>
        /// <item>PAGE_VIEW：页面访问数</item>
        /// <item>API_REQUEST：API 请求数</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("metric_type")]
        public string MetricType { get; set; } = string.Empty;

        /// <summary>
        /// <para>数据点</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10000000</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("points")]
        public OpenApiAnalyticsData[]? Points { get; set; }

        /// <summary>
        /// <para>数据点</para>
        /// </summary>
        public record OpenApiAnalyticsData
        {
            /// <summary>
            /// <para>数据点的时间戳，单位：纳秒</para>
            /// <para>必填：是</para>
            /// <para>示例值：1782132931498000000</para>
            /// <para>最大长度：20</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("timestamp_ns")]
            public string TimestampNs { get; set; } = string.Empty;

            /// <summary>
            /// <para>数据点的值</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// <para>最大值：9999999999999</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("value")]
            public double Value { get; set; }

            /// <summary>
            /// <para>数据点的维度</para>
            /// <para>必填：是</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("dimensions")]
            public Kv[] Dimensions { get; set; } = [];

            /// <summary>
            /// <para>数据点的维度</para>
            /// </summary>
            public record Kv
            {
                /// <summary>
                /// <para>key</para>
                /// <para>必填：是</para>
                /// <para>示例值：foo</para>
                /// <para>最大长度：1000</para>
                /// <para>最小长度：1</para>
                /// </summary>
                [JsonPropertyName("key")]
                public string Key { get; set; } = string.Empty;

                /// <summary>
                /// <para>value</para>
                /// <para>必填：是</para>
                /// <para>示例值：bar</para>
                /// <para>最大长度：1000</para>
                /// <para>最小长度：1</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }
    }
}
