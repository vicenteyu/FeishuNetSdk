namespace FeishuNetSdk.Tests.Cardkit;

/// <summary>
/// 测试 流式更新文本 请求体
/// <para>接口ID：7397253002364649475</para>
/// <para>文档地址：https://open.feishu.cn/document/cardkit-v1/card-element/content</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard-element%2fcontent</para>
/// </summary>
[TestClass]
public class Test_PutCardkitV1CardsByCardIdElementsByElementIdContentBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "uuid": "191857678434",
    "content": "这是更新后的文本内容。将以打字机式的效果输出",
    "sequence": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Cardkit.PutCardkitV1CardsByCardIdElementsByElementIdContentBodyDto>(json);
        Assert.IsNotNull(result);
    }
}