namespace FeishuNetSdk.Calendar;
/// <summary>
/// 查询日程视图 响应体
/// <para>该接口用于以用户身份查询某日历下的日程视图（重复性日程展开）。</para>
/// <para>身份由 Header Authorization 的 Token 类型决定。</para>
/// <para>接口ID：7322810271218647043</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/instance_view</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event%2finstance_view</para>
/// </summary>
public record GetCalendarV4CalendarsByCalendarIdEventsInstanceViewResponseDto
{
    /// <summary>
    /// <para>日程instance列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Instance[]? Items { get; set; }

    /// <summary>
    /// <para>日程instance列表</para>
    /// </summary>
    public record Instance
    {
        /// <summary>
        /// <para>日程实例ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：75d28f9b-e35c-4230-8a83-4a661497db54_1602504000</para>
        /// </summary>
        [JsonPropertyName("event_id")]
        public string EventId { get; set; } = string.Empty;

        /// <summary>
        /// <para>日程主题</para>
        /// <para>必填：否</para>
        /// <para>示例值：日程主题</para>
        /// </summary>
        [JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// <para>日程描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：desc</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>开始时间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public TimeInfo? StartTime { get; set; }

        /// <summary>
        /// <para>开始时间</para>
        /// </summary>
        public record TimeInfo
        {
            /// <summary>
            /// <para>仅全天日程使用该字段，如2018-09-01。需满足 RFC3339 格式。</para>
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
        /// <para>结束时间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public TimeInfo? EndTime { get; set; }

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
        /// <para>是否是例外日程实例</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_exception")]
        public bool? IsException { get; set; }

        /// <summary>
        /// <para>日程的app_link,跳转到具体的某个日程</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.larkoffice.com/client/calendar/event/detail?calendarId=7039673579105026066&amp;key=aeac9c56-aeb1-4179-a21b-02f278f59048&amp;originalTime=0&amp;startTime=1700496000</para>
        /// </summary>
        [JsonPropertyName("app_link")]
        public string? AppLink { get; set; }

        /// <summary>
        /// <para>日程组织者日历ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：feishu.cn_HF9U2MbibE8PPpjro6xjqa@group.calendar.feishu.cn</para>
        /// </summary>
        [JsonPropertyName("organizer_calendar_id")]
        public string? OrganizerCalendarId { get; set; }

        /// <summary>
        /// <para>视频会议信息，仅当日程至少有一位attendee时生效</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("vchat")]
        public InstanceVchat? Vchat { get; set; }

        /// <summary>
        /// <para>视频会议信息，仅当日程至少有一位attendee时生效</para>
        /// </summary>
        public record InstanceVchat
        {
            /// <summary>
            /// <para>视频会议类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：vc</para>
            /// <para>可选值：<list type="bullet">
            /// <item>vc：飞书视频会议</item>
            /// <item>third_party：第三方链接视频会议</item>
            /// <item>no_meeting：无视频会议</item>
            /// <item>lark_live：Lark直播</item>
            /// <item>unknown：未知类型</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("vc_type")]
            public string? VcType { get; set; }

            /// <summary>
            /// <para>第三方视频会议icon类型</para>
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
            /// <para>示例值：vc.feishu.cn/j/152568231</para>
            /// <para>最大长度：2000</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("meeting_url")]
            public string? MeetingUrl { get; set; }
        }

        /// <summary>
        /// <para>日程公开范围，新建日程默认为Default；仅新建日程时对所有参与人生效，之后修改该属性仅对当前身份生效</para>
        /// <para>必填：否</para>
        /// <para>示例值：default</para>
        /// <para>可选值：<list type="bullet">
        /// <item>default：默认权限，仅向他人显示是否“忙碌”</item>
        /// <item>public：公开，显示日程详情</item>
        /// <item>private：私密，仅自己可见</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("visibility")]
        public string? Visibility { get; set; }

        /// <summary>
        /// <para>参与人权限</para>
        /// <para>必填：否</para>
        /// <para>示例值：none</para>
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
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("color")]
        public int? Color { get; set; }

        /// <summary>
        /// <para>例外日程的原重复日程的event_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：75d28f9b-e35c-4230-8a83-4a661497db54_0</para>
        /// </summary>
        [JsonPropertyName("recurring_event_id")]
        public string? RecurringEventId { get; set; }

        /// <summary>
        /// <para>日程组织者信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("event_organizer")]
        public InstanceEventOrganizer? EventOrganizer { get; set; }

        /// <summary>
        /// <para>日程组织者信息</para>
        /// </summary>
        public record InstanceEventOrganizer
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
        /// <para>日程参与人信息，当前只返回会议室，需要其他类型参与人信息请使用「获取日程参与人列表」</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("attendees")]
        public CalendarEventAttendee[]? Attendees { get; set; }

        /// <summary>
        /// <para>日程参与人信息，当前只返回会议室，需要其他类型参与人信息请使用「获取日程参与人列表」</para>
        /// </summary>
        public record CalendarEventAttendee
        {
            /// <summary>
            /// <para>参与人类型，仅当新建参与人时可设置类型</para>
            /// <para>type为User时，值为open_id/user_id/union_id</para>
            /// <para>type为Chat时，值为open_chat_id</para>
            /// <para>type为Resource时，值为open_room_id</para>
            /// <para>type为ThirdParty时，值为third_party_email；不支持通过API新建该类型参与人</para>
            /// <para>必填：否</para>
            /// <para>示例值：user</para>
            /// <para>可选值：<list type="bullet">
            /// <item>user：用户</item>
            /// <item>chat：群组</item>
            /// <item>resource：会议室</item>
            /// <item>third_party：邮箱</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>参与人ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：user_xxxxxx</para>
            /// </summary>
            [JsonPropertyName("attendee_id")]
            public string? AttendeeId { get; set; }

            /// <summary>
            /// <para>参与人RSVP状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：accept</para>
            /// <para>可选值：<list type="bullet">
            /// <item>needs_action：参与人尚未回复状态，或表示会议室预约中</item>
            /// <item>accept：参与人回复接受，或表示会议室预约成功</item>
            /// <item>tentative：参与人回复待定</item>
            /// <item>decline：参与人回复拒绝，或表示会议室预约失败</item>
            /// <item>removed：参与人或会议室已经从日程中被移除</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("rsvp_status")]
            public string? RsvpStatus { get; set; }

            /// <summary>
            /// <para>参与人是否为「可选参加」，无法编辑群参与人的此字段</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// <para>默认值：false</para>
            /// </summary>
            [JsonPropertyName("is_optional")]
            public bool? IsOptional { get; set; }

            /// <summary>
            /// <para>参与人是否为日程组织者</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_organizer")]
            public bool? IsOrganizer { get; set; }

            /// <summary>
            /// <para>参与人是否为外部参与人；外部参与人不支持编辑</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_external")]
            public bool? IsExternal { get; set; }

            /// <summary>
            /// <para>参与人名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("display_name")]
            public string? DisplayName { get; set; }

            /// <summary>
            /// <para>群中的群成员，当type为Chat时有效；群成员不支持编辑</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("chat_members")]
            public AttendeeChatMember[]? ChatMembers { get; set; }

            /// <summary>
            /// <para>群中的群成员，当type为Chat时有效；群成员不支持编辑</para>
            /// </summary>
            public record AttendeeChatMember
            {
                /// <summary>
                /// <para>参与人RSVP状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：accept</para>
                /// <para>可选值：<list type="bullet">
                /// <item>needs_action：参与人尚未回复状态，或表示会议室预约中</item>
                /// <item>accept：参与人回复接受，或表示会议室预约成功</item>
                /// <item>tentative：参与人回复待定</item>
                /// <item>decline：参与人回复拒绝，或表示会议室预约失败</item>
                /// <item>removed：参与人或会议室已经从日程中被移除</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("rsvp_status")]
                public string? RsvpStatus { get; set; }

                /// <summary>
                /// <para>参与人是否为「可选参加」</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonPropertyName("is_optional")]
                public bool? IsOptional { get; set; }

                /// <summary>
                /// <para>参与人名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：zhangsan</para>
                /// </summary>
                [JsonPropertyName("display_name")]
                public string? DisplayName { get; set; }

                /// <summary>
                /// <para>参与人是否为日程组织者</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_organizer")]
                public bool? IsOrganizer { get; set; }

                /// <summary>
                /// <para>参与人是否为外部参与人</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("is_external")]
                public bool? IsExternal { get; set; }
            }

            /// <summary>
            /// <para>参与人的用户id，依赖于user_id_type返回对应的取值，当is_external为true时，此字段只会返回open_id或者union_id</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_xxxxxxxx</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>chat类型参与人的群组chat_id</para>
            /// <para>必填：否</para>
            /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
            /// </summary>
            [JsonPropertyName("chat_id")]
            public string? ChatId { get; set; }

            /// <summary>
            /// <para>resource类型参与人的会议室room_id</para>
            /// <para>必填：否</para>
            /// <para>示例值：omm_83d09ad4f6896e02029a6a075f71c9d1</para>
            /// </summary>
            [JsonPropertyName("room_id")]
            public string? RoomId { get; set; }

            /// <summary>
            /// <para>third_party类型参与人的邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：test@example.com</para>
            /// </summary>
            [JsonPropertyName("third_party_email")]
            public string? ThirdPartyEmail { get; set; }

            /// <summary>
            /// <para>bot身份操作时，为预定的会议室指定实际预定人</para>
            /// <para>必填：否</para>
            /// <para>示例值：4d7a3c6g</para>
            /// </summary>
            [JsonPropertyName("operate_id")]
            public string? OperateId { get; set; }

            /// <summary>
            /// <para>会议室的个性化配置</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("resource_customization")]
            public CalendarAttendeeResourceCustomization[]? ResourceCustomizations { get; set; }

            /// <summary>
            /// <para>会议室的个性化配置</para>
            /// </summary>
            public record CalendarAttendeeResourceCustomization
            {
                /// <summary>
                /// <para>每个配置的唯一ID</para>
                /// <para>必填：是</para>
                /// <para>示例值：16281481596100</para>
                /// </summary>
                [JsonPropertyName("index_key")]
                public string IndexKey { get; set; } = string.Empty;

                /// <summary>
                /// <para>当type类型为填空时，该参数有返回值</para>
                /// <para>必填：否</para>
                /// <para>示例值：xxx</para>
                /// </summary>
                [JsonPropertyName("input_content")]
                public string? InputContent { get; set; }

                /// <summary>
                /// <para>每个配置的选项</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("options")]
                public CustomizationOption[]? Options { get; set; }

                /// <summary>
                /// <para>每个配置的选项</para>
                /// </summary>
                public record CustomizationOption
                {
                    /// <summary>
                    /// <para>每个选项的唯一ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：16281481596185</para>
                    /// </summary>
                    [JsonPropertyName("option_key")]
                    public string? OptionKey { get; set; }

                    /// <summary>
                    /// <para>当type类型为其它选项时，该参数有返回值</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：xxxx</para>
                    /// </summary>
                    [JsonPropertyName("others_content")]
                    public string? OthersContent { get; set; }
                }
            }

            /// <summary>
            /// <para>会议室审批原因</para>
            /// <para>必填：否</para>
            /// <para>示例值：申请审批原因</para>
            /// <para>最大长度：200</para>
            /// </summary>
            [JsonPropertyName("approval_reason")]
            public string? ApprovalReason { get; set; }
        }
    }
}
