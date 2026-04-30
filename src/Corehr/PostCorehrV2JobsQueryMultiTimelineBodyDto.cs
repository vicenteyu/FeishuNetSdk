// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-01
//
// Last Modified By : yxr
// Last Modified On : 2026-05-01
// ************************************************************************
// <copyright file="PostCorehrV2JobsQueryMultiTimelineBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询指定时间范围职务版本 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询指定时间范围职务版本 请求体
/// <para>- 接口支持查询出对象生效时间段在指定的start_date和end_date之间的版本（即：会查询出生效时间段和查询时间段有交集的版本）</para>
/// <para>- 接口支持对象版本相关字段的查询和返回（默认返回id和version_id）</para>
/// <para>接口ID：7473071080241577988</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job/query_multi_timeline</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob%2fquery_multi_timeline</para>
/// </summary>
public record PostCorehrV2JobsQueryMultiTimelineBodyDto
{
    /// <summary>
    /// <para>职务 ID 列表</para>
    /// <para>- 可通过[【批量查询职务】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/list)获取ID</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("job_ids")]
    public string[] JobIds { get; set; } = [];

    /// <summary>
    /// <para>查询开始时间（包含），注意事项：</para>
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
    /// <para>查询结束时间(不包含)，注意事项：</para>
    /// <para>- 必填字段，无默认值</para>
    /// <para>必填：否</para>
    /// <para>示例值：2024-12-31</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：10</para>
    /// </summary>
    [JsonPropertyName("end_date")]
    public string? EndDate { get; set; }

    /// <summary>
    /// <para>返回数据的字段列表，可选</para>
    /// <para>- job_name：职务名称</para>
    /// <para>- code：编码</para>
    /// <para>- active：是否启用</para>
    /// <para>- parent_job：（该字段无效，请忽略）</para>
    /// <para>- description：描述</para>
    /// <para>- effective_date：当前版本生效日期</para>
    /// <para>- expiration_date：当前版本失效日期</para>
    /// <para>- job_title：职务头衔</para>
    /// <para>- job_family：序列</para>
    /// <para>- job_level：职级</para>
    /// <para>- pathway：通道</para>
    /// <para>- working_hours_type：工时制度</para>
    /// <para>注意事项：</para>
    /// <para>- 为空时只能查询到ID</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("fields")]
    public string[]? Fields { get; set; }
}
