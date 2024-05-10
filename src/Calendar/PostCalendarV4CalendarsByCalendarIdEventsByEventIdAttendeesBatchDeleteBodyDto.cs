namespace FeishuNetSdk.Calendar;
/// <summary>
/// 删除日程参与人 请求体
/// <para>调用该接口以当前身份（应用或用户）删除指定日程的一个或多个参与人。</para>
/// <para>接口ID：6952888507002830875</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-event-attendee/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event-attendee%2fbatch_delete</para>
/// </summary>
public record PostCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesBatchDeleteBodyDto
{
    /// <summary>
    /// <para>需要删除的参与人 ID 列表。</para>
    /// <para>添加日程参与人时，会返回参与人 ID（attendee_id），你也可以调用[获取日程参与人列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event-attendee/list)接口，查询指定日程的参与人 ID。</para>
    /// <para>- 一次最多删除500个参与人（与delete_ids一起计算）</para>
    /// <para>必填：否</para>
    /// <para>示例值：["user_xxxxx", "chat_xxxxx", "resource_xxxxx", "third_party_xxxxx"]</para>
    /// </summary>
    [JsonPropertyName("attendee_ids")]
    public string[]? AttendeeIds { get; set; }

    /// <summary>
    /// <para>参与人类型对应的 ID，该 ID 是 attendee_ids 字段的补充字段。</para>
    /// <para>- 一次最多删除500个参与人（与attendee_ids一起计算）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("delete_ids")]
    public CalendarEventAttendeeId[]? DeleteIds { get; set; }

    /// <summary>
    /// <para>参与人类型对应的 ID，该 ID 是 attendee_ids 字段的补充字段。</para>
    /// <para>- 一次最多删除500个参与人（与attendee_ids一起计算）</para>
    /// </summary>
    public record CalendarEventAttendeeId
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
        /// <para>用户 ID。当选择用户类型参与人（type 取值为 user）时，需要传入该参数。传入的用户 ID 类型需要和 user_id_type 的值保持一致。</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_xxxxxxxx</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>群组 ID。当选择群组类型参与人（type 取值为 chat）时，需要传入该参数。</para>
        /// <para>必填：否</para>
        /// <para>示例值：oc_xxxxxxxxx</para>
        /// </summary>
        [JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// <para>会议室 ID。当选择会议室类型参与人（type 取值为 resource）时，需要传入该参数。</para>
        /// <para>必填：否</para>
        /// <para>示例值：omm_xxxxxxxx</para>
        /// </summary>
        [JsonPropertyName("room_id")]
        public string? RoomId { get; set; }

        /// <summary>
        /// <para>邮箱地址。当选择外部邮箱类型参与人（type 取值为 third_party）时，需要传入该参数。</para>
        /// <para>必填：否</para>
        /// <para>示例值：wangwu@email.com</para>
        /// </summary>
        [JsonPropertyName("third_party_email")]
        public string? ThirdPartyEmail { get; set; }
    }

    /// <summary>
    /// <para>删除日程参与人时，是否向参与人发送 Bot 通知。</para>
    /// <para>**可选值有**：</para>
    /// <para>- true（默认值）：发送</para>
    /// <para>- false：不发送</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("need_notification")]
    public bool? NeedNotification { get; set; }

    /// <summary>
    /// <para>使用管理员身份访问时，要修改的实例（仅用于重复日程修改其中的一个实例，非重复日程无需填此字段）。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1647320400</para>
    /// </summary>
    [JsonPropertyName("instance_start_time_admin")]
    public string? InstanceStartTimeAdmin { get; set; }

    /// <summary>
    /// <para>是否启用会议室管理员身份（需先在管理后台设置某人为会议室管理员）。</para>
    /// <para>**可选值有**：</para>
    /// <para>- true：启用</para>
    /// <para>- false（默认值）：不启用</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("is_enable_admin")]
    public bool? IsEnableAdmin { get; set; }
}
