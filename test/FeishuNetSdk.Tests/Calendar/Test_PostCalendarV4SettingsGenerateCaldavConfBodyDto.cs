namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 生成 CalDAV 配置 请求体
/// <para>接口ID：6952888507002929179</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/setting/generate_caldav_conf</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fsetting%2fgenerate_caldav_conf</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4SettingsGenerateCaldavConfBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "device_name": "iPhone"
}
""";
        var result = Deserialize<FeishuNetSdk.Calendar.PostCalendarV4SettingsGenerateCaldavConfBodyDto>(json);
        Assert.IsNotNull(result);
    }
}