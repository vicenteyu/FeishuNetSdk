// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-05-31
// ************************************************************************
// <copyright file="GetMeetingRoomFreebusyBatchGetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询会议室忙闲 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.MeetingRoom.Spec;
/// <summary>
/// 查询会议室忙闲 响应体
/// <para>调用该接口获取指定会议室的忙碌、空闲日程信息。</para>
/// <para>查询结果中：</para>
/// <para>- 非重复日程只有唯一的实例信息。</para>
/// <para>- 重复日程可能存在多个实例信息，根据日程重复规则和时间范围进行扩展。建议查询的时间区间为 30 天内。</para>
/// <para>接口ID：6907569524100956161</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/meeting-room-event/query-room-availability</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDOyUjLygjM14iM4ITN</para>
/// </summary>
public record GetMeetingRoomFreebusyBatchGetResponseDto
{
    /// <summary>
    /// <para>查询会议室忙闲的起始时间。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("time_min")]
    public string? TimeMin { get; set; }

    /// <summary>
    /// <para>查询会议室忙闲的结束时间。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("time_max")]
    public string? TimeMax { get; set; }

    /// <summary>
    /// <para>会议室忙闲信息列表。</para>
    /// <para>必填：否</para>
    /// <para>键名为 会议室 ID</para>
    /// </summary>
    [JsonPropertyName("free_busy")]
    public Dictionary<string, Room[]>? FreeBusy { get; set; }

    /// <summary></summary>
    public record Room
    {
        /// <summary>
        /// <para>忙碌起始时间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>忙碌结束时间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>日程的唯一 ID。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// <para>日程实例的原始时间。非重复性日程和重复性日程，此处为 0；重复性日程的例外日程，此处为对应的 original_time 值（时间戳类型）。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("original_time")]
        public string? OriginalTime { get; set; }

        /// <summary>
        /// <para>日程组织者信息。私密日程不会返回该信息。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("organizer_info")]
        public OrganizerInfoSuffix? OrganizerInfo { get; set; }

        /// <summary></summary>
        public record OrganizerInfoSuffix
        {
            /// <summary>
            /// <para>组织者姓名。使用应用身份创建的日程不会返回该信息。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>组织者 open_id</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("open_id")]
            public string? OpenId { get; set; }
        }
    }
}
