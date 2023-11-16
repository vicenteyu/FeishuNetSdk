namespace FeishuNetSdk.MeetingRoom.Spec;
/// <summary>
/// 查询会议室日程主题和会议详情 请求体
/// <para>通过日程的Uid和Original time，查询会议室日程主题。 </para>
/// <para>接口ID：6922096654371831836</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/meeting-room-event/</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIjM5UjLyITO14iMykTN%2f</para>
/// </summary>
public record PostMeetingRoomSummaryBatchGetBodyDto
{
    /// <summary>
    /// <para>需要查询的日程Uid和Original time</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("eventUids")]
    public EventUid[] EventUids { get; set; } = Array.Empty<EventUid>();

    /// <summary></summary>
    public record EventUid
    {
        /// <summary>
        /// <para>日程的唯一id</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; } = string.Empty;

        /// <summary>
        /// <para>日程实例原始时间。非重复性日程和重复性日程，此处传0；重复性日程的例外，传对应的original_time</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("original_time")]
        public int OriginalTime { get; set; }
    }
}
