// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-10-08
// ************************************************************************
// <copyright file="GetCorehrV1LocationsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量分页查询地点信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 批量分页查询地点信息 响应体
/// <para>该接口用于批量查询地点信息，信息包含地点名称、描述、地点用途、工时制度、区域设置、时区以及关联的地址信息等。</para>
/// <para>接口ID：7017707615190990851</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/location/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2flocation%2flist</para>
/// </summary>
public record GetCorehrV1LocationsResponseDto : IPageableResponse<GetCorehrV1LocationsResponseDto.Location>
{
    /// <summary>
    /// <para>查询的地点信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Location[]? Items { get; set; }

    /// <summary>
    /// <para>查询的地点信息</para>
    /// </summary>
    public record Location
    {
        /// <summary>
        /// <para>地点维护管理员在 飞书人事系统，组织管理模块维护的地点记录 ID。</para>
        /// <para>必填：否</para>
        /// <para>示例值：4718803945687580505</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>地点基本信息，该结构维护了地点的名称、编码、启用状态、上级地点 等基础信息。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("hiberarchy_common")]
        public LocationHiberarchyCommon HiberarchyCommon { get; set; } = new();

        /// <summary>
        /// <para>地点基本信息，该结构维护了地点的名称、编码、启用状态、上级地点 等基础信息。</para>
        /// </summary>
        public record LocationHiberarchyCommon
        {
            /// <summary>
            /// <para>上级地点，在创建场景下， 该字段必填，枚举值及详细信息可通过[【查询地点列表】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)接口查询获得</para>
            /// <para>必填：否</para>
            /// <para>示例值：4719168654814483759</para>
            /// </summary>
            [JsonPropertyName("parent_id")]
            public string? ParentId { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n[] Names { get; set; } = Array.Empty<I18n>();

            /// <summary>
            /// <para>名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>语言</para>
                /// <para>- 中文用zh-CN，英文用en-US。</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：刘梓新</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>组织类型</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("type")]
            public Enum? Type { get; set; }

            /// <summary>
            /// <para>组织类型</para>
            /// </summary>
            public record Enum
            {
                /// <summary>
                /// <para>组织类型，默认值为 location， 枚举值及详细信息可通过[【批量查询枚举类型】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)接口查询获得</para>
                /// <para>必填：是</para>
                /// <para>示例值：location</para>
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
                    /// <para>语言</para>
                    /// <para>- 中文用zh-CN，英文用en-US。</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：zh-CN</para>
                    /// </summary>
                    [JsonPropertyName("lang")]
                    public string Lang { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：地点</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>启用状态，true为启用，fasle为停用</para>
            /// <para>必填：是</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("active")]
            public bool Active { get; set; }

            /// <summary>
            /// <para>当前版本生效日期</para>
            /// <para>- 返回格式：YYYY-MM-DD 00:00:00（最小单位到日）</para>
            /// <para>- 日期范围:1900-01-01 00:00:00～9999-12-31 00:00:00</para>
            /// <para>- 详情可以参考[时间轴介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/about-timeline-version)</para>
            /// <para>- 该字段和data.effective_time字段一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-05-01 00:00:00</para>
            /// </summary>
            [JsonPropertyName("effective_time")]
            public string? EffectiveTime { get; set; }

            /// <summary>
            /// <para>当前版本失效日期</para>
            /// <para>- 返回格式：YYYY-MM-DD 00:00:00（最小单位到日）</para>
            /// <para>- 日期范围:1900-01-01 00:00:00～9999-12-31 00:00:00</para>
            /// <para>- 系统默认为失效日期当天的 00:00:00 失效</para>
            /// <para>- 详情可以参考[时间轴介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/about-timeline-version)</para>
            /// <para>- 该字段和data.expiration_time字段一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-05-02 00:00:00</para>
            /// </summary>
            [JsonPropertyName("expiration_time")]
            public string? ExpirationTime { get; set; }

            /// <summary>
            /// <para>编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：12456</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>描述</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("description")]
            public I18n[]? Descriptions { get; set; }

            /// <summary>
            /// <para>自定义字段（该字段暂不支持，可忽略）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public ObjectFieldData[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段（该字段暂不支持，可忽略）</para>
            /// </summary>
            public record ObjectFieldData
            {
                /// <summary>
                /// <para>字段名</para>
                /// <para>必填：是</para>
                /// <para>示例值：name</para>
                /// </summary>
                [JsonPropertyName("field_name")]
                public string FieldName { get; set; } = string.Empty;

                /// <summary>
                /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同。如：```("\"123\"", "\"123.23\"", "\"true\"", [\"id1\",\"id2\"], \"2006-01-02 15:04:05\")```</para>
                /// <para>必填：是</para>
                /// <para>示例值：\"Sandy\"</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>地点用途</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("location_usage_list")]
        public Enum[]? LocationUsageLists { get; set; }

        /// <summary>
        /// <para>地点用途</para>
        /// </summary>
        public record Enum
        {
            /// <summary>
            /// <para>地点用途 ID，枚举值及详细信息可通过[【批量查询地点用途】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询获得。</para>
            /// <para>- 请求参数object_api_name=location；custom_api_name=location_usage</para>
            /// <para>必填：是</para>
            /// <para>示例值：work_location</para>
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
                /// <para>语言</para>
                /// <para>- 中文用zh-CN，英文用en-US。</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：工作地点</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>地址</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("address")]
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
            [JsonPropertyName("full_address_local_script")]
            public string? FullAddressLocalScript { get; set; }

            /// <summary>
            /// <para>完整地址（西方文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：Beijing, Beijing, China,</para>
            /// </summary>
            [JsonPropertyName("full_address_western_script")]
            public string? FullAddressWesternScript { get; set; }

            /// <summary>
            /// <para>地址ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6989822217869624863</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>国家 / 地区 ID</para>
            /// <para>可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口获取</para>
            /// <para>必填：是</para>
            /// <para>示例值：6862995757234914824</para>
            /// </summary>
            [JsonPropertyName("country_region_id")]
            public string CountryRegionId { get; set; } = string.Empty;

            /// <summary>
            /// <para>主要行政区 ID</para>
            /// <para>可通过[【查询省份/行政区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863326815667095047</para>
            /// </summary>
            [JsonPropertyName("region_id")]
            public string? RegionId { get; set; }

            /// <summary>
            /// <para>城市ID。</para>
            /// <para>- 详情调用[【查询区县信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-district/search)获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863333254578046471</para>
            /// </summary>
            [JsonPropertyName("city_id")]
            public string? CityId { get; set; }

            /// <summary>
            /// <para>区/县ID</para>
            /// <para>- 详情可通过[【查询区县信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-district/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863333516579440141</para>
            /// </summary>
            [JsonPropertyName("distinct_id")]
            public string? DistinctId { get; set; }

            /// <summary>
            /// <para>地址行 1</para>
            /// <para>必填：否</para>
            /// <para>示例值：丹佛测试地址-纽埃时区</para>
            /// </summary>
            [JsonPropertyName("address_line1")]
            public string? AddressLine1 { get; set; }

            /// <summary>
            /// <para>地址行 2</para>
            /// <para>必填：否</para>
            /// <para>示例值：PoewH</para>
            /// </summary>
            [JsonPropertyName("address_line2")]
            public string? AddressLine2 { get; set; }

            /// <summary>
            /// <para>地址行 3</para>
            /// <para>必填：否</para>
            /// <para>示例值：PoewH</para>
            /// </summary>
            [JsonPropertyName("address_line3")]
            public string? AddressLine3 { get; set; }

            /// <summary>
            /// <para>地址行 4</para>
            /// <para>必填：否</para>
            /// <para>示例值：jmwJc</para>
            /// </summary>
            [JsonPropertyName("address_line4")]
            public string? AddressLine4 { get; set; }

            /// <summary>
            /// <para>地址行 5</para>
            /// <para>必填：否</para>
            /// <para>示例值：jmwJc</para>
            /// </summary>
            [JsonPropertyName("address_line5")]
            public string? AddressLine5 { get; set; }

            /// <summary>
            /// <para>地址行 6</para>
            /// <para>必填：否</para>
            /// <para>示例值：jmwJc</para>
            /// </summary>
            [JsonPropertyName("address_line6")]
            public string? AddressLine6 { get; set; }

            /// <summary>
            /// <para>地址行 7</para>
            /// <para>必填：否</para>
            /// <para>示例值：jmwJc</para>
            /// </summary>
            [JsonPropertyName("address_line7")]
            public string? AddressLine7 { get; set; }

            /// <summary>
            /// <para>地址行 8</para>
            /// <para>必填：否</para>
            /// <para>示例值：rafSu</para>
            /// </summary>
            [JsonPropertyName("address_line8")]
            public string? AddressLine8 { get; set; }

            /// <summary>
            /// <para>地址行 9</para>
            /// <para>必填：否</para>
            /// <para>示例值：McPRG</para>
            /// </summary>
            [JsonPropertyName("address_line9")]
            public string? AddressLine9 { get; set; }

            /// <summary>
            /// <para>地址行 1（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：丹佛测试地址-纽埃时区</para>
            /// </summary>
            [JsonPropertyName("local_address_line1")]
            public string? LocalAddressLine1 { get; set; }

            /// <summary>
            /// <para>地址行 2（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：New York</para>
            /// </summary>
            [JsonPropertyName("local_address_line2")]
            public string? LocalAddressLine2 { get; set; }

            /// <summary>
            /// <para>地址行 3（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：New York</para>
            /// </summary>
            [JsonPropertyName("local_address_line3")]
            public string? LocalAddressLine3 { get; set; }

            /// <summary>
            /// <para>地址行 4（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：New York</para>
            /// </summary>
            [JsonPropertyName("local_address_line4")]
            public string? LocalAddressLine4 { get; set; }

            /// <summary>
            /// <para>地址行 5（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：New York</para>
            /// </summary>
            [JsonPropertyName("local_address_line5")]
            public string? LocalAddressLine5 { get; set; }

            /// <summary>
            /// <para>地址行 6（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：New York</para>
            /// </summary>
            [JsonPropertyName("local_address_line6")]
            public string? LocalAddressLine6 { get; set; }

            /// <summary>
            /// <para>地址行 7（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：New York</para>
            /// </summary>
            [JsonPropertyName("local_address_line7")]
            public string? LocalAddressLine7 { get; set; }

            /// <summary>
            /// <para>地址行 8（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：New York</para>
            /// </summary>
            [JsonPropertyName("local_address_line8")]
            public string? LocalAddressLine8 { get; set; }

            /// <summary>
            /// <para>地址行 9（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：New York</para>
            /// </summary>
            [JsonPropertyName("local_address_line9")]
            public string? LocalAddressLine9 { get; set; }

            /// <summary>
            /// <para>邮政编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：611530</para>
            /// </summary>
            [JsonPropertyName("postal_code")]
            public string? PostalCode { get; set; }

            /// <summary>
            /// <para>地址类型</para>
            /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name = "address"</para>
            /// <para>- custom_api_name = "address_type"</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("address_type_list")]
            public Enum[]? AddressTypeLists { get; set; }

            /// <summary>
            /// <para>地址类型</para>
            /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name = "address"</para>
            /// <para>- custom_api_name = "address_type"</para>
            /// </summary>
            public record Enum
            {
                /// <summary>
                /// <para>枚举值</para>
                /// <para>必填：是</para>
                /// <para>示例值：onboarding_address</para>
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
                    /// <para>语言</para>
                    /// <para>- 中文用zh-CN，英文用en-US。</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：zh-CN</para>
                    /// </summary>
                    [JsonPropertyName("lang")]
                    public string Lang { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：入职地址</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>主要地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_primary")]
            public bool? IsPrimary { get; set; }

            /// <summary>
            /// <para>公开地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_public")]
            public bool? IsPublic { get; set; }

            /// <summary>
            /// <para>自定义字段（该字段暂不支持，可忽略）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public ObjectFieldData[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段（该字段暂不支持，可忽略）</para>
            /// </summary>
            public record ObjectFieldData
            {
                /// <summary>
                /// <para>字段名</para>
                /// <para>必填：是</para>
                /// <para>示例值：name</para>
                /// </summary>
                [JsonPropertyName("field_name")]
                public string FieldName { get; set; } = string.Empty;

                /// <summary>
                /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同。如：```("\"123\"", "\"123.23\"", "\"true\"", [\"id1\",\"id2\"], \"2006-01-02 15:04:05\")```</para>
                /// <para>必填：是</para>
                /// <para>示例值：\"Sandy\"</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>工时制度 ID，枚举值及详细信息可通过[【批量查询工时制度】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/list)接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：4690238309151997779</para>
        /// </summary>
        [JsonPropertyName("working_hours_type_id")]
        public string? WorkingHoursTypeId { get; set; }

        /// <summary>
        /// <para>当前版本生效日期</para>
        /// <para>- 返回格式：YYYY-MM-DD 00:00:00（最小单位到日）</para>
        /// <para>- 日期范围:1900-01-01 00:00:00～9999-12-31 00:00:00</para>
        /// <para>- 详情可以参考[时间轴介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/about-timeline-version)</para>
        /// <para>- 该字段和data.hiberarchy_common.effective_time字段一致</para>
        /// <para>必填：是</para>
        /// <para>示例值：2020-05-01 00:00:00</para>
        /// </summary>
        [JsonPropertyName("effective_time")]
        public string EffectiveTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>当前版本失效日期</para>
        /// <para>- 返回格式：YYYY-MM-DD 00:00:00（最小单位到日）</para>
        /// <para>- 日期范围:1900-01-01 00:00:00～9999-12-31 00:00:00</para>
        /// <para>- 系统默认为失效日期当天的 00:00:00 失效</para>
        /// <para>- 详情可以参考[时间轴介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/about-timeline-version)</para>
        /// <para>- 该字段和data. hiberarchy_common.expiration_time字段一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-05-02 00:00:00</para>
        /// </summary>
        [JsonPropertyName("expiration_time")]
        public string? ExpirationTime { get; set; }

        /// <summary>
        /// <para>自定义字段（该字段暂不支持，可忽略）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public ObjectFieldData[]? CustomFields { get; set; }

        /// <summary>
        /// <para>自定义字段（该字段暂不支持，可忽略）</para>
        /// </summary>
        public record ObjectFieldData
        {
            /// <summary>
            /// <para>字段名</para>
            /// <para>必填：是</para>
            /// <para>示例值：name</para>
            /// </summary>
            [JsonPropertyName("field_name")]
            public string FieldName { get; set; } = string.Empty;

            /// <summary>
            /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同。如：```("\"123\"", "\"123.23\"", "\"true\"", [\"id1\",\"id2\"], \"2006-01-02 15:04:05\")```</para>
            /// <para>必填：是</para>
            /// <para>示例值：\"Sandy\"</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>区域设置ID ，枚举值及详细信息可通过[【批量查询枚举信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询获得。</para>
        /// <para>- 请求参数object_api_name=location；custom_api_name=locale</para>
        /// <para>必填：否</para>
        /// <para>示例值：zh_cn</para>
        /// </summary>
        [JsonPropertyName("locale")]
        public Enum? Locale { get; set; }

        /// <summary>
        /// <para>时区</para>
        /// <para>必填：否</para>
        /// <para>示例值：123456789</para>
        /// </summary>
        [JsonPropertyName("time_zone_id")]
        public string? TimeZoneId { get; set; }

        /// <summary>
        /// <para>默认显示语言</para>
        /// <para>必填：否</para>
        /// <para>示例值：123456789</para>
        /// </summary>
        [JsonPropertyName("display_language_id")]
        public string? DisplayLanguageId { get; set; }
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
    /// <para>示例值：7094095584361137709</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
