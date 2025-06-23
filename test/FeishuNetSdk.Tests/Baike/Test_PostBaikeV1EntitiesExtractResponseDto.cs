namespace FeishuNetSdk.Tests.Baike;

/// <summary>
/// 测试 提取潜在的词条 响应体
/// <para>接口ID：7158733167621242883</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/baike-v1/entity/extract</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbaike-v1%2fentity%2fextract</para>
/// </summary>
[TestClass]
public class Test_PostBaikeV1EntitiesExtractResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "entity_word": [
            {
                "name": "飞书词典",
                "aliases": [
                    "Lingo"
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Baike.PostBaikeV1EntitiesExtractResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}