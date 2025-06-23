namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 查询日程视图 响应体
/// <para>接口ID：7322810271218647043</para>
/// <para>文档地址：https://open.feishu.cn/document/calendar-v4/calendar-event/instance_view</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event%2finstance_view</para>
/// </summary>
[TestClass]
public class Test_GetCalendarV4CalendarsByCalendarIdEventsInstanceViewResponseDto : TestBase
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
                "organizer_calendar_id": "feishu.cn_HF9U2MbibE8PPpjro6xjqa@group.calendar.feishu.cn",
                "vchat": {
                    "vc_type": "vc",
                    "icon_type": "vc",
                    "description": "发起视频会议",
                    "meeting_url": "vc.feishu.cn/j/152568231"
                },
                "visibility": "default",
                "attendee_ability": "none",
                "free_busy_status": "busy",
                "location": {
                    "name": "地点名称",
                    "address": "地点地址",
                    "latitude": 1.100000023841858,
                    "longitude": 2.200000047683716
                },
                "color": 0,
                "recurring_event_id": "75d28f9b-e35c-4230-8a83-4a661497db54_0",
                "event_organizer": {
                    "user_id": "ou_xxxxxx",
                    "display_name": "孙二二"
                },
                "attendees": [
                    {
                        "type": "user",
                        "attendee_id": "user_xxxxxx",
                        "rsvp_status": "accept",
                        "is_optional": false,
                        "is_organizer": true,
                        "is_external": false,
                        "display_name": "张三",
                        "chat_members": [
                            {
                                "rsvp_status": "accept",
                                "is_optional": true,
                                "display_name": "zhangsan",
                                "is_organizer": true,
                                "is_external": false
                            }
                        ],
                        "user_id": "ou_xxxxxxxx",
                        "chat_id": "oc_a0553eda9014c201e6969b478895c230",
                        "room_id": "omm_83d09ad4f6896e02029a6a075f71c9d1",
                        "third_party_email": "test@example.com",
                        "operate_id": "4d7a3c6g",
                        "resource_customization": [
                            {
                                "index_key": "16281481596100",
                                "input_content": "xxx",
                                "options": [
                                    {
                                        "option_key": "16281481596185",
                                        "others_content": "xxxx"
                                    }
                                ]
                            }
                        ],
                        "approval_reason": "申请审批原因"
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Calendar.GetCalendarV4CalendarsByCalendarIdEventsInstanceViewResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}