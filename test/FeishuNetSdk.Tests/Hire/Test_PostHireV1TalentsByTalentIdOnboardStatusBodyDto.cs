namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新人才在职状态 请求体
/// <para>接口ID：7236665938900877340</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/onboard_status</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fonboard_status</para>
/// </summary>
[TestClass]
public class Test_PostHireV1TalentsByTalentIdOnboardStatusBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "operation": 1,
    "onboard_time": "1676548784889",
    "overboard_time": "1676548784890"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1TalentsByTalentIdOnboardStatusBodyDto>(json);
        Assert.IsNotNull(result);
    }
}