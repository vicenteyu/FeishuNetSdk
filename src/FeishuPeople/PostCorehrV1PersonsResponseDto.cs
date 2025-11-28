// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV1PersonsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建个人信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 创建个人信息 响应体
/// <para>创建人员的个人信息。</para>
/// <para>接口ID：7017707615190827011</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/person/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fperson%2fcreate</para>
/// </summary>
public record PostCorehrV1PersonsResponseDto
{
    /// <summary>
    /// <para>创建成功返回Person信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("person")]
    public PostCorehrV1PersonsResponseDtoPerson? Person { get; set; }

    /// <summary>
    /// <para>创建成功返回Person信息</para>
    /// </summary>
    public record PostCorehrV1PersonsResponseDtoPerson
    {
        /// <summary>
        /// <para>个人手机号</para>
        /// <para>必填：否</para>
        /// <para>示例值：11111111111</para>
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
        /// <para>展示中英文混合名，示例值：张三(Zhang San)</para>
        /// <para>必填：否</para>
        /// <para>示例值：张四</para>
        /// </summary>
        [JsonPropertyName("preferred_name")]
        public string? PreferredName { get; set; }

        /// <summary>
        /// <para>Person ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：646465654545</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>姓名</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name_list")]
        public PersonName[] NameLists { get; set; } = [];

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
            /// <para>国家 / 地区</para>
            /// <para>必填：是</para>
            /// <para>示例值：6862995757234914824</para>
            /// </summary>
            [JsonPropertyName("country_region_id")]
            public string CountryRegionId { get; set; } = string.Empty;

            /// <summary>
            /// <para>姓名类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)姓名类型（name_type）枚举定义部分获得</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("name_type")]
            public Enum NameType { get; set; } = new();

            /// <summary>
            /// <para>姓名类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)姓名类型（name_type）枚举定义部分获得</para>
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
            /// <para>补充姓名类型，比如emergency_contact_name（紧急联系人姓名）</para>
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
            /// <para>示例值：刘梓新</para>
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
            /// <para>尊称</para>
            /// <para>必填：否</para>
            /// <para>示例值：刘梓新</para>
            /// </summary>
            [JsonPropertyName("social")]
            public Enum? Social { get; set; }

            /// <summary>
            /// <para>婚后姓氏</para>
            /// <para>必填：否</para>
            /// <para>示例值：王</para>
            /// </summary>
            [JsonPropertyName("tertiary")]
            public string? Tertiary { get; set; }

            /// <summary>
            /// <para>头衔，比如</para>
            /// <para>Mr.</para>
            /// <para>Miss.</para>
            /// <para>Mrs.</para>
            /// <para>Prof.</para>
            /// <para>Dr.</para>
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
            /// <para>展示姓名（本地和西方文字），按照如下规则自动计算得到</para>
            /// <para>- 中国（包括中国香港、中国澳门、中国台湾）姓名，默认取 custom_local_name 字段的值，如果为空则取 custom_name 的值</para>
            /// <para>- 非中国姓名，根据该国家/地区的规则自动将 local_primary、local_first_name、name_primary、first_name 等字段拼接在一起</para>
            /// <para>必填：否</para>
            /// <para>示例值：刘梓新</para>
            /// </summary>
            [JsonPropertyName("display_name_local_and_western_script")]
            public string? DisplayNameLocalAndWesternScript { get; set; }

            /// <summary>
            /// <para>展示姓名（本地文字），按照如下规则自动计算得到</para>
            /// <para>- 中国（包括中国香港、中国澳门、中国台湾）姓名，默认取 custom_local_name 字段的值</para>
            /// <para>- 非中国姓名，根据该国家/地区的规则自动将 local_primary、local_first_name 等字段拼接在一起</para>
            /// <para>必填：否</para>
            /// <para>示例值：刘梓新</para>
            /// </summary>
            [JsonPropertyName("display_name_local_script")]
            public string? DisplayNameLocalScript { get; set; }

            /// <summary>
            /// <para>展示姓名（西方文字），按照如下规则自动计算得到</para>
            /// <para>- 中国（包括中国香港、中国澳门、中国台湾）姓名，默认取 custom_name 字段的值</para>
            /// <para>- 非中国姓名，根据该国家/地区的规则自动将 name_primary、first_name 等字段拼接在一起</para>
            /// <para>必填：否</para>
            /// <para>示例值：刘梓新</para>
            /// </summary>
            [JsonPropertyName("display_name_western_script")]
            public string? DisplayNameWesternScript { get; set; }

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
        }

        /// <summary>
        /// <para>性别，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)性别（gender）枚举定义部分获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("gender")]
        public Enum? Gender { get; set; }

        /// <summary>
        /// <para>性别，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)性别（gender）枚举定义部分获得</para>
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
        /// <para>出生日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-01-01</para>
        /// </summary>
        [JsonPropertyName("date_of_birth")]
        public string? DateOfBirth { get; set; }

        /// <summary>
        /// <para>国籍id</para>
        /// <para>必填：否</para>
        /// <para>示例值：123456789</para>
        /// </summary>
        [JsonPropertyName("nationality_id")]
        public string? NationalityId { get; set; }

        /// <summary>
        /// <para>民族 / 种族，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)民族（race）枚举定义部分获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("race")]
        public Enum? Race { get; set; }

        /// <summary>
        /// <para>婚姻状况，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)婚姻状况（marital_status）枚举定义部分获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("marital_status")]
        public Enum? MaritalStatus { get; set; }

        /// <summary>
        /// <para>电话列表，只有当满足下面所有条件时，电话在个人信息页才可见:</para>
        /// <para>- 电话号码不为空</para>
        /// <para>- is_primary = "true"</para>
        /// <para>- phone_usage = "home"</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("phone_list")]
        public Phone[]? PhoneLists { get; set; }

        /// <summary>
        /// <para>电话列表，只有当满足下面所有条件时，电话在个人信息页才可见:</para>
        /// <para>- 电话号码不为空</para>
        /// <para>- is_primary = "true"</para>
        /// <para>- phone_usage = "home"</para>
        /// </summary>
        public record Phone
        {
            /// <summary>
            /// <para>国家区号</para>
            /// <para>常见如：86_china（中国）、852_hong_kong（中国香港）、886_taiwan（中国台湾）、853_macao（中国澳门）、1_united_states_of_america（美利坚合众国）、7_russian_federation（俄罗斯联邦）、44_united_kingdom（英国）、81_japan（日本）、82_korea_republic_of（大韩民国）、91_india（印度）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("international_area_code")]
            public Enum? InternationalAreaCode { get; set; }

            /// <summary>
            /// <para>国家区号</para>
            /// <para>常见如：86_china（中国）、852_hong_kong（中国香港）、886_taiwan（中国台湾）、853_macao（中国澳门）、1_united_states_of_america（美利坚合众国）、7_russian_federation（俄罗斯联邦）、44_united_kingdom（英国）、81_japan（日本）、82_korea_republic_of（大韩民国）、91_india（印度）</para>
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
            /// <para>设备类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)设备类型（device_type）枚举定义部分获得</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("device_type")]
            public Enum? DeviceType { get; set; }

            /// <summary>
            /// <para>电话用途，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)电话用途（phone_usage）枚举定义部分获得</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("phone_usage")]
            public Enum? PhoneUsage { get; set; }

            /// <summary>
            /// <para>是否为主要电话</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_primary")]
            public bool? IsPrimary { get; set; }

            /// <summary>
            /// <para>是否为公开电话</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_public")]
            public bool? IsPublic { get; set; }

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
            /// <para>地址ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6989822217869624863</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>国家 / 地区</para>
            /// <para>必填：是</para>
            /// <para>示例值：6862995757234914824</para>
            /// </summary>
            [JsonPropertyName("country_region_id")]
            public string CountryRegionId { get; set; } = string.Empty;

            /// <summary>
            /// <para>主要行政区</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863326815667095047</para>
            /// </summary>
            [JsonPropertyName("region_id")]
            public string? RegionId { get; set; }

            /// <summary>
            /// <para>城市</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863333254578046471</para>
            /// </summary>
            [JsonPropertyName("city_id")]
            public string? CityId { get; set; }

            /// <summary>
            /// <para>区/县</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863333516579440141</para>
            /// </summary>
            [JsonPropertyName("distinct_id")]
            public string? DistinctId { get; set; }

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
            /// <para>邮箱号</para>
            /// <para>必填：是</para>
            /// <para>示例值：12456@test.com</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string EmailSuffix { get; set; } = string.Empty;

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
        }

        /// <summary>
        /// <para>工作履历列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("work_experience_list")]
        public WorkExperience[]? WorkExperienceLists { get; set; }

        /// <summary>
        /// <para>工作履历列表</para>
        /// </summary>
        public record WorkExperience
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
            /// <para>开始日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-01-01</para>
            /// </summary>
            [JsonPropertyName("start_date")]
            public string? StartDate { get; set; }

            /// <summary>
            /// <para>结束日期</para>
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
            public I18n[] Schools { get; set; } = [];

            /// <summary>
            /// <para>学校</para>
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
            /// <para>学历，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)学历（level_of_education）枚举定义获得</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("level_of_education")]
            public Enum? LevelOfEducation { get; set; }

            /// <summary>
            /// <para>学历，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)学历（level_of_education）枚举定义获得</para>
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
            /// <para>开始日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2011-09-01</para>
            /// </summary>
            [JsonPropertyName("start_date")]
            public string? StartDate { get; set; }

            /// <summary>
            /// <para>结束日期</para>
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
            /// <para>学位，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)学位（degree）枚举定义获得</para>
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
        }

        /// <summary>
        /// <para>银行账号</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("bank_account_list")]
        public BankAccount[]? BankAccountLists { get; set; }

        /// <summary>
        /// <para>银行账号</para>
        /// </summary>
        public record BankAccount
        {
            /// <summary>
            /// <para>银行名称，如果已经填入银行枚举，该字段可为空。如果要填写数据不在系统提供的枚举范围内，该字段存储自定义银行名称</para>
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
            /// <para>银行枚举，常见的银行枚举如：bank-5（交通银行）、bank-6（中国银行）、bank-7（中国建设银行）、bank-8（中国农业银行）、bank-9（中国工商银行）、bank-10（中国邮政储蓄银行）、bank-11（中国光大银行）、bank-12（中国民生银行）、bank-13（招商银行）、bank-14（中信银行）、bank-15（华夏银行）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("bank")]
            public Enum? Bank { get; set; }

            /// <summary>
            /// <para>银行枚举，常见的银行枚举如：bank-5（交通银行）、bank-6（中国银行）、bank-7（中国建设银行）、bank-8（中国农业银行）、bank-9（中国工商银行）、bank-10（中国邮政储蓄银行）、bank-11（中国光大银行）、bank-12（中国民生银行）、bank-13（招商银行）、bank-14（中信银行）、bank-15（华夏银行）</para>
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
            /// <para>支行名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：中国农业银行支行</para>
            /// </summary>
            [JsonPropertyName("branch_name")]
            public string? BranchName { get; set; }

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
            /// <para>国家/地区id，详细信息可通过【查询国家/地区信息】接口查询获得</para>
            /// <para>必填：否</para>
            /// <para>示例值：12</para>
            /// </summary>
            [JsonPropertyName("country_region_id")]
            public string? CountryRegionId { get; set; }

            /// <summary>
            /// <para>银行卡用途，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)银行卡用途（bank_account_usage）枚举定义部分获得</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("bank_account_usage")]
            public Enum[]? BankAccountUsages { get; set; }

            /// <summary>
            /// <para>银行卡类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)银行卡类型（bank_account_type）枚举定义部分获得</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("bank_account_type")]
            public Enum? BankAccountType { get; set; }

            /// <summary>
            /// <para>货币id</para>
            /// <para>必填：否</para>
            /// <para>示例值：12QueryCountryRegionSubdivisionDataReq</para>
            /// </summary>
            [JsonPropertyName("currency_id")]
            public string? CurrencyId { get; set; }
        }

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
            /// <para>国家证件类型，枚举值可通过【批量查询国家证件类型】接口获取</para>
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
            /// <para>国家 / 地区</para>
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
        }

        /// <summary>
        /// <para>亲属列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("dependent_list")]
        public Dependent[]? DependentLists { get; set; }

        /// <summary>
        /// <para>亲属列表</para>
        /// </summary>
        public record Dependent
        {
            /// <summary>
            /// <para>亲属姓名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public PersonName? Name { get; set; }

            /// <summary>
            /// <para>亲属姓名</para>
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
                /// <para>国家 / 地区</para>
                /// <para>必填：是</para>
                /// <para>示例值：6862995757234914824</para>
                /// </summary>
                [JsonPropertyName("country_region_id")]
                public string CountryRegionId { get; set; } = string.Empty;

                /// <summary>
                /// <para>姓名类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)姓名类型（name_type）枚举定义部分获得</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("name_type")]
                public Enum NameType { get; set; } = new();

                /// <summary>
                /// <para>姓名类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)姓名类型（name_type）枚举定义部分获得</para>
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
                /// <para>补充姓名类型，比如emergency_contact_name（紧急联系人姓名）</para>
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
                /// <para>示例值：刘梓新</para>
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
                /// <para>自定义姓名</para>
                /// <para>必填：否</para>
                /// <para>示例值：刘梓新</para>
                /// </summary>
                [JsonPropertyName("custom_name")]
                public string? CustomName { get; set; }

                /// <summary>
                /// <para>本地文字的自定义姓名</para>
                /// <para>必填：否</para>
                /// <para>示例值：刘梓新</para>
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
                /// <para>尊称</para>
                /// <para>必填：否</para>
                /// <para>示例值：刘梓新</para>
                /// </summary>
                [JsonPropertyName("social")]
                public Enum? Social { get; set; }

                /// <summary>
                /// <para>婚后姓氏</para>
                /// <para>必填：否</para>
                /// <para>示例值：王</para>
                /// </summary>
                [JsonPropertyName("tertiary")]
                public string? Tertiary { get; set; }

                /// <summary>
                /// <para>头衔，比如</para>
                /// <para>Mr.</para>
                /// <para>Miss.</para>
                /// <para>Mrs.</para>
                /// <para>Prof.</para>
                /// <para>Dr.</para>
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
                /// <para>展示姓名（本地和西方文字），按照如下规则自动计算得到</para>
                /// <para>- 中国（包括中国香港、中国澳门、中国台湾）姓名，默认取 custom_local_name 字段的值，如果为空则取 custom_name 的值</para>
                /// <para>- 非中国姓名，根据该国家/地区的规则自动将 local_primary、local_first_name、name_primary、first_name 等字段拼接在一起</para>
                /// <para>必填：否</para>
                /// <para>示例值：刘梓新</para>
                /// </summary>
                [JsonPropertyName("display_name_local_and_western_script")]
                public string? DisplayNameLocalAndWesternScript { get; set; }

                /// <summary>
                /// <para>展示姓名（本地文字），按照如下规则自动计算得到</para>
                /// <para>- 中国（包括中国香港、中国澳门、中国台湾）姓名，默认取 custom_local_name 字段的值</para>
                /// <para>- 非中国姓名，根据该国家/地区的规则自动将 local_primary、local_first_name 等字段拼接在一起</para>
                /// <para>必填：否</para>
                /// <para>示例值：刘梓新</para>
                /// </summary>
                [JsonPropertyName("display_name_local_script")]
                public string? DisplayNameLocalScript { get; set; }

                /// <summary>
                /// <para>展示姓名（西方文字），按照如下规则自动计算得到</para>
                /// <para>- 中国（包括中国香港、中国澳门、中国台湾）姓名，默认取 custom_name 字段的值</para>
                /// <para>- 非中国姓名，根据该国家/地区的规则自动将 name_primary、first_name 等字段拼接在一起</para>
                /// <para>必填：否</para>
                /// <para>示例值：刘梓新</para>
                /// </summary>
                [JsonPropertyName("display_name_western_script")]
                public string? DisplayNameWesternScript { get; set; }

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
            }

            /// <summary>
            /// <para>亲属关系，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)亲属关系（relationship）枚举定义获得</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("relationship")]
            public Enum Relationship { get; set; } = new();

            /// <summary>
            /// <para>亲属关系，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)亲属关系（relationship）枚举定义获得</para>
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
            /// <para>亲属性别，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)性别（gender）枚举定义部分获得</para>
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
            /// <para>国籍</para>
            /// <para>必填：否</para>
            /// <para>示例值：7075702734054164011</para>
            /// </summary>
            [JsonPropertyName("nationality_id")]
            public string? NationalityId { get; set; }

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
                /// <para>国家证件类型，枚举值可通过【批量查询国家证件类型】接口获取</para>
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
                /// <para>国家 / 地区</para>
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
            }

            /// <summary>
            /// <para>配偶工作状态，比如working（在岗）、not_working（不在岗）</para>
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
                /// <para>国家区号</para>
                /// <para>常见如：86_china（中国）、852_hong_kong（中国香港）、886_taiwan（中国台湾）、853_macao（中国澳门）、1_united_states_of_america（美利坚合众国）、7_russian_federation（俄罗斯联邦）、44_united_kingdom（英国）、81_japan（日本）、82_korea_republic_of（大韩民国）、91_india（印度）</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("international_area_code")]
                public Enum? InternationalAreaCode { get; set; }

                /// <summary>
                /// <para>国家区号</para>
                /// <para>常见如：86_china（中国）、852_hong_kong（中国香港）、886_taiwan（中国台湾）、853_macao（中国澳门）、1_united_states_of_america（美利坚合众国）、7_russian_federation（俄罗斯联邦）、44_united_kingdom（英国）、81_japan（日本）、82_korea_republic_of（大韩民国）、91_india（印度）</para>
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
                /// <para>地址ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6989822217869624863</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>国家 / 地区</para>
                /// <para>必填：是</para>
                /// <para>示例值：6862995757234914824</para>
                /// </summary>
                [JsonPropertyName("country_region_id")]
                public string CountryRegionId { get; set; } = string.Empty;

                /// <summary>
                /// <para>主要行政区</para>
                /// <para>必填：否</para>
                /// <para>示例值：6863326815667095047</para>
                /// </summary>
                [JsonPropertyName("region_id")]
                public string? RegionId { get; set; }

                /// <summary>
                /// <para>城市</para>
                /// <para>必填：否</para>
                /// <para>示例值：6863333254578046471</para>
                /// </summary>
                [JsonPropertyName("city_id")]
                public string? CityId { get; set; }

                /// <summary>
                /// <para>区/县</para>
                /// <para>必填：否</para>
                /// <para>示例值：6863333516579440141</para>
                /// </summary>
                [JsonPropertyName("distinct_id")]
                public string? DistinctId { get; set; }

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
                /// <para>地址行 1（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：丹佛测试地址-纽埃时区</para>
                /// </summary>
                [JsonPropertyName("local_address_line3")]
                public string? LocalAddressLine3 { get; set; }

                /// <summary>
                /// <para>地址行 2（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：PoewH</para>
                /// </summary>
                [JsonPropertyName("local_address_line4")]
                public string? LocalAddressLine4 { get; set; }

                /// <summary>
                /// <para>地址行 3（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：PoewH</para>
                /// </summary>
                [JsonPropertyName("local_address_line5")]
                public string? LocalAddressLine5 { get; set; }

                /// <summary>
                /// <para>地址行 4（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("local_address_line6")]
                public string? LocalAddressLine6 { get; set; }

                /// <summary>
                /// <para>地址行 5（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("local_address_line7")]
                public string? LocalAddressLine7 { get; set; }

                /// <summary>
                /// <para>地址行 6（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("local_address_line8")]
                public string? LocalAddressLine8 { get; set; }

                /// <summary>
                /// <para>地址行 7（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("local_address_line9")]
                public string? LocalAddressLine9 { get; set; }

                /// <summary>
                /// <para>地址行 8（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：rafSu</para>
                /// </summary>
                [JsonPropertyName("postal_code")]
                public string? PostalCode { get; set; }

                /// <summary>
                /// <para>地址行 9（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：McPRG</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public ObjectFieldData[]? CustomFields { get; set; }

                /// <summary>
                /// <para>地址行 9（非拉丁语系的本地文字）</para>
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
            /// <para>紧急联系人姓名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public PersonName? Name { get; set; }

            /// <summary>
            /// <para>紧急联系人姓名</para>
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
                /// <para>国家 / 地区</para>
                /// <para>必填：是</para>
                /// <para>示例值：6862995757234914824</para>
                /// </summary>
                [JsonPropertyName("country_region_id")]
                public string CountryRegionId { get; set; } = string.Empty;

                /// <summary>
                /// <para>姓名类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)姓名类型（name_type）枚举定义部分获得</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("name_type")]
                public Enum NameType { get; set; } = new();

                /// <summary>
                /// <para>姓名类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)姓名类型（name_type）枚举定义部分获得</para>
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
                /// <para>补充姓名类型，比如emergency_contact_name（紧急联系人姓名）</para>
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
                /// <para>示例值：刘梓新</para>
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
                /// <para>自定义姓名</para>
                /// <para>必填：否</para>
                /// <para>示例值：刘梓新</para>
                /// </summary>
                [JsonPropertyName("custom_name")]
                public string? CustomName { get; set; }

                /// <summary>
                /// <para>本地文字的自定义姓名</para>
                /// <para>必填：否</para>
                /// <para>示例值：刘梓新</para>
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
                /// <para>尊称</para>
                /// <para>必填：否</para>
                /// <para>示例值：刘梓新</para>
                /// </summary>
                [JsonPropertyName("social")]
                public Enum? Social { get; set; }

                /// <summary>
                /// <para>婚后姓氏</para>
                /// <para>必填：否</para>
                /// <para>示例值：王</para>
                /// </summary>
                [JsonPropertyName("tertiary")]
                public string? Tertiary { get; set; }

                /// <summary>
                /// <para>头衔，比如</para>
                /// <para>Mr.</para>
                /// <para>Miss.</para>
                /// <para>Mrs.</para>
                /// <para>Prof.</para>
                /// <para>Dr.</para>
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
                /// <para>展示姓名（本地和西方文字），按照如下规则自动计算得到</para>
                /// <para>- 中国（包括中国香港、中国澳门、中国台湾）姓名，默认取 custom_local_name 字段的值，如果为空则取 custom_name 的值</para>
                /// <para>- 非中国姓名，根据该国家/地区的规则自动将 local_primary、local_first_name、name_primary、first_name 等字段拼接在一起</para>
                /// <para>必填：否</para>
                /// <para>示例值：刘梓新</para>
                /// </summary>
                [JsonPropertyName("display_name_local_and_western_script")]
                public string? DisplayNameLocalAndWesternScript { get; set; }

                /// <summary>
                /// <para>展示姓名（本地文字），按照如下规则自动计算得到</para>
                /// <para>- 中国（包括中国香港、中国澳门、中国台湾）姓名，默认取 custom_local_name 字段的值</para>
                /// <para>- 非中国姓名，根据该国家/地区的规则自动将 local_primary、local_first_name 等字段拼接在一起</para>
                /// <para>必填：否</para>
                /// <para>示例值：刘梓新</para>
                /// </summary>
                [JsonPropertyName("display_name_local_script")]
                public string? DisplayNameLocalScript { get; set; }

                /// <summary>
                /// <para>展示姓名（西方文字），按照如下规则自动计算得到</para>
                /// <para>- 中国（包括中国香港、中国澳门、中国台湾）姓名，默认取 custom_name 字段的值</para>
                /// <para>- 非中国姓名，根据该国家/地区的规则自动将 name_primary、first_name 等字段拼接在一起</para>
                /// <para>必填：否</para>
                /// <para>示例值：刘梓新</para>
                /// </summary>
                [JsonPropertyName("display_name_western_script")]
                public string? DisplayNameWesternScript { get; set; }

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
            }

            /// <summary>
            /// <para>紧急联系人与本人亲属关系，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)亲属关系（relationship）枚举定义获得</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("relationship")]
            public Enum? Relationship { get; set; }

            /// <summary>
            /// <para>紧急联系人与本人亲属关系，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)亲属关系（relationship）枚举定义获得</para>
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
            /// <para>紧急联系人电话</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("phone_ist")]
            public Phone[]? PhoneIsts { get; set; }

            /// <summary>
            /// <para>紧急联系人电话</para>
            /// </summary>
            public record Phone
            {
                /// <summary>
                /// <para>国家区号</para>
                /// <para>常见如：86_china（中国）、852_hong_kong（中国香港）、886_taiwan（中国台湾）、853_macao（中国澳门）、1_united_states_of_america（美利坚合众国）、7_russian_federation（俄罗斯联邦）、44_united_kingdom（英国）、81_japan（日本）、82_korea_republic_of（大韩民国）、91_india（印度）</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("international_area_code")]
                public Enum? InternationalAreaCode { get; set; }

                /// <summary>
                /// <para>国家区号</para>
                /// <para>常见如：86_china（中国）、852_hong_kong（中国香港）、886_taiwan（中国台湾）、853_macao（中国澳门）、1_united_states_of_america（美利坚合众国）、7_russian_federation（俄罗斯联邦）、44_united_kingdom（英国）、81_japan（日本）、82_korea_republic_of（大韩民国）、91_india（印度）</para>
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
                /// <para>电话号码</para>
                /// <para>必填：是</para>
                /// <para>示例值：010-12345678</para>
                /// </summary>
                [JsonPropertyName("phone_number")]
                public string PhoneNumber { get; set; } = string.Empty;

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
            }

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
            /// <para>法定姓名</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("legal_name")]
            public string? LegalName { get; set; }
        }

        /// <summary>
        /// <para>参加工作日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-10-01</para>
        /// </summary>
        [JsonPropertyName("date_entered_workforce")]
        public string? DateEnteredWorkforce { get; set; }

        /// <summary>
        /// <para>头像资源的 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：dfysuc8x76dsfsw</para>
        /// </summary>
        [JsonPropertyName("profile_image_id")]
        public string? ProfileImageId { get; set; }

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
        /// <para>邮箱</para>
        /// <para>必填：否</para>
        /// <para>示例值：test@163.com</para>
        /// </summary>
        [JsonPropertyName("email_address")]
        public string? EmailAddress { get; set; }

        /// <summary>
        /// <para>纳税身份信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：["1", "2"]</para>
        /// </summary>
        [JsonPropertyName("resident_tax_id_list")]
        public string[]? ResidentTaxIdList { get; set; }

        /// <summary>
        /// <para>年龄</para>
        /// <para>必填：否</para>
        /// <para>示例值：25</para>
        /// </summary>
        [JsonPropertyName("age")]
        public int? Age { get; set; }

        /// <summary>
        /// <para>最高学历教育</para>
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
        /// <para>个人资料</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("personal_profile")]
        public PersonalProfile[]? PersonalProfiles { get; set; }

        /// <summary>
        /// <para>个人资料</para>
        /// </summary>
        public record PersonalProfile
        {
            /// <summary>
            /// <para>个人资料 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：150018109586e8ea745e47ae8feb3722dbe1d03a181336393633393133303431393831343930373235150200</para>
            /// </summary>
            [JsonPropertyName("personal_profile_id")]
            public string? PersonalProfileId { get; set; }

            /// <summary>
            /// <para>个人资料类型，比如</para>
            /// <para>银行储蓄卡复印件、证件照、个人信息采集表、生活照</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("personal_profile_type")]
            public Enum? PersonalProfileType { get; set; }

            /// <summary>
            /// <para>个人资料类型，比如</para>
            /// <para>银行储蓄卡复印件、证件照、个人信息采集表、生活照</para>
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
            /// <para>上传文件列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("files")]
            public File[]? Files { get; set; }

            /// <summary>
            /// <para>上传文件列表</para>
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
            }
        }
    }
}
