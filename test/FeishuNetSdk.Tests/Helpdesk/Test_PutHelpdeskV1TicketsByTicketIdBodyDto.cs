namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 更新工单详情 请求体
/// <para>接口ID：6955768699895824386</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutHelpdeskV1TicketsByTicketIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "status": 1,
    "tag_names": [
        "abc"
    ],
    "comment": "good",
    "customized_fields": [
        {
            "id": "123",
            "value": "value",
            "key_name": "key"
        }
    ],
    "ticket_type": 1,
    "solved": 1,
    "channel": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Helpdesk.PutHelpdeskV1TicketsByTicketIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}