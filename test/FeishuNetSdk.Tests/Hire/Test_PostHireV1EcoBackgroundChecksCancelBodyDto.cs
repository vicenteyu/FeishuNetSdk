namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 终止背调订单 请求体
/// <para>接口ID：7195815979079598081</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_background_check/cancel</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_background_check%2fcancel</para>
/// </summary>
[TestClass]
public class Test_PostHireV1EcoBackgroundChecksCancelBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "background_check_id": "6931286400470354183"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1EcoBackgroundChecksCancelBodyDto>(json);
        Assert.IsNotNull(result);
    }
}