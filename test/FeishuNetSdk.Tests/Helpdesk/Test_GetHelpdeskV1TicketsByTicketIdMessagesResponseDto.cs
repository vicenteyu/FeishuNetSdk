namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 获取工单消息详情 响应体
/// <para>接口ID：6955768699895840770</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket-message/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket-message%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHelpdeskV1TicketsByTicketIdMessagesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "messages": [
            {
                "id": "6948728206392295444",
                "message_id": "6949088236610273307",
                "message_type": "text",
                "created_at": 1617960686000,
                "content": "{\"content\":\"进入人工服务。 @李宁  为你提供服务，开始聊起来吧~\",\"msg_type\":\"text\"}",
                "user_name": "李宁",
                "avatar_url": "https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/3e73cdce-54b0-4c6a-8226-b131fb2825dj~?image_size=72x72&cut_type=&quality=&format=image&sticker_format=.webp",
                "user_id": "ou_37019b7c830210acd88fdce886e25c71"
            }
        ],
        "total": 100
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Helpdesk.GetHelpdeskV1TicketsByTicketIdMessagesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}