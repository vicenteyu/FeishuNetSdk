namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 创建知识空间节点 请求体
/// <para>接口ID：7023947709203873796</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space-node/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-node%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostWikiV2SpacesBySpaceIdNodesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
// 创建文档为某文档子节点：
{
    "obj_type": "docx",
    "parent_node_token": "wikcnKQ1k3p******8Vabcef",
    "node_type": "origin"
}

// 创建文档为空间一级节点：
{
    "obj_type": "docx",
    "node_type": "origin"
}

// 创建某一知识空间文档的快捷方式为文档子节点：
{
    "obj_type": "docx",
    "parent_node_token": "wikcnKQ1k3p******8Vabcef",
    "node_type": "shortcut"，
    "origin_node_token": "wikcnKQ1k3p******8Vabcef"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostWikiV2SpacesBySpaceIdNodesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}