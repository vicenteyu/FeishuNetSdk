namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 注册内推账户 请求体
/// <para>接口ID：7252281835550932994</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/referral_account/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_account%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ReferralAccountBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "mobile": {
        "code": "86",
        "number": "18900001111"
    },
    "email": "hire@open.com"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1ReferralAccountBodyDto>(json);
        Assert.IsNotNull(result);
    }
}