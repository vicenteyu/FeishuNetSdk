// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostMeetingRoomSummaryBatchGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询会议室日程主题和会议详情 请求体</summary>
// ************************************************************************
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
    /// <para>需要查询的日程 Uid 和 Original time 列表。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("EventUids")]
    public EventUid[] EventUids { get; set; } = [];

    /// <summary></summary>
    public record EventUid
    {
        /// <summary>
        /// <para>日程的唯一 ID。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; } = string.Empty;

        /// <summary>
        /// <para>日程实例原始时间。非重复性日程和重复性日程，此处传 0；重复性日程的例外日程，需要传入对应的 original_time 值（时间戳类型）。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("original_time")]
        public long OriginalTime { get; set; }
    }
}
