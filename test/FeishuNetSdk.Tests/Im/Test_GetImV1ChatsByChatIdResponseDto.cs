// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetImV1ChatsByChatIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取群信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 获取群信息 响应体
/// <para>接口ID：6946222931479478273</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat%2fget</para>
/// </summary>
[TestClass]
public class Test_GetImV1ChatsByChatIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "avatar": "https://p3-lark-file.byteimg.com/img/lark-avatar-staging/default-avatar_44ae0ca3-e140-494b-956f-78091e348435~100x100.jpg",
        "name": "测试群名称",
        "description": "测试群描述",
        "i18n_names": {
            "zh_cn": "群聊",
            "en_us": "group chat",
            "ja_jp": "グループチャット"
        },
        "add_member_permission": "all_members",
        "share_card_permission": "allowed",
        "at_all_permission": "all_members",
        "edit_permission": "all_members",
        "owner_id_type": "user_id",
        "owner_id": "4d7a3c6g",
        "user_manager_id_list": [
            "ou_9204a37300b3700d61effaa439f34295"
        ],
        "bot_manager_id_list": [
            "cli_a3e157960e7294c"
        ],
        "group_message_type": "chat",
        "chat_mode": "group",
        "chat_type": "private",
        "chat_tag": "inner",
        "join_message_visibility": "only_owner",
        "leave_message_visibility": "only_owner",
        "membership_approval": "no_approval_required",
        "moderation_permission": "all_members",
        "external": false,
        "tenant_key": "736588c9260f175e",
        "user_count": "1",
        "bot_count": "3",
        "restricted_mode_setting": {
            "status": false,
            "screenshot_has_permission_setting": "all_members",
            "download_has_permission_setting": "all_members",
            "message_has_permission_setting": "all_members"
        },
        "urgent_setting": "all_members",
        "video_conference_setting": "all_members",
        "hide_member_count_setting": "all_members",
        "chat_status": "normal"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.GetImV1ChatsByChatIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}