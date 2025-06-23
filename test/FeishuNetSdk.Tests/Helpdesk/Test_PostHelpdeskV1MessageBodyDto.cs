namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 服务台机器人向工单绑定的群内发送消息 请求体
/// <para>接口ID：7036209421748764675</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket-message/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fbot-message%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHelpdeskV1MessageBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "msg_type": "post",
    "content": "{\"post\":{\"zh_cn\":{\"title\":\"some title\",\"content\":[[{\"tag\":\"text\",\"text\":\"some content\"}]]}}}",
    "receiver_id": "ou_7346484524",
    "receive_type": "chat"
}
""";
        var result = Deserialize<FeishuNetSdk.Helpdesk.PostHelpdeskV1MessageBodyDto>(json);
        Assert.IsNotNull(result);
    }
}