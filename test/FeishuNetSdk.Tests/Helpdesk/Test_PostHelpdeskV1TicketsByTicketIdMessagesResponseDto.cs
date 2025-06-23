namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 发送工单消息 响应体
/// <para>接口ID：6955768699895758850</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket-message/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket-message%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHelpdeskV1TicketsByTicketIdMessagesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "message_id": "om_8baa3656c7b41900d29bf9104bf5310b"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Helpdesk.PostHelpdeskV1TicketsByTicketIdMessagesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}