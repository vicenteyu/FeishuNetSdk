namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 创建知识空间节点副本 请求体
/// <para>接口ID：7109718703113797635</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space-node/copy</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-node%2fcopy</para>
/// </summary>
[TestClass]
public class Test_PostWikiV2SpacesBySpaceIdNodesByNodeTokenCopyBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "target_parent_token": "wikcnKQ1k3p******8Vabce",
    "target_space_id": "6946843325487912356",
    "title": "新标题。"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostWikiV2SpacesBySpaceIdNodesByNodeTokenCopyBodyDto>(json);
        Assert.IsNotNull(result);
    }
}