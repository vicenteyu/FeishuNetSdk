namespace FeishuNetSdk.Tests.Calendar.Events;

/// <summary>
/// 测试 创建 ACL 事件体
/// <para>接口ID：7002206318614577156</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-acl/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-acl%2fevents%2fcreated</para>
/// </summary>
[TestClass]
public class Test_CalendarCalendarAclCreatedV4EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "calendar.calendar.acl.created_v4",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "acl_id": "user_xxxxx",
        "role": "unknown",
        "scope": {
            "type": "user",
            "user_id": {
                "union_id": "on_8ed6aa67826108097d9ee143816345",
                "user_id": "e33ggbyz",
                "open_id": "ou_84aad35d084aa403a838cf73ee18467"
            }
        },
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
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Calendar.Events.CalendarCalendarAclCreatedV4EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}