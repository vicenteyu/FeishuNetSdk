// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CalendarCalendarChangedV4EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>日历变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Calendar.Events;
/// <summary>
/// 日历变更 事件体
/// <para>当用户订阅日历变更事件后，如果用户日历列表内发生了日历变动，则会触发该事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=calendar&amp;version=v4&amp;resource=calendar&amp;event=changed)</para>
/// <para>接口ID：7002206318614609924</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar/events/changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar%2fevents%2fchanged</para>
/// </summary>
public record CalendarCalendarChangedV4EventBodyDto() : EventBodyDto("calendar.calendar.changed_v4")
{
    /// <summary>
    /// <para>需要推送事件的用户列表。关于用户不同 ID 的介绍，参见[用户身份概述](https://open.feishu.cn/document/home/user-identity-introduction/introduction)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_id_list")]
    public UserIdSuffix[]? UserIdList { get; set; }
}
