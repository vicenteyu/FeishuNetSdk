// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-06
// ************************************************************************
// <copyright file="PostHireV1ApplicationsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建投递 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建投递 请求体
/// <para>为人才在特定职位上创建投递。</para>
/// <para>接口ID：6964286393804816412</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/application/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2fcreate</para>
/// </summary>
public record PostHireV1ApplicationsBodyDto
{
    /// <summary>
    /// <para>人才 ID，可通过[获取人才列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent/list)获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：6889020179456689671</para>
    /// </summary>
    [JsonPropertyName("talent_id")]
    public string TalentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>职位 ID，可通过[获取职位列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job/list)获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：6889330484657424647</para>
    /// </summary>
    [JsonPropertyName("job_id")]
    public string JobId { get; set; } = string.Empty;

    /// <summary>
    /// <para>人员 ID，与入参 `user_id_type` 类型一致。</para>
    /// <para>**注意**：</para>
    /// <para>若投递来源为属于「员工转岗」或「实习生转正」时必填，创建投递成功后会将该员工和对应人才进行绑定；创建其他来源投递时，不会进行人员与人才绑定。</para>
    /// <para>必填：否</para>
    /// <para>示例值：6930815272790114324</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>简历来源 ID，可通过[获取简历来源列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/resume_source/list)获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：7115289562569591070</para>
    /// </summary>
    [JsonPropertyName("resume_source_id")]
    public string? ResumeSourceId { get; set; }

    /// <summary>
    /// <para>意向投递城市列表，可通过[查询地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)</para>
    /// <para>获取到对应的城市编码</para>
    /// <para>必填：否</para>
    /// <para>示例值：["CT_1"]</para>
    /// </summary>
    [JsonPropertyName("application_preferred_city_code_list")]
    public string[]? ApplicationPreferredCityCodeList { get; set; }

    /// <summary>
    /// <para>投递方式</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：HR 寻访</item>
    /// <item>2：候选人主动投递</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("delivery_type")]
    public int? DeliveryType { get; set; }
}
