// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2BasicInfoCurrenciesSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询货币信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询货币信息 响应体
/// <para>根据货币 ID、状态查询货币信息</para>
/// <para>接口ID：7301516605753163779</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/currency/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-currency%2fsearch</para>
/// </summary>
public record PostCorehrV2BasicInfoCurrenciesSearchResponseDto : IPageableResponse<PostCorehrV2BasicInfoCurrenciesSearchResponseDto.Currency>
{
    /// <summary>
    /// <para>查询到的货币信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Currency[]? Items { get; set; }

    /// <summary>
    /// <para>查询到的货币信息列表</para>
    /// </summary>
    public record Currency
    {
        /// <summary>
        /// <para>货币 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6863329932261459464</para>
        /// </summary>
        [JsonPropertyName("currency_id")]
        public string? CurrencyId { get; set; }

        /// <summary>
        /// <para>货币所属国家/地区 ID 列表，详细信息可通过[查询国家 / 地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口查询获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("country_region_id_list")]
        public string[]? CountryRegionIdList { get; set; }

        /// <summary>
        /// <para>货币名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("currency_name")]
        public I18n[]? CurrencyNames { get; set; }

        /// <summary>
        /// <para>货币名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>语言编码（IETF BCP 47）</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>文本内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：中文示例</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>数字代码（ISO 4217）</para>
        /// <para>必填：否</para>
        /// <para>示例值：156</para>
        /// </summary>
        [JsonPropertyName("numeric_code")]
        public int? NumericCode { get; set; }

        /// <summary>
        /// <para>三位字母代码（ISO 4217）</para>
        /// <para>必填：否</para>
        /// <para>示例值：CNY</para>
        /// </summary>
        [JsonPropertyName("currency_alpha_3_code")]
        public string? CurrencyAlpha3Code { get; set; }

        /// <summary>
        /// <para>状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：生效</item>
        /// <item>0：失效</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：6863329958782043655</para>
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
