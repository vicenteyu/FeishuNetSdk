// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-12
//
// Last Modified By : yxr
// Last Modified On : 2024-07-12
// ************************************************************************
// <copyright file="PostHireV1LocationsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询地点列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 查询地点列表 响应体
/// <para>根据地点类型和地点码查询地点列表，获取地点名称信息。</para>
/// <para>## 名词解释</para>
/// <para>地点：行政区域划分，如 「中国大陆」、「四川省」、「成都市」、「高新区」</para>
/// <para>地址：分为职位地址与面试地址，如：「中国四川省成都市成华区熊猫大道1375号」</para>
/// <para>接口ID：7385067676815949828</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/recruitment-related-configuration/location/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2flocation%2fquery</para>
/// </summary>
public record PostHireV1LocationsQueryResponseDto
{
    /// <summary>
    /// <para>地点数据列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public LocationDto[]? Items { get; set; }

    /// <summary>
    /// <para>地点数据列表</para>
    /// </summary>
    public record LocationDto
    {
        /// <summary>
        /// <para>国家信息列表，仅当 location_type=1 时返回</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("country")]
        public LocationCountry? Country { get; set; }

        /// <summary>
        /// <para>国家信息列表，仅当 location_type=1 时返回</para>
        /// </summary>
        public record LocationCountry
        {
            /// <summary>
            /// <para>国家Code码</para>
            /// <para>必填：否</para>
            /// <para>示例值：CN_1</para>
            /// </summary>
            [JsonPropertyName("country_code")]
            public string? CountryCode { get; set; }

            /// <summary>
            /// <para>国家名称信息聚合</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("country_name_info")]
            public LocationNameInfo? CountryNameInfo { get; set; }

            /// <summary>
            /// <para>国家名称信息聚合</para>
            /// </summary>
            public record LocationNameInfo
            {
                /// <summary>
                /// <para>国家中文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：成都</para>
                /// </summary>
                [JsonPropertyName("zh_name")]
                public string? ZhName { get; set; }

                /// <summary>
                /// <para>国家英文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：Chinese Mainland</para>
                /// </summary>
                [JsonPropertyName("en_name")]
                public string? EnName { get; set; }

                /// <summary>
                /// <para>国家拼音名</para>
                /// <para>必填：否</para>
                /// <para>示例值：zhongguodalu</para>
                /// </summary>
                [JsonPropertyName("py_name")]
                public string? PyName { get; set; }
            }
        }

        /// <summary>
        /// <para>省份/州信息列表，仅当 location_type=2 时返回</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("state")]
        public LocationState? State { get; set; }

        /// <summary>
        /// <para>省份/州信息列表，仅当 location_type=2 时返回</para>
        /// </summary>
        public record LocationState
        {
            /// <summary>
            /// <para>省份/州Code码</para>
            /// <para>必填：否</para>
            /// <para>示例值：ST_1</para>
            /// </summary>
            [JsonPropertyName("state_code")]
            public string? StateCode { get; set; }

            /// <summary>
            /// <para>国家Code码</para>
            /// <para>必填：否</para>
            /// <para>示例值：CN_1</para>
            /// </summary>
            [JsonPropertyName("country_code")]
            public string? CountryCode { get; set; }

            /// <summary>
            /// <para>省份/州名称信息聚合</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("state_name_info")]
            public LocationNameInfo? StateNameInfo { get; set; }

            /// <summary>
            /// <para>省份/州名称信息聚合</para>
            /// </summary>
            public record LocationNameInfo
            {
                /// <summary>
                /// <para>省份/州中文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：成都</para>
                /// </summary>
                [JsonPropertyName("zh_name")]
                public string? ZhName { get; set; }

                /// <summary>
                /// <para>省份/州英文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：Liaoning</para>
                /// </summary>
                [JsonPropertyName("en_name")]
                public string? EnName { get; set; }

                /// <summary>
                /// <para>省份/州拼音名</para>
                /// <para>必填：否</para>
                /// <para>示例值：liaoning</para>
                /// </summary>
                [JsonPropertyName("py_name")]
                public string? PyName { get; set; }
            }
        }

        /// <summary>
        /// <para>市信息列表，仅当 location_type=3 时返回</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("city")]
        public LocationCity? City { get; set; }

        /// <summary>
        /// <para>市信息列表，仅当 location_type=3 时返回</para>
        /// </summary>
        public record LocationCity
        {
            /// <summary>
            /// <para>市Code码</para>
            /// <para>必填：否</para>
            /// <para>示例值：CT_1</para>
            /// </summary>
            [JsonPropertyName("city_code")]
            public string? CityCode { get; set; }

            /// <summary>
            /// <para>省份/州Code码</para>
            /// <para>必填：否</para>
            /// <para>示例值：ST_1</para>
            /// </summary>
            [JsonPropertyName("state_code")]
            public string? StateCode { get; set; }

            /// <summary>
            /// <para>国家Code码</para>
            /// <para>必填：否</para>
            /// <para>示例值：CN_1</para>
            /// </summary>
            [JsonPropertyName("country_code")]
            public string? CountryCode { get; set; }

            /// <summary>
            /// <para>市名称信息聚合</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("city_name_info")]
            public LocationNameInfo? CityNameInfo { get; set; }

            /// <summary>
            /// <para>市名称信息聚合</para>
            /// </summary>
            public record LocationNameInfo
            {
                /// <summary>
                /// <para>市中文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：成都</para>
                /// </summary>
                [JsonPropertyName("zh_name")]
                public string? ZhName { get; set; }

                /// <summary>
                /// <para>市英文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：ChengDu</para>
                /// </summary>
                [JsonPropertyName("en_name")]
                public string? EnName { get; set; }

                /// <summary>
                /// <para>市拼音名</para>
                /// <para>必填：否</para>
                /// <para>示例值：chengdu</para>
                /// </summary>
                [JsonPropertyName("py_name")]
                public string? PyName { get; set; }
            }
        }

        /// <summary>
        /// <para>区/县信息列表，仅当 location_type=4 时返回</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("district")]
        public LocationDistrict? District { get; set; }

        /// <summary>
        /// <para>区/县信息列表，仅当 location_type=4 时返回</para>
        /// </summary>
        public record LocationDistrict
        {
            /// <summary>
            /// <para>区/县Code码</para>
            /// <para>必填：否</para>
            /// <para>示例值：DS_70</para>
            /// </summary>
            [JsonPropertyName("district_code")]
            public string? DistrictCode { get; set; }

            /// <summary>
            /// <para>市Code码</para>
            /// <para>必填：否</para>
            /// <para>示例值：CT_1</para>
            /// </summary>
            [JsonPropertyName("city_code")]
            public string? CityCode { get; set; }

            /// <summary>
            /// <para>省份/州Code码</para>
            /// <para>必填：否</para>
            /// <para>示例值：ST_1</para>
            /// </summary>
            [JsonPropertyName("state_code")]
            public string? StateCode { get; set; }

            /// <summary>
            /// <para>国家Code码</para>
            /// <para>必填：否</para>
            /// <para>示例值：CN_1</para>
            /// </summary>
            [JsonPropertyName("country_code")]
            public string? CountryCode { get; set; }

            /// <summary>
            /// <para>区/县名称信息聚合</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("district_name_info")]
            public LocationNameInfo? DistrictNameInfo { get; set; }

            /// <summary>
            /// <para>区/县名称信息聚合</para>
            /// </summary>
            public record LocationNameInfo
            {
                /// <summary>
                /// <para>区/县中文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：成都</para>
                /// </summary>
                [JsonPropertyName("zh_name")]
                public string? ZhName { get; set; }

                /// <summary>
                /// <para>区/县英文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：ChengDu</para>
                /// </summary>
                [JsonPropertyName("en_name")]
                public string? EnName { get; set; }

                /// <summary>
                /// <para>区/县拼音名</para>
                /// <para>必填：否</para>
                /// <para>示例值：chengdu</para>
                /// </summary>
                [JsonPropertyName("py_name")]
                public string? PyName { get; set; }
            }
        }
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
    /// <para>示例值：eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ==</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
