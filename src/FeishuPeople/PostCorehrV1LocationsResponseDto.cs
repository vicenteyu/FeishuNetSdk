using Newtonsoft.Json;
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 创建地点 响应体
/// <para>创建地点。</para>
/// <para>接口ID：7072646479949316098</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/location/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2flocation%2fcreate</para>
/// </summary>
public record PostCorehrV1LocationsResponseDto
{
    /// <summary>
    /// <para>4718803945687580505</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("location")]
    public PostCorehrV1LocationsResponseDtoLocation? Location { get; set; }

    /// <summary>
    /// <para>4718803945687580505</para>
    /// </summary>
    public record PostCorehrV1LocationsResponseDtoLocation
    {
        /// <summary>
        /// <para>实体在CoreHR内部的唯一键</para>
        /// <para>必填：否</para>
        /// <para>示例值：4718803945687580505</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>层级关系，内层字段见实体</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("hiberarchy_common")]
        public PostCorehrV1LocationsResponseDtoLocationHiberarchyCommon HiberarchyCommon { get; set; } = new();

        /// <summary>
        /// <para>层级关系，内层字段见实体</para>
        /// </summary>
        public record PostCorehrV1LocationsResponseDtoLocationHiberarchyCommon
        {
            /// <summary>
            /// <para>上级组织</para>
            /// <para>必填：否</para>
            /// <para>示例值：4719168654814483759</para>
            /// </summary>
            [JsonProperty("parent_id")]
            public string? ParentId { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonProperty("name")]
            public I18n[] Names { get; set; } = Array.Empty<I18n>();

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
                [JsonProperty("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：刘梓新</para>
                /// </summary>
                [JsonProperty("value")]
                public string Value { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>组织类型</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonProperty("type")]
            public Enum Type { get; set; } = new();

            /// <summary>
            /// <para>组织类型</para>
            /// </summary>
            public record Enum
            {
                /// <summary>
                /// <para>枚举值</para>
                /// <para>必填：是</para>
                /// <para>示例值：phone_type</para>
                /// </summary>
                [JsonProperty("enum_name")]
                public string EnumName { get; set; } = string.Empty;

                /// <summary>
                /// <para>枚举多语展示</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("display")]
                public I18n[]? Displies { get; set; }

                /// <summary>
                /// <para>枚举多语展示</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>语言</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：zh-CN</para>
                    /// </summary>
                    [JsonProperty("lang")]
                    public string Lang { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：刘梓新</para>
                    /// </summary>
                    [JsonProperty("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>启用</para>
            /// <para>必填：是</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonProperty("active")]
            public bool Active { get; set; }

            /// <summary>
            /// <para>生效时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-05-0100:00:00</para>
            /// </summary>
            [JsonProperty("effective_time")]
            public string? EffectiveTime { get; set; }

            /// <summary>
            /// <para>失效时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-05-0200:00:00</para>
            /// </summary>
            [JsonProperty("expiration_time")]
            public string? ExpirationTime { get; set; }

            /// <summary>
            /// <para>编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：12456</para>
            /// </summary>
            [JsonProperty("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>描述</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("description")]
            public I18n[]? Descriptions { get; set; }

            /// <summary>
            /// <para>树形排序，代表同层级的部门排序序号</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonProperty("tree_order")]
            public string? TreeOrder { get; set; }

            /// <summary>
            /// <para>列表排序，代表所有部门的混排序号</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonProperty("list_order")]
            public string? ListOrder { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("custom_fields")]
            public ObjectFieldData[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record ObjectFieldData
            {
                /// <summary>
                /// <para>字段名</para>
                /// <para>必填：是</para>
                /// <para>示例值：name</para>
                /// </summary>
                [JsonProperty("field_name")]
                public string FieldName { get; set; } = string.Empty;

                /// <summary>
                /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(123, 123.23, true, [\"id1\",\"id2\], 2006-01-02 15:04:05])</para>
                /// <para>必填：是</para>
                /// <para>示例值：Sandy</para>
                /// </summary>
                [JsonProperty("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>地点用途</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("location_usage_list")]
        public Enum[]? LocationUsageLists { get; set; }

        /// <summary>
        /// <para>地点用途</para>
        /// </summary>
        public record Enum
        {
            /// <summary>
            /// <para>枚举值</para>
            /// <para>必填：是</para>
            /// <para>示例值：phone_type</para>
            /// </summary>
            [JsonProperty("enum_name")]
            public string EnumName { get; set; } = string.Empty;

            /// <summary>
            /// <para>枚举多语展示</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("display")]
            public I18n[]? Displies { get; set; }

            /// <summary>
            /// <para>枚举多语展示</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>语言</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonProperty("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：刘梓新</para>
                /// </summary>
                [JsonProperty("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>地址</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("address")]
        public Address[]? Addresses { get; set; }

        /// <summary>
        /// <para>地址</para>
        /// </summary>
        public record Address
        {
            /// <summary>
            /// <para>完整地址（本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：中国北京北京</para>
            /// </summary>
            [JsonProperty("full_address_local_script")]
            public string? FullAddressLocalScript { get; set; }

            /// <summary>
            /// <para>完整地址（西方文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：Beijing,Beijing,China,</para>
            /// </summary>
            [JsonProperty("full_address_western_script")]
            public string? FullAddressWesternScript { get; set; }

            /// <summary>
            /// <para>地址ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6989822217869624863</para>
            /// </summary>
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>国家 / 地区</para>
            /// <para>必填：是</para>
            /// <para>示例值：6862995757234914824</para>
            /// </summary>
            [JsonProperty("country_region_id")]
            public string CountryRegionId { get; set; } = string.Empty;

            /// <summary>
            /// <para>主要行政区</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863326815667095047</para>
            /// </summary>
            [JsonProperty("region_id")]
            public string? RegionId { get; set; }

            /// <summary>
            /// <para>城市，该字段已作废，请使用 city_id_v2 字段</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863333254578046471</para>
            /// </summary>
            [JsonProperty("city_id")]
            public string? CityId { get; set; }

            /// <summary>
            /// <para>区/县，该字段已作废，请使用 district_id_v2 字段</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863333516579440141</para>
            /// </summary>
            [JsonProperty("distinct_id")]
            public string? DistinctId { get; set; }

            /// <summary>
            /// <para>地址行 1（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：丹佛测试地址-纽埃时区</para>
            /// </summary>
            [JsonProperty("local_address_line1")]
            public string? LocalAddressLine1 { get; set; }

            /// <summary>
            /// <para>地址行 2（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：PoewH</para>
            /// </summary>
            [JsonProperty("local_address_line2")]
            public string? LocalAddressLine2 { get; set; }

            /// <summary>
            /// <para>地址行 3（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：PoewH</para>
            /// </summary>
            [JsonProperty("local_address_line3")]
            public string? LocalAddressLine3 { get; set; }

            /// <summary>
            /// <para>地址行 4（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：jmwJc</para>
            /// </summary>
            [JsonProperty("local_address_line4")]
            public string? LocalAddressLine4 { get; set; }

            /// <summary>
            /// <para>地址行 5（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：jmwJc</para>
            /// </summary>
            [JsonProperty("local_address_line5")]
            public string? LocalAddressLine5 { get; set; }

            /// <summary>
            /// <para>地址行 6（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：jmwJc</para>
            /// </summary>
            [JsonProperty("local_address_line6")]
            public string? LocalAddressLine6 { get; set; }

            /// <summary>
            /// <para>地址行 7（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：jmwJc</para>
            /// </summary>
            [JsonProperty("local_address_line7")]
            public string? LocalAddressLine7 { get; set; }

            /// <summary>
            /// <para>地址行 8（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：rafSu</para>
            /// </summary>
            [JsonProperty("local_address_line8")]
            public string? LocalAddressLine8 { get; set; }

            /// <summary>
            /// <para>地址行 9（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：McPRG</para>
            /// </summary>
            [JsonProperty("local_address_line9")]
            public string? LocalAddressLine9 { get; set; }

            /// <summary>
            /// <para>邮政编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：611530</para>
            /// </summary>
            [JsonProperty("postal_code")]
            public string? PostalCode { get; set; }

            /// <summary>
            /// <para>地址类型</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("address_type_list")]
            public Enum[]? AddressTypeLists { get; set; }

            /// <summary>
            /// <para>地址类型</para>
            /// </summary>
            public record Enum
            {
                /// <summary>
                /// <para>枚举值</para>
                /// <para>必填：是</para>
                /// <para>示例值：phone_type</para>
                /// </summary>
                [JsonProperty("enum_name")]
                public string EnumName { get; set; } = string.Empty;

                /// <summary>
                /// <para>枚举多语展示</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("display")]
                public I18n[]? Displies { get; set; }

                /// <summary>
                /// <para>枚举多语展示</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>语言</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：zh-CN</para>
                    /// </summary>
                    [JsonProperty("lang")]
                    public string Lang { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：刘梓新</para>
                    /// </summary>
                    [JsonProperty("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>主要地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonProperty("is_primary")]
            public bool? IsPrimary { get; set; }

            /// <summary>
            /// <para>公开地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonProperty("is_public")]
            public bool? IsPublic { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("custom_fields")]
            public ObjectFieldData[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record ObjectFieldData
            {
                /// <summary>
                /// <para>字段名</para>
                /// <para>必填：是</para>
                /// <para>示例值：name</para>
                /// </summary>
                [JsonProperty("field_name")]
                public string FieldName { get; set; } = string.Empty;

                /// <summary>
                /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(123, 123.23, true, [\"id1\",\"id2\], 2006-01-02 15:04:05])</para>
                /// <para>必填：是</para>
                /// <para>示例值：Sandy</para>
                /// </summary>
                [JsonProperty("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>工时制度</para>
        /// <para>必填：否</para>
        /// <para>示例值：4690238309151997779</para>
        /// </summary>
        [JsonProperty("working_hours_type_id")]
        public string? WorkingHoursTypeId { get; set; }

        /// <summary>
        /// <para>生效时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：2020-05-0100:00:00</para>
        /// </summary>
        [JsonProperty("effective_time")]
        public string EffectiveTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>失效时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-05-0200:00:00</para>
        /// </summary>
        [JsonProperty("expiration_time")]
        public string? ExpirationTime { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("custom_fields")]
        public ObjectFieldData[]? CustomFields { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// </summary>
        public record ObjectFieldData
        {
            /// <summary>
            /// <para>字段名</para>
            /// <para>必填：是</para>
            /// <para>示例值：name</para>
            /// </summary>
            [JsonProperty("field_name")]
            public string FieldName { get; set; } = string.Empty;

            /// <summary>
            /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(123, 123.23, true, [\"id1\",\"id2\], 2006-01-02 15:04:05])</para>
            /// <para>必填：是</para>
            /// <para>示例值：Sandy</para>
            /// </summary>
            [JsonProperty("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>区域设置</para>
        /// <para>必填：否</para>
        /// <para>示例值：zh_cn</para>
        /// </summary>
        [JsonProperty("locale")]
        public Enum? Locale { get; set; }

        /// <summary>
        /// <para>时区</para>
        /// <para>必填：否</para>
        /// <para>示例值：123456789</para>
        /// </summary>
        [JsonProperty("time_zone_id")]
        public string? TimeZoneId { get; set; }

        /// <summary>
        /// <para>默认显示语言</para>
        /// <para>必填：否</para>
        /// <para>示例值：123456789</para>
        /// </summary>
        [JsonProperty("display_language_id")]
        public string? DisplayLanguageId { get; set; }
    }
}
