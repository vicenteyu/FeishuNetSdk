namespace FeishuNetSdk.Tests.Cardkit;

/// <summary>
/// 测试 全量更新卡片实体 请求体
/// <para>接口ID：7397253002364682243</para>
/// <para>文档地址：https://open.feishu.cn/document/cardkit-v1/card/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutCardkitV1CardsByCardIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "card": {
        "type": "card_json",
        "data": "{\"schema\":\"2.0\",\"header\":{\"title\":{\"content\":\"卡片标题\",\"tag\":\"plain_text\"}},\"body\":{\"elements\":[{\"tag\":\"markdown\",\"content\":\"卡片内容\"}]}}"
    },
    "uuid": "191857678434",
    "sequence": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Cardkit.PutCardkitV1CardsByCardIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}