// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCalendarV4CalendarsByCalendarIdEventsByEventIdMeetingChatResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建会议群 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 创建会议群 响应体
/// <para>接口ID：7263360328350744580</para>
/// <para>文档地址：https://open.feishu.cn/document/calendar-v4/calendar-event-meeting_chat/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event-meeting_chat%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4CalendarsByCalendarIdEventsByEventIdMeetingChatResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "meeting_chat_id": "oc_xxx",
        "applink": "https://example.cn?openChatId=oc_xxx"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Calendar.PostCalendarV4CalendarsByCalendarIdEventsByEventIdMeetingChatResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}