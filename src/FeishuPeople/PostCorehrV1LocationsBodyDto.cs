// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-10-08
// ************************************************************************
// <copyright file="PostCorehrV1LocationsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建地点 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 创建地点 请求体
/// <para>在系统中第一次创建地点数据</para>
/// <para>接口ID：7072646479949316098</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/location/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2flocation%2fcreate</para>
/// </summary>
public record PostCorehrV1LocationsBodyDto
{
    /// <summary>
    /// <para>地点基本信息，该结构维护了地点的名称、编码、启用状态、上级地点等基础信息。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("hiberarchy_common")]
    public PostCorehrV1LocationsBodyDtoHiberarchyCommon HiberarchyCommon { get; set; } = new();

    /// <summary>
    /// <para>地点基本信息，该结构维护了地点的名称、编码、启用状态、上级地点等基础信息。</para>
    /// </summary>
    public record PostCorehrV1LocationsBodyDtoHiberarchyCommon
    {
        /// <summary>
        /// <para>上级地点ID。ID获取方式：</para>
        /// <para>- 调用[【创建地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/create)[【批量分页查询地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)等接口可以返回地点ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719168654814483759</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// <para>地点名称</para>
        /// <para>- 名称不能包含「/」「；」「;」字符。</para>
        /// <para>- 地点中英文名称会有全局唯一校验</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n[] Names { get; set; } = Array.Empty<I18n>();

        /// <summary>
        /// <para>地点名称</para>
        /// <para>- 名称不能包含「/」「；」「;」字符。</para>
        /// <para>- 地点中英文名称会有全局唯一校验</para>
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
        /// <para>启用状态，true为启用，false为停用</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// <para>编码</para>
        /// <para>- 编码 (不能与其他记录的编码重复)，当开启自动编码时，该字段会失效</para>
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
        /// <para>示例值：work_space</para>
        /// </summary>
        [JsonPropertyName("enum_name")]
        public string EnumName { get; set; } = string.Empty;
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
        /// <para>城市ID。ID获取</para>
        /// <para>调用[【查询城市信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-city/search)等接口可以返回城市ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6863333254578046471</para>
        /// </summary>
        [JsonPropertyName("city_id")]
        public string? CityId { get; set; }

        /// <summary>
        /// <para>区县ID。ID获取</para>
        /// <para>调用[【查询区县信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-district/search)等接口可以返回区县ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6863333516579440141</para>
        /// </summary>
        [JsonPropertyName("distinct_id")]
        public string? DistinctId { get; set; }

        /// <summary>
        /// <para>地址行 1</para>
        /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
        /// <para>必填：否</para>
        /// <para>示例值：丹佛测试地址-纽埃时区</para>
        /// </summary>
        [JsonPropertyName("address_line1")]
        public string? AddressLine1 { get; set; }

        /// <summary>
        /// <para>地址行 2</para>
        /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
        /// <para>必填：否</para>
        /// <para>示例值：PoewH</para>
        /// </summary>
        [JsonPropertyName("address_line2")]
        public string? AddressLine2 { get; set; }

        /// <summary>
        /// <para>地址行 3</para>
        /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
        /// <para>必填：否</para>
        /// <para>示例值：PoewH</para>
        /// </summary>
        [JsonPropertyName("address_line3")]
        public string? AddressLine3 { get; set; }

        /// <summary>
        /// <para>地址行 4</para>
        /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
        /// <para>必填：否</para>
        /// <para>示例值：jmwJc</para>
        /// </summary>
        [JsonPropertyName("address_line4")]
        public string? AddressLine4 { get; set; }

        /// <summary>
        /// <para>地址行 5</para>
        /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
        /// <para>必填：否</para>
        /// <para>示例值：jmwJc</para>
        /// </summary>
        [JsonPropertyName("address_line5")]
        public string? AddressLine5 { get; set; }

        /// <summary>
        /// <para>地址行 6</para>
        /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
        /// <para>必填：否</para>
        /// <para>示例值：jmwJc</para>
        /// </summary>
        [JsonPropertyName("address_line6")]
        public string? AddressLine6 { get; set; }

        /// <summary>
        /// <para>地址行 7</para>
        /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
        /// <para>必填：否</para>
        /// <para>示例值：jmwJc</para>
        /// </summary>
        [JsonPropertyName("address_line7")]
        public string? AddressLine7 { get; set; }

        /// <summary>
        /// <para>地址行 8</para>
        /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
        /// <para>必填：否</para>
        /// <para>示例值：rafSu</para>
        /// </summary>
        [JsonPropertyName("address_line8")]
        public string? AddressLine8 { get; set; }

        /// <summary>
        /// <para>地址行 9</para>
        /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
        /// <para>必填：否</para>
        /// <para>示例值：McPRG</para>
        /// </summary>
        [JsonPropertyName("address_line9")]
        public string? AddressLine9 { get; set; }

        /// <summary>
        /// <para>地址行 1（非拉丁语系的本地文字）</para>
        /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
        /// <para>必填：否</para>
        /// <para>示例值：丹佛测试地址-纽埃时区</para>
        /// </summary>
        [JsonPropertyName("local_address_line1")]
        public string? LocalAddressLine1 { get; set; }

        /// <summary>
        /// <para>地址行 2（非拉丁语系的本地文字）</para>
        /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
        /// <para>必填：否</para>
        /// <para>示例值：PoewH</para>
        /// </summary>
        [JsonPropertyName("local_address_line2")]
        public string? LocalAddressLine2 { get; set; }

        /// <summary>
        /// <para>地址行 3（非拉丁语系的本地文字）</para>
        /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
        /// <para>必填：否</para>
        /// <para>示例值：PoewH</para>
        /// </summary>
        [JsonPropertyName("local_address_line3")]
        public string? LocalAddressLine3 { get; set; }

        /// <summary>
        /// <para>地址行 4（非拉丁语系的本地文字）</para>
        /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
        /// <para>必填：否</para>
        /// <para>示例值：jmwJc</para>
        /// </summary>
        [JsonPropertyName("local_address_line4")]
        public string? LocalAddressLine4 { get; set; }

        /// <summary>
        /// <para>地址行 5（非拉丁语系的本地文字）</para>
        /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
        /// <para>必填：否</para>
        /// <para>示例值：jmwJc</para>
        /// </summary>
        [JsonPropertyName("local_address_line5")]
        public string? LocalAddressLine5 { get; set; }

        /// <summary>
        /// <para>地址行 6（非拉丁语系的本地文字）</para>
        /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
        /// <para>必填：否</para>
        /// <para>示例值：jmwJc</para>
        /// </summary>
        [JsonPropertyName("local_address_line6")]
        public string? LocalAddressLine6 { get; set; }

        /// <summary>
        /// <para>地址行 7（非拉丁语系的本地文字）</para>
        /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
        /// <para>必填：否</para>
        /// <para>示例值：jmwJc</para>
        /// </summary>
        [JsonPropertyName("local_address_line7")]
        public string? LocalAddressLine7 { get; set; }

        /// <summary>
        /// <para>地址行 8（非拉丁语系的本地文字）</para>
        /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
        /// <para>必填：否</para>
        /// <para>示例值：rafSu</para>
        /// </summary>
        [JsonPropertyName("local_address_line8")]
        public string? LocalAddressLine8 { get; set; }

        /// <summary>
        /// <para>地址行 9（非拉丁语系的本地文字）</para>
        /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
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
        /// <para>地址类型，枚举值及详细信息可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询获得。</para>
        /// <para>- 请求参数object_api_name=address；custom_api_name=address_type</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("address_type_list")]
        public Enum[]? AddressTypeLists { get; set; }

        /// <summary>
        /// <para>地址类型，枚举值及详细信息可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询获得。</para>
        /// <para>- 请求参数object_api_name=address；custom_api_name=address_type</para>
        /// </summary>
        public record Enum
        {
            /// <summary>
            /// <para>枚举值</para>
            /// <para>必填：是</para>
            /// <para>示例值：registered_address</para>
            /// </summary>
            [JsonPropertyName("enum_name")]
            public string EnumName { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>是否为主要地址</para>
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
    }

    /// <summary>
    /// <para>工时制度 ID，枚举值及详细信息可通过[【批量查询工时制度】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/list)接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：4690238309151997779</para>
    /// </summary>
    [JsonPropertyName("working_hours_type_id")]
    public string? WorkingHoursTypeId { get; set; }

    /// <summary>
    /// <para>版本生效日期</para>
    /// <para>- 填写格式：YYYY-MM-DD 00:00:00（系统会自动将时分秒改为00:00:00）</para>
    /// <para>- 系统默认为填写日期当天的 00:00:00 生效</para>
    /// <para>- 该接口只支持到最小单位为日</para>
    /// <para>- 日期范围要求:1900-01-01 00:00:00～9999-12-31 23:59:59</para>
    /// <para>- 详情可以参考[时间轴介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/about-timeline-version)</para>
    /// <para>必填：是</para>
    /// <para>示例值：2020-05-01 00:00:00</para>
    /// </summary>
    [JsonPropertyName("effective_time")]
    public string EffectiveTime { get; set; } = string.Empty;

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
