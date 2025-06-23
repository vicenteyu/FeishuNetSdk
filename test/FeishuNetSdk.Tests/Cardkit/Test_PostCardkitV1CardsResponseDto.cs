namespace FeishuNetSdk.Tests.Cardkit;

/// <summary>
/// 测试 创建卡片实体 响应体
/// <para>接口ID：7397265677100974083</para>
/// <para>文档地址：https://open.feishu.cn/document/cardkit-v1/card/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCardkitV1CardsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "card_id": "7355372766134157313"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Cardkit.PostCardkitV1CardsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}