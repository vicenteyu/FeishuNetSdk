namespace FeishuNetSdk.Calendar;
/// <summary>
/// 搜索日程 响应体
/// <para>该接口用于以用户身份搜索某日历下的相关日程。</para>
/// <para>身份由 Header Authorization 的 Token 类型决定。</para>
/// <para>接口ID：6952888507003109403</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-event/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event%2fsearch</para>
/// </summary>
public record PostCalendarV4CalendarsByCalendarIdEventsSearchResponseDto
{
    /// <summary>
    /// <para>搜索命中的日程列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public CalendarEvent[]? Items { get; set; }

    /// <summary>
    /// <para>搜索命中的日程列表</para>
    /// </summary>
    public record CalendarEvent
    {
        /// <summary>
        /// <para>日程ID。参见[日程ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/introduction)</para>
        /// <para>必填：是</para>
        /// <para>示例值：00592a0e-7edf-4678-bc9d-1b77383ef08e_0</para>
        /// </summary>
        [JsonPropertyName("event_id")]
        public string EventId { get; set; } = string.Empty;

        /// <summary>
        /// <para>日程组织者日历ID。参见[日历ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/introduction)</para>
        /// <para>必填：否</para>
        /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
        /// </summary>
        [JsonPropertyName("organizer_calendar_id")]
        public string? OrganizerCalendarId { get; set; }

        /// <summary>
        /// <para>日程标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：日程标题</para>
        /// <para>最大长度：1000</para>
        /// </summary>
        [JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// <para>日程描述；目前不支持编辑富文本描述，如果日程描述通过客户端编辑过，更新描述会导致富文本格式丢失</para>
        /// <para>必填：否</para>
        /// <para>示例值：日程描述</para>
        /// <para>最大长度：40960</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>日程开始时间</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public TimeInfo StartTime { get; set; } = new();

        /// <summary>
        /// <para>日程开始时间</para>
        /// </summary>
        public record TimeInfo
        {
            /// <summary>
            /// <para>仅全天日程使用该字段，如2018-09-01。需满足 RFC3339 格式。不能与 timestamp 同时指定</para>
            /// <para>必填：否</para>
            /// <para>示例值：2018-09-01</para>
            /// </summary>
            [JsonPropertyName("date")]
            public string? Date { get; set; }

            /// <summary>
            /// <para>秒级时间戳，如1602504000(表示2020/10/12 20:0:00 +8时区)</para>
            /// <para>必填：否</para>
            /// <para>示例值：1602504000</para>
            /// </summary>
            [JsonPropertyName("timestamp")]
            public string? Timestamp { get; set; }

            /// <summary>
            /// <para>时区名称，使用IANA Time Zone Database标准，如Asia/Shanghai；全天日程时区固定为UTC，非全天日程时区默认为Asia/Shanghai</para>
            /// <para>必填：否</para>
            /// <para>示例值：Asia/Shanghai</para>
            /// </summary>
            [JsonPropertyName("timezone")]
            public string? Timezone { get; set; }
        }

        /// <summary>
        /// <para>日程结束时间</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public TimeInfo EndTime { get; set; } = new();

        /// <summary>
        /// <para>日程公开范围，新建日程默认为Default；仅新建日程时对所有参与人生效，之后修改该属性仅对当前身份生效</para>
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
        /// <para>参与人权限</para>
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
        /// <para>日程占用的忙闲状态，新建日程默认为Busy；仅新建日程时对所有参与人生效，之后修改该属性仅对当前身份生效</para>
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
        /// <para>日程地点</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("location")]
        public EventLocation? Location { get; set; }

        /// <summary>
        /// <para>日程地点</para>
        /// </summary>
        public record EventLocation
        {
            /// <summary>
            /// <para>地点名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：地点名称</para>
            /// <para>最大长度：512</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>地点地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：地点地址</para>
            /// <para>最大长度：255</para>
            /// </summary>
            [JsonPropertyName("address")]
            public string? Address { get; set; }

            /// <summary>
            /// <para>地点坐标纬度信息，对于国内的地点，采用GCJ-02标准，海外地点采用WGS84标准</para>
            /// <para>必填：否</para>
            /// <para>示例值：1.100000023841858</para>
            /// </summary>
            [JsonPropertyName("latitude")]
            public float? Latitude { get; set; }

            /// <summary>
            /// <para>地点坐标经度信息，对于国内的地点，采用GCJ-02标准，海外地点采用WGS84标准</para>
            /// <para>必填：否</para>
            /// <para>示例值：2.200000047683716</para>
            /// </summary>
            [JsonPropertyName("longitude")]
            public float? Longitude { get; set; }
        }

        /// <summary>
        /// <para>日程颜色，颜色RGB值的int32表示。仅对当前身份生效；客户端展示时会映射到色板上最接近的一种颜色；值为0或-1时默认跟随日历颜色。</para>
        /// <para>必填：否</para>
        /// <para>示例值：-1</para>
        /// </summary>
        [JsonPropertyName("color")]
        public int? Color { get; set; }

        /// <summary>
        /// <para>日程提醒列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("reminders")]
        public Reminder[]? Reminders { get; set; }

        /// <summary>
        /// <para>日程提醒列表</para>
        /// </summary>
        public record Reminder
        {
            /// <summary>
            /// <para>日程提醒时间的偏移量，正数时表示在日程开始前X分钟提醒，负数时表示在日程开始后X分钟提醒。</para>
            /// <para>新建或更新日程时传入该字段，仅对当前身份生效，不会对日程其他参与人生效。</para>
            /// <para>必填：否</para>
            /// <para>示例值：5</para>
            /// </summary>
            [JsonPropertyName("minutes")]
            public int? Minutes { get; set; }
        }

        /// <summary>
        /// <para>重复日程的重复性规则；参考[rfc5545](https://datatracker.ietf.org/doc/html/rfc5545#section-3.3.10)；</para>
        /// <para>- 不支持COUNT和UNTIL同时出现；</para>
        /// <para>- 预定会议室重复日程长度不得超过两年。</para>
        /// <para>必填：否</para>
        /// <para>示例值：FREQ=DAILY;INTERVAL=1</para>
        /// <para>最大长度：2000</para>
        /// </summary>
        [JsonPropertyName("recurrence")]
        public string? Recurrence { get; set; }

        /// <summary>
        /// <para>日程状态</para>
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
        /// <para>日程是否是一个重复日程的例外日程</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_exception")]
        public bool? IsException { get; set; }

        /// <summary>
        /// <para>例外日程的原重复日程的event_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：1cd45aaa-fa70-4195-80b7-c93b2e208f45</para>
        /// </summary>
        [JsonPropertyName("recurring_event_id")]
        public string? RecurringEventId { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxxxx</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
