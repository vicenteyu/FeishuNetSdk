namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 获取日程参与人列表 响应体
/// <para>接口ID：6952888507002896411</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-event-attendee/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event-attendee%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesResponseDto : TestBase
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
                "type": "user",
                "attendee_id": "user_xxxxxx",
                "rsvp_status": "needs_action",
                "is_optional": true,
                "is_organizer": true,
                "is_external": false,
                "display_name": "Zhang San",
                "chat_members": [
                    {
                        "rsvp_status": "needs_action",
                        "is_optional": true,
                        "display_name": "Group",
                        "is_organizer": false,
                        "is_external": false
                    }
                ],
                "user_id": "ou_xxxxxxxx",
                "chat_id": "oc_xxxxxxxxx",
                "room_id": "omm_xxxxxxxx",
                "third_party_email": "wangwu@email.com",
                "operate_id": "ou_xxxxxxxx",
                "resource_customization": [
                    {
                        "index_key": "16281481596100",
                        "input_content": "xxx",
                        "options": [
                            {
                                "option_key": "16281481596185",
                                "others_content": "xxx"
                            }
                        ]
                    }
                ]
            }
        ],
        "has_more": true,
        "page_token": "38RTjheyXXXX"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Calendar.GetCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}