namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 编辑消息 请求体
/// <para>接口ID：7239186075281358852</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutImV1MessagesByMessageIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "msg_type": "text",
    "content": "{\"text\":\"test content\"}"
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PutImV1MessagesByMessageIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}