namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 批量查询货币信息 响应体
/// <para>批量查询货币信息。</para>
/// <para>接口ID：7072978200179294210</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/currency/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcurrency%2flist</para>
/// </summary>
public record GetCorehrV1CurrenciesResponseDto
{
    /// <summary>
    /// <para>货币信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Currency[]? Items { get; set; }

    /// <summary>
    /// <para>货币信息</para>
    /// </summary>
    public record Currency
    {
        /// <summary>
        /// <para>货币id</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>货币所属国家/地区id，详细信息可通过【查询国家/地区信息】接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：12</para>
        /// </summary>
        [JsonPropertyName("country_region_id")]
        public string? CountryRegionId { get; set; }

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
        /// <para>数字代码</para>
        /// <para>必填：否</para>
        /// <para>示例值：12</para>
        /// </summary>
        [JsonPropertyName("numeric_code")]
        public int? NumericCode { get; set; }

        /// <summary>
        /// <para>三位字母代码</para>
        /// <para>必填：否</para>
        /// <para>示例值：12</para>
        /// </summary>
        [JsonPropertyName("currency_alpha_3_code")]
        public string? CurrencyAlpha3Code { get; set; }
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
