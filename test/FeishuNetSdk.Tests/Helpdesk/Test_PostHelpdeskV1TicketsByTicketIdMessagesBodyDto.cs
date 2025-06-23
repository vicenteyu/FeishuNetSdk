namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 发送工单消息 请求体
/// <para>接口ID：6955768699895758850</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket-message/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket-message%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHelpdeskV1TicketsByTicketIdMessagesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "msg_type": "post",
    "content": {
        "post": {
            "zh_cn": {
                "title": "this is title",
                "content": [
                    [
                        {
                            "tag": "text",
                            "un_escape": true,
                            "text": "第一行&nbsp;:"
                        },
                        {
                            "tag": "a",
                            "text": "超链接",
                            "href": "http://www.feishu.cn"
                        }
                    ],
                    [
                        {
                            "tag": "text",
                            "text": "第二行 :"
                        },
                        {
                            "tag": "text",
                            "text": "文本测试"
                        }
                    ]
                ]
            }
        }
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Helpdesk.PostHelpdeskV1TicketsByTicketIdMessagesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}