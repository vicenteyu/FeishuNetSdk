namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 订阅服务台事件 请求体
/// <para>接口ID：6955768699895873538</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/event/subscribe</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fevent%2fsubscribe</para>
/// </summary>
[TestClass]
public class Test_PostHelpdeskV1EventsSubscribeBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "events": [
        {
            "type": "helpdesk.ticket_message",
            "subtype": "ticket_message.created_v1"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Helpdesk.PostHelpdeskV1EventsSubscribeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}