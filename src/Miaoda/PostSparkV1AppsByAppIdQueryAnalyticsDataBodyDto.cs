// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-09-05
//
// Last Modified By : yxr
// Last Modified On : 2026-09-05
// ************************************************************************
// <copyright file="PostSparkV1AppsByAppIdQueryAnalyticsDataBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取妙搭应用运营数据趋势 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 获取妙搭应用运营数据趋势 请求体
/// <para>获取妙搭应用运营数据趋势</para>
/// <para>接口ID：7679858182358010822</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/query_analytics_data</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fquery_analytics_data</para>
/// </summary>
public record PostSparkV1AppsByAppIdQueryAnalyticsDataBodyDto
{
    /// <summary>
    /// <para>指标名列表</para>
    /// <para>必填：是</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>TOTAL_USER：累计用户数</item>
    /// <item>ACTIVE_USER：活跃用户数</item>
    /// <item>NEW_USER：新增用户数</item>
    /// <item>PAGE_VIEW：页面访问数</item>
    /// <item>API_REQUEST：暂不支持</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("metric_types")]
    public string[] MetricTypes { get; set; } = [];

    /// <summary>
    /// <para>起始时间戳，单位：纳秒</para>
    /// <para>必填：是</para>
    /// <para>示例值：1782132931498000000</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("start_timestamp_ns")]
    public string StartTimestampNs { get; set; } = string.Empty;

    /// <summary>
    /// <para>结束时间戳，单位：纳秒</para>
    /// <para>必填：是</para>
    /// <para>示例值：1782132931498000000</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("end_timestamp_ns")]
    public string EndTimestampNs { get; set; } = string.Empty;

    /// <summary>
    /// <para>时间聚合单元: DAY、WEEK、MONTH</para>
    /// <para>必填：是</para>
    /// <para>示例值：DAY</para>
    /// <para>可选值：<list type="bullet">
    /// <item>DAY：天</item>
    /// <item>WEEK：周</item>
    /// <item>MONTH：月</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("time_aggregation_unit")]
    public string TimeAggregationUnit { get; set; } = string.Empty;

    /// <summary>
    /// <para>其他过滤条件，key: 匹配字段名称（所有指标共享）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("filter")]
    public OpenApiAnalyticsFilter? Filter { get; set; }

    /// <summary>
    /// <para>其他过滤条件，key: 匹配字段名称（所有指标共享）</para>
    /// </summary>
    public record OpenApiAnalyticsFilter
    {
        /// <summary>
        /// <para>页面路径</para>
        /// <para>必填：否</para>
        /// <para>示例值：/home</para>
        /// <para>最大长度：10000</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("page")]
        public string? Page { get; set; }

        /// <summary>
        /// <para>终端类型</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("device_types")]
        public string[]? DeviceTypes { get; set; }
    }

    /// <summary>
    /// <para>是否需要补点：</para>
    /// <para>- true 时对缺失的时间点补 0；</para>
    /// <para>- false 时只返回原始数据点。</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("need_pack_lack_point")]
    public bool? NeedPackLackPoint { get; set; }

    /// <summary>
    /// <para>按字段聚合，当前只支持 device_ytpe</para>
    /// <para>必填：否</para>
    /// <para>示例值：device_type</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("group_by")]
    public string? GroupBy { get; set; }
}
