namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 查询单条省份/行政区信息 响应体
/// <para>查询单条省份/行政区信息。</para>
/// <para>接口ID：7072978219502321665</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/location_data/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fsubdivision%2fget</para>
/// </summary>
public record GetCorehrV1SubdivisionsBySubdivisionIdResponseDto
{
    /// <summary>
    /// <para>国家/地址信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("subdivision")]
    public GetCorehrV1SubdivisionsBySubdivisionIdResponseDtoSubdivision? Subdivision { get; set; }

    /// <summary>
    /// <para>国家/地址信息</para>
    /// </summary>
    public record GetCorehrV1SubdivisionsBySubdivisionIdResponseDtoSubdivision
    {
        /// <summary>
        /// <para>省份/行政区id</para>
        /// <para>必填：是</para>
        /// <para>示例值：12</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>省份/行政区名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n[] Names { get; set; } = Array.Empty<I18n>();

        /// <summary>
        /// <para>省份/行政区名称</para>
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
        /// <para>所属国家/地区id，详细信息可通过【查询国家/地区信息】接口查询获得</para>
        /// <para>必填：是</para>
        /// <para>示例值：12</para>
        /// </summary>
        [JsonPropertyName("country_region_id")]
        public string CountryRegionId { get; set; } = string.Empty;

        /// <summary>
        /// <para>行政区类型，枚举值可通过文档【飞书人事枚举常量】行政区类型（subdivision_type）枚举定义部分获得</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("subdivision_type")]
        public Enum SubdivisionType { get; set; } = new();

        /// <summary>
        /// <para>行政区类型，枚举值可通过文档【飞书人事枚举常量】行政区类型（subdivision_type）枚举定义部分获得</para>
        /// </summary>
        public record Enum
        {
            /// <summary>
            /// <para>枚举值</para>
            /// <para>必填：是</para>
            /// <para>示例值：type_1</para>
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
        }
    }
}
