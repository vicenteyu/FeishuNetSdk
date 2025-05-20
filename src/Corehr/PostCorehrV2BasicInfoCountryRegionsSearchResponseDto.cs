// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2BasicInfoCountryRegionsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询国家/地区信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询国家/地区信息 响应体
/// <para>根据国家/地区 ID、状态，批量查询国家/地区信息</para>
/// <para>接口ID：7301516605753229315</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/location_data/search-4</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-country_region%2fsearch</para>
/// </summary>
public record PostCorehrV2BasicInfoCountryRegionsSearchResponseDto : IPageableResponse<PostCorehrV2BasicInfoCountryRegionsSearchResponseDto.CountryRegion>
{
    /// <summary>
    /// <para>查询到的国家/地区列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public CountryRegion[]? Items { get; set; }

    /// <summary>
    /// <para>查询到的国家/地区列表</para>
    /// </summary>
    public record CountryRegion
    {
        /// <summary>
        /// <para>国家/地区 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6862995757234914824</para>
        /// </summary>
        [JsonPropertyName("country_region_id")]
        public string? CountryRegionId { get; set; }

        /// <summary>
        /// <para>国家/地区名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n[]? Names { get; set; }

        /// <summary>
        /// <para>国家/地区名称</para>
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
            /// <para>示例值：中国</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>国家/地区全称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("full_name")]
        public I18n[]? FullNames { get; set; }

        /// <summary>
        /// <para>国家/地区两位字母编码（ISO 3166-1）</para>
        /// <para>必填：否</para>
        /// <para>示例值：CN</para>
        /// </summary>
        [JsonPropertyName("alpha_2_code")]
        public string? Alpha2Code { get; set; }

        /// <summary>
        /// <para>国家/地区三位字母编码（ISO 3166-1）</para>
        /// <para>必填：否</para>
        /// <para>示例值：CHN</para>
        /// </summary>
        [JsonPropertyName("alpha_3_code")]
        public string? Alpha3Code { get; set; }

        /// <summary>
        /// <para>国际电话区号</para>
        /// <para>必填：否</para>
        /// <para>示例值：+86</para>
        /// </summary>
        [JsonPropertyName("global_code")]
        public string? GlobalCode { get; set; }

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
    /// <para>示例值：6862995772275688974</para>
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
