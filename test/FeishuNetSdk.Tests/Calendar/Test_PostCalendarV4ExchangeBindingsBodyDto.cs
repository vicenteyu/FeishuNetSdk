namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 将 Exchange 账户绑定到飞书账户 请求体
/// <para>接口ID：6963176044560728066</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/exchange_binding/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fexchange_binding%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4ExchangeBindingsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "admin_account": "email_admin_example@outlook.com",
    "exchange_account": "email_account_example@outlook.com",
    "user_id": "ou_xxxxxxxxxxxxxxxxxx"
}
""";
        var result = Deserialize<FeishuNetSdk.Calendar.PostCalendarV4ExchangeBindingsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}