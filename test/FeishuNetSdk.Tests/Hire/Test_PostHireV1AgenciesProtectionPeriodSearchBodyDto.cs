namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 查询猎头保护期信息 请求体
/// <para>接口ID：7307160083569655811</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/agency/protect_search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fagency%2fprotect_search</para>
/// </summary>
[TestClass]
public class Test_PostHireV1AgenciesProtectionPeriodSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "talent_id": "6930815272790114324"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1AgenciesProtectionPeriodSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}