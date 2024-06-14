namespace FeishuNetSdk.Calendar;
/// <summary>
/// 查询主日历日程忙闲信息 响应体
/// <para>调用该接口查询指定用户的主日历忙闲信息，或者查询指定会议室的忙闲信息。</para>
/// <para>接口ID：6952888507002912795</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2ffreebusy%2flist</para>
/// </summary>
public record PostCalendarV4FreebusyListResponseDto
{
    /// <summary>
    /// <para>在请求的时间区间内的忙碌时间段列表。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("freebusy_list")]
    public Freebusy[]? FreebusyLists { get; set; }

    /// <summary>
    /// <para>在请求的时间区间内的忙碌时间段列表。</para>
    /// </summary>
    public record Freebusy
    {
        /// <summary>
        /// <para>忙闲信息开始时间，[RFC 3339](https://datatracker.ietf.org/doc/html/rfc3339) date_time 格式。</para>
        /// <para>必填：是</para>
        /// <para>示例值：2020-10-28T22:30:00+08:00</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>忙闲信息结束时间，[RFC 3339](https://datatracker.ietf.org/doc/html/rfc3339) date_time 格式。</para>
        /// <para>必填：是</para>
        /// <para>示例值：2020-10-28T22:45:00+08:00</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; } = string.Empty;
    }
}
