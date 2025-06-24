// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchCalendarV4CalendarsByCalendarIdEventsByEventIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新日程 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 更新日程 响应体
/// <para>接口ID：6952888507003043867</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-event/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCalendarV4CalendarsByCalendarIdEventsByEventIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "event": {
            "event_id": "00592a0e-7edf-4678-bc9d-1b77383ef08e_0",
            "organizer_calendar_id": "feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn",
            "summary": "日程标题",
            "description": "日程描述",
            "start_time": {
                "date": "2018-09-01",
                "timestamp": "1602504000",
                "timezone": "Asia/Shanghai"
            },
            "end_time": {
                "date": "2018-09-01",
                "timestamp": "1602504000",
                "timezone": "Asia/Shanghai"
            },
            "vchat": {
                "vc_type": "third_party",
                "icon_type": "vc",
                "description": "发起视频会议",
                "meeting_url": "https://example.com",
                "meeting_settings": {
                    "owner_id": "ou_7d8a6e6df7621556ce0d21922b676706ccs",
                    "join_meeting_permission": "only_organization_employees",
                    "password": "971024",
                    "assign_hosts": [
                        "ou_7d8a6e6df7621556ce0d21922b676706ccs"
                    ],
                    "auto_record": false,
                    "open_lobby": true,
                    "allow_attendees_start": true
                }
            },
            "visibility": "default",
            "attendee_ability": "can_see_others",
            "free_busy_status": "busy",
            "location": {
                "name": "地点名称",
                "address": "地点地址",
                "latitude": 1.100000023841858,
                "longitude": 2.200000047683716
            },
            "color": -1,
            "reminders": [
                {
                    "minutes": 5
                }
            ],
            "recurrence": "FREQ=DAILY;INTERVAL=1",
            "status": "confirmed",
            "is_exception": false,
            "recurring_event_id": "1cd45aaa-fa70-4195-80b7-c93b2e208f45",
            "create_time": "1602504000",
            "schemas": [
                {
                    "ui_name": "ForwardIcon",
                    "ui_status": "hide",
                    "app_link": "https://applink.feishu.cn/client/calendar/event/detail?calendarId=xxxxxx&key=xxxxxx&originalTime=xxxxxx&startTime=xxxxxx"
                }
            ],
            "event_organizer": {
                "user_id": "ou_xxxxxx",
                "display_name": "孙二二"
            },
            "app_link": "https://applink.larkoffice.com/client/calendar/event/detail?calendarId=7039673579105026066&key=aeac9c56-aeb1-4179-a21b-02f278f59048&originalTime=0&startTime=1700496000",
            "attachments": [
                {
                    "file_token": "xAAAAA",
                    "file_size": "2345",
                    "is_deleted": false,
                    "name": "附件.jpeg"
                }
            ],
            "event_check_in": {
                "enable_check_in": true,
                "check_in_start_time": {
                    "time_type": "before_event_start",
                    "duration": 15
                },
                "check_in_end_time": {
                    "time_type": "after_event_end",
                    "duration": 0
                },
                "need_notify_attendees": false
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Calendar.PatchCalendarV4CalendarsByCalendarIdEventsByEventIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}