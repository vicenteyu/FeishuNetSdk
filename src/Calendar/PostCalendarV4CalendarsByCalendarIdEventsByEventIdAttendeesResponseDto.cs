using Newtonsoft.Json;
namespace FeishuNetSdk.Calendar;
/// <summary>
/// 添加日程参与人 响应体
/// <para>批量给日程添加参与人。</para>
/// <para>接口ID：6952888507003125787</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-event-attendee/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event-attendee%2fcreate</para>
/// </summary>
public record PostCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesResponseDto
{
    /// <summary>
    /// <para>新增参与人后的日程所有参与人列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("attendees")]
    public CalendarEventAttendee[]? Attendees { get; set; }

    /// <summary>
    /// <para>新增参与人后的日程所有参与人列表</para>
    /// </summary>
    public record CalendarEventAttendee
    {
        /// <summary>
        /// <para>参与人类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：user</para>
        /// <para>可选值：<list type="bullet">
        /// <item>user：用户</item>
        /// <item>chat：群组</item>
        /// <item>resource：会议室</item>
        /// <item>third_party：邮箱</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>参与人ID。参见[参与人ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event-attendee/introduction#4998889c)</para>
        /// <para>必填：否</para>
        /// <para>示例值：user_xxxxxx</para>
        /// </summary>
        [JsonProperty("attendee_id")]
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
        [JsonProperty("rsvp_status")]
        public string? RsvpStatus { get; set; }

        /// <summary>
        /// <para>参与人是否为「可选参加」，无法编辑群参与人的此字段</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// <para>默认值：false</para>
        /// </summary>
        [JsonProperty("is_optional")]
        public bool? IsOptional { get; set; }

        /// <summary>
        /// <para>参与人是否为日程组织者</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("is_organizer")]
        public bool? IsOrganizer { get; set; }

        /// <summary>
        /// <para>参与人是否为外部参与人；外部参与人不支持编辑</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("is_external")]
        public bool? IsExternal { get; set; }

        /// <summary>
        /// <para>参与人名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonProperty("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// <para>群中的群成员，当type为Chat时有效；群成员不支持编辑</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("chat_members")]
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
            [JsonProperty("rsvp_status")]
            public string? RsvpStatus { get; set; }

            /// <summary>
            /// <para>参与人是否为「可选参加」</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// <para>默认值：false</para>
            /// </summary>
            [JsonProperty("is_optional")]
            public bool? IsOptional { get; set; }

            /// <summary>
            /// <para>参与人名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonProperty("display_name")]
            public string? DisplayName { get; set; }

            /// <summary>
            /// <para>参与人是否为日程组织者</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonProperty("is_organizer")]
            public bool? IsOrganizer { get; set; }

            /// <summary>
            /// <para>参与人是否为外部参与人</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonProperty("is_external")]
            public bool? IsExternal { get; set; }
        }

        /// <summary>
        /// <para>参与人的用户id，依赖于user_id_type返回对应的取值，当is_external为true时，此字段只会返回open_id或者union_id，参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_xxxxxxxx</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>chat类型参与人的群组chat_id，参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
        /// <para>必填：否</para>
        /// <para>示例值：oc_xxxxxxxxx</para>
        /// </summary>
        [JsonProperty("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// <para>resource类型参与人的会议室room_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：omm_xxxxxxxx</para>
        /// </summary>
        [JsonProperty("room_id")]
        public string? RoomId { get; set; }

        /// <summary>
        /// <para>third_party类型参与人的邮箱</para>
        /// <para>必填：否</para>
        /// <para>示例值：wangwu@email.com</para>
        /// </summary>
        [JsonProperty("third_party_email")]
        public string? ThirdPartyEmail { get; set; }

        /// <summary>
        /// <para>如果日程是使用应用身份创建的，在添加会议室的时候，用来指定会议室的联系人，在会议室视图展示。参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_xxxxxxxx</para>
        /// </summary>
        [JsonProperty("operate_id")]
        public string? OperateId { get; set; }

        /// <summary>
        /// <para>会议室的个性化配置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("resource_customization")]
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
            [JsonProperty("index_key")]
            public string IndexKey { get; set; } = string.Empty;

            /// <summary>
            /// <para>当type类型为填空时，该参数需要填入</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxx</para>
            /// </summary>
            [JsonProperty("input_content")]
            public string? InputContent { get; set; }

            /// <summary>
            /// <para>每个配置的选项</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("options")]
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
                [JsonProperty("option_key")]
                public string? OptionKey { get; set; }

                /// <summary>
                /// <para>当type类型为其它选项时，该参数需要填入</para>
                /// <para>必填：否</para>
                /// <para>示例值：xxx</para>
                /// </summary>
                [JsonProperty("others_content")]
                public string? OthersContent { get; set; }
            }
        }

        /// <summary>
        /// <para>申请预定审批会议室的原因。</para>
        /// <para>- 仅user_access_token预定审批会议室时，approval_reason字段生效。</para>
        /// <para>-  tenant_access_token预定审批会议室时，会直接失败。</para>
        /// <para>- 对于审批会议室，不传approval_reason会直接预约失败。</para>
        /// <para>必填：否</para>
        /// <para>示例值：申请审批原因</para>
        /// <para>最大长度：200</para>
        /// </summary>
        [JsonProperty("approval_reason")]
        public string? ApprovalReason { get; set; }
    }
}
