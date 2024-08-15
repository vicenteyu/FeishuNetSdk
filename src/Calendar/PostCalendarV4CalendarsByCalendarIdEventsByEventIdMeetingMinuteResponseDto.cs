// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-18
//
// Last Modified By : yxr
// Last Modified On : 2024-07-18
// ************************************************************************
// <copyright file="PostCalendarV4CalendarsByCalendarIdEventsByEventIdMeetingMinuteResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建会议纪要 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Calendar;
/// <summary>
/// 创建会议纪要 响应体
/// <para>调用该接口为指定的日程创建会议纪要。纪要以文档形式展示，成功创建后会返回纪要文档 URL。</para>
/// <para>## 注意事项</para>
/// <para>- 所操作的日历需要是当前身份（身份由 Header Authorization 的 Token 类型决定）的主日历，且当前身份具有日历的 writer 权限（即编辑权限）。</para>
/// <para>- 所操作的日程内至少需要有 1 个参与人，且参与人权限不能为 none（即无法查看参与人列表）。</para>
/// <para>接口ID：7263360328350760964</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event-meeting_minute/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event-meeting_minute%2fcreate</para>
/// </summary>
public record PostCalendarV4CalendarsByCalendarIdEventsByEventIdMeetingMinuteResponseDto
{
    /// <summary>
    /// <para>文档 URL</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://example.cn/xxx</para>
    /// </summary>
    [JsonPropertyName("doc_url")]
    public string? DocUrl { get; set; }
}
