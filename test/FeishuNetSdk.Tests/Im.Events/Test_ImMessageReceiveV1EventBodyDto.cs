// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_ImMessageReceiveV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 接收消息 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im.Events;

/// <summary>
/// 测试 接收消息 事件体
/// <para>接口ID：6946222929790402588</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/events/receive</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fevents%2freceive</para>
/// </summary>
[TestClass]
public class Test_ImMessageReceiveV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "im.message.receive_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "sender": {
            "sender_id": {
                "union_id": "on_8ed6aa67826108097d9ee143816345",
                "user_id": "e33ggbyz",
                "open_id": "ou_84aad35d084aa403a838cf73ee18467"
            },
            "sender_type": "user",
            "tenant_key": "736588c9260f175e"
        },
        "message": {
            "message_id": "om_5ce6d572455d361153b7cb51da133945",
            "root_id": "om_5ce6d572455d361153b7cb5xxfsdfsdfdsf",
            "parent_id": "om_5ce6d572455d361153b7cb5xxfsdfsdfdsf",
            "create_time": "1609073151345",
            "update_time": "1687343654666",
            "chat_id": "oc_5ce6d572455d361153b7xx51da133945",
            "thread_id": "omt_d4be107c616",
            "chat_type": "group",
            "message_type": "text",
            "content": "{\"text\":\"@_user_1 hello\"}",
            "mentions": [
                {
                    "key": "@_user_1",
                    "id": {
                        "union_id": "on_8ed6aa67826108097d9ee143816345",
                        "user_id": "e33ggbyz",
                        "open_id": "ou_84aad35d084aa403a838cf73ee18467"
                    },
                    "name": "Tom",
                    "tenant_key": "736588c9260f175e"
                }
            ],
            "user_agent": "Mozilla/5.0 (Macintosh; Intel Mac OS X 13_2_1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/101.0.4951.53 Safari/537.36 Lark/6.7.5 LarkLocale/en_US ttnet SDK-Version/6.7.8"
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Im.Events.ImMessageReceiveV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}