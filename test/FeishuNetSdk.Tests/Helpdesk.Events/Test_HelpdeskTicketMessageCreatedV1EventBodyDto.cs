namespace FeishuNetSdk.Tests.Helpdesk.Events;

/// <summary>
/// 测试 工单消息事件 事件体
/// <para>接口ID：6955768699895627778</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket-message/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket_message%2fevents%2fcreated</para>
/// </summary>
[TestClass]
public class Test_HelpdeskTicketMessageCreatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "helpdesk.ticket_message.created_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "ticket_message_id": "6949088240624222236",
        "message_id": "om_8baa3656c7b41900d29bf9104bf5310b",
        "msg_type": "text",
        "position": "10",
        "sender_id": {
            "union_id": "on_8ed6aa67826108097d9ee143816345",
            "user_id": "e33ggbyz",
            "open_id": "ou_84aad35d084aa403a838cf73ee18467"
        },
        "sender_type": 1,
        "text": "请问vpn怎么下载",
        "ticket": {
            "ticket_id": "6626871355780366331",
            "comments": {
                "content": "备注内容",
                "created_at": 备注时间,
                "id": 备注id,
                "user_avatar_url": "备注人头像",
                "user_name": "备注人姓名",
                "user_id": 备注人id
            },
            "ticket_type": 1,
            "status": 50,
            "dissatisfaction_reason": {
                "zh_cn": "答案看不懂",
                "en_us": "I don't understand",
                "ja_jp": "回答が複雑すぎる"
            },
            "customized_fields": [
                {
                    "id": "123",
                    "value": "value",
                    "key_name": "key",
                    "display_name": "display name",
                    "position": 1,
                    "required": true,
                    "editable": true
                }
            ],
            "agent_service_duration": 42624.95,
            "agent_first_response_duration": 123869,
            "bot_service_duration": 1,
            "agent_resolution_time": 66,
            "actual_processing_time": 68,
            "agent_entry_time": 1636444596000,
            "agent_first_response_time": 1636444696000,
            "agent_last_response_time": 1636444796000,
            "agent_owner": {
                "id": "ou_37019b7c830210acd88fdce886e25c71",
                "avatar_url": "https://xxxx",
                "name": "abc",
                "email": "xxxx@abc.com",
                "department": "用户部门名称(有权限才展示)",
                "city": "城市",
                "country": "国家"
            }
        },
        "event_id": "118a6492-122d-04ad-4370-010a3bb384d3",
        "chat_id": "6949088236610273307",
        "content": {
            "content": "请问vpn怎么下载",
            "msg_type": "text",
            "image_keys": [
                "xxx","yyy"
            ],
            "image_key": "xxx"
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Helpdesk.Events.HelpdeskTicketMessageCreatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}