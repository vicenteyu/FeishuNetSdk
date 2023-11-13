using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新外部投递 请求体
/// <para>更新外部投递，对外部投递的字段进行覆盖更新。</para>
/// <para>接口ID：7215630682033963036</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/import-external-system-information/update-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_application%2fupdate</para>
/// </summary>
public record PutHireV1ExternalApplicationsByExternalApplicationIdBodyDto
{
    /// <summary>
    /// <para>外部系统背调主键 （仅用于幂等）</para>
    /// <para>必填：否</para>
    /// <para>示例值：123</para>
    /// </summary>
    [JsonProperty("external_id")]
    public string? ExternalId { get; set; }

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
    /// <para>更新时间，招聘系统内用作投递在外部系统终止时间</para>
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
