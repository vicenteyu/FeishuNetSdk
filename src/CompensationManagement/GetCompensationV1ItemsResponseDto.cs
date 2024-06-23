// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetCompensationV1ItemsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询薪资项 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 批量查询薪资项 响应体
/// <para>批量查询薪资项</para>
/// <para>接口ID：7314129756769779716</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/item/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2fitem%2flist</para>
/// </summary>
public record GetCompensationV1ItemsResponseDto
{
    /// <summary>
    /// <para>薪资项信息列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Item[] Items { get; set; } = Array.Empty<Item>();

    /// <summary>
    /// <para>薪资项信息列表</para>
    /// </summary>
    public record Item
    {
        /// <summary>
        /// <para>薪资项ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7196951947268589113</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>薪资项名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：基本月薪</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>薪资项描述</para>
        /// <para>必填：是</para>
        /// <para>示例值：每月份的薪酬</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// <para>薪资项分类ID，详细信息可以通过[批量获取薪资项分类信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/item_category/list)接口查询获得</para>
        /// <para>必填：是</para>
        /// <para>示例值：7196951947268589223</para>
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; } = string.Empty;

        /// <summary>
        /// <para>薪资项数值类型</para>
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
        /// <para>发放频率</para>
        /// <para>必填：是</para>
        /// <para>示例值：month</para>
        /// <para>可选值：<list type="bullet">
        /// <item>year：年</item>
        /// <item>half_year：半年</item>
        /// <item>quarterly：季度</item>
        /// <item>bimonthly：双月</item>
        /// <item>month：月</item>
        /// <item>biweekly：双周</item>
        /// <item>week：周</item>
        /// <item>day：日</item>
        /// <item>hour：小时</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("pay_off_frequency_type")]
        public string PayOffFrequencyType { get; set; } = string.Empty;

        /// <summary>
        /// <para>小数位数</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// <para>最大值：6</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("decimal_places")]
        public int? DecimalPlaces { get; set; }

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

        /// <summary>
        /// <para>多语言描述</para>
        /// <para>必填：是</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("i18n_descriptions")]
        public I18nContent[] I18nDescriptions { get; set; } = Array.Empty<I18nContent>();
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
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool HasMore { get; set; }
}
