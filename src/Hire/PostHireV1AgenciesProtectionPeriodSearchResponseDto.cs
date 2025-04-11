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
/// <para>查询指定人才的猎头保护期信息列表，包含保护期起止时间、猎头供应商、猎头顾问信息等。若人才已经入职，还会返回入职时所在的保护期信息。</para>
/// <para>接口ID：7307160083569655811</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/agency/protect_search</para>
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
    /// <para>入职时所在保护期，当且仅当`is_onboarded = true &amp;&amp; onboarded_in_protection = true`时，该字段有值</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("onboarded_protection")]
    public AgencyProtection? OnboardedProtection { get; set; }

    /// <summary>
    /// <para>入职时所在保护期，当且仅当`is_onboarded = true &amp;&amp; onboarded_in_protection = true`时，该字段有值</para>
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
        /// <para>如保护期类型为 职位保护期（`2`）时，返回职位保护所在的投递 ID，详情请参考：[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6930815272790114323</para>
        /// </summary>
        [JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>保护期开始时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1700023694629</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>保护期过期时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1700023694630</para>
        /// </summary>
        [JsonPropertyName("expire_time")]
        public string? ExpireTime { get; set; }

        /// <summary>
        /// <para>猎头供应商 ID，详情请参考：[获取猎头供应商信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/agency/get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6930815272790114324</para>
        /// </summary>
        [JsonPropertyName("agency_supplier_id")]
        public string? AgencySupplierId { get; set; }

        /// <summary>
        /// <para>猎头供应商名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agency_supplier_name")]
        public I18n? AgencySupplierName { get; set; }

        /// <summary>
        /// <para>猎头供应商名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：超越猎头公司</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：chaoyue head-hunting company</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>猎头顾问 ID，与`user_id_type`类型一致。</para>
        /// <para>**注意**：由于猎头顾问位于猎头供应商租户，不在本接口调用方租户里，若需获取猎头信息，需切换租户至猎头供应商租户后通过[获取单个用户信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/get)访问猎头顾问详情</para>
        /// <para>必填：否</para>
        /// <para>示例值：6930815272790114324</para>
        /// </summary>
        [JsonPropertyName("agency_supplier_user_id")]
        public string? AgencySupplierUserId { get; set; }

        /// <summary>
        /// <para>猎头顾问名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agency_supplier_user_name")]
        public I18n? AgencySupplierUserName { get; set; }
    }

    /// <summary>
    /// <para>保护期列表，若返回空，则表明人才上没有任何的保护期</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("protection_list")]
    public AgencyProtection[]? ProtectionLists { get; set; }
}
