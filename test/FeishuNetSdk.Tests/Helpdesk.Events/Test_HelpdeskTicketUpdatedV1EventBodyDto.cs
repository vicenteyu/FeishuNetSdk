// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_HelpdeskTicketUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 工单状态变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Helpdesk.Events;

/// <summary>
/// 测试 工单状态变更 事件体
/// <para>接口ID：6955768699896102914</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_HelpdeskTicketUpdatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "helpdesk.ticket.updated_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "object": {
            "ticket_id": "6626871355780366331",
            "helpdesk_id": "6626871355780366330",
            "guest": {
                "id": {
                    "union_id": "on_8ed6aa67826108097d9ee143816345",
                    "user_id": "e33ggbyz",
                    "open_id": "ou_84aad35d084aa403a838cf73ee18467"
                },
                "name": "abc"
            },
            "stage": 1,
            "status": 1,
            "score": 1,
            "created_at": 1616920429000,
            "updated_at": 1616920429000,
            "closed_at": 1616920429000,
            "channel": 0,
            "solve": 1,
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
            "chat_id": "oc_xxxxxxx"
        },
        "old_object": {
            "stage": 1,
            "status": 50,
            "updated_at": 1616920429000
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Helpdesk.Events.HelpdeskTicketUpdatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}