// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-09-05
//
// Last Modified By : yxr
// Last Modified On : 2026-09-05
// ************************************************************************
// <copyright file="GetSparkV1AppsByAppIdCreditUsageResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取妙搭应用消耗 AI 额度 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 获取妙搭应用消耗 AI 额度 响应体
/// <para>获取妙搭应用消耗 AI 额度</para>
/// <para>接口ID：7679858182357978054</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/open_api_credit_usage</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fopen_api_credit_usage</para>
/// </summary>
public record GetSparkV1AppsByAppIdCreditUsageResponseDto
{
    /// <summary>
    /// <para>区间内 by day 数据点的总额度消耗总和</para>
    /// <para>必填：否</para>
    /// <para>示例值：1250.5</para>
    /// </summary>
    [JsonPropertyName("total")]
    public double? Total { get; set; }

    /// <summary>
    /// <para>按天的 AI 消耗量数据点列表，按 timestamp 升序</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("points")]
    public OpenApiCreditUsagePoint[]? Points { get; set; }

    /// <summary>
    /// <para>按天的 AI 消耗量数据点列表，按 timestamp 升序</para>
    /// </summary>
    public record OpenApiCreditUsagePoint
    {
        /// <summary>
        /// <para>数据点所在自然日的起始时间戳（该自然日 0 点），单位：秒</para>
        /// <para>必填：是</para>
        /// <para>示例值：1690848000</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; } = string.Empty;

        /// <summary>
        /// <para>当日 AI 消耗量（总额度，含企业 + 个人）</para>
        /// <para>必填：是</para>
        /// <para>示例值：1250.5</para>
        /// <para>最大值：99999999</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("credit_usage")]
        public double CreditUsage { get; set; }

        /// <summary>
        /// <para>当日企业额度消耗</para>
        /// <para>必填：是</para>
        /// <para>示例值：820.3</para>
        /// <para>最大值：99999999</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("credit_usage_enterprise")]
        public double CreditUsageEnterprise { get; set; }

        /// <summary>
        /// <para>当日个人额度消耗</para>
        /// <para>必填：是</para>
        /// <para>示例值：430.2</para>
        /// <para>最大值：99999999</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("credit_usage_personal")]
        public double CreditUsagePersonal { get; set; }
    }

    /// <summary>
    /// <para>区间内 by day 数据点的企业额度消耗总和</para>
    /// <para>必填：否</para>
    /// <para>示例值：980.2</para>
    /// </summary>
    [JsonPropertyName("total_enterprise")]
    public double? TotalEnterprise { get; set; }

    /// <summary>
    /// <para>区间内 by day 数据点的个人额度消耗总和</para>
    /// <para>必填：否</para>
    /// <para>示例值：270.3</para>
    /// </summary>
    [JsonPropertyName("total_personal")]
    public double? TotalPersonal { get; set; }
}
