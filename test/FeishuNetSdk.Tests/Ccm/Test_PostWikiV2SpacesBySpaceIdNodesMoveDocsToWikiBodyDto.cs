// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostWikiV2SpacesBySpaceIdNodesMoveDocsToWikiBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 移动云空间文档至知识空间 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 移动云空间文档至知识空间 请求体
/// <para>接口ID：7023947709203808260</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/task/move_docs_to_wiki</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-node%2fmove_docs_to_wiki</para>
/// </summary>
[TestClass]
public class Test_PostWikiV2SpacesBySpaceIdNodesMoveDocsToWikiBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "parent_wiki_token": "wikcnKQ1k3p******8Vabce",
    "obj_type": "doc",
    "obj_token": "doccnzAaOD******Wabcdef"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostWikiV2SpacesBySpaceIdNodesMoveDocsToWikiBodyDto>(json);
        Assert.IsNotNull(result);
    }
}