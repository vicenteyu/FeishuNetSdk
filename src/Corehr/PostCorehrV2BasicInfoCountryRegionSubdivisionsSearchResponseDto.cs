// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2BasicInfoCountryRegionSubdivisionsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询省份/行政区信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询省份/主要行政区信息 响应体
/// <para>根据国家/地区 ID、省份/主要行政区 ID、状态，批量查询国家/地区下辖的一级行政区（如省份、直辖市、自治区、州等）数据</para>
/// <para>接口ID：7301516605753245699</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/location_data/search-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-country_region_subdivision%2fsearch</para>
/// </summary>
public record PostCorehrV2BasicInfoCountryRegionSubdivisionsSearchResponseDto
{
    /// <summary>
    /// <para>查询的省份/主要行政区信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public CountryRegionSubdivision[]? Items { get; set; }

    /// <summary>
    /// <para>查询的省份/主要行政区信息</para>
    /// </summary>
    public record CountryRegionSubdivision
    {
        /// <summary>
        /// <para>省份/主要行政区 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6863326571462133262</para>
        /// </summary>
        [JsonPropertyName("country_region_subdivision_id")]
        public string? CountryRegionSubdivisionId { get; set; }

        /// <summary>
        /// <para>省份/主要行政区名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n[]? Names { get; set; }

        /// <summary>
        /// <para>省份/主要行政区名称</para>
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
        /// <para>所属国家/地区 ID，详细信息可通过[查询国家 / 地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6862995791674344967</para>
        /// </summary>
        [JsonPropertyName("country_region_id")]
        public string? CountryRegionId { get; set; }

        /// <summary>
        /// <para>行政区类型，枚举值可通过[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant#402ea9a0)文档中行政区类型（subdivision_type）定义部分获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("subdivision_type")]
        public Enum? SubdivisionType { get; set; }

        /// <summary>
        /// <para>行政区类型，枚举值可通过[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant#402ea9a0)文档中行政区类型（subdivision_type）定义部分获得</para>
        /// </summary>
        public record Enum
        {
            /// <summary>
            /// <para>枚举值</para>
            /// <para>必填：是</para>
            /// <para>示例值：governorate</para>
            /// </summary>
            [JsonPropertyName("enum_name")]
            public string EnumName { get; set; } = string.Empty;

            /// <summary>
            /// <para>枚举多语展示</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("display")]
            public I18n[]? Displies { get; set; }

            /// <summary>
            /// <para>枚举多语展示</para>
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
        }

        /// <summary>
        /// <para>省份/主要行政区编码（ISO 3166-2）</para>
        /// <para>必填：否</para>
        /// <para>示例值：PSE-GZA</para>
        /// </summary>
        [JsonPropertyName("iso_code")]
        public string? IsoCode { get; set; }

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
    /// <para>示例值：6891251722631890445</para>
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
