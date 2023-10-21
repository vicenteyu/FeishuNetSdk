using Newtonsoft.Json;
namespace FeishuNetSdk.Application;
/// <summary>
/// 获取应用使用概览 响应体
/// <para>查看应用在某一天/某一周/某一个月的使用数据，可以查看租户整体对应用的使用情况，也可以分部门查看。</para>
/// <para>接口ID：6995148762798178332</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/app-usage/overview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-app_usage%2foverview</para>
/// </summary>
public record PostApplicationV6ApplicationsByAppIdAppUsageOverviewResponseDto
{
    /// <summary>
    /// <para>员工使用应用概览数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public ApplicationAppUsage[]? Items { get; set; }

    /// <summary>
    /// <para>员工使用应用概览数据</para>
    /// </summary>
    public record ApplicationAppUsage
    {
        /// <summary>
        /// <para>指标名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：pv</para>
        /// </summary>
        [JsonProperty("metric_name")]
        public string MetricName { get; set; } = string.Empty;

        /// <summary>
        /// <para>指标值</para>
        /// <para>必填：是</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonProperty("metric_value")]
        public int MetricValue { get; set; }
    }
}
