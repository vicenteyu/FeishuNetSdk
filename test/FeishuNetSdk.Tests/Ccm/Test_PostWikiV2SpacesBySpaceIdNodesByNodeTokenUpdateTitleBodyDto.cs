namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 更新知识空间节点标题 请求体
/// <para>接口ID：7109718703113781251</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space-node/update_title</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-node%2fupdate_title</para>
/// </summary>
[TestClass]
public class Test_PostWikiV2SpacesBySpaceIdNodesByNodeTokenUpdateTitleBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "title": "新标题"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostWikiV2SpacesBySpaceIdNodesByNodeTokenUpdateTitleBodyDto>(json);
        Assert.IsNotNull(result);
    }
}