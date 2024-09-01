// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="MeetingRoomMeetingRoomDeletedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>会议室删除 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.MeetingRoom.Events;
/// <summary>
/// 会议室删除 事件体
/// <para>会议室被删除将触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=meeting_room&amp;version=v1&amp;resource=meeting_room&amp;event=deleted)</para>
/// <para>接口ID：7056983069833035780</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/event/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmeeting_room-v1%2fmeeting_room%2fevents%2fdeleted</para>
/// </summary>
public record MeetingRoomMeetingRoomDeletedV1EventBodyDto() : EventBodyDto("meeting_room.meeting_room.deleted_v1")
{
    /// <summary>
    /// <para>会议室名称</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("room_name")]
    public string? RoomName { get; set; }

    /// <summary>
    /// <para>会议室 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("room_id")]
    public string? RoomId { get; set; }
}
