namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 获取邮件卡片的邮件列表 响应体
/// <para>接口ID：7447350647756800004</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-message/get_by_card</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-message%2fget_by_card</para>
/// </summary>
[TestClass]
public class Test_GetMailV1UserMailboxesByUserMailboxIdMessagesGetByCardResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "owner_info": {
            "type": "user",
            "owner_user_id": "ou_7dab8a3d3cdcc9da365777c7ad115d62",
            "public_mailbox_id": "xxx"
        },
        "message_ids": [
            "TnAwLzVZbjB3TTcyeU5Tek1UMHRFa0l3aStNPQ=="
        ],
        "card_id": "512ca581-6059-4449-8150-5522e6646d32"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1UserMailboxesByUserMailboxIdMessagesGetByCardResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}