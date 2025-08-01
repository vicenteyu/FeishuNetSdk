// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-01
//
// Last Modified By : yxr
// Last Modified On : 2025-08-01
// ************************************************************************
// <copyright file="PostCorehrV2JobFamiliesQueryMultiTimelineBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询指定时间范围序列版本 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询指定时间范围序列版本 请求体
/// <para>- 接口支持查询出对象生效时间段在指定的start_date和end_date之间的版本</para>
/// <para>- 接口支持对象版本相关字段的查询和返回（默认返回id和version_id）</para>
/// <para>- 适用于需要回顾某段时间内对象版本变化的场景</para>
/// <para>接口ID：7473071080241561604</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job_family/query_multi_timeline</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_family%2fquery_multi_timeline</para>
/// </summary>
public record PostCorehrV2JobFamiliesQueryMultiTimelineBodyDto
{
    /// <summary>
    /// <para>序列ID。ID获取方式：</para>
    /// <para>- 调用[【新建序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/create)[【查询租户的序列信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/list)等接口可以返回序列ID</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("job_family_ids")]
    public string[] JobFamilyIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>查询开始时间（包含）</para>
    /// <para>- start_date 不能大于 end_date</para>
    /// <para>- 必填字段，无默认值</para>
    /// <para>必填：否</para>
    /// <para>示例值：2024-01-01</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：10</para>
    /// </summary>
    [JsonPropertyName("start_date")]
    public string? StartDate { get; set; }

    /// <summary>
    /// <para>查询结束时间(不包含)</para>
    /// <para>- 必填字段，无默认值</para>
    /// <para>必填：否</para>
    /// <para>示例值：2024-12-31</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：10</para>
    /// </summary>
    [JsonPropertyName("end_date")]
    public string? EndDate { get; set; }

    /// <summary>
    /// <para>返回数据的字段列表，可选["job_family_name", "code", "active", "parent_job_family", "selectable","pathway","description", "effective_date", "expiration_date"]</para>
    /// <para>- 无默认值，为空时只能查询到ID</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("fields")]
    public string[]? Fields { get; set; }
}
