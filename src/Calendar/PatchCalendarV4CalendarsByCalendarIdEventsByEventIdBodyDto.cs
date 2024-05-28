namespace FeishuNetSdk.Calendar;
/// <summary>
/// 更新日程 请求体
/// <para>调用该接口以当前身份（应用或用户）更新指定日历上的一个日程，包括日程标题、描述、开始与结束时间、视频会议以及日程地点等信息。</para>
/// <para>接口ID：6952888507003043867</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-event/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event%2fpatch</para>
/// </summary>
public record PatchCalendarV4CalendarsByCalendarIdEventsByEventIdBodyDto
{
    /// <summary>
    /// <para>日程标题。</para>
    /// <para>**默认值**：空，表示不更新该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：日程标题</para>
    /// <para>最大长度：1000</para>
    /// </summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>
    /// <para>日程描述。</para>
    /// <para>**注意**：目前 API 方式不支持编辑富文本描述。如果日程描述通过客户端编辑为富文本内容，则使用 API 更新描述会导致富文本格式丢失。</para>
    /// <para>**默认值**：空，表示不更新该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：日程描述</para>
    /// <para>最大长度：40960</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>更新日程时，是否给日程参与人发送 Bot 通知。</para>
    /// <para>**默认值**：空，表示不更新该字段</para>
    /// <para>**可选值有**：</para>
    /// <para>- true：发送通知</para>
    /// <para>- false：不发送通知</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("need_notification")]
    public bool? NeedNotification { get; set; }

    /// <summary>
    /// <para>日程开始时间。需要与end_time同时有值才会生效。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("start_time")]
    public TimeInfo? StartTime { get; set; }

    /// <summary>
    /// <para>日程开始时间。需要与end_time同时有值才会生效。</para>
    /// </summary>
    public record TimeInfo
    {
        /// <summary>
        /// <para>开始时间，仅全天日程使用该字段，[RFC 3339](https://datatracker.ietf.org/doc/html/rfc3339) 格式，例如，2018-09-01。</para>
        /// <para>**注意**：该参数不能与 `timestamp` 同时指定。</para>
        /// <para>必填：否</para>
        /// <para>示例值：2018-09-01</para>
        /// </summary>
        [JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// <para>秒级时间戳，用于设置具体的开始时间。例如，1602504000 表示 2020/10/12 20:00:00（UTC +8 时区）。</para>
        /// <para>**注意**：该参数不能与 `date` 同时指定。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1602504000</para>
        /// </summary>
        [JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// <para>时区。使用 IANA Time Zone Database 标准，例如 Asia/Shanghai。</para>
        /// <para>- 全天日程时区固定为UTC +0</para>
        /// <para>- 非全天日程时区默认为 Asia/Shanghai</para>
        /// <para>必填：否</para>
        /// <para>示例值：Asia/Shanghai</para>
        /// </summary>
        [JsonPropertyName("timezone")]
        public string? Timezone { get; set; }
    }

    /// <summary>
    /// <para>日程结束时间。需要与start_time同时有值才会生效。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("end_time")]
    public TimeInfo? EndTime { get; set; }

    /// <summary>
    /// <para>视频会议信息。不传值则表示不更新该字段。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("vchat")]
    public PatchCalendarV4CalendarsByCalendarIdEventsByEventIdBodyDtoVchat? Vchat { get; set; }

    /// <summary>
    /// <para>视频会议信息。不传值则表示不更新该字段。</para>
    /// </summary>
    public record PatchCalendarV4CalendarsByCalendarIdEventsByEventIdBodyDtoVchat
    {
        /// <summary>
        /// <para>视频会议类型。如果无需视频会议，则必须传入 `no_meeting`。</para>
        /// <para>必填：否</para>
        /// <para>示例值：third_party</para>
        /// <para>可选值：<list type="bullet">
        /// <item>vc：飞书视频会议。取该类型时，vchat 内的其他字段均无效。</item>
        /// <item>third_party：第三方链接视频会议。取该类型时，仅生效 vchat 内的 icon_type、description、meeting_url 字段。</item>
        /// <item>no_meeting：无视频会议。取该类型时，vchat 内的其他字段均无效。</item>
        /// <item>lark_live：飞书直播。该值用于客户端，不支持通过 API 调用，只读。</item>
        /// <item>unknown：未知类型。该值用于客户端做兼容使用，不支持通过 API 调用，只读。</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("vc_type")]
        public string? VcType { get; set; }

        /// <summary>
        /// <para>第三方视频会议的 icon 类型。</para>
        /// <para>**默认值**：空，表示不更新该字段</para>
        /// <para>必填：否</para>
        /// <para>示例值：vc</para>
        /// <para>可选值：<list type="bullet">
        /// <item>vc：飞书视频会议 icon</item>
        /// <item>live：直播视频会议 icon</item>
        /// <item>default：默认 icon</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("icon_type")]
        public string? IconType { get; set; }

        /// <summary>
        /// <para>第三方视频会议文案。</para>
        /// <para>**默认值**：空，表示不更新该字段</para>
        /// <para>必填：否</para>
        /// <para>示例值：发起视频会议</para>
        /// <para>最大长度：500</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>视频会议 URL。</para>
        /// <para>**默认值**：空，表示不更新该字段</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://example.com</para>
        /// <para>最大长度：2000</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("meeting_url")]
        public string? MeetingUrl { get; set; }

        /// <summary>
        /// <para>飞书视频会议（VC）的会前设置，需满足以下全部条件：</para>
        /// <para>- 当 `vc_type` 为 `vc` 时生效。</para>
        /// <para>- 需要有日程的编辑权限。</para>
        /// <para>不传值则表示不更新该字段。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("meeting_settings")]
        public PatchCalendarV4CalendarsByCalendarIdEventsByEventIdBodyDtoVchatMeetingSettings? MeetingSettings { get; set; }

        /// <summary>
        /// <para>飞书视频会议（VC）的会前设置，需满足以下全部条件：</para>
        /// <para>- 当 `vc_type` 为 `vc` 时生效。</para>
        /// <para>- 需要有日程的编辑权限。</para>
        /// <para>不传值则表示不更新该字段。</para>
        /// </summary>
        public record PatchCalendarV4CalendarsByCalendarIdEventsByEventIdBodyDtoVchatMeetingSettings
        {
            /// <summary>
            /// <para>设置会议 owner 的用户 ID，ID 类型需和 user_id_type 保持一致。</para>
            /// <para>该参数需满足以下全部条件才会生效：</para>
            /// <para>- 应用身份（tenant_access_token）请求，且在应用日历上操作日程。</para>
            /// <para>- 首次将日程设置为 VC 会议时，才能设置owner。</para>
            /// <para>- owner 不能为非用户身份。</para>
            /// <para>- owner 不能为外部租户用户身份。</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_7d8a6e6df7621556ce0d21922b676706ccs</para>
            /// </summary>
            [JsonPropertyName("owner_id")]
            public string? OwnerId { get; set; }

            /// <summary>
            /// <para>设置入会范围。</para>
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
            /// <para>通过用户 ID 指定主持人，ID 类型需和 user_id</para>
            /// <para>_type 保持一致。</para>
            /// <para>**注意**：</para>
            /// <para>- 仅日程组织者可以指定主持人。</para>
            /// <para>- 主持人不能是非用户身份。</para>
            /// <para>- 主持人不能是外部租户用户身份。</para>
            /// <para>- 在应用日历上操作日程时，不允许指定主持人。</para>
            /// <para>必填：否</para>
            /// <para>最大长度：10</para>
            /// </summary>
            [JsonPropertyName("assign_hosts")]
            public string[]? AssignHosts { get; set; }

            /// <summary>
            /// <para>是否开启自动录制。</para>
            /// <para>**可选值有**：</para>
            /// <para>- true：开启</para>
            /// <para>- false：不开启</para>
            /// <para>**默认值**：空，表示不更新该字段</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("auto_record")]
            public bool? AutoRecord { get; set; }

            /// <summary>
            /// <para>是否开启等候室。</para>
            /// <para>**可选值有**：</para>
            /// <para>- true：开启</para>
            /// <para>- false：不开启</para>
            /// <para>**默认值**：空，表示不更新该字段</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("open_lobby")]
            public bool? OpenLobby { get; set; }

            /// <summary>
            /// <para>是否允许日程参与者发起会议。</para>
            /// <para>**注意**：应用日历上操作日程时，该字段必须为 true，否则没有人能发起会议。</para>
            /// <para>**可选值有**：</para>
            /// <para>- true：允许</para>
            /// <para>- false：不允许</para>
            /// <para>**默认值**：空，表示不更新该字段</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("allow_attendees_start")]
            public bool? AllowAttendeesStart { get; set; }
        }
    }

    /// <summary>
    /// <para>日程公开范围。</para>
    /// <para>**注意**：更新日程时如果修改了该参数值，则仅对当前身份生效。</para>
    /// <para>**默认值**：空，表示不更新该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：default</para>
    /// <para>可选值：<list type="bullet">
    /// <item>default：默认权限，即跟随日历权限，默认仅向他人显示是否忙碌</item>
    /// <item>public：公开，显示日程详情</item>
    /// <item>private：私密，仅自己可见详情</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    /// <summary>
    /// <para>参与人权限。</para>
    /// <para>**默认值**：空，表示不更新该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：can_see_others</para>
    /// <para>可选值：<list type="bullet">
    /// <item>none：无法编辑日程、无法邀请其他参与人、无法查看参与人列表</item>
    /// <item>can_see_others：无法编辑日程、无法邀请其他参与人、可以查看参与人列表</item>
    /// <item>can_invite_others：无法编辑日程、可以邀请其他参与人、可以查看参与人列表</item>
    /// <item>can_modify_event：可以编辑日程、可以邀请其他参与人、可以查看参与人列表</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("attendee_ability")]
    public string? AttendeeAbility { get; set; }

    /// <summary>
    /// <para>日程占用的忙闲状态，新建日程默认为 `busy`。</para>
    /// <para>**注意**：更新日程时如果修改了该参数值，则仅对当前身份生效。</para>
    /// <para>**默认值**：空，表示不更新该字段</para>
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
    /// <para>日程地点。不传值则表示不更新该字段。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("location")]
    public EventLocation? Location { get; set; }

    /// <summary>
    /// <para>日程地点。不传值则表示不更新该字段。</para>
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
        /// <para>- 对于国内的地点，采用 GCJ-02 标准。</para>
        /// <para>- 对于海外的地点，采用 WGS84 标准。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1.100000023841858</para>
        /// </summary>
        [JsonPropertyName("latitude")]
        public float? Latitude { get; set; }

        /// <summary>
        /// <para>地点坐标经度信息。</para>
        /// <para>- 对于国内的地点，采用 GCJ-02 标准。</para>
        /// <para>- 对于海外的地点，采用 WGS84 标准。</para>
        /// <para>必填：否</para>
        /// <para>示例值：2.200000047683716</para>
        /// </summary>
        [JsonPropertyName("longitude")]
        public float? Longitude { get; set; }
    }

    /// <summary>
    /// <para>日程颜色，取值通过颜色 RGB 值的 int32 表示。</para>
    /// <para>**注意**：</para>
    /// <para>- 该参数仅对当前身份生效。</para>
    /// <para>- 客户端展示时会映射到色板上最接近的一种颜色。</para>
    /// <para>- 取值为 0 或 -1 时，默认跟随日历颜色。</para>
    /// <para>**默认值**：空，表示不更新该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：-1</para>
    /// </summary>
    [JsonPropertyName("color")]
    public int? Color { get; set; }

    /// <summary>
    /// <para>日程提醒列表。不传值则表示不更新该字段。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("reminders")]
    public Reminder[]? Reminders { get; set; }

    /// <summary>
    /// <para>日程提醒列表。不传值则表示不更新该字段。</para>
    /// </summary>
    public record Reminder
    {
        /// <summary>
        /// <para>日程提醒时间的偏移量。</para>
        /// <para>- 正数时表示在日程开始前 X 分钟提醒。</para>
        /// <para>- 负数时表示在日程开始后 X 分钟提醒。</para>
        /// <para>**注意**：更新日程时修改该字段仅对当前身份生效。</para>
        /// <para>必填：否</para>
        /// <para>示例值：5</para>
        /// <para>最大值：20160</para>
        /// <para>最小值：-20160</para>
        /// </summary>
        [JsonPropertyName("minutes")]
        public int? Minutes { get; set; }
    }

    /// <summary>
    /// <para>重复日程的重复性规则，规则设置方式参考[rfc5545](https://datatracker.ietf.org/doc/html/rfc5545#section-3.3.10)。</para>
    /// <para>**注意**：</para>
    /// <para>- COUNT 和 UNTIL 不支持同时出现。</para>
    /// <para>- 预定会议室重复日程长度不得超过两年。</para>
    /// <para>**默认值**：空，表示不更新该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：FREQ=DAILY;INTERVAL=1</para>
    /// <para>最大长度：2000</para>
    /// </summary>
    [JsonPropertyName("recurrence")]
    public string? Recurrence { get; set; }

    /// <summary>
    /// <para>日程自定义信息，控制日程详情页的 UI 展示。不传值则表示不更新该字段。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("schemas")]
    public Schema[]? Schemas { get; set; }

    /// <summary>
    /// <para>日程自定义信息，控制日程详情页的 UI 展示。不传值则表示不更新该字段。</para>
    /// </summary>
    public record Schema
    {
        /// <summary>
        /// <para>UI 名称。</para>
        /// <para>**可选值有**：</para>
        /// <para>- ForwardIcon：日程转发按钮</para>
        /// <para>- MeetingChatIcon：会议群聊按钮</para>
        /// <para>- MeetingMinutesIcon：会议纪要按钮</para>
        /// <para>- MeetingVideo：视频会议区域</para>
        /// <para>- RSVP：接受、拒绝、待定区域</para>
        /// <para>- Attendee：参与者区域</para>
        /// <para>- OrganizerOrCreator：组织者或创建者区域</para>
        /// <para>必填：否</para>
        /// <para>示例值：ForwardIcon</para>
        /// </summary>
        [JsonPropertyName("ui_name")]
        public string? UiName { get; set; }

        /// <summary>
        /// <para>UI 项的状态。目前只支持选择 `hide`。</para>
        /// <para>必填：否</para>
        /// <para>示例值：hide</para>
        /// <para>可选值：<list type="bullet">
        /// <item>hide：隐藏显示</item>
        /// <item>readonly：只读</item>
        /// <item>editable：可编辑</item>
        /// <item>unknown：未知 UI 项自定义状态。该参数仅用于读取时兼容，不支持作为请求参数值传入</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("ui_status")]
        public string? UiStatus { get; set; }

        /// <summary>
        /// <para>按钮点击后跳转的链接。</para>
        /// <para>**注意**：兼容性参数，只读，因此暂不支持传入该请求参数。</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.feishu.cn/client/calendar/event/detail?calendarId=xxxxxx&amp;key=xxxxxx&amp;originalTime=xxxxxx&amp;startTime=xxxxxx</para>
        /// <para>最大长度：2000</para>
        /// </summary>
        [JsonPropertyName("app_link")]
        public string? AppLink { get; set; }
    }

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
        /// <para>附件token，参考[上传素材](https://open.larkoffice.com/document/server-docs/docs/drive-v1/media/upload_all)获取file_token</para>
        /// <para>**注意**：</para>
        /// <para>- parent_type传入固定值 "calendar"</para>
        /// <para>- parent_node传入日历ID且与本接口日历ID保持一致</para>
        /// <para>**附件校验规则**:</para>
        /// <para>- 附件总大小不超过25MB</para>
        /// <para>必填：否</para>
        /// <para>示例值：xAAAAA</para>
        /// </summary>
        [JsonPropertyName("file_token")]
        public string? FileToken { get; set; }

        /// <summary>
        /// <para>是否删除附件</para>
        /// <para>**默认值**：</para>
        /// <para>- false: 不删除附件</para>
        /// <para>**可选值有**：</para>
        /// <para>- true: 删除附件</para>
        /// <para>- false: 不删除附件</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_deleted")]
        public bool? IsDeleted { get; set; }
    }
}
