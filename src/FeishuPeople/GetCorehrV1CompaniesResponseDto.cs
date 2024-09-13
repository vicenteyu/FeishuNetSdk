// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-12
// ************************************************************************
// <copyright file="GetCorehrV1CompaniesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询公司 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 批量查询公司 响应体
/// <para>分页查询公司，可分页遍历全量公司数据。</para>
/// <para>接口ID：7017707615191105539</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/company/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcompany%2flist</para>
/// </summary>
public record GetCorehrV1CompaniesResponseDto
{
    /// <summary>
    /// <para>查询的公司信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Company[]? Items { get; set; }

    /// <summary>
    /// <para>查询的公司信息</para>
    /// </summary>
    public record Company
    {
        /// <summary>
        /// <para>公司 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：4692472714243080020</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>公司基本信息，该结构维护了公司的名称、编码、启用状态、上级公司等基础信息。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("hiberarchy_common")]
        public CompanyHiberarchyCommon HiberarchyCommon { get; set; } = new();

        /// <summary>
        /// <para>公司基本信息，该结构维护了公司的名称、编码、启用状态、上级公司等基础信息。</para>
        /// </summary>
        public record CompanyHiberarchyCommon
        {
            /// <summary>
            /// <para>上级 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：4719168654814483759</para>
            /// </summary>
            [JsonPropertyName("parent_id")]
            public string? ParentId { get; set; }

            /// <summary>
            /// <para>公司名称</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n[] Names { get; set; } = Array.Empty<I18n>();

            /// <summary>
            /// <para>公司名称</para>
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
            /// <para>组织类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)组织类型（organization_type）枚举定义部分获得</para>
            /// <para>- 该接口固定返回常量值：company</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("type")]
            public Enum? Type { get; set; }

            /// <summary>
            /// <para>组织类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)组织类型（organization_type）枚举定义部分获得</para>
            /// <para>- 该接口固定返回常量值：company</para>
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

            /// <summary>
            /// <para>是否启用</para>
            /// <para>必填：是</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("active")]
            public bool Active { get; set; }

            /// <summary>
            /// <para>当前版本生效日期</para>
            /// <para>- 返回格式：YYYY-MM-DD 00:00:00（最小单位到日）</para>
            /// <para>- 日期范围:1900-01-01 00:00:00～9999-12-31 23:59:59</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-05-01 00:00:00</para>
            /// </summary>
            [JsonPropertyName("effective_time")]
            public string? EffectiveTime { get; set; }

            /// <summary>
            /// <para>当前版本失效日期</para>
            /// <para>- 返回格式：YYYY-MM-DD 00:00:00（最小单位到日）</para>
            /// <para>- 日期范围:1900-01-01 00:00:00～9999-12-31 23:59:59</para>
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
            /// <para>树形排序（该功能暂不支持，可忽略）</para>
            /// <para>必填：否</para>
            /// <para>示例值：001000</para>
            /// </summary>
            [JsonPropertyName("tree_order")]
            public string? TreeOrder { get; set; }

            /// <summary>
            /// <para>列表排序（该功能暂不支持，可忽略）</para>
            /// <para>必填：否</para>
            /// <para>示例值：001000-001000</para>
            /// </summary>
            [JsonPropertyName("list_order")]
            public string? ListOrder { get; set; }

            /// <summary>
            /// <para>自定义字段（该功能暂不支持，可忽略）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public ObjectFieldData[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段（该功能暂不支持，可忽略）</para>
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
                /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(如123, 123.23, "true", [\"id1\",\"id2\"], "2006-01-02 15:04:05")</para>
                /// <para>必填：是</para>
                /// <para>示例值：\"Sandy\"</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>公司性质，通过[获取字段详情](https://open.larkoffice.com/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)查询获取。请求参数：object_api_name=company；custom_api_name=type。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("type")]
        public Enum? Type { get; set; }

        /// <summary>
        /// <para>公司性质，通过[获取字段详情](https://open.larkoffice.com/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)查询获取。请求参数：object_api_name=company；custom_api_name=type。</para>
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

        /// <summary>
        /// <para>所在行业，通过[获取字段详情](https://open.larkoffice.com/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)查询获取。请求参数：object_api_name=company；custom_api_name=industry。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("industry_list")]
        public Enum[]? IndustryLists { get; set; }

        /// <summary>
        /// <para>法定代表人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("legal_representative")]
        public I18n[]? LegalRepresentatives { get; set; }

        /// <summary>
        /// <para>法定代表人</para>
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
        /// <para>邮编</para>
        /// <para>必填：否</para>
        /// <para>示例值：邮编</para>
        /// </summary>
        [JsonPropertyName("post_code")]
        public string? PostCode { get; set; }

        /// <summary>
        /// <para>纳税人识别号</para>
        /// <para>必填：否</para>
        /// <para>示例值：123456840</para>
        /// </summary>
        [JsonPropertyName("tax_payer_id")]
        public string? TaxPayerId { get; set; }

        /// <summary>
        /// <para>是否保密（该功能暂不支持，可忽略）</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("confidential")]
        public bool? Confidential { get; set; }

        /// <summary>
        /// <para>公司主体类型，通过[获取字段详情](https://open.larkoffice.com/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)查询获取。请求参数：object_api_name=company；custom_api_name=subtype。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sub_type_list")]
        public Enum[]? SubTypeLists { get; set; }

        /// <summary>
        /// <para>是否为分公司</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("branch_company")]
        public bool? BranchCompany { get; set; }

        /// <summary>
        /// <para>主要负责人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("primary_manager")]
        public I18n[]? PrimaryManagers { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
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
            [JsonPropertyName("field_name")]
            public string FieldName { get; set; } = string.Empty;

            /// <summary>
            /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(如123, 123.23, "true", [\"id1\",\"id2\"], "2006-01-02 15:04:05")</para>
            /// <para>必填：是</para>
            /// <para>示例值：\"Sandy\"</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>默认币种</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("currency")]
        public CompanyCurrency? Currency { get; set; }

        /// <summary>
        /// <para>默认币种</para>
        /// </summary>
        public record CompanyCurrency
        {
            /// <summary>
            /// <para>货币id</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>货币所属国家/地区id，详细信息可通过[【查询国家/地区信息】](https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/location_data/list)接口查询获得</para>
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
                /// <para>语言</para>
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
            /// <para>对应币种的指代代码，通过[查询货币信息v2](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-currency/search)查询获取。</para>
            /// <para>必填：否</para>
            /// <para>示例值：12</para>
            /// </summary>
            [JsonPropertyName("numeric_code")]
            public int? NumericCode { get; set; }

            /// <summary>
            /// <para>法定货币对应代码，如CNY、USD等，通过[查询货币信息v2](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-currency/search)查询获取。</para>
            /// <para>必填：否</para>
            /// <para>示例值：12</para>
            /// </summary>
            [JsonPropertyName("currency_alpha_3_code")]
            public string? CurrencyAlpha3Code { get; set; }
        }

        /// <summary>
        /// <para>电话</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("phone")]
        public PhoneNumberAndAreaCode? Phone { get; set; }

        /// <summary>
        /// <para>电话</para>
        /// </summary>
        public record PhoneNumberAndAreaCode
        {
            /// <summary>
            /// <para>区号对应的数字，可通过</para>
            /// <para>[获取字段详情](https://open.larkoffice.com/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)查询获取。请求参数：object_api_name=phone；custom_api_name=international_area_code</para>
            /// <para>必填：是</para>
            /// <para>示例值：123123</para>
            /// </summary>
            [JsonPropertyName("area_code")]
            public Enum AreaCode { get; set; } = new();

            /// <summary>
            /// <para>区号对应的数字，可通过</para>
            /// <para>[获取字段详情](https://open.larkoffice.com/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)查询获取。请求参数：object_api_name=phone；custom_api_name=international_area_code</para>
            /// </summary>
            public record Enum
            {
                /// <summary>
                /// <para>枚举值</para>
                /// <para>必填：是</para>
                /// <para>示例值：phone_type</para>
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
            }

            /// <summary>
            /// <para>号码</para>
            /// <para>必填：是</para>
            /// <para>示例值：213213</para>
            /// </summary>
            [JsonPropertyName("phone_number")]
            public string PhoneNumber { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>传真</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("fax")]
        public PhoneNumberAndAreaCode? Fax { get; set; }

        /// <summary>
        /// <para>完整注册地址</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("registered_office_address")]
        public I18n[]? RegisteredOfficeAddress { get; set; }

        /// <summary>
        /// <para>完整办公地址</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("office_address")]
        public I18n[]? OfficeAddress { get; set; }

        /// <summary>
        /// <para>注册地址详细信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("registered_office_address_info")]
        public Address? RegisteredOfficeAddressInfo { get; set; }

        /// <summary>
        /// <para>注册地址详细信息</para>
        /// </summary>
        public record Address
        {
            /// <summary>
            /// <para>国家 / 地区id。各国家/地区填写字段可参考[地址填写规则](https://bytedance.larkoffice.com/wiki/GoL4wAKAXis3OWku72YcEjTxnKe?sheet=0sMjoP)查询。</para>
            /// <para>国家/地区id可通过[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)查询获取。</para>
            /// <para>必填：是</para>
            /// <para>示例值：6862995757234914824</para>
            /// </summary>
            [JsonPropertyName("country_region_id")]
            public string CountryRegionId { get; set; } = string.Empty;

            /// <summary>
            /// <para>主要行政区id。</para>
            /// <para>可通过</para>
            /// <para>[查询省份/主要行政区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)查询获取。</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863326815667095047</para>
            /// </summary>
            [JsonPropertyName("region_id")]
            public string? RegionId { get; set; }

            /// <summary>
            /// <para>城市id，可通过</para>
            /// <para>[查询城市信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-city/search)查询获取。</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863333254578046471</para>
            /// </summary>
            [JsonPropertyName("city_id")]
            public string? CityId { get; set; }

            /// <summary>
            /// <para>区/县id，可通过</para>
            /// <para>[查询区/县信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-district/search)查询获取。</para>
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
            /// <para>示例值：PoewH</para>
            /// </summary>
            [JsonPropertyName("local_address_line2")]
            public string? LocalAddressLine2 { get; set; }

            /// <summary>
            /// <para>地址行 3（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：PoewH</para>
            /// </summary>
            [JsonPropertyName("local_address_line3")]
            public string? LocalAddressLine3 { get; set; }

            /// <summary>
            /// <para>地址行 4（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：jmwJc</para>
            /// </summary>
            [JsonPropertyName("local_address_line4")]
            public string? LocalAddressLine4 { get; set; }

            /// <summary>
            /// <para>地址行 5（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：jmwJc</para>
            /// </summary>
            [JsonPropertyName("local_address_line5")]
            public string? LocalAddressLine5 { get; set; }

            /// <summary>
            /// <para>地址行 6（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：jmwJc</para>
            /// </summary>
            [JsonPropertyName("local_address_line6")]
            public string? LocalAddressLine6 { get; set; }

            /// <summary>
            /// <para>地址行 7（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：jmwJc</para>
            /// </summary>
            [JsonPropertyName("local_address_line7")]
            public string? LocalAddressLine7 { get; set; }

            /// <summary>
            /// <para>地址行 8（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：rafSu</para>
            /// </summary>
            [JsonPropertyName("local_address_line8")]
            public string? LocalAddressLine8 { get; set; }

            /// <summary>
            /// <para>地址行 9（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：McPRG</para>
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
        }

        /// <summary>
        /// <para>办公地址详细信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("office_address_info")]
        public Address? OfficeAddressInfo { get; set; }
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
