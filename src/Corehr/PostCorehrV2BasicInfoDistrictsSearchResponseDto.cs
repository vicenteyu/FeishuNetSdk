// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2BasicInfoDistrictsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询区/县信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询区/县信息 响应体
/// <para>根据区/县 ID、上级城市 ID，查询区/县信息</para>
/// <para>接口ID：7301516605753147395</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-district/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-district%2fsearch</para>
/// </summary>
public record PostCorehrV2BasicInfoDistrictsSearchResponseDto
{
    /// <summary>
    /// <para>查询到的区/县列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public District[]? Items { get; set; }

    /// <summary>
    /// <para>查询到的区/县列表</para>
    /// </summary>
    public record District
    {
        /// <summary>
        /// <para>区/县 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6863333353496512007</para>
        /// </summary>
        [JsonPropertyName("district_id")]
        public string? DistrictId { get; set; }

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
        /// <para>所属城市 ID，详细信息可通过[查询城市信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-city/search)接口获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6863333352603125255</para>
        /// </summary>
        [JsonPropertyName("city_id")]
        public string? CityId { get; set; }

        /// <summary>
        /// <para>行政区划代码</para>
        /// <para>必填：否</para>
        /// <para>示例值：230110</para>
        /// </summary>
        [JsonPropertyName("subregion_code")]
        public string? SubregionCode { get; set; }

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
    /// <para>示例值：6863333354096297480</para>
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
