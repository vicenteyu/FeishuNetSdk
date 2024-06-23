// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetOkrV1PeriodRulesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取 OKR 周期规则 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 获取 OKR 周期规则 响应体
/// <para>获取租户的周期规则列表。</para>
/// <para>接口ID：7177567881395699740</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/period_rule/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fperiod_rule%2flist</para>
/// </summary>
public record GetOkrV1PeriodRulesResponseDto
{
    /// <summary>
    /// <para>周期规则列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("period_rules")]
    public PeriodRule[]? PeriodRules { get; set; }

    /// <summary>
    /// <para>周期规则列表</para>
    /// </summary>
    public record PeriodRule
    {
        /// <summary>
        /// <para>周期规则ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：134</para>
        /// </summary>
        [JsonPropertyName("period_rule_id")]
        public string? PeriodRuleId { get; set; }

        /// <summary>
        /// <para>周期类型</para>
        /// <para>- year: 年度周期</para>
        /// <para>- month: 月度周期</para>
        /// <para>必填：否</para>
        /// <para>示例值：year</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>周期长度（月)</para>
        /// <para>必填：否</para>
        /// <para>示例值：12</para>
        /// </summary>
        [JsonPropertyName("length")]
        public int? Length { get; set; }

        /// <summary>
        /// <para>每年首个开始月份</para>
        /// <para>必填：否</para>
        /// <para>示例值：12</para>
        /// </summary>
        [JsonPropertyName("first_month")]
        public int? FirstMonth { get; set; }
    }
}
