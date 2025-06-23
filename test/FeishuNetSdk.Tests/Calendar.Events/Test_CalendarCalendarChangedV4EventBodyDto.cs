namespace FeishuNetSdk.Tests.Calendar.Events;

/// <summary>
/// 测试 日历变更 事件体
/// <para>接口ID：7002206318614609924</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar/events/changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar%2fevents%2fchanged</para>
/// </summary>
[TestClass]
public class Test_CalendarCalendarChangedV4EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "calendar.calendar.changed_v4",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "user_id_list": [
            {
                "union_id": "on_xxxxxx",
                "user_id": "exxxxxxz",
                "open_id": "ou_xxxxxx"
            }
        ]
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Calendar.Events.CalendarCalendarChangedV4EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}