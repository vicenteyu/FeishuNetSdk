namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 查询 Exchange 账户的绑定状态 响应体
/// <para>接口ID：6963176044560744450</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/exchange_binding/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fexchange_binding%2fget</para>
/// </summary>
[TestClass]
public class Test_GetCalendarV4ExchangeBindingsByExchangeBindingIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "admin_account": "email_admin_example@outlook.com",
        "exchange_account": "email_account_example@outlook.com",
        "user_id": "ou_xxxxxxxxxxxxxxxxxx",
        "status": "doing",
        "exchange_binding_id": "ZW1haWxfYWRtaW5fZXhhbXBsZUBvdXRsb29rLmNvbSBlbWFpbF9hY2NvdW50X2V4YW1wbGVAb3V0bG9vay5jb20="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Calendar.GetCalendarV4ExchangeBindingsByExchangeBindingIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}