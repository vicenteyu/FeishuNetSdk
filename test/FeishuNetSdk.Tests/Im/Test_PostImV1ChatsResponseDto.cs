namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 创建群 响应体
/// <para>接口ID：6946222931479379969</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostImV1ChatsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "chat_id": "oc_a0553eda9014c201e6969b478895c230",
        "avatar": "https://p3-lark-file.byteimg.com/img/lark-avatar-staging/default-avatar_44ae0ca3-e140-494b-956f-78091e348435~100x100.jpg",
        "name": "测试群名称",
        "description": "测试群描述",
        "i18n_names": {
            "zh_cn": "群聊",
            "en_us": "group chat",
            "ja_jp": "グループチャット"
        },
        "owner_id": "ou_7d8a6e6df7621556ce0d21922b676706ccs",
        "owner_id_type": "open_id",
        "urgent_setting": "all_members",
        "video_conference_setting": "all_members",
        "add_member_permission": "all members",
        "share_card_permission": "allowed",
        "at_all_permission": "all members",
        "edit_permission": "all members",
        "group_message_type": "chat",
        "chat_mode": "group",
        "chat_type": "private",
        "chat_tag": "inner",
        "external": false,
        "tenant_key": "736588c9260f175e",
        "join_message_visibility": "all_members",
        "leave_message_visibility": "all_members",
        "membership_approval": "no_approval_required",
        "moderation_permission": "all_members",
        "restricted_mode_setting": {
            "status": false,
            "screenshot_has_permission_setting": "all_members",
            "download_has_permission_setting": "all_members",
            "message_has_permission_setting": "all_members"
        },
        "hide_member_count_setting": "all_members"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PostImV1ChatsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}