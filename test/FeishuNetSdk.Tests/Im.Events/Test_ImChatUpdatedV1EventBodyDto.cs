// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_ImChatUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 群配置修改 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im.Events;

/// <summary>
/// 测试 群配置修改 事件体
/// <para>接口ID：6946222929790615580</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_ImChatUpdatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "im.chat.updated_v1",
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
        "operator_tenant_key": "86gwe65",
        "after_change": {
            "avatar": "default-avatar_0cda3662-875a-4354-94d2-83e7393c7123",
            "name": "群名称测试",
            "description": "群描述测试",
            "i18n_names": {
                "zh_cn": "群聊",
                "en_us": "group chat",
                "ja_jp": "グループチャット"
            },
            "add_member_permission": "all_members",
            "share_card_permission": "allowed",
            "at_all_permission": "only_owner",
            "edit_permission": "all_members",
            "membership_approval": "approval_required",
            "join_message_visibility": "all_members",
            "leave_message_visibility": "all_members",
            "moderation_permission": "all_members",
            "owner_id": {
                "union_id": "on_8ed6aa67826108097d9ee143816345",
                "user_id": "e33ggbyz",
                "open_id": "ou_84aad35d084aa403a838cf73ee18467"
            },
            "restricted_mode_setting": {
                "status": false,
                "screenshot_has_permission_setting": "all_members",
                "download_has_permission_setting": "all_members",
                "message_has_permission_setting": "all_members"
            },
            "group_message_type": "thread"
        },
        "before_change": {
            "avatar": "default-avatar_0cda3662-875a-4354-94d2-83e7393c7123",
            "name": "群名称测试",
            "description": "群描述测试",
            "i18n_names": {
                "zh_cn": "群聊",
                "en_us": "group chat",
                "ja_jp": "グループチャット"
            },
            "add_member_permission": "all_members",
            "share_card_permission": "allowed",
            "at_all_permission": "only_owner",
            "edit_permission": "all_members",
            "membership_approval": "approval_required",
            "join_message_visibility": "all_members",
            "leave_message_visibility": "all_members",
            "moderation_permission": "all_members",
            "owner_id": {
                "union_id": "on_8ed6aa67826108097d9ee143816345",
                "user_id": "e33ggbyz",
                "open_id": "ou_84aad35d084aa403a838cf73ee18467"
            },
            "restricted_mode_setting": {
                "status": false,
                "screenshot_has_permission_setting": "all_members",
                "download_has_permission_setting": "all_members",
                "message_has_permission_setting": "all_members"
            },
            "group_message_type": "thread"
        },
        "moderator_list": {
            "added_member_list": [
                {
                    "tenant_key": "86gwe65",
                    "user_id": {
                        "union_id": "on_8ed6aa67826108097d9ee143816345",
                        "user_id": "e33ggbyz",
                        "open_id": "ou_84aad35d084aa403a838cf73ee18467"
                    }
                }
            ],
            "removed_member_list": [
                {
                    "tenant_key": "86gwe65",
                    "user_id": {
                        "union_id": "on_8ed6aa67826108097d9ee143816345",
                        "user_id": "e33ggbyz",
                        "open_id": "ou_84aad35d084aa403a838cf73ee18467"
                    }
                }
            ]
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Im.Events.ImChatUpdatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}