using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建投递 请求体
/// <para>根据人才 ID 和职位 ID 创建投递。</para>
/// <para>接口ID：6964286393804816412</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/application/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2fcreate</para>
/// </summary>
public record PostHireV1ApplicationsBodyDto
{
    /// <summary>
    /// <para>人才ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：12312312312</para>
    /// </summary>
    [JsonProperty("talent_id")]
    public string TalentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>职位ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：12312312312</para>
    /// </summary>
    [JsonProperty("job_id")]
    public string JobId { get; set; } = string.Empty;

    /// <summary>
    /// <para>简历来源 ID，可通过「获取简历来源」接口查询。若简历来源类型属于「员工转岗」或「实习生转正」，人才需处于已入职状态。</para>
    /// <para>必填：否</para>
    /// <para>示例值：7115289562569591070</para>
    /// </summary>
    [JsonProperty("resume_source_id")]
    public string? ResumeSourceId { get; set; }

    /// <summary>
    /// <para>意向投递城市列表，可从「获取职位信息」返回的工作地点列表获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：["CT_1"]</para>
    /// </summary>
    [JsonProperty("application_preferred_city_code_list")]
    public string[]? ApplicationPreferredCityCodeList { get; set; }
}
