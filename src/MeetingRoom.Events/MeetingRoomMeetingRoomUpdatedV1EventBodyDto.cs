// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="MeetingRoomMeetingRoomUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>会议室属性变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.MeetingRoom.Events;
/// <summary>
/// 会议室属性变更 事件体
/// <para>会议室属性更新将触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=meeting_room&amp;version=v1&amp;resource=meeting_room&amp;event=updated)</para>
/// <para>接口ID：7056983069833003012</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/event/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmeeting_room-v1%2fmeeting_room%2fevents%2fupdated</para>
/// </summary>
public record MeetingRoomMeetingRoomUpdatedV1EventBodyDto() : EventBodyDto("meeting_room.meeting_room.updated_v1")
{
    /// <summary>
    /// <para>Meeting room name</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("room_name")]
    public string? RoomName { get; set; }

    /// <summary>
    /// <para>Meeting room ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("room_id")]
    public string? RoomId { get; set; }
}
