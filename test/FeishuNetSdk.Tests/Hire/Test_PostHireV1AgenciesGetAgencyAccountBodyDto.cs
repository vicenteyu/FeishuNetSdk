namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 查询猎头供应商下猎头列表 请求体
/// <para>接口ID：7413697955198058500</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/agency/get_agency_account</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fagency%2fget_agency_account</para>
/// </summary>
[TestClass]
public class Test_PostHireV1AgenciesGetAgencyAccountBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "supplier_id": "7398623155442682156",
    "status": 1,
    "role": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1AgenciesGetAgencyAccountBodyDto>(json);
        Assert.IsNotNull(result);
    }
}