namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询城市信息v2 响应体
/// <para>根据上级省份/行政区 ID 、城市 ID、状态 查询城市（自治区、地区、县「美」、町、村「日」）信息</para>
/// <para>接口ID：7301516605753131011</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-city/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-city%2fsearch</para>
/// </summary>
public record PostCorehrV2BasicInfoCitiesSearchResponseDto
{
    /// <summary>
    /// <para>查询的城市信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public City[]? Items { get; set; }

    /// <summary>
    /// <para>查询的城市信息</para>
    /// </summary>
    public record City
    {
        /// <summary>
        /// <para>城市 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6822114662122064111</para>
        /// </summary>
        [JsonPropertyName("city_id")]
        public string? CityId { get; set; }

        /// <summary>
        /// <para>城市名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n[]? Names { get; set; }

        /// <summary>
        /// <para>城市名称</para>
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
        /// <para>所属省份/行政区 ID，详细信息可通过[查询省份/行政区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6822114062133062211</para>
        /// </summary>
        [JsonPropertyName("country_region_subdivision_id")]
        public string? CountryRegionSubdivisionId { get; set; }

        /// <summary>
        /// <para>城市三字码</para>
        /// <para>必填：否</para>
        /// <para>示例值：PEK</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

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
