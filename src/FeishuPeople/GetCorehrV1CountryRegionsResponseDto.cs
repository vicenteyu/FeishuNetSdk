// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetCorehrV1CountryRegionsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询国家/地区信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 批量查询国家/地区信息 响应体
/// <para>批量查询国家/地区信息。</para>
/// <para>接口ID：7072977636028874753</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/location_data/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcountry_region%2flist</para>
/// </summary>
public record GetCorehrV1CountryRegionsResponseDto : IPageableResponse<GetCorehrV1CountryRegionsResponseDto.CountryRegion>
{
    /// <summary>
    /// <para>国家/地区信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public CountryRegion[]? Items { get; set; }

    /// <summary>
    /// <para>国家/地区信息</para>
    /// </summary>
    public record CountryRegion
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
        public I18n[] Names { get; set; } = Array.Empty<I18n>();

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
    /// <para>示例值：1234452132</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
