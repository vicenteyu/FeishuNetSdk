namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 撤销转正 请求体
/// <para>接口ID：7254814386694651906</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/probation/withdraw</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprobation%2fwithdraw</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2ProbationWithdrawBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employment_id": "7140964208476371111"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2ProbationWithdrawBodyDto>(json);
        Assert.IsNotNull(result);
    }
}