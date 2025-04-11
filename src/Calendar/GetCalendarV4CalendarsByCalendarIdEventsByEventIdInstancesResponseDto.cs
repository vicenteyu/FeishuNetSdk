// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetCalendarV4CalendarsByCalendarIdEventsByEventIdInstancesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取重复日程实例 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Calendar;
/// <summary>
/// 获取重复日程实例 响应体
/// <para>调用该接口以当前身份（应用或用户）获取指定日历中的某一重复日程信息。</para>
/// <para>接口ID：7317471576948850689</para>
/// <para>文档地址：https://open.feishu.cn/document/calendar-v4/calendar-event/instances</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event%2finstances</para>
/// </summary>
public record GetCalendarV4CalendarsByCalendarIdEventsByEventIdInstancesResponseDto
{
    /// <summary>
    /// <para>重复日程的日程 instance 列表。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Instance[]? Items { get; set; }

    /// <summary>
    /// <para>重复日程的日程 instance 列表。</para>
    /// </summary>
    public record Instance
    {
        /// <summary>
        /// <para>日程实例 ID。</para>
        /// <para>**注意**：重复日程实例的 ID 与其他日程 ID 不同，其 ID 包含了实例原始时间（Original time），数据格式为秒级时间戳。例如：`2cf525f0-1e67-4b04-ad4d-30b7f003903c_1713168000`，其中 `1713168000` 即为实例原始时间。</para>
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
            /// <para>示例值：上海</para>
            /// <para>最大长度：512</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>地点地址。</para>
            /// <para>必填：否</para>
            /// <para>示例值：徐汇区</para>
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
            /// <para>示例值：23.4444</para>
            /// </summary>
            [JsonPropertyName("latitude")]
            public float? Latitude { get; set; }

            /// <summary>
            /// <para>地点坐标经度信息。</para>
            /// <para>- 对于国内的地点，采用 GCJ-02 标准</para>
            /// <para>- 对于海外的地点，采用 WGS84 标准</para>
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
