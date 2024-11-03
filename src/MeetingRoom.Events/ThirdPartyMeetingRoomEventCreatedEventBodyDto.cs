// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-27
// ************************************************************************
// <copyright file="ThirdPartyMeetingRoomEventCreatedEventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>第三方会议室日程变动 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.MeetingRoom.Events;
/// <summary>
/// 第三方会议室日程变动 事件体
/// <para>当添加了第三方会议室的日程发生变动时（创建/更新/删除）触发此事件，其中更新日程时，仅当更新日程时间后触发此事件。</para>
/// <para>了解事件订阅的使用场景和配置流程，可参见[事件订阅概述](https://open.feishu.cn/document/ukTMukTMukTM/uUTNz4SN1MjL1UzM)。</para>
/// <para>接口ID：7047356600295014404</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/meeting-room-event/event/third-room-event-changes</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmeeting_room-v1%2fevent%2fthird-room-event-changes</para>
/// </summary>
public record ThirdPartyMeetingRoomEventCreatedEventBodyDto() : EventBodyDto("third_party_meeting_room_event_created")
{
    /// <summary>
    /// <para>应用 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("app_id")]
    public string? AppId { get; set; }

    /// <summary>
    /// <para>租户 Key</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tenant_key")]
    public string? TenantKey { get; set; }

    /// <summary>
    /// <para>事件类型</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// <para>事件发生时间</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("event_time")]
    public string? EventTime { get; set; }

    /// <summary>
    /// <para>日程的唯一标识</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>
    /// <para>重复日程的例外日程的唯一标识，时间戳格式。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("original_time")]
    public int? OriginalTime { get; set; }

    /// <summary>
    /// <para>日程 ID，格式为 `{Uid}_{Original time}`，`{Uid}` 是日程的唯一标识，`{Original time}` 是日程实例原始时间，非重复性日程和重复性日程取值为 0，重复性日程的例外日程取值为具体时间戳。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("event_id")]
    public string? EventId { get; set; }

    /// <summary>
    /// <para>日程开始时间</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("start")]
    public EventTimeSuffix? Start { get; set; }

    /// <summary>
    /// <para>日程结束时间</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("end")]
    public EventTimeSuffix? End { get; set; }

    /// <summary>
    /// 时间戳
    /// </summary>
    public record EventTimeSuffix
    {
        /// <summary>
        /// <para>时间戳</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("time_stamp")]
        public string? TimeStamp { get; set; }
    }

    /// <summary>
    /// <para>日程关联的会议室</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("meeting_rooms")]
    public string[]? MeetingRooms { get; set; }

    /// <summary>
    /// <para>日程的组织者</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("organizer")]
    public UserIdSuffix? Organizer { get; set; }
}
