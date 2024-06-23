// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHireV1ApplicationsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建投递 请求体</summary>
// ************************************************************************
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
    [JsonPropertyName("talent_id")]
    public string TalentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>职位ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：12312312312</para>
    /// </summary>
    [JsonPropertyName("job_id")]
    public string JobId { get; set; } = string.Empty;

    /// <summary>
    /// <para>人员ID，仅在投递来源为属于「员工转岗」或「实习生转正」时，需传入该字段。校验数据无误后，会成为招聘方维护的一条人才、员工关联关系记录；创建其他来源投递时，不会进行人员与人才绑定</para>
    /// <para>必填：否</para>
    /// <para>示例值：6930815272790114324</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>简历来源 ID，可通过「获取简历来源」接口查询。若简历来源类型属于「员工转岗」或「实习生转正」，人才需处于已入职状态。</para>
    /// <para>必填：否</para>
    /// <para>示例值：7115289562569591070</para>
    /// </summary>
    [JsonPropertyName("resume_source_id")]
    public string? ResumeSourceId { get; set; }

    /// <summary>
    /// <para>意向投递城市列表，可从「获取职位信息」返回的工作地点列表获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：["CT_1"]</para>
    /// </summary>
    [JsonPropertyName("application_preferred_city_code_list")]
    public string[]? ApplicationPreferredCityCodeList { get; set; }
}
