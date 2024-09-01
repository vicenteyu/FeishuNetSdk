// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CalendarCalendarEventChangedV4EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>日程变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Calendar.Events;
/// <summary>
/// 日程变更 事件体
/// <para>当用户订阅日程变更事件后，被订阅的日历下有日程发生变更时，将会触发该事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=calendar&amp;version=v4&amp;resource=calendar.event&amp;event=changed)</para>
/// <para>接口ID：7002206318614626308</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-event/events/changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event%2fevents%2fchanged</para>
/// </summary>
public record CalendarCalendarEventChangedV4EventBodyDto() : EventBodyDto("calendar.calendar.event.changed_v4")
{
    /// <summary>
    /// <para>日程所在的日历 ID。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("calendar_id")]
    public string? CalendarId { get; set; }

    /// <summary>
    /// <para>需要推送事件的用户列表。关于用户不同 ID 的介绍，参见[用户身份概述](https://open.feishu.cn/document/home/user-identity-introduction/introduction).</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_id_list")]
    public UserIdSuffix[]? UserIdList { get; set; }

    /// <summary>
    /// <para>发生变更的日程 ID。</para>
    /// <para>**注意**：该参数在灰度测试阶段，如需使用请咨询你的商务对接人或者[技术支持](https://applink.feishu.cn/TLJpeNdW)。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("calendar_event_id")]
    public string? CalendarEventId { get; set; }

    /// <summary>
    /// <para>日程变更类型。</para>
    /// <para>**可能值有：**</para>
    /// <para>- create：日程在日历上被创建。新建日程或者作为参与人被邀请进日程，都属于 create 类型。</para>
    /// <para>- update：日程发生了变更。</para>
    /// <para>- delete：日程从日历上消失。删除日程或者作为参与人被移出了日程，都属于 delete 类型。</para>
    /// <para>- rsvp：用户类型的参与人主动对日程进行回复（包括回复接收、拒绝、待定）。</para>
    /// <para>**事件聚合策略**：</para>
    /// <para>在实际推送事件时，同一个日历（calendarID）、同一个日程（eventID）的变更事件，会以 3 秒为一个窗口进行聚合推送事件。在 3 秒内：</para>
    /// <para>- 日程进行了 create + delete 变更时，不推送事件。</para>
    /// <para>- 日程进行了 create + update 变更时，推送 create 变更类型的事件。</para>
    /// <para>- 日程进行了 delete + update 变更时，推送 delete 变更类型的事件。</para>
    /// <para>- 日程进行了 update + update 变更时，只推送最后一次 update 变更类型的事件。</para>
    /// <para>- 有多次 rsvp 变更时，只推送最后一次 rsvp 变更类型的事件。</para>
    /// <para>**注意**：该参数在灰度测试阶段，如需使用请咨询你的商务对接人或[技术支持](https://applink.feishu.cn/TLJpeNdW)。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("change_type")]
    public string? ChangeType { get; set; }

    /// <summary>
    /// <para>RSVP 变更详情，即日程参与人的回复状态。</para>
    /// <para>**注意**：</para>
    /// <para>- 该参数仅包含用户类型参与人的变更详情。</para>
    /// <para>- 该参数在灰度测试阶段，如需使用请咨询你的商务对接人或[技术支持](https://applink.feishu.cn/TLJpeNdW)。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("rsvp_infos")]
    public OpenEventRsvpInfo[]? RsvpInfos { get; set; }

    /// <summary></summary>
    public record OpenEventRsvpInfo
    {
        /// <summary>
        /// <para>用户类型参与人的用户 ID。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("from_user_id")]
        public UserIdSuffix? FromUserId { get; set; }

        /// <summary>
        /// <para>RSVP 操作状态。</para>
        /// <para>**可能值有：**</para>
        /// <para>- accept：接收</para>
        /// <para>- decline：拒绝</para>
        /// <para>- tentative：待定</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("rsvp_status")]
        public string? RsvpStatus { get; set; }
    }
}
