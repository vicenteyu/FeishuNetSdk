// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetCompensationV1IndicatorsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询薪资统计指标 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 批量查询薪资统计指标 响应体
/// <para>批量查询薪资统计指标</para>
/// <para>接口ID：7314129756769796100</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/indicator/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2findicator%2flist</para>
/// </summary>
public record GetCompensationV1IndicatorsResponseDto
{
    /// <summary>
    /// <para>薪资统计指标信息列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Indicator[] Items { get; set; } = Array.Empty<Indicator>();

    /// <summary>
    /// <para>薪资统计指标信息列表</para>
    /// </summary>
    public record Indicator
    {
        /// <summary>
        /// <para>薪资统计指标ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7196951947228589113</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>薪资统计指标名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：年度现金总和</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>薪资统计指标数值类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：money</para>
        /// <para>可选值：<list type="bullet">
        /// <item>money：金额</item>
        /// <item>number：数值</item>
        /// <item>percent：百分比</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("value_type")]
        public string ValueType { get; set; } = string.Empty;

        /// <summary>
        /// <para>启用状态</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：启用</item>
        /// <item>0：禁用</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("active_status")]
        public int ActiveStatus { get; set; }

        /// <summary>
        /// <para>多语言名称</para>
        /// <para>必填：是</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("i18n_names")]
        public I18nContent[] I18nNames { get; set; } = Array.Empty<I18nContent>();

        /// <summary>
        /// <para>多语言名称</para>
        /// </summary>
        public record I18nContent
        {
            /// <summary>
            /// <para>语言版本，例如：“zh-CN”、“en-US”</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh_cn</para>
            /// </summary>
            [JsonPropertyName("locale")]
            public string? Locale { get; set; }

            /// <summary>
            /// <para>语言名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：中文名称</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1234452132</para>
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
