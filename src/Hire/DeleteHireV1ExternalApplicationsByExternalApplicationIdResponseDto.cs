// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-12
// ************************************************************************
// <copyright file="DeleteHireV1ExternalApplicationsByExternalApplicationIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除外部投递 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 删除外部投递 响应体
/// <para>根据外部投递 ID 删除外部投递。</para>
/// <para>接口ID：7215630682033979420</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/import-external-system-information/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_application%2fdelete</para>
/// </summary>
public record DeleteHireV1ExternalApplicationsByExternalApplicationIdResponseDto
{
    /// <summary>
    /// <para>\-</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("external_application")]
    public DeleteHireV1ExternalApplicationsByExternalApplicationIdResponseDtoExternalApplication? ExternalApplication { get; set; }

    /// <summary>
    /// <para>\-</para>
    /// </summary>
    public record DeleteHireV1ExternalApplicationsByExternalApplicationIdResponseDtoExternalApplication
    {
        /// <summary>
        /// <para>外部投递 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6989202908470446380</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>职位招聘类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：社招</item>
        /// <item>2：校招</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("job_recruitment_type")]
        public int? JobRecruitmentType { get; set; }

        /// <summary>
        /// <para>职位名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：高级Java</para>
        /// </summary>
        [JsonPropertyName("job_title")]
        public string? JobTitle { get; set; }

        /// <summary>
        /// <para>简历来源</para>
        /// <para>必填：否</para>
        /// <para>示例值：lagou</para>
        /// </summary>
        [JsonPropertyName("resume_source")]
        public string? ResumeSource { get; set; }

        /// <summary>
        /// <para>阶段名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：简历初筛</para>
        /// </summary>
        [JsonPropertyName("stage")]
        public string? Stage { get; set; }

        /// <summary>
        /// <para>人才 ID，详情请查看：[获取人才信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent/get)</para>
        /// <para>必填：是</para>
        /// <para>示例值：6960663240925956459</para>
        /// </summary>
        [JsonPropertyName("talent_id")]
        public string TalentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>终止原因</para>
        /// <para>必填：否</para>
        /// <para>示例值：不合适</para>
        /// </summary>
        [JsonPropertyName("termination_reason")]
        public string? TerminationReason { get; set; }

        /// <summary>
        /// <para>投递类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：HR 寻访</item>
        /// <item>2：候选人主动投递</item>
        /// <item>3：人才推荐</item>
        /// <item>4：其他</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("delivery_type")]
        public int? DeliveryType { get; set; }

        /// <summary>
        /// <para>投递在外部系统终止时间，毫秒时间戳（字段类型为：int64）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618500278645</para>
        /// </summary>
        [JsonPropertyName("modify_time")]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>终止类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：HR 主动终止</para>
        /// </summary>
        [JsonPropertyName("termination_type")]
        public string? TerminationType { get; set; }
    }
}
