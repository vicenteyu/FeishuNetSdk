// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-09
// ************************************************************************
// <copyright file="PostHireV1TalentsBatchGetIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取人才ID 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 批量获取人才ID 响应体
/// <para>通过手机号、邮箱、证件号，批量查询人才ID</para>
/// <para>接口ID：7125370772851458076</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/batch_get_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fbatch_get_id</para>
/// </summary>
public record PostHireV1TalentsBatchGetIdResponseDto
{
    /// <summary>
    /// <para>人才信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("talent_list")]
    public TalentBatchInfo[]? TalentLists { get; set; }

    /// <summary>
    /// <para>人才信息列表</para>
    /// </summary>
    public record TalentBatchInfo
    {
        /// <summary>
        /// <para>人才 ID，详情请查看：[获取人才信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent/get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6891560630172518670</para>
        /// </summary>
        [JsonPropertyName("talent_id")]
        public string? TalentId { get; set; }

        /// <summary>
        /// <para>国际区号，遵守国际统一标准，请参考[百度百科-国际长途电话区号](https://baike.baidu.com/item/%E5%9B%BD%E9%99%85%E9%95%BF%E9%80%94%E7%94%B5%E8%AF%9D%E5%8C%BA%E5%8F%B7%E8%A1%A8/12803495?fr=ge_ala)，仅当入参传入`mobile_number_list `时返回</para>
        /// <para>必填：否</para>
        /// <para>示例值：86</para>
        /// </summary>
        [JsonPropertyName("mobile_code")]
        public string? MobileCode { get; set; }

        /// <summary>
        /// <para>手机号，仅当入参传入`mobile_number_list`时返回</para>
        /// <para>必填：否</para>
        /// <para>示例值：182900291190</para>
        /// </summary>
        [JsonPropertyName("mobile_number")]
        public string? MobileNumber { get; set; }

        /// <summary>
        /// <para>邮箱，仅当入参传入`email_list `时返回</para>
        /// <para>必填：否</para>
        /// <para>示例值：foo@bytedance.com</para>
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// <para>证件类型，枚举定义详见文档：[枚举常量介绍](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/enum)</para>
        /// <para>的 IdentificationType，仅当入参传入`identification_number_list `时返回</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("identification_type")]
        public int? IdentificationType { get; set; }

        /// <summary>
        /// <para>证件号，仅当入参传入`identification_number_list `时返回</para>
        /// <para>必填：否</para>
        /// <para>示例值：510403xxxxxxxx</para>
        /// </summary>
        [JsonPropertyName("identification_number")]
        public string? IdentificationNumber { get; set; }

        /// <summary>
        /// <para>是否已入职</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// <para>可选值：<list type="bullet">
        /// <item>false：未入职</item>
        /// <item>true：已入职</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("is_onboarded")]
        public bool? IsOnboarded { get; set; }
    }
}
