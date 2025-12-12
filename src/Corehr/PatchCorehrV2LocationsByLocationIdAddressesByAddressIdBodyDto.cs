// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-03
//
// Last Modified By : yxr
// Last Modified On : 2025-12-12
// ************************************************************************
// <copyright file="PatchCorehrV2LocationsByLocationIdAddressesByAddressIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新地点地址 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 更新地点地址 请求体
/// <para>更新地点地址</para>
/// <para>接口ID：7420421437192929283</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/location/location-address/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2flocation-address%2fpatch</para>
/// </summary>
public record PatchCorehrV2LocationsByLocationIdAddressesByAddressIdBodyDto
{
    /// <summary>
    /// <para>国家 / 地区 ID</para>
    /// <para>- 可通过[【查询国家/地区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6862995757234914824</para>
    /// </summary>
    [JsonPropertyName("country_region_id")]
    public string? CountryRegionId { get; set; }

    /// <summary>
    /// <para>主要行政区 ID</para>
    /// <para>- 可通过[【查询省份/行政区信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6863326264296474119</para>
    /// </summary>
    [JsonPropertyName("region_id")]
    public string? RegionId { get; set; }

    /// <summary>
    /// <para>城市ID。</para>
    /// <para>- 详情调用[【查询城市信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-city/search)获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6863333555859097096</para>
    /// </summary>
    [JsonPropertyName("city_id")]
    public string? CityId { get; set; }

    /// <summary>
    /// <para>区/县ID</para>
    /// <para>- 详情可通过[【查询区县信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-district/search)接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6863333556291110408</para>
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
    /// <para>示例值：丹佛测试地址-纽埃时区</para>
    /// </summary>
    [JsonPropertyName("local_address_line2")]
    public string? LocalAddressLine2 { get; set; }

    /// <summary>
    /// <para>地址行 3（非拉丁语系的本地文字）</para>
    /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
    /// <para>必填：否</para>
    /// <para>示例值：丹佛测试地址-纽埃时区</para>
    /// </summary>
    [JsonPropertyName("local_address_line3")]
    public string? LocalAddressLine3 { get; set; }

    /// <summary>
    /// <para>地址行 4（非拉丁语系的本地文字）</para>
    /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
    /// <para>必填：否</para>
    /// <para>示例值：丹佛测试地址-纽埃时区</para>
    /// </summary>
    [JsonPropertyName("local_address_line4")]
    public string? LocalAddressLine4 { get; set; }

    /// <summary>
    /// <para>地址行 5（非拉丁语系的本地文字）</para>
    /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
    /// <para>必填：否</para>
    /// <para>示例值：丹佛测试地址-纽埃时区</para>
    /// </summary>
    [JsonPropertyName("local_address_line5")]
    public string? LocalAddressLine5 { get; set; }

    /// <summary>
    /// <para>地址行 6（非拉丁语系的本地文字）</para>
    /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
    /// <para>必填：否</para>
    /// <para>示例值：丹佛测试地址-纽埃时区</para>
    /// </summary>
    [JsonPropertyName("local_address_line6")]
    public string? LocalAddressLine6 { get; set; }

    /// <summary>
    /// <para>地址行 7（非拉丁语系的本地文字）</para>
    /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
    /// <para>必填：否</para>
    /// <para>示例值：丹佛测试地址-纽埃时区</para>
    /// </summary>
    [JsonPropertyName("local_address_line7")]
    public string? LocalAddressLine7 { get; set; }

    /// <summary>
    /// <para>地址行 8（非拉丁语系的本地文字）</para>
    /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
    /// <para>必填：否</para>
    /// <para>示例值：丹佛测试地址-纽埃时区</para>
    /// </summary>
    [JsonPropertyName("local_address_line8")]
    public string? LocalAddressLine8 { get; set; }

    /// <summary>
    /// <para>地址行 9（非拉丁语系的本地文字）</para>
    /// <para>- 填写规则可见[【地址填写指南】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/basic-infomation/data-calculation-rules/address-completion-guidelines)</para>
    /// <para>必填：否</para>
    /// <para>示例值：丹佛测试地址-纽埃时区</para>
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
    /// <para>地址类型，枚举值及详细信息可通过[【枚举常量介绍】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)查询获得</para>
    /// <para>必填：否</para>
    /// <para>最大长度：5</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("address_types")]
    public Enum[]? AddressTypes { get; set; }

    /// <summary>
    /// <para>地址类型，枚举值及详细信息可通过[【枚举常量介绍】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)查询获得</para>
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
    /// <para>是否主要地址，一个地点只能存在一个主要地址，更新地址为主要地址会取消原主要地址，无法更新主要地址为非主要地址</para>
    /// <para>- true 表示地址是主要地址</para>
    /// <para>- false 表示地址不是主要地址</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("is_primary")]
    public bool? IsPrimary { get; set; }

    /// <summary>
    /// <para>是否公开地址</para>
    /// <para>- true 表示地址是公开地址</para>
    /// <para>- false 表示地址不是公开地址</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("is_public")]
    public bool? IsPublic { get; set; }
}
