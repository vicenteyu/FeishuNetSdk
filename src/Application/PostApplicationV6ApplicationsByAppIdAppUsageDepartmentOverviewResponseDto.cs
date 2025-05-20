// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="PostApplicationV6ApplicationsByAppIdAppUsageDepartmentOverviewResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取多部门应用使用概览 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 获取多部门应用使用概览 响应体
/// <para>查看应用在某一天/某一周/某一个月的使用数据，可以根据部门做多层子部门的筛选</para>
/// <para>接口ID：7036626399368937500</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/app-usage/department_overview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-app_usage%2fdepartment_overview</para>
/// </summary>
public record PostApplicationV6ApplicationsByAppIdAppUsageDepartmentOverviewResponseDto : IPageableResponse<PostApplicationV6ApplicationsByAppIdAppUsageDepartmentOverviewResponseDto.ApplicationDepartmentAppUsage>
{
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

    /// <summary>
    /// <para>部门内员工使用应用的概览数据</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("items")]
    public ApplicationDepartmentAppUsage[]? Items { get; set; }

    /// <summary>
    /// <para>部门内员工使用应用的概览数据</para>
    /// </summary>
    public record ApplicationDepartmentAppUsage
    {
        /// <summary>
        /// <para>租户内部门的唯一标识，ID值与查询参数中的department_id_type 对应。</para>
        /// <para>必填：否</para>
        /// <para>示例值：7a59bc779b7c1f19</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>应用整体使用情况，指标值包括：uv：活跃用户数，total_users：累计用户数，new_users：新增用户数，pv：在应用（小程序或网页）中访问的页面数，lifecycle：打开应用（小程序或网页）的次数</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10</para>
        /// </summary>
        [JsonPropertyName("app")]
        public ApplicationAppUsage[]? Apps { get; set; }

        /// <summary>
        /// <para>应用整体使用情况，指标值包括：uv：活跃用户数，total_users：累计用户数，new_users：新增用户数，pv：在应用（小程序或网页）中访问的页面数，lifecycle：打开应用（小程序或网页）的次数</para>
        /// </summary>
        public record ApplicationAppUsage
        {
            /// <summary>
            /// <para>指标名称</para>
            /// <para>必填：是</para>
            /// <para>示例值：pv</para>
            /// </summary>
            [JsonPropertyName("metric_name")]
            public string MetricName { get; set; } = string.Empty;

            /// <summary>
            /// <para>指标值</para>
            /// <para>必填：是</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("metric_value")]
            public int MetricValue { get; set; }
        }

        /// <summary>
        /// <para>小程序使用情况，没有小程序形态时为null，指标值包括：uv（小程序活跃用户数）、pv（用户在小程序中的访问页面数）、lifecycle（小程序的打开次数）</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10</para>
        /// </summary>
        [JsonPropertyName("gadget")]
        public ApplicationAppUsage[]? Gadgets { get; set; }

        /// <summary>
        /// <para>网页应用使用情况，没有网页应用形态时为null，指标值包括：uv（网页应用活跃用户数）、pv（用户在网页应用中的访问页面数）、lifecycle（网页应用的打开次数）</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10</para>
        /// </summary>
        [JsonPropertyName("webapp")]
        public ApplicationAppUsage[]? Webapps { get; set; }

        /// <summary>
        /// <para>机器人使用情况，没有机器人形态时为null</para>
        /// <para>指标值包括：uv（机器人的活跃用户数）</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10</para>
        /// </summary>
        [JsonPropertyName("bot")]
        public ApplicationAppUsage[]? Bots { get; set; }
    }
}
