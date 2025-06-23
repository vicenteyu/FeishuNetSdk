namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 创建日程 请求体
/// <para>接口ID：6990540948577599491</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-event/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4CalendarsByCalendarIdEventsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "summary": "日程标题",
    "description": "日程描述",
    "need_notification": false,
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
    "schemas": [
        {
            "ui_name": "ForwardIcon",
            "ui_status": "hide",
            "app_link": "https://applink.feishu.cn/client/calendar/event/detail?calendarId=xxxxxx&key=xxxxxx&originalTime=xxxxxx&startTime=xxxxxx"
        }
    ],
    "attachments": [
        {
            "file_token": "xAAAAA"
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
""";
        var result = Deserialize<FeishuNetSdk.Calendar.PostCalendarV4CalendarsByCalendarIdEventsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}