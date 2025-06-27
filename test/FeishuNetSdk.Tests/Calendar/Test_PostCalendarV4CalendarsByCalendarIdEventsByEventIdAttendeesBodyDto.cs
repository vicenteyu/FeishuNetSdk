// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 添加日程参与人 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 添加日程参与人 请求体
/// <para>接口ID：6952888507003125787</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-event-attendee/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event-attendee%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "attendees": [
        {
            "type": "user",
            "is_optional": true,
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
            ],
            "approval_reason": "申请原因"
        }
    ],
    "need_notification": false,
    "instance_start_time_admin": "1647320400",
    "is_enable_admin": false,
    "add_operator_to_attendee": false
}
""";
        var result = Deserialize<FeishuNetSdk.Calendar.PostCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}