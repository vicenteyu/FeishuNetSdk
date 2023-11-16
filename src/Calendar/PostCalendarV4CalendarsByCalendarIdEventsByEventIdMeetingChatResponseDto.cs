namespace FeishuNetSdk.Calendar;
/// <summary>
/// 创建会议群 响应体
/// <para>该接口用于以当前身份（应用/用户）给日程创建一个会议群。</para>
/// <para>身份由 Header Authorization 的 Token 类型决定。</para>
/// <para>接口ID：7263360328350744580</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event-meeting_chat/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event-meeting_chat%2fcreate</para>
/// </summary>
public record PostCalendarV4CalendarsByCalendarIdEventsByEventIdMeetingChatResponseDto
{
    /// <summary>
    /// <para>会议群ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：oc_xxx</para>
    /// </summary>
    [JsonPropertyName("meeting_chat_id")]
    public string? MeetingChatId { get; set; }

    /// <summary>
    /// <para>群分享链接</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://example.cn?openChatId=oc_xxx</para>
    /// </summary>
    [JsonPropertyName("applink")]
    public string? Applink { get; set; }
}
