namespace FeishuNetSdk.Tests.Cardkit;

/// <summary>
/// 测试 创建卡片实体 请求体
/// <para>接口ID：7397265677100974083</para>
/// <para>文档地址：https://open.feishu.cn/document/cardkit-v1/card/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCardkitV1CardsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "type": "card_json",
    "data": "{\"schema\":\"2.0\",\"header\":{\"title\":{\"content\":\"卡片标题\",\"tag\":\"plain_text\"}},\"config\":{\"streaming_mode\":true,\"summary\":{\"content\":\"\"}},\"body\":{\"elements\":[{\"tag\":\"markdown\",\"content\":\"卡片内容\",\"element_id\":\"markdown_1\"}]}}"
}
""";
        var result = Deserialize<FeishuNetSdk.Cardkit.PostCardkitV1CardsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}