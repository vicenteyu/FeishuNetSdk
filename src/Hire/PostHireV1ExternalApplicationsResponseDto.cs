using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建外部投递 响应体
/// <para>导入来自其他系统的投递信息，创建为外部投递。</para>
/// <para>接口ID：6992822583076388867</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/import-external-system-information/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_application%2fcreate</para>
/// </summary>
public record PostHireV1ExternalApplicationsResponseDto
{
    /// <summary>
    /// <para>外部投递信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("external_application")]
    public PostHireV1ExternalApplicationsResponseDtoExternalApplication? ExternalApplication { get; set; }

    /// <summary>
    /// <para>外部投递信息</para>
    /// </summary>
    public record PostHireV1ExternalApplicationsResponseDtoExternalApplication
    {
        /// <summary>
        /// <para>外部投递 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6989202908470446380</para>
        /// </summary>
        [JsonProperty("id")]
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
        [JsonProperty("job_recruitment_type")]
        public int? JobRecruitmentType { get; set; }

        /// <summary>
        /// <para>职位名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：高级Java</para>
        /// </summary>
        [JsonProperty("job_title")]
        public string? JobTitle { get; set; }

        /// <summary>
        /// <para>简历来源</para>
        /// <para>必填：否</para>
        /// <para>示例值：lagou</para>
        /// </summary>
        [JsonProperty("resume_source")]
        public string? ResumeSource { get; set; }

        /// <summary>
        /// <para>阶段</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonProperty("stage")]
        public string? Stage { get; set; }

        /// <summary>
        /// <para>人才 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6960663240925956459</para>
        /// </summary>
        [JsonProperty("talent_id")]
        public string TalentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>终止原因</para>
        /// <para>必填：否</para>
        /// <para>示例值：不合适</para>
        /// </summary>
        [JsonProperty("termination_reason")]
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
        [JsonProperty("delivery_type")]
        public int? DeliveryType { get; set; }

        /// <summary>
        /// <para>投递在外部系统终止时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618500278645</para>
        /// </summary>
        [JsonProperty("modify_time")]
        public int? ModifyTime { get; set; }

        /// <summary>
        /// <para>投递在外部系统创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618500278644</para>
        /// </summary>
        [JsonProperty("create_time")]
        public int? CreateTime { get; set; }

        /// <summary>
        /// <para>终止类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：health</para>
        /// </summary>
        [JsonProperty("termination_type")]
        public string? TerminationType { get; set; }
    }
}
