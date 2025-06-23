namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 创建投递 请求体
/// <para>接口ID：6964286393804816412</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/application/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ApplicationsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "talent_id": "6889020179456689671",
    "job_id": "6889330484657424647",
    "user_id": "6930815272790114324",
    "resume_source_id": "7115289562569591070",
    "application_preferred_city_code_list": [
        "CN_1"
    ],
    "delivery_type": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1ApplicationsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}