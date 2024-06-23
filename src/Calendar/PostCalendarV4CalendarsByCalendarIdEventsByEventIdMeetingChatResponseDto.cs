// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCalendarV4CalendarsByCalendarIdEventsByEventIdMeetingChatResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建会议群 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Calendar;
/// <summary>
/// 创建会议群 响应体
/// <para>调用该接口以当前身份（应用或用户）为指定日程创建一个会议群。</para>
/// <para>接口ID：7263360328350744580</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event-meeting_chat/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event-meeting_chat%2fcreate</para>
/// </summary>
public record PostCalendarV4CalendarsByCalendarIdEventsByEventIdMeetingChatResponseDto
{
    /// <summary>
    /// <para>会议群 ID。后续可用于解绑会议群。</para>
    /// <para>必填：否</para>
    /// <para>示例值：oc_xxx</para>
    /// </summary>
    [JsonPropertyName("meeting_chat_id")]
    public string? MeetingChatId { get; set; }

    /// <summary>
    /// <para>群分享链接。</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://example.cn?openChatId=oc_xxx</para>
    /// </summary>
    [JsonPropertyName("applink")]
    public string? Applink { get; set; }
}
