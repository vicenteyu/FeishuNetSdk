// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-09-05
//
// Last Modified By : yxr
// Last Modified On : 2026-09-05
// ************************************************************************
// <copyright file="GetSparkV1AppsByAppIdAnalyticsOverviewResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取妙搭应用运营数据总览 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 获取妙搭应用运营数据总览 响应体
/// <para>获取妙搭应用运营数据总览</para>
/// <para>接口ID：7679858182357994438</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/open_api_analytics_overview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fopen_api_analytics_overview</para>
/// </summary>
public record GetSparkV1AppsByAppIdAnalyticsOverviewResponseDto
{
    /// <summary>
    /// <para>单个运营指标对象（含本区间值、上一等长区间值与环比）。</para>
    /// <para>必填：否</para>
    /// <para>示例值：{"current":1200,"previous":1000,"delta":200,"rate":0.2}</para>
    /// </summary>
    [JsonPropertyName("active_users")]
    public OpenApiAnalyticsMetric? ActiveUsers { get; set; }

    /// <summary>
    /// <para>单个运营指标对象（含本区间值、上一等长区间值与环比）。</para>
    /// </summary>
    public record OpenApiAnalyticsMetric
    {
        /// <summary>
        /// <para>本区间指标值</para>
        /// <para>必填：是</para>
        /// <para>示例值：12500</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;

        /// <summary>
        /// <para>上一等长区间的指标值（环比基准）</para>
        /// <para>必填：是</para>
        /// <para>示例值：15000</para>
        /// </summary>
        [JsonPropertyName("prev_value")]
        public string PrevValue { get; set; } = string.Empty;

        /// <summary>
        /// <para>环比绝对变化 = value - prev_value</para>
        /// <para>必填：是</para>
        /// <para>示例值：-2500</para>
        /// </summary>
        [JsonPropertyName("diff")]
        public string Diff { get; set; } = string.Empty;

        /// <summary>
        /// <para>环比变化率（小数，如 -0.714 表示下降 71.4%）；prev_value 为 0 时为 0</para>
        /// <para>必填：是</para>
        /// <para>示例值：-0.1667</para>
        /// <para>最大值：99999</para>
        /// <para>最小值：-99999</para>
        /// </summary>
        [JsonPropertyName("ratio")]
        public double Ratio { get; set; }
    }

    /// <summary>
    /// <para>单个运营指标对象（含本区间值、上一等长区间值与环比）。</para>
    /// <para>必填：否</para>
    /// <para>示例值：{"current":350,"previous":300,"delta":50,"rate":0.1667}</para>
    /// </summary>
    [JsonPropertyName("signups")]
    public OpenApiAnalyticsMetric? Signups { get; set; }

    /// <summary>
    /// <para>单个运营指标对象（含本区间值、上一等长区间值与环比）。</para>
    /// <para>必填：否</para>
    /// <para>示例值：{"current":8500,"previous":7800,"delta":700,"rate":0.0897}</para>
    /// </summary>
    [JsonPropertyName("page_views")]
    public OpenApiAnalyticsMetric? PageViews { get; set; }
}
