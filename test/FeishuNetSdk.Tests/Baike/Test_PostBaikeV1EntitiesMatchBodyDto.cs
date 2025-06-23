namespace FeishuNetSdk.Tests.Baike;

/// <summary>
/// 测试 精准搜索词条 请求体
/// <para>接口ID：7016992864837337116</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/baike-v1/entity/match</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbaike-v1%2fentity%2fmatch</para>
/// </summary>
[TestClass]
public class Test_PostBaikeV1EntitiesMatchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "word": "飞书词典"
}
""";
        var result = Deserialize<FeishuNetSdk.Baike.PostBaikeV1EntitiesMatchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}