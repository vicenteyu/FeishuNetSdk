namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 查询地点列表 请求体
/// <para>接口ID：7385067676815949828</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/recruitment-related-configuration/location/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2flocation%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostHireV1LocationsQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code_list": [
        "CN_1"
    ],
    "location_type": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1LocationsQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}