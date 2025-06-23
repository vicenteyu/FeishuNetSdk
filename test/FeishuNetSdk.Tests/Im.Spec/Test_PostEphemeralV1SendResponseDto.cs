namespace FeishuNetSdk.Tests.Im.Spec;

/// <summary>
/// 测试 发送仅特定人可见的消息卡片 响应体
/// <para>接口ID：6907569523177078785</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-card/send-message-cards-that-are-only-visible-to-certain-people</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuETOyYjLxkjM24SM5IjN</para>
/// </summary>
[TestClass]
public class Test_PostEphemeralV1SendResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "message_id": "om_fd2057276f16243756ff8eb6fcdabcef"
    },
    "msg": "ok"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.Spec.PostEphemeralV1SendResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}