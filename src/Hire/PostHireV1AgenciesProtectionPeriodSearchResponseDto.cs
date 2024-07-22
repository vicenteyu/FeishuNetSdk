// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1AgenciesProtectionPeriodSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询猎头保护期信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 查询猎头保护期信息 响应体
/// <para>查询猎头保护期信息</para>
/// <para>接口ID：7307160083569655811</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/agency/protect_search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fagency%2fprotect_search</para>
/// </summary>
public record PostHireV1AgenciesProtectionPeriodSearchResponseDto
{
    /// <summary>
    /// <para>是否已入职</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("is_onboarded")]
    public bool? IsOnboarded { get; set; }

    /// <summary>
    /// <para>是否在猎头保护期内入职</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("onboarded_in_protection")]
    public bool? OnboardedInProtection { get; set; }

    /// <summary>
    /// <para>入职所在保护期</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("onboarded_protection")]
    public AgencyProtection? OnboardedProtection { get; set; }

    /// <summary>
    /// <para>入职所在保护期</para>
    /// </summary>
    public record AgencyProtection
    {
        /// <summary>
        /// <para>保护期类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：人才保护期</item>
        /// <item>2：职位保护期</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("protection_type")]
        public int? ProtectionType { get; set; }

        /// <summary>
        /// <para>如保护期类型为职位保护，返回职位保护所在的投递id</para>
        /// <para>必填：否</para>
        /// <para>示例值：6930815272790114323</para>
        /// </summary>
        [JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>保护期开始时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1700023694629</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>保护期过期时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1700023694630</para>
        /// </summary>
        [JsonPropertyName("expire_time")]
        public string? ExpireTime { get; set; }

        /// <summary>
        /// <para>推荐的猎头供应商 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6930815272790114324</para>
        /// </summary>
        [JsonPropertyName("agency_supplier_id")]
        public string? AgencySupplierId { get; set; }

        /// <summary>
        /// <para>推荐的猎头供应商名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agency_supplier_name")]
        public I18n? AgencySupplierName { get; set; }

        /// <summary>
        /// <para>推荐的猎头供应商名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试猎头</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：test agency</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>推荐的猎头顾问ID，目前仅作为唯一标识，不可查询具体的人员信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：6930815272790114324</para>
        /// </summary>
        [JsonPropertyName("agency_supplier_user_id")]
        public string? AgencySupplierUserId { get; set; }

        /// <summary>
        /// <para>推荐的猎头顾问名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agency_supplier_user_name")]
        public I18n? AgencySupplierUserName { get; set; }
    }

    /// <summary>
    /// <para>人才保护信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("protection_list")]
    public AgencyProtection[]? ProtectionLists { get; set; }
}
