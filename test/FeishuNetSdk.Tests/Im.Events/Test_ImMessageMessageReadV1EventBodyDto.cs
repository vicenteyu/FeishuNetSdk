namespace FeishuNetSdk.Tests.Im.Events;

/// <summary>
/// 测试 消息已读 事件体
/// <para>接口ID：6946222929790533660</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/events/message_read</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fevents%2fmessage_read</para>
/// </summary>
[TestClass]
public class Test_ImMessageMessageReadV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "im.message.message_read_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "reader": {
            "reader_id": {
                "union_id": "on_8ed6aa67826108097d9ee143816345",
                "user_id": "e33ggbyz",
                "open_id": "ou_84aad35d084aa403a838cf73ee18467"
            },
            "read_time": "1609484183000",
            "tenant_key": "736588c9260f175e"
        },
        "message_id_list": [
            "om_dc13264520392913993dd051dba21dcf"
        ]
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Im.Events.ImMessageMessageReadV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}