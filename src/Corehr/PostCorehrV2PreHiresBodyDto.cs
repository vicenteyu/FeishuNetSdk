// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-28
// ************************************************************************
// <copyright file="PostCorehrV2PreHiresBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>直接创建待入职 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 直接创建待入职 请求体
/// <para>使用指定数据创建一个待入职人员。</para>
/// <para>接口ID：7160511371865014276</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/pre_hire/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fcreate</para>
/// </summary>
public record PostCorehrV2PreHiresBodyDto
{
    /// <summary>
    /// <para>个人信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("basic_info")]
    public PostCorehrV2PreHiresBodyDtoBasicInfo BasicInfo { get; set; } = new();

    /// <summary>
    /// <para>个人信息</para>
    /// </summary>
    public record PostCorehrV2PreHiresBodyDtoBasicInfo
    {
        /// <summary>
        /// <para>常用名</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public PostCorehrV2PreHiresBodyDtoBasicInfoName? Name { get; set; }

        /// <summary>
        /// <para>常用名</para>
        /// </summary>
        public record PostCorehrV2PreHiresBodyDtoBasicInfoName
        {
            /// <summary>
            /// <para>全名</para>
            /// <para>必填：否</para>
            /// <para>示例值：李一一</para>
            /// </summary>
            [JsonPropertyName("full_name")]
            public string? FullName { get; set; }

            /// <summary>
            /// <para>名</para>
            /// <para>必填：否</para>
            /// <para>示例值：一</para>
            /// </summary>
            [JsonPropertyName("first_name")]
            public string? FirstName { get; set; }

            /// <summary>
            /// <para>中间名</para>
            /// <para>必填：否</para>
            /// <para>示例值：一</para>
            /// </summary>
            [JsonPropertyName("middle_name")]
            public string? MiddleName { get; set; }

            /// <summary>
            /// <para>姓</para>
            /// <para>必填：否</para>
            /// <para>示例值：李</para>
            /// </summary>
            [JsonPropertyName("name_primary")]
            public string? NamePrimary { get; set; }

            /// <summary>
            /// <para>名 - 本地文字</para>
            /// <para>必填：否</para>
            /// <para>示例值：一</para>
            /// </summary>
            [JsonPropertyName("local_first_name")]
            public string? LocalFirstName { get; set; }

            /// <summary>
            /// <para>本地中间名</para>
            /// <para>必填：否</para>
            /// <para>示例值：一</para>
            /// </summary>
            [JsonPropertyName("local_middle_name")]
            public string? LocalMiddleName { get; set; }

            /// <summary>
            /// <para>姓 - 本地文字</para>
            /// <para>必填：否</para>
            /// <para>示例值：李</para>
            /// </summary>
            [JsonPropertyName("local_primary")]
            public string? LocalPrimary { get; set; }

            /// <summary>
            /// <para>国家 / 地区，可以通过接口[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获得</para>
            /// <para>必填：否</para>
            /// <para>示例值：6862995757234914824</para>
            /// </summary>
            [JsonPropertyName("country_region_id")]
            public string? CountryRegionId { get; set; }

            /// <summary>
            /// <para>本地文字的自定义姓名</para>
            /// <para>必填：否</para>
            /// <para>示例值：李一一</para>
            /// </summary>
            [JsonPropertyName("custom_local_name")]
            public string? CustomLocalName { get; set; }

            /// <summary>
            /// <para>西方文字的自定义姓名</para>
            /// <para>必填：否</para>
            /// <para>示例值：YiyiLi</para>
            /// </summary>
            [JsonPropertyName("custom_western_name")]
            public string? CustomWesternName { get; set; }
        }

        /// <summary>
        /// <para>手机号</para>
        /// <para>必填：否</para>
        /// <para>示例值：31123227</para>
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// <para>区号，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
        /// <para>- object_api_name = phone</para>
        /// <para>- custom_api_name = international_area_code</para>
        /// <para>必填：否</para>
        /// <para>示例值：86_china</para>
        /// </summary>
        [JsonPropertyName("international_area_code")]
        public string? InternationalAreaCode { get; set; }

        /// <summary>
        /// <para>个人邮箱</para>
        /// <para>必填：否</para>
        /// <para>示例值：1234567@bytedance.com</para>
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// <para>生日</para>
        /// <para>必填：否</para>
        /// <para>示例值：2011-09-09</para>
        /// </summary>
        [JsonPropertyName("date_of_birth")]
        public string? DateOfBirth { get; set; }

        /// <summary>
        /// <para>证件号（待废弃，建议使用national_id_list）</para>
        /// <para>必填：否</para>
        /// <para>示例值：31123127</para>
        /// </summary>
        [JsonPropertyName("personal_id_number")]
        public string? PersonalIdNumber { get; set; }

        /// <summary>
        /// <para>证件类型（待废弃，建议使用national_id_list），可以通过[批量查询国家证件类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/national_id_type/list)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6862995757234914823</para>
        /// </summary>
        [JsonPropertyName("personal_id_type")]
        public string? PersonalIdType { get; set; }

        /// <summary>
        /// <para>参加工作日期，格式："YYYY-MM-DD"</para>
        /// <para>必填：否</para>
        /// <para>示例值：2010-09-09</para>
        /// </summary>
        [JsonPropertyName("date_entered_workforce")]
        public string? DateEnteredWorkforce { get; set; }

        /// <summary>
        /// <para>性别，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
        /// <para>- object_api_name = person</para>
        /// <para>- custom_api_name = gender</para>
        /// <para>必填：否</para>
        /// <para>示例值：male</para>
        /// </summary>
        [JsonPropertyName("gender_id")]
        public string? GenderId { get; set; }

        /// <summary>
        /// <para>国籍（新），可以通过[查询国籍信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-nationality/search)接口获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6862995757234914824</para>
        /// </summary>
        [JsonPropertyName("nationality_v2_id")]
        public string? NationalityV2Id { get; set; }

        /// <summary>
        /// <para>其他国籍，可以通过[查询国籍信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-nationality/search)接口获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：[6862995757234914824]</para>
        /// </summary>
        [JsonPropertyName("additional_nationality_id_list")]
        public string[]? AdditionalNationalityIdList { get; set; }

        /// <summary>
        /// <para>公民身份，如需获取具体值，请联系人员档案管理员</para>
        /// <para>必填：否</para>
        /// <para>示例值：[6862995757234914824]</para>
        /// </summary>
        [JsonPropertyName("citizenship_status_id_list")]
        public string[]? CitizenshipStatusIdList { get; set; }

        /// <summary>
        /// <para>家庭地址（待废弃）</para>
        /// <para>必填：否</para>
        /// <para>示例值：home addr</para>
        /// </summary>
        [JsonPropertyName("home_address")]
        public string? HomeAddress { get; set; }

        /// <summary>
        /// <para>人员编号</para>
        /// <para>必填：否</para>
        /// <para>示例值：DDD00001</para>
        /// </summary>
        [JsonPropertyName("worker_id")]
        public string? WorkerId { get; set; }

        /// <summary>
        /// <para>数据驻留地（部分租户开通此功能），枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取。</para>
        /// <para>按如下参数查询即可：</para>
        /// <para>- object_api_name = pre_hire</para>
        /// <para>- custom_api_name = user_geo</para>
        /// <para>必填：否</para>
        /// <para>示例值：cn</para>
        /// </summary>
        [JsonPropertyName("user_geo")]
        public string? UserGeo { get; set; }

        /// <summary>
        /// <para>法定姓名</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("legal_name")]
        public NameSuffix? LegalName { get; set; }

        /// <summary>
        /// <para>法定姓名</para>
        /// </summary>
        public record NameSuffix
        {
            /// <summary>
            /// <para>全名</para>
            /// <para>必填：否</para>
            /// <para>示例值：李一一</para>
            /// </summary>
            [JsonPropertyName("full_name")]
            public string? FullName { get; set; }

            /// <summary>
            /// <para>名</para>
            /// <para>必填：否</para>
            /// <para>示例值：一</para>
            /// </summary>
            [JsonPropertyName("first_name")]
            public string? FirstName { get; set; }

            /// <summary>
            /// <para>中间名</para>
            /// <para>必填：否</para>
            /// <para>示例值：一</para>
            /// </summary>
            [JsonPropertyName("middle_name")]
            public string? MiddleName { get; set; }

            /// <summary>
            /// <para>姓</para>
            /// <para>必填：否</para>
            /// <para>示例值：李</para>
            /// </summary>
            [JsonPropertyName("name_primary")]
            public string? NamePrimary { get; set; }

            /// <summary>
            /// <para>名 - 本地文字</para>
            /// <para>必填：否</para>
            /// <para>示例值：一</para>
            /// </summary>
            [JsonPropertyName("local_first_name")]
            public string? LocalFirstName { get; set; }

            /// <summary>
            /// <para>本地中间名</para>
            /// <para>必填：否</para>
            /// <para>示例值：一</para>
            /// </summary>
            [JsonPropertyName("local_middle_name")]
            public string? LocalMiddleName { get; set; }

            /// <summary>
            /// <para>姓 - 本地文字</para>
            /// <para>必填：否</para>
            /// <para>示例值：李</para>
            /// </summary>
            [JsonPropertyName("local_primary")]
            public string? LocalPrimary { get; set; }

            /// <summary>
            /// <para>国家 / 地区，可以通过接口[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获得</para>
            /// <para>必填：否</para>
            /// <para>示例值：6862995757234914824</para>
            /// </summary>
            [JsonPropertyName("country_region_id")]
            public string? CountryRegionId { get; set; }

            /// <summary>
            /// <para>本地文字的自定义姓名</para>
            /// <para>必填：否</para>
            /// <para>示例值：李一一</para>
            /// </summary>
            [JsonPropertyName("custom_local_name")]
            public string? CustomLocalName { get; set; }

            /// <summary>
            /// <para>西方文字的自定义姓名</para>
            /// <para>必填：否</para>
            /// <para>示例值：YiyiLi</para>
            /// </summary>
            [JsonPropertyName("custom_western_name")]
            public string? CustomWesternName { get; set; }
        }

        /// <summary>
        /// <para>纳税身份信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("resident_tax_list")]
        public ResidentTaxForUpdate[]? ResidentTaxLists { get; set; }

        /// <summary>
        /// <para>纳税身份信息</para>
        /// </summary>
        public record ResidentTaxForUpdate
        {
            /// <summary>
            /// <para>国家 / 地区ID，可以通过接口[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获得</para>
            /// <para>必填：否</para>
            /// <para>示例值：6862995757234914824</para>
            /// </summary>
            [JsonPropertyName("tax_country_region")]
            public string? TaxCountryRegion { get; set; }

            /// <summary>
            /// <para>居民身份，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- object_api_name = resident_tax</para>
            /// <para>- custom_api_name = resident_status</para>
            /// <para>必填：否</para>
            /// <para>示例值：tax_residence</para>
            /// </summary>
            [JsonPropertyName("resident_status")]
            public string? ResidentStatus { get; set; }

            /// <summary>
            /// <para>纳税地址</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("tax_address")]
            public AddressForUpdate? TaxAddress { get; set; }

            /// <summary>
            /// <para>纳税地址</para>
            /// </summary>
            public record AddressForUpdate
            {
                /// <summary>
                /// <para>国家 / 地区，可以通过接口[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获得</para>
                /// <para>必填：是</para>
                /// <para>示例值：6862995757234914824</para>
                /// </summary>
                [JsonPropertyName("country_region_id")]
                public string CountryRegionId { get; set; } = string.Empty;

                /// <summary>
                /// <para>主要行政区，可以通过接口[查询省份/行政区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)获得</para>
                /// <para>必填：否</para>
                /// <para>示例值：6863326815667095047</para>
                /// </summary>
                [JsonPropertyName("region_id")]
                public string? RegionId { get; set; }

                /// <summary>
                /// <para>地址行 1（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：北京市海淀区</para>
                /// </summary>
                [JsonPropertyName("local_address_line1")]
                public string? LocalAddressLine1 { get; set; }

                /// <summary>
                /// <para>地址行 2（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：上海市杨浦区</para>
                /// </summary>
                [JsonPropertyName("local_address_line2")]
                public string? LocalAddressLine2 { get; set; }

                /// <summary>
                /// <para>地址行 3（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：北京市房山区</para>
                /// </summary>
                [JsonPropertyName("local_address_line3")]
                public string? LocalAddressLine3 { get; set; }

                /// <summary>
                /// <para>地址行 4（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：天津滨海高新区</para>
                /// </summary>
                [JsonPropertyName("local_address_line4")]
                public string? LocalAddressLine4 { get; set; }

                /// <summary>
                /// <para>地址行 5（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：成都市成华区</para>
                /// </summary>
                [JsonPropertyName("local_address_line5")]
                public string? LocalAddressLine5 { get; set; }

                /// <summary>
                /// <para>地址行 6（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：深圳市南山区</para>
                /// </summary>
                [JsonPropertyName("local_address_line6")]
                public string? LocalAddressLine6 { get; set; }

                /// <summary>
                /// <para>地址行 7（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：南京市鼓楼区</para>
                /// </summary>
                [JsonPropertyName("local_address_line7")]
                public string? LocalAddressLine7 { get; set; }

                /// <summary>
                /// <para>地址行 8（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：杭州市滨江区</para>
                /// </summary>
                [JsonPropertyName("local_address_line8")]
                public string? LocalAddressLine8 { get; set; }

                /// <summary>
                /// <para>地址行 9（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：郑州市中原区</para>
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
                /// <para>地址类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：- object_api_name = "address" - custom_api_name = "address_type"</para>
                /// <para>必填：是</para>
                /// <para>最大长度：1000</para>
                /// <para>最小长度：1</para>
                /// </summary>
                [JsonPropertyName("address_types")]
                public string[] AddressTypes { get; set; } = Array.Empty<string>();

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
            }

            /// <summary>
            /// <para>居民纳税身份说明</para>
            /// <para>必填：否</para>
            /// <para>示例值：文本内容，对纳税身份的补充说明信息</para>
            /// </summary>
            [JsonPropertyName("resident_status_specification")]
            public string? ResidentStatusSpecification { get; set; }

            /// <summary>
            /// <para>年度</para>
            /// <para>必填：否</para>
            /// <para>示例值：2006-01-01</para>
            /// </summary>
            [JsonPropertyName("year_resident_tax")]
            public string? YearResidentTax { get; set; }
        }

        /// <summary>
        /// <para>出生国家/地区，可以通过[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：cn</para>
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
        /// <para>示例值：身份证号+残疾类型（1-7）+ 残疾程度分级（1-4）+[补发编号]</para>
        /// </summary>
        [JsonPropertyName("disable_card_number")]
        public string? DisableCardNumber { get; set; }

        /// <summary>
        /// <para>是否孤老</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_old_alone")]
        public bool? IsOldAlone { get; set; }

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
        /// <para>示例值：00001</para>
        /// </summary>
        [JsonPropertyName("martyr_card_number")]
        public string? MartyrCardNumber { get; set; }

        /// <summary>
        /// <para>家庭成员</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("dependent_list")]
        public DependentForUpdate[]? DependentLists { get; set; }

        /// <summary>
        /// <para>家庭成员</para>
        /// </summary>
        public record DependentForUpdate
        {
            /// <summary>
            /// <para>关系 ，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- object_api_name：dependent</para>
            /// <para>- custom_api_name：relationship_with_dependent</para>
            /// <para>必填：是</para>
            /// <para>示例值：parent</para>
            /// </summary>
            [JsonPropertyName("relationship")]
            public string Relationship { get; set; } = string.Empty;

            /// <summary>
            /// <para>性别 ，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- object_api_name：person</para>
            /// <para>- custom_api_name：gender</para>
            /// <para>必填：否</para>
            /// <para>示例值：male</para>
            /// </summary>
            [JsonPropertyName("gender")]
            public string? Gender { get; set; }

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
            /// <para>最大长度：1000</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("national_ids")]
            public NationalIdForUpdate[]? NationalIds { get; set; }

            /// <summary>
            /// <para>证件号码</para>
            /// </summary>
            public record NationalIdForUpdate
            {
                /// <summary>
                /// <para>国家/地区，可以通过[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口获取</para>
                /// <para>必填：是</para>
                /// <para>示例值：6862995757234914824</para>
                /// </summary>
                [JsonPropertyName("country_region_id")]
                public string CountryRegionId { get; set; } = string.Empty;

                /// <summary>
                /// <para>国家证件类型，可以通过[批量查询国家证件类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/national_id_type/list)接口获取</para>
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
                /// <para>证件签发日期，格式："YYYY-MM-DD"</para>
                /// <para>必填：否</para>
                /// <para>示例值：2020-04-01</para>
                /// </summary>
                [JsonPropertyName("issue_date")]
                public string? IssueDate { get; set; }

                /// <summary>
                /// <para>证件到期日期，格式："YYYY-MM-DD"</para>
                /// <para>必填：否</para>
                /// <para>示例值：2020-05-21</para>
                /// </summary>
                [JsonPropertyName("expiration_date")]
                public string? ExpirationDate { get; set; }

                /// <summary>
                /// <para>证件签发机构</para>
                /// <para>必填：否</para>
                /// <para>示例值：北京市公安局</para>
                /// </summary>
                [JsonPropertyName("issued_by")]
                public string? IssuedBy { get; set; }
            }

            /// <summary>
            /// <para>配偶工作状态，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- object_api_name：dependent</para>
            /// <para>- custom_api_name：spouses_working_status</para>
            /// <para>必填：否</para>
            /// <para>示例值：working</para>
            /// </summary>
            [JsonPropertyName("spouses_working_status")]
            public string? SpousesWorkingStatus { get; set; }

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
            /// <para>家庭成员姓名</para>
            /// <para>必填：否</para>
            /// <para>示例值：王冰</para>
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
            /// <para>岗位信息</para>
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
            public PhoneForUpdate? Phone { get; set; }

            /// <summary>
            /// <para>电话</para>
            /// </summary>
            public record PhoneForUpdate
            {
                /// <summary>
                /// <para>手机区号，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
                /// <para>- object_api_name：phone</para>
                /// <para>- custom_api_name：international_area_code</para>
                /// <para>必填：是</para>
                /// <para>示例值：86_china</para>
                /// </summary>
                [JsonPropertyName("international_area_code")]
                public string InternationalAreaCode { get; set; } = string.Empty;

                /// <summary>
                /// <para>电话号码</para>
                /// <para>必填：是</para>
                /// <para>示例值：010-12345678</para>
                /// </summary>
                [JsonPropertyName("phone_number")]
                public string PhoneNumber { get; set; } = string.Empty;

                /// <summary>
                /// <para>设备类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
                /// <para>- object_api_name：phone</para>
                /// <para>- custom_api_name：device_type</para>
                /// <para>必填：是</para>
                /// <para>示例值：mobile_phone</para>
                /// </summary>
                [JsonPropertyName("device_type")]
                public string DeviceType { get; set; } = string.Empty;

                /// <summary>
                /// <para>电话用途，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
                /// <para>- custom_api_name：phone_usage</para>
                /// <para>- object_api_name：phone</para>
                /// <para>必填：是</para>
                /// <para>示例值：home</para>
                /// </summary>
                [JsonPropertyName("phone_usage")]
                public string PhoneUsage { get; set; } = string.Empty;

                /// <summary>
                /// <para>主要电话，若有多个电话，只能有一个电话的「is_primary」为true</para>
                /// <para>必填：是</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_primary")]
                public bool IsPrimary { get; set; }

                /// <summary>
                /// <para>公开电话</para>
                /// <para>必填：是</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_public")]
                public bool IsPublic { get; set; }
            }

            /// <summary>
            /// <para>联系地址</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("address")]
            public AddressForUpdate? Address { get; set; }

            /// <summary>
            /// <para>联系地址</para>
            /// </summary>
            public record AddressForUpdate
            {
                /// <summary>
                /// <para>国家/地区，可以通过[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口获取</para>
                /// <para>必填：是</para>
                /// <para>示例值：6862995757234914824</para>
                /// </summary>
                [JsonPropertyName("country_region_id")]
                public string CountryRegionId { get; set; } = string.Empty;

                /// <summary>
                /// <para>主要行政区，可以通过[查询省份/行政区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)接口获取</para>
                /// <para>必填：否</para>
                /// <para>示例值：6863326815667095047</para>
                /// </summary>
                [JsonPropertyName("region_id")]
                public string? RegionId { get; set; }

                /// <summary>
                /// <para>地址行 1（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：北京市海淀区</para>
                /// </summary>
                [JsonPropertyName("local_address_line1")]
                public string? LocalAddressLine1 { get; set; }

                /// <summary>
                /// <para>地址行 2（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：上海市杨浦区</para>
                /// </summary>
                [JsonPropertyName("local_address_line2")]
                public string? LocalAddressLine2 { get; set; }

                /// <summary>
                /// <para>地址行 3（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：北京市房山区</para>
                /// </summary>
                [JsonPropertyName("local_address_line3")]
                public string? LocalAddressLine3 { get; set; }

                /// <summary>
                /// <para>地址行 4（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：天津滨海高新区</para>
                /// </summary>
                [JsonPropertyName("local_address_line4")]
                public string? LocalAddressLine4 { get; set; }

                /// <summary>
                /// <para>地址行 5（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：成都市成华区</para>
                /// </summary>
                [JsonPropertyName("local_address_line5")]
                public string? LocalAddressLine5 { get; set; }

                /// <summary>
                /// <para>地址行 6（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：深圳市南山区</para>
                /// </summary>
                [JsonPropertyName("local_address_line6")]
                public string? LocalAddressLine6 { get; set; }

                /// <summary>
                /// <para>地址行 7（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：南京市鼓楼区</para>
                /// </summary>
                [JsonPropertyName("local_address_line7")]
                public string? LocalAddressLine7 { get; set; }

                /// <summary>
                /// <para>地址行 8（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：杭州市滨江区</para>
                /// </summary>
                [JsonPropertyName("local_address_line8")]
                public string? LocalAddressLine8 { get; set; }

                /// <summary>
                /// <para>地址行 9（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：郑州市中原区</para>
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
                /// <para>地址类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
                /// <para>- custom_api_name：address_type</para>
                /// <para>- object_api_name：address</para>
                /// <para>必填：是</para>
                /// <para>最大长度：1000</para>
                /// <para>最小长度：1</para>
                /// </summary>
                [JsonPropertyName("address_types")]
                public string[] AddressTypes { get; set; } = Array.Empty<string>();

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
            }
        }

        /// <summary>
        /// <para>宗教信仰，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
        /// <para>- object_api_name：person</para>
        /// <para>- custom_api_name：religion</para>
        /// <para>必填：否</para>
        /// <para>示例值：buddism</para>
        /// </summary>
        [JsonPropertyName("religion")]
        public string? Religion { get; set; }

        /// <summary>
        /// <para>银行账号</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("bank_account_list")]
        public BankAccountForUpdate[]? BankAccountLists { get; set; }

        /// <summary>
        /// <para>银行账号</para>
        /// </summary>
        public record BankAccountForUpdate
        {
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
            /// <para>国家/地区，可以通过[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6862995745889322510</para>
            /// </summary>
            [JsonPropertyName("country_region_id")]
            public string? CountryRegionId { get; set; }

            /// <summary>
            /// <para>银行卡用途，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- custom_api_name：bank_account_usage</para>
            /// <para>- object_api_name：bank_account</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("bank_account_usages")]
            public string[]? BankAccountUsages { get; set; }

            /// <summary>
            /// <para>银行卡类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- custom_api_name：bank_account_type</para>
            /// <para>- object_api_name：bank_account</para>
            /// <para>必填：否</para>
            /// <para>示例值：checking</para>
            /// </summary>
            [JsonPropertyName("bank_account_type")]
            public string? BankAccountType { get; set; }
        }

        /// <summary>
        /// <para>国家证件</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("national_id_list")]
        public NationalIdForUpdate[]? NationalIdLists { get; set; }

        /// <summary>
        /// <para>国家证件</para>
        /// </summary>
        public record NationalIdForUpdate
        {
            /// <summary>
            /// <para>国家/地区，可以通过[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口获取</para>
            /// <para>必填：是</para>
            /// <para>示例值：6862995757234914824</para>
            /// </summary>
            [JsonPropertyName("country_region_id")]
            public string CountryRegionId { get; set; } = string.Empty;

            /// <summary>
            /// <para>国家证件类型，可以通过[批量查询国家证件类型](https://open.larkoffice.com/document/server-docs/corehr-v1/basic-infomation/national_id_type/list)接口获取</para>
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
            /// <para>证件签发机构</para>
            /// <para>必填：否</para>
            /// <para>示例值：北京市公安局</para>
            /// </summary>
            [JsonPropertyName("issued_by")]
            public string? IssuedBy { get; set; }
        }

        /// <summary>
        /// <para>个人资料</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("personal_profile_list")]
        public PersonalProfileForUpdate[]? PersonalProfileLists { get; set; }

        /// <summary>
        /// <para>个人资料</para>
        /// </summary>
        public record PersonalProfileForUpdate
        {
            /// <summary>
            /// <para>资料类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- object_api_name：personal_profile</para>
            /// <para>- custom_api_name：profile_type</para>
            /// <para>必填：否</para>
            /// <para>示例值：profile_type_1_101_101011</para>
            /// </summary>
            [JsonPropertyName("personal_profile_type")]
            public string? PersonalProfileType { get; set; }

            /// <summary>
            /// <para>资料文件列表</para>
            /// <para>必填：否</para>
            /// <para>最大长度：1000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("files")]
            public File[]? Files { get; set; }

            /// <summary>
            /// <para>资料文件列表</para>
            /// </summary>
            public record File
            {
                /// <summary>
                /// <para>上传文件ID，可以通过[上传文件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/person/upload)接口获取</para>
                /// <para>必填：否</para>
                /// <para>示例值：6655aa1b2ec326f983b91f9d_f9974583040c4b05ae71f92f5df16bbc</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }
            }
        }

        /// <summary>
        /// <para>紧急联系人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("emergency_contact_list")]
        public EmergencyContactForUpdate[]? EmergencyContactLists { get; set; }

        /// <summary>
        /// <para>紧急联系人</para>
        /// </summary>
        public record EmergencyContactForUpdate
        {
            /// <summary>
            /// <para>紧急联系人姓名</para>
            /// <para>必填：否</para>
            /// <para>示例值：王冰</para>
            /// </summary>
            [JsonPropertyName("legal_name")]
            public string? LegalName { get; set; }

            /// <summary>
            /// <para>紧急联系人与本人亲属关系，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- object_api_name：emergency_contact</para>
            /// <para>- custom_api_name：relationship</para>
            /// <para>必填：否</para>
            /// <para>示例值：parent</para>
            /// </summary>
            [JsonPropertyName("relationship")]
            public string? Relationship { get; set; }

            /// <summary>
            /// <para>电话</para>
            /// <para>必填：否</para>
            /// <para>最大长度：1000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("phones")]
            public PhoneForUpdate[]? Phones { get; set; }

            /// <summary>
            /// <para>电话</para>
            /// </summary>
            public record PhoneForUpdate
            {
                /// <summary>
                /// <para>国际电话区号，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
                /// <para>- object_api_name：phone</para>
                /// <para>- custom_api_name：international_area_code</para>
                /// <para>必填：是</para>
                /// <para>示例值：86_china</para>
                /// </summary>
                [JsonPropertyName("international_area_code")]
                public string InternationalAreaCode { get; set; } = string.Empty;

                /// <summary>
                /// <para>电话号码</para>
                /// <para>必填：是</para>
                /// <para>示例值：010-12345678</para>
                /// </summary>
                [JsonPropertyName("phone_number")]
                public string PhoneNumber { get; set; } = string.Empty;

                /// <summary>
                /// <para>设备类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
                /// <para>- object_api_name：phone</para>
                /// <para>- custom_api_name：device_type</para>
                /// <para>必填：是</para>
                /// <para>示例值：mobile_phone</para>
                /// </summary>
                [JsonPropertyName("device_type")]
                public string DeviceType { get; set; } = string.Empty;

                /// <summary>
                /// <para>电话用途，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
                /// <para>- object_api_name：phone</para>
                /// <para>- custom_api_name：phone_usage</para>
                /// <para>必填：是</para>
                /// <para>示例值：home</para>
                /// </summary>
                [JsonPropertyName("phone_usage")]
                public string PhoneUsage { get; set; } = string.Empty;

                /// <summary>
                /// <para>主要电话，若有多个电话，只能有一个电话的「is_primary」为true</para>
                /// <para>必填：是</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_primary")]
                public bool IsPrimary { get; set; }

                /// <summary>
                /// <para>公开电话</para>
                /// <para>必填：是</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_public")]
                public bool IsPublic { get; set; }
            }

            /// <summary>
            /// <para>地址</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("address")]
            public AddressForUpdate? Address { get; set; }

            /// <summary>
            /// <para>地址</para>
            /// </summary>
            public record AddressForUpdate
            {
                /// <summary>
                /// <para>国家 / 地区，可以通过[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口获取</para>
                /// <para>必填：是</para>
                /// <para>示例值：6862995757234914824</para>
                /// </summary>
                [JsonPropertyName("country_region_id")]
                public string CountryRegionId { get; set; } = string.Empty;

                /// <summary>
                /// <para>主要行政区，可以通过[查询省份/行政区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)接口获取</para>
                /// <para>必填：否</para>
                /// <para>示例值：6863326815667095047</para>
                /// </summary>
                [JsonPropertyName("region_id")]
                public string? RegionId { get; set; }

                /// <summary>
                /// <para>地址行 1（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：北京市海淀区</para>
                /// </summary>
                [JsonPropertyName("local_address_line1")]
                public string? LocalAddressLine1 { get; set; }

                /// <summary>
                /// <para>地址行 2（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：上海市杨浦区</para>
                /// </summary>
                [JsonPropertyName("local_address_line2")]
                public string? LocalAddressLine2 { get; set; }

                /// <summary>
                /// <para>地址行 3（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：北京市房山区</para>
                /// </summary>
                [JsonPropertyName("local_address_line3")]
                public string? LocalAddressLine3 { get; set; }

                /// <summary>
                /// <para>地址行 4（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：天津滨海高新区</para>
                /// </summary>
                [JsonPropertyName("local_address_line4")]
                public string? LocalAddressLine4 { get; set; }

                /// <summary>
                /// <para>地址行 5（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：成都市成华区</para>
                /// </summary>
                [JsonPropertyName("local_address_line5")]
                public string? LocalAddressLine5 { get; set; }

                /// <summary>
                /// <para>地址行 6（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：深圳市南山区</para>
                /// </summary>
                [JsonPropertyName("local_address_line6")]
                public string? LocalAddressLine6 { get; set; }

                /// <summary>
                /// <para>地址行 7（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：南京市鼓楼区</para>
                /// </summary>
                [JsonPropertyName("local_address_line7")]
                public string? LocalAddressLine7 { get; set; }

                /// <summary>
                /// <para>地址行 8（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：杭州市滨江区</para>
                /// </summary>
                [JsonPropertyName("local_address_line8")]
                public string? LocalAddressLine8 { get; set; }

                /// <summary>
                /// <para>地址行 9（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：郑州市中原区</para>
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
                /// <para>地址类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
                /// <para>- object_api_name：address</para>
                /// <para>- custom_api_name：address_type</para>
                /// <para>必填：是</para>
                /// <para>最大长度：1000</para>
                /// <para>最小长度：1</para>
                /// </summary>
                [JsonPropertyName("address_types")]
                public string[] AddressTypes { get; set; } = Array.Empty<string>();

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
            }

            /// <summary>
            /// <para>邮箱</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("email")]
            public EmailForUpdate? Email { get; set; }

            /// <summary>
            /// <para>邮箱</para>
            /// </summary>
            public record EmailForUpdate
            {
                /// <summary>
                /// <para>邮箱地址</para>
                /// <para>必填：是</para>
                /// <para>示例值：1234567@bytedance.com</para>
                /// </summary>
                [JsonPropertyName("email")]
                public string Email { get; set; } = string.Empty;

                /// <summary>
                /// <para>是否为主要邮箱，若有多个邮箱，只能有一个邮箱的「is_primary」为true</para>
                /// <para>必填：是</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_primary")]
                public bool IsPrimary { get; set; }

                /// <summary>
                /// <para>是否为公开邮箱</para>
                /// <para>必填：是</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_public")]
                public bool IsPublic { get; set; }

                /// <summary>
                /// <para>邮箱用途，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
                /// <para>- object_api_name：email</para>
                /// <para>- custom_api_name：email_usage</para>
                /// <para>必填：是</para>
                /// <para>示例值：work</para>
                /// </summary>
                [JsonPropertyName("email_usage")]
                public string EmailUsage { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>联系地址</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("address_list")]
        public AddressForUpdate[]? AddressLists { get; set; }

        /// <summary>
        /// <para>联系地址</para>
        /// </summary>
        public record AddressForUpdate
        {
            /// <summary>
            /// <para>国家 / 地区，可以通过[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口获取</para>
            /// <para>必填：是</para>
            /// <para>示例值：6862995757234914824</para>
            /// </summary>
            [JsonPropertyName("country_region_id")]
            public string CountryRegionId { get; set; } = string.Empty;

            /// <summary>
            /// <para>主要行政区，可以通过[查询省份/行政区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863326815667095047</para>
            /// </summary>
            [JsonPropertyName("region_id")]
            public string? RegionId { get; set; }

            /// <summary>
            /// <para>地址行 1（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：北京市海淀区</para>
            /// </summary>
            [JsonPropertyName("local_address_line1")]
            public string? LocalAddressLine1 { get; set; }

            /// <summary>
            /// <para>地址行 2（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：上海市杨浦区</para>
            /// </summary>
            [JsonPropertyName("local_address_line2")]
            public string? LocalAddressLine2 { get; set; }

            /// <summary>
            /// <para>地址行 3（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：北京市房山区</para>
            /// </summary>
            [JsonPropertyName("local_address_line3")]
            public string? LocalAddressLine3 { get; set; }

            /// <summary>
            /// <para>地址行 4（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：天津滨海高新区</para>
            /// </summary>
            [JsonPropertyName("local_address_line4")]
            public string? LocalAddressLine4 { get; set; }

            /// <summary>
            /// <para>地址行 5（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：成都市成华区</para>
            /// </summary>
            [JsonPropertyName("local_address_line5")]
            public string? LocalAddressLine5 { get; set; }

            /// <summary>
            /// <para>地址行 6（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：深圳市南山区</para>
            /// </summary>
            [JsonPropertyName("local_address_line6")]
            public string? LocalAddressLine6 { get; set; }

            /// <summary>
            /// <para>地址行 7（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：南京市鼓楼区</para>
            /// </summary>
            [JsonPropertyName("local_address_line7")]
            public string? LocalAddressLine7 { get; set; }

            /// <summary>
            /// <para>地址行 8（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：杭州市滨江区</para>
            /// </summary>
            [JsonPropertyName("local_address_line8")]
            public string? LocalAddressLine8 { get; set; }

            /// <summary>
            /// <para>地址行 9（非拉丁语系的本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：郑州市中原区</para>
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
            /// <para>地址类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
            /// <para>- object_api_name：address</para>
            /// <para>- custom_api_name：address_type</para>
            /// <para>必填：是</para>
            /// <para>最大长度：1000</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("address_types")]
            public string[] AddressTypes { get; set; } = Array.Empty<string>();

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
        }

        /// <summary>
        /// <para>婚姻状况，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
        /// <para>- object_api_name：person</para>
        /// <para>- custom_api_name：marital_status</para>
        /// <para>必填：否</para>
        /// <para>示例值：single</para>
        /// </summary>
        [JsonPropertyName("marital_status")]
        public string? MaritalStatus { get; set; }

        /// <summary>
        /// <para>民族 / 种族，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
        /// <para>- object_api_name：person</para>
        /// <para>- custom_api_name：ethnicity_race</para>
        /// <para>必填：否</para>
        /// <para>示例值：han</para>
        /// </summary>
        [JsonPropertyName("ethnicity_race")]
        public string? EthnicityRace { get; set; }

        /// <summary>
        /// <para>籍贯，可以通过[查询省份/行政区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6822114062122064111</para>
        /// </summary>
        [JsonPropertyName("native_region")]
        public string? NativeRegion { get; set; }

        /// <summary>
        /// <para>户口类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
        /// <para>- object_api_name：person_info_chn</para>
        /// <para>- custom_api_name：hukou_type</para>
        /// <para>必填：否</para>
        /// <para>示例值：local_urban_residence</para>
        /// </summary>
        [JsonPropertyName("hukou_type")]
        public string? HukouType { get; set; }

        /// <summary>
        /// <para>户口所在地</para>
        /// <para>必填：否</para>
        /// <para>示例值：北京市海淀区北三环西路</para>
        /// </summary>
        [JsonPropertyName("hukou_location")]
        public string? HukouLocation { get; set; }

        /// <summary>
        /// <para>person对象上的自定义字段，可以通过[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)接口获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public ObjectFieldData[]? CustomFields { get; set; }

        /// <summary>
        /// <para>person对象上的自定义字段，可以通过[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)接口获得</para>
        /// </summary>
        public record ObjectFieldData
        {
            /// <summary>
            /// <para>字段名</para>
            /// <para>必填：是</para>
            /// <para>示例值：custom_field_1__c</para>
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
    /// <para>职位信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("offer_info")]
    public PostCorehrV2PreHiresBodyDtoOfferInfo OfferInfo { get; set; } = new();

    /// <summary>
    /// <para>职位信息</para>
    /// </summary>
    public record PostCorehrV2PreHiresBodyDtoOfferInfo
    {
        /// <summary>
        /// <para>Offer ID，仅支持飞书招聘 ID，可以通过飞书招聘[获取Offer列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/offer/list)接口获取，如果未使用飞书招聘请置空</para>
        /// <para>必填：否</para>
        /// <para>示例值：7032210902531327521</para>
        /// </summary>
        [JsonPropertyName("offer_id")]
        public string? OfferId { get; set; }

        /// <summary>
        /// <para>Offer HR 雇佣 ID，可以通过[批量查询员工信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：7032210902531327521</para>
        /// </summary>
        [JsonPropertyName("offer_hr_id")]
        public string? OfferHrId { get; set; }

        /// <summary>
        /// <para>部门 ID，可以通过[批量查询部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：7147562782945478177</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>直属领导的雇佣 ID，可以通过[批量查询员工信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：7032210902531327521</para>
        /// </summary>
        [JsonPropertyName("direct_leader_id")]
        public string? DirectLeaderId { get; set; }

        /// <summary>
        /// <para>职务 ID，可以通过[批量查询职务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/list)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977976735715378724</para>
        /// </summary>
        [JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// <para>序列 ID，可以通过[批量查询序列](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/list)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977972856625939999</para>
        /// </summary>
        [JsonPropertyName("job_family_id")]
        public string? JobFamilyId { get; set; }

        /// <summary>
        /// <para>职级 ID，可以通过[批量查询职级](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/list)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977971894960145950</para>
        /// </summary>
        [JsonPropertyName("job_level_id")]
        public string? JobLevelId { get; set; }

        /// <summary>
        /// <para>职务头衔（待废弃）</para>
        /// <para>必填：否</para>
        /// <para>示例值：java</para>
        /// </summary>
        [JsonPropertyName("job_title")]
        public string? JobTitle { get; set; }

        /// <summary>
        /// <para>试用期开始日期，格式："YYYY-MM-DD"</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-07-29</para>
        /// </summary>
        [JsonPropertyName("probation_start_date")]
        public string? ProbationStartDate { get; set; }

        /// <summary>
        /// <para>试用期结束日期，格式："YYYY-MM-DD"</para>
        /// <para>必填：否</para>
        /// <para>示例值：2023-04-07</para>
        /// </summary>
        [JsonPropertyName("probation_end_date")]
        public string? ProbationEndDate { get; set; }

        /// <summary>
        /// <para>合同开始日期，格式："YYYY-MM-DD"</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-10-08</para>
        /// </summary>
        [JsonPropertyName("contract_start_date")]
        public string? ContractStartDate { get; set; }

        /// <summary>
        /// <para>合同结束日期，格式："YYYY-MM-DD"</para>
        /// <para>必填：否</para>
        /// <para>示例值：2025-10-07</para>
        /// </summary>
        [JsonPropertyName("contract_end_date")]
        public string? ContractEndDate { get; set; }

        /// <summary>
        /// <para>合同期限时长</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonPropertyName("duration_period")]
        public float? DurationPeriod { get; set; }

        /// <summary>
        /// <para>合同期限单位，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
        /// <para>- object_api_name = pre_hire</para>
        /// <para>- custom_api_name = duration_unit</para>
        /// <para>必填：否</para>
        /// <para>示例值：year</para>
        /// </summary>
        [JsonPropertyName("duration_unit")]
        public string? DurationUnit { get; set; }

        /// <summary>
        /// <para>入职日期，格式："YYYY-MM-DD"</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-10-08</para>
        /// </summary>
        [JsonPropertyName("onboarding_date")]
        public string? OnboardingDate { get; set; }

        /// <summary>
        /// <para>入职地点 ID，可以通过[批量查询地点](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977976687350924832</para>
        /// </summary>
        [JsonPropertyName("onboarding_location_id")]
        public string? OnboardingLocationId { get; set; }

        /// <summary>
        /// <para>办公地点 ID，可以通过[批量查询地点](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977976687350924832</para>
        /// </summary>
        [JsonPropertyName("office_location_id")]
        public string? OfficeLocationId { get; set; }

        /// <summary>
        /// <para>招聘来源，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
        /// <para>- object_api_name：pre_hire</para>
        /// <para>- custom_api_name：recruitment_type</para>
        /// <para>必填：否</para>
        /// <para>示例值：experienced_professionals</para>
        /// </summary>
        [JsonPropertyName("recruitment_type_id")]
        public string? RecruitmentTypeId { get; set; }

        /// <summary>
        /// <para>试用期时长</para>
        /// <para>必填：否</para>
        /// <para>示例值：6</para>
        /// </summary>
        [JsonPropertyName("probation_period")]
        public string? ProbationPeriod { get; set; }

        /// <summary>
        /// <para>人员类型 ID，可以通过接口[批量查询人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/list)获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977973225846343171</para>
        /// </summary>
        [JsonPropertyName("employee_type_id")]
        public string? EmployeeTypeId { get; set; }

        /// <summary>
        /// <para>雇佣类型， 枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
        /// <para>- object_api_name：pre_hire</para>
        /// <para>- custom_api_name：employment_type</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977973225846343171</para>
        /// </summary>
        [JsonPropertyName("employment_type_id")]
        public string? EmploymentTypeId { get; set; }

        /// <summary>
        /// <para>工作邮箱</para>
        /// <para>必填：否</para>
        /// <para>示例值：joshua@bytedance.com</para>
        /// </summary>
        [JsonPropertyName("work_email")]
        public string? WorkEmail { get; set; }

        /// <summary>
        /// <para>期限类型， 枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
        /// <para>- object_api_name：pre_hire</para>
        /// <para>- custom_api_name：duration_type</para>
        /// <para>必填：否</para>
        /// <para>示例值：fixed_term</para>
        /// </summary>
        [JsonPropertyName("duration_type_id")]
        public string? DurationTypeId { get; set; }

        /// <summary>
        /// <para>签订类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
        /// <para>- object_api_name：pre_hire</para>
        /// <para>- custom_api_name：signing_type</para>
        /// <para>必填：否</para>
        /// <para>示例值：new</para>
        /// </summary>
        [JsonPropertyName("signing_type_id")]
        public string? SigningTypeId { get; set; }

        /// <summary>
        /// <para>入职方式，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
        /// <para>- object_api_name：pre_hire</para>
        /// <para>- custom_api_name：onboarding_method</para>
        /// <para>必填：否</para>
        /// <para>示例值：onsite</para>
        /// </summary>
        [JsonPropertyName("entry_mode")]
        public string? EntryMode { get; set; }

        /// <summary>
        /// <para>社保城市 ID，可以通过[批量查询地点](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977976687350924833</para>
        /// </summary>
        [JsonPropertyName("social_security_city_id")]
        public string? SocialSecurityCityId { get; set; }

        /// <summary>
        /// <para>合同类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
        /// <para>- object_api_name：pre_hire</para>
        /// <para>- custom_api_name：contract_type</para>
        /// <para>必填：否</para>
        /// <para>示例值：internship_agreement</para>
        /// </summary>
        [JsonPropertyName("contract_type")]
        public string? ContractType { get; set; }

        /// <summary>
        /// <para>公司 ID，可以通过[批量查询公司](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/list)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6738317738688661772</para>
        /// </summary>
        [JsonPropertyName("company")]
        public string? Company { get; set; }

        /// <summary>
        /// <para>成本中心分摊信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("cost_center_rate")]
        public JobDataCostCenter[]? CostCenterRates { get; set; }

        /// <summary>
        /// <para>成本中心分摊信息</para>
        /// </summary>
        public record JobDataCostCenter
        {
            /// <summary>
            /// <para>成本中心 ID，可以通过[搜索成本中心信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6950635856373745165</para>
            /// </summary>
            [JsonPropertyName("cost_center_id")]
            public string? CostCenterId { get; set; }

            /// <summary>
            /// <para>分摊比例，大于0小于等于100的正整数</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("rate")]
            public int? Rate { get; set; }
        }

        /// <summary>
        /// <para>职等ID，可以通过[查询职等](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_grade/query)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6738317738688661772</para>
        /// </summary>
        [JsonPropertyName("job_grade_id")]
        public string? JobGradeId { get; set; }

        /// <summary>
        /// <para>pre_hire对象上的自定义字段，可以通过[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)接口获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public ObjectFieldData[]? CustomFields { get; set; }

        /// <summary>
        /// <para>pre_hire对象上的自定义字段，可以通过[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)接口获得</para>
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
            /// <para>字段值，请转换为字符串数组的方式写入</para>
            /// <para>必填：是</para>
            /// <para>示例值：[\"Sandy\"]</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>任职公司</para>
        /// <para>必填：否</para>
        /// <para>示例值：6738317738688661772</para>
        /// </summary>
        [JsonPropertyName("service_company")]
        public string? ServiceCompany { get; set; }

        /// <summary>
        /// <para>排班，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
        /// <para>- object_api_name：pre_hire</para>
        /// <para>- custom_api_name：work_shift</para>
        /// <para>必填：否</para>
        /// <para>示例值：work_shift</para>
        /// </summary>
        [JsonPropertyName("work_shift")]
        public string? WorkShift { get; set; }

        /// <summary>
        /// <para>薪资类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
        /// <para>- object_api_name：pre_hire</para>
        /// <para>- custom_api_name：compensation_type</para>
        /// <para>必填：否</para>
        /// <para>示例值：hourly</para>
        /// </summary>
        [JsonPropertyName("compensation_type")]
        public string? CompensationType { get; set; }

        /// <summary>
        /// <para>工作地点ID，可以通过[批量查询地点](https://open.larkoffice.com/document/server-docs/corehr-v1/organization-management/location/list)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977976687350924833</para>
        /// </summary>
        [JsonPropertyName("work_location_id")]
        public string? WorkLocationId { get; set; }

        /// <summary>
        /// <para>入职地址ID，可以通过[批量查询地点](https://open.larkoffice.com/document/server-docs/corehr-v1/organization-management/location/list)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977976687350924833</para>
        /// </summary>
        [JsonPropertyName("onboarding_address_id")]
        public string? OnboardingAddressId { get; set; }

        /// <summary>
        /// <para>办公地址ID，，可以通过[批量查询地点](https://open.larkoffice.com/document/server-docs/corehr-v1/organization-management/location/list)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977976687350924833</para>
        /// </summary>
        [JsonPropertyName("office_address_id")]
        public string? OfficeAddressId { get; set; }

        /// <summary>
        /// <para>岗位ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977976687350924833</para>
        /// </summary>
        [JsonPropertyName("position_id")]
        public string? PositionId { get; set; }

        /// <summary>
        /// <para>工作日历ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977976687350924833</para>
        /// </summary>
        [JsonPropertyName("working_calendar_id")]
        public string? WorkingCalendarId { get; set; }

        /// <summary>
        /// <para>工时制度，可以通过[批量查询工时制度](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/list)接口获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6890452208593372679</para>
        /// </summary>
        [JsonPropertyName("working_hours_type")]
        public string? WorkingHoursType { get; set; }

        /// <summary>
        /// <para>薪资组</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977976687350924833</para>
        /// </summary>
        [JsonPropertyName("pay_group_id")]
        public string? PayGroupId { get; set; }

        /// <summary>
        /// <para>入职流程ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：64377642c0ec3f23c79c6916</para>
        /// </summary>
        [JsonPropertyName("flow_id")]
        public string? FlowId { get; set; }

        /// <summary>
        /// <para>签到日期，格式："YYYY-MM-DD"</para>
        /// <para>必填：否</para>
        /// <para>示例值：2024-12-31</para>
        /// </summary>
        [JsonPropertyName("check_in_time")]
        public string? CheckInTime { get; set; }

        /// <summary>
        /// <para>签到方式，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
        /// <para>- object_api_name：pre_hire</para>
        /// <para>- custom_api_name：onboarding_method</para>
        /// <para>必填：否</para>
        /// <para>示例值：onsite</para>
        /// </summary>
        [JsonPropertyName("check_in_method")]
        public string? CheckInMethod { get; set; }
    }

    /// <summary>
    /// <para>教育经历</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("education_info")]
    public EducationInfo[]? EducationInfos { get; set; }

    /// <summary>
    /// <para>教育经历</para>
    /// </summary>
    public record EducationInfo
    {
        /// <summary>
        /// <para>学校名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：长安大学</para>
        /// </summary>
        [JsonPropertyName("school_name")]
        public string? SchoolName { get; set; }

        /// <summary>
        /// <para>学历，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
        /// <para>- object_api_name：education</para>
        /// <para>- custom_api_name：level_of_education</para>
        /// <para>必填：否</para>
        /// <para>示例值：phd</para>
        /// </summary>
        [JsonPropertyName("education")]
        public string? Education { get; set; }

        /// <summary>
        /// <para>开始时间，格式："YYYY-MM-DD"</para>
        /// <para>必填：否</para>
        /// <para>示例值：2017-04-01</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>结束时间，格式："YYYY-MM-DD"</para>
        /// <para>必填：否</para>
        /// <para>示例值：2018-04-01</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>专业</para>
        /// <para>必填：否</para>
        /// <para>示例值：医学影像技术</para>
        /// </summary>
        [JsonPropertyName("field_of_study")]
        public string? FieldOfStudy { get; set; }
    }

    /// <summary>
    /// <para>工作经历</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("work_experience")]
    public WorkExperience[]? WorkExperiences { get; set; }

    /// <summary>
    /// <para>工作经历</para>
    /// </summary>
    public record WorkExperience
    {
        /// <summary>
        /// <para>公司名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：猎豹</para>
        /// </summary>
        [JsonPropertyName("company_name")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// <para>开始时间，格式："YYYY-MM-DD"</para>
        /// <para>必填：否</para>
        /// <para>示例值：2015-02-01</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>结束时间，格式："YYYY-MM-DD"</para>
        /// <para>必填：否</para>
        /// <para>示例值：2017-02-01</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>岗位</para>
        /// <para>必填：否</para>
        /// <para>示例值：产品经理</para>
        /// </summary>
        [JsonPropertyName("job_title")]
        public string? JobTitle { get; set; }

        /// <summary>
        /// <para>工作描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：app</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>部门</para>
        /// <para>必填：否</para>
        /// <para>示例值：部门名称</para>
        /// </summary>
        [JsonPropertyName("department")]
        public string? Department { get; set; }
    }

    /// <summary>
    /// <para>招聘应用 ID，仅支持飞书招聘 ID，可以通过[获取投递列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/list)接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：7140946969586010376</para>
    /// </summary>
    [JsonPropertyName("ats_application_id")]
    public string? AtsApplicationId { get; set; }

    /// <summary>
    /// <para>外部业务唯一编码，用于支持幂等创建</para>
    /// <para>必填：否</para>
    /// <para>示例值：7140946969586010376</para>
    /// </summary>
    [JsonPropertyName("out_biz_id")]
    public string? OutBizId { get; set; }
}
