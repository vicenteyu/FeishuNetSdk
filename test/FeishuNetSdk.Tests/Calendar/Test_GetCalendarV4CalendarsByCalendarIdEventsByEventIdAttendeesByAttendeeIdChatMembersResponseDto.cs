// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesByAttendeeIdChatMembersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取日程参与群成员列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 获取日程参与群成员列表 响应体
/// <para>接口ID：6952888507002847259</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-event-attendee/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event-attendee-chat_member%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesByAttendeeIdChatMembersResponseDto : TestBase
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
                "rsvp_status": "needs_action",
                "is_optional": true,
                "display_name": "Zhang San",
                "open_id": "ou_143669c5a53647f00f6c80a0253aa68b",
                "is_organizer": true,
                "is_external": false
            }
        ],
        "has_more": false,
        "page_token": "73TyueXXXXX"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Calendar.GetCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesByAttendeeIdChatMembersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}