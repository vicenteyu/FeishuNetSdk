namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 更新群信息 请求体
/// <para>接口ID：6946222931479592961</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/update-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutImV1ChatsByChatIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "avatar": "default-avatar_44ae0ca3-e140-494b-956f-78091e348435",
    "name": "群聊",
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
    "owner_id": "4d7a3c6g",
    "join_message_visibility": "only_owner",
    "leave_message_visibility": "only_owner",
    "membership_approval": "no_approval_required",
    "restricted_mode_setting": {
        "status": false,
        "screenshot_has_permission_setting": "all_members",
        "download_has_permission_setting": "all_members",
        "message_has_permission_setting": "all_members"
    },
    "chat_type": "private",
    "group_message_type": "chat",
    "urgent_setting": "all_members",
    "video_conference_setting": "all_members",
    "hide_member_count_setting": "all_members"
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PutImV1ChatsByChatIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}