namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 创建知识空间 响应体
/// <para>接口ID：7023947709203922948</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostWikiV2SpacesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "space": {
            "name": "知识空间",
            "description": "知识空间描述",
            "space_id": "1565676577122621"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PostWikiV2SpacesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}