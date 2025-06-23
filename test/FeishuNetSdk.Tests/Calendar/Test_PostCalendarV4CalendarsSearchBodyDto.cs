namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 搜索日历 请求体
/// <para>接口ID：6952888507002863643</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4CalendarsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "query": "query words"
}
""";
        var result = Deserialize<FeishuNetSdk.Calendar.PostCalendarV4CalendarsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}