// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-03-29
// ************************************************************************
// <copyright file="PostCorehrV2EmployeesSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索员工信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 搜索员工信息 响应体
/// <para>查询员工的工作信息、个人信息等数据</para>
/// <para>接口ID：7211423970042167300</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployee%2fsearch</para>
/// </summary>
public record PostCorehrV2EmployeesSearchResponseDto : IPageableResponse<PostCorehrV2EmployeesSearchResponseDto.Employee>
{
    /// <summary>
    /// <para>查询的雇佣信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Employee[]? Items { get; set; }

    /// <summary>
    /// <para>查询的雇佣信息</para>
    /// </summary>
    public record Employee
    {
        /// <summary>
        /// I18n
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
        /// 自定义字段
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

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>- 请参考[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
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

        /// <summary>
        /// 枚举值
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
        }

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
            /// <para>国家/地区</para>
            /// <para>- 可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取</para>
            /// <para>必填：是</para>
            /// <para>示例值：6862995757234914824</para>
            /// </summary>
            [JsonPropertyName("country_region_id")]
            public string CountryRegionId { get; set; } = string.Empty;

            /// <summary>
            /// <para>姓名类型</para>
            /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name：person_name</para>
            /// <para>- custom_api_name：name_type</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("name_type")]
            public Enum NameType { get; set; } = new();

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
            /// <para>补充姓名类型</para>
            /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name：person_name</para>
            /// <para>- custom_api_name：additional_name_type</para>
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
            /// <para>尊称</para>
            /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name：person_name</para>
            /// <para>- custom_api_name：social</para>
            /// <para>必填：否</para>
            /// <para>示例值：王大帅</para>
            /// </summary>
            [JsonPropertyName("social")]
            public Enum? Social { get; set; }

            /// <summary>
            /// <para>头衔</para>
            /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name：person_name</para>
            /// <para>- custom_api_name：title</para>
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
        /// <para>电话列表</para>
        /// </summary>
        public record Phone
        {
            /// <summary>
            /// <para>国家区号</para>
            /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name：phone</para>
            /// <para>- custom_api_name：international_area_code</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("international_area_code")]
            public Enum? InternationalAreaCode { get; set; }

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
            /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name：phone</para>
            /// <para>- custom_api_name：device_type</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("device_type")]
            public Enum? DeviceType { get; set; }

            /// <summary>
            /// <para>电话用途</para>
            /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name：phone</para>
            /// <para>- custom_api_name：phone_usage</para>
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
            /// <para>国家/地区</para>
            /// <para>- 可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取</para>
            /// <para>必填：是</para>
            /// <para>示例值：6862995757234914824</para>
            /// </summary>
            [JsonPropertyName("country_region_id")]
            public string CountryRegionId { get; set; } = string.Empty;

            /// <summary>
            /// <para>主要行政区</para>
            /// <para>- 可通过[【查询省份/主要行政区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863326815667095047</para>
            /// </summary>
            [JsonPropertyName("region_id")]
            public string? RegionId { get; set; }

            /// <summary>
            /// <para>城市（该字段待作废，请勿使用）</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863333254578046471</para>
            /// </summary>
            [JsonPropertyName("city_id")]
            public string? CityId { get; set; }

            /// <summary>
            /// <para>区/县（该字段待作废，请勿使用）</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863333516579440141</para>
            /// </summary>
            [JsonPropertyName("distinct_id")]
            public string? DistinctId { get; set; }

            /// <summary>
            /// <para>城市</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863333254578046471</para>
            /// </summary>
            [JsonPropertyName("city_id_v2")]
            public string? CityIdV2 { get; set; }

            /// <summary>
            /// <para>区/县</para>
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
            /// <para>地址类型</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("address_type_list")]
            public Enum[] AddressTypeLists { get; set; } = Array.Empty<Enum>();

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
            /// <para>- 请参考[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public CustomFieldData[]? CustomFields { get; set; }

            /// <summary>
            /// <para>城市往下细分 1 层的行政区</para>
            /// <para>必填：否</para>
            /// <para>示例值：123</para>
            /// </summary>
            [JsonPropertyName("city_subdivision_1")]
            public string? CitySubdivision1 { get; set; }

            /// <summary>
            /// <para>城市往下细分 2 层的行政区</para>
            /// <para>必填：否</para>
            /// <para>示例值：123</para>
            /// </summary>
            [JsonPropertyName("city_subdivision_2")]
            public string? CitySubdivision2 { get; set; }

            /// <summary>
            /// <para>主要行政区往下细分 1 层的行政区</para>
            /// <para>必填：否</para>
            /// <para>示例值：123</para>
            /// </summary>
            [JsonPropertyName("region_subdivision_1")]
            public string? RegionSubdivision1 { get; set; }

            /// <summary>
            /// <para>主要行政区往下细分 2 层的行政区</para>
            /// <para>必填：否</para>
            /// <para>示例值：123</para>
            /// </summary>
            [JsonPropertyName("region_subdivision_2")]
            public string? RegionSubdivision2 { get; set; }
        }

        /// <summary>
        /// <para>证件</para>
        /// </summary>
        public record NationalId
        {
            /// <summary>
            /// <para>国家证件类型，可通过[【查询单个国家证件类型】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/national_id_type/get)获取详细信息</para>
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
            /// <para>国家/地区</para>
            /// <para>- 可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取</para>
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
            /// <para>- 请参考[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public CustomFieldData[]? CustomFields { get; set; }
        }

        /// <summary>
        /// <para>文件</para>
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

        /// <summary>
        /// <para>雇佣 ID，类型与 user_id_type 一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("employment_id")]
        public string? EmploymentId { get; set; }

        /// <summary>
        /// <para>雇佣 ID</para>
        /// <para>- 类型与 user_id_type 一致，转换失败时返回空值</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("employment_id_v2")]
        public string? EmploymentIdV2 { get; set; }

        /// <summary>
        /// <para>招聘投递 ID ，详细信息可以通过[【获取投递信息】](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)接口查询</para>
        /// <para>必填：否</para>
        /// <para>示例值：6838119494196871234</para>
        /// </summary>
        [JsonPropertyName("ats_application_id")]
        public string? AtsApplicationId { get; set; }

        /// <summary>
        /// <para>待入职 ID，可通过[【查询单个待入职】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/pre_hire/get)获取信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：7023239238976141133</para>
        /// </summary>
        [JsonPropertyName("prehire_id")]
        public string? PrehireId { get; set; }

        /// <summary>
        /// <para>工号，在[【创建雇佣】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employment/create)</para>
        /// <para>是指定的或者自动生成的值</para>
        /// <para>必填：否</para>
        /// <para>示例值：1000000</para>
        /// </summary>
        [JsonPropertyName("employee_number")]
        public string? EmployeeNumber { get; set; }

        /// <summary>
        /// <para>人员类型 ID，详细信息可通过[【查询单个人员类型】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/get)接口查询</para>
        /// <para>必填：否</para>
        /// <para>示例值：6971090097697521314</para>
        /// </summary>
        [JsonPropertyName("employee_type_id")]
        public string? EmployeeTypeId { get; set; }

        /// <summary>
        /// <para>人员子类型 ID，详细信息可通过[【查询单个人员类型】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/get)接口查询</para>
        /// <para>- 功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6971090097697521317</para>
        /// </summary>
        [JsonPropertyName("employee_subtype_id")]
        public string? EmployeeSubtypeId { get; set; }

        /// <summary>
        /// <para>部门 ID，详细信息可通过[【查询单个部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/get)接口查询</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>部门 ID</para>
        /// <para>- 可通过 [【查询单个部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/get)获取详细信息</para>
        /// <para>- 类型与 department_id_type 一致，转换失败时返回空值</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("department_id_v2")]
        public string? DepartmentIdV2 { get; set; }

        /// <summary>
        /// <para>职级 ID，详细信息可通过[【获取单个职级】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/get)接口查询</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("job_level_id")]
        public string? JobLevelId { get; set; }

        /// <summary>
        /// <para>职级</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_level")]
        public EmployeeJobLevel? JobLevel { get; set; }

        /// <summary>
        /// <para>职级</para>
        /// </summary>
        public record EmployeeJobLevel
        {
            /// <summary>
            /// <para>职级 ID，可通过[【查询单个职级】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/get)获取详细信息</para>
            /// <para>- 与 job_level_id 值相同</para>
            /// <para>必填：否</para>
            /// <para>示例值：4692446793125560154</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>职级数值</para>
            /// <para>必填：是</para>
            /// <para>示例值：9999</para>
            /// </summary>
            [JsonPropertyName("level_order")]
            public int LevelOrder { get; set; }

            /// <summary>
            /// <para>编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：VQzo/BSonp8l6PmcZ+VlDhkd2595LMkhyBAGX6HAlCY=</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n[] Names { get; set; } = Array.Empty<I18n>();

            /// <summary>
            /// <para>描述</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("description")]
            public I18n[]? Descriptions { get; set; }

            /// <summary>
            /// <para>启用</para>
            /// <para>必填：是</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("active")]
            public bool Active { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>- 请参考[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public CustomFieldData[]? CustomFields { get; set; }
        }

        /// <summary>
        /// <para>通道 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("pathway_id")]
        public string? PathwayId { get; set; }

        /// <summary>
        /// <para>通道</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("pathway")]
        public EmployeePathway? Pathway { get; set; }

        /// <summary>
        /// <para>通道</para>
        /// </summary>
        public record EmployeePathway
        {
            /// <summary>
            /// <para>通道 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：4692446793125560154</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：VQzo/BSonp8l6PmcZ+VlDhkd2595LMkhyBAGX6HAlCY=</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n[] Names { get; set; } = Array.Empty<I18n>();

            /// <summary>
            /// <para>描述</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("description")]
            public I18n[]? Descriptions { get; set; }

            /// <summary>
            /// <para>启用</para>
            /// <para>必填：是</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("active")]
            public bool Active { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public CustomFieldData[]? CustomFields { get; set; }
        }

        /// <summary>
        /// <para>职等 ID，可用于[【查询职等】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_grade/query)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("job_grade_id")]
        public string? JobGradeId { get; set; }

        /// <summary>
        /// <para>工作地点 ID，详细信息可通过[【查询单个地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/get)接口查询</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("work_location_id")]
        public string? WorkLocationId { get; set; }

        /// <summary>
        /// <para>序列 ID，详细信息可通过[【查询单个序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/get)接口查询</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("job_family_id")]
        public string? JobFamilyId { get; set; }

        /// <summary>
        /// <para>序列</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_family")]
        public EmployeeJobFamily? JobFamily { get; set; }

        /// <summary>
        /// <para>序列</para>
        /// </summary>
        public record EmployeeJobFamily
        {
            /// <summary>
            /// <para>序列 ID，可通过[【查询单个序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/get)获取详细信息</para>
            /// <para>- 与 job_family_id 值相同</para>
            /// <para>必填：否</para>
            /// <para>示例值：4698019107896524633</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n[] Names { get; set; } = Array.Empty<I18n>();

            /// <summary>
            /// <para>是否启用</para>
            /// <para>必填：是</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("active")]
            public bool Active { get; set; }

            /// <summary>
            /// <para>上级序列，可通过[【查询单个序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/get)获取详细信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：4698020757495316313</para>
            /// </summary>
            [JsonPropertyName("parent_id")]
            public string? ParentId { get; set; }

            /// <summary>
            /// <para>生效时间</para>
            /// <para>必填：是</para>
            /// <para>示例值：2020-05-01 00:00:00</para>
            /// </summary>
            [JsonPropertyName("effective_time")]
            public string EffectiveTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>失效时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-05-02 00:00:00</para>
            /// </summary>
            [JsonPropertyName("expiration_time")]
            public string? ExpirationTime { get; set; }

            /// <summary>
            /// <para>编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：123456</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>- 请参考[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public CustomFieldData[]? CustomFields { get; set; }
        }

        /// <summary>
        /// <para>岗位 ID，功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("position_id")]
        public string? PositionId { get; set; }

        /// <summary>
        /// <para>岗位，功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("position")]
        public EmployeePosition? Position { get; set; }

        /// <summary>
        /// <para>岗位，功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
        /// </summary>
        public record EmployeePosition
        {
            /// <summary>
            /// <para>岗位 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：4692446793125560154</para>
            /// </summary>
            [JsonPropertyName("position_id")]
            public string? PositionId { get; set; }

            /// <summary>
            /// <para>编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：A01234</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：否</para>
            /// <para>最大长度：2</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("names")]
            public I18n[]? Names { get; set; }

            /// <summary>
            /// <para>描述</para>
            /// <para>必填：否</para>
            /// <para>最大长度：2</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("descriptions")]
            public I18n[]? Descriptions { get; set; }

            /// <summary>
            /// <para>状态</para>
            /// <para>必填：是</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("active")]
            public bool Active { get; set; }
        }

        /// <summary>
        /// <para>职务 ID，详细信息可通过[【查询单个职务】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/get)接口查询</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// <para>职务</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job")]
        public EmployeeJob? Job { get; set; }

        /// <summary>
        /// <para>职务</para>
        /// </summary>
        public record EmployeeJob
        {
            /// <summary>
            /// <para>实体在CoreHR内部的唯一键</para>
            /// <para>必填：否</para>
            /// <para>示例值：4698040628992333549</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：JP422119</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n[] Names { get; set; } = Array.Empty<I18n>();

            /// <summary>
            /// <para>描述</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("description")]
            public I18n[]? Descriptions { get; set; }

            /// <summary>
            /// <para>启用</para>
            /// <para>必填：是</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("active")]
            public bool Active { get; set; }

            /// <summary>
            /// <para>职务头衔</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("job_title")]
            public I18n[]? JobTitles { get; set; }

            /// <summary>
            /// <para>通道ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：4719519211875096301</para>
            /// </summary>
            [JsonPropertyName("pathway_id")]
            public string? PathwayId { get; set; }

            /// <summary>
            /// <para>序列</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("job_family_id_list")]
            public string[]? JobFamilyIdList { get; set; }

            /// <summary>
            /// <para>职级</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("job_level_id_list")]
            public string[]? JobLevelIdList { get; set; }

            /// <summary>
            /// <para>工时制度，引用WorkingHoursType的ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6890452208593372679</para>
            /// </summary>
            [JsonPropertyName("working_hours_type_id")]
            public string? WorkingHoursTypeId { get; set; }

            /// <summary>
            /// <para>生效时间</para>
            /// <para>必填：是</para>
            /// <para>示例值：2020-01-01 00:00:00</para>
            /// </summary>
            [JsonPropertyName("effective_time")]
            public string EffectiveTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>失效时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：2021-01-01 00:00:00</para>
            /// </summary>
            [JsonPropertyName("expiration_time")]
            public string? ExpirationTime { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>- 请参考[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public ObjectFieldData[]? CustomFields { get; set; }
        }

        /// <summary>
        /// <para>所属公司 ID，详细信息可通过[【查询单个公司】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/get)接口查询</para>
        /// <para>- 当前生效的合同中的公司</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("company_id")]
        public string? CompanyId { get; set; }

        /// <summary>
        /// <para>工时制度 ID，详细信息可通过[【查询单个工时制度】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/get)接口查询</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("working_hours_type_id")]
        public string? WorkingHoursTypeId { get; set; }

        /// <summary>
        /// <para>司龄</para>
        /// <para>必填：否</para>
        /// <para>示例值：0.01</para>
        /// </summary>
        [JsonPropertyName("tenure")]
        public string? Tenure { get; set; }

        /// <summary>
        /// <para>司龄起算日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-03-16</para>
        /// </summary>
        [JsonPropertyName("seniority_date")]
        public string? SeniorityDate { get; set; }

        /// <summary>
        /// <para>当前雇佣记录的入职日期</para>
        /// <para>必填：是</para>
        /// <para>示例值：2021-03-16</para>
        /// </summary>
        [JsonPropertyName("effective_date")]
        public string EffectiveDate { get; set; } = string.Empty;

        /// <summary>
        /// <para>是否是主雇佣信息</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("primary_employment")]
        public bool PrimaryEmployment { get; set; }

        /// <summary>
        /// <para>试用期时长（月）</para>
        /// <para>必填：否</para>
        /// <para>示例值：16</para>
        /// </summary>
        [JsonPropertyName("probation_period")]
        public int? ProbationPeriod { get; set; }

        /// <summary>
        /// <para>是否在试用期中</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("on_probation")]
        public bool? OnProbation { get; set; }

        /// <summary>
        /// <para>试用期结束日期（实际结束日期）</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-08-01</para>
        /// </summary>
        [JsonPropertyName("probation_end_date")]
        public string? ProbationEndDate { get; set; }

        /// <summary>
        /// <para>直接上级的雇佣 ID</para>
        /// <para>- 类型与 user_id_type 一致</para>
        /// <para>- 请使用 direct_manager_id_v2</para>
        /// <para>必填：否</para>
        /// <para>示例值：7027024823985411287</para>
        /// </summary>
        [JsonPropertyName("direct_manager_id")]
        public string? DirectManagerId { get; set; }

        /// <summary>
        /// <para>虚线上级的雇佣 ID</para>
        /// <para>- 类型与 user_id_type 一致</para>
        /// <para>- 请使用 dotted_line_manager_id_v2</para>
        /// <para>必填：否</para>
        /// <para>示例值：7027024823985411782</para>
        /// </summary>
        [JsonPropertyName("dotted_line_manager_id")]
        public string? DottedLineManagerId { get; set; }

        /// <summary>
        /// <para>直接上级的雇佣 ID</para>
        /// <para>- 类型与 user_id_type 一致，转换失败返回空值</para>
        /// <para>必填：否</para>
        /// <para>示例值：7027024823985411287</para>
        /// </summary>
        [JsonPropertyName("direct_manager_id_v2")]
        public string? DirectManagerIdV2 { get; set; }

        /// <summary>
        /// <para>虚线上级的雇佣 ID</para>
        /// <para>- 类型与 user_id_type 一致，转换失败返回空值</para>
        /// <para>必填：否</para>
        /// <para>示例值：7027024823985411782</para>
        /// </summary>
        [JsonPropertyName("dotted_line_manager_id_v2")]
        public string? DottedLineManagerIdV2 { get; set; }

        /// <summary>
        /// <para>雇佣类型</para>
        /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
        /// <para>- object_api_name：employment</para>
        /// <para>- custom_api_name：employment_type</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("employment_type")]
        public Enum EmploymentType { get; set; } = new();

        /// <summary>
        /// <para>雇佣状态</para>
        /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
        /// <para>- object_api_name：employment</para>
        /// <para>- custom_api_name：employment_status</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("employment_status")]
        public Enum? EmploymentStatus { get; set; }

        /// <summary>
        /// <para>离职日期，即员工的最后一个工作日，最后一个工作日时员工的雇佣状态仍为“在职”，次日凌晨将更改为“离职”</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-08-16</para>
        /// </summary>
        [JsonPropertyName("expiration_date")]
        public string? ExpirationDate { get; set; }

        /// <summary>
        /// <para>离职原因</para>
        /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
        /// <para>- object_api_name：employment</para>
        /// <para>- custom_api_name：reason_for_offboarding</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("reason_for_offboarding")]
        public Enum? ReasonForOffboarding { get; set; }

        /// <summary>
        /// <para>工作邮箱地址</para>
        /// <para>- 计算字段，取自work_email_list 中</para>
        /// <para>- email_usage: work</para>
        /// <para>- is_primary: true</para>
        /// <para>必填：否</para>
        /// <para>示例值：test@163.com</para>
        /// </summary>
        [JsonPropertyName("email_address")]
        public string? EmailAddress { get; set; }

        /// <summary>
        /// <para>工作邮箱列表，只有当邮箱满足下面所有条件时，才在个人信息页面可见</para>
        /// <para>- email_usage: work</para>
        /// <para>- is_primary: true</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("work_email_list")]
        public WorkEmail[]? WorkEmailLists { get; set; }

        /// <summary>
        /// <para>工作邮箱列表，只有当邮箱满足下面所有条件时，才在个人信息页面可见</para>
        /// <para>- email_usage: work</para>
        /// <para>- is_primary: true</para>
        /// </summary>
        public record WorkEmail
        {
            /// <summary>
            /// <para>邮箱地址</para>
            /// <para>必填：是</para>
            /// <para>示例值：1234567@example.feishu.cn</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string Email { get; set; } = string.Empty;

            /// <summary>
            /// <para>邮箱用途</para>
            /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name: email</para>
            /// <para>- custom_api_name：email_usage</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("email_usage")]
            public Enum? EmailUsage { get; set; }
        }

        /// <summary>
        /// <para>成本中心列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("cost_center_list")]
        public JobDataCostCenter[]? CostCenterLists { get; set; }

        /// <summary>
        /// <para>成本中心列表</para>
        /// </summary>
        public record JobDataCostCenter
        {
            /// <summary>
            /// <para>成本中心 ID，可以通过[搜索成本中心信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口获取对应的成本中心信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：6950635856373745165</para>
            /// </summary>
            [JsonPropertyName("cost_center_id")]
            public string? CostCenterId { get; set; }

            /// <summary>
            /// <para>分摊比例(整数)</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("rate")]
            public int? Rate { get; set; }

            /// <summary>
            /// <para>分摊比例</para>
            /// <para>必填：否</para>
            /// <para>示例值：50.2</para>
            /// </summary>
            [JsonPropertyName("new_rate")]
            public float? NewRate { get; set; }
        }

        /// <summary>
        /// <para>是否离职重聘，枚举如下：</para>
        /// <para>- no：否</para>
        /// <para>- yes：是</para>
        /// <para>- to_be_confirmed：待确定</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("rehire")]
        public Enum? Rehire { get; set; }

        /// <summary>
        /// <para>历史雇佣信息 ID，可通过此接口查询详情</para>
        /// <para>必填：否</para>
        /// <para>示例值：7164286667866966659</para>
        /// </summary>
        [JsonPropertyName("rehire_employment_id")]
        public string? RehireEmploymentId { get; set; }

        /// <summary>
        /// <para>基本个人信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("person_info")]
        public EmployeePersonInfo? PersonInfo { get; set; }

        /// <summary>
        /// <para>基本个人信息</para>
        /// </summary>
        public record EmployeePersonInfo
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
            /// <para>- 该值取自 person_info.phone_list 中满足以下条件的个人电话</para>
            /// <para>- is_primary=true</para>
            /// <para>- device_type=mobile_phone</para>
            /// <para>- phone_usage=home</para>
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
            /// <para>- 基于 local_primary、local_first_name、name_primary、first_name 等字段计算获得</para>
            /// <para>必填：否</para>
            /// <para>示例值：刘梓新(Henry)</para>
            /// </summary>
            [JsonPropertyName("preferred_name")]
            public string? PreferredName { get; set; }

            /// <summary>
            /// <para>别名</para>
            /// <para>必填：否</para>
            /// <para>示例值：梓新</para>
            /// </summary>
            [JsonPropertyName("additional_name")]
            public string? AdditionalName { get; set; }

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
            /// <para>性别</para>
            /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name：person</para>
            /// <para>- custom_api_name：gender</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("gender")]
            public Enum? Gender { get; set; }

            /// <summary>
            /// <para>出生日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-01-01</para>
            /// </summary>
            [JsonPropertyName("date_of_birth")]
            public string? DateOfBirth { get; set; }

            /// <summary>
            /// <para>国籍 ID，可通过[【查询国籍信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-nationality/search)查询</para>
            /// <para>必填：否</para>
            /// <para>示例值：6862995757234914821</para>
            /// </summary>
            [JsonPropertyName("nationality_id_v2")]
            public string? NationalityIdV2 { get; set; }

            /// <summary>
            /// <para>民族 / 种族</para>
            /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name：person</para>
            /// <para>- custom_api_name：ethnicity_race</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("race")]
            public Enum? Race { get; set; }

            /// <summary>
            /// <para>婚姻状况</para>
            /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name：person</para>
            /// <para>- custom_api_name：marital_status</para>
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
            /// <para>地址列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("address_list")]
            public Address[]? AddressLists { get; set; }

            /// <summary>
            /// <para>邮箱列表</para>
            /// <para>- 请使用 work_email_list 获取工作邮箱</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("email_list")]
            public Email[]? EmailLists { get; set; }

            /// <summary>
            /// <para>邮箱列表</para>
            /// <para>- 请使用 work_email_list 获取工作邮箱</para>
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
                /// <para>邮箱用途</para>
                /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
                /// <para>- object_api_name: email</para>
                /// <para>- custom_api_name：email_usage</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("email_usage")]
                public Enum? EmailUsage { get; set; }
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
                /// <para>- 请参考[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }
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
                /// <para>- 自定义名称时返回该字段</para>
                /// <para>- 下拉框选择的返回 school_name 字段</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("school")]
                public I18n[] Schools { get; set; } = Array.Empty<I18n>();

                /// <summary>
                /// <para>学历</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("level_of_education")]
                public Enum? LevelOfEducation { get; set; }

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
                /// <para>- 自定义名称时返回该字段</para>
                /// <para>- 下拉框选择的返回 field_of_study_name 字段</para>
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
                /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
                /// <para>- object_api_name：education</para>
                /// <para>- custom_api_name：school_name</para>
                /// <para>- 自定义名称时返回 school 字段</para>
                /// <para>- 下拉框选择的返回该字段</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("school_name")]
                public Enum? SchoolName { get; set; }

                /// <summary>
                /// <para>专业名称</para>
                /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
                /// <para>- object_api_name：education</para>
                /// <para>- custom_api_name：field_of_study_name</para>
                /// <para>- 自定义名称时返回 field_of_study 字段</para>
                /// <para>- 下拉框选择的返回该字段</para>
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
                /// <para>- 请参考[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }
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
                /// <para>银行名称。当在飞书人事找不到银行下拉选项，手动填写文本时，请通过此字段获取结果</para>
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
                /// <para>支行名称。当在飞书人事找不到支行下拉选项，手动填写文本时，请通过此字段获取结果</para>
                /// <para>必填：否</para>
                /// <para>示例值：中国农业银行支行</para>
                /// </summary>
                [JsonPropertyName("branch_name")]
                public string? BranchName { get; set; }

                /// <summary>
                /// <para>银行 ID，详细信息可通过[【查询银行信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-bank/search)查询。当在飞书人事选择具体银行下拉选项时，请通过此字段获取结果</para>
                /// <para>必填：否</para>
                /// <para>示例值：MDBH00000001</para>
                /// </summary>
                [JsonPropertyName("bank_id_v2")]
                public string? BankIdV2 { get; set; }

                /// <summary>
                /// <para>支行 ID，要求必须为填入银行的支行，详细信息可通过[【查询支行信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-bank_branch/search)查询。当在飞书人事选择具体支行下拉选项时，请通过此字段获取结果</para>
                /// <para>必填：否</para>
                /// <para>示例值：MDBK00000017</para>
                /// </summary>
                [JsonPropertyName("branch_id_v2")]
                public string? BranchIdV2 { get; set; }

                /// <summary>
                /// <para>国家/地区</para>
                /// <para>- 可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取</para>
                /// <para>必填：否</para>
                /// <para>示例值：12</para>
                /// </summary>
                [JsonPropertyName("country_region_id")]
                public string? CountryRegionId { get; set; }

                /// <summary>
                /// <para>银行卡用途</para>
                /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
                /// <para>- object_api_name: bank_account</para>
                /// <para>- custom_api_name: bank_account_usage</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("bank_account_usage")]
                public Enum[]? BankAccountUsages { get; set; }

                /// <summary>
                /// <para>银行卡类型</para>
                /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
                /// <para>- object_api_name: bank_account</para>
                /// <para>- custom_api_name: bank_account_type</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("bank_account_type")]
                public Enum? BankAccountType { get; set; }

                /// <summary>
                /// <para>分配方式</para>
                /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
                /// <para>- object_api_name: bank_account</para>
                /// <para>- custom_api_name: payment_type</para>
                /// <para>必填：否</para>
                /// <para>示例值：balance</para>
                /// </summary>
                [JsonPropertyName("payment_type")]
                public Enum? PaymentType { get; set; }

                /// <summary>
                /// <para>分配比例</para>
                /// <para>- 数字类型，最多精确两位小数</para>
                /// <para>必填：否</para>
                /// <para>示例值：70.21</para>
                /// </summary>
                [JsonPropertyName("payment_rate")]
                public string? PaymentRate { get; set; }

                /// <summary>
                /// <para>分配金额</para>
                /// <para>- 数字类型，最多精确两位小数</para>
                /// <para>必填：否</para>
                /// <para>示例值：5000</para>
                /// </summary>
                [JsonPropertyName("payment_amount")]
                public string? PaymentAmount { get; set; }

                /// <summary>
                /// <para>分配优先级</para>
                /// <para>- 升序，即该值越小，优先级越高</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("priority")]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>货币id，可通过[【查询货币信息v2】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-currency/search)查询</para>
                /// <para>必填：否</para>
                /// <para>示例值：12</para>
                /// </summary>
                [JsonPropertyName("currency_id")]
                public string? CurrencyId { get; set; }

                /// <summary>
                /// <para>国际银行账号</para>
                /// <para>必填：否</para>
                /// <para>示例值：CH56 0483 5012 3456 7800 9</para>
                /// </summary>
                [JsonPropertyName("IBAN")]
                public string? IBAN { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// <para>- 请参考[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }
            }

            /// <summary>
            /// <para>证件</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("national_id_list")]
            public NationalId[]? NationalIdLists { get; set; }

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
                /// <para>关系</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("relationship")]
                public Enum Relationship { get; set; } = new();

                /// <summary>
                /// <para>性别</para>
                /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
                /// <para>- object_api_name：person</para>
                /// <para>- custom_api_name：gender</para>
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
                /// <para>国籍 ID，可通过[【查询国籍信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-nationality/search)查询</para>
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
                /// <para>配偶工作状态</para>
                /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
                /// <para>- object_api_name：dependent</para>
                /// <para>- custom_api_name：spouses_working_status</para>
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
                /// <para>- 请参考[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }

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
                public Phone? Phone { get; set; }

                /// <summary>
                /// <para>联系地址</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("address")]
                public Address? Address { get; set; }

                /// <summary>
                /// <para>出生证明</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("birth_certificate_of_child")]
                public File[]? BirthCertificateOfChilds { get; set; }
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
                /// <para>关系</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("relationship")]
                public Enum? Relationship { get; set; }

                /// <summary>
                /// <para>电话</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("phone_ist")]
                public Phone[]? PhoneIsts { get; set; }

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
                /// <para>- 请参考[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }

                /// <summary>
                /// <para>联系地址</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("address")]
                public Address? Address { get; set; }
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
            /// <para>个人邮箱地址</para>
            /// <para>- 计算字段，取自 person_info.email_list 中</para>
            /// <para>- email_usage: home</para>
            /// <para>- is_primary: true</para>
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
                /// <para>资料类型</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("personal_profile_type")]
                public Enum? PersonalProfileType { get; set; }

                /// <summary>
                /// <para>上传文件列表</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("files")]
                public File[]? Files { get; set; }
            }

            /// <summary>
            /// <para>籍贯 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863326262618752111</para>
            /// </summary>
            [JsonPropertyName("native_region")]
            public string? NativeRegion { get; set; }

            /// <summary>
            /// <para>户口类型</para>
            /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name: person_info_chn</para>
            /// <para>- custom_api_name: hukou_type</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("hukou_type")]
            public Enum? HukouType { get; set; }

            /// <summary>
            /// <para>户口所在地</para>
            /// <para>必填：否</para>
            /// <para>示例值：山东省平阴县</para>
            /// </summary>
            [JsonPropertyName("hukou_location")]
            public string? HukouLocation { get; set; }

            /// <summary>
            /// <para>政治面貌</para>
            /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name：person_info_chn</para>
            /// <para>- custom_api_name：political_affiliation</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("political_affiliations")]
            public Enum[]? PoliticalAffiliations { get; set; }

            /// <summary>
            /// <para>人才 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863326262618752123</para>
            /// </summary>
            [JsonPropertyName("talent_id")]
            public string? TalentId { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>- 请参考[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public CustomFieldData[]? CustomFields { get; set; }

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
                /// <para>居民身份</para>
                /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
                /// <para>- object_api_name: resident_tax</para>
                /// <para>- custom_api_name: resident_status</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("resident_status")]
                public Enum? ResidentStatus { get; set; }

                /// <summary>
                /// <para>国家/地区</para>
                /// <para>- 可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取</para>
                /// <para>必填：否</para>
                /// <para>示例值：中国</para>
                /// </summary>
                [JsonPropertyName("tax_country_region_id")]
                public string? TaxCountryRegionId { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// <para>- 请参考[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public ObjectFieldData[]? CustomFields { get; set; }
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

            /// <summary>
            /// <para>宗教信仰</para>
            /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name：person</para>
            /// <para>- custom_api_name：religion</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("religion")]
            public Enum? Religion { get; set; }

            /// <summary>
            /// <para>工龄 浮点类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：2.1</para>
            /// </summary>
            [JsonPropertyName("working_years_v2")]
            public float? WorkingYearsV2 { get; set; }
        }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>- 请参考[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public CustomFieldData[]? CustomFields { get; set; }

        /// <summary>
        /// <para>竞业状态</para>
        /// <para>- 可通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
        /// <para>- object_api_name：employment</para>
        /// <para>- custom_api_name：noncompete_status</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("noncompete_status")]
        public Enum? NoncompeteStatus { get; set; }

        /// <summary>
        /// <para>是否历史离职人员</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("past_offboarding")]
        public bool? PastOffboarding { get; set; }

        /// <summary>
        /// <para>转正式日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-01-01</para>
        /// </summary>
        [JsonPropertyName("regular_employee_start_date")]
        public string? RegularEmployeeStartDate { get; set; }

        /// <summary>
        /// <para>外部系统 ID , 可存储租户系统中的员工 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：10000000</para>
        /// </summary>
        [JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// <para>入职次数</para>
        /// <para>必填：否</para>
        /// <para>示例值：16</para>
        /// </summary>
        [JsonPropertyName("times_employed")]
        public int? TimesEmployed { get; set; }

        /// <summary>
        /// <para>招聘来源</para>
        /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
        /// <para>- object_api_name：employment</para>
        /// <para>- custom_api_name：recruitment_type</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("recruitment_type")]
        public Enum? RecruitmentType { get; set; }

        /// <summary>
        /// <para>员工头像</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/v2_a550d36b-28ef-48ad-9e50-58004beb386j~?image_size=noop&amp;cut_type=&amp;quality=&amp;format=png&amp;sticker_format=.webp</para>
        /// </summary>
        [JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// <para>主合同 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7164286667866966659</para>
        /// </summary>
        [JsonPropertyName("primary_contract_id")]
        public string? PrimaryContractId { get; set; }

        /// <summary>
        /// <para>主合同开始日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-01-01</para>
        /// </summary>
        [JsonPropertyName("contract_start_date")]
        public string? ContractStartDate { get; set; }

        /// <summary>
        /// <para>主合同到期日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-01-01</para>
        /// </summary>
        [JsonPropertyName("contract_end_date")]
        public string? ContractEndDate { get; set; }

        /// <summary>
        /// <para>主合同预计到期日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-01-01</para>
        /// </summary>
        [JsonPropertyName("contract_expected_end_date")]
        public string? ContractExpectedEndDate { get; set; }

        /// <summary>
        /// <para>所属薪资组 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7164286667866966659</para>
        /// </summary>
        [JsonPropertyName("pay_group_id")]
        public string? PayGroupId { get; set; }

        /// <summary>
        /// <para>所属外派薪资组 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7164286667866966659</para>
        /// </summary>
        [JsonPropertyName("assignment_pay_group_id")]
        public string? AssignmentPayGroupId { get; set; }

        /// <summary>
        /// <para>是否外派</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("international_assignment")]
        public bool? InternationalAssignment { get; set; }

        /// <summary>
        /// <para>工作日历 ID</para>
        /// <para>- 可通过[【查询工作日历】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/leave/work_calendar)查询</para>
        /// <para>必填：否</para>
        /// <para>示例值：7164286667866966659</para>
        /// </summary>
        [JsonPropertyName("work_calendar_id")]
        public string? WorkCalendarId { get; set; }

        /// <summary>
        /// <para>部门基本信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department")]
        public BasicDepartment? Department { get; set; }

        /// <summary>
        /// <para>部门基本信息</para>
        /// </summary>
        public record BasicDepartment
        {
            /// <summary>
            /// <para>部门 ID</para>
            /// <para>- 类型与 department_id_type 一致，转换失败时返回空值</para>
            /// <para>- 请使用 id_v2</para>
            /// <para>必填：否</para>
            /// <para>示例值：4719456877659520852</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>部门 ID</para>
            /// <para>- 类型与 department_id_type 一致，转换失败时返回空值</para>
            /// <para>必填：否</para>
            /// <para>示例值：4719456877659520852</para>
            /// </summary>
            [JsonPropertyName("id_v2")]
            public string? IdV2 { get; set; }

            /// <summary>
            /// <para>部门名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("department_name")]
            public I18n[]? DepartmentNames { get; set; }
        }

        /// <summary>
        /// <para>直接上级基本信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("direct_manager")]
        public BasicEmployee? DirectManager { get; set; }

        /// <summary>
        /// <para>直接上级基本信息</para>
        /// </summary>
        public record BasicEmployee
        {
            /// <summary>
            /// <para>雇佣 ID</para>
            /// <para>- 类型与 user_id_type 一致</para>
            /// <para>- 请使用 employment_id_v2</para>
            /// <para>必填：否</para>
            /// <para>示例值：6893014062142064135</para>
            /// </summary>
            [JsonPropertyName("employment_id")]
            public string? EmploymentId { get; set; }

            /// <summary>
            /// <para>雇佣 ID</para>
            /// <para>- 类型与 user_id_type 一致，转换失败时返回空值</para>
            /// <para>必填：否</para>
            /// <para>示例值：6893014062142064135</para>
            /// </summary>
            [JsonPropertyName("employment_id_v2")]
            public string? EmploymentIdV2 { get; set; }

            /// <summary>
            /// <para>工号</para>
            /// <para>必填：否</para>
            /// <para>示例值：1000000</para>
            /// </summary>
            [JsonPropertyName("employee_number")]
            public string? EmployeeNumber { get; set; }

            /// <summary>
            /// <para>邮箱地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：test@163.com</para>
            /// </summary>
            [JsonPropertyName("email_address")]
            public string? EmailAddress { get; set; }

            /// <summary>
            /// <para>基本个人信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("person_info")]
            public BasicPersonInfo? PersonInfo { get; set; }

            /// <summary>
            /// <para>基本个人信息</para>
            /// </summary>
            public record BasicPersonInfo
            {
                /// <summary>
                /// <para>个人信息 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6919733936050406926</para>
                /// </summary>
                [JsonPropertyName("person_id")]
                public string? PersonId { get; set; }

                /// <summary>
                /// <para>常用名</para>
                /// <para>- 基于 local_primary、local_first_name、name_primary、first_name 等字段计算获得</para>
                /// <para>必填：否</para>
                /// <para>示例值：刘梓新</para>
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
            }
        }

        /// <summary>
        /// <para>虚线上级基本信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("dotted_line_manager")]
        public BasicEmployee? DottedLineManager { get; set; }

        /// <summary>
        /// <para>时区</para>
        /// <para>必填：否</para>
        /// <para>示例值：Asia/Shanghai</para>
        /// </summary>
        [JsonPropertyName("time_zone")]
        public string? TimeZone { get; set; }

        /// <summary>
        /// <para>任职公司</para>
        /// <para>必填：否</para>
        /// <para>示例值：7174374910734141112</para>
        /// </summary>
        [JsonPropertyName("service_company")]
        public string? ServiceCompany { get; set; }

        /// <summary>
        /// <para>薪资类型</para>
        /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
        /// <para>- object_api_name：job_data</para>
        /// <para>- custom_api_name：compensation_type</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("compensation_type")]
        public Enum? CompensationType { get; set; }

        /// <summary>
        /// <para>排班类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("work_shift")]
        public Enum? WorkShift { get; set; }

        /// <summary>
        /// <para>自定义组织</para>
        /// <para>- 功能灰度中，有需要请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
        /// <para>必填：否</para>
        /// <para>示例值：{\"custom_org_02\":[{\"id\":\"1\",\"rate\":\"99\"}]}</para>
        /// </summary>
        [JsonPropertyName("custom_org")]
        public string? CustomOrg { get; set; }

        /// <summary>
        /// <para>司龄调整信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("seniority_adjust_information_list")]
        public SeniorityAdjustInformation[]? SeniorityAdjustInformationLists { get; set; }

        /// <summary>
        /// <para>司龄调整信息</para>
        /// </summary>
        public record SeniorityAdjustInformation
        {
            /// <summary>
            /// <para>调整类型</para>
            /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name：seniority_adjust_information</para>
            /// <para>- custom_api_name：seniority_adjustment_type</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("seniority_adjustment_type")]
            public Enum SeniorityAdjustmentType { get; set; } = new();

            /// <summary>
            /// <para>开始日期</para>
            /// <para>- 格式： yyyy-mm-dd</para>
            /// <para>必填：否</para>
            /// <para>示例值：2024-01-01</para>
            /// </summary>
            [JsonPropertyName("start_date")]
            public string? StartDate { get; set; }

            /// <summary>
            /// <para>结束日期</para>
            /// <para>- 格式： yyyy-mm-dd</para>
            /// <para>必填：否</para>
            /// <para>示例值：2024-10-01</para>
            /// </summary>
            [JsonPropertyName("end_date")]
            public string? EndDate { get; set; }

            /// <summary>
            /// <para>调整值</para>
            /// <para>- 精确度：两位小数</para>
            /// <para>- 单位：年</para>
            /// <para>必填：是</para>
            /// <para>示例值：1.01</para>
            /// <para>最大值：100</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("seniority_adjustment")]
            public float SeniorityAdjustment { get; set; }

            /// <summary>
            /// <para>调整原因</para>
            /// <para>必填：否</para>
            /// <para>示例值：工厂停产需要减去半年工龄</para>
            /// </summary>
            [JsonPropertyName("reasons_for_seniority_adjustment")]
            public string? ReasonsForSeniorityAdjustment { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>- 具体支持的对象请参考[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
            /// <para>必填：否</para>
            /// <para>最大长度：180</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public CustomFieldData[]? CustomFields { get; set; }
        }

        /// <summary>
        /// <para>员工直属 BP 信息，当员工所在部门、属地无 BP 时，会上钻找到最近的 BP</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("employment_direct_bps")]
        public EmploymentBp? EmploymentDirectBps { get; set; }

        /// <summary>
        /// <para>员工直属 BP 信息，当员工所在部门、属地无 BP 时，会上钻找到最近的 BP</para>
        /// </summary>
        public record EmploymentBp
        {
            /// <summary>
            /// <para>员工直属 HRBP 雇佣 ID，若员工是部门负责人，且同部门 HRBP 在权限中配置了 HRBP 不可见部门负责人，则在结果中不会出现该 HRBP</para>
            /// <para>- 类型与 user_id_type 一致</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("hrbp_ids")]
            public string[]? HrbpIds { get; set; }

            /// <summary>
            /// <para>员工直属属地 BP 雇佣 ID</para>
            /// <para>- 类型与 user_id_type 一致</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("location_bp_ids")]
            public string[]? LocationBpIds { get; set; }
        }

        /// <summary>
        /// <para>员工全部 BP 信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("employment_all_bps")]
        public EmploymentBp? EmploymentAllBps { get; set; }

        /// <summary>
        /// <para>当前所属合同类型</para>
        /// <para>- 可通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)查询</para>
        /// <para>- object_api_name：contract</para>
        /// <para>- custom_api_name：contract_type</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("contract_type")]
        public Enum? ContractType { get; set; }

        /// <summary>
        /// <para>当前所属薪资方案 ID</para>
        /// <para>- 可结合[批量查询薪资方案](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/plan/list)接口使用</para>
        /// <para>必填：否</para>
        /// <para>示例值：123456789</para>
        /// </summary>
        [JsonPropertyName("archive_cpst_plan_id")]
        public string? ArchiveCpstPlanId { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eyJldV9uYyI6IlswLFwiNjk2MTI4Njg0NjA5Mzc4ODY4MC03MjExMDM0ODcxMjA3OTUzOTc1XCJdIn0</para>
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
