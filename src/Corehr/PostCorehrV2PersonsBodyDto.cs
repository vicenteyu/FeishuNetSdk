// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2PersonsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建个人信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 创建个人信息 请求体
/// <para>创建员工的个人信息，包括姓名、个人电话、邮箱、联系地址、政治面貌、户口信息等</para>
/// <para>接口ID：7225452763517108227</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/person/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fperson%2fcreate</para>
/// </summary>
public record PostCorehrV2PersonsBodyDto
{
    /// <summary>
    /// <para>姓名列表，当不为离职重聘员工时，该字段必填</para>
    /// <para>字段权限要求：</para>
    /// <para>读写法定姓名信息(corehr:person.legal_name:write)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("name_list")]
    public PersonName[]? NameLists { get; set; }

    /// <summary>
    /// <para>姓名列表，当不为离职重聘员工时，该字段必填</para>
    /// <para>字段权限要求：</para>
    /// <para>读写法定姓名信息(corehr:person.legal_name:write)</para>
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
        /// <para>国家/地区，可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取</para>
        /// <para>必填：是</para>
        /// <para>示例值：6862995757234914824</para>
        /// </summary>
        [JsonPropertyName("country_region_id")]
        public string CountryRegionId { get; set; } = string.Empty;

        /// <summary>
        /// <para>姓名类型，可通过[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)姓名类型（name_type）枚举定义获得</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name_type")]
        public Enum NameType { get; set; } = new();

        /// <summary>
        /// <para>姓名类型，可通过[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)姓名类型（name_type）枚举定义获得</para>
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
        /// <para>补充姓名类型，可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)获取，查询参数：</para>
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
        /// <para>尊称，可通过 [【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
        /// <para>- custom_api_name：social</para>
        /// <para>- object_api_name：person_name</para>
        /// <para>必填：否</para>
        /// <para>示例值：王大帅</para>
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
        /// <para>头衔，可通过 [【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
        /// <para>- custom_api_name：social</para>
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
    }

    /// <summary>
    /// <para>性别，枚举值 api_name 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
    /// <para>- object_api_name = "person"</para>
    /// <para>- custom_api_name = "gender"</para>
    /// <para>字段权限要求：</para>
    /// <para>读写性别信息(corehr:person.gender:write)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("gender")]
    public Enum? Gender { get; set; }

    /// <summary>
    /// <para>性别，枚举值 api_name 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
    /// <para>- object_api_name = "person"</para>
    /// <para>- custom_api_name = "gender"</para>
    /// <para>字段权限要求：</para>
    /// <para>读写性别信息(corehr:person.gender:write)</para>
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
    }

    /// <summary>
    /// <para>出生日期</para>
    /// <para>字段权限要求：</para>
    /// <para>读写生日信息(corehr:person.date_of_birth:write)</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public string? DateOfBirth { get; set; }

    /// <summary>
    /// <para>国籍 ID，可通过[【查询国籍信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-nationality/search)接口查询</para>
    /// <para>必填：否</para>
    /// <para>示例值：6862995757234914821</para>
    /// </summary>
    [JsonPropertyName("nationality_id_v2")]
    public string? NationalityIdV2 { get; set; }

    /// <summary>
    /// <para>民族 / 种族，枚举值 api_name 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
    /// <para>- object_api_name = "person"</para>
    /// <para>- custom_api_name = "race"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("race")]
    public Enum? Race { get; set; }

    /// <summary>
    /// <para>婚姻状况，枚举值 api_name 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
    /// <para>- object_api_name = "person"</para>
    /// <para>- custom_api_name = "marital_status"</para>
    /// <para>字段权限要求：</para>
    /// <para>读写婚姻状况信息(corehr:person.marital_status:write)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("marital_status")]
    public Enum? MaritalStatus { get; set; }

    /// <summary>
    /// <para>电话列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("phone_list")]
    public Phone[]? PhoneLists { get; set; }

    /// <summary>
    /// <para>电话列表</para>
    /// </summary>
    public record Phone
    {
        /// <summary>
        /// <para>国家区号，可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)获取，按如下参数查询即可：</para>
        /// <para>- custom_api_name：international_area_code</para>
        /// <para>- object_api_name：phone</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("international_area_code")]
        public Enum? InternationalAreaCode { get; set; }

        /// <summary>
        /// <para>国家区号，可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)获取，按如下参数查询即可：</para>
        /// <para>- custom_api_name：international_area_code</para>
        /// <para>- object_api_name：phone</para>
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
        }

        /// <summary>
        /// <para>电话号码</para>
        /// <para>必填：是</para>
        /// <para>示例值：010-12345678</para>
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>地址列表</para>
    /// <para>字段权限要求：</para>
    /// <para>读取个人地址信息(corehr:person.address:write)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("address_list")]
    public Address[]? AddressLists { get; set; }

    /// <summary>
    /// <para>地址列表</para>
    /// <para>字段权限要求：</para>
    /// <para>读取个人地址信息(corehr:person.address:write)</para>
    /// </summary>
    public record Address
    {
        /// <summary>
        /// <para>地址 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6989822217869624863</para>
        /// </summary>
        [JsonPropertyName("address_id")]
        public string? AddressId { get; set; }

        /// <summary>
        /// <para>国家/地区，可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取</para>
        /// <para>必填：是</para>
        /// <para>示例值：6862995757234914824</para>
        /// </summary>
        [JsonPropertyName("country_region_id")]
        public string CountryRegionId { get; set; } = string.Empty;

        /// <summary>
        /// <para>主要行政区，可通过[【查询省份/主要行政区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)获取</para>
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
        /// <para>地址类型，可通过[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)地址类型（address_type）枚举定义获得</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("address_type_list")]
        public Enum[] AddressTypeLists { get; set; } = Array.Empty<Enum>();

        /// <summary>
        /// <para>地址类型，可通过[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)地址类型（address_type）枚举定义获得</para>
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
            /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
            /// <para>必填：是</para>
            /// <para>示例值：\"231\"</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>邮箱列表</para>
    /// <para>字段权限要求：</para>
    /// <para>读写个人邮箱信息(corehr:person.email:write)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("email_list")]
    public Email[]? EmailLists { get; set; }

    /// <summary>
    /// <para>邮箱列表</para>
    /// <para>字段权限要求：</para>
    /// <para>读写个人邮箱信息(corehr:person.email:write)</para>
    /// </summary>
    public record Email
    {
        /// <summary>
        /// <para>邮箱地址</para>
        /// <para>必填：是</para>
        /// <para>示例值：1234567@example.feishu.cn</para>
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
        /// <para>邮箱用途，可通过[【枚举常量介绍】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)邮箱用途（email_usage）枚举定义获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("email_usage")]
        public Enum? EmailUsage { get; set; }

        /// <summary>
        /// <para>邮箱用途，可通过[【枚举常量介绍】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)邮箱用途（email_usage）枚举定义获得</para>
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
        }
    }

    /// <summary>
    /// <para>工作经历列表</para>
    /// <para>字段权限要求：</para>
    /// <para>读写工作履历信息(corehr:person.work_experience:write)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("work_experience_list")]
    public WorkExperienceInfo[]? WorkExperienceLists { get; set; }

    /// <summary>
    /// <para>工作经历列表</para>
    /// <para>字段权限要求：</para>
    /// <para>读写工作履历信息(corehr:person.work_experience:write)</para>
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
            /// <para>语言</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>内容</para>
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
            /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
            /// <para>必填：是</para>
            /// <para>示例值：\"231\"</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>教育经历列表</para>
    /// <para>字段权限要求：</para>
    /// <para>读写教育经历信息(corehr:person.education:write)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("education_list")]
    public Education[]? EducationLists { get; set; }

    /// <summary>
    /// <para>教育经历列表</para>
    /// <para>字段权限要求：</para>
    /// <para>读写教育经历信息(corehr:person.education:write)</para>
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
            /// <para>语言</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>学历，可通过[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)学历（level_of_education）枚举定义获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("level_of_education")]
        public Enum? LevelOfEducation { get; set; }

        /// <summary>
        /// <para>学历，可通过[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)学历（level_of_education）枚举定义获得</para>
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
        /// <para>专业名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("field_of_study")]
        public I18n[]? FieldOfStuies { get; set; }

        /// <summary>
        /// <para>学位，可通过[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)学位（degree）枚举定义获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("degree")]
        public Enum? Degree { get; set; }

        /// <summary>
        /// <para>学校名称，可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)获取，查询参数：</para>
        /// <para>- custom_api_name：school_name</para>
        /// <para>- object_api_name：education</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("school_name")]
        public Enum? SchoolName { get; set; }

        /// <summary>
        /// <para>专业名称，可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)获取，查询参数：</para>
        /// <para>- custom_api_name：field_of_study_name</para>
        /// <para>- object_api_name：education</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("field_of_study_name")]
        public Enum? FieldOfStudyName { get; set; }

        /// <summary>
        /// <para>国家/地区ID，可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取</para>
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
            /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
            /// <para>必填：是</para>
            /// <para>示例值：\"231\"</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>银行账户</para>
    /// <para>字段权限要求：</para>
    /// <para>读写银行账号列表信息(corehr:person.bank_account:write)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("bank_account_list")]
    public BankAccount[]? BankAccountLists { get; set; }

    /// <summary>
    /// <para>银行账户</para>
    /// <para>字段权限要求：</para>
    /// <para>读写银行账号列表信息(corehr:person.bank_account:write)</para>
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
        /// <para>银行 ID，可通过[【查询银行信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-bank/search)接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：MDBH00000001</para>
        /// </summary>
        [JsonPropertyName("bank_id_v2")]
        public string? BankIdV2 { get; set; }

        /// <summary>
        /// <para>支行 ID，要求必须为填入银行的支行，可通过[【查询支行信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-bank_branch/search)接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：MDBK00000017</para>
        /// </summary>
        [JsonPropertyName("branch_id_v2")]
        public string? BranchIdV2 { get; set; }

        /// <summary>
        /// <para>国家/地区ID，可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：12</para>
        /// </summary>
        [JsonPropertyName("country_region_id")]
        public string? CountryRegionId { get; set; }

        /// <summary>
        /// <para>银行卡用途，可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)银行卡用途（Bank Account Usage）枚举定义获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("bank_account_usage")]
        public Enum[]? BankAccountUsages { get; set; }

        /// <summary>
        /// <para>银行卡用途，可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)银行卡用途（Bank Account Usage）枚举定义获得</para>
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
        }

        /// <summary>
        /// <para>银行卡类型，可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)银行卡类型（Bank Account Type）枚举定义获得</para>
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
            /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
            /// <para>必填：是</para>
            /// <para>示例值：\"231\"</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>证件列表</para>
    /// <para>字段权限要求：</para>
    /// <para>读写证件信息(corehr:person.national_id:write)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("national_id_list")]
    public NationalId[]? NationalIdLists { get; set; }

    /// <summary>
    /// <para>证件列表</para>
    /// <para>字段权限要求：</para>
    /// <para>读写证件信息(corehr:person.national_id:write)</para>
    /// </summary>
    public record NationalId
    {
        /// <summary>
        /// <para>国家证件类型，可通过[【批量查询国家证件类型】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/national_id_type/list)获得</para>
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
        /// <para>国家/地区ID，可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取</para>
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
            /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
            /// <para>必填：是</para>
            /// <para>示例值：\"231\"</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>家庭成员列表</para>
    /// <para>字段权限要求：</para>
    /// <para>读写家庭成员信息(corehr:person.dependent:write)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("dependent_list")]
    public Dependent[]? DependentLists { get; set; }

    /// <summary>
    /// <para>家庭成员列表</para>
    /// <para>字段权限要求：</para>
    /// <para>读写家庭成员信息(corehr:person.dependent:write)</para>
    /// </summary>
    public record Dependent
    {
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
        }

        /// <summary>
        /// <para>性别，可通过[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)性别（gender）枚举定义获得</para>
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
        /// <para>国籍 ID，可通过[【查询国籍信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-nationality/search)接口查询</para>
        /// <para>必填：否</para>
        /// <para>示例值：6862995745046267401</para>
        /// </summary>
        [JsonPropertyName("nationality_id_v2")]
        public string? NationalityIdV2 { get; set; }

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
            /// <para>国家证件类型，可通过[【批量查询国家证件类型】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/national_id_type/list)获得</para>
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
            /// <para>国家/地区ID，可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取</para>
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
                /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
                /// <para>必填：是</para>
                /// <para>示例值：\"231\"</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>配偶工作状态，可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)获取，查询参数：</para>
        /// <para>- custom_api_name：spouses_working_status</para>
        /// <para>- object_api_name：dependent</para>
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
            /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
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
            /// <para>国家区号，可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)获取，按如下参数查询即可：</para>
            /// <para>- custom_api_name：international_area_code</para>
            /// <para>- object_api_name：phone</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("international_area_code")]
            public Enum? InternationalAreaCode { get; set; }

            /// <summary>
            /// <para>国家区号，可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)获取，按如下参数查询即可：</para>
            /// <para>- custom_api_name：international_area_code</para>
            /// <para>- object_api_name：phone</para>
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
            }

            /// <summary>
            /// <para>电话号码</para>
            /// <para>必填：是</para>
            /// <para>示例值：010-12345678</para>
            /// </summary>
            [JsonPropertyName("phone_number")]
            public string PhoneNumber { get; set; } = string.Empty;
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
            /// <para>地址 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6989822217869624863</para>
            /// </summary>
            [JsonPropertyName("address_id")]
            public string? AddressId { get; set; }

            /// <summary>
            /// <para>国家/地区，可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取</para>
            /// <para>必填：是</para>
            /// <para>示例值：6862995757234914824</para>
            /// </summary>
            [JsonPropertyName("country_region_id")]
            public string CountryRegionId { get; set; } = string.Empty;

            /// <summary>
            /// <para>主要行政区，可通过[【查询省份/主要行政区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)获取</para>
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
                /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
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
        }
    }

    /// <summary>
    /// <para>紧急联系人列表</para>
    /// <para>字段权限要求：</para>
    /// <para>读写紧急联系人信息(corehr:person.emergency_contact:write)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("emergency_contact_list")]
    public EmergencyContact[]? EmergencyContactLists { get; set; }

    /// <summary>
    /// <para>紧急联系人列表</para>
    /// <para>字段权限要求：</para>
    /// <para>读写紧急联系人信息(corehr:person.emergency_contact:write)</para>
    /// </summary>
    public record EmergencyContact
    {
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
            /// <para>国家/地区，可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取</para>
            /// <para>必填：是</para>
            /// <para>示例值：6862995757234914824</para>
            /// </summary>
            [JsonPropertyName("country_region_id")]
            public string CountryRegionId { get; set; } = string.Empty;

            /// <summary>
            /// <para>姓名类型，可通过[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)姓名类型（name_type）枚举定义获得</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("name_type")]
            public Enum NameType { get; set; } = new();

            /// <summary>
            /// <para>姓名类型，可通过[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)姓名类型（name_type）枚举定义获得</para>
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
            /// <para>补充姓名类型，可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)获取，查询参数：</para>
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
            /// <para>尊称，可通过 [【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- custom_api_name：social</para>
            /// <para>- object_api_name：person_name</para>
            /// <para>必填：否</para>
            /// <para>示例值：王大帅</para>
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
            /// <para>头衔，可通过 [【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- custom_api_name：social</para>
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
        }

        /// <summary>
        /// <para>关系，可通过[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)亲属关系（relationship）枚举定义获取</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("relationship")]
        public Enum? Relationship { get; set; }

        /// <summary>
        /// <para>关系，可通过[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)亲属关系（relationship）枚举定义获取</para>
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
            /// <para>国家区号，可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)获取，按如下参数查询即可：</para>
            /// <para>- custom_api_name：international_area_code</para>
            /// <para>- object_api_name：phone</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("international_area_code")]
            public Enum? InternationalAreaCode { get; set; }

            /// <summary>
            /// <para>国家区号，可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)获取，按如下参数查询即可：</para>
            /// <para>- custom_api_name：international_area_code</para>
            /// <para>- object_api_name：phone</para>
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
            }

            /// <summary>
            /// <para>电话号码</para>
            /// <para>必填：是</para>
            /// <para>示例值：010-12345678</para>
            /// </summary>
            [JsonPropertyName("phone_number")]
            public string PhoneNumber { get; set; } = string.Empty;
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
    /// <para>字段权限要求：</para>
    /// <para>读写参加工作日期(corehr:person.date_entered_workforce:write)</para>
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
    /// <para>个人资料附件</para>
    /// <para>字段权限要求：</para>
    /// <para>读写个人资料信息(corehr:person.personal_profile:write)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("personal_profile")]
    public PersonalProfile[]? PersonalProfiles { get; set; }

    /// <summary>
    /// <para>个人资料附件</para>
    /// <para>字段权限要求：</para>
    /// <para>读写个人资料信息(corehr:person.personal_profile:write)</para>
    /// </summary>
    public record PersonalProfile
    {
        /// <summary>
        /// <para>资料类型，可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)获取，查询参数：</para>
        /// <para>- custom_api_name：profile_type</para>
        /// <para>- object_api_name：personal_profile</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("personal_profile_type")]
        public Enum? PersonalProfileType { get; set; }

        /// <summary>
        /// <para>资料类型，可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)获取，查询参数：</para>
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

    /// <summary>
    /// <para>籍贯 ID，可通过[【查询省份/主要行政区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/subdivision/get)接口查询</para>
    /// <para>字段权限要求：</para>
    /// <para>读写籍贯信息(corehr:person.native_region:write)</para>
    /// <para>必填：否</para>
    /// <para>示例值：6863326262618752111</para>
    /// </summary>
    [JsonPropertyName("native_region")]
    public string? NativeRegion { get; set; }

    /// <summary>
    /// <para>户口类型，可通过文档 [【枚举常量介绍】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)户口类型（hukou_type）枚举定义获得</para>
    /// <para>字段权限要求：</para>
    /// <para>读写户口信息(corehr:person.hukou:write)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("hukou_type")]
    public Enum? HukouType { get; set; }

    /// <summary>
    /// <para>户口所在地</para>
    /// <para>字段权限要求：</para>
    /// <para>读写户口信息(corehr:person.hukou:write)</para>
    /// <para>必填：否</para>
    /// <para>示例值：山东省平阴县</para>
    /// </summary>
    [JsonPropertyName("hukou_location")]
    public string? HukouLocation { get; set; }

    /// <summary>
    /// <para>政治面貌，可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)政治面貌（political_affiliation）枚举定义获得</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("political_affiliations")]
    public Enum[]? PoliticalAffiliations { get; set; }

    /// <summary>
    /// <para>人才ID，可通过[【获取人才列表】](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent/list)获取</para>
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
        /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
        /// <para>必填：是</para>
        /// <para>示例值：\"231\"</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>出生国家/地区</para>
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
        /// <para>居民身份，枚举值 api_name 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下： - object_api_name = "resident_tax" - custom_api_name = "resident_status"</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("resident_status")]
        public Enum? ResidentStatus { get; set; }

        /// <summary>
        /// <para>居民身份，枚举值 api_name 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下： - object_api_name = "resident_tax" - custom_api_name = "resident_status"</para>
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
        }

        /// <summary>
        /// <para>国家/地区，可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口查询</para>
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
    /// <para>首次入境日期</para>
    /// <para>必填：否</para>
    /// <para>示例值：2021-01-02</para>
    /// </summary>
    [JsonPropertyName("first_entry_time")]
    public string? FirstEntryTime { get; set; }

    /// <summary>
    /// <para>预计离境日期</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-01-02</para>
    /// </summary>
    [JsonPropertyName("leave_time")]
    public string? LeaveTime { get; set; }
}
