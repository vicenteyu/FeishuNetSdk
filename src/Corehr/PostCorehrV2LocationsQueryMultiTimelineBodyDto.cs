// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-01
//
// Last Modified By : yxr
// Last Modified On : 2026-05-01
// ************************************************************************
// <copyright file="PostCorehrV2LocationsQueryMultiTimelineBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询指定时间范围地点版本 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询指定时间范围地点版本 请求体
/// <para>- 接口支持查询出对象生效时间段在指定的start_date和end_date之间的版本（即：会查询出生效时间段和查询时间段有交集的版本）</para>
/// <para>- 接口支持对象版本相关字段的查询和返回（默认返回id和version_id）</para>
/// <para>接口ID：7473071080241528836</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/location/query_multi_timeline</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2flocation%2fquery_multi_timeline</para>
/// </summary>
public record PostCorehrV2LocationsQueryMultiTimelineBodyDto
{
    /// <summary>
    /// <para>地点ID。ID获取方式：</para>
    /// <para>- 调用[【创建地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/create)[【批量分页查询地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)等接口可以返回地点ID</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("location_ids")]
    public string[] LocationIds { get; set; } = [];

    /// <summary>
    /// <para>查询开始时间（包含）</para>
    /// <para>必填：否</para>
    /// <para>示例值：2024-01-01</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：10</para>
    /// </summary>
    [JsonPropertyName("start_date")]
    public string? StartDate { get; set; }

    /// <summary>
    /// <para>查询结束时间(不包含)</para>
    /// <para>必填：否</para>
    /// <para>示例值：2024-12-31</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：10</para>
    /// </summary>
    [JsonPropertyName("end_date")]
    public string? EndDate { get; set; }

    /// <summary>
    /// <para>返回数据的字段列表，可选值</para>
    /// <para>- location_name：地点名称</para>
    /// <para>- code：编码</para>
    /// <para>- active ：是否启用</para>
    /// <para>- parent_location：上级地点</para>
    /// <para>- description：描述</para>
    /// <para>- effective_date：当前版本生效日期</para>
    /// <para>- expiration_date：当前版本失效日期</para>
    /// <para>- location_usage：地点用途</para>
    /// <para>- working_hours_type：工时制度</para>
    /// <para>- locale：区域设置</para>
    /// <para>- time_zone：时区</para>
    /// <para>- display_language：默认语言</para>
    /// <para>- address：地址</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("fields")]
    public string[]? Fields { get; set; }
}
