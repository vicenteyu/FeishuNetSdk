namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 转发话题 请求体
/// <para>接口ID：7322036039857700865</para>
/// <para>文档地址：https://open.feishu.cn/document/im-v1/message/forward-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fthread%2fforward</para>
/// </summary>
[TestClass]
public class Test_PostImV1ThreadsByThreadIdForwardBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "receive_id": "oc_a0553eda9014c201e6969b478895c230"
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PostImV1ThreadsByThreadIdForwardBodyDto>(json);
        Assert.IsNotNull(result);
    }
}