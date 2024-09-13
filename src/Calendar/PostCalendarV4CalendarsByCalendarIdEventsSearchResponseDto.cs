// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCalendarV4CalendarsByCalendarIdEventsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索日程 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Calendar;
/// <summary>
/// 搜索日程 响应体
/// <para>调用该接口搜索指定日历下的相关日程，支持关键词搜索、过滤条件搜索。</para>
/// <para>## 注意事项</para>
/// <para>适用于主日历和共享日历，且当前身份必须对日历有 reader、writer 或 owner 权限。你可以调用[查询日历信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/get)接口，获取当前身份对日历的访问权限。</para>
/// <para>接口ID：6952888507003109403</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-event/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event%2fsearch</para>
/// </summary>
public record PostCalendarV4CalendarsByCalendarIdEventsSearchResponseDto
{
    /// <summary>
    /// <para>搜索命中的日程列表。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public CalendarEvent[]? Items { get; set; }

    /// <summary>
    /// <para>搜索命中的日程列表。</para>
    /// </summary>
    public record CalendarEvent
    {
        /// <summary>
        /// <para>日程 ID。后续可通过该 ID 查询、更新或删除日程信息。更多信息可参见[日程 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/introduction)。</para>
        /// <para>必填：是</para>
        /// <para>示例值：00592a0e-7edf-4678-bc9d-1b77383ef08e_0</para>
        /// </summary>
        [JsonPropertyName("event_id")]
        public string EventId { get; set; } = string.Empty;

        /// <summary>
        /// <para>日程组织者的日历 ID。关于日历 ID 可参见[日历 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/introduction)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
        /// </summary>
        [JsonPropertyName("organizer_calendar_id")]
        public string? OrganizerCalendarId { get; set; }

        /// <summary>
        /// <para>日程标题。</para>
        /// <para>必填：否</para>
        /// <para>示例值：日程标题</para>
        /// <para>最大长度：1000</para>
        /// </summary>
        [JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// <para>日程描述。</para>
        /// <para>必填：否</para>
        /// <para>示例值：日程描述</para>
        /// <para>最大长度：40960</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>日程开始时间。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public TimeInfo StartTime { get; set; } = new();

        /// <summary>
        /// <para>日程开始时间。</para>
        /// </summary>
        public record TimeInfo
        {
            /// <summary>
            /// <para>开始时间，仅全天日程使用该字段，[RFC 3339](https://datatracker.ietf.org/doc/html/rfc3339) 格式，例如，2018-09-01。</para>
            /// <para>必填：否</para>
            /// <para>示例值：2018-09-01</para>
            /// </summary>
            [JsonPropertyName("date")]
            public string? Date { get; set; }

            /// <summary>
            /// <para>秒级时间戳，指日程具体的开始时间。例如，1602504000 表示 2020/10/12 20:00:00（UTC +8 时区）。</para>
            /// <para>必填：否</para>
            /// <para>示例值：1602504000</para>
            /// </summary>
            [JsonPropertyName("timestamp")]
            public string? Timestamp { get; set; }

            /// <summary>
            /// <para>时区。使用 IANA Time Zone Database 标准。</para>
            /// <para>必填：否</para>
            /// <para>示例值：Asia/Shanghai</para>
            /// </summary>
            [JsonPropertyName("timezone")]
            public string? Timezone { get; set; }
        }

        /// <summary>
        /// <para>日程结束时间。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public TimeInfo EndTime { get; set; } = new();

        /// <summary>
        /// <para>日程公开范围。仅新建日程时对所有参与人生效，之后修改该属性仅对当前身份生效。</para>
        /// <para>必填：否</para>
        /// <para>示例值：default</para>
        /// <para>可选值：<list type="bullet">
        /// <item>default：默认权限，跟随日历权限，默认仅向他人显示是否“忙碌”</item>
        /// <item>public：公开，显示日程详情</item>
        /// <item>private：私密，仅自己可见详情</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("visibility")]
        public string? Visibility { get; set; }

        /// <summary>
        /// <para>参与人权限。</para>
        /// <para>必填：否</para>
        /// <para>示例值：can_see_others</para>
        /// <para>可选值：<list type="bullet">
        /// <item>none：无法编辑日程、无法邀请其它参与人、无法查看参与人列表</item>
        /// <item>can_see_others：无法编辑日程、无法邀请其它参与人、可以查看参与人列表</item>
        /// <item>can_invite_others：无法编辑日程、可以邀请其它参与人、可以查看参与人列表</item>
        /// <item>can_modify_event：可以编辑日程、可以邀请其它参与人、可以查看参与人列表</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("attendee_ability")]
        public string? AttendeeAbility { get; set; }

        /// <summary>
        /// <para>日程占用的忙闲状态。仅新建日程时对所有参与人生效，之后修改该属性仅对当前身份生效。</para>
        /// <para>必填：否</para>
        /// <para>示例值：busy</para>
        /// <para>可选值：<list type="bullet">
        /// <item>busy：忙碌</item>
        /// <item>free：空闲</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("free_busy_status")]
        public string? FreeBusyStatus { get; set; }

        /// <summary>
        /// <para>日程地点。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("location")]
        public EventLocation? Location { get; set; }

        /// <summary>
        /// <para>日程地点。</para>
        /// </summary>
        public record EventLocation
        {
            /// <summary>
            /// <para>地点名称。</para>
            /// <para>必填：否</para>
            /// <para>示例值：地点名称</para>
            /// <para>最大长度：512</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>地点地址。</para>
            /// <para>必填：否</para>
            /// <para>示例值：地点地址</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("address")]
            public string? Address { get; set; }

            /// <summary>
            /// <para>地点坐标纬度信息。</para>
            /// <para>- 对于国内的地点，采用 GCJ-02 标准</para>
            /// <para>- 对于海外的地点，采用 WGS84 标准</para>
            /// <para>必填：否</para>
            /// <para>示例值：1.100000023841858</para>
            /// </summary>
            [JsonPropertyName("latitude")]
            public float? Latitude { get; set; }

            /// <summary>
            /// <para>地点坐标经度信息。</para>
            /// <para>- 对于国内的地点，采用 GCJ-02 标准</para>
            /// <para>- 对于海外的地点，采用 WGS84 标准</para>
            /// <para>必填：否</para>
            /// <para>示例值：2.200000047683716</para>
            /// </summary>
            [JsonPropertyName("longitude")]
            public float? Longitude { get; set; }
        }

        /// <summary>
        /// <para>日程颜色，由颜色 RGB 值的 int32 表示。</para>
        /// <para>**说明**：</para>
        /// <para>- 仅对当前身份生效。</para>
        /// <para>- 取值为 0 或 -1 时，表示默认跟随日历颜色。</para>
        /// <para>- 客户端展示时会映射到色板上最接近的一种颜色。</para>
        /// <para>必填：否</para>
        /// <para>示例值：-1</para>
        /// </summary>
        [JsonPropertyName("color")]
        public int? Color { get; set; }

        /// <summary>
        /// <para>日程提醒列表。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("reminders")]
        public Reminder[]? Reminders { get; set; }

        /// <summary>
        /// <para>日程提醒列表。</para>
        /// </summary>
        public record Reminder
        {
            /// <summary>
            /// <para>日程提醒时间的偏移量。该参数仅对当前身份生效。</para>
            /// <para>- 正数时表示在日程开始前 X 分钟提醒。</para>
            /// <para>- 负数时表示在日程开始后 X 分钟提醒。</para>
            /// <para>必填：否</para>
            /// <para>示例值：5</para>
            /// <para>最大值：20160</para>
            /// <para>最小值：-20160</para>
            /// </summary>
            [JsonPropertyName("minutes")]
            public int? Minutes { get; set; }
        }

        /// <summary>
        /// <para>重复日程的重复性规则，规则格式可参见 [rfc5545](https://datatracker.ietf.org/doc/html/rfc5545#section-3.3.10)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：FREQ=DAILY;INTERVAL=1</para>
        /// <para>最大长度：2000</para>
        /// </summary>
        [JsonPropertyName("recurrence")]
        public string? Recurrence { get; set; }

        /// <summary>
        /// <para>日程状态。</para>
        /// <para>必填：否</para>
        /// <para>示例值：confirmed</para>
        /// <para>可选值：<list type="bullet">
        /// <item>tentative：未回应</item>
        /// <item>confirmed：已确认</item>
        /// <item>cancelled：日程已取消</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// <para>日程是否是一个重复日程的例外日程。了解例外日程，可参见[例外日程](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/introduction#71c5ec78)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_exception")]
        public bool? IsException { get; set; }

        /// <summary>
        /// <para>例外日程对应的原重复日程的 event_id。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1cd45aaa-fa70-4195-80b7-c93b2e208f45</para>
        /// </summary>
        [JsonPropertyName("recurring_event_id")]
        public string? RecurringEventId { get; set; }

        /// <summary>
        /// <para>日程组织者信息。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("event_organizer")]
        public CalendarEventEventOrganizer? EventOrganizer { get; set; }

        /// <summary>
        /// <para>日程组织者信息。</para>
        /// </summary>
        public record CalendarEventEventOrganizer
        {
            /// <summary>
            /// <para>日程组织者 user ID。</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_xxxxxx</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>日程组织者姓名。</para>
            /// <para>必填：否</para>
            /// <para>示例值：孙二二</para>
            /// </summary>
            [JsonPropertyName("display_name")]
            public string? DisplayName { get; set; }
        }

        /// <summary>
        /// <para>日程的 app_link，跳转到具体的某个日程。</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.larkoffice.com/client/calendar/event/detail?calendarId=7039673579105026066&amp;key=aeac9c56-aeb1-4179-a21b-02f278f59048&amp;originalTime=0&amp;startTime=1700496000</para>
        /// </summary>
        [JsonPropertyName("app_link")]
        public string? AppLink { get; set; }

        /// <summary>
        /// <para>日程附件</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("attachments")]
        public Attachment[]? Attachments { get; set; }

        /// <summary>
        /// <para>日程附件</para>
        /// </summary>
        public record Attachment
        {
            /// <summary>
            /// <para>附件token</para>
            /// <para>必填：否</para>
            /// <para>示例值：xAAAAA</para>
            /// </summary>
            [JsonPropertyName("file_token")]
            public string? FileToken { get; set; }

            /// <summary>
            /// <para>附件大小</para>
            /// <para>必填：否</para>
            /// <para>示例值：2345</para>
            /// </summary>
            [JsonPropertyName("file_size")]
            public string? FileSize { get; set; }

            /// <summary>
            /// <para>是否删除附件</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_deleted")]
            public bool? IsDeleted { get; set; }

            /// <summary>
            /// <para>附件名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：附件.jpeg</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxxxx</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
