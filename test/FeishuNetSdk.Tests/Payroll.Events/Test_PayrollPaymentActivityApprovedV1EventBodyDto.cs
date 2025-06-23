namespace FeishuNetSdk.Tests.Payroll.Events;

/// <summary>
/// 测试 发薪活动封存 事件体
/// <para>接口ID：7411460155089534979</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/payment_activity/events/approved</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fpayment_activity%2fevents%2fapproved</para>
/// </summary>
[TestClass]
public class Test_PayrollPaymentActivityApprovedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "payroll.payment_activity.approved_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "activity_id": "7202076988667019308"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Payroll.Events.PayrollPaymentActivityApprovedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}