namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 添加消息表情回复 请求体
/// <para>接口ID：6990603997012312066</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-reaction/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage-reaction%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostImV1MessagesByMessageIdReactionsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "reaction_type": {
        "emoji_type": "SMILE"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PostImV1MessagesByMessageIdReactionsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}