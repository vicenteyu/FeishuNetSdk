// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2BasicInfoNationalitiesSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询国籍信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询国籍信息 响应体
/// <para>根据国家 ID、国籍 ID 查询国籍信息</para>
/// <para>接口ID：7301516605753180163</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-nationality/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-nationality%2fsearch</para>
/// </summary>
public record PostCorehrV2BasicInfoNationalitiesSearchResponseDto
{
    /// <summary>
    /// <para>查询的国籍信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Nationality[]? Items { get; set; }

    /// <summary>
    /// <para>查询的国籍信息</para>
    /// </summary>
    public record Nationality
    {
        /// <summary>
        /// <para>国籍 ID（对应其他查询结果的 nationality_id_v2 字段）</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("nationality_id")]
        public string? NationalityId { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n[]? Names { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>语言</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>二字码</para>
        /// <para>必填：否</para>
        /// <para>示例值：CN</para>
        /// </summary>
        [JsonPropertyName("alpha_2_code")]
        public string? Alpha2Code { get; set; }

        /// <summary>
        /// <para>三字码</para>
        /// <para>必填：否</para>
        /// <para>示例值：CHN</para>
        /// </summary>
        [JsonPropertyName("alpha_3_code")]
        public string? Alpha3Code { get; set; }

        /// <summary>
        /// <para>数字代码</para>
        /// <para>必填：否</para>
        /// <para>示例值：156</para>
        /// </summary>
        [JsonPropertyName("numeric_code")]
        public int? NumericCode { get; set; }

        /// <summary>
        /// <para>国家 / 地区 ID ，可通过[查询国家 / 地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口查询</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014061142064135</para>
        /// </summary>
        [JsonPropertyName("country_region_id")]
        public string? CountryRegionId { get; set; }

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
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
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
