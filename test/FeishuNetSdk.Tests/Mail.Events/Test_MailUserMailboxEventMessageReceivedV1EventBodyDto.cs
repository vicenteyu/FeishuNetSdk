namespace FeishuNetSdk.Tests.Mail.Events;

/// <summary>
/// 测试 收信通知 事件体
/// <para>接口ID：7275929163676041219</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-event/events/message_received</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-event%2fevents%2fmessage_received</para>
/// </summary>
[TestClass]
public class Test_MailUserMailboxEventMessageReceivedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "mail.user_mailbox.event.message_received_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "mail_address": "a@xxx.com",
        "message_id": "ODM5OTgzYWItOTNmMS00NGJiLTk4MzAtODIwNGMzMjM1OGJh",
        "mailbox_type": 1,
        "subscriber": {
            "user_ids": [
                {
                    "union_id": "on_xxxxxx",
                    "user_id": "xxxxxx",
                    "open_id": "ou_xxxxxx"
                }
            ]
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Mail.Events.MailUserMailboxEventMessageReceivedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}