namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询国家/地区信息v2 响应体
/// <para>根据国家/地区 ID、状态批量查询国家/地区信息</para>
/// <para>接口ID：7301516605753229315</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-country_region%2fsearch</para>
/// </summary>
public record PostCorehrV2BasicInfoCountryRegionsSearchResponseDto
{
    /// <summary>
    /// <para>查询的国家/地区信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public CountryRegion[]? Items { get; set; }

    /// <summary>
    /// <para>查询的国家/地区信息</para>
    /// </summary>
    public record CountryRegion
    {
        /// <summary>
        /// <para>国家/地区 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893114062122064111</para>
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
        /// <para>国家/地区全称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("full_name")]
        public I18n[]? FullNames { get; set; }

        /// <summary>
        /// <para>国家地区二字码</para>
        /// <para>必填：否</para>
        /// <para>示例值：CN</para>
        /// </summary>
        [JsonPropertyName("alpha_2_code")]
        public string? Alpha2Code { get; set; }

        /// <summary>
        /// <para>国家地区三字码</para>
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
