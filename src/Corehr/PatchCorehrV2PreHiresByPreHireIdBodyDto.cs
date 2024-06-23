// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchCorehrV2PreHiresByPreHireIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新待入职信息（推荐） 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 更新待入职信息（推荐） 请求体
/// <para>更新待入职对象指定字段的值</para>
/// <para>接口ID：7357756972752715778</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fpatch</para>
/// </summary>
public record PatchCorehrV2PreHiresByPreHireIdBodyDto
{
    /// <summary>
    /// <para>更新个人（person）信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("basic_info_update")]
    public PatchCorehrV2PreHiresByPreHireIdBodyDtoBasicInfoUpdate? BasicInfoUpdate { get; set; }

    /// <summary>
    /// <para>更新个人（person）信息</para>
    /// </summary>
    public record PatchCorehrV2PreHiresByPreHireIdBodyDtoBasicInfoUpdate
    {
        /// <summary>
        /// <para>姓名,该值是一个list，会全量更新。即使只更新 list 中的某一个元素，也需要把其它元素都完整传值，否则将丢失数据。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("names")]
        public NameForUpdate[]? Names { get; set; }

        /// <summary>
        /// <para>姓名,该值是一个list，会全量更新。即使只更新 list 中的某一个元素，也需要把其它元素都完整传值，否则将丢失数据。</para>
        /// </summary>
        public record NameForUpdate
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
            /// <para>自定义姓名（本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：李一一</para>
            /// </summary>
            [JsonPropertyName("custom_local_name")]
            public string? CustomLocalName { get; set; }

            /// <summary>
            /// <para>自定义姓名（西方文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：YiyiLi</para>
            /// </summary>
            [JsonPropertyName("custom_western_name")]
            public string? CustomWesternName { get; set; }

            /// <summary>
            /// <para>国家/地区</para>
            /// <para>必填：是</para>
            /// <para>示例值：6862995757234914824</para>
            /// </summary>
            [JsonPropertyName("country_region")]
            public string CountryRegion { get; set; } = string.Empty;

            /// <summary>
            /// <para>姓名类型，枚举值如下：</para>
            /// <para>- legal_name：法定姓名</para>
            /// <para>- preferred_name：常用名</para>
            /// <para>- former_name：曾用名</para>
            /// <para>- additional_name：别名</para>
            /// <para>必填：是</para>
            /// <para>示例值：legal_name</para>
            /// </summary>
            [JsonPropertyName("name_type")]
            public string NameType { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>电话,该值是一个list，会全量更新。即使只更新 list 中的某一个元素，也需要把其它元素都完整传值，否则将丢失数据。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("phones")]
        public PhoneForUpdate[]? Phones { get; set; }

        /// <summary>
        /// <para>电话,该值是一个list，会全量更新。即使只更新 list 中的某一个元素，也需要把其它元素都完整传值，否则将丢失数据。</para>
        /// </summary>
        public record PhoneForUpdate
        {
            /// <summary>
            /// <para>国家区号,枚举值</para>
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
            /// <para>设备类型，枚举值</para>
            /// <para>- mobile_phone：手机</para>
            /// <para>- landline：座机</para>
            /// <para>- fax：传真</para>
            /// <para>必填：是</para>
            /// <para>示例值：mobile_phone</para>
            /// </summary>
            [JsonPropertyName("device_type")]
            public string DeviceType { get; set; } = string.Empty;

            /// <summary>
            /// <para>电话用途,枚举值</para>
            /// <para>- work：工作</para>
            /// <para>- home：家庭</para>
            /// <para>- emergency_contact：紧急联系人</para>
            /// <para>- company：公司</para>
            /// <para>必填：是</para>
            /// <para>示例值：work</para>
            /// </summary>
            [JsonPropertyName("phone_usage")]
            public string PhoneUsage { get; set; } = string.Empty;

            /// <summary>
            /// <para>主要电话,若有多个电话，只能有一个电话的「is_primary」为true</para>
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
        /// <para>邮箱,该值是一个list，会全量更新。即使只更新 list 中的某一个元素，也需要把其它元素都完整传值，否则将丢失数据。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("emails")]
        public EmailForUpdate[]? Emails { get; set; }

        /// <summary>
        /// <para>邮箱,该值是一个list，会全量更新。即使只更新 list 中的某一个元素，也需要把其它元素都完整传值，否则将丢失数据。</para>
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
            /// <para>是否为主要邮箱,若有多个邮箱，只能有一个邮箱的「is_primary」为true</para>
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
            /// <para>邮箱用途，枚举值可通过文档[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)获得</para>
            /// <para>必填：是</para>
            /// <para>示例值：work</para>
            /// </summary>
            [JsonPropertyName("email_usage")]
            public string EmailUsage { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>更新待入职（prehire）信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("offer_info_update")]
    public PatchCorehrV2PreHiresByPreHireIdBodyDtoOfferInfoUpdate? OfferInfoUpdate { get; set; }

    /// <summary>
    /// <para>更新待入职（prehire）信息</para>
    /// </summary>
    public record PatchCorehrV2PreHiresByPreHireIdBodyDtoOfferInfoUpdate
    {
        /// <summary>
        /// <para>入职日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-10-08</para>
        /// </summary>
        [JsonPropertyName("onboarding_date")]
        public string? OnboardingDate { get; set; }

        /// <summary>
        /// <para>招聘应用ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7140946969586010375</para>
        /// </summary>
        [JsonPropertyName("ats_application_id")]
        public string? AtsApplicationId { get; set; }

        /// <summary>
        /// <para>入职地点ID，详细信息可通过[批量查询地点](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977976687350924832</para>
        /// </summary>
        [JsonPropertyName("onboarding_location_id")]
        public string? OnboardingLocationId { get; set; }

        /// <summary>
        /// <para>入职地址ID，详细信息可通过【批量查询地址】接口获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977976687350924832</para>
        /// </summary>
        [JsonPropertyName("onboarding_address_id")]
        public string? OnboardingAddressId { get; set; }

        /// <summary>
        /// <para>办公地点ID，详细信息可通过[批量查询地点](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977976687350924833</para>
        /// </summary>
        [JsonPropertyName("office_location_id")]
        public string? OfficeLocationId { get; set; }

        /// <summary>
        /// <para>办公地址ID，详细信息可通过【批量查询地址】接口获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977976687350924832</para>
        /// </summary>
        [JsonPropertyName("office_address_id")]
        public string? OfficeAddressId { get; set; }

        /// <summary>
        /// <para>雇佣类型，[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)获得</para>
        /// <para>- employee(员工)</para>
        /// <para>- contingent_worker(临时工)</para>
        /// <para>必填：否</para>
        /// <para>示例值：employee</para>
        /// </summary>
        [JsonPropertyName("employment_type")]
        public string? EmploymentType { get; set; }

        /// <summary>
        /// <para>入职方式，通过[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)获得</para>
        /// <para>- onsite(现场入职)</para>
        /// <para>- remote(远程入职)</para>
        /// <para>必填：否</para>
        /// <para>示例值：onsite</para>
        /// </summary>
        [JsonPropertyName("onboarding_method")]
        public string? OnboardingMethod { get; set; }

        /// <summary>
        /// <para>工作邮箱，该值是一个list，会全量更新。即使只更新 list 中的某一个元素，也需要把其它元素都完整传值，否则将丢失数据。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("work_emails")]
        public EmailForUpdate[]? WorkEmails { get; set; }

        /// <summary>
        /// <para>工作邮箱，该值是一个list，会全量更新。即使只更新 list 中的某一个元素，也需要把其它元素都完整传值，否则将丢失数据。</para>
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
            /// <para>是否为主要邮箱,若有多个邮箱，只能有一个邮箱的「is_primary」为true</para>
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
            /// <para>邮箱用途，枚举值可通过[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)获得</para>
            /// <para>必填：是</para>
            /// <para>示例值：work</para>
            /// </summary>
            [JsonPropertyName("email_usage")]
            public string EmailUsage { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>成本中心分摊信息,只支持商业化租户</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("cost_center_rates")]
        public JobDataCostCenter[]? CostCenterRates { get; set; }

        /// <summary>
        /// <para>成本中心分摊信息,只支持商业化租户</para>
        /// </summary>
        public record JobDataCostCenter
        {
            /// <summary>
            /// <para>成本中心 ID，可以通过【查询单个成本中心信息】获取对应的成本中心信息</para>
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
            /// <para>字段值，该值是一个 string list 经转义后的字符串，具体参考请求体示例</para>
            /// <para>必填：是</para>
            /// <para>示例值：[\"Sandy\"]</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>指定需要更新的系统字段，只支持最多下钻一层，格式如下：</para>
    /// <para>- basic_info_update字段：basic_info_update.names（对name整体进行覆盖更新）；basic_info_update.emails（对邮箱整体进行更新）</para>
    /// <para>- offer_info_update字段：offer_info_update.onboarding_method</para>
    /// <para>注意，如果指定了要更新的系统字段但是没有在结构体中传对应的值，那么就会清空该字段的值</para>
    /// <para>必填：否</para>
    /// <para>示例值：\["basic_info_update.names","offer_info_update.onboarding_method"\]</para>
    /// </summary>
    [JsonPropertyName("standard_update_fields")]
    public string[]? StandardUpdateFields { get; set; }

    /// <summary>
    /// <para>指定需要更新的PreHire对象上的自定义字段，格式如下：</para>
    /// <para>- custom_field1__c</para>
    /// <para>注意，如果指定了要更新的自定义字段但是没有在结构体中传对应的值，那么就会清空该字段的值</para>
    /// <para>必填：否</para>
    /// <para>示例值：\["custom_field1__c","custom_field2__c"\]</para>
    /// </summary>
    [JsonPropertyName("custom_update_fields")]
    public string[]? CustomUpdateFields { get; set; }
}
