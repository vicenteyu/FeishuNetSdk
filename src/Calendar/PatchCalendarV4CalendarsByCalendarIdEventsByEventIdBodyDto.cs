using Newtonsoft.Json;
namespace FeishuNetSdk.Calendar;
/// <summary>
/// 更新日程 请求体
/// <para>该接口用于以当前身份（应用 / 用户）更新日历上的一个日程。</para>
/// <para>身份由 Header Authorization 的 Token 类型决定。</para>
/// <para>接口ID：6952888507003043867</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-event/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event%2fpatch</para>
/// </summary>
public record PatchCalendarV4CalendarsByCalendarIdEventsByEventIdBodyDto
{
    /// <summary>
    /// <para>日程标题</para>
    /// <para>必填：否</para>
    /// <para>示例值：日程标题</para>
    /// <para>最大长度：1000</para>
    /// </summary>
    [JsonProperty("summary")]
    public string? Summary { get; set; }

    /// <summary>
    /// <para>日程描述；目前不支持编辑富文本描述，如果日程描述通过客户端编辑过，更新描述会导致富文本格式丢失</para>
    /// <para>必填：否</para>
    /// <para>示例值：日程描述</para>
    /// <para>最大长度：40960</para>
    /// </summary>
    [JsonProperty("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>更新日程是否给日程参与人发送bot通知，默认为true</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonProperty("need_notification")]
    public bool? NeedNotification { get; set; }

    /// <summary>
    /// <para>日程开始时间</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("start_time")]
    public TimeInfo? StartTime { get; set; }

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
        [JsonProperty("date")]
        public string? Date { get; set; }

        /// <summary>
        /// <para>秒级时间戳，如1602504000(表示2020/10/12 20:0:00 +8时区)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1602504000</para>
        /// </summary>
        [JsonProperty("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// <para>时区名称，使用IANA Time Zone Database标准，如Asia/Shanghai；全天日程时区固定为UTC，非全天日程时区默认为Asia/Shanghai</para>
        /// <para>必填：否</para>
        /// <para>示例值：Asia/Shanghai</para>
        /// </summary>
        [JsonProperty("timezone")]
        public string? Timezone { get; set; }
    }

    /// <summary>
    /// <para>日程结束时间</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("end_time")]
    public TimeInfo? EndTime { get; set; }

    /// <summary>
    /// <para>视频会议信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("vchat")]
    public PatchCalendarV4CalendarsByCalendarIdEventsByEventIdBodyDtoVchat? Vchat { get; set; }

    /// <summary>
    /// <para>视频会议信息。</para>
    /// </summary>
    public record PatchCalendarV4CalendarsByCalendarIdEventsByEventIdBodyDtoVchat
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
        [JsonProperty("vc_type")]
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
        [JsonProperty("icon_type")]
        public string? IconType { get; set; }

        /// <summary>
        /// <para>第三方视频会议文案，可以为空，为空展示默认文案</para>
        /// <para>必填：否</para>
        /// <para>示例值：发起视频会议</para>
        /// <para>最大长度：500</para>
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>视频会议URL</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://example.com</para>
        /// <para>最大长度：2000</para>
        /// </summary>
        [JsonProperty("meeting_url")]
        public string? MeetingUrl { get; set; }

        /// <summary>
        /// <para>VC视频会议的会前设置。需要满足以下条件(需全部满足)：</para>
        /// <para>- 当vc_type为vc时生效。</para>
        /// <para>- 需要有日程的编辑权限。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("meeting_settings")]
        public PatchCalendarV4CalendarsByCalendarIdEventsByEventIdBodyDtoVchatMeetingSettings? MeetingSettings { get; set; }

        /// <summary>
        /// <para>VC视频会议的会前设置。需要满足以下条件(需全部满足)：</para>
        /// <para>- 当vc_type为vc时生效。</para>
        /// <para>- 需要有日程的编辑权限。</para>
        /// </summary>
        public record PatchCalendarV4CalendarsByCalendarIdEventsByEventIdBodyDtoVchatMeetingSettings
        {
            /// <summary>
            /// <para>设置会议 owner。需要满足以下条件(需全部满足)：</para>
            /// <para>-  tenant_access_token身份请求，且在应用日历上操作日程。</para>
            /// <para>- 首次将日程设置为VC会议，才能设置owner。</para>
            /// <para>- owner不能为非用户身份。</para>
            /// <para>- owner不能为外租户用户身份。</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_7d8a6e6df7621556ce0d21922b676706ccs</para>
            /// </summary>
            [JsonProperty("owner_id")]
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
            [JsonProperty("join_meeting_permission")]
            public string? JoinMeetingPermission { get; set; }

            /// <summary>
            /// <para>指定主持人。</para>
            /// <para>- 仅日程组织者可以指定主持人。</para>
            /// <para>- 主持人不能是非用户身份。</para>
            /// <para>- 主持人不能是外租户用户身份。</para>
            /// <para>- 应用日历上操作日程时，不允许指定主持人。</para>
            /// <para>必填：否</para>
            /// <para>最大长度：10</para>
            /// </summary>
            [JsonProperty("assign_hosts")]
            public string[]? AssignHosts { get; set; }

            /// <summary>
            /// <para>设置自动录制</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonProperty("auto_record")]
            public bool? AutoRecord { get; set; }

            /// <summary>
            /// <para>开启等候室</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonProperty("open_lobby")]
            public bool? OpenLobby { get; set; }

            /// <summary>
            /// <para>允许日程参与者发起会议。</para>
            /// <para>- 应用日历上操作日程时，该字段必须为true，否则没有人能发起会议。</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonProperty("allow_attendees_start")]
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
    [JsonProperty("visibility")]
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
    [JsonProperty("attendee_ability")]
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
    [JsonProperty("free_busy_status")]
    public string? FreeBusyStatus { get; set; }

    /// <summary>
    /// <para>日程地点</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("location")]
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
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>地点地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：地点地址</para>
        /// <para>最大长度：255</para>
        /// </summary>
        [JsonProperty("address")]
        public string? Address { get; set; }

        /// <summary>
        /// <para>地点坐标纬度信息，对于国内的地点，采用GCJ-02标准，海外地点采用WGS84标准</para>
        /// <para>必填：否</para>
        /// <para>示例值：1.100000023841858</para>
        /// </summary>
        [JsonProperty("latitude")]
        public float? Latitude { get; set; }

        /// <summary>
        /// <para>地点坐标经度信息，对于国内的地点，采用GCJ-02标准，海外地点采用WGS84标准</para>
        /// <para>必填：否</para>
        /// <para>示例值：2.200000047683716</para>
        /// </summary>
        [JsonProperty("longitude")]
        public float? Longitude { get; set; }
    }

    /// <summary>
    /// <para>日程颜色，颜色RGB值的int32表示。仅对当前身份生效；客户端展示时会映射到色板上最接近的一种颜色；值为0或-1时默认跟随日历颜色。</para>
    /// <para>必填：否</para>
    /// <para>示例值：-1</para>
    /// </summary>
    [JsonProperty("color")]
    public int? Color { get; set; }

    /// <summary>
    /// <para>日程提醒列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("reminders")]
    public Reminder[]? Reminders { get; set; }

    /// <summary>
    /// <para>日程提醒列表</para>
    /// </summary>
    public record Reminder
    {
        /// <summary>
        /// <para>日程提醒时间的偏移量，正数时表示在日程开始前X分钟提醒，负数时表示在日程开始后X分钟提醒</para>
        /// <para>新建或更新日程时传入该字段，仅对当前身份生效，不会对日程其他参与人生效。</para>
        /// <para>必填：否</para>
        /// <para>示例值：5</para>
        /// </summary>
        [JsonProperty("minutes")]
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
    [JsonProperty("recurrence")]
    public string? Recurrence { get; set; }

    /// <summary>
    /// <para>日程自定义信息；控制日程详情页的ui展示。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("schemas")]
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
        [JsonProperty("ui_name")]
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
        [JsonProperty("ui_status")]
        public string? UiStatus { get; set; }

        /// <summary>
        /// <para>按钮点击后跳转的链接; **该字段暂不支持传入。**</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.feishu.cn/client/calendar/event/detail?calendarId=xxxxxx&key=xxxxxx&originalTime=xxxxxx&startTime=xxxxxx</para>
        /// <para>最大长度：2000</para>
        /// </summary>
        [JsonProperty("app_link")]
        public string? AppLink { get; set; }
    }
}
