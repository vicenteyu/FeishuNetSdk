// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_ImMessageReactionCreatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 新增消息表情回复 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im.Events;

/// <summary>
/// 测试 新增消息表情回复 事件体
/// <para>接口ID：6992043826169970690</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-reaction/event/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage-reaction%2fevents%2fcreated</para>
/// </summary>
[TestClass]
public class Test_ImMessageReactionCreatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "im.message.reaction.created_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "message_id": "om_dc1326***************51dba21dcf",
        "reaction_type": {
            "emoji_type": "SMILE"
        },
        "operator_type": "app/user",
        "user_id": {
            "union_id": "on_8ed6aa67826108097d9ee143816345",
            "user_id": "e33ggbyz",
            "open_id": "ou_84aad35d084aa403a838cf73ee18467"
        },
        "app_id": "cli_9f53******712544",
        "action_time": "1627641418803"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Im.Events.ImMessageReactionCreatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}