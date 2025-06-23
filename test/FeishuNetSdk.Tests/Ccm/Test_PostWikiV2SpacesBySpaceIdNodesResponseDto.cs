namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 创建知识空间节点 响应体
/// <para>接口ID：7023947709203873796</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space-node/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-node%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostWikiV2SpacesBySpaceIdNodesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
// 实体节点
{
    "code": 0,
    "msg": "success",
    "data": {
        "node": {
            "space_id": "6946843325487906839",
            "node_token": "wikcnKQ1k3p******8Vabcef",
            "obj_token": "doccnzAaO******8g9Spprd",
            "obj_type": "doc",
            "parent_node_token": "wikcnKQ1k3p******8Vabcef",
            "node_type": "origin",
            "origin_node_token": "",
            "origin_space_id": "",
            "has_child": false,
            "title": ""
        }
    }
}

// 快捷方式节点
{
    "code": 0,
    "msg": "success",
    "data": {
        "node": {
            "space_id": "6946843325487906839",
            "node_token": "wikcnKQ1k3p******8Vabcef",
            "obj_token": "doccnzAaO******8g9Spprd",
            "obj_type": "doc",
            "parent_node_token": "wikcnKQ1k3p******8Vabcef",
            "node_type": "shortcut",
            "origin_node_token": "wikcnKQ1k3p******8Vabcef",
            "origin_space_id": "6946843325487906839",
            "has_child": false,
            "title": ""
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PostWikiV2SpacesBySpaceIdNodesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}