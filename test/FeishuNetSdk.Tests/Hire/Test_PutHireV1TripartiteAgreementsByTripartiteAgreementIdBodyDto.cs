namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新三方协议 请求体
/// <para>接口ID：7307160083569688579</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/delivery-process-management/tripartite_agreement/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftripartite_agreement%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutHireV1TripartiteAgreementsByTripartiteAgreementIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "state": 1,
    "modify_time": "1698292282661"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PutHireV1TripartiteAgreementsByTripartiteAgreementIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}