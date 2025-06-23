namespace FeishuNetSdk.Tests.Payroll;

/// <summary>
/// 测试 封存发薪活动 请求体
/// <para>接口ID：7441890276475142147</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/payment_activity/archive</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fpayment_activity%2farchive</para>
/// </summary>
[TestClass]
public class Test_PostPayrollV1PaymentActivitysArchiveBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "activity_id": "7433255159377444875"
}
""";
        var result = Deserialize<FeishuNetSdk.Payroll.PostPayrollV1PaymentActivitysArchiveBodyDto>(json);
        Assert.IsNotNull(result);
    }
}