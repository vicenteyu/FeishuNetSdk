namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 移动云空间文档至知识空间 响应体
/// <para>接口ID：7023947709203808260</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/task/move_docs_to_wiki</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-node%2fmove_docs_to_wiki</para>
/// </summary>
[TestClass]
public class Test_PostWikiV2SpacesBySpaceIdNodesMoveDocsToWikiResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "wiki_token": "wikbcLZuhp4r9QuJumHzVabcdef",
        "task_id": "7037044037068177428-075c9481e6a0007c1df689dfbe5b55a08b6b06f7",
        "applied": true
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PostWikiV2SpacesBySpaceIdNodesMoveDocsToWikiResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}