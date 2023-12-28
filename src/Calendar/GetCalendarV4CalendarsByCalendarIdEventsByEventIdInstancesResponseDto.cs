namespace FeishuNetSdk.Calendar;
/// <summary>
/// 获取重复日程实例 响应体
/// <para>该接口用于以当前身份（应用 / 用户）在获取日历上重复性日程的日程实例信息。</para>
/// <para>身份由 Header Authorization 的 Token 类型决定。</para>
/// <para>接口ID：7317471576948850689</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/instances</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event%2finstances</para>
/// </summary>
public record GetCalendarV4CalendarsByCalendarIdEventsByEventIdInstancesResponseDto
{
    /// <summary>
    /// <para>instances实例</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Instance[]? Items { get; set; }

    /// <summary>
    /// <para>instances实例</para>
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
            /// <para>仅全天日程使用该字段，如2018-09-01。需满足 RFC3339 格式。不能与 time_stamp 同时指定</para>
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
            /// <para>示例值：上海</para>
            /// <para>最大长度：512</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>地点地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：徐汇区</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("address")]
            public string? Address { get; set; }

            /// <summary>
            /// <para>地点坐标纬度信息，对于国内的地点，采用GCJ-02标准，海外地点采用WGS84标准</para>
            /// <para>必填：否</para>
            /// <para>示例值：23.4444</para>
            /// </summary>
            [JsonPropertyName("latitude")]
            public float? Latitude { get; set; }

            /// <summary>
            /// <para>地点坐标经度信息，对于国内的地点，采用GCJ-02标准，海外地点采用WGS84标准</para>
            /// <para>必填：否</para>
            /// <para>示例值：23.4444</para>
            /// </summary>
            [JsonPropertyName("longitude")]
            public float? Longitude { get; set; }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
