namespace FeishuNetSdk.Tests.Cardkit;

/// <summary>
/// 测试 更新组件属性 请求体
/// <para>接口ID：7397253002364567555</para>
/// <para>文档地址：https://open.feishu.cn/document/cardkit-v1/card-element/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard-element%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCardkitV1CardsByCardIdElementsByElementIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "partial_element": "{\"content\":\"更新后的组件文本\"}",
    "uuid": "191857678434",
    "sequence": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Cardkit.PatchCardkitV1CardsByCardIdElementsByElementIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}