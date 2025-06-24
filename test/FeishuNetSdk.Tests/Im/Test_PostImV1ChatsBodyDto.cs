// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostImV1ChatsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建群 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 创建群 请求体
/// <para>接口ID：6946222931479379969</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostImV1ChatsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "avatar": "default-avatar_44ae0ca3-e140-494b-956f-78091e348435",
    "name": "测试群名称",
    "description": "测试群描述",
    "i18n_names": {
        "zh_cn": "群聊",
        "en_us": "group chat",
        "ja_jp": "グループチャット"
    },
    "owner_id": "ou_7d8a6e6df7621556ce0d21922b676706ccs",
    "user_id_list": [
        "ou_7d8a6e6df7621556ce0d21922b676706ccs"
    ],
    "bot_id_list": [
        "cli_a10fbf7e94b8d01d"
    ],
    "group_message_type": "chat",
    "chat_mode": "group",
    "chat_type": "private",
    "join_message_visibility": "all_members",
    "leave_message_visibility": "all_members",
    "membership_approval": "no_approval_required",
    "restricted_mode_setting": {
        "status": false,
        "screenshot_has_permission_setting": "all_members",
        "download_has_permission_setting": "all_members",
        "message_has_permission_setting": "all_members"
    },
    "urgent_setting": "all_members",
    "video_conference_setting": "all_members",
    "edit_permission": "all_members",
    "hide_member_count_setting": "all_members"
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PostImV1ChatsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}