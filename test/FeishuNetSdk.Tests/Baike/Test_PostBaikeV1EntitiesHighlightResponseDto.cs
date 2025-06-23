namespace FeishuNetSdk.Tests.Baike;

/// <summary>
/// 测试 词条高亮 响应体
/// <para>接口ID：7016992864837369884</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/baike-v1/entity/highlight</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbaike-v1%2fentity%2fhighlight</para>
/// </summary>
[TestClass]
public class Test_PostBaikeV1EntitiesHighlightResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "phrases": [
            {
                "name": "词典",
                "entity_ids": [
                    "enterprise_348***84"
                ],
                "span": {
                    "start": 0,
                    "end": 2
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Baike.PostBaikeV1EntitiesHighlightResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}