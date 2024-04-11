namespace FeishuNetSdk.Calendar;
/// <summary>
/// 获取日程参与群成员列表 响应体
/// <para>调用该接口以当前身份（应用或用户）获取日程的群组类型参与人的群成员列表。</para>
/// <para>接口ID：6952888507002847259</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-event-attendee/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event-attendee-chat_member%2flist</para>
/// </summary>
public record GetCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesByAttendeeIdChatMembersResponseDto
{
    /// <summary>
    /// <para>群组类型参与人的群成员列表。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public CalendarEventAttendeeChatMember[]? Items { get; set; }

    /// <summary>
    /// <para>群组类型参与人的群成员列表。</para>
    /// </summary>
    public record CalendarEventAttendeeChatMember
    {
        /// <summary>
        /// <para>参与人 RSVP 状态，即日程回复状态。</para>
        /// <para>必填：否</para>
        /// <para>示例值：needs_action</para>
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
        /// <para>示例值：Zhang San</para>
        /// </summary>
        [JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// <para>参与人的 open_id。关于用户 ID 可参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_143669c5a53647f00f6c80a0253aa68b</para>
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

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
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：73TyueXXXXX</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
