namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 创建共享日历 请求体
/// <para>接口ID：6952888507003076635</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4CalendarsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "summary": "测试日历",
    "description": "使用开放接口创建日历",
    "permissions": "private",
    "color": -1,
    "summary_alias": "日历备注名"
}
""";
        var result = Deserialize<FeishuNetSdk.Calendar.PostCalendarV4CalendarsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}