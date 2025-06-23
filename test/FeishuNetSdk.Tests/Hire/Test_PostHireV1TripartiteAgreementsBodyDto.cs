namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 创建三方协议 请求体
/// <para>接口ID：7307160083569623043</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/delivery-process-management/tripartite_agreement/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftripartite_agreement%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1TripartiteAgreementsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "application_id": "6930815272790114325",
    "state": 1,
    "create_time": "1698292282660"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1TripartiteAgreementsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}