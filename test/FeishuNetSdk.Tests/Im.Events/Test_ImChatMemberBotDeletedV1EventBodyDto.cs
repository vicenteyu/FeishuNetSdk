// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_ImChatMemberBotDeletedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 机器人被移出群 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im.Events;

/// <summary>
/// 测试 机器人被移出群 事件体
/// <para>接口ID：6946222929790566428</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/event/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-member-bot%2fevents%2fdeleted</para>
/// </summary>
[TestClass]
public class Test_ImChatMemberBotDeletedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "im.chat.member.bot.deleted_v1",
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
        "external": false,
        "operator_tenant_key": "27898y326",
        "name": "群名称测试",
        "i18n_names": {
            "zh_cn": "群聊",
            "en_us": "group chat",
            "ja_jp": "グループチャット"
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Im.Events.ImChatMemberBotDeletedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}