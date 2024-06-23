// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加日程参与人 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Calendar;
/// <summary>
/// 添加日程参与人 响应体
/// <para>调用该接口以当前身份（应用或用户）为指定日程添加一个或多个参与人，参与人类型包括用户、群组、会议室以及邮箱。</para>
/// <para>接口ID：6952888507003125787</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-event-attendee/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event-attendee%2fcreate</para>
/// </summary>
public record PostCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesResponseDto
{
    /// <summary>
    /// <para>添加参与人后，日程参与人列表信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("attendees")]
    public CalendarEventAttendee[]? Attendees { get; set; }

    /// <summary>
    /// <para>添加参与人后，日程参与人列表信息。</para>
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
        /// <item>third_party：外部邮箱</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>参与人 ID。日程参与人在当前日程内的唯一标识，后续可通过该 ID 删除日程参与人，或用于查询群组类型参与人的群成员信息。</para>
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
        /// <para>示例值：true</para>
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
        /// <para>群成员，当参与人类型为群组（type 为 chat）时有效。群成员不支持编辑。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("chat_members")]
        public AttendeeChatMember[]? ChatMembers { get; set; }

        /// <summary>
        /// <para>群成员，当参与人类型为群组（type 为 chat）时有效。群成员不支持编辑。</para>
        /// </summary>
        public record AttendeeChatMember
        {
            /// <summary>
            /// <para>参与人 RSVP 状态。</para>
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
            /// <para>示例值：false</para>
            /// <para>默认值：false</para>
            /// </summary>
            [JsonPropertyName("is_optional")]
            public bool? IsOptional { get; set; }

            /// <summary>
            /// <para>参与人名称。</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
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
        /// <para>示例值：oc_xxxxxxxxx</para>
        /// </summary>
        [JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// <para>会议室类型参与人的会议室 ID。</para>
        /// <para>必填：否</para>
        /// <para>示例值：omm_xxxxxxxx</para>
        /// </summary>
        [JsonPropertyName("room_id")]
        public string? RoomId { get; set; }

        /// <summary>
        /// <para>外部邮箱类型参与人的邮箱地址。</para>
        /// <para>必填：否</para>
        /// <para>示例值：wangwu@email.com</para>
        /// </summary>
        [JsonPropertyName("third_party_email")]
        public string? ThirdPartyEmail { get; set; }

        /// <summary>
        /// <para>如果日程是使用应用身份创建的，在添加会议室时，指定的会议室联系人 ID。ID 类型与 user_id_type 的值保持一致。</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_xxxxxxxx</para>
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
                /// <para>示例值：xxx</para>
                /// </summary>
                [JsonPropertyName("others_content")]
                public string? OthersContent { get; set; }
            }
        }

        /// <summary>
        /// <para>申请预定审批会议室的原因。参数配置说明：</para>
        /// <para>- 仅使用用户身份（user_access_token）预定审批会议室时，该字段生效。</para>
        /// <para>- 对于申请预定审批会议室的场景，不传该值会直接预约失败。</para>
        /// <para>- 如果使用应用身份（tenant_access_token）预定审批会议室，会直接失败。</para>
        /// <para>必填：否</para>
        /// <para>示例值：申请原因</para>
        /// <para>最大长度：200</para>
        /// </summary>
        [JsonPropertyName("approval_reason")]
        public string? ApprovalReason { get; set; }
    }
}
