// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-12
//
// Last Modified By : yxr
// Last Modified On : 2024-09-12
// ************************************************************************
// <copyright file="PostCorehrV1LeavesWorkCalendarDateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取工作日历日期详情 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 获取工作日历日期详情 请求体
/// <para>获取工作日历每一天的日期详情，如日期、日期类型等</para>
/// <para>接口ID：7408403062694084611</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/leave/work_calendar_date</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fleave%2fwork_calendar_date</para>
/// </summary>
public record PostCorehrV1LeavesWorkCalendarDateBodyDto
{
    /// <summary>
    /// <para>工作日历ID列表，最多100；可以通过[获取工作日历](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/leave/work_calendar) 获取工作日历ID</para>
    /// <para>必填：是</para>
    /// <para>示例值："7390282135276635692"</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("wk_calendar_ids")]
    public string[] WkCalendarIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>日期，格式："2006-01-02"，最多50个；</para>
    /// <para>**注意**：</para>
    /// <para>- 如果不传 ids 参数，则必须传 dates 参数或 [begin_date，end_date]参数</para>
    /// <para>- 如果传 ids 参数，则仅生效 ids 参数，无需传 dates 参数或 [begin_date，end_date]参数</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("dates")]
    public string[]? Dates { get; set; }

    /// <summary>
    /// <para>日期范围-开始日期，格式："2006-01-02"；需要和end_date一起使用；</para>
    /// <para>**注意**：</para>
    /// <para>- 如果不传 ids 参数，则必须传 dates 参数或 [begin_date，end_date]参数</para>
    /// <para>- 如果传 ids 参数，则仅生效 ids 参数，无需传 dates 参数或 [begin_date，end_date]参数</para>
    /// <para>必填：否</para>
    /// <para>示例值：2006-01-02</para>
    /// </summary>
    [JsonPropertyName("begin_date")]
    public string? BeginDate { get; set; }

    /// <summary>
    /// <para>日期范围-结束日期(含)，格式："2006-01-02"；需要和begin_date一起使用</para>
    /// <para>必填：否</para>
    /// <para>示例值：2006-01-02</para>
    /// </summary>
    [JsonPropertyName("end_date")]
    public string? EndDate { get; set; }

    /// <summary>
    /// <para>分页</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// </summary>
    [JsonPropertyName("offset")]
    public int? Offset { get; set; }

    /// <summary>
    /// <para>分页大小</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// </summary>
    [JsonPropertyName("limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// <para>日期id，可使用响应体中的data.calendar_dates.id</para>
    /// <para>**注意**：</para>
    /// <para>- 如果不传 ids 参数，则必须传 dates 参数或 [begin_date，end_date]参数</para>
    /// <para>- 如果传 ids 参数，则仅生效 ids 参数，无需传 dates 参数或 [begin_date，end_date]参数</para>
    /// <para>必填：否</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("ids")]
    public string[]? Ids { get; set; }
}
