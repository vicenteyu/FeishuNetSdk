namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 创建服务台对话 响应体
/// <para>接口ID：6955768699895726082</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket/start_service</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket%2fstart_service</para>
/// </summary>
[TestClass]
public class Test_PostHelpdeskV1StartServiceResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "chat_id": "创建的 chat-id",
        "ticket_id": "7474857595946745884"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Helpdesk.PostHelpdeskV1StartServiceResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}