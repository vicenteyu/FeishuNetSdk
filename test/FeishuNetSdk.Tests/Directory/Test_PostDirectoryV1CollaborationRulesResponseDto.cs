namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 新增可搜可见规则 响应体
/// <para>接口ID：7442539768884723740</para>
/// <para>文档地址：https://open.feishu.cn/document/trust_party-v1/searchable-and-visible-rules/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fcollaboration_rule%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostDirectoryV1CollaborationRulesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "add_rule_id": "1212121"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Directory.PostDirectoryV1CollaborationRulesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}