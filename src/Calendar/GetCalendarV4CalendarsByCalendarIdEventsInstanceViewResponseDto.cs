// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetCalendarV4CalendarsByCalendarIdEventsInstanceViewResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询日程视图 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Calendar;
/// <summary>
/// 查询日程视图 响应体
/// <para>调用该接口以用户身份查询指定日历下的日程视图。与[获取日程列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/list)不同的是，当前接口会按照重复日程的重复性规则展开成多个日程实例（instance），并根据查询的时间区间返回相应的日程实例信息。</para>
/// <para>接口ID：7322810271218647043</para>
/// <para>文档地址：https://open.feishu.cn/document/calendar-v4/calendar-event/instance_view</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event%2finstance_view</para>
/// </summary>
public record GetCalendarV4CalendarsByCalendarIdEventsInstanceViewResponseDto
{
    /// <summary>
    /// <para>日程 instance 列表。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Instance[]? Items { get; set; }

    /// <summary>
    /// <para>日程 instance 列表。</para>
    /// </summary>
    public record Instance
    {
        /// <summary>
        /// <para>日程 instance ID。后续可通过该 ID 查询、更新或删除日程实例信息。</para>
        /// <para>必填：是</para>
        /// <para>示例值：75d28f9b-e35c-4230-8a83-4a661497db54_1602504000</para>
        /// </summary>
        [JsonPropertyName("event_id")]
        public string EventId { get; set; } = string.Empty;

        /// <summary>
        /// <para>日程主题。</para>
        /// <para>必填：否</para>
        /// <para>示例值：日程主题</para>
        /// </summary>
        [JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// <para>日程描述。</para>
        /// <para>必填：否</para>
        /// <para>示例值：desc</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>日程开始时间。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public TimeInfo? StartTime { get; set; }

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
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public TimeInfo? EndTime { get; set; }

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
        /// <para>日程是否是重复日程的例外日程。了解例外日程，可参见[例外日程](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/introduction#71c5ec78)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_exception")]
        public bool? IsException { get; set; }

        /// <summary>
        /// <para>日程的 app_link，用于跳转到具体的某个日程。</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.larkoffice.com/client/calendar/event/detail?calendarId=7039673579105026066&amp;key=aeac9c56-aeb1-4179-a21b-02f278f59048&amp;originalTime=0&amp;startTime=1700496000</para>
        /// </summary>
        [JsonPropertyName("app_link")]
        public string? AppLink { get; set; }

        /// <summary>
        /// <para>日程组织者的日历 ID。关于日历 ID 可参见[日历 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/introduction)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：feishu.cn_HF9U2MbibE8PPpjro6xjqa@group.calendar.feishu.cn</para>
        /// </summary>
        [JsonPropertyName("organizer_calendar_id")]
        public string? OrganizerCalendarId { get; set; }

        /// <summary>
        /// <para>视频会议信息。仅当日程至少有一位参与人时生效。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("vchat")]
        public InstanceVchat? Vchat { get; set; }

        /// <summary>
        /// <para>视频会议信息。仅当日程至少有一位参与人时生效。</para>
        /// </summary>
        public record InstanceVchat
        {
            /// <summary>
            /// <para>视频会议类型。</para>
            /// <para>必填：否</para>
            /// <para>示例值：vc</para>
            /// <para>可选值：<list type="bullet">
            /// <item>vc：飞书视频会议</item>
            /// <item>third_party：第三方链接视频会议</item>
            /// <item>no_meeting：无视频会议</item>
            /// <item>lark_live：飞书直播</item>
            /// <item>unknown：未知类型</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("vc_type")]
            public string? VcType { get; set; }

            /// <summary>
            /// <para>第三方视频会议 icon 类型。</para>
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
            /// <para>必填：否</para>
            /// <para>示例值：发起视频会议</para>
            /// <para>最大长度：500</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string? Description { get; set; }

            /// <summary>
            /// <para>视频会议 URL。</para>
            /// <para>必填：否</para>
            /// <para>示例值：vc.feishu.cn/j/152568231</para>
            /// <para>最大长度：2000</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("meeting_url")]
            public string? MeetingUrl { get; set; }
        }

        /// <summary>
        /// <para>日程公开范围。仅新建日程时对所有参与人生效，之后修改该属性仅对当前身份生效。</para>
        /// <para>必填：否</para>
        /// <para>示例值：default</para>
        /// <para>可选值：<list type="bullet">
        /// <item>default：默认权限，仅向他人显示是否忙碌</item>
        /// <item>public：公开，显示日程详情</item>
        /// <item>private：私密，仅自己可见</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("visibility")]
        public string? Visibility { get; set; }

        /// <summary>
        /// <para>参与人权限。</para>
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
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("color")]
        public int? Color { get; set; }

        /// <summary>
        /// <para>例外日程对应的原重复日程的 event_id。</para>
        /// <para>必填：否</para>
        /// <para>示例值：75d28f9b-e35c-4230-8a83-4a661497db54_0</para>
        /// </summary>
        [JsonPropertyName("recurring_event_id")]
        public string? RecurringEventId { get; set; }

        /// <summary>
        /// <para>日程组织者信息。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("event_organizer")]
        public InstanceEventOrganizer? EventOrganizer { get; set; }

        /// <summary>
        /// <para>日程组织者信息。</para>
        /// </summary>
        public record InstanceEventOrganizer
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
        /// <para>日程参与人信息，当前只返回会议室，需要其他类型参与人信息请使用[获取日程参与人列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event-attendee/list)接口。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("attendees")]
        public CalendarEventAttendee[]? Attendees { get; set; }

        /// <summary>
        /// <para>日程参与人信息，当前只返回会议室，需要其他类型参与人信息请使用[获取日程参与人列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event-attendee/list)接口。</para>
        /// </summary>
        public record CalendarEventAttendee
        {
            /// <summary>
            /// <para>参与人类型。</para>
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
            /// <para>参与人 ID。日程参与人在当前日程内的唯一标识。</para>
            /// <para>必填：否</para>
            /// <para>示例值：user_xxxxxx</para>
            /// </summary>
            [JsonPropertyName("attendee_id")]
            public string? AttendeeId { get; set; }

            /// <summary>
            /// <para>参与人 RSVP 状态，即日程回复状态。</para>
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
            /// <para>参与人是否为可选参加，该参数值对群组的群成员不生效。</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// <para>默认值：false</para>
            /// </summary>
            [JsonPropertyName("is_optional")]
            public bool? IsOptional { get; set; }

            /// <summary>
            /// <para>参与人是否为日程组织者。</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_organizer")]
            public bool? IsOrganizer { get; set; }

            /// <summary>
            /// <para>参与人是否为外部参与人。外部参与人不支持编辑。</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_external")]
            public bool? IsExternal { get; set; }

            /// <summary>
            /// <para>参与人名称。</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("display_name")]
            public string? DisplayName { get; set; }

            /// <summary>
            /// <para>群中的群成员，当参与人类型（type）为 chat 时有效。群成员不支持编辑。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("chat_members")]
            public AttendeeChatMember[]? ChatMembers { get; set; }

            /// <summary>
            /// <para>群中的群成员，当参与人类型（type）为 chat 时有效。群成员不支持编辑。</para>
            /// </summary>
            public record AttendeeChatMember
            {
                /// <summary>
                /// <para>参与人 RSVP 状态，即日程回复状态。</para>
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
                /// <para>参与人是否为可选参加。</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonPropertyName("is_optional")]
                public bool? IsOptional { get; set; }

                /// <summary>
                /// <para>参与人名称。</para>
                /// <para>必填：否</para>
                /// <para>示例值：zhangsan</para>
                /// </summary>
                [JsonPropertyName("display_name")]
                public string? DisplayName { get; set; }

                /// <summary>
                /// <para>参与人是否为日程组织者。</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_organizer")]
                public bool? IsOrganizer { get; set; }

                /// <summary>
                /// <para>参与人是否为外部参与人。</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("is_external")]
                public bool? IsExternal { get; set; }
            }

            /// <summary>
            /// <para>用户类型参与人的用户 ID，ID 类型与 user_id_type 的值保持一致。关于用户 ID 可参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
            /// <para>**注意**：当 is_external 返回为 true 时，此字段只会返回 open_id 或者 union_id。</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_xxxxxxxx</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>群组类型参与人的群组 ID。关于群组 ID 可参见[群 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)。</para>
            /// <para>必填：否</para>
            /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
            /// </summary>
            [JsonPropertyName("chat_id")]
            public string? ChatId { get; set; }

            /// <summary>
            /// <para>会议室类型参与人的会议室 ID。</para>
            /// <para>必填：否</para>
            /// <para>示例值：omm_83d09ad4f6896e02029a6a075f71c9d1</para>
            /// </summary>
            [JsonPropertyName("room_id")]
            public string? RoomId { get; set; }

            /// <summary>
            /// <para>外部邮箱类型参与人的邮箱地址。</para>
            /// <para>必填：否</para>
            /// <para>示例值：test@example.com</para>
            /// </summary>
            [JsonPropertyName("third_party_email")]
            public string? ThirdPartyEmail { get; set; }

            /// <summary>
            /// <para>如果日程是使用应用身份创建的，在添加会议室时，指定的会议室联系人 ID。ID 类型与 user_id_type 的值保持一致。</para>
            /// <para>必填：否</para>
            /// <para>示例值：4d7a3c6g</para>
            /// </summary>
            [JsonPropertyName("operate_id")]
            public string? OperateId { get; set; }

            /// <summary>
            /// <para>会议室的个性化配置。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("resource_customization")]
            public CalendarAttendeeResourceCustomization[]? ResourceCustomizations { get; set; }

            /// <summary>
            /// <para>会议室的个性化配置。</para>
            /// </summary>
            public record CalendarAttendeeResourceCustomization
            {
                /// <summary>
                /// <para>每个配置的唯一 ID。</para>
                /// <para>必填：是</para>
                /// <para>示例值：16281481596100</para>
                /// </summary>
                [JsonPropertyName("index_key")]
                public string IndexKey { get; set; } = string.Empty;

                /// <summary>
                /// <para>填空类型的取值。</para>
                /// <para>必填：否</para>
                /// <para>示例值：xxx</para>
                /// </summary>
                [JsonPropertyName("input_content")]
                public string? InputContent { get; set; }

                /// <summary>
                /// <para>每个配置的选项。</para>
                /// <para>必填：否</para>
                /// <para>示例值：无</para>
                /// </summary>
                [JsonPropertyName("options")]
                public CustomizationOption[]? Options { get; set; }

                /// <summary>
                /// <para>每个配置的选项。</para>
                /// </summary>
                public record CustomizationOption
                {
                    /// <summary>
                    /// <para>每个选项的唯一 ID。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：16281481596185</para>
                    /// </summary>
                    [JsonPropertyName("option_key")]
                    public string? OptionKey { get; set; }

                    /// <summary>
                    /// <para>其他选项类型的取值。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：xxxx</para>
                    /// </summary>
                    [JsonPropertyName("others_content")]
                    public string? OthersContent { get; set; }
                }
            }

            /// <summary>
            /// <para>会议室的审批原因。</para>
            /// <para>必填：否</para>
            /// <para>示例值：申请审批原因</para>
            /// <para>最大长度：200</para>
            /// </summary>
            [JsonPropertyName("approval_reason")]
            public string? ApprovalReason { get; set; }
        }
    }
}
