namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 创建访问控制 请求体
/// <para>接口ID：6952888507002814491</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-acl/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-acl%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4CalendarsByCalendarIdAclsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "role": "writer",
    "scope": {
        "type": "user",
        "user_id": "ou_xxxxxx"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Calendar.PostCalendarV4CalendarsByCalendarIdAclsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}