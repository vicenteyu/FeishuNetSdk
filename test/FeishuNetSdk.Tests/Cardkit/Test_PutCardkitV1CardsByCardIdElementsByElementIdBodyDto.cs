namespace FeishuNetSdk.Tests.Cardkit;

/// <summary>
/// 测试 更新组件 请求体
/// <para>接口ID：7397265677100990467</para>
/// <para>文档地址：https://open.feishu.cn/document/cardkit-v1/card-element/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard-element%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutCardkitV1CardsByCardIdElementsByElementIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "uuid": "191857678434",
    "element": "{\"tag\":\"markdown\",\"element_id\":\"md_1\",\"content\":\"示例文本\"}",
    "sequence": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Cardkit.PutCardkitV1CardsByCardIdElementsByElementIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}