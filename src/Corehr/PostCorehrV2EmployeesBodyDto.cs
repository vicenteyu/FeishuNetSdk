// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2EmployeesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加人员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 添加人员 请求体
/// <para>支持在单个接口中进行人员全信息添加，包括人员基本信息，雇佣信息，任职记录及其他分组信息</para>
/// <para>接口ID：7350663854198161410</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployee%2fcreate</para>
/// </summary>
public record PostCorehrV2EmployeesBodyDto
{
    /// <summary>
    /// <para>个人信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("personal_info")]
    public ProfileSettingPersonalInfo? PersonalInfo { get; set; }

    /// <summary>
    /// <para>个人信息</para>
    /// </summary>
    public record ProfileSettingPersonalInfo
    {
        /// <summary>
        /// <para>基本信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("personal_basic_info")]
        public ProfileSettingPersonalBasicInfo? PersonalBasicInfo { get; set; }

        /// <summary>
        /// <para>基本信息</para>
        /// </summary>
        public record ProfileSettingPersonalBasicInfo
        {
            /// <summary>
            /// <para>法定姓名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("legal_name")]
            public ProfileSettingName? LegalName { get; set; }

            /// <summary>
            /// <para>法定姓名</para>
            /// </summary>
            public record ProfileSettingName
            {
                /// <summary>
                /// <para>补充姓名类型</para>
                /// <para>枚举值可以通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
                /// <para>- object_api_name = "person_name"</para>
                /// <para>- custom_api_name = "additional_name_type"</para>
                /// <para>必填：否</para>
                /// <para>示例值：emergency_contact_name</para>
                /// </summary>
                [JsonPropertyName("additional_name_type")]
                public string? AdditionalNameType { get; set; }

                /// <summary>
                /// <para>国家 / 地区 ID</para>
                /// <para>可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口获取</para>
                /// <para>必填：否</para>
                /// <para>示例值：6862995757234914824</para>
                /// </summary>
                [JsonPropertyName("country_region")]
                public string? CountryRegion { get; set; }

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
                /// <para>中间名</para>
                /// <para>必填：否</para>
                /// <para>示例值：大</para>
                /// </summary>
                [JsonPropertyName("middle_name")]
                public string? MiddleName { get; set; }

                /// <summary>
                /// <para>第二姓氏</para>
                /// <para>必填：否</para>
                /// <para>示例值：王</para>
                /// </summary>
                [JsonPropertyName("secondary")]
                public string? Secondary { get; set; }

                /// <summary>
                /// <para>尊称</para>
                /// <para>枚举值可以通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
                /// <para>- object_api_name = "person_name"</para>
                /// <para>- custom_api_name = "social"</para>
                /// <para>必填：否</para>
                /// <para>示例值：ii</para>
                /// </summary>
                [JsonPropertyName("social")]
                public string? Social { get; set; }

                /// <summary>
                /// <para>婚后姓氏</para>
                /// <para>必填：否</para>
                /// <para>示例值：王</para>
                /// </summary>
                [JsonPropertyName("tertiary")]
                public string? Tertiary { get; set; }

                /// <summary>
                /// <para>名 - 第二本地文字</para>
                /// <para>必填：否</para>
                /// <para>示例值：五</para>
                /// </summary>
                [JsonPropertyName("local_first_name_2")]
                public string? LocalFirstName2 { get; set; }

                /// <summary>
                /// <para>本地中间名</para>
                /// <para>必填：否</para>
                /// <para>示例值：大</para>
                /// </summary>
                [JsonPropertyName("local_middle_name")]
                public string? LocalMiddleName { get; set; }

                /// <summary>
                /// <para>姓 - 本地文字</para>
                /// <para>必填：否</para>
                /// <para>示例值：黄</para>
                /// </summary>
                [JsonPropertyName("local_primary")]
                public string? LocalPrimary { get; set; }

                /// <summary>
                /// <para>姓 - 第二本地文字</para>
                /// <para>必填：否</para>
                /// <para>示例值：王</para>
                /// </summary>
                [JsonPropertyName("local_primary_2")]
                public string? LocalPrimary2 { get; set; }

                /// <summary>
                /// <para>第二姓氏 - 本地文字</para>
                /// <para>必填：否</para>
                /// <para>示例值：王</para>
                /// </summary>
                [JsonPropertyName("local_secondary")]
                public string? LocalSecondary { get; set; }

                /// <summary>
                /// <para>头衔</para>
                /// <para>枚举值可以通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
                /// <para>- object_api_name = "person_name"</para>
                /// <para>- custom_api_name = "title"</para>
                /// <para>必填：否</para>
                /// <para>示例值：Mr</para>
                /// </summary>
                [JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// <para>名 - 本地文字</para>
                /// <para>必填：否</para>
                /// <para>示例值：四</para>
                /// </summary>
                [JsonPropertyName("local_first_name")]
                public string? LocalFirstName { get; set; }

                /// <summary>
                /// <para>自定义姓名（本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：王大帅</para>
                /// </summary>
                [JsonPropertyName("custom_local_name")]
                public string? CustomLocalName { get; set; }

                /// <summary>
                /// <para>自定义姓名（西方文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：王大帅</para>
                /// </summary>
                [JsonPropertyName("custom_western_name")]
                public string? CustomWesternName { get; set; }

                /// <summary>
                /// <para>姓名类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：legal_name</para>
                /// </summary>
                [JsonPropertyName("name_type")]
                public string? NameType { get; set; }

                /// <summary>
                /// <para>名</para>
                /// <para>必填：否</para>
                /// <para>示例值：帅</para>
                /// </summary>
                [JsonPropertyName("first_name")]
                public string? FirstName { get; set; }

                /// <summary>
                /// <para>姓</para>
                /// <para>必填：否</para>
                /// <para>示例值：王</para>
                /// </summary>
                [JsonPropertyName("name_primary")]
                public string? NamePrimary { get; set; }
            }

            /// <summary>
            /// <para>常用姓名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("preferred_name")]
            public ProfileSettingName? PreferredName { get; set; }

            /// <summary>
            /// <para>性别</para>
            /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name = "person"</para>
            /// <para>- custom_api_name = "gender"</para>
            /// <para>必填：否</para>
            /// <para>示例值：female</para>
            /// </summary>
            [JsonPropertyName("gender")]
            public string? Gender { get; set; }

            /// <summary>
            /// <para>国籍 ID</para>
            /// <para>可通过[【查询国籍信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-nationality/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6862995757234914826</para>
            /// </summary>
            [JsonPropertyName("nationality_v2")]
            public string? NationalityV2 { get; set; }

            /// <summary>
            /// <para>民族 / 种族</para>
            /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name = "person"</para>
            /// <para>- custom_api_name = "ethnicity_race"</para>
            /// <para>必填：否</para>
            /// <para>示例值：han</para>
            /// </summary>
            [JsonPropertyName("ethnicity_race")]
            public string? EthnicityRace { get; set; }

            /// <summary>
            /// <para>个人电话</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("phone")]
            public ProfileSettingPhone? Phone { get; set; }

            /// <summary>
            /// <para>个人电话</para>
            /// </summary>
            public record ProfileSettingPhone
            {
                /// <summary>
                /// <para>国际电话区号</para>
                /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
                /// <para>- object_api_name = "phone"</para>
                /// <para>- custom_api_name = "international_area_code"</para>
                /// <para>必填：否</para>
                /// <para>示例值：86_china</para>
                /// </summary>
                [JsonPropertyName("international_area_code")]
                public string? InternationalAreaCode { get; set; }

                /// <summary>
                /// <para>电话号码</para>
                /// <para>必填：否</para>
                /// <para>示例值：13000000000</para>
                /// </summary>
                [JsonPropertyName("phone_number")]
                public string? PhoneNumber { get; set; }
            }

            /// <summary>
            /// <para>个人邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：1234567@example.feishu.cn</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string? Email { get; set; }

            /// <summary>
            /// <para>出生日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2006-01-02</para>
            /// </summary>
            [JsonPropertyName("date_of_birth")]
            public string? DateOfBirth { get; set; }

            /// <summary>
            /// <para>婚姻状况</para>
            /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name = "person"</para>
            /// <para>- custom_api_name = "marital_status"</para>
            /// <para>必填：否</para>
            /// <para>示例值：married</para>
            /// </summary>
            [JsonPropertyName("marital_status")]
            public string? MaritalStatus { get; set; }

            /// <summary>
            /// <para>是否残疾</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_disabled")]
            public bool? IsDisabled { get; set; }

            /// <summary>
            /// <para>残疾证号</para>
            /// <para>is_disabled 为 true 时必填</para>
            /// <para>必填：否</para>
            /// <para>示例值：92838277746172888312</para>
            /// </summary>
            [JsonPropertyName("disable_card_number")]
            public string? DisableCardNumber { get; set; }

            /// <summary>
            /// <para>是否为烈属</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_martyr_family")]
            public bool? IsMartyrFamily { get; set; }

            /// <summary>
            /// <para>烈属证号</para>
            /// <para>is_martyr_family 为 true 时必填</para>
            /// <para>必填：否</para>
            /// <para>示例值：00001</para>
            /// </summary>
            [JsonPropertyName("martyr_card_number")]
            public string? MartyrCardNumber { get; set; }

            /// <summary>
            /// <para>是否为孤老</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_old_alone")]
            public bool? IsOldAlone { get; set; }

            /// <summary>
            /// <para>出生国家/地区</para>
            /// <para>必填：否</para>
            /// <para>示例值：6862995757234914825</para>
            /// </summary>
            [JsonPropertyName("born_country_region")]
            public string? BornCountryRegion { get; set; }

            /// <summary>
            /// <para>政治面貌</para>
            /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name = "person_info_chn"</para>
            /// <para>- custom_api_name = "political_affiliation"</para>
            /// <para>必填：否</para>
            /// <para>示例值：other</para>
            /// </summary>
            [JsonPropertyName("political_affiliation")]
            public string? PoliticalAffiliation { get; set; }

            /// <summary>
            /// <para>籍贯（省份/行政区 ID）</para>
            /// <para>可通过[【查询省份/行政区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6862995757234914827</para>
            /// </summary>
            [JsonPropertyName("native_region")]
            public string? NativeRegion { get; set; }

            /// <summary>
            /// <para>参加工作日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2006-01-02</para>
            /// </summary>
            [JsonPropertyName("date_entered_workforce")]
            public string? DateEnteredWorkforce { get; set; }

            /// <summary>
            /// <para>首次入境日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2006-01-02</para>
            /// </summary>
            [JsonPropertyName("first_entry_time")]
            public string? FirstEntryTime { get; set; }

            /// <summary>
            /// <para>预计离境日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2006-01-02</para>
            /// </summary>
            [JsonPropertyName("leave_time")]
            public string? LeaveTime { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public ProfileSettingCustomField[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record ProfileSettingCustomField
            {
                /// <summary>
                /// <para>字段名</para>
                /// <para>必填：是</para>
                /// <para>示例值：custom_field_1__c</para>
                /// </summary>
                [JsonPropertyName("field_name")]
                public string FieldName { get; set; } = string.Empty;

                /// <summary>
                /// <para>字段值</para>
                /// <para>是 JSON 转义后的字符串，根据元数据定义不同，字段格式不同。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
                /// <para>必填：否</para>
                /// <para>示例值：123</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }
        }

        /// <summary>
        /// <para>紧急联系人</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("emergency_contacts")]
        public ProfileSettingEmergencyContact[]? EmergencyContacts { get; set; }

        /// <summary>
        /// <para>紧急联系人</para>
        /// </summary>
        public record ProfileSettingEmergencyContact
        {
            /// <summary>
            /// <para>姓名</para>
            /// <para>必填：否</para>
            /// <para>示例值：王大帅</para>
            /// </summary>
            [JsonPropertyName("legal_name")]
            public string? LegalName { get; set; }

            /// <summary>
            /// <para>关系</para>
            /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name = "emergency_contract"</para>
            /// <para>- custom_api_name = "relationship"</para>
            /// <para>必填：否</para>
            /// <para>示例值：parent</para>
            /// </summary>
            [JsonPropertyName("relationship")]
            public string? Relationship { get; set; }

            /// <summary>
            /// <para>主要联系人</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_primary")]
            public bool? IsPrimary { get; set; }

            /// <summary>
            /// <para>电话</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("phone")]
            public ProfileSettingPhone? Phone { get; set; }

            /// <summary>
            /// <para>电话</para>
            /// </summary>
            public record ProfileSettingPhone
            {
                /// <summary>
                /// <para>国际电话区号</para>
                /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
                /// <para>- object_api_name = "phone"</para>
                /// <para>- custom_api_name = "international_area_code"</para>
                /// <para>必填：否</para>
                /// <para>示例值：86_china</para>
                /// </summary>
                [JsonPropertyName("international_area_code")]
                public string? InternationalAreaCode { get; set; }

                /// <summary>
                /// <para>电话号码</para>
                /// <para>必填：否</para>
                /// <para>示例值：13000000000</para>
                /// </summary>
                [JsonPropertyName("phone_number")]
                public string? PhoneNumber { get; set; }
            }

            /// <summary>
            /// <para>邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：1234567@example.feishu.cn</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string? Email { get; set; }

            /// <summary>
            /// <para>地址</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("address")]
            public ProfileSettingAddress? Address { get; set; }

            /// <summary>
            /// <para>地址</para>
            /// </summary>
            public record ProfileSettingAddress
            {
                /// <summary>
                /// <para>地址类型</para>
                /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
                /// <para>- object_api_name = "address"</para>
                /// <para>- custom_api_name = "address_type"</para>
                /// <para>必填：否</para>
                /// <para>示例值：home_address</para>
                /// </summary>
                [JsonPropertyName("address_type")]
                public string? AddressType { get; set; }

                /// <summary>
                /// <para>国家 / 地区 ID</para>
                /// <para>可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口获取</para>
                /// <para>必填：否</para>
                /// <para>示例值：6862995757234914824</para>
                /// </summary>
                [JsonPropertyName("country_region")]
                public string? CountryRegion { get; set; }

                /// <summary>
                /// <para>主要行政区 ID</para>
                /// <para>可通过[【查询省份/行政区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)接口获取</para>
                /// <para>必填：否</para>
                /// <para>示例值：6863326815667095047</para>
                /// </summary>
                [JsonPropertyName("region")]
                public string? Region { get; set; }

                /// <summary>
                /// <para>主要行政区往下细分 1 层的行政区</para>
                /// <para>必填：否</para>
                /// <para>示例值：行政区1</para>
                /// </summary>
                [JsonPropertyName("region_subdivision_1")]
                public string? RegionSubdivision1 { get; set; }

                /// <summary>
                /// <para>主要行政区往下细分 2 层的行政区</para>
                /// <para>必填：否</para>
                /// <para>示例值：行政区2</para>
                /// </summary>
                [JsonPropertyName("region_subdivision_2")]
                public string? RegionSubdivision2 { get; set; }

                /// <summary>
                /// <para>城市V2 ID</para>
                /// <para>可通过[【查询城市信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-city/search)接口获取</para>
                /// <para>必填：否</para>
                /// <para>示例值：6862995757234914829</para>
                /// </summary>
                [JsonPropertyName("city_v2")]
                public string? CityV2 { get; set; }

                /// <summary>
                /// <para>城市（文本）</para>
                /// <para>必填：否</para>
                /// <para>示例值：北京市</para>
                /// </summary>
                [JsonPropertyName("city_text")]
                public string? CityText { get; set; }

                /// <summary>
                /// <para>城市（仅文本，非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：北京市</para>
                /// </summary>
                [JsonPropertyName("local_city_text")]
                public string? LocalCityText { get; set; }

                /// <summary>
                /// <para>城市往下细分 1 层的行政区</para>
                /// <para>必填：否</para>
                /// <para>示例值：行政区 1</para>
                /// </summary>
                [JsonPropertyName("city_subdivision_1")]
                public string? CitySubdivision1 { get; set; }

                /// <summary>
                /// <para>城市往下细分 2 层的行政区</para>
                /// <para>必填：否</para>
                /// <para>示例值：行政区 2</para>
                /// </summary>
                [JsonPropertyName("city_subdivision_2")]
                public string? CitySubdivision2 { get; set; }

                /// <summary>
                /// <para>区/县 V2 ID</para>
                /// <para>可通过[【查询区/县信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-district/search)接口获取</para>
                /// <para>必填：否</para>
                /// <para>示例值：6862995757234914831</para>
                /// </summary>
                [JsonPropertyName("district_v2")]
                public string? DistrictV2 { get; set; }

                /// <summary>
                /// <para>邮政编码</para>
                /// <para>必填：否</para>
                /// <para>示例值：611530</para>
                /// </summary>
                [JsonPropertyName("postal_code")]
                public string? PostalCode { get; set; }

                /// <summary>
                /// <para>地址行 1</para>
                /// <para>必填：否</para>
                /// <para>示例值：丹佛测试地址 - 纽埃时区</para>
                /// </summary>
                [JsonPropertyName("address_line_1")]
                public string? AddressLine1 { get; set; }

                /// <summary>
                /// <para>地址行 1（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：丹佛测试地址 - 纽埃时区</para>
                /// </summary>
                [JsonPropertyName("local_address_line_1")]
                public string? LocalAddressLine1 { get; set; }

                /// <summary>
                /// <para>地址行 2</para>
                /// <para>必填：否</para>
                /// <para>示例值：PoewH</para>
                /// </summary>
                [JsonPropertyName("address_line_2")]
                public string? AddressLine2 { get; set; }

                /// <summary>
                /// <para>地址行 2（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：PoewH</para>
                /// </summary>
                [JsonPropertyName("local_address_line_2")]
                public string? LocalAddressLine2 { get; set; }

                /// <summary>
                /// <para>地址行 3</para>
                /// <para>必填：否</para>
                /// <para>示例值：PoewH</para>
                /// </summary>
                [JsonPropertyName("address_line_3")]
                public string? AddressLine3 { get; set; }

                /// <summary>
                /// <para>地址行 3（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：PoewH</para>
                /// </summary>
                [JsonPropertyName("local_address_line_3")]
                public string? LocalAddressLine3 { get; set; }

                /// <summary>
                /// <para>地址行 4</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("address_line_4")]
                public string? AddressLine4 { get; set; }

                /// <summary>
                /// <para>地址行 5（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("local_address_line_5")]
                public string? LocalAddressLine5 { get; set; }

                /// <summary>
                /// <para>地址行 6</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("address_line_6")]
                public string? AddressLine6 { get; set; }

                /// <summary>
                /// <para>地址行 6（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("local_address_line_6")]
                public string? LocalAddressLine6 { get; set; }

                /// <summary>
                /// <para>地址行 7</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("address_line_7")]
                public string? AddressLine7 { get; set; }

                /// <summary>
                /// <para>地址行 7（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("local_address_line_7")]
                public string? LocalAddressLine7 { get; set; }

                /// <summary>
                /// <para>地址行 8</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("address_line_8")]
                public string? AddressLine8 { get; set; }

                /// <summary>
                /// <para>地址行 8（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：rafSu</para>
                /// </summary>
                [JsonPropertyName("local_address_line_8")]
                public string? LocalAddressLine8 { get; set; }

                /// <summary>
                /// <para>地址行 9</para>
                /// <para>必填：否</para>
                /// <para>示例值：McPRG</para>
                /// </summary>
                [JsonPropertyName("address_line_9")]
                public string? AddressLine9 { get; set; }

                /// <summary>
                /// <para>地址行 9（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：McPRG</para>
                /// </summary>
                [JsonPropertyName("local_address_line_9")]
                public string? LocalAddressLine9 { get; set; }

                /// <summary>
                /// <para>地址行 4（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("local_address_line_4")]
                public string? LocalAddressLine4 { get; set; }

                /// <summary>
                /// <para>地址行 5</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("address_line_5")]
                public string? AddressLine5 { get; set; }
            }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public ProfileSettingCustomField[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record ProfileSettingCustomField
            {
                /// <summary>
                /// <para>字段名</para>
                /// <para>必填：是</para>
                /// <para>示例值：custom_field_1__c</para>
                /// </summary>
                [JsonPropertyName("field_name")]
                public string FieldName { get; set; } = string.Empty;

                /// <summary>
                /// <para>字段值</para>
                /// <para>是 JSON 转义后的字符串，根据元数据定义不同，字段格式不同。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
                /// <para>必填：否</para>
                /// <para>示例值：123</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }
        }

        /// <summary>
        /// <para>银行账户</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("bank_accounts")]
        public ProfileSettingBankAccount[]? BankAccounts { get; set; }

        /// <summary>
        /// <para>银行账户</para>
        /// </summary>
        public record ProfileSettingBankAccount
        {
            /// <summary>
            /// <para>国家 / 地区 ID</para>
            /// <para>可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6862995757234914824</para>
            /// </summary>
            [JsonPropertyName("country_region")]
            public string? CountryRegion { get; set; }

            /// <summary>
            /// <para>银行名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：中国农业银行</para>
            /// </summary>
            [JsonPropertyName("bank_name")]
            public string? BankName { get; set; }

            /// <summary>
            /// <para>支行名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：中国农业银行支行</para>
            /// </summary>
            [JsonPropertyName("branch_name")]
            public string? BranchName { get; set; }

            /// <summary>
            /// <para>开户人姓名</para>
            /// <para>必填：否</para>
            /// <para>示例值：孟十五</para>
            /// </summary>
            [JsonPropertyName("account_holder")]
            public string? AccountHolder { get; set; }

            /// <summary>
            /// <para>银行账号</para>
            /// <para>必填：否</para>
            /// <para>示例值：6231200000001223</para>
            /// </summary>
            [JsonPropertyName("bank_account_number")]
            public string? BankAccountNumber { get; set; }

            /// <summary>
            /// <para>银行卡用途</para>
            /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name = "bank_account"</para>
            /// <para>- custom_api_name = "bank_account_usage"</para>
            /// <para>必填：否</para>
            /// <para>示例值：payment</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("bank_account_usages")]
            public string[]? BankAccountUsages { get; set; }

            /// <summary>
            /// <para>银行卡类型</para>
            /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name = "bank_account"</para>
            /// <para>- custom_api_name = "bank_account_type"</para>
            /// <para>必填：否</para>
            /// <para>示例值：savings</para>
            /// </summary>
            [JsonPropertyName("bank_account_type")]
            public string? BankAccountType { get; set; }

            /// <summary>
            /// <para>银行 ID</para>
            /// <para>可通过[【查询银行信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-bank/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6862995757234914832</para>
            /// </summary>
            [JsonPropertyName("bank_id")]
            public string? BankId { get; set; }

            /// <summary>
            /// <para>银行支行 ID</para>
            /// <para>可通过[【查询支行信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-bank_branch/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6862995757234914833</para>
            /// </summary>
            [JsonPropertyName("branch_id")]
            public string? BranchId { get; set; }
        }

        /// <summary>
        /// <para>证件</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("nationals")]
        public ProfileSettingNational[]? Nationals { get; set; }

        /// <summary>
        /// <para>证件</para>
        /// </summary>
        public record ProfileSettingNational
        {
            /// <summary>
            /// <para>国家 / 地区 ID</para>
            /// <para>可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6862995757234914824</para>
            /// </summary>
            [JsonPropertyName("country_region")]
            public string? CountryRegion { get; set; }

            /// <summary>
            /// <para>国家证件类型 ID</para>
            /// <para>可通过[【批量查询国家证件类型】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/national_id_type/list)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863330041896371725</para>
            /// </summary>
            [JsonPropertyName("national_id_type")]
            public string? NationalIdType { get; set; }

            /// <summary>
            /// <para>证件号码</para>
            /// <para>必填：否</para>
            /// <para>示例值：1231131333</para>
            /// </summary>
            [JsonPropertyName("national_id_number")]
            public string? NationalIdNumber { get; set; }

            /// <summary>
            /// <para>证件签发日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-04-01</para>
            /// </summary>
            [JsonPropertyName("issued_date")]
            public string? IssuedDate { get; set; }

            /// <summary>
            /// <para>证件签发机构</para>
            /// <para>必填：否</para>
            /// <para>示例值：北京市公安局</para>
            /// </summary>
            [JsonPropertyName("issued_by")]
            public string? IssuedBy { get; set; }

            /// <summary>
            /// <para>证件到期日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-05-21</para>
            /// </summary>
            [JsonPropertyName("expiration_date")]
            public string? ExpirationDate { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public ProfileSettingCustomField[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record ProfileSettingCustomField
            {
                /// <summary>
                /// <para>字段名</para>
                /// <para>必填：是</para>
                /// <para>示例值：custom_field_1__c</para>
                /// </summary>
                [JsonPropertyName("field_name")]
                public string FieldName { get; set; } = string.Empty;

                /// <summary>
                /// <para>字段值</para>
                /// <para>是 JSON 转义后的字符串，根据元数据定义不同，字段格式不同。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
                /// <para>必填：否</para>
                /// <para>示例值：123</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }
        }

        /// <summary>
        /// <para>居民身份信息</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("resident_taxes")]
        public ProfileSettingResidentTax[]? ResidentTaxes { get; set; }

        /// <summary>
        /// <para>居民身份信息</para>
        /// </summary>
        public record ProfileSettingResidentTax
        {
            /// <summary>
            /// <para>年度</para>
            /// <para>必填：否</para>
            /// <para>示例值：2006-01-02</para>
            /// </summary>
            [JsonPropertyName("year_resident_tax")]
            public string? YearResidentTax { get; set; }

            /// <summary>
            /// <para>国家 / 地区 ID</para>
            /// <para>可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6862995757234914824</para>
            /// </summary>
            [JsonPropertyName("tax_country_region")]
            public string? TaxCountryRegion { get; set; }

            /// <summary>
            /// <para>居民身份</para>
            /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name = "resident_tax"</para>
            /// <para>- custom_api_name = "resident_status"</para>
            /// <para>必填：否</para>
            /// <para>示例值：tax_residence</para>
            /// </summary>
            [JsonPropertyName("resident_status")]
            public string? ResidentStatus { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public ProfileSettingCustomField[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record ProfileSettingCustomField
            {
                /// <summary>
                /// <para>字段名</para>
                /// <para>必填：是</para>
                /// <para>示例值：custom_field_1__c</para>
                /// </summary>
                [JsonPropertyName("field_name")]
                public string FieldName { get; set; } = string.Empty;

                /// <summary>
                /// <para>字段值</para>
                /// <para>是 JSON 转义后的字符串，根据元数据定义不同，字段格式不同。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
                /// <para>必填：否</para>
                /// <para>示例值：123</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }
        }

        /// <summary>
        /// <para>家庭成员</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("dependents")]
        public ProfileSettingDependent[]? Dependents { get; set; }

        /// <summary>
        /// <para>家庭成员</para>
        /// </summary>
        public record ProfileSettingDependent
        {
            /// <summary>
            /// <para>姓名</para>
            /// <para>必填：否</para>
            /// <para>示例值：王大帅</para>
            /// </summary>
            [JsonPropertyName("legal_name")]
            public string? LegalName { get; set; }

            /// <summary>
            /// <para>生日</para>
            /// <para>必填：否</para>
            /// <para>示例值：2006-01-02</para>
            /// </summary>
            [JsonPropertyName("date_of_birth")]
            public string? DateOfBirth { get; set; }

            /// <summary>
            /// <para>关系</para>
            /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name = "dependent"</para>
            /// <para>- custom_api_name ="relationship_with_dependent"</para>
            /// <para>必填：否</para>
            /// <para>示例值：parent</para>
            /// </summary>
            [JsonPropertyName("relationship_with_dependent")]
            public string? RelationshipWithDependent { get; set; }

            /// <summary>
            /// <para>性别</para>
            /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name = "dependent"</para>
            /// <para>- custom_api_name = "gender"</para>
            /// <para>必填：否</para>
            /// <para>示例值：female</para>
            /// </summary>
            [JsonPropertyName("gender")]
            public string? Gender { get; set; }

            /// <summary>
            /// <para>电话</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("phone")]
            public ProfileSettingPhone? Phone { get; set; }

            /// <summary>
            /// <para>电话</para>
            /// </summary>
            public record ProfileSettingPhone
            {
                /// <summary>
                /// <para>国际电话区号</para>
                /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
                /// <para>- object_api_name = "phone"</para>
                /// <para>- custom_api_name = "international_area_code"</para>
                /// <para>必填：否</para>
                /// <para>示例值：86_china</para>
                /// </summary>
                [JsonPropertyName("international_area_code")]
                public string? InternationalAreaCode { get; set; }

                /// <summary>
                /// <para>电话号码</para>
                /// <para>必填：否</para>
                /// <para>示例值：13000000000</para>
                /// </summary>
                [JsonPropertyName("phone_number")]
                public string? PhoneNumber { get; set; }
            }

            /// <summary>
            /// <para>岗位</para>
            /// <para>必填：否</para>
            /// <para>示例值：岗位</para>
            /// </summary>
            [JsonPropertyName("job")]
            public string? Job { get; set; }

            /// <summary>
            /// <para>出生证明</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("child_birth_certificates")]
            public ProfileSettingFile[]? ChildBirthCertificates { get; set; }

            /// <summary>
            /// <para>出生证明</para>
            /// </summary>
            public record ProfileSettingFile
            {
                /// <summary>
                /// <para>文件 ID</para>
                /// <para>可通过[【上传文件】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/person/upload)接口获取</para>
                /// <para>必填：否</para>
                /// <para>示例值：150018109586e8ea745e47ae8feb3722dbe1d03a181336393633393133303431393831343930373235150200</para>
                /// </summary>
                [JsonPropertyName("file_id")]
                public string? FileId { get; set; }

                /// <summary>
                /// <para>文件 MIME 类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：zip</para>
                /// </summary>
                [JsonPropertyName("mime_type")]
                public string? MimeType { get; set; }

                /// <summary>
                /// <para>文件名</para>
                /// <para>必填：否</para>
                /// <para>示例值：附件.zip</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// <para>文件大小（KB）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1000</para>
                /// </summary>
                [JsonPropertyName("size")]
                public string? Size { get; set; }

                /// <summary>
                /// <para>文件 Token</para>
                /// <para>必填：否</para>
                /// <para>示例值：0a423bc7ea7c4a439d066bf070616782</para>
                /// </summary>
                [JsonPropertyName("token")]
                public string? Token { get; set; }
            }

            /// <summary>
            /// <para>工作单位</para>
            /// <para>必填：否</para>
            /// <para>示例值：飞书</para>
            /// </summary>
            [JsonPropertyName("employer")]
            public string? Employer { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public ProfileSettingCustomField[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record ProfileSettingCustomField
            {
                /// <summary>
                /// <para>字段名</para>
                /// <para>必填：是</para>
                /// <para>示例值：custom_field_1__c</para>
                /// </summary>
                [JsonPropertyName("field_name")]
                public string FieldName { get; set; } = string.Empty;

                /// <summary>
                /// <para>字段值</para>
                /// <para>是 JSON 转义后的字符串，根据元数据定义不同，字段格式不同。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
                /// <para>必填：否</para>
                /// <para>示例值：123</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }

            /// <summary>
            /// <para>联系地址</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("address")]
            public ProfileSettingAddress? Address { get; set; }

            /// <summary>
            /// <para>联系地址</para>
            /// </summary>
            public record ProfileSettingAddress
            {
                /// <summary>
                /// <para>地址类型</para>
                /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
                /// <para>- object_api_name = "address"</para>
                /// <para>- custom_api_name = "address_type"</para>
                /// <para>必填：否</para>
                /// <para>示例值：home_address</para>
                /// </summary>
                [JsonPropertyName("address_type")]
                public string? AddressType { get; set; }

                /// <summary>
                /// <para>国家 / 地区 ID</para>
                /// <para>可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口获取</para>
                /// <para>必填：否</para>
                /// <para>示例值：6862995757234914824</para>
                /// </summary>
                [JsonPropertyName("country_region")]
                public string? CountryRegion { get; set; }

                /// <summary>
                /// <para>主要行政区 ID</para>
                /// <para>可通过[【查询省份/行政区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)接口获取</para>
                /// <para>必填：否</para>
                /// <para>示例值：6863326815667095047</para>
                /// </summary>
                [JsonPropertyName("region")]
                public string? Region { get; set; }

                /// <summary>
                /// <para>主要行政区往下细分 1 层的行政区</para>
                /// <para>必填：否</para>
                /// <para>示例值：行政区 1</para>
                /// </summary>
                [JsonPropertyName("region_subdivision_1")]
                public string? RegionSubdivision1 { get; set; }

                /// <summary>
                /// <para>主要行政区往下细分 2 层的行政区</para>
                /// <para>必填：否</para>
                /// <para>示例值：行政区 2</para>
                /// </summary>
                [JsonPropertyName("region_subdivision_2")]
                public string? RegionSubdivision2 { get; set; }

                /// <summary>
                /// <para>城市 V2 ID</para>
                /// <para>可通过[【查询城市信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-city/search)接口获取</para>
                /// <para>必填：否</para>
                /// <para>示例值：6862995757234914829</para>
                /// </summary>
                [JsonPropertyName("city_v2")]
                public string? CityV2 { get; set; }

                /// <summary>
                /// <para>城市（文本）</para>
                /// <para>必填：否</para>
                /// <para>示例值：北京市</para>
                /// </summary>
                [JsonPropertyName("city_text")]
                public string? CityText { get; set; }

                /// <summary>
                /// <para>城市（仅文本，非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：北京市</para>
                /// </summary>
                [JsonPropertyName("local_city_text")]
                public string? LocalCityText { get; set; }

                /// <summary>
                /// <para>城市往下细分 1 层的行政区</para>
                /// <para>必填：否</para>
                /// <para>示例值：行政区 1</para>
                /// </summary>
                [JsonPropertyName("city_subdivision_1")]
                public string? CitySubdivision1 { get; set; }

                /// <summary>
                /// <para>城市往下细分 2 层的行政区</para>
                /// <para>必填：否</para>
                /// <para>示例值：行政区 2</para>
                /// </summary>
                [JsonPropertyName("city_subdivision_2")]
                public string? CitySubdivision2 { get; set; }

                /// <summary>
                /// <para>区/县 V2 ID</para>
                /// <para>可通过[【查询区/县信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-district/search)接口获取</para>
                /// <para>必填：否</para>
                /// <para>示例值：6862995757234914831</para>
                /// </summary>
                [JsonPropertyName("district_v2")]
                public string? DistrictV2 { get; set; }

                /// <summary>
                /// <para>邮政编码</para>
                /// <para>必填：否</para>
                /// <para>示例值：611530</para>
                /// </summary>
                [JsonPropertyName("postal_code")]
                public string? PostalCode { get; set; }

                /// <summary>
                /// <para>地址行 1</para>
                /// <para>必填：否</para>
                /// <para>示例值：丹佛测试地址 - 纽埃时区</para>
                /// </summary>
                [JsonPropertyName("address_line_1")]
                public string? AddressLine1 { get; set; }

                /// <summary>
                /// <para>地址行 1（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：丹佛测试地址 - 纽埃时区</para>
                /// </summary>
                [JsonPropertyName("local_address_line_1")]
                public string? LocalAddressLine1 { get; set; }

                /// <summary>
                /// <para>地址行 2</para>
                /// <para>必填：否</para>
                /// <para>示例值：PoewH</para>
                /// </summary>
                [JsonPropertyName("address_line_2")]
                public string? AddressLine2 { get; set; }

                /// <summary>
                /// <para>地址行 2（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：PoewH</para>
                /// </summary>
                [JsonPropertyName("local_address_line_2")]
                public string? LocalAddressLine2 { get; set; }

                /// <summary>
                /// <para>地址行 3</para>
                /// <para>必填：否</para>
                /// <para>示例值：PoewH</para>
                /// </summary>
                [JsonPropertyName("address_line_3")]
                public string? AddressLine3 { get; set; }

                /// <summary>
                /// <para>地址行 3（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：PoewH</para>
                /// </summary>
                [JsonPropertyName("local_address_line_3")]
                public string? LocalAddressLine3 { get; set; }

                /// <summary>
                /// <para>地址行 4</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("address_line_4")]
                public string? AddressLine4 { get; set; }

                /// <summary>
                /// <para>地址行 5（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("local_address_line_5")]
                public string? LocalAddressLine5 { get; set; }

                /// <summary>
                /// <para>地址行 6</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("address_line_6")]
                public string? AddressLine6 { get; set; }

                /// <summary>
                /// <para>地址行 6（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("local_address_line_6")]
                public string? LocalAddressLine6 { get; set; }

                /// <summary>
                /// <para>地址行 7</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("address_line_7")]
                public string? AddressLine7 { get; set; }

                /// <summary>
                /// <para>地址行 7（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("local_address_line_7")]
                public string? LocalAddressLine7 { get; set; }

                /// <summary>
                /// <para>地址行 8</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("address_line_8")]
                public string? AddressLine8 { get; set; }

                /// <summary>
                /// <para>地址行 8（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：rafSu</para>
                /// </summary>
                [JsonPropertyName("local_address_line_8")]
                public string? LocalAddressLine8 { get; set; }

                /// <summary>
                /// <para>地址行 9</para>
                /// <para>必填：否</para>
                /// <para>示例值：McPRG</para>
                /// </summary>
                [JsonPropertyName("address_line_9")]
                public string? AddressLine9 { get; set; }

                /// <summary>
                /// <para>地址行 9（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：McPRG</para>
                /// </summary>
                [JsonPropertyName("local_address_line_9")]
                public string? LocalAddressLine9 { get; set; }

                /// <summary>
                /// <para>地址行 4（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("local_address_line_4")]
                public string? LocalAddressLine4 { get; set; }

                /// <summary>
                /// <para>地址行 5</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("address_line_5")]
                public string? AddressLine5 { get; set; }
            }
        }

        /// <summary>
        /// <para>户口</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("hukou")]
        public ProfileSettingHukou? Hukou { get; set; }

        /// <summary>
        /// <para>户口</para>
        /// </summary>
        public record ProfileSettingHukou
        {
            /// <summary>
            /// <para>户口类型</para>
            /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name = "person_info_chn"</para>
            /// <para>- custom_api_name = "hukou_type"</para>
            /// <para>必填：否</para>
            /// <para>示例值：local_urban_residence</para>
            /// </summary>
            [JsonPropertyName("hukou_type")]
            public string? HukouType { get; set; }

            /// <summary>
            /// <para>户口所在地</para>
            /// <para>必填：否</para>
            /// <para>示例值：北京</para>
            /// </summary>
            [JsonPropertyName("hukou_location")]
            public string? HukouLocation { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public ProfileSettingCustomField[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record ProfileSettingCustomField
            {
                /// <summary>
                /// <para>字段名</para>
                /// <para>必填：是</para>
                /// <para>示例值：custom_field_1__c</para>
                /// </summary>
                [JsonPropertyName("field_name")]
                public string FieldName { get; set; } = string.Empty;

                /// <summary>
                /// <para>字段值</para>
                /// <para>是 JSON 转义后的字符串，根据元数据定义不同，字段格式不同。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
                /// <para>必填：否</para>
                /// <para>示例值：123</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }
        }

        /// <summary>
        /// <para>联系地址</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("contact_addresses")]
        public ProfileSettingAddress[]? ContactAddresses { get; set; }

        /// <summary>
        /// <para>联系地址</para>
        /// </summary>
        public record ProfileSettingAddress
        {
            /// <summary>
            /// <para>地址类型</para>
            /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name = "address"</para>
            /// <para>- custom_api_name = "address_type"</para>
            /// <para>必填：否</para>
            /// <para>示例值：home_address</para>
            /// </summary>
            [JsonPropertyName("address_type")]
            public string? AddressType { get; set; }

            /// <summary>
            /// <para>国家 / 地区 ID</para>
            /// <para>可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6862995757234914824</para>
            /// </summary>
            [JsonPropertyName("country_region")]
            public string? CountryRegion { get; set; }

            /// <summary>
            /// <para>主要行政区 ID</para>
            /// <para>可通过[【查询省份/行政区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863326815667095047</para>
            /// </summary>
            [JsonPropertyName("region")]
            public string? Region { get; set; }

            /// <summary>
            /// <para>主要行政区往下细分 1 层的行政区</para>
            /// <para>必填：否</para>
            /// <para>示例值：行政区 1</para>
            /// </summary>
            [JsonPropertyName("region_subdivision_1")]
            public string? RegionSubdivision1 { get; set; }

            /// <summary>
            /// <para>主要行政区往下细分 2 层的行政区</para>
            /// <para>必填：否</para>
            /// <para>示例值：行政区 2</para>
            /// </summary>
            [JsonPropertyName("region_subdivision_2")]
            public string? RegionSubdivision2 { get; set; }

            /// <summary>
            /// <para>城市 V2 ID</para>
            /// <para>可通过[【查询城市信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-city/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6862995757234914829</para>
            /// </summary>
            [JsonPropertyName("city_v2")]
            public string? CityV2 { get; set; }

            /// <summary>
            /// <para>城市（文本）</para>
            /// <para>必填：否</para>
            /// <para>示例值：北京市</para>
            /// </summary>
            [JsonPropertyName("city_text")]
            public string? CityText { get; set; }

            /// <summary>
            /// <para>城市（仅文本，非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：北京市</para>
            /// </summary>
            [JsonPropertyName("local_city_text")]
            public string? LocalCityText { get; set; }

            /// <summary>
            /// <para>城市往下细分 1 层的行政区</para>
            /// <para>必填：否</para>
            /// <para>示例值：行政区 1</para>
            /// </summary>
            [JsonPropertyName("city_subdivision_1")]
            public string? CitySubdivision1 { get; set; }

            /// <summary>
            /// <para>城市往下细分 2 层的行政区</para>
            /// <para>必填：否</para>
            /// <para>示例值：行政区 2</para>
            /// </summary>
            [JsonPropertyName("city_subdivision_2")]
            public string? CitySubdivision2 { get; set; }

            /// <summary>
            /// <para>区/县 V2 ID</para>
            /// <para>可通过[【查询区/县信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-district/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6862995757234914831</para>
            /// </summary>
            [JsonPropertyName("district_v2")]
            public string? DistrictV2 { get; set; }

            /// <summary>
            /// <para>邮政编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：611530</para>
            /// </summary>
            [JsonPropertyName("postal_code")]
            public string? PostalCode { get; set; }

            /// <summary>
            /// <para>地址行 1</para>
            /// <para>必填：否</para>
            /// <para>示例值：丹佛测试地址 - 纽埃时区</para>
            /// </summary>
            [JsonPropertyName("address_line_1")]
            public string? AddressLine1 { get; set; }

            /// <summary>
            /// <para>地址行 1（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：丹佛测试地址 - 纽埃时区</para>
            /// </summary>
            [JsonPropertyName("local_address_line_1")]
            public string? LocalAddressLine1 { get; set; }

            /// <summary>
            /// <para>地址行 2</para>
            /// <para>必填：否</para>
            /// <para>示例值：PoewH</para>
            /// </summary>
            [JsonPropertyName("address_line_2")]
            public string? AddressLine2 { get; set; }

            /// <summary>
            /// <para>地址行 2（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：PoewH</para>
            /// </summary>
            [JsonPropertyName("local_address_line_2")]
            public string? LocalAddressLine2 { get; set; }

            /// <summary>
            /// <para>地址行 3</para>
            /// <para>必填：否</para>
            /// <para>示例值：PoewH</para>
            /// </summary>
            [JsonPropertyName("address_line_3")]
            public string? AddressLine3 { get; set; }

            /// <summary>
            /// <para>地址行 3（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：PoewH</para>
            /// </summary>
            [JsonPropertyName("local_address_line_3")]
            public string? LocalAddressLine3 { get; set; }

            /// <summary>
            /// <para>地址行 4</para>
            /// <para>必填：否</para>
            /// <para>示例值：jmwJc</para>
            /// </summary>
            [JsonPropertyName("address_line_4")]
            public string? AddressLine4 { get; set; }

            /// <summary>
            /// <para>地址行 5（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：jmwJc</para>
            /// </summary>
            [JsonPropertyName("local_address_line_5")]
            public string? LocalAddressLine5 { get; set; }

            /// <summary>
            /// <para>地址行 6</para>
            /// <para>必填：否</para>
            /// <para>示例值：jmwJc</para>
            /// </summary>
            [JsonPropertyName("address_line_6")]
            public string? AddressLine6 { get; set; }

            /// <summary>
            /// <para>地址行 6（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：jmwJc</para>
            /// </summary>
            [JsonPropertyName("local_address_line_6")]
            public string? LocalAddressLine6 { get; set; }

            /// <summary>
            /// <para>地址行 7</para>
            /// <para>必填：否</para>
            /// <para>示例值：jmwJc</para>
            /// </summary>
            [JsonPropertyName("address_line_7")]
            public string? AddressLine7 { get; set; }

            /// <summary>
            /// <para>地址行 7（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：jmwJc</para>
            /// </summary>
            [JsonPropertyName("local_address_line_7")]
            public string? LocalAddressLine7 { get; set; }

            /// <summary>
            /// <para>地址行 8</para>
            /// <para>必填：否</para>
            /// <para>示例值：jmwJc</para>
            /// </summary>
            [JsonPropertyName("address_line_8")]
            public string? AddressLine8 { get; set; }

            /// <summary>
            /// <para>地址行 8（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：rafSu</para>
            /// </summary>
            [JsonPropertyName("local_address_line_8")]
            public string? LocalAddressLine8 { get; set; }

            /// <summary>
            /// <para>地址行 9</para>
            /// <para>必填：否</para>
            /// <para>示例值：McPRG</para>
            /// </summary>
            [JsonPropertyName("address_line_9")]
            public string? AddressLine9 { get; set; }

            /// <summary>
            /// <para>地址行 9（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：McPRG</para>
            /// </summary>
            [JsonPropertyName("local_address_line_9")]
            public string? LocalAddressLine9 { get; set; }

            /// <summary>
            /// <para>地址行 4（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：jmwJc</para>
            /// </summary>
            [JsonPropertyName("local_address_line_4")]
            public string? LocalAddressLine4 { get; set; }

            /// <summary>
            /// <para>地址行 5</para>
            /// <para>必填：否</para>
            /// <para>示例值：jmwJc</para>
            /// </summary>
            [JsonPropertyName("address_line_5")]
            public string? AddressLine5 { get; set; }
        }

        /// <summary>
        /// <para>自定义分组</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("custom_groups")]
        public ProfileSettingCustomGroup[]? CustomGroups { get; set; }

        /// <summary>
        /// <para>自定义分组</para>
        /// </summary>
        public record ProfileSettingCustomGroup
        {
            /// <summary>
            /// <para>分组名</para>
            /// <para>必填：否</para>
            /// <para>示例值：custom_obj__c</para>
            /// </summary>
            [JsonPropertyName("group_name")]
            public string? GroupName { get; set; }

            /// <summary>
            /// <para>分组数据</para>
            /// <para>必填：否</para>
            /// <para>最大长度：1000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("items")]
            public ProfileSettingCustomGroupItem[]? Items { get; set; }

            /// <summary>
            /// <para>分组数据</para>
            /// </summary>
            public record ProfileSettingCustomGroupItem
            {
                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// <para>最大长度：100</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public ProfileSettingCustomField[]? CustomFields { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// </summary>
                public record ProfileSettingCustomField
                {
                    /// <summary>
                    /// <para>字段名</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：custom_field_1__c</para>
                    /// </summary>
                    [JsonPropertyName("field_name")]
                    public string FieldName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>字段值</para>
                    /// <para>是 JSON 转义后的字符串，根据元数据定义不同，字段格式不同。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：123</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string? Value { get; set; }
                }
            }
        }
    }

    /// <summary>
    /// <para>工作信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_info")]
    public ProfileSettingEmploymentInfo? EmploymentInfo { get; set; }

    /// <summary>
    /// <para>工作信息</para>
    /// </summary>
    public record ProfileSettingEmploymentInfo
    {
        /// <summary>
        /// <para>基本信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("basic_info")]
        public ProfileSettingEmploymentBasicInfo? BasicInfo { get; set; }

        /// <summary>
        /// <para>基本信息</para>
        /// </summary>
        public record ProfileSettingEmploymentBasicInfo
        {
            /// <summary>
            /// <para>员工编号</para>
            /// <para>必填：否</para>
            /// <para>示例值：1000000</para>
            /// </summary>
            [JsonPropertyName("employee_number")]
            public string? EmployeeNumber { get; set; }

            /// <summary>
            /// <para>入职日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2021-01-01</para>
            /// </summary>
            [JsonPropertyName("effective_time")]
            public string? EffectiveTime { get; set; }

            /// <summary>
            /// <para>转正式员工日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2021-02-01</para>
            /// </summary>
            [JsonPropertyName("regular_employee_start_date")]
            public string? RegularEmployeeStartDate { get; set; }

            /// <summary>
            /// <para>资历起算日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-01-01</para>
            /// </summary>
            [JsonPropertyName("seniority_date")]
            public string? SeniorityDate { get; set; }

            /// <summary>
            /// <para>工作邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：12456@test.com</para>
            /// </summary>
            [JsonPropertyName("work_email")]
            public string? WorkEmail { get; set; }

            /// <summary>
            /// <para>工作电话</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("phone")]
            public ProfileSettingPhone? Phone { get; set; }

            /// <summary>
            /// <para>工作电话</para>
            /// </summary>
            public record ProfileSettingPhone
            {
                /// <summary>
                /// <para>国际电话区号</para>
                /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
                /// <para>- object_api_name = "phone"</para>
                /// <para>- custom_api_name = "international_area_code"</para>
                /// <para>必填：否</para>
                /// <para>示例值：86_china</para>
                /// </summary>
                [JsonPropertyName("international_area_code")]
                public string? InternationalAreaCode { get; set; }

                /// <summary>
                /// <para>电话号码</para>
                /// <para>必填：否</para>
                /// <para>示例值：13000000000</para>
                /// </summary>
                [JsonPropertyName("phone_number")]
                public string? PhoneNumber { get; set; }
            }

            /// <summary>
            /// <para>数据驻留地</para>
            /// <para>开通了飞书数据驻留服务的企业，该字段为必填</para>
            /// <para>必填：否</para>
            /// <para>示例值：cn</para>
            /// </summary>
            [JsonPropertyName("user_geo")]
            public string? UserGeo { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public ProfileSettingCustomField[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record ProfileSettingCustomField
            {
                /// <summary>
                /// <para>字段名</para>
                /// <para>必填：是</para>
                /// <para>示例值：custom_field_1__c</para>
                /// </summary>
                [JsonPropertyName("field_name")]
                public string FieldName { get; set; } = string.Empty;

                /// <summary>
                /// <para>字段值</para>
                /// <para>是 JSON 转义后的字符串，根据元数据定义不同，字段格式不同。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
                /// <para>必填：否</para>
                /// <para>示例值：123</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }
        }

        /// <summary>
        /// <para>试用期信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("probation_info")]
        public ProfileSettingProbationInfo? ProbationInfo { get; set; }

        /// <summary>
        /// <para>试用期信息</para>
        /// </summary>
        public record ProfileSettingProbationInfo
        {
            /// <summary>
            /// <para>试用期开始日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2021-01-01</para>
            /// </summary>
            [JsonPropertyName("probation_start_date")]
            public string? ProbationStartDate { get; set; }

            /// <summary>
            /// <para>试用期预计结束日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2021-02-01</para>
            /// </summary>
            [JsonPropertyName("probation_expected_end_date")]
            public string? ProbationExpectedEndDate { get; set; }

            /// <summary>
            /// <para>试用期实际结束日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2021-02-01</para>
            /// </summary>
            [JsonPropertyName("actual_probation_end_date")]
            public string? ActualProbationEndDate { get; set; }
        }

        /// <summary>
        /// <para>任职记录</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("employment_record")]
        public ProfileSettingEmploymentRecord? EmploymentRecord { get; set; }

        /// <summary>
        /// <para>任职记录</para>
        /// </summary>
        public record ProfileSettingEmploymentRecord
        {
            /// <summary>
            /// <para>人员类型 ID</para>
            /// <para>可通过[【查询单个人员类型】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/get)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6890452208593372679</para>
            /// </summary>
            [JsonPropertyName("employee_type")]
            public string? EmployeeType { get; set; }

            /// <summary>
            /// <para>部门 ID</para>
            /// <para>可通过[【查询单个部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/get)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6890452208593372679</para>
            /// </summary>
            [JsonPropertyName("department")]
            public string? Department { get; set; }

            /// <summary>
            /// <para>直属上级雇佣 ID</para>
            /// <para>可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6893014062142064135</para>
            /// </summary>
            [JsonPropertyName("direct_manager")]
            public string? DirectManager { get; set; }

            /// <summary>
            /// <para>工时制度 ID</para>
            /// <para>可通过[【查询单个工时制度】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/get)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6890452208593372600</para>
            /// </summary>
            [JsonPropertyName("working_hours_type")]
            public string? WorkingHoursType { get; set; }

            /// <summary>
            /// <para>成本中心分摊信息</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("cost_centers")]
            public ProfileSettingCostCenter[]? CostCenters { get; set; }

            /// <summary>
            /// <para>成本中心分摊信息</para>
            /// </summary>
            public record ProfileSettingCostCenter
            {
                /// <summary>
                /// <para>100</para>
                /// <para>必填：否</para>
                /// <para>示例值：6950635856373745165</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>分摊比例</para>
                /// <para>必填：否</para>
                /// <para>示例值：100</para>
                /// <para>最大值：100</para>
                /// <para>最小值：0</para>
                /// </summary>
                [JsonPropertyName("rate")]
                public int? Rate { get; set; }
            }

            /// <summary>
            /// <para>直属上级入职日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-01-01</para>
            /// </summary>
            [JsonPropertyName("direct_manager_effective_time")]
            public string? DirectManagerEffectiveTime { get; set; }

            /// <summary>
            /// <para>虚线上级雇佣 ID</para>
            /// <para>可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6893014062142064136</para>
            /// </summary>
            [JsonPropertyName("dotted_line_manager")]
            public string? DottedLineManager { get; set; }

            /// <summary>
            /// <para>虚线上级入职日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-01-01</para>
            /// </summary>
            [JsonPropertyName("dotted_line_manager_effective_time")]
            public string? DottedLineManagerEffectiveTime { get; set; }

            /// <summary>
            /// <para>职务 ID</para>
            /// <para>可通过[【查询单个职务】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job/get)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6890452208593372679</para>
            /// </summary>
            [JsonPropertyName("job")]
            public string? Job { get; set; }

            /// <summary>
            /// <para>序列 ID</para>
            /// <para>可通过[【查询单个序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/get)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6890452208593372680</para>
            /// </summary>
            [JsonPropertyName("job_family")]
            public string? JobFamily { get; set; }

            /// <summary>
            /// <para>职级 ID</para>
            /// <para>可通过[【查询单个职级】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/get)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6890452208593372681</para>
            /// </summary>
            [JsonPropertyName("job_level")]
            public string? JobLevel { get; set; }

            /// <summary>
            /// <para>职等 ID</para>
            /// <para>可通过[【查询职等】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_grade/query)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6890452208593372682</para>
            /// </summary>
            [JsonPropertyName("job_grade")]
            public string? JobGrade { get; set; }

            /// <summary>
            /// <para>工作地点 ID</para>
            /// <para>可通过[【查询单个地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/get)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6890452208593372683</para>
            /// </summary>
            [JsonPropertyName("work_location")]
            public string? WorkLocation { get; set; }

            /// <summary>
            /// <para>周工作时长</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// <para>最大值：168</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("weekly_working_hours")]
            public int? WeeklyWorkingHours { get; set; }
        }

        /// <summary>
        /// <para>合同记录</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("emp_contract_record")]
        public ProfileSettingEmpContractRecord? EmpContractRecord { get; set; }

        /// <summary>
        /// <para>合同记录</para>
        /// </summary>
        public record ProfileSettingEmpContractRecord
        {
            /// <summary>
            /// <para>合同协议编号</para>
            /// <para>必填：否</para>
            /// <para>示例值：6919737965274990093</para>
            /// </summary>
            [JsonPropertyName("contract_number")]
            public string? ContractNumber { get; set; }

            /// <summary>
            /// <para>合同类型</para>
            /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name = "contract"</para>
            /// <para>- custom_api_name = "contract_type"</para>
            /// <para>必填：否</para>
            /// <para>示例值：labor_contract</para>
            /// </summary>
            [JsonPropertyName("contract_type")]
            public string? ContractType { get; set; }

            /// <summary>
            /// <para>甲方公司 ID</para>
            /// <para>引用 Company 的 ID，详细信息可通过[【查询单个公司】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/get)接口查询获得</para>
            /// <para>必填：否</para>
            /// <para>示例值：6892686614112241165</para>
            /// </summary>
            [JsonPropertyName("first_party")]
            public string? FirstParty { get; set; }

            /// <summary>
            /// <para>合同开始日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2006-01-02</para>
            /// </summary>
            [JsonPropertyName("effective_time")]
            public string? EffectiveTime { get; set; }

            /// <summary>
            /// <para>期限类型</para>
            /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name = "contract"</para>
            /// <para>- custom_api_name = "duration_type"</para>
            /// <para>必填：否</para>
            /// <para>示例值：fixed_term</para>
            /// </summary>
            [JsonPropertyName("duration_type")]
            public string? DurationType { get; set; }

            /// <summary>
            /// <para>合同结束日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2050-01-01</para>
            /// </summary>
            [JsonPropertyName("contract_end_date")]
            public string? ContractEndDate { get; set; }
        }

        /// <summary>
        /// <para>自定义分组</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("custom_groups")]
        public ProfileSettingCustomGroup[]? CustomGroups { get; set; }

        /// <summary>
        /// <para>自定义分组</para>
        /// </summary>
        public record ProfileSettingCustomGroup
        {
            /// <summary>
            /// <para>分组名</para>
            /// <para>必填：否</para>
            /// <para>示例值：custom_obj__c</para>
            /// </summary>
            [JsonPropertyName("group_name")]
            public string? GroupName { get; set; }

            /// <summary>
            /// <para>分组数据</para>
            /// <para>必填：否</para>
            /// <para>最大长度：1000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("items")]
            public ProfileSettingCustomGroupItem[]? Items { get; set; }

            /// <summary>
            /// <para>分组数据</para>
            /// </summary>
            public record ProfileSettingCustomGroupItem
            {
                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// <para>最大长度：100</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public ProfileSettingCustomField[]? CustomFields { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// </summary>
                public record ProfileSettingCustomField
                {
                    /// <summary>
                    /// <para>字段名</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：custom_field_1__c</para>
                    /// </summary>
                    [JsonPropertyName("field_name")]
                    public string FieldName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>字段值</para>
                    /// <para>是 JSON 转义后的字符串，根据元数据定义不同，字段格式不同。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：123</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string? Value { get; set; }
                }
            }
        }
    }

    /// <summary>
    /// <para>履历信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("career")]
    public ProfileSettingCareer? Career { get; set; }

    /// <summary>
    /// <para>履历信息</para>
    /// </summary>
    public record ProfileSettingCareer
    {
        /// <summary>
        /// <para>教育经历</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("educations")]
        public ProfileSettingEducation[]? Educations { get; set; }

        /// <summary>
        /// <para>教育经历</para>
        /// </summary>
        public record ProfileSettingEducation
        {
            /// <summary>
            /// <para>学校</para>
            /// <para>必填：否</para>
            /// <para>示例值：北京大学</para>
            /// </summary>
            [JsonPropertyName("school")]
            public string? School { get; set; }

            /// <summary>
            /// <para>学校</para>
            /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name = "education"</para>
            /// <para>- custom_api_name = "school_name"</para>
            /// <para>必填：否</para>
            /// <para>示例值：school-177</para>
            /// </summary>
            [JsonPropertyName("school_enum")]
            public string? SchoolEnum { get; set; }

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
            /// <para>学历</para>
            /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name = "education"</para>
            /// <para>- custom_api_name = "level_of_education"</para>
            /// <para>必填：否</para>
            /// <para>示例值：masters_degree</para>
            /// </summary>
            [JsonPropertyName("level_of_education")]
            public string? LevelOfEducation { get; set; }

            /// <summary>
            /// <para>专业</para>
            /// <para>必填：否</para>
            /// <para>示例值：软件工程</para>
            /// </summary>
            [JsonPropertyName("field_of_study")]
            public string? FieldOfStudy { get; set; }

            /// <summary>
            /// <para>学位</para>
            /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name = "education"</para>
            /// <para>- custom_api_name = "degree"</para>
            /// <para>必填：否</para>
            /// <para>示例值：bachelors_degree</para>
            /// </summary>
            [JsonPropertyName("degree")]
            public string? Degree { get; set; }

            /// <summary>
            /// <para>专业</para>
            /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name = "education"</para>
            /// <para>- custom_api_name = "field_of_study_name"</para>
            /// <para>必填：否</para>
            /// <para>示例值：field_of_study-2</para>
            /// </summary>
            [JsonPropertyName("field_of_study_enum")]
            public string? FieldOfStudyEnum { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public ProfileSettingCustomField[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record ProfileSettingCustomField
            {
                /// <summary>
                /// <para>字段名</para>
                /// <para>必填：是</para>
                /// <para>示例值：custom_field_1__c</para>
                /// </summary>
                [JsonPropertyName("field_name")]
                public string FieldName { get; set; } = string.Empty;

                /// <summary>
                /// <para>字段值</para>
                /// <para>是 JSON 转义后的字符串，根据元数据定义不同，字段格式不同。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
                /// <para>必填：否</para>
                /// <para>示例值：123</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }
        }

        /// <summary>
        /// <para>工作经历</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("work_experiences")]
        public ProfileSettingWorkExperience[]? WorkExperiences { get; set; }

        /// <summary>
        /// <para>工作经历</para>
        /// </summary>
        public record ProfileSettingWorkExperience
        {
            /// <summary>
            /// <para>公司 / 组织</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("company_organization")]
            public ProfileSettingI18n? CompanyOrganization { get; set; }

            /// <summary>
            /// <para>公司 / 组织</para>
            /// </summary>
            public record ProfileSettingI18n
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：中文名</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：english name</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>部门</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("department")]
            public ProfileSettingI18n? Department { get; set; }

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
            /// <para>示例值：2020-02-01</para>
            /// </summary>
            [JsonPropertyName("end_date")]
            public string? EndDate { get; set; }

            /// <summary>
            /// <para>岗位</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("job")]
            public ProfileSettingI18n? Job { get; set; }

            /// <summary>
            /// <para>工作描述</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("description")]
            public ProfileSettingI18n? Description { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public ProfileSettingCustomField[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record ProfileSettingCustomField
            {
                /// <summary>
                /// <para>字段名</para>
                /// <para>必填：是</para>
                /// <para>示例值：custom_field_1__c</para>
                /// </summary>
                [JsonPropertyName("field_name")]
                public string FieldName { get; set; } = string.Empty;

                /// <summary>
                /// <para>字段值</para>
                /// <para>是 JSON 转义后的字符串，根据元数据定义不同，字段格式不同。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
                /// <para>必填：否</para>
                /// <para>示例值：123</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }
        }

        /// <summary>
        /// <para>自定义分组</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("custom_groups")]
        public ProfileSettingCustomGroup[]? CustomGroups { get; set; }

        /// <summary>
        /// <para>自定义分组</para>
        /// </summary>
        public record ProfileSettingCustomGroup
        {
            /// <summary>
            /// <para>分组名</para>
            /// <para>必填：否</para>
            /// <para>示例值：custom_obj__c</para>
            /// </summary>
            [JsonPropertyName("group_name")]
            public string? GroupName { get; set; }

            /// <summary>
            /// <para>分组数据</para>
            /// <para>必填：否</para>
            /// <para>最大长度：1000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("items")]
            public ProfileSettingCustomGroupItem[]? Items { get; set; }

            /// <summary>
            /// <para>分组数据</para>
            /// </summary>
            public record ProfileSettingCustomGroupItem
            {
                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// <para>最大长度：100</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public ProfileSettingCustomField[]? CustomFields { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// </summary>
                public record ProfileSettingCustomField
                {
                    /// <summary>
                    /// <para>字段名</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：custom_field_1__c</para>
                    /// </summary>
                    [JsonPropertyName("field_name")]
                    public string FieldName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>字段值</para>
                    /// <para>是 JSON 转义后的字符串，根据元数据定义不同，字段格式不同。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：123</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string? Value { get; set; }
                }
            }
        }
    }

    /// <summary>
    /// <para>资料附件</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("data_attachment")]
    public ProfileSettingDataAttachment? DataAttachment { get; set; }

    /// <summary>
    /// <para>资料附件</para>
    /// </summary>
    public record ProfileSettingDataAttachment
    {
        /// <summary>
        /// <para>资料附件记录</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("personal_records")]
        public ProfileSettingPersonalRecord[]? PersonalRecords { get; set; }

        /// <summary>
        /// <para>资料附件记录</para>
        /// </summary>
        public record ProfileSettingPersonalRecord
        {
            /// <summary>
            /// <para>资料类型</para>
            /// <para>枚举值可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name = "personal_profile"</para>
            /// <para>- custom_api_name = "profile_type"</para>
            /// <para>必填：否</para>
            /// <para>示例值：profile_type_1</para>
            /// </summary>
            [JsonPropertyName("profile_type")]
            public string? ProfileType { get; set; }

            /// <summary>
            /// <para>文件列表</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("files")]
            public ProfileSettingFile[]? Files { get; set; }

            /// <summary>
            /// <para>文件列表</para>
            /// </summary>
            public record ProfileSettingFile
            {
                /// <summary>
                /// <para>文件 ID</para>
                /// <para>可通过[【上传文件】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/person/upload)接口获取</para>
                /// <para>必填：否</para>
                /// <para>示例值：150018109586e8ea745e47ae8feb3722dbe1d03a181336393633393133303431393831343930373235150200</para>
                /// </summary>
                [JsonPropertyName("file_id")]
                public string? FileId { get; set; }

                /// <summary>
                /// <para>文件 MIME 类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：zip</para>
                /// </summary>
                [JsonPropertyName("mime_type")]
                public string? MimeType { get; set; }

                /// <summary>
                /// <para>文件名</para>
                /// <para>必填：否</para>
                /// <para>示例值：附件.zip</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// <para>文件大小（KB）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1000</para>
                /// </summary>
                [JsonPropertyName("size")]
                public string? Size { get; set; }

                /// <summary>
                /// <para>文件 Token</para>
                /// <para>必填：否</para>
                /// <para>示例值：0a423bc7ea7c4a439d066bf070616782</para>
                /// </summary>
                [JsonPropertyName("token")]
                public string? Token { get; set; }
            }
        }

        /// <summary>
        /// <para>自定义分组</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("custom_groups")]
        public ProfileSettingCustomGroup[]? CustomGroups { get; set; }

        /// <summary>
        /// <para>自定义分组</para>
        /// </summary>
        public record ProfileSettingCustomGroup
        {
            /// <summary>
            /// <para>分组名</para>
            /// <para>必填：否</para>
            /// <para>示例值：custom_obj__c</para>
            /// </summary>
            [JsonPropertyName("group_name")]
            public string? GroupName { get; set; }

            /// <summary>
            /// <para>分组数据</para>
            /// <para>必填：否</para>
            /// <para>最大长度：1000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("items")]
            public ProfileSettingCustomGroupItem[]? Items { get; set; }

            /// <summary>
            /// <para>分组数据</para>
            /// </summary>
            public record ProfileSettingCustomGroupItem
            {
                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// <para>最大长度：100</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public ProfileSettingCustomField[]? CustomFields { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// </summary>
                public record ProfileSettingCustomField
                {
                    /// <summary>
                    /// <para>字段名</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：custom_field_1__c</para>
                    /// </summary>
                    [JsonPropertyName("field_name")]
                    public string FieldName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>字段值</para>
                    /// <para>是 JSON 转义后的字符串，根据元数据定义不同，字段格式不同。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：123</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string? Value { get; set; }
                }
            }
        }
    }
}
