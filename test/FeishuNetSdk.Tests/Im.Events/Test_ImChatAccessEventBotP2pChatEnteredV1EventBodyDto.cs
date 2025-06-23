namespace FeishuNetSdk.Tests.Im.Events;

/// <summary>
/// 测试 用户进入与机器人的会话 事件体
/// <para>接口ID：7372115309028524036</para>
/// <para>文档地址：https://open.feishu.cn/document/group/chat-member/event/bot_p2p_chat_entered</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-access_event%2fevents%2fbot_p2p_chat_entered</para>
/// </summary>
[TestClass]
public class Test_ImChatAccessEventBotP2pChatEnteredV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "im.chat.access_event.bot_p2p_chat_entered_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "chat_id": "oc_413871888e0d5492e25b173f0812efb7",
        "operator_id": {
            "union_id": "on_8ed6aa67826108097d9ee143816345",
            "user_id": "e33ggbyz",
            "open_id": "ou_84aad35d084aa403a838cf73ee18467"
        },
        "last_message_id": "om_dc13264520392913993dd051dba21dcf",
        "last_message_create_time": "1615380573411"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Im.Events.ImChatAccessEventBotP2pChatEnteredV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}