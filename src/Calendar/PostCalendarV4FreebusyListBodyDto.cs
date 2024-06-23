// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCalendarV4FreebusyListBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询主日历日程忙闲信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Calendar;
/// <summary>
/// 查询主日历日程忙闲信息 请求体
/// <para>调用该接口查询指定用户的主日历忙闲信息，或者查询指定会议室的忙闲信息。</para>
/// <para>接口ID：6952888507002912795</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2ffreebusy%2flist</para>
/// </summary>
public record PostCalendarV4FreebusyListBodyDto
{
    /// <summary>
    /// <para>查询时段开始时间，[RFC 3339](https://datatracker.ietf.org/doc/html/rfc3339) date_time 格式。</para>
    /// <para>**注意**：time_min 与 time_max 之间的时间间隔不能大于 90 天。</para>
    /// <para>必填：是</para>
    /// <para>示例值：2020-10-28T12:00:00+08:00</para>
    /// </summary>
    [JsonPropertyName("time_min")]
    public string TimeMin { get; set; } = string.Empty;

    /// <summary>
    /// <para>查询时段结束时间，[RFC 3339](https://datatracker.ietf.org/doc/html/rfc3339) date_time 格式。</para>
    /// <para>**注意**：time_min 与 time_max 之间的时间间隔不能大于 90 天。</para>
    /// <para>必填：是</para>
    /// <para>示例值：2020-12-28T12:00:00+08:00</para>
    /// </summary>
    [JsonPropertyName("time_max")]
    public string TimeMax { get; set; } = string.Empty;

    /// <summary>
    /// <para>用户 ID，需要传入与查询参数 user_id_type 相匹配的 id。例如，`user_id_type=open_id` 时，需要传入用户的 open_id。了解用户 ID 参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
    /// <para>**注意**：user_id 与 room_id 需要二选一传入，如果同时传入则只生效 user_id。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_xxxxxxxxxx</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>会议室 room_id。你可以调用[查询会议室列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/room/list)接口或者[搜索会议室](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/room/search)接口，获取相应会议室的 room_id。</para>
    /// <para>**注意**：user_id 与 room_id 需要二选一传入，如果同时传入则只生效 user_id。</para>
    /// <para>必填：否</para>
    /// <para>示例值：omm_xxxxxxxxxx</para>
    /// </summary>
    [JsonPropertyName("room_id")]
    public string? RoomId { get; set; }

    /// <summary>
    /// <para>是否包含绑定的三方日历中的日程。</para>
    /// <para>**取值**：</para>
    /// <para>- true（默认值）：包含</para>
    /// <para>- false：不包含</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("include_external_calendar")]
    public bool? IncludeExternalCalendar { get; set; }

    /// <summary>
    /// <para>是否只查询忙碌日程信息。</para>
    /// <para>**取值**：</para>
    /// <para>- true（默认值）：是，查询结果不包含空闲日程。</para>
    /// <para>- false：否，查询结果包含空闲日程。</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("only_busy")]
    public bool? OnlyBusy { get; set; }
}
