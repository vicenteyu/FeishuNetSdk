namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 创建投递 响应体
/// <para>接口ID：6964286393804816412</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/application/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ApplicationsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "id": "6920175883425581324"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1ApplicationsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}