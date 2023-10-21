using Newtonsoft.Json;
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 查询单个货币信息 响应体
/// <para>查询单个货币信息。</para>
/// <para>接口ID：7072978068286357532</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/currency/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcurrency%2fget</para>
/// </summary>
public record GetCorehrV1CurrenciesByCurrencyIdResponseDto
{
    /// <summary>
    /// <para>货币信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("currency")]
    public GetCorehrV1CurrenciesByCurrencyIdResponseDtoCurrency? Currency { get; set; }

    /// <summary>
    /// <para>货币信息</para>
    /// </summary>
    public record GetCorehrV1CurrenciesByCurrencyIdResponseDtoCurrency
    {
        /// <summary>
        /// <para>货币id</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>货币所属国家/地区id，详细信息可通过【查询国家/地区信息】接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：12</para>
        /// </summary>
        [JsonProperty("country_region_id")]
        public string? CountryRegionId { get; set; }

        /// <summary>
        /// <para>货币名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("currency_name")]
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
            [JsonProperty("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>名称信息的内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonProperty("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>数字代码</para>
        /// <para>必填：否</para>
        /// <para>示例值：12</para>
        /// </summary>
        [JsonProperty("numeric_code")]
        public int? NumericCode { get; set; }

        /// <summary>
        /// <para>三位字母代码</para>
        /// <para>必填：否</para>
        /// <para>示例值：12</para>
        /// </summary>
        [JsonProperty("currency_alpha_3_code")]
        public string? CurrencyAlpha3Code { get; set; }
    }
}
