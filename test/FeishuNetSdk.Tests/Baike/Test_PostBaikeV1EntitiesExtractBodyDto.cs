namespace FeishuNetSdk.Tests.Baike;

/// <summary>
/// 测试 提取潜在的词条 请求体
/// <para>接口ID：7158733167621242883</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/baike-v1/entity/extract</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbaike-v1%2fentity%2fextract</para>
/// </summary>
[TestClass]
public class Test_PostBaikeV1EntitiesExtractBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "text": "飞书词典是一部高效汇聚企业内各类信息，并可由企业成员参与编辑的在线词典"
}
""";
        var result = Deserialize<FeishuNetSdk.Baike.PostBaikeV1EntitiesExtractBodyDto>(json);
        Assert.IsNotNull(result);
    }
}