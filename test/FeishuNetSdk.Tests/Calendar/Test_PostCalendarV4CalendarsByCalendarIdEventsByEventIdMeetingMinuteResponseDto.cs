namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 创建会议纪要 响应体
/// <para>接口ID：7263360328350760964</para>
/// <para>文档地址：https://open.feishu.cn/document/calendar-v4/calendar-event-meeting_minute/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event-meeting_minute%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4CalendarsByCalendarIdEventsByEventIdMeetingMinuteResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "doc_url": "https://example.cn/xxx"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Calendar.PostCalendarV4CalendarsByCalendarIdEventsByEventIdMeetingMinuteResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}