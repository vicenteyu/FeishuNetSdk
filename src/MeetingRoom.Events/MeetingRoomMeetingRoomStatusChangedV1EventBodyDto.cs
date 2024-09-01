// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="MeetingRoomMeetingRoomStatusChangedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>会议室状态信息变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.MeetingRoom.Events;
/// <summary>
/// 会议室状态信息变更 事件体
/// <para>当会议室状态信息发生变更时，将会触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=meeting_room&amp;version=v1&amp;resource=meeting_room&amp;event=status_changed)</para>
/// <para>接口ID：7056983069833019396</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/meeting-room-event/event/status_changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmeeting_room-v1%2fmeeting_room%2fevents%2fstatus_changed</para>
/// </summary>
public record MeetingRoomMeetingRoomStatusChangedV1EventBodyDto() : EventBodyDto("meeting_room.meeting_room.status_changed_v1")
{
    /// <summary>
    /// <para>会议室名称。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("room_name")]
    public string? RoomName { get; set; }

    /// <summary>
    /// <para>会议室 ID。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("room_id")]
    public string? RoomId { get; set; }
}
