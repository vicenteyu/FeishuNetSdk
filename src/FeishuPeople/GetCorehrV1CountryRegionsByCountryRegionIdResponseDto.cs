// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetCorehrV1CountryRegionsByCountryRegionIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询单条国家/地区信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 查询单条国家/地区信息 响应体
/// <para>查询单条国家/地区信息。</para>
/// <para>接口ID：7072978180814618652</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/location_data/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcountry_region%2fget</para>
/// </summary>
public record GetCorehrV1CountryRegionsByCountryRegionIdResponseDto
{
    /// <summary>
    /// <para>国家/地区信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("country_region")]
    public GetCorehrV1CountryRegionsByCountryRegionIdResponseDtoCountryRegion? CountryRegion { get; set; }

    /// <summary>
    /// <para>国家/地区信息</para>
    /// </summary>
    public record GetCorehrV1CountryRegionsByCountryRegionIdResponseDtoCountryRegion
    {
        /// <summary>
        /// <para>国家/地区id</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>国家/地区名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n[] Names { get; set; } = [];

        /// <summary>
        /// <para>国家/地区名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>名称信息的语言</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>名称信息的内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>国家地区三字码</para>
        /// <para>必填：是</para>
        /// <para>示例值：12</para>
        /// </summary>
        [JsonPropertyName("alpha_3_code")]
        public string Alpha3Code { get; set; } = string.Empty;

        /// <summary>
        /// <para>国家地区二字码</para>
        /// <para>必填：是</para>
        /// <para>示例值：12</para>
        /// </summary>
        [JsonPropertyName("alpha_2_code")]
        public string Alpha2Code { get; set; } = string.Empty;
    }
}
