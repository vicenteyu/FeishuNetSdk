namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 移动知识空间节点 请求体
/// <para>接口ID：7041549010980667394</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space-node/move</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-node%2fmove</para>
/// </summary>
[TestClass]
public class Test_PostWikiV2SpacesBySpaceIdNodesByNodeTokenMoveBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "target_parent_token": "wikbcd6ydSUyOEzbdlt1BfpA5Yc",
    "target_space_id": "7008061636015512345"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostWikiV2SpacesBySpaceIdNodesByNodeTokenMoveBodyDto>(json);
        Assert.IsNotNull(result);
    }
}