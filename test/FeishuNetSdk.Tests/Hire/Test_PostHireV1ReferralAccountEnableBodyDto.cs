namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 启用内推账户 请求体
/// <para>接口ID：7418831232862584833</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/referral_account/enable</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_account%2fenable</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ReferralAccountEnableBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "referral_account_id": "6942778198054125570"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1ReferralAccountEnableBodyDto>(json);
        Assert.IsNotNull(result);
    }
}