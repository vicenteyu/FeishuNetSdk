namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 获取重复日程实例 响应体
/// <para>接口ID：7317471576948850689</para>
/// <para>文档地址：https://open.feishu.cn/document/calendar-v4/calendar-event/instances</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event%2finstances</para>
/// </summary>
[TestClass]
public class Test_GetCalendarV4CalendarsByCalendarIdEventsByEventIdInstancesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "event_id": "75d28f9b-e35c-4230-8a83-4a661497db54_1602504000",
                "summary": "日程主题",
                "description": "desc",
                "start_time": {
                    "date": "2018-09-01",
                    "timestamp": "1602504000",
                    "timezone": "Asia/Shanghai"
                },
                "end_time": {
                    "date": "2018-09-01",
                    "timestamp": "1602504400",
                    "timezone": "Asia/Shanghai"
                },
                "status": "confirmed",
                "is_exception": false,
                "app_link": "https://applink.larkoffice.com/client/calendar/event/detail?calendarId=7039673579105026066&key=aeac9c56-aeb1-4179-a21b-02f278f59048&originalTime=0&startTime=1700496000",
                "location": {
                    "name": "上海",
                    "address": "徐汇区",
                    "latitude": 23.4444,
                    "longitude": 23.4444
                }
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Calendar.GetCalendarV4CalendarsByCalendarIdEventsByEventIdInstancesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}