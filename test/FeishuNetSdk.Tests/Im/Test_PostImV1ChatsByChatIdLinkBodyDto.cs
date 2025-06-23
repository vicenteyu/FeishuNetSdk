namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 获取群分享链接 请求体
/// <para>接口ID：7139929321426386972</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/link</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat%2flink</para>
/// </summary>
[TestClass]
public class Test_PostImV1ChatsByChatIdLinkBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "validity_period": "week"
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PostImV1ChatsByChatIdLinkBodyDto>(json);
        Assert.IsNotNull(result);
    }
}