using Newtonsoft.Json;
namespace FeishuNetSdk.MeetingRoom.Spec;
/// <summary>
/// 查询会议室忙闲 响应体
/// <para>该接口用于获取指定会议室的忙闲日程实例列表。非重复日程只有唯一实例；重复日程可能存在多个实例，依据重复规则和时间范围扩展。建议查询区间为30天内。</para>
/// <para>接口ID：6907569524100956161</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/meeting-room-event/query-room-availability</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDOyUjLygjM14iM4ITN</para>
/// </summary>
public record GetMeetingRoomFreebusyBatchGetResponseDto
{
    /// <summary>
    /// <para>查询会议室忙闲的起始时间，与请求参数完全相同</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("time_min")]
    public string? TimeMin { get; set; }

    /// <summary>
    /// <para>查询会议室忙闲的结束时间，与请求参数完全相同</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("time_max")]
    public string? TimeMax { get; set; }

    /// <summary>
    /// <para>会议室忙闲列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("free_busy")]
    public object? FreeBusy { get; set; }

    /// <summary>
    /// <para>与请求合法参数相同，表示之后是对应会议室的忙闲状态</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("room_id")]
    public string? RoomId { get; set; }

    /// <summary></summary>
    public record Room
    {
        /// <summary>
        /// <para>忙碌起始时间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>忙碌结束时间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>日程 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// <para>日程实例的原始时间, 非重复日程以及重复性日程的原日程为0，重复性日程的例外日程为非0</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("original_time")]
        public string? OriginalTime { get; set; }

        /// <summary>
        /// <para>组织者信息, 私密日程不返回该信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("organizer_info")]
        public string? OrganizerInfo { get; set; }

        /// <summary></summary>
        public record OrganizerInfoSuffix
        {
            /// <summary>
            /// <para>组织者姓名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>组织者 open_id</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("open_id")]
            public string? OpenId { get; set; }
        }
    }
}
