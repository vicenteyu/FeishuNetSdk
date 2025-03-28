// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-03-29
//
// Last Modified By : yxr
// Last Modified On : 2025-03-29
// ************************************************************************
// <copyright file="GetCorehrV2JobsQueryRecentChangeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询当前生效信息发生变更的职务 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询当前生效信息发生变更的职务 响应体
/// <para>查询指定时间范围内当前生效信息发生变更的职务，即只有职务当前生效版本的生效时间在查询时间范围内，才返回该职务id</para>
/// <para>接口ID：7473775676862119940</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/query_recent_change</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob%2fquery_recent_change</para>
/// </summary>
public record GetCorehrV2JobsQueryRecentChangeResponseDto
{
    /// <summary>
    /// <para>职务ID 列表， 其中包含新建、更新以及删除的 ID 列表</para>
    /// <para>- 非删除的数据，可通过[批量查询职务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/get) 获取详情</para>
    /// <para>必填：否</para>
    /// <para>最大长度：2000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("job_ids")]
    public string[]? JobIds { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>目标查询时间范围内被删除的职务列表， 该列表是 job_ids 的子集，便于获取在指定的[start_date, end_date+1) 的范围内被删除的职务 IDs。</para>
    /// <para>- **由于对应的职务已经被删除，无法通过 ID 查询到历史数据。**</para>
    /// <para>必填：否</para>
    /// <para>最大长度：2000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("deleted_job_ids")]
    public string[]? DeletedJobIds { get; set; }
}
