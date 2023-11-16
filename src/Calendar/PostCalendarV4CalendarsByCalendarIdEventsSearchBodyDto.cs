namespace FeishuNetSdk.Calendar;
/// <summary>
/// 搜索日程 请求体
/// <para>该接口用于以用户身份搜索某日历下的相关日程。</para>
/// <para>身份由 Header Authorization 的 Token 类型决定。</para>
/// <para>接口ID：6952888507003109403</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-event/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event%2fsearch</para>
/// </summary>
public record PostCalendarV4CalendarsByCalendarIdEventsSearchBodyDto
{
    /// <summary>
    /// <para>搜索关键字</para>
    /// <para>必填：是</para>
    /// <para>示例值：querywords</para>
    /// <para>最大长度：200</para>
    /// </summary>
    [JsonPropertyName("query")]
    public string Query { get; set; } = string.Empty;

    /// <summary>
    /// <para>搜索过滤器</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("filter")]
    public EventSearchFilter? Filter { get; set; }

    /// <summary>
    /// <para>搜索过滤器</para>
    /// </summary>
    public record EventSearchFilter
    {
        /// <summary>
        /// <para>搜索过滤项，日程搜索区间的开始时间，被搜索日程的事件必须与搜索区间有交集</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public TimeInfo? StartTime { get; set; }

        /// <summary>
        /// <para>搜索过滤项，日程搜索区间的开始时间，被搜索日程的事件必须与搜索区间有交集</para>
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
        /// <para>搜索过滤项，日程搜索区间的结束时间，被搜索日程的事件必须与搜索区间有交集</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public TimeInfo? EndTime { get; set; }

        /// <summary>
        /// <para>搜索过滤项，参与人的用户ID列表，被搜索日程中必须包含至少一个其中的参与人。参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxxxx</para>
        /// </summary>
        [JsonPropertyName("user_ids")]
        public string[]? UserIds { get; set; }

        /// <summary>
        /// <para>搜索过滤项，会议室ID列表，被搜索日程中必须包含至少一个其中的会议室</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxxxx</para>
        /// </summary>
        [JsonPropertyName("room_ids")]
        public string[]? RoomIds { get; set; }

        /// <summary>
        /// <para>搜索过滤项，群ID列表，被搜索日程的参与人中必须包含至少一个其中的群。参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxxxx</para>
        /// </summary>
        [JsonPropertyName("chat_ids")]
        public string[]? ChatIds { get; set; }
    }
}
