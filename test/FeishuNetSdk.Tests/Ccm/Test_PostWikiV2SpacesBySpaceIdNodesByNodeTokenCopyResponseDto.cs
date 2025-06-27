// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostWikiV2SpacesBySpaceIdNodesByNodeTokenCopyResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建知识空间节点副本 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 创建知识空间节点副本 响应体
/// <para>接口ID：7109718703113797635</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space-node/copy</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-node%2fcopy</para>
/// </summary>
[TestClass]
public class Test_PostWikiV2SpacesBySpaceIdNodesByNodeTokenCopyResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "node": {
            "space_id": "6946843325487912356",
            "node_token": "wikcnKQ1k3p******8Vabcef",
            "obj_token": "doccnzAaOD******Wabcdef",
            "obj_type": "doc",
            "parent_node_token": "wikcnKQ1k3p******8Vabcef",
            "node_type": "origin",
            "origin_node_token": "wikcnKQ1k3p******8Vabcef",
            "origin_space_id": "6946843325487912356",
            "has_child": false,
            "title": "标题",
            "obj_create_time": "1642402428",
            "obj_edit_time": "1642402428",
            "node_create_time": "1642402428",
            "creator": "ou_xxxxx",
            "owner": "ou_xxxxx",
            "node_creator": "ou_xxxxx"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PostWikiV2SpacesBySpaceIdNodesByNodeTokenCopyResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}