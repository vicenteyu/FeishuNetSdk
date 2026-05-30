// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-30
//
// Last Modified By : yxr
// Last Modified On : 2026-05-29
// ************************************************************************
// <copyright file="GetAilyV1AppStatsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询应用统计数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 查询应用统计数据 响应体
/// <para>该 API 用于查询租户下的工作流/智能体应用使用情况的统计数据</para>
/// <para>接口ID：7644497349981572316</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/tenant-app_stat/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2ftenant-app_stat%2flist</para>
/// </summary>
public record GetAilyV1AppStatsResponseDto : IPageableResponse<GetAilyV1AppStatsResponseDto.AppStat>
{
    /// <summary>
    /// <para>统计数据列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public AppStat[]? Items { get; set; }

    /// <summary>
    /// <para>统计数据列表</para>
    /// </summary>
    public record AppStat
    {
        /// <summary>
        /// <para>应用唯一标识</para>
        /// <para>必填：是</para>
        /// <para>示例值：app_7d2f9c4a1b3e8</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>应用名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：智能客服助手</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>活跃用户数</para>
        /// <para>必填：否</para>
        /// <para>示例值：1256.89</para>
        /// <para>最大值：2147483647</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("avg_daily_active_user_num")]
        public double? AvgDailyActiveUserNum { get; set; }

        /// <summary>
        /// <para>日均对话次数</para>
        /// <para>必填：否</para>
        /// <para>示例值：8923.45</para>
        /// <para>最大值：2147483647</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("avg_daily_run_num")]
        public double? AvgDailyRunNum { get; set; }

        /// <summary>
        /// <para>日均消耗额度</para>
        /// <para>必填：否</para>
        /// <para>示例值：5678.23</para>
        /// <para>最大值：2147483647</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("avg_daily_credit_usage")]
        public double? AvgDailyCreditUsage { get; set; }

        /// <summary>
        /// <para>总消耗额度</para>
        /// <para>必填：否</para>
        /// <para>示例值：170346.9</para>
        /// <para>最大值：2147483647</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("total_credit_usage")]
        public double? TotalCreditUsage { get; set; }

        /// <summary>
        /// <para>应用所有者信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("owner")]
        public LookupWithAvatar? Owner { get; set; }

        /// <summary>
        /// <para>应用所有者信息</para>
        /// </summary>
        public record LookupWithAvatar
        {
            /// <summary>
            /// <para>kunlun userId</para>
            /// <para>必填：是</para>
            /// <para>示例值：1787137372910676</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string Id { get; set; } = string.Empty;

            /// <summary>
            /// <para>人员名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>租户ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：200001</para>
            /// </summary>
            [JsonPropertyName("tenant_id")]
            public string? TenantId { get; set; }

            /// <summary>
            /// <para>飞书 User ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7563596720278863891</para>
            /// </summary>
            [JsonPropertyName("lark_user_id")]
            public string? LarkUserId { get; set; }
        }

        /// <summary>
        /// <para>应用创建时间，格式为YYYY-MM-DD HH:mm:ss</para>
        /// <para>必填：否</para>
        /// <para>示例值：2024-01-15 14:30:00</para>
        /// </summary>
        [JsonPropertyName("app_created_at")]
        public string? AppCreatedAt { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eyJwYWdlX251bWJlciI6MywiY29udGVudF9pZCI6IjE2OTg3Mjk2MDAifQ==</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
