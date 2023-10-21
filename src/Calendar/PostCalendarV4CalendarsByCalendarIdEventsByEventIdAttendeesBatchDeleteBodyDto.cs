using Newtonsoft.Json;
namespace FeishuNetSdk.Calendar;
/// <summary>
/// 删除日程参与人 请求体
/// <para>批量删除日程的参与人。</para>
/// <para>接口ID：6952888507002830875</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-event-attendee/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event-attendee%2fbatch_delete</para>
/// </summary>
public record PostCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesBatchDeleteBodyDto
{
    /// <summary>
    /// <para>要移除的参与人 ID 列表。参见[参与人ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event-attendee/introduction#4998889c)</para>
    /// <para>必填：否</para>
    /// <para>示例值：["user_xxxxx","chat_xxxxx","resource_xxxxx","third_party_xxxxx"]</para>
    /// </summary>
    [JsonProperty("attendee_ids")]
    public string[]? AttendeeIds { get; set; }

    /// <summary>
    /// <para>需要删除的参与人类型实体ID，作为attendee_ids字段的补充。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("delete_ids")]
    public CalendarEventAttendeeId[]? DeleteIds { get; set; }

    /// <summary>
    /// <para>需要删除的参与人类型实体ID，作为attendee_ids字段的补充。</para>
    /// </summary>
    public record CalendarEventAttendeeId
    {
        /// <summary>
        /// <para>参与人类型，仅当新建参与人时可设置类型</para>
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
        /// <para>参与人的用户id，依赖于user_id_type返回对应的取值，当is_external为true时，此字段只会返回open_id或者union_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_xxxxxxxx</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>chat类型参与人的群组chat_id</para>
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
    }

    /// <summary>
    /// <para>删除日程参与人时是否要给参与人发送bot通知，默认为true</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonProperty("need_notification")]
    public bool? NeedNotification { get; set; }

    /// <summary>
    /// <para>使用管理员身份访问时要修改的实例</para>
    /// <para>必填：否</para>
    /// <para>示例值：1647320400</para>
    /// </summary>
    [JsonProperty("instance_start_time_admin")]
    public string? InstanceStartTimeAdmin { get; set; }

    /// <summary>
    /// <para>是否启用管理员身份(需先在管理后台设置某人为会议室管理员)</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonProperty("is_enable_admin")]
    public bool? IsEnableAdmin { get; set; }
}
