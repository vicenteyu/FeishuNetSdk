namespace FeishuNetSdk.Calendar;
/// <summary>
/// 创建日程 响应体
/// <para>该接口用于以当前身份（应用 / 用户）在日历上创建一个日程。</para>
/// <para>身份由 Header Authorization 的 Token 类型决定。</para>
/// <para>接口ID：6990540948577599491</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-event/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event%2fcreate</para>
/// </summary>
public record PostCalendarV4CalendarsByCalendarIdEventsResponseDto
{
    /// <summary>
    /// <para>新创建的日程实体</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("event")]
    public CalendarEvent? Event { get; set; }

    /// <summary>
    /// <para>新创建的日程实体</para>
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
        /// <para>更新日程是否给日程参与人发送bot通知，默认为true</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("need_notification")]
        public bool? NeedNotification { get; set; }

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
        /// <para>视频会议信息。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("vchat")]
        public CalendarEventVchat? Vchat { get; set; }

        /// <summary>
        /// <para>视频会议信息。</para>
        /// </summary>
        public record CalendarEventVchat
        {
            /// <summary>
            /// <para>视频会议类型；可以为空，为空会在首次添加日程参与人时，自动生成飞书视频会议URL。若无需视频会议时需显式传入no_meeting。</para>
            /// <para>必填：否</para>
            /// <para>示例值：third_party</para>
            /// <para>可选值：<list type="bullet">
            /// <item>vc：飞书视频会议，取该类型时，其他字段无效。</item>
            /// <item>third_party：第三方链接视频会议，取该类型时，icon_type、description、meeting_url字段生效。</item>
            /// <item>no_meeting：无视频会议，取该类型时，其他字段无效。</item>
            /// <item>lark_live：飞书直播，内部类型，飞书客户端使用，API不支持创建，只读。</item>
            /// <item>unknown：未知类型，做兼容使用，飞书客户端使用，API不支持创建，只读。</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("vc_type")]
            public string? VcType { get; set; }

            /// <summary>
            /// <para>第三方视频会议icon类型；可以为空，为空展示默认icon。</para>
            /// <para>必填：否</para>
            /// <para>示例值：vc</para>
            /// <para>可选值：<list type="bullet">
            /// <item>vc：飞书视频会议icon</item>
            /// <item>live：直播视频会议icon</item>
            /// <item>default：默认icon</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("icon_type")]
            public string? IconType { get; set; }

            /// <summary>
            /// <para>第三方视频会议文案，可以为空，为空展示默认文案</para>
            /// <para>必填：否</para>
            /// <para>示例值：发起视频会议</para>
            /// <para>最大长度：500</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string? Description { get; set; }

            /// <summary>
            /// <para>视频会议URL</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://example.com</para>
            /// <para>最大长度：2000</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("meeting_url")]
            public string? MeetingUrl { get; set; }

            /// <summary>
            /// <para>VC视频会议的会前设置。需要满足以下条件(需全部满足)：</para>
            /// <para>- 当vc_type为vc时生效。</para>
            /// <para>- 需要有日程的编辑权限。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("meeting_settings")]
            public CalendarEventVchatMeetingSettings? MeetingSettings { get; set; }

            /// <summary>
            /// <para>VC视频会议的会前设置。需要满足以下条件(需全部满足)：</para>
            /// <para>- 当vc_type为vc时生效。</para>
            /// <para>- 需要有日程的编辑权限。</para>
            /// </summary>
            public record CalendarEventVchatMeetingSettings
            {
                /// <summary>
                /// <para>设置会议 owner。需要满足以下条件(需全部满足)：</para>
                /// <para>- tenant_access_token身份请求，且在应用日历上操作日程。</para>
                /// <para>- 日程首次设置VC会议。</para>
                /// <para>- owner不能为非用户身份。</para>
                /// <para>- owner不能为外租户用户身份。</para>
                /// <para>必填：否</para>
                /// <para>示例值：ou_7d8a6e6df7621556ce0d21922b676706ccs</para>
                /// </summary>
                [JsonPropertyName("owner_id")]
                public string? OwnerId { get; set; }

                /// <summary>
                /// <para>设置入会范围</para>
                /// <para>必填：否</para>
                /// <para>示例值：only_organization_employees</para>
                /// <para>可选值：<list type="bullet">
                /// <item>anyone_can_join：所有人可以加入会议</item>
                /// <item>only_organization_employees：仅企业内用户可以加入会议</item>
                /// <item>only_event_attendees：仅日程参与者可以加入会议</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("join_meeting_permission")]
                public string? JoinMeetingPermission { get; set; }

                /// <summary>
                /// <para>指定主持人。</para>
                /// <para>- 仅日程组织者可以指定主持人。</para>
                /// <para>- 主持人不能是非用户身份。</para>
                /// <para>- 主持人不能是外租户用户身份。</para>
                /// <para>- 应用日历上操作日程时，不允许指定主持人。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("assign_hosts")]
                public string[]? AssignHosts { get; set; }

                /// <summary>
                /// <para>设置自动录制</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("auto_record")]
                public bool? AutoRecord { get; set; }

                /// <summary>
                /// <para>开启等候室</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("open_lobby")]
                public bool? OpenLobby { get; set; }

                /// <summary>
                /// <para>允许日程参与者发起会议。</para>
                /// <para>- 应用日历上操作日程时，该字段必须为true，否则没有人能发起会议。</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("allow_attendees_start")]
                public bool? AllowAttendeesStart { get; set; }
            }
        }

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
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>地点地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：地点地址</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：1</para>
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
            /// <para>最大值：20160</para>
            /// <para>最小值：-20160</para>
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

        /// <summary>
        /// <para>日程的创建时间（秒级时间戳）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1602504000</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>日程自定义信息；控制日程详情页的ui展示。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("schemas")]
        public Schema[]? Schemas { get; set; }

        /// <summary>
        /// <para>日程自定义信息；控制日程详情页的ui展示。</para>
        /// </summary>
        public record Schema
        {
            /// <summary>
            /// <para>UI名称。取值范围如下：</para>
            /// <para>- ForwardIcon: 日程转发按钮</para>
            /// <para>- MeetingChatIcon: 会议群聊按钮</para>
            /// <para>- MeetingMinutesIcon: 会议纪要按钮</para>
            /// <para>- MeetingVideo: 视频会议区域</para>
            /// <para>- RSVP: 接受/拒绝/待定区域</para>
            /// <para>- Attendee: 参与者区域</para>
            /// <para>- OrganizerOrCreator: 组织者/创建者区域</para>
            /// <para>必填：否</para>
            /// <para>示例值：ForwardIcon</para>
            /// </summary>
            [JsonPropertyName("ui_name")]
            public string? UiName { get; set; }

            /// <summary>
            /// <para>UI项自定义状态。**目前只支持hide**</para>
            /// <para>必填：否</para>
            /// <para>示例值：hide</para>
            /// <para>可选值：<list type="bullet">
            /// <item>hide：隐藏显示</item>
            /// <item>readonly：只读</item>
            /// <item>editable：可编辑</item>
            /// <item>unknown：未知UI项自定义状态，仅用于读取时兼容</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("ui_status")]
            public string? UiStatus { get; set; }

            /// <summary>
            /// <para>按钮点击后跳转的链接; **该字段暂不支持传入。**</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://applink.feishu.cn/client/calendar/event/detail?calendarId=xxxxxx&amp;key=xxxxxx&amp;originalTime=xxxxxx&amp;startTime=xxxxxx</para>
            /// <para>最大长度：2000</para>
            /// </summary>
            [JsonPropertyName("app_link")]
            public string? AppLink { get; set; }
        }

        /// <summary>
        /// <para>日程组织者信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("event_organizer")]
        public CalendarEventEventOrganizer? EventOrganizer { get; set; }

        /// <summary>
        /// <para>日程组织者信息</para>
        /// </summary>
        public record CalendarEventEventOrganizer
        {
            /// <summary>
            /// <para>日程组织者user ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_xxxxxx</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>日程组织者姓名</para>
            /// <para>必填：否</para>
            /// <para>示例值：孙二二</para>
            /// </summary>
            [JsonPropertyName("display_name")]
            public string? DisplayName { get; set; }
        }

        /// <summary>
        /// <para>日程的app_link,跳转到具体的某个日程</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.larkoffice.com/client/calendar/event/detail?calendarId=7039673579105026066&amp;key=aeac9c56-aeb1-4179-a21b-02f278f59048&amp;originalTime=0&amp;startTime=1700496000</para>
        /// </summary>
        [JsonPropertyName("app_link")]
        public string? AppLink { get; set; }
    }
}
