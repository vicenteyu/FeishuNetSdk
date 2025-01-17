// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-18
//
// Last Modified By : yxr
// Last Modified On : 2025-01-17
// ************************************************************************
// <copyright file="PostCorehrV2PreHiresQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询待入职信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询待入职信息 响应体
/// <para>该接口用于根据待入职人员 ID(支持批量)查询待入职人员信息，信息包含姓名、手机号等个人信息和任职信息。</para>
/// <para>- 延迟说明：数据库主从延迟 2s 以内，即：直接创建待入职后2s内调用此接口可能查询不到数据。</para>
/// <para>- 性能说明：本接口返回数据量较多，查询时请控制每批次数量（&lt;10）和适当减少查询字段数(&lt;50)</para>
/// <para>接口ID：7386487948991299587</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fquery</para>
/// </summary>
public record PostCorehrV2PreHiresQueryResponseDto
{
    /// <summary>
    /// <para>查询待入职的信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public PreHire[]? Items { get; set; }

    /// <summary>
    /// <para>查询待入职的信息</para>
    /// </summary>
    public record PreHire
    {
        /// <summary>
        /// <para>个人信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("person_info")]
        public PreHirePersonInfo? PersonInfo { get; set; }

        /// <summary>
        /// <para>个人信息</para>
        /// </summary>
        public record PreHirePersonInfo
        {
            /// <summary>
            /// <para>个人信息 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6919733936050406926</para>
            /// </summary>
            [JsonPropertyName("person_id")]
            public string? PersonId { get; set; }

            /// <summary>
            /// <para>个人电话</para>
            /// <para>必填：否</para>
            /// <para>示例值：13649211111</para>
            /// </summary>
            [JsonPropertyName("phone_number")]
            public string? PhoneNumber { get; set; }

            /// <summary>
            /// <para>法定姓名</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("legal_name")]
            public string? LegalName { get; set; }

            /// <summary>
            /// <para>常用名</para>
            /// <para>必填：否</para>
            /// <para>示例值：刘梓新(Henry)</para>
            /// </summary>
            [JsonPropertyName("preferred_name")]
            public string? PreferredName { get; set; }

            /// <summary>
            /// <para>常用本地全名</para>
            /// <para>必填：否</para>
            /// <para>示例值：刘梓新</para>
            /// </summary>
            [JsonPropertyName("preferred_local_full_name")]
            public string? PreferredLocalFullName { get; set; }

            /// <summary>
            /// <para>常用英文全名</para>
            /// <para>必填：否</para>
            /// <para>示例值：Henry</para>
            /// </summary>
            [JsonPropertyName("preferred_english_full_name")]
            public string? PreferredEnglishFullName { get; set; }

            /// <summary>
            /// <para>姓名列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name_list")]
            public PersonName[]? NameLists { get; set; }

            /// <summary>
            /// <para>姓名列表</para>
            /// </summary>
            public record PersonName
            {
                /// <summary>
                /// <para>姓 - 本地文字</para>
                /// <para>必填：否</para>
                /// <para>示例值：黄</para>
                /// </summary>
                [JsonPropertyName("local_primary")]
                public string? LocalPrimary { get; set; }

                /// <summary>
                /// <para>名 - 本地文字</para>
                /// <para>必填：否</para>
                /// <para>示例值：四</para>
                /// </summary>
                [JsonPropertyName("local_first_name")]
                public string? LocalFirstName { get; set; }

                /// <summary>
                /// <para>国家 / 地区，可以通过接口[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取详情</para>
                /// <para>必填：是</para>
                /// <para>示例值：6862995757234914824</para>
                /// </summary>
                [JsonPropertyName("country_region_id")]
                public string CountryRegionId { get; set; } = string.Empty;

                /// <summary>
                /// <para>姓名类型，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)姓名类型（name_type）枚举定义获得</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("name_type")]
                public Enum NameType { get; set; } = new();

                /// <summary>
                /// <para>姓名类型，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)姓名类型（name_type）枚举定义获得</para>
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
                }

                /// <summary>
                /// <para>名 - 第二本地文字</para>
                /// <para>必填：否</para>
                /// <para>示例值：五</para>
                /// </summary>
                [JsonPropertyName("local_first_name_2")]
                public string? LocalFirstName2 { get; set; }

                /// <summary>
                /// <para>姓 - 第二本地文字</para>
                /// <para>必填：否</para>
                /// <para>示例值：王</para>
                /// </summary>
                [JsonPropertyName("local_primary_2")]
                public string? LocalPrimary2 { get; set; }

                /// <summary>
                /// <para>别名</para>
                /// <para>必填：否</para>
                /// <para>示例值：别名</para>
                /// </summary>
                [JsonPropertyName("additional_name")]
                public string? AdditionalName { get; set; }

                /// <summary>
                /// <para>补充姓名类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
                /// <para>- custom_api_name：additional_name_type</para>
                /// <para>- object_api_name：person_name</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("additional_name_type")]
                public Enum? AdditionalNameType { get; set; }

                /// <summary>
                /// <para>名</para>
                /// <para>必填：否</para>
                /// <para>示例值：帅</para>
                /// </summary>
                [JsonPropertyName("first_name")]
                public string? FirstName { get; set; }

                /// <summary>
                /// <para>全名</para>
                /// <para>必填：否</para>
                /// <para>示例值：王大帅</para>
                /// </summary>
                [JsonPropertyName("full_name")]
                public string? FullName { get; set; }

                /// <summary>
                /// <para>姓氏称谓</para>
                /// <para>必填：否</para>
                /// <para>示例值：王</para>
                /// </summary>
                [JsonPropertyName("hereditary")]
                public string? Hereditary { get; set; }

                /// <summary>
                /// <para>自定义姓名（未传入时，姓名将默认根据所属国家 / 地区规则对相关姓、名字段拼接）</para>
                /// <para>必填：否</para>
                /// <para>示例值：王大帅</para>
                /// </summary>
                [JsonPropertyName("custom_name")]
                public string? CustomName { get; set; }

                /// <summary>
                /// <para>本地文字的自定义姓名（未传入时，本地文字的姓名将默认根据所属国家 / 地区规则对本地文字的相关姓、名字段拼接）</para>
                /// <para>必填：否</para>
                /// <para>示例值：王大帅</para>
                /// </summary>
                [JsonPropertyName("custom_local_name")]
                public string? CustomLocalName { get; set; }

                /// <summary>
                /// <para>中间名</para>
                /// <para>必填：否</para>
                /// <para>示例值：大</para>
                /// </summary>
                [JsonPropertyName("middle_name")]
                public string? MiddleName { get; set; }

                /// <summary>
                /// <para>姓</para>
                /// <para>必填：否</para>
                /// <para>示例值：王</para>
                /// </summary>
                [JsonPropertyName("name_primary")]
                public string? NamePrimary { get; set; }

                /// <summary>
                /// <para>第二姓氏</para>
                /// <para>必填：否</para>
                /// <para>示例值：王</para>
                /// </summary>
                [JsonPropertyName("secondary")]
                public string? Secondary { get; set; }

                /// <summary>
                /// <para>婚后姓氏</para>
                /// <para>必填：否</para>
                /// <para>示例值：王</para>
                /// </summary>
                [JsonPropertyName("tertiary")]
                public string? Tertiary { get; set; }

                /// <summary>
                /// <para>尊称，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
                /// <para>- custom_api_name：social</para>
                /// <para>- object_api_name：person_name</para>
                /// <para>必填：否</para>
                /// <para>示例值：王大帅</para>
                /// </summary>
                [JsonPropertyName("social")]
                public Enum? Social { get; set; }

                /// <summary>
                /// <para>头衔，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
                /// <para>- custom_api_name：title</para>
                /// <para>- object_api_name：person_name</para>
                /// <para>必填：否</para>
                /// <para>示例值：王</para>
                /// </summary>
                [JsonPropertyName("title")]
                public Enum? Title { get; set; }

                /// <summary>
                /// <para>本地中间名</para>
                /// <para>必填：否</para>
                /// <para>示例值：大</para>
                /// </summary>
                [JsonPropertyName("local_middle_name")]
                public string? LocalMiddleName { get; set; }

                /// <summary>
                /// <para>第二姓氏 - 本地文字</para>
                /// <para>必填：否</para>
                /// <para>示例值：王</para>
                /// </summary>
                [JsonPropertyName("local_secondary")]
                public string? LocalSecondary { get; set; }

                /// <summary>
                /// <para>展示姓名（本地和西方文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：王大帅</para>
                /// </summary>
                [JsonPropertyName("display_name_local_and_western_script")]
                public string? DisplayNameLocalAndWesternScript { get; set; }

                /// <summary>
                /// <para>展示姓名（本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：王大帅</para>
                /// </summary>
                [JsonPropertyName("display_name_local_script")]
                public string? DisplayNameLocalScript { get; set; }

                /// <summary>
                /// <para>展示姓名（西方文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：王大帅</para>
                /// </summary>
                [JsonPropertyName("display_name_western_script")]
                public string? DisplayNameWesternScript { get; set; }
            }

            /// <summary>
            /// <para>性别，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)性别（gendar）枚举定义获得</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("gender")]
            public Enum? Gender { get; set; }

            /// <summary>
            /// <para>性别，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)性别（gendar）枚举定义获得</para>
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
            }

            /// <summary>
            /// <para>出生日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-01-01</para>
            /// </summary>
            [JsonPropertyName("date_of_birth")]
            public string? DateOfBirth { get; set; }

            /// <summary>
            /// <para>国籍，可以通过[查询国籍信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-nationality/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6862995757234914821</para>
            /// </summary>
            [JsonPropertyName("nationality_id_v2")]
            public string? NationalityIdV2 { get; set; }

            /// <summary>
            /// <para>民族，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)民族（race）枚举定义获得</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("race")]
            public Enum? Race { get; set; }

            /// <summary>
            /// <para>婚姻状况，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)婚姻状况（marital_status）枚举定义获得</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("marital_status")]
            public Enum? MaritalStatus { get; set; }

            /// <summary>
            /// <para>电话列表，只有当满足下面所有条件时，电话在个人信息页才可见</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("phone_list")]
            public Phone[]? PhoneLists { get; set; }

            /// <summary>
            /// <para>电话列表，只有当满足下面所有条件时，电话在个人信息页才可见</para>
            /// </summary>
            public record Phone
            {
                /// <summary>
                /// <para>国家区号，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)手机区号（international_area_code）枚举定义获得</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("international_area_code")]
                public Enum? InternationalAreaCode { get; set; }

                /// <summary>
                /// <para>国家区号，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)手机区号（international_area_code）枚举定义获得</para>
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
                }

                /// <summary>
                /// <para>电话号码</para>
                /// <para>必填：是</para>
                /// <para>示例值：010-12345678</para>
                /// </summary>
                [JsonPropertyName("phone_number")]
                public string PhoneNumber { get; set; } = string.Empty;

                /// <summary>
                /// <para>完整电话号码</para>
                /// <para>必填：否</para>
                /// <para>示例值：+86 010-12345678</para>
                /// </summary>
                [JsonPropertyName("formatted_phone_number")]
                public string? FormattedPhoneNumber { get; set; }

                /// <summary>
                /// <para>设备类型，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)设备类型（device_type）枚举定义获得</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("device_type")]
                public Enum? DeviceType { get; set; }

                /// <summary>
                /// <para>电话用途，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)电话用途（phone_usage）枚举定义获得</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("phone_usage")]
                public Enum? PhoneUsage { get; set; }

                /// <summary>
                /// <para>主要电话</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_primary")]
                public bool? IsPrimary { get; set; }

                /// <summary>
                /// <para>公开电话</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_public")]
                public bool? IsPublic { get; set; }
            }

            /// <summary>
            /// <para>地址列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("address_list")]
            public Address[]? AddressLists { get; set; }

            /// <summary>
            /// <para>地址列表</para>
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
                /// <para>地址 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6989822217869624863</para>
                /// </summary>
                [JsonPropertyName("address_id")]
                public string? AddressId { get; set; }

                /// <summary>
                /// <para>国家 / 地区，可以通过接口[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取详情</para>
                /// <para>必填：是</para>
                /// <para>示例值：6862995757234914824</para>
                /// </summary>
                [JsonPropertyName("country_region_id")]
                public string CountryRegionId { get; set; } = string.Empty;

                /// <summary>
                /// <para>主要行政区ID 可以通过[查询省份/行政区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)接口获取详情</para>
                /// <para>必填：否</para>
                /// <para>示例值：6863326815667095047</para>
                /// </summary>
                [JsonPropertyName("region_id")]
                public string? RegionId { get; set; }

                /// <summary>
                /// <para>城市，可以通过接口[查询城市信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-city/search)获取详情</para>
                /// <para>必填：否</para>
                /// <para>示例值：6863333254578046471</para>
                /// </summary>
                [JsonPropertyName("city_id_v2")]
                public string? CityIdV2 { get; set; }

                /// <summary>
                /// <para>区/县，可以通过接口[查询区/县信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-district/search)获取详情</para>
                /// <para>必填：否</para>
                /// <para>示例值：6863333516579440141</para>
                /// </summary>
                [JsonPropertyName("district_id_v2")]
                public string? DistrictIdV2 { get; set; }

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

                /// <summary>
                /// <para>地址类型，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)地址类型（address_type）枚举定义获得</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("address_type_list")]
                public Enum[] AddressTypeLists { get; set; } = Array.Empty<Enum>();

                /// <summary>
                /// <para>地址类型，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)地址类型（address_type）枚举定义获得</para>
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
                }

                /// <summary>
                /// <para>主要地址</para>
                /// <para>必填：是</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_primary")]
                public bool IsPrimary { get; set; }

                /// <summary>
                /// <para>公开地址</para>
                /// <para>必填：是</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_public")]
                public bool IsPublic { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// </summary>
                public record CustomFieldData
                {
                    /// <summary>
                    /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：name</para>
                    /// </summary>
                    [JsonPropertyName("custom_api_name")]
                    public string CustomApiName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public CustomName? Name { get; set; }

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// </summary>
                    public record CustomName
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：自定义姓名</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Custom Name</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>自定义字段类型</para>
                    /// <para>值类型说明：</para>
                    /// <para>- 1：文本 Text，“文本”和“超链接”属于该类型</para>
                    /// <para>- 2：布尔 Boolean</para>
                    /// <para>- 3：数字 Number</para>
                    /// <para>- 4：枚举 Option，“单选”和“多选”为该类型</para>
                    /// <para>- 5：查找 Lookup，“人员（单选）”、“人员（多选）”和个人信息中的自定义分组为该类型</para>
                    /// <para>- 6：自动编码 Autonumber</para>
                    /// <para>- 7：日期时间 Datetime</para>
                    /// <para>- 8：附件 Attachment，“附件单选”和“附件多选”为该类型</para>
                    /// <para>- 9：图片 Image</para>
                    /// <para>- 10：计算字段 Calculated</para>
                    /// <para>- 11：反向查找 Backlookup</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：\"231\"</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>邮箱列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("email_list")]
            public Email[]? EmailLists { get; set; }

            /// <summary>
            /// <para>邮箱列表</para>
            /// </summary>
            public record Email
            {
                /// <summary>
                /// <para>邮箱地址</para>
                /// <para>必填：是</para>
                /// <para>示例值：1234567@bytedance.com</para>
                /// </summary>
                [JsonPropertyName("email")]
                public string EmailSuffix { get; set; } = string.Empty;

                /// <summary>
                /// <para>是否为主要邮箱</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_primary")]
                public bool? IsPrimary { get; set; }

                /// <summary>
                /// <para>是否为公开邮箱</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_public")]
                public bool? IsPublic { get; set; }

                /// <summary>
                /// <para>邮箱用途，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)邮箱用途（email_usage）枚举定义获得</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("email_usage")]
                public Enum? EmailUsage { get; set; }

                /// <summary>
                /// <para>邮箱用途，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)邮箱用途（email_usage）枚举定义获得</para>
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
                }
            }

            /// <summary>
            /// <para>工作经历列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("work_experience_list")]
            public WorkExperienceInfo[]? WorkExperienceLists { get; set; }

            /// <summary>
            /// <para>工作经历列表</para>
            /// </summary>
            public record WorkExperienceInfo
            {
                /// <summary>
                /// <para>公司 / 组织</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("company_organization")]
                public I18n[]? CompanyOrganizations { get; set; }

                /// <summary>
                /// <para>公司 / 组织</para>
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
                /// <para>部门</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("department")]
                public I18n[]? Departments { get; set; }

                /// <summary>
                /// <para>岗位</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("job")]
                public I18n[]? Jobs { get; set; }

                /// <summary>
                /// <para>工作描述</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("description")]
                public I18n[]? Descriptions { get; set; }

                /// <summary>
                /// <para>开始日期，时间格式为 2023-09-01</para>
                /// <para>必填：否</para>
                /// <para>示例值：2020-01-01</para>
                /// </summary>
                [JsonPropertyName("start_date")]
                public string? StartDate { get; set; }

                /// <summary>
                /// <para>结束日期，时间格式为 2023-09-01</para>
                /// <para>必填：否</para>
                /// <para>示例值：2020-01-01</para>
                /// </summary>
                [JsonPropertyName("end_date")]
                public string? EndDate { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// </summary>
                public record CustomFieldData
                {
                    /// <summary>
                    /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：name</para>
                    /// </summary>
                    [JsonPropertyName("custom_api_name")]
                    public string CustomApiName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public CustomName? Name { get; set; }

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// </summary>
                    public record CustomName
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：自定义姓名</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Custom Name</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>自定义字段类型</para>
                    /// <para>值类型说明：</para>
                    /// <para>- 1：文本 Text，“文本”和“超链接”属于该类型</para>
                    /// <para>- 2：布尔 Boolean</para>
                    /// <para>- 3：数字 Number</para>
                    /// <para>- 4：枚举 Option，“单选”和“多选”为该类型</para>
                    /// <para>- 5：查找 Lookup，“人员（单选）”、“人员（多选）”和个人信息中的自定义分组为该类型</para>
                    /// <para>- 6：自动编码 Autonumber</para>
                    /// <para>- 7：日期时间 Datetime</para>
                    /// <para>- 8：附件 Attachment，“附件单选”和“附件多选”为该类型</para>
                    /// <para>- 9：图片 Image</para>
                    /// <para>- 10：计算字段 Calculated</para>
                    /// <para>- 11：反向查找 Backlookup</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：\"231\"</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>教育经历列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("education_list")]
            public Education[]? EducationLists { get; set; }

            /// <summary>
            /// <para>教育经历列表</para>
            /// </summary>
            public record Education
            {
                /// <summary>
                /// <para>学校</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("school")]
                public I18n[] Schools { get; set; } = Array.Empty<I18n>();

                /// <summary>
                /// <para>学校</para>
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
                /// <para>学历，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)学历（level_of_education）枚举定义获得</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("level_of_education")]
                public Enum? LevelOfEducation { get; set; }

                /// <summary>
                /// <para>学历，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)学历（level_of_education）枚举定义获得</para>
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
                }

                /// <summary>
                /// <para>开始日期，时间格式为 2023-09-01</para>
                /// <para>必填：否</para>
                /// <para>示例值：2011-09-01</para>
                /// </summary>
                [JsonPropertyName("start_date")]
                public string? StartDate { get; set; }

                /// <summary>
                /// <para>结束日期，时间格式为 2023-09-01</para>
                /// <para>必填：否</para>
                /// <para>示例值：2015-06-30</para>
                /// </summary>
                [JsonPropertyName("end_date")]
                public string? EndDate { get; set; }

                /// <summary>
                /// <para>专业</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("field_of_study")]
                public I18n[]? FieldOfStuies { get; set; }

                /// <summary>
                /// <para>学位</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("degree")]
                public Enum? Degree { get; set; }

                /// <summary>
                /// <para>学校名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("school_name")]
                public Enum? SchoolName { get; set; }

                /// <summary>
                /// <para>专业名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("field_of_study_name")]
                public Enum? FieldOfStudyName { get; set; }

                /// <summary>
                /// <para>国家地区ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("country_region_id")]
                public string? CountryRegionId { get; set; }

                /// <summary>
                /// <para>预期结束日期</para>
                /// <para>必填：否</para>
                /// <para>示例值：2011-09-01</para>
                /// </summary>
                [JsonPropertyName("expected_end_date")]
                public string? ExpectedEndDate { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// </summary>
                public record CustomFieldData
                {
                    /// <summary>
                    /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：name</para>
                    /// </summary>
                    [JsonPropertyName("custom_api_name")]
                    public string CustomApiName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public CustomName? Name { get; set; }

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// </summary>
                    public record CustomName
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：自定义姓名</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Custom Name</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>自定义字段类型</para>
                    /// <para>值类型说明：</para>
                    /// <para>- 1：文本 Text，“文本”和“超链接”属于该类型</para>
                    /// <para>- 2：布尔 Boolean</para>
                    /// <para>- 3：数字 Number</para>
                    /// <para>- 4：枚举 Option，“单选”和“多选”为该类型</para>
                    /// <para>- 5：查找 Lookup，“人员（单选）”、“人员（多选）”和个人信息中的自定义分组为该类型</para>
                    /// <para>- 6：自动编码 Autonumber</para>
                    /// <para>- 7：日期时间 Datetime</para>
                    /// <para>- 8：附件 Attachment，“附件单选”和“附件多选”为该类型</para>
                    /// <para>- 9：图片 Image</para>
                    /// <para>- 10：计算字段 Calculated</para>
                    /// <para>- 11：反向查找 Backlookup</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：\"231\"</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>银行账户</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("bank_account_list")]
            public BankAccount[]? BankAccountLists { get; set; }

            /// <summary>
            /// <para>银行账户</para>
            /// </summary>
            public record BankAccount
            {
                /// <summary>
                /// <para>银行名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：中国农业银行</para>
                /// </summary>
                [JsonPropertyName("bank_name")]
                public string? BankName { get; set; }

                /// <summary>
                /// <para>银行账号</para>
                /// <para>必填：是</para>
                /// <para>示例值：6231200000001223</para>
                /// </summary>
                [JsonPropertyName("bank_account_number")]
                public string BankAccountNumber { get; set; } = string.Empty;

                /// <summary>
                /// <para>开户人姓名</para>
                /// <para>必填：是</para>
                /// <para>示例值：孟十五</para>
                /// </summary>
                [JsonPropertyName("account_holder")]
                public string AccountHolder { get; set; } = string.Empty;

                /// <summary>
                /// <para>支行名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：中国农业银行支行</para>
                /// </summary>
                [JsonPropertyName("branch_name")]
                public string? BranchName { get; set; }

                /// <summary>
                /// <para>国家 / 地区，可以通过接口[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取详情</para>
                /// <para>必填：否</para>
                /// <para>示例值：12</para>
                /// </summary>
                [JsonPropertyName("country_region_id")]
                public string? CountryRegionId { get; set; }

                /// <summary>
                /// <para>银行卡用途，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)银行卡用途（bank_account_usage）枚举定义获得</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("bank_account_usage")]
                public Enum[]? BankAccountUsages { get; set; }

                /// <summary>
                /// <para>银行卡用途，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)银行卡用途（bank_account_usage）枚举定义获得</para>
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
                }

                /// <summary>
                /// <para>银行卡类型，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)银行卡类型（bank_account_type）枚举定义获得</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("bank_account_type")]
                public Enum? BankAccountType { get; set; }

                /// <summary>
                /// <para>分配方式，枚举值可通过文档【飞书人事枚举常量】分配方式（Payment Type）枚举定义部分获得</para>
                /// <para>必填：否</para>
                /// <para>示例值：balance</para>
                /// </summary>
                [JsonPropertyName("payment_type")]
                public Enum? PaymentType { get; set; }

                /// <summary>
                /// <para>分配比例</para>
                /// <para>必填：否</para>
                /// <para>示例值：70.21</para>
                /// </summary>
                [JsonPropertyName("payment_rate")]
                public string? PaymentRate { get; set; }

                /// <summary>
                /// <para>分配金额</para>
                /// <para>必填：否</para>
                /// <para>示例值：5000</para>
                /// </summary>
                [JsonPropertyName("payment_amount")]
                public string? PaymentAmount { get; set; }

                /// <summary>
                /// <para>分配优先级</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("priority")]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>货币id</para>
                /// <para>必填：否</para>
                /// <para>示例值：12</para>
                /// </summary>
                [JsonPropertyName("currency_id")]
                public string? CurrencyId { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// </summary>
                public record CustomFieldData
                {
                    /// <summary>
                    /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：name</para>
                    /// </summary>
                    [JsonPropertyName("custom_api_name")]
                    public string CustomApiName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public CustomName? Name { get; set; }

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// </summary>
                    public record CustomName
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：自定义姓名</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Custom Name</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>自定义字段类型</para>
                    /// <para>值类型说明：</para>
                    /// <para>- 1：文本 Text，“文本”和“超链接”属于该类型</para>
                    /// <para>- 2：布尔 Boolean</para>
                    /// <para>- 3：数字 Number</para>
                    /// <para>- 4：枚举 Option，“单选”和“多选”为该类型</para>
                    /// <para>- 5：查找 Lookup，“人员（单选）”、“人员（多选）”和个人信息中的自定义分组为该类型</para>
                    /// <para>- 6：自动编码 Autonumber</para>
                    /// <para>- 7：日期时间 Datetime</para>
                    /// <para>- 8：附件 Attachment，“附件单选”和“附件多选”为该类型</para>
                    /// <para>- 9：图片 Image</para>
                    /// <para>- 10：计算字段 Calculated</para>
                    /// <para>- 11：反向查找 Backlookup</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：\"231\"</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>证件</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("national_id_list")]
            public NationalId[]? NationalIdLists { get; set; }

            /// <summary>
            /// <para>证件</para>
            /// </summary>
            public record NationalId
            {
                /// <summary>
                /// <para>国家证件类型</para>
                /// <para>必填：是</para>
                /// <para>示例值：6863330041896371725</para>
                /// </summary>
                [JsonPropertyName("national_id_type_id")]
                public string NationalIdTypeId { get; set; } = string.Empty;

                /// <summary>
                /// <para>证件号码</para>
                /// <para>必填：是</para>
                /// <para>示例值：1231131333</para>
                /// </summary>
                [JsonPropertyName("national_id_number")]
                public string NationalIdNumber { get; set; } = string.Empty;

                /// <summary>
                /// <para>证件签发日期</para>
                /// <para>必填：否</para>
                /// <para>示例值：2020-04-01</para>
                /// </summary>
                [JsonPropertyName("issue_date")]
                public string? IssueDate { get; set; }

                /// <summary>
                /// <para>证件到期日期</para>
                /// <para>必填：否</para>
                /// <para>示例值：2020-05-21</para>
                /// </summary>
                [JsonPropertyName("expiration_date")]
                public string? ExpirationDate { get; set; }

                /// <summary>
                /// <para>国家 / 地区，可以通过接口[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取详情</para>
                /// <para>必填：是</para>
                /// <para>示例值：6862995757234914824</para>
                /// </summary>
                [JsonPropertyName("country_region_id")]
                public string CountryRegionId { get; set; } = string.Empty;

                /// <summary>
                /// <para>证件签发机构</para>
                /// <para>必填：否</para>
                /// <para>示例值：北京市公安局</para>
                /// </summary>
                [JsonPropertyName("issued_by")]
                public string? IssuedBy { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// </summary>
                public record CustomFieldData
                {
                    /// <summary>
                    /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：name</para>
                    /// </summary>
                    [JsonPropertyName("custom_api_name")]
                    public string CustomApiName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public CustomName? Name { get; set; }

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// </summary>
                    public record CustomName
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：自定义姓名</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Custom Name</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>自定义字段类型</para>
                    /// <para>值类型说明：</para>
                    /// <para>- 1：文本 Text，“文本”和“超链接”属于该类型</para>
                    /// <para>- 2：布尔 Boolean</para>
                    /// <para>- 3：数字 Number</para>
                    /// <para>- 4：枚举 Option，“单选”和“多选”为该类型</para>
                    /// <para>- 5：查找 Lookup，“人员（单选）”、“人员（多选）”和个人信息中的自定义分组为该类型</para>
                    /// <para>- 6：自动编码 Autonumber</para>
                    /// <para>- 7：日期时间 Datetime</para>
                    /// <para>- 8：附件 Attachment，“附件单选”和“附件多选”为该类型</para>
                    /// <para>- 9：图片 Image</para>
                    /// <para>- 10：计算字段 Calculated</para>
                    /// <para>- 11：反向查找 Backlookup</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：\"231\"</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>家庭成员列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("dependent_list")]
            public Dependent[]? DependentLists { get; set; }

            /// <summary>
            /// <para>家庭成员列表</para>
            /// </summary>
            public record Dependent
            {
                /// <summary>
                /// <para>ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：123</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>姓名</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public PersonName? Name { get; set; }

                /// <summary>
                /// <para>姓名</para>
                /// </summary>
                public record PersonName
                {
                    /// <summary>
                    /// <para>姓 - 本地文字</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：黄</para>
                    /// </summary>
                    [JsonPropertyName("local_primary")]
                    public string? LocalPrimary { get; set; }

                    /// <summary>
                    /// <para>名 - 本地文字</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：四</para>
                    /// </summary>
                    [JsonPropertyName("local_first_name")]
                    public string? LocalFirstName { get; set; }

                    /// <summary>
                    /// <para>国家 / 地区，可以通过接口[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取详情</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：6862995757234914824</para>
                    /// </summary>
                    [JsonPropertyName("country_region_id")]
                    public string CountryRegionId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>姓名类型，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)姓名类型（name_type）枚举定义获得</para>
                    /// <para>必填：是</para>
                    /// </summary>
                    [JsonPropertyName("name_type")]
                    public Enum NameType { get; set; } = new();

                    /// <summary>
                    /// <para>姓名类型，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)姓名类型（name_type）枚举定义获得</para>
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
                    }

                    /// <summary>
                    /// <para>名 - 第二本地文字</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：五</para>
                    /// </summary>
                    [JsonPropertyName("local_first_name_2")]
                    public string? LocalFirstName2 { get; set; }

                    /// <summary>
                    /// <para>姓 - 第二本地文字</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("local_primary_2")]
                    public string? LocalPrimary2 { get; set; }

                    /// <summary>
                    /// <para>别名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：别名</para>
                    /// </summary>
                    [JsonPropertyName("additional_name")]
                    public string? AdditionalName { get; set; }

                    /// <summary>
                    /// <para>补充姓名类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
                    /// <para>- custom_api_name：additional_name_type</para>
                    /// <para>- object_api_name：person_name</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("additional_name_type")]
                    public Enum? AdditionalNameType { get; set; }

                    /// <summary>
                    /// <para>名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：帅</para>
                    /// </summary>
                    [JsonPropertyName("first_name")]
                    public string? FirstName { get; set; }

                    /// <summary>
                    /// <para>全名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("full_name")]
                    public string? FullName { get; set; }

                    /// <summary>
                    /// <para>姓氏称谓</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("hereditary")]
                    public string? Hereditary { get; set; }

                    /// <summary>
                    /// <para>自定义姓名（未传入时，姓名将默认根据所属国家 / 地区规则对相关姓、名字段拼接）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("custom_name")]
                    public string? CustomName { get; set; }

                    /// <summary>
                    /// <para>本地文字的自定义姓名（未传入时，本地文字的姓名将默认根据所属国家 / 地区规则对本地文字的相关姓、名字段拼接）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("custom_local_name")]
                    public string? CustomLocalName { get; set; }

                    /// <summary>
                    /// <para>中间名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：大</para>
                    /// </summary>
                    [JsonPropertyName("middle_name")]
                    public string? MiddleName { get; set; }

                    /// <summary>
                    /// <para>姓</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("name_primary")]
                    public string? NamePrimary { get; set; }

                    /// <summary>
                    /// <para>第二姓氏</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("secondary")]
                    public string? Secondary { get; set; }

                    /// <summary>
                    /// <para>婚后姓氏</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("tertiary")]
                    public string? Tertiary { get; set; }

                    /// <summary>
                    /// <para>尊称，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
                    /// <para>- custom_api_name：social</para>
                    /// <para>- object_api_name：person_name</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("social")]
                    public Enum? Social { get; set; }

                    /// <summary>
                    /// <para>头衔，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
                    /// <para>- custom_api_name：title</para>
                    /// <para>- object_api_name：person_name</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("title")]
                    public Enum? Title { get; set; }

                    /// <summary>
                    /// <para>本地中间名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：大</para>
                    /// </summary>
                    [JsonPropertyName("local_middle_name")]
                    public string? LocalMiddleName { get; set; }

                    /// <summary>
                    /// <para>第二姓氏 - 本地文字</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("local_secondary")]
                    public string? LocalSecondary { get; set; }

                    /// <summary>
                    /// <para>展示姓名（本地和西方文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("display_name_local_and_western_script")]
                    public string? DisplayNameLocalAndWesternScript { get; set; }

                    /// <summary>
                    /// <para>展示姓名（本地文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("display_name_local_script")]
                    public string? DisplayNameLocalScript { get; set; }

                    /// <summary>
                    /// <para>展示姓名（西方文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("display_name_western_script")]
                    public string? DisplayNameWesternScript { get; set; }
                }

                /// <summary>
                /// <para>关系</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("relationship")]
                public Enum Relationship { get; set; } = new();

                /// <summary>
                /// <para>关系</para>
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
                }

                /// <summary>
                /// <para>性别</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("gender")]
                public Enum? Gender { get; set; }

                /// <summary>
                /// <para>生日</para>
                /// <para>必填：否</para>
                /// <para>示例值：2020-01-01</para>
                /// </summary>
                [JsonPropertyName("date_of_birth")]
                public string? DateOfBirth { get; set; }

                /// <summary>
                /// <para>证件号码</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("national_id_list")]
                public NationalId[]? NationalIdLists { get; set; }

                /// <summary>
                /// <para>证件号码</para>
                /// </summary>
                public record NationalId
                {
                    /// <summary>
                    /// <para>国家证件类型</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：6863330041896371725</para>
                    /// </summary>
                    [JsonPropertyName("national_id_type_id")]
                    public string NationalIdTypeId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>证件号码</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1231131333</para>
                    /// </summary>
                    [JsonPropertyName("national_id_number")]
                    public string NationalIdNumber { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>证件签发日期</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：2020-04-01</para>
                    /// </summary>
                    [JsonPropertyName("issue_date")]
                    public string? IssueDate { get; set; }

                    /// <summary>
                    /// <para>证件到期日期</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：2020-05-21</para>
                    /// </summary>
                    [JsonPropertyName("expiration_date")]
                    public string? ExpirationDate { get; set; }

                    /// <summary>
                    /// <para>国家 / 地区，可以通过接口[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取详情</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：6862995757234914824</para>
                    /// </summary>
                    [JsonPropertyName("country_region_id")]
                    public string CountryRegionId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>证件签发机构</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：北京市公安局</para>
                    /// </summary>
                    [JsonPropertyName("issued_by")]
                    public string? IssuedBy { get; set; }

                    /// <summary>
                    /// <para>自定义字段</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("custom_fields")]
                    public CustomFieldData[]? CustomFields { get; set; }

                    /// <summary>
                    /// <para>自定义字段</para>
                    /// </summary>
                    public record CustomFieldData
                    {
                        /// <summary>
                        /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：name</para>
                        /// </summary>
                        [JsonPropertyName("custom_api_name")]
                        public string CustomApiName { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>自定义字段名称</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("name")]
                        public CustomName? Name { get; set; }

                        /// <summary>
                        /// <para>自定义字段名称</para>
                        /// </summary>
                        public record CustomName
                        {
                            /// <summary>
                            /// <para>中文</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：自定义姓名</para>
                            /// </summary>
                            [JsonPropertyName("zh_cn")]
                            public string? ZhCn { get; set; }

                            /// <summary>
                            /// <para>英文</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：Custom Name</para>
                            /// </summary>
                            [JsonPropertyName("en_us")]
                            public string? EnUs { get; set; }
                        }

                        /// <summary>
                        /// <para>自定义字段类型</para>
                        /// <para>值类型说明：</para>
                        /// <para>- 1：文本 Text，“文本”和“超链接”属于该类型</para>
                        /// <para>- 2：布尔 Boolean</para>
                        /// <para>- 3：数字 Number</para>
                        /// <para>- 4：枚举 Option，“单选”和“多选”为该类型</para>
                        /// <para>- 5：查找 Lookup，“人员（单选）”、“人员（多选）”和个人信息中的自定义分组为该类型</para>
                        /// <para>- 6：自动编码 Autonumber</para>
                        /// <para>- 7：日期时间 Datetime</para>
                        /// <para>- 8：附件 Attachment，“附件单选”和“附件多选”为该类型</para>
                        /// <para>- 9：图片 Image</para>
                        /// <para>- 10：计算字段 Calculated</para>
                        /// <para>- 11：反向查找 Backlookup</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// </summary>
                        [JsonPropertyName("type")]
                        public int? Type { get; set; }

                        /// <summary>
                        /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：\"231\"</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// <para>配偶工作状态</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("spouses_working_status")]
                public Enum? SpousesWorkingStatus { get; set; }

                /// <summary>
                /// <para>包含家属医疗保险</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_this_person_covered_by_health_insurance")]
                public bool? IsThisPersonCoveredByHealthInsurance { get; set; }

                /// <summary>
                /// <para>允许家属抵扣税款</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("is_this_person_allowed_for_tax_deduction")]
                public bool? IsThisPersonAllowedForTaxDeduction { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// </summary>
                public record CustomFieldData
                {
                    /// <summary>
                    /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：name</para>
                    /// </summary>
                    [JsonPropertyName("custom_api_name")]
                    public string CustomApiName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public CustomName? Name { get; set; }

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// </summary>
                    public record CustomName
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：自定义姓名</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Custom Name</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>自定义字段类型</para>
                    /// <para>值类型说明：</para>
                    /// <para>- 1：文本 Text，“文本”和“超链接”属于该类型</para>
                    /// <para>- 2：布尔 Boolean</para>
                    /// <para>- 3：数字 Number</para>
                    /// <para>- 4：枚举 Option，“单选”和“多选”为该类型</para>
                    /// <para>- 5：查找 Lookup，“人员（单选）”、“人员（多选）”和个人信息中的自定义分组为该类型</para>
                    /// <para>- 6：自动编码 Autonumber</para>
                    /// <para>- 7：日期时间 Datetime</para>
                    /// <para>- 8：附件 Attachment，“附件单选”和“附件多选”为该类型</para>
                    /// <para>- 9：图片 Image</para>
                    /// <para>- 10：计算字段 Calculated</para>
                    /// <para>- 11：反向查找 Backlookup</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：\"231\"</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }

                /// <summary>
                /// <para>家庭成员姓名</para>
                /// <para>必填：否</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("dependent_name")]
                public string? DependentName { get; set; }

                /// <summary>
                /// <para>工作单位</para>
                /// <para>必填：否</para>
                /// <para>示例值：海淀区交警大队</para>
                /// </summary>
                [JsonPropertyName("employer")]
                public string? Employer { get; set; }

                /// <summary>
                /// <para>岗位</para>
                /// <para>必填：否</para>
                /// <para>示例值：保安</para>
                /// </summary>
                [JsonPropertyName("job")]
                public string? Job { get; set; }

                /// <summary>
                /// <para>电话</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("phone")]
                public DependentPhone? Phone { get; set; }

                /// <summary>
                /// <para>电话</para>
                /// </summary>
                public record DependentPhone
                {
                    /// <summary>
                    /// <para>国家区号，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)手机区号（international_area_code）枚举定义获得</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("international_area_code")]
                    public Enum? InternationalAreaCode { get; set; }

                    /// <summary>
                    /// <para>国家区号，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)手机区号（international_area_code）枚举定义获得</para>
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
                    }

                    /// <summary>
                    /// <para>电话号码</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：010-12345678</para>
                    /// </summary>
                    [JsonPropertyName("phone_number")]
                    public string PhoneNumber { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>完整电话号码</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：+86 010-12345678</para>
                    /// </summary>
                    [JsonPropertyName("formatted_phone_number")]
                    public string? FormattedPhoneNumber { get; set; }

                    /// <summary>
                    /// <para>设备类型</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("device_type")]
                    public Enum? DeviceType { get; set; }

                    /// <summary>
                    /// <para>电话用途，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)电话用途（phone_usage）枚举定义获得</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("phone_usage")]
                    public Enum? PhoneUsage { get; set; }

                    /// <summary>
                    /// <para>主要电话</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// </summary>
                    [JsonPropertyName("is_primary")]
                    public bool? IsPrimary { get; set; }

                    /// <summary>
                    /// <para>公开电话</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// </summary>
                    [JsonPropertyName("is_public")]
                    public bool? IsPublic { get; set; }
                }

                /// <summary>
                /// <para>联系地址</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("address")]
                public DependentAddress? Address { get; set; }

                /// <summary>
                /// <para>联系地址</para>
                /// </summary>
                public record DependentAddress
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
                    /// <para>地址 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6989822217869624863</para>
                    /// </summary>
                    [JsonPropertyName("address_id")]
                    public string? AddressId { get; set; }

                    /// <summary>
                    /// <para>国家 / 地区，可以通过接口[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取详情</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：6862995757234914824</para>
                    /// </summary>
                    [JsonPropertyName("country_region_id")]
                    public string CountryRegionId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>主要行政区ID 可以通过[查询省份/行政区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)接口获取详情</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6863326815667095047</para>
                    /// </summary>
                    [JsonPropertyName("region_id")]
                    public string? RegionId { get; set; }

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

                    /// <summary>
                    /// <para>地址类型，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)地址类型（address_type）枚举定义获得</para>
                    /// <para>必填：是</para>
                    /// </summary>
                    [JsonPropertyName("address_type_list")]
                    public Enum[] AddressTypeLists { get; set; } = Array.Empty<Enum>();

                    /// <summary>
                    /// <para>地址类型，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)地址类型（address_type）枚举定义获得</para>
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
                    }

                    /// <summary>
                    /// <para>主要地址</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：true</para>
                    /// </summary>
                    [JsonPropertyName("is_primary")]
                    public bool IsPrimary { get; set; }

                    /// <summary>
                    /// <para>公开地址</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：true</para>
                    /// </summary>
                    [JsonPropertyName("is_public")]
                    public bool IsPublic { get; set; }

                    /// <summary>
                    /// <para>自定义字段</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("custom_fields")]
                    public CustomFieldData[]? CustomFields { get; set; }

                    /// <summary>
                    /// <para>自定义字段</para>
                    /// </summary>
                    public record CustomFieldData
                    {
                        /// <summary>
                        /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：name</para>
                        /// </summary>
                        [JsonPropertyName("custom_api_name")]
                        public string CustomApiName { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>自定义字段名称</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("name")]
                        public CustomName? Name { get; set; }

                        /// <summary>
                        /// <para>自定义字段名称</para>
                        /// </summary>
                        public record CustomName
                        {
                            /// <summary>
                            /// <para>中文</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：自定义姓名</para>
                            /// </summary>
                            [JsonPropertyName("zh_cn")]
                            public string? ZhCn { get; set; }

                            /// <summary>
                            /// <para>英文</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：Custom Name</para>
                            /// </summary>
                            [JsonPropertyName("en_us")]
                            public string? EnUs { get; set; }
                        }

                        /// <summary>
                        /// <para>自定义字段类型</para>
                        /// <para>值类型说明：</para>
                        /// <para>- 1：文本 Text，“文本”和“超链接”属于该类型</para>
                        /// <para>- 2：布尔 Boolean</para>
                        /// <para>- 3：数字 Number</para>
                        /// <para>- 4：枚举 Option，“单选”和“多选”为该类型</para>
                        /// <para>- 5：查找 Lookup，“人员（单选）”、“人员（多选）”和个人信息中的自定义分组为该类型</para>
                        /// <para>- 6：自动编码 Autonumber</para>
                        /// <para>- 7：日期时间 Datetime</para>
                        /// <para>- 8：附件 Attachment，“附件单选”和“附件多选”为该类型</para>
                        /// <para>- 9：图片 Image</para>
                        /// <para>- 10：计算字段 Calculated</para>
                        /// <para>- 11：反向查找 Backlookup</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// </summary>
                        [JsonPropertyName("type")]
                        public int? Type { get; set; }

                        /// <summary>
                        /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：\"231\"</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// <para>出生证明</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("birth_certificate_of_child")]
                public File[]? BirthCertificateOfChilds { get; set; }

                /// <summary>
                /// <para>出生证明</para>
                /// </summary>
                public record File
                {
                    /// <summary>
                    /// <para>上传文件ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：150018109586e8ea745e47ae8feb3722dbe1d03a181336393633393133303431393831343930373235150200</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>文件名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：document.txt</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string? Name { get; set; }
                }
            }

            /// <summary>
            /// <para>紧急联系人列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("emergency_contact_list")]
            public EmergencyContact[]? EmergencyContactLists { get; set; }

            /// <summary>
            /// <para>紧急联系人列表</para>
            /// </summary>
            public record EmergencyContact
            {
                /// <summary>
                /// <para>ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：123</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>姓名</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public PersonName? Name { get; set; }

                /// <summary>
                /// <para>姓名</para>
                /// </summary>
                public record PersonName
                {
                    /// <summary>
                    /// <para>姓 - 本地文字</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：黄</para>
                    /// </summary>
                    [JsonPropertyName("local_primary")]
                    public string? LocalPrimary { get; set; }

                    /// <summary>
                    /// <para>名 - 本地文字</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：四</para>
                    /// </summary>
                    [JsonPropertyName("local_first_name")]
                    public string? LocalFirstName { get; set; }

                    /// <summary>
                    /// <para>国家 / 地区，可以通过接口[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取详情</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：6862995757234914824</para>
                    /// </summary>
                    [JsonPropertyName("country_region_id")]
                    public string CountryRegionId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>姓名类型，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)姓名类型（name_type）枚举定义获得</para>
                    /// <para>必填：是</para>
                    /// </summary>
                    [JsonPropertyName("name_type")]
                    public Enum NameType { get; set; } = new();

                    /// <summary>
                    /// <para>姓名类型，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)姓名类型（name_type）枚举定义获得</para>
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
                    }

                    /// <summary>
                    /// <para>名 - 第二本地文字</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：五</para>
                    /// </summary>
                    [JsonPropertyName("local_first_name_2")]
                    public string? LocalFirstName2 { get; set; }

                    /// <summary>
                    /// <para>姓 - 第二本地文字</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("local_primary_2")]
                    public string? LocalPrimary2 { get; set; }

                    /// <summary>
                    /// <para>别名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：别名</para>
                    /// </summary>
                    [JsonPropertyName("additional_name")]
                    public string? AdditionalName { get; set; }

                    /// <summary>
                    /// <para>补充姓名类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
                    /// <para>- custom_api_name：additional_name_type</para>
                    /// <para>- object_api_name：person_name</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("additional_name_type")]
                    public Enum? AdditionalNameType { get; set; }

                    /// <summary>
                    /// <para>名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：帅</para>
                    /// </summary>
                    [JsonPropertyName("first_name")]
                    public string? FirstName { get; set; }

                    /// <summary>
                    /// <para>全名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("full_name")]
                    public string? FullName { get; set; }

                    /// <summary>
                    /// <para>姓氏称谓</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("hereditary")]
                    public string? Hereditary { get; set; }

                    /// <summary>
                    /// <para>自定义姓名（未传入时，姓名将默认根据所属国家 / 地区规则对相关姓、名字段拼接）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("custom_name")]
                    public string? CustomName { get; set; }

                    /// <summary>
                    /// <para>本地文字的自定义姓名（未传入时，本地文字的姓名将默认根据所属国家 / 地区规则对本地文字的相关姓、名字段拼接）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("custom_local_name")]
                    public string? CustomLocalName { get; set; }

                    /// <summary>
                    /// <para>中间名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：大</para>
                    /// </summary>
                    [JsonPropertyName("middle_name")]
                    public string? MiddleName { get; set; }

                    /// <summary>
                    /// <para>姓</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("name_primary")]
                    public string? NamePrimary { get; set; }

                    /// <summary>
                    /// <para>第二姓氏</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("secondary")]
                    public string? Secondary { get; set; }

                    /// <summary>
                    /// <para>婚后姓氏</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("tertiary")]
                    public string? Tertiary { get; set; }

                    /// <summary>
                    /// <para>尊称，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
                    /// <para>- custom_api_name：social</para>
                    /// <para>- object_api_name：person_name</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("social")]
                    public Enum? Social { get; set; }

                    /// <summary>
                    /// <para>头衔，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
                    /// <para>- custom_api_name：title</para>
                    /// <para>- object_api_name：person_name</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("title")]
                    public Enum? Title { get; set; }

                    /// <summary>
                    /// <para>本地中间名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：大</para>
                    /// </summary>
                    [JsonPropertyName("local_middle_name")]
                    public string? LocalMiddleName { get; set; }

                    /// <summary>
                    /// <para>第二姓氏 - 本地文字</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("local_secondary")]
                    public string? LocalSecondary { get; set; }

                    /// <summary>
                    /// <para>展示姓名（本地和西方文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("display_name_local_and_western_script")]
                    public string? DisplayNameLocalAndWesternScript { get; set; }

                    /// <summary>
                    /// <para>展示姓名（本地文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("display_name_local_script")]
                    public string? DisplayNameLocalScript { get; set; }

                    /// <summary>
                    /// <para>展示姓名（西方文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("display_name_western_script")]
                    public string? DisplayNameWesternScript { get; set; }
                }

                /// <summary>
                /// <para>关系</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("relationship")]
                public Enum? Relationship { get; set; }

                /// <summary>
                /// <para>关系</para>
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
                }

                /// <summary>
                /// <para>电话</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("phone_ist")]
                public Phone[]? PhoneIsts { get; set; }

                /// <summary>
                /// <para>电话</para>
                /// </summary>
                public record Phone
                {
                    /// <summary>
                    /// <para>国家区号，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)手机区号（international_area_code）枚举定义获得</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("international_area_code")]
                    public Enum? InternationalAreaCode { get; set; }

                    /// <summary>
                    /// <para>国家区号，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)手机区号（international_area_code）枚举定义获得</para>
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
                    }

                    /// <summary>
                    /// <para>电话号码</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：010-12345678</para>
                    /// </summary>
                    [JsonPropertyName("phone_number")]
                    public string PhoneNumber { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>完整电话号码</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：+86 010-12345678</para>
                    /// </summary>
                    [JsonPropertyName("formatted_phone_number")]
                    public string? FormattedPhoneNumber { get; set; }

                    /// <summary>
                    /// <para>设备类型</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("device_type")]
                    public Enum? DeviceType { get; set; }

                    /// <summary>
                    /// <para>电话用途</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("phone_usage")]
                    public Enum? PhoneUsage { get; set; }

                    /// <summary>
                    /// <para>主要电话</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// </summary>
                    [JsonPropertyName("is_primary")]
                    public bool? IsPrimary { get; set; }

                    /// <summary>
                    /// <para>公开电话</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// </summary>
                    [JsonPropertyName("is_public")]
                    public bool? IsPublic { get; set; }
                }

                /// <summary>
                /// <para>电话</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("phone_list")]
                public Phone[]? PhoneLists { get; set; }

                /// <summary>
                /// <para>法定姓名</para>
                /// <para>必填：否</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("legal_name")]
                public string? LegalName { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// </summary>
                public record CustomFieldData
                {
                    /// <summary>
                    /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：name</para>
                    /// </summary>
                    [JsonPropertyName("custom_api_name")]
                    public string CustomApiName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public CustomName? Name { get; set; }

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// </summary>
                    public record CustomName
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：自定义姓名</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Custom Name</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>自定义字段类型</para>
                    /// <para>值类型说明：</para>
                    /// <para>- 1：文本 Text，“文本”和“超链接”属于该类型</para>
                    /// <para>- 2：布尔 Boolean</para>
                    /// <para>- 3：数字 Number</para>
                    /// <para>- 4：枚举 Option，“单选”和“多选”为该类型</para>
                    /// <para>- 5：查找 Lookup，“人员（单选）”、“人员（多选）”和个人信息中的自定义分组为该类型</para>
                    /// <para>- 6：自动编码 Autonumber</para>
                    /// <para>- 7：日期时间 Datetime</para>
                    /// <para>- 8：附件 Attachment，“附件单选”和“附件多选”为该类型</para>
                    /// <para>- 9：图片 Image</para>
                    /// <para>- 10：计算字段 Calculated</para>
                    /// <para>- 11：反向查找 Backlookup</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：\"231\"</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }

                /// <summary>
                /// <para>主要联系人,若有多个联系人，只能有一个联系人的「is_primary」为true</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_primary")]
                public bool? IsPrimary { get; set; }
            }

            /// <summary>
            /// <para>参加工作日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-10-01</para>
            /// </summary>
            [JsonPropertyName("date_entered_workforce")]
            public string? DateEnteredWorkforce { get; set; }

            /// <summary>
            /// <para>工龄</para>
            /// <para>必填：否</para>
            /// <para>示例值：2</para>
            /// </summary>
            [JsonPropertyName("working_years")]
            public int? WorkingYears { get; set; }

            /// <summary>
            /// <para>头像资源的 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：dfysuc8x76dsfsw</para>
            /// </summary>
            [JsonPropertyName("profile_image_id")]
            public string? ProfileImageId { get; set; }

            /// <summary>
            /// <para>邮箱地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：test@163.com</para>
            /// </summary>
            [JsonPropertyName("email_address")]
            public string? EmailAddress { get; set; }

            /// <summary>
            /// <para>年龄</para>
            /// <para>必填：否</para>
            /// <para>示例值：22</para>
            /// </summary>
            [JsonPropertyName("age")]
            public int? Age { get; set; }

            /// <summary>
            /// <para>最高学历教育经历</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("highest_level_of_education")]
            public Education? HighestLevelOfEducation { get; set; }

            /// <summary>
            /// <para>最高学位教育经历</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("highest_degree_of_education")]
            public Education? HighestDegreeOfEducation { get; set; }

            /// <summary>
            /// <para>个人资料附件</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("personal_profile")]
            public PersonalProfile[]? PersonalProfiles { get; set; }

            /// <summary>
            /// <para>个人资料附件</para>
            /// </summary>
            public record PersonalProfile
            {
                /// <summary>
                /// <para>资料类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
                /// <para>- custom_api_name：profile_type</para>
                /// <para>- object_api_name：personal_profile</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("personal_profile_type")]
                public Enum? PersonalProfileType { get; set; }

                /// <summary>
                /// <para>资料类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
                /// <para>- custom_api_name：profile_type</para>
                /// <para>- object_api_name：personal_profile</para>
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
                }

                /// <summary>
                /// <para>文件列表</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("files")]
                public File[]? Files { get; set; }

                /// <summary>
                /// <para>文件列表</para>
                /// </summary>
                public record File
                {
                    /// <summary>
                    /// <para>文件ID，文件内容可通过[下载文件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/file/get)接口获取</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：150018109586e8ea745e47ae8feb3722dbe1d03a181336393633393133303431393831343930373235150200</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>文件名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：document.txt</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string? Name { get; set; }
                }
            }

            /// <summary>
            /// <para>人才 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863326262618752123</para>
            /// </summary>
            [JsonPropertyName("talent_id")]
            public string? TalentId { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public CustomFieldData[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record CustomFieldData
            {
                /// <summary>
                /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                /// <para>必填：是</para>
                /// <para>示例值：name</para>
                /// </summary>
                [JsonPropertyName("custom_api_name")]
                public string CustomApiName { get; set; } = string.Empty;

                /// <summary>
                /// <para>自定义字段名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public CustomName? Name { get; set; }

                /// <summary>
                /// <para>自定义字段名称</para>
                /// </summary>
                public record CustomName
                {
                    /// <summary>
                    /// <para>中文</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：自定义姓名</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>英文</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Custom Name</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>自定义字段类型</para>
                /// <para>值类型说明：</para>
                /// <para>- 1：文本 Text，“文本”和“超链接”属于该类型</para>
                /// <para>- 2：布尔 Boolean</para>
                /// <para>- 3：数字 Number</para>
                /// <para>- 4：枚举 Option，“单选”和“多选”为该类型</para>
                /// <para>- 5：查找 Lookup，“人员（单选）”、“人员（多选）”和个人信息中的自定义分组为该类型</para>
                /// <para>- 6：自动编码 Autonumber</para>
                /// <para>- 7：日期时间 Datetime</para>
                /// <para>- 8：附件 Attachment，“附件单选”和“附件多选”为该类型</para>
                /// <para>- 9：图片 Image</para>
                /// <para>- 10：计算字段 Calculated</para>
                /// <para>- 11：反向查找 Backlookup</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("type")]
                public int? Type { get; set; }

                /// <summary>
                /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                /// <para>必填：是</para>
                /// <para>示例值：\"231\"</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>居民身份证件号码</para>
            /// <para>必填：否</para>
            /// <para>示例值：11010000000000</para>
            /// </summary>
            [JsonPropertyName("national_id_number")]
            public string? NationalIdNumber { get; set; }

            /// <summary>
            /// <para>家庭地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863326262618752123</para>
            /// </summary>
            [JsonPropertyName("family_address")]
            public string? FamilyAddress { get; set; }

            /// <summary>
            /// <para>个人附加信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863326262618752123</para>
            /// </summary>
            [JsonPropertyName("person_info_chns")]
            public PersonInfoChn[]? PersonInfoChns { get; set; }

            /// <summary>
            /// <para>个人附加信息</para>
            /// </summary>
            public record PersonInfoChn
            {
                /// <summary>
                /// <para>籍贯 ID，可以通过[查询省份/行政区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)接口获取详情</para>
                /// <para>必填：否</para>
                /// <para>示例值：6863326262618752111</para>
                /// </summary>
                [JsonPropertyName("native_region")]
                public string? NativeRegion { get; set; }

                /// <summary>
                /// <para>户口类型，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)户口类型（hukou_type）枚举定义获得</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("hukou_type")]
                public Enum? HukouType { get; set; }

                /// <summary>
                /// <para>户口类型，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)户口类型（hukou_type）枚举定义获得</para>
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
                }

                /// <summary>
                /// <para>户口所在地</para>
                /// <para>必填：否</para>
                /// <para>示例值：山东省平阴县</para>
                /// </summary>
                [JsonPropertyName("hukou_location")]
                public string? HukouLocation { get; set; }

                /// <summary>
                /// <para>政治面貌，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)政治面貌（political_affiliation）枚举定义获得</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("political_affiliations")]
                public Enum[]? PoliticalAffiliations { get; set; }
            }

            /// <summary>
            /// <para>出生国家/地区，可以通过接口[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取详情</para>
            /// <para>必填：否</para>
            /// <para>示例值：中国</para>
            /// </summary>
            [JsonPropertyName("born_country_region")]
            public string? BornCountryRegion { get; set; }

            /// <summary>
            /// <para>是否残疾</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_disabled")]
            public bool? IsDisabled { get; set; }

            /// <summary>
            /// <para>残疾证号</para>
            /// <para>必填：否</para>
            /// <para>示例值：1110000</para>
            /// </summary>
            [JsonPropertyName("disable_card_number")]
            public string? DisableCardNumber { get; set; }

            /// <summary>
            /// <para>是否烈属</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_martyr_family")]
            public bool? IsMartyrFamily { get; set; }

            /// <summary>
            /// <para>烈属证号</para>
            /// <para>必填：否</para>
            /// <para>示例值：1110000</para>
            /// </summary>
            [JsonPropertyName("martyr_card_number")]
            public string? MartyrCardNumber { get; set; }

            /// <summary>
            /// <para>是否孤老</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_old_alone")]
            public bool? IsOldAlone { get; set; }

            /// <summary>
            /// <para>居民身份信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863326262618752123</para>
            /// </summary>
            [JsonPropertyName("resident_taxes")]
            public ResidentTax[]? ResidentTaxes { get; set; }

            /// <summary>
            /// <para>居民身份信息</para>
            /// </summary>
            public record ResidentTax
            {
                /// <summary>
                /// <para>年度</para>
                /// <para>必填：是</para>
                /// <para>示例值：2023</para>
                /// </summary>
                [JsonPropertyName("year_resident_tax")]
                public string YearResidentTax { get; set; } = string.Empty;

                /// <summary>
                /// <para>resident_status</para>
                /// <para>居民身份，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
                /// <para>- custom_api_name：resident_status</para>
                /// <para>- object_api_name：resident_tax</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("resident_status")]
                public Enum? ResidentStatus { get; set; }

                /// <summary>
                /// <para>resident_status</para>
                /// <para>居民身份，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
                /// <para>- custom_api_name：resident_status</para>
                /// <para>- object_api_name：resident_tax</para>
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
                }

                /// <summary>
                /// <para>国家/地区，可以通过接口[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取详情</para>
                /// <para>必填：否</para>
                /// <para>示例值：中国</para>
                /// </summary>
                [JsonPropertyName("tax_country_region_id")]
                public string? TaxCountryRegionId { get; set; }

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
                    /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(123, 123.23, true, [\"id1\",\"id2\], 2006-01-02 15:04:05])</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：Sandy</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>宗教信仰，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- custom_api_name：religion</para>
            /// <para>- object_api_name：person</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("religion")]
            public Enum? Religion { get; set; }

            /// <summary>
            /// <para>工龄 （单位：年）浮点类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：2.1</para>
            /// </summary>
            [JsonPropertyName("working_years_v2")]
            public float? WorkingYearsV2 { get; set; }

            /// <summary>
            /// <para>个人信息 创建时间，时间格式为 2023-09-01 13:21:12</para>
            /// <para>必填：否</para>
            /// <para>示例值：2023-09-01 13:21:12</para>
            /// </summary>
            [JsonPropertyName("created_at")]
            public string? CreatedAt { get; set; }

            /// <summary>
            /// <para>个人信息 更新时间，时间格式为 2023-09-01 13:21:12</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022-01-02</para>
            /// </summary>
            [JsonPropertyName("updated_at")]
            public string? UpdatedAt { get; set; }

            /// <summary>
            /// <para>个人信息 创建人，可以通过[批量查询员工信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)接口获取详情，user_id_type使用people_corehr_id类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：69928404442626824</para>
            /// </summary>
            [JsonPropertyName("created_by")]
            public string? CreatedBy { get; set; }

            /// <summary>
            /// <para>个人信息 更新人，可以通过[批量查询员工信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)接口获取详情，user_id_type使用people_corehr_id类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：69928404442626824</para>
            /// </summary>
            [JsonPropertyName("updated_by")]
            public string? UpdatedBy { get; set; }

            /// <summary>
            /// <para>银行卡号</para>
            /// <para>必填：否</para>
            /// <para>示例值：69928404442626824</para>
            /// </summary>
            [JsonPropertyName("bank_account_number")]
            public string? BankAccountNumber { get; set; }

            /// <summary>
            /// <para>护照号码</para>
            /// <para>必填：否</para>
            /// <para>示例值：6919733936050406926</para>
            /// </summary>
            [JsonPropertyName("passport_number")]
            public string? PassportNumber { get; set; }

            /// <summary>
            /// <para>上家公司</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("former_employer")]
            public I18n[]? FormerEmployers { get; set; }

            /// <summary>
            /// <para>上家公司</para>
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
        }

        /// <summary>
        /// <para>工作信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("employment_info")]
        public PreHireEmploymentInfo? EmploymentInfo { get; set; }

        /// <summary>
        /// <para>工作信息</para>
        /// </summary>
        public record PreHireEmploymentInfo
        {
            /// <summary>
            /// <para>部门 ID ，可以通过[搜索部门信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/search)接口获取详情，department_id_type使用people_corehr_department_id类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：7147562782945478177</para>
            /// </summary>
            [JsonPropertyName("department_id")]
            public string? DepartmentId { get; set; }

            /// <summary>
            /// <para>成本中心分摊信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("cost_center_rates")]
            public JobDataCostCenter[]? CostCenterRates { get; set; }

            /// <summary>
            /// <para>成本中心分摊信息</para>
            /// </summary>
            public record JobDataCostCenter
            {
                /// <summary>
                /// <para>成本中心 ID，可以通过[搜索成本中心信息](https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/cost_center/search)接口获取对应的成本中心信息</para>
                /// <para>必填：否</para>
                /// <para>示例值：6950635856373745165</para>
                /// </summary>
                [JsonPropertyName("cost_center_id")]
                public string? CostCenterId { get; set; }

                /// <summary>
                /// <para>分摊比例</para>
                /// <para>必填：否</para>
                /// <para>示例值：100</para>
                /// </summary>
                [JsonPropertyName("rate")]
                public int? Rate { get; set; }
            }

            /// <summary>
            /// <para>办公地点 ID，详细信息可通过[查询地点](https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/location/get)接口获得</para>
            /// <para>必填：否</para>
            /// <para>示例值：6977976687350924832</para>
            /// </summary>
            [JsonPropertyName("office_location_id")]
            public string? OfficeLocationId { get; set; }

            /// <summary>
            /// <para>工作地点id ，可通过[批量查询地点](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)接口获取详情</para>
            /// <para>必填：否</para>
            /// <para>示例值：6977976687350924832</para>
            /// </summary>
            [JsonPropertyName("work_location_id")]
            public string? WorkLocationId { get; set; }

            /// <summary>
            /// <para>工位</para>
            /// <para>必填：否</para>
            /// <para>示例值：ABC123</para>
            /// </summary>
            [JsonPropertyName("work_station")]
            public string? WorkStation { get; set; }

            /// <summary>
            /// <para>工号</para>
            /// <para>必填：否</para>
            /// <para>示例值：1234567</para>
            /// </summary>
            [JsonPropertyName("worker_id")]
            public string? WorkerId { get; set; }

            /// <summary>
            /// <para>薪资类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- custom_api_name：compensation_type</para>
            /// <para>- object_api_name：pre_hire</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("compensation_type")]
            public Enum? CompensationType { get; set; }

            /// <summary>
            /// <para>薪资类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- custom_api_name：compensation_type</para>
            /// <para>- object_api_name：pre_hire</para>
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
            }

            /// <summary>
            /// <para>直属上级雇佣 ID，可以通过[搜索员工信息](https://open.feishu.cn/document/server-docs/corehr-v1/employee/search)接口获取详情，user_id_type使用people_corehr_id类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：7032210902531327521</para>
            /// </summary>
            [JsonPropertyName("direct_leader_id")]
            public string? DirectLeaderId { get; set; }

            /// <summary>
            /// <para>虚线上级雇佣 ID ， 可以通过【搜索员工信息】接口获取</para>
            /// <para>- 功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// <para>必填：否</para>
            /// <para>示例值：7032210902531327521</para>
            /// </summary>
            [JsonPropertyName("dotted_line_manager_id")]
            public string? DottedLineManagerId { get; set; }

            /// <summary>
            /// <para>职务 ID ,可以通过[查询职务](https://open.feishu.cn/document/server-docs/corehr-v1/job-management/job/get)接口获取详情</para>
            /// <para>必填：否</para>
            /// <para>示例值：6977976735715378724</para>
            /// </summary>
            [JsonPropertyName("job_id")]
            public string? JobId { get; set; }

            /// <summary>
            /// <para>序列 ID，可以通过[查询序列](https://open.feishu.cn/document/server-docs/corehr-v1/job-management/job_family/get)接口获取详情</para>
            /// <para>必填：否</para>
            /// <para>示例值：6977972856625939999</para>
            /// </summary>
            [JsonPropertyName("job_family_id")]
            public string? JobFamilyId { get; set; }

            /// <summary>
            /// <para>职级 ID，可以通过[查询职级](https://open.feishu.cn/document/server-docs/corehr-v1/job-management/job_level/get)接口获取详情</para>
            /// <para>必填：否</para>
            /// <para>示例值：6977971894960145950</para>
            /// </summary>
            [JsonPropertyName("job_level_id")]
            public string? JobLevelId { get; set; }

            /// <summary>
            /// <para>职等 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6977971894960145950</para>
            /// </summary>
            [JsonPropertyName("job_grade_id")]
            public string? JobGradeId { get; set; }

            /// <summary>
            /// <para>职务头衔</para>
            /// <para>必填：否</para>
            /// <para>示例值：java</para>
            /// </summary>
            [JsonPropertyName("job_title")]
            public string? JobTitle { get; set; }

            /// <summary>
            /// <para>人员类型 ID ，可以通过招聘[查询人员类型](https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/employee_type/get)接口获取详情</para>
            /// <para>必填：否</para>
            /// <para>示例值：6977973225846343171</para>
            /// </summary>
            [JsonPropertyName("employee_type_id")]
            public string? EmployeeTypeId { get; set; }

            /// <summary>
            /// <para>人员子类型 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6977973225846343171</para>
            /// </summary>
            [JsonPropertyName("employee_subtype_id")]
            public string? EmployeeSubtypeId { get; set; }

            /// <summary>
            /// <para>雇佣类型， 枚举值可查询[获取字段详情](https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- object_api_name = pre_hire</para>
            /// <para>- custom_api_name = employment_type</para>
            /// <para>必填：否</para>
            /// <para>示例值：employee</para>
            /// </summary>
            [JsonPropertyName("employment_type")]
            public string? EmploymentType { get; set; }

            /// <summary>
            /// <para>工作邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：joshua@bytedance.com</para>
            /// </summary>
            [JsonPropertyName("work_email")]
            public string? WorkEmail { get; set; }

            /// <summary>
            /// <para>公司 ID , 详细信息可通过[查询单个公司](https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/company/get)接口获得</para>
            /// <para>必填：否</para>
            /// <para>示例值：6738317738688661772</para>
            /// </summary>
            [JsonPropertyName("company_id")]
            public string? CompanyId { get; set; }

            /// <summary>
            /// <para>社保城市 ID ，详细信息可通过[查询地点](https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/location/get)接口获得</para>
            /// <para>必填：否</para>
            /// <para>示例值：6977973225846343171</para>
            /// </summary>
            [JsonPropertyName("social_security_city_id")]
            public string? SocialSecurityCityId { get; set; }

            /// <summary>
            /// <para>是否包含竞业条款</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("non_compete_covenant")]
            public bool? NonCompeteCovenant { get; set; }

            /// <summary>
            /// <para>周工作时长（单位：小时）</para>
            /// <para>必填：否</para>
            /// <para>示例值：8</para>
            /// </summary>
            [JsonPropertyName("weekly_working_hours")]
            public int? WeeklyWorkingHours { get; set; }

            /// <summary>
            /// <para>是否离职重聘</para>
            /// <para>必填：否</para>
            /// <para>示例值：no</para>
            /// <para>可选值：<list type="bullet">
            /// <item>to_be_confirmed：待确认，系统会判断该员工是否存在历史雇佣记录，如果存在且需要二次确认时会调用失败，并返回历史雇佣记录</item>
            /// <item>no：否，系统直接标为非离职重聘人员，不再做重复判断</item>
            /// <item>yes：是，要求历史雇佣信息 ID 必填</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("rehire")]
            public string? Rehire { get; set; }

            /// <summary>
            /// <para>历史雇佣信息 ID ，雇佣信息详细信息可以通过[查询单个雇佣信息](https://open.feishu.cn/document/server-docs/corehr-v1/employee/employment/get) 获得，系统会检验当前雇佣信息的合法性，要求：</para>
            /// <para>- 雇佣信息为该人员最后一次雇佣记录</para>
            /// <para>- 雇佣信息的雇员状态 = "terminated"</para>
            /// <para>- 该人员不存在其他待入职记录</para>
            /// <para>必填：否</para>
            /// <para>示例值：6977973225846343172</para>
            /// </summary>
            [JsonPropertyName("rehire_employment_id")]
            public string? RehireEmploymentId { get; set; }

            /// <summary>
            /// <para>工时制度 ID ，可通过[查询单个工时制度](https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/working_hours_type/get)接口获取详情</para>
            /// <para>必填：否</para>
            /// <para>示例值：6977973225846343171</para>
            /// </summary>
            [JsonPropertyName("working_hours_type")]
            public string? WorkingHoursType { get; set; }

            /// <summary>
            /// <para>周工作时长v2（单位：小时）浮点类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：8.5</para>
            /// </summary>
            [JsonPropertyName("weekly_working_hours_v2")]
            public float? WeeklyWorkingHoursV2 { get; set; }

            /// <summary>
            /// <para>办公地址</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("office_address")]
            public Address? OfficeAddress { get; set; }

            /// <summary>
            /// <para>办公地址</para>
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
                /// <para>地址 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6989822217869624863</para>
                /// </summary>
                [JsonPropertyName("address_id")]
                public string? AddressId { get; set; }

                /// <summary>
                /// <para>国家 / 地区，可以通过接口[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取详情</para>
                /// <para>必填：是</para>
                /// <para>示例值：6862995757234914824</para>
                /// </summary>
                [JsonPropertyName("country_region_id")]
                public string CountryRegionId { get; set; } = string.Empty;

                /// <summary>
                /// <para>主要行政区ID 可以通过[查询省份/行政区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)接口获取详情</para>
                /// <para>必填：否</para>
                /// <para>示例值：6863326815667095047</para>
                /// </summary>
                [JsonPropertyName("region_id")]
                public string? RegionId { get; set; }

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

                /// <summary>
                /// <para>地址类型，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)地址类型（address_type）枚举定义获得</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("address_type_list")]
                public Enum[] AddressTypeLists { get; set; } = Array.Empty<Enum>();

                /// <summary>
                /// <para>地址类型，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)地址类型（address_type）枚举定义获得</para>
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
                }

                /// <summary>
                /// <para>主要地址</para>
                /// <para>必填：是</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_primary")]
                public bool IsPrimary { get; set; }

                /// <summary>
                /// <para>公开地址</para>
                /// <para>必填：是</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_public")]
                public bool IsPublic { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// </summary>
                public record CustomFieldData
                {
                    /// <summary>
                    /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：name</para>
                    /// </summary>
                    [JsonPropertyName("custom_api_name")]
                    public string CustomApiName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public CustomName? Name { get; set; }

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// </summary>
                    public record CustomName
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：自定义姓名</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Custom Name</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>自定义字段类型</para>
                    /// <para>值类型说明：</para>
                    /// <para>- 1：文本 Text，“文本”和“超链接”属于该类型</para>
                    /// <para>- 2：布尔 Boolean</para>
                    /// <para>- 3：数字 Number</para>
                    /// <para>- 4：枚举 Option，“单选”和“多选”为该类型</para>
                    /// <para>- 5：查找 Lookup，“人员（单选）”、“人员（多选）”和个人信息中的自定义分组为该类型</para>
                    /// <para>- 6：自动编码 Autonumber</para>
                    /// <para>- 7：日期时间 Datetime</para>
                    /// <para>- 8：附件 Attachment，“附件单选”和“附件多选”为该类型</para>
                    /// <para>- 9：图片 Image</para>
                    /// <para>- 10：计算字段 Calculated</para>
                    /// <para>- 11：反向查找 Backlookup</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：\"231\"</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>工作日历ID，可以通过[查询工作日历](https://open.larkoffice.com/document/server-docs/calendar-v4/calendar/get)接口获取详情</para>
            /// <para>必填：否</para>
            /// <para>示例值：6977973225846343173</para>
            /// </summary>
            [JsonPropertyName("working_calendar_id")]
            public string? WorkingCalendarId { get; set; }

            /// <summary>
            /// <para>更新时间，时间格式为 2023-09-01 13:21:12</para>
            /// <para>必填：否</para>
            /// <para>示例值：2023-09-01 13:21:12</para>
            /// </summary>
            [JsonPropertyName("updated_at")]
            public string? UpdatedAt { get; set; }

            /// <summary>
            /// <para>是否疑似重聘</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("suspected_rehiring")]
            public bool? SuspectedRehiring { get; set; }

            /// <summary>
            /// <para>是否外部人员</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("condition_worker")]
            public bool? ConditionWorker { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public CustomFieldData[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record CustomFieldData
            {
                /// <summary>
                /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                /// <para>必填：是</para>
                /// <para>示例值：name</para>
                /// </summary>
                [JsonPropertyName("custom_api_name")]
                public string CustomApiName { get; set; } = string.Empty;

                /// <summary>
                /// <para>自定义字段名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public CustomName? Name { get; set; }

                /// <summary>
                /// <para>自定义字段名称</para>
                /// </summary>
                public record CustomName
                {
                    /// <summary>
                    /// <para>中文</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：自定义姓名</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>英文</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Custom Name</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>自定义字段类型</para>
                /// <para>值类型说明：</para>
                /// <para>- 1：文本 Text，“文本”和“超链接”属于该类型</para>
                /// <para>- 2：布尔 Boolean</para>
                /// <para>- 3：数字 Number</para>
                /// <para>- 4：枚举 Option，“单选”和“多选”为该类型</para>
                /// <para>- 5：查找 Lookup，“人员（单选）”、“人员（多选）”和个人信息中的自定义分组为该类型</para>
                /// <para>- 6：自动编码 Autonumber</para>
                /// <para>- 7：日期时间 Datetime</para>
                /// <para>- 8：附件 Attachment，“附件单选”和“附件多选”为该类型</para>
                /// <para>- 9：图片 Image</para>
                /// <para>- 10：计算字段 Calculated</para>
                /// <para>- 11：反向查找 Backlookup</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("type")]
                public int? Type { get; set; }

                /// <summary>
                /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                /// <para>必填：是</para>
                /// <para>示例值：\"231\"</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>岗位 ID，如需获取具体值，请联系人员档案管理员</para>
            /// <para>必填：否</para>
            /// <para>示例值：6977976735715373452</para>
            /// </summary>
            [JsonPropertyName("position_id")]
            public string? PositionId { get; set; }

            /// <summary>
            /// <para>公司主体是否被手动修改</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("company_manual_updated")]
            public bool? CompanyManualUpdated { get; set; }

            /// <summary>
            /// <para>薪资组信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("pay_group")]
            public PreHirePayGroupInfo? PayGroup { get; set; }

            /// <summary>
            /// <para>薪资组信息</para>
            /// </summary>
            public record PreHirePayGroupInfo
            {
                /// <summary>
                /// <para>薪资组名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n[]? Names { get; set; }

                /// <summary>
                /// <para>薪资组名称</para>
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
                /// <para>薪资组 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：1234566</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }
            }

            /// <summary>
            /// <para>是否信息异常</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("whether_the_information_is_abnormal")]
            public bool? WhetherTheInformationIsAbnormal { get; set; }

            /// <summary>
            /// <para>异常原因列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("abnormal_reason")]
            public PreHireAbnormalReason[]? AbnormalReasons { get; set; }

            /// <summary>
            /// <para>异常原因列表</para>
            /// </summary>
            public record PreHireAbnormalReason
            {
                /// <summary>
                /// <para>异常信息描述</para>
                /// <para>必填：否</para>
                /// <para>最大长度：100</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("descriptions")]
                public I18n[]? Descriptions { get; set; }

                /// <summary>
                /// <para>异常信息描述</para>
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
            }

            /// <summary>
            /// <para>是否有 Offer 薪酬</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("has_offer_salary")]
            public bool? HasOfferSalary { get; set; }

            /// <summary>
            /// <para>招聘项目 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：23214213152</para>
            /// </summary>
            [JsonPropertyName("recruitment_project_id")]
            public string? RecruitmentProjectId { get; set; }

            /// <summary>
            /// <para>排班类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- custom_api_name：work_shift</para>
            /// <para>- object_api_name：pre_hire</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("work_shift")]
            public Enum? WorkShift { get; set; }

            /// <summary>
            /// <para>创建时间，时间格式为 2023-09-01 13:21:12</para>
            /// <para>必填：否</para>
            /// <para>示例值：2023-01-10 10:29</para>
            /// </summary>
            [JsonPropertyName("created_at")]
            public string? CreatedAt { get; set; }

            /// <summary>
            /// <para>待入职信息 创建人，可以通过[批量查询员工信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)接口获取详情，user_id_type使用people_corehr_id类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：69928404442626824</para>
            /// </summary>
            [JsonPropertyName("created_by")]
            public string? CreatedBy { get; set; }

            /// <summary>
            /// <para>待入职信息 更新人，可以通过[批量查询员工信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)接口获取详情，user_id_type使用people_corehr_id类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：69928404442626824</para>
            /// </summary>
            [JsonPropertyName("updated_by")]
            public string? UpdatedBy { get; set; }

            /// <summary>
            /// <para>司龄起算日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2023-01-10</para>
            /// </summary>
            [JsonPropertyName("seniority_date")]
            public string? SeniorityDate { get; set; }

            /// <summary>
            /// <para>背调订单ID</para>
            /// <para>- 功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// <para>必填：否</para>
            /// <para>示例值：123</para>
            /// </summary>
            [JsonPropertyName("background_check_order_id")]
            public string? BackgroundCheckOrderId { get; set; }

            /// <summary>
            /// <para>背调名称</para>
            /// <para>- 功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxx</para>
            /// </summary>
            [JsonPropertyName("background_check_order_name")]
            public string? BackgroundCheckOrderName { get; set; }

            /// <summary>
            /// <para>背调套餐</para>
            /// <para>- 功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxx</para>
            /// </summary>
            [JsonPropertyName("background_check_order_package_name")]
            public string? BackgroundCheckOrderPackageName { get; set; }

            /// <summary>
            /// <para>背调结果</para>
            /// <para>- 功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// <para>必填：否</para>
            /// <para>示例值：通过</para>
            /// </summary>
            [JsonPropertyName("background_check_order_result")]
            public string? BackgroundCheckOrderResult { get; set; }

            /// <summary>
            /// <para>背调供应商</para>
            /// <para>- 功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxx</para>
            /// </summary>
            [JsonPropertyName("background_check_order_supplier_name")]
            public string? BackgroundCheckOrderSupplierName { get; set; }

            /// <summary>
            /// <para>背调账号名称</para>
            /// <para>- 功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxx</para>
            /// </summary>
            [JsonPropertyName("background_check_order_account_name")]
            public string? BackgroundCheckOrderAccountName { get; set; }

            /// <summary>
            /// <para>背调开始时间</para>
            /// <para>- 功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// <para>必填：否</para>
            /// <para>示例值：2023-01-10 10:29</para>
            /// </summary>
            [JsonPropertyName("background_check_order_start_time")]
            public string? BackgroundCheckOrderStartTime { get; set; }

            /// <summary>
            /// <para>背调完成时间</para>
            /// <para>- 功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// <para>必填：否</para>
            /// <para>示例值：2023-01-10 10:29</para>
            /// </summary>
            [JsonPropertyName("background_check_order_complete_time")]
            public string? BackgroundCheckOrderCompleteTime { get; set; }

            /// <summary>
            /// <para>背调状态，枚举值可查询[获取字段详情](https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- object_api_name = pre_hire</para>
            /// <para>- custom_api_name = background_check_order_status</para>
            /// <para>- 功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("background_check_order_status")]
            public Enum? BackgroundCheckOrderStatus { get; set; }

            /// <summary>
            /// <para>司龄调整信息</para>
            /// <para>- 功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("seniority_adjust_information_list")]
            public PrehireSeniorityAdjustInformationQuery[]? SeniorityAdjustInformationLists { get; set; }

            /// <summary>
            /// <para>司龄调整信息</para>
            /// <para>- 功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// </summary>
            public record PrehireSeniorityAdjustInformationQuery
            {
                /// <summary>
                /// <para>调整值</para>
                /// <para>- 精确度：两位小数</para>
                /// <para>- 单位：年</para>
                /// <para>必填：否</para>
                /// <para>示例值：0.5</para>
                /// <para>最大值：100</para>
                /// <para>最小值：0</para>
                /// </summary>
                [JsonPropertyName("seniority_adjustment")]
                public float? SeniorityAdjustment { get; set; }

                /// <summary>
                /// <para>调整类型</para>
                /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
                /// <para>- object_api_name：seniority_adjust_information</para>
                /// <para>- custom_api_name：seniority_adjustment_type</para>
                /// <para>必填：否</para>
                /// <para>示例值：增加</para>
                /// </summary>
                [JsonPropertyName("seniority_adjustment_type")]
                public Enum? SeniorityAdjustmentType { get; set; }

                /// <summary>
                /// <para>调整类型</para>
                /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
                /// <para>- object_api_name：seniority_adjust_information</para>
                /// <para>- custom_api_name：seniority_adjustment_type</para>
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
                }

                /// <summary>
                /// <para>司龄调整原因</para>
                /// <para>必填：否</para>
                /// <para>示例值：工厂停产需要减去半年工龄</para>
                /// </summary>
                [JsonPropertyName("reasons_for_seniority_adjustment")]
                public string? ReasonsForSeniorityAdjustment { get; set; }

                /// <summary>
                /// <para>开始日期</para>
                /// <para>必填：否</para>
                /// <para>示例值：2024-05-19</para>
                /// </summary>
                [JsonPropertyName("start_date")]
                public string? StartDate { get; set; }

                /// <summary>
                /// <para>结束日期</para>
                /// <para>必填：否</para>
                /// <para>示例值：2024-11-18</para>
                /// </summary>
                [JsonPropertyName("end_date")]
                public string? EndDate { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// </summary>
                public record CustomFieldData
                {
                    /// <summary>
                    /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：name</para>
                    /// </summary>
                    [JsonPropertyName("custom_api_name")]
                    public string CustomApiName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public CustomName? Name { get; set; }

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// </summary>
                    public record CustomName
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：自定义姓名</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Custom Name</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>自定义字段类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：\"231\"</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>转正后通知期（主动离职）</para>
            /// <para>- 功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("notice_period_positive_voluntary")]
            public NoticePeriodDetail? NoticePeriodPositiveVoluntary { get; set; }

            /// <summary>
            /// <para>转正后通知期（主动离职）</para>
            /// <para>- 功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// </summary>
            public record NoticePeriodDetail
            {
                /// <summary>
                /// <para>ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：4698019107896524633</para>
                /// </summary>
                [JsonPropertyName("wk_id")]
                public string? WkId { get; set; }

                /// <summary>
                /// <para>数值</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>最大值：65535</para>
                /// <para>最小值：1</para>
                /// </summary>
                [JsonPropertyName("value")]
                public int? Value { get; set; }

                /// <summary>
                /// <para>单位</para>
                /// <para>必填：否</para>
                /// <para>示例值：月</para>
                /// </summary>
                [JsonPropertyName("value_unit")]
                public string? ValueUnit { get; set; }

                /// <summary>
                /// <para>名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

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
            }

            /// <summary>
            /// <para>试用期内通知期（被动离职）</para>
            /// <para>- 功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("notice_period_probation_involuntary")]
            public NoticePeriodDetail? NoticePeriodProbationInvoluntary { get; set; }

            /// <summary>
            /// <para>转正后通知期（被动离职）</para>
            /// <para>- 功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("notice_period_positive_involuntary")]
            public NoticePeriodDetail? NoticePeriodPositiveInvoluntary { get; set; }

            /// <summary>
            /// <para>试用期内通知期（主动离职)</para>
            /// <para>- 功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("notice_period_probation_voluntary")]
            public NoticePeriodDetail? NoticePeriodProbationVoluntary { get; set; }

            /// <summary>
            /// <para>工时制度是否被手动修改</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("working_hours_type_manual_updated")]
            public bool? WorkingHoursTypeManualUpdated { get; set; }

            /// <summary>
            /// <para>入职任务是否逾期</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_over_due")]
            public bool? IsOverDue { get; set; }

            /// <summary>
            /// <para>入职任务是否完成，暂不推荐使用</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("task_completed")]
            public bool? TaskCompleted { get; set; }

            /// <summary>
            /// <para>预计毕业日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2023-01-10</para>
            /// </summary>
            [JsonPropertyName("expected_graduate_date")]
            public string? ExpectedGraduateDate { get; set; }

            /// <summary>
            /// <para>任职公司 ID , 详细信息可通过[查询单个公司](https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/company/get)接口获得</para>
            /// <para>必填：否</para>
            /// <para>示例值：6738317738688661772</para>
            /// </summary>
            [JsonPropertyName("service_company")]
            public string? ServiceCompany { get; set; }
        }

        /// <summary>
        /// <para>入职信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("onboarding_info")]
        public PreHireOnboardingInfo? OnboardingInfo { get; set; }

        /// <summary>
        /// <para>入职信息</para>
        /// </summary>
        public record PreHireOnboardingInfo
        {
            /// <summary>
            /// <para>Offer ID，可以通过招聘[获取 Offer 列表](https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/offer/list)接口获取详情</para>
            /// <para>必填：否</para>
            /// <para>示例值：7032210902531327521</para>
            /// </summary>
            [JsonPropertyName("offer_id")]
            public string? OfferId { get; set; }

            /// <summary>
            /// <para>Offer HR 的 雇佣 ID，可以通过[批量查询员工信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)接口获取详情，user_id_type使用people_corehr_id类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：7032210902531327521</para>
            /// </summary>
            [JsonPropertyName("offer_hr_id")]
            public string? OfferHrId { get; set; }

            /// <summary>
            /// <para>入职方式，枚举值可查询[获取字段详情](https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- object_api_name = pre_hire</para>
            /// <para>- custom_api_name = onboarding_method</para>
            /// <para>必填：否</para>
            /// <para>示例值：onsite</para>
            /// </summary>
            [JsonPropertyName("entry_mode")]
            public string? EntryMode { get; set; }

            /// <summary>
            /// <para>入职日期，时间格式为 2023-09-01</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022-10-08</para>
            /// </summary>
            [JsonPropertyName("onboarding_date")]
            public string? OnboardingDate { get; set; }

            /// <summary>
            /// <para>招聘投递 ID ，详细信息可以通过招聘[获取投递信息](https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/application/get)接口查询获得详情</para>
            /// <para>必填：否</para>
            /// <para>示例值：7140946969586010376</para>
            /// </summary>
            [JsonPropertyName("ats_application_id")]
            public string? AtsApplicationId { get; set; }

            /// <summary>
            /// <para>招聘来源 ，枚举值可查询[获取字段详情](https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- object_api_name = pre_hire</para>
            /// <para>- custom_api_name = recruitment_type</para>
            /// <para>必填：否</para>
            /// <para>示例值：recent_graduates</para>
            /// </summary>
            [JsonPropertyName("recruitment_type")]
            public string? RecruitmentType { get; set; }

            /// <summary>
            /// <para>入职地点 ID，详细信息可通过[查询单个地点](https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/location/get)接口获得</para>
            /// <para>必填：否</para>
            /// <para>示例值：6977976687350924832</para>
            /// </summary>
            [JsonPropertyName("onboarding_location_id")]
            public string? OnboardingLocationId { get; set; }

            /// <summary>
            /// <para>需要公司办理签证</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("company_sponsored_visa")]
            public bool? CompanySponsoredVisa { get; set; }

            /// <summary>
            /// <para>入职状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：preboarding</para>
            /// <para>可选值：<list type="bullet">
            /// <item>preboarding：待入职</item>
            /// <item>deleted：已删除</item>
            /// <item>day_one：准备就绪</item>
            /// <item>withdrawn：已撤销</item>
            /// <item>completed：已完成</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("onboarding_status")]
            public string? OnboardingStatus { get; set; }

            /// <summary>
            /// <para>入职任务列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("onboarding_task_list")]
            public OnboardingTask[]? OnboardingTaskLists { get; set; }

            /// <summary>
            /// <para>入职任务列表</para>
            /// </summary>
            public record OnboardingTask
            {
                /// <summary>
                /// <para>任务名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：task_1</para>
                /// </summary>
                [JsonPropertyName("task_name")]
                public string? TaskName { get; set; }

                /// <summary>
                /// <para>任务状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：task_1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>initiating：发起中</item>
                /// <item>terminated：已终止</item>
                /// <item>exception：异常</item>
                /// <item>in_progress：进行中</item>
                /// <item>not_started：未开始</item>
                /// <item>skipped：已跳过</item>
                /// <item>uninitialized：未初始化</item>
                /// <item>failed：已失败</item>
                /// <item>in_review：审核中</item>
                /// <item>rejected：已退回</item>
                /// <item>completed：已完成</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("task_status")]
                public string? TaskStatus { get; set; }

                /// <summary>
                /// <para>当前操作人雇佣 ID，可以通过[批量查询员工信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)接口获取详情，user_id_type使用people_corehr_id类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：7032210902531327521</para>
                /// </summary>
                [JsonPropertyName("operator_id")]
                public string? OperatorId { get; set; }

                /// <summary>
                /// <para>任务code</para>
                /// <para>必填：否</para>
                /// <para>示例值：task_11</para>
                /// </summary>
                [JsonPropertyName("task_code")]
                public string? TaskCode { get; set; }
            }

            /// <summary>
            /// <para>入职地址</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("onboarding_address")]
            public Address? OnboardingAddress { get; set; }

            /// <summary>
            /// <para>入职地址</para>
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
                /// <para>地址 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6989822217869624863</para>
                /// </summary>
                [JsonPropertyName("address_id")]
                public string? AddressId { get; set; }

                /// <summary>
                /// <para>国家 / 地区，可以通过接口[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取详情</para>
                /// <para>必填：是</para>
                /// <para>示例值：6862995757234914824</para>
                /// </summary>
                [JsonPropertyName("country_region_id")]
                public string CountryRegionId { get; set; } = string.Empty;

                /// <summary>
                /// <para>主要行政区ID 可以通过[查询省份/行政区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)接口获取详情</para>
                /// <para>必填：否</para>
                /// <para>示例值：6863326815667095047</para>
                /// </summary>
                [JsonPropertyName("region_id")]
                public string? RegionId { get; set; }

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

                /// <summary>
                /// <para>地址类型，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)地址类型（address_type）枚举定义获得</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("address_type_list")]
                public Enum[] AddressTypeLists { get; set; } = Array.Empty<Enum>();

                /// <summary>
                /// <para>地址类型，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)地址类型（address_type）枚举定义获得</para>
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
                }

                /// <summary>
                /// <para>主要地址</para>
                /// <para>必填：是</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_primary")]
                public bool IsPrimary { get; set; }

                /// <summary>
                /// <para>公开地址</para>
                /// <para>必填：是</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_public")]
                public bool IsPublic { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// </summary>
                public record CustomFieldData
                {
                    /// <summary>
                    /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：name</para>
                    /// </summary>
                    [JsonPropertyName("custom_api_name")]
                    public string CustomApiName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public CustomName? Name { get; set; }

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// </summary>
                    public record CustomName
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：自定义姓名</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Custom Name</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>自定义字段类型</para>
                    /// <para>值类型说明：</para>
                    /// <para>- 1：文本 Text，“文本”和“超链接”属于该类型</para>
                    /// <para>- 2：布尔 Boolean</para>
                    /// <para>- 3：数字 Number</para>
                    /// <para>- 4：枚举 Option，“单选”和“多选”为该类型</para>
                    /// <para>- 5：查找 Lookup，“人员（单选）”、“人员（多选）”和个人信息中的自定义分组为该类型</para>
                    /// <para>- 6：自动编码 Autonumber</para>
                    /// <para>- 7：日期时间 Datetime</para>
                    /// <para>- 8：附件 Attachment，“附件单选”和“附件多选”为该类型</para>
                    /// <para>- 9：图片 Image</para>
                    /// <para>- 10：计算字段 Calculated</para>
                    /// <para>- 11：反向查找 Backlookup</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：\"231\"</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>入职流程</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("flow_name")]
            public I18n[]? FlowNames { get; set; }

            /// <summary>
            /// <para>入职流程</para>
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
            /// <para>入职流程 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：2342352325</para>
            /// </summary>
            [JsonPropertyName("flow_id")]
            public string? FlowId { get; set; }

            /// <summary>
            /// <para>签到时间，时间格式为 2023-09-01 13:21:12</para>
            /// <para>必填：否</para>
            /// <para>示例值：2023-09-01 13:21:12</para>
            /// </summary>
            [JsonPropertyName("check_in_time")]
            public string? CheckInTime { get; set; }

            /// <summary>
            /// <para>招聘来源，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- custom_api_name：check_in_method</para>
            /// <para>- object_api_name：pre_hire</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("check_in_method")]
            public Enum? CheckInMethod { get; set; }

            /// <summary>
            /// <para>招聘来源，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- custom_api_name：check_in_method</para>
            /// <para>- object_api_name：pre_hire</para>
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
            }
        }

        /// <summary>
        /// <para>试用期信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("probation_info")]
        public PreHireProbationInfo? ProbationInfo { get; set; }

        /// <summary>
        /// <para>试用期信息</para>
        /// </summary>
        public record PreHireProbationInfo
        {
            /// <summary>
            /// <para>试用期开始日期，时间格式为 2023-09-01</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022-07-29</para>
            /// </summary>
            [JsonPropertyName("probation_start_date")]
            public string? ProbationStartDate { get; set; }

            /// <summary>
            /// <para>试用期结束日期，时间格式为 2023-09-01</para>
            /// <para>必填：否</para>
            /// <para>示例值：2023-04-07</para>
            /// </summary>
            [JsonPropertyName("probation_end_date")]
            public string? ProbationEndDate { get; set; }

            /// <summary>
            /// <para>试用期时长（单位：天）</para>
            /// <para>必填：否</para>
            /// <para>示例值：6</para>
            /// </summary>
            [JsonPropertyName("probation_period")]
            public int? ProbationPeriod { get; set; }
        }

        /// <summary>
        /// <para>合同信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("contract_info")]
        public PreHireContractInfo? ContractInfo { get; set; }

        /// <summary>
        /// <para>合同信息</para>
        /// </summary>
        public record PreHireContractInfo
        {
            /// <summary>
            /// <para>合同开始日期，时间格式为 2023-09-01</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022-10-08</para>
            /// </summary>
            [JsonPropertyName("contract_start_date")]
            public string? ContractStartDate { get; set; }

            /// <summary>
            /// <para>合同结束日期，时间格式为 2023-09-01</para>
            /// <para>必填：否</para>
            /// <para>示例值：2025-10-07</para>
            /// </summary>
            [JsonPropertyName("contract_end_date")]
            public string? ContractEndDate { get; set; }

            /// <summary>
            /// <para>合同类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- object_api_name = pre_hire</para>
            /// <para>- custom_api_name = contract_type</para>
            /// <para>必填：否</para>
            /// <para>示例值：labor_contract</para>
            /// </summary>
            [JsonPropertyName("contract_type")]
            public string? ContractType { get; set; }

            /// <summary>
            /// <para>期限类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- object_api_name = pre_hire</para>
            /// <para>- custom_api_name = duration_type</para>
            /// <para>必填：否</para>
            /// <para>示例值：fixed_term</para>
            /// </summary>
            [JsonPropertyName("duration_type")]
            public string? DurationType { get; set; }

            /// <summary>
            /// <para>签订类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- object_api_name = pre_hire</para>
            /// <para>- custom_api_name = signing_type</para>
            /// <para>必填：否</para>
            /// <para>示例值：renewed</para>
            /// </summary>
            [JsonPropertyName("signing_type")]
            public string? SigningType { get; set; }
        }

        /// <summary>
        /// <para>待入职 id</para>
        /// <para>必填：否</para>
        /// <para>示例值：7032210902531327521</para>
        /// </summary>
        [JsonPropertyName("pre_hire_id")]
        public string? PreHireId { get; set; }
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
