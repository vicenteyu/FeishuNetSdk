namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 搜索日程 请求体
/// <para>接口ID：6952888507003109403</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-event/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4CalendarsByCalendarIdEventsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "query": "query words",
    "filter": {
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
        "user_ids": [
            "ou_e051986ab19f80d16b7b8d74f3f1235"
        ],
        "room_ids": [
            "omm_eada1d61a550955240c28757e7dec3af"
        ],
        "chat_ids": [
            "oc_a0553eda9014c201e6969b478895c230"
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Calendar.PostCalendarV4CalendarsByCalendarIdEventsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}