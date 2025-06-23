namespace FeishuNetSdk.Tests.Baike;

/// <summary>
/// 测试 词条高亮 请求体
/// <para>接口ID：7249689905697210396</para>
/// <para>文档地址：https://open.feishu.cn/document/lingo-v1/entity/highlight</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2flingo-v1%2fentity%2fhighlight</para>
/// </summary>
[TestClass]
public class Test_PostLingoV1EntitiesHighlightBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "text": "词典是飞书提供的一款知识管理工具"
}
""";
        var result = Deserialize<FeishuNetSdk.Baike.PostLingoV1EntitiesHighlightBodyDto>(json);
        Assert.IsNotNull(result);
    }
}