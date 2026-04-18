// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="Test_GetMailV1UserMailboxesByUserMailboxIdThreadsByThreadIdMessagesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询会话下邮件信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 查询会话下邮件信息 响应体
/// <para>接口ID：7535351280176414739</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-message/list_thread_message</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-message%2flist_thread_message</para>
/// </summary>
[TestClass]
public class Test_GetMailV1UserMailboxesByUserMailboxIdThreadsByThreadIdMessagesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "message_id": "xxx",
                "thread_id": "xxx",
                "folder_id": "INBOX",
                "smtp_message_id": "123456@example.com",
                "internal_date": "1651234567890",
                "message_state": 1,
                "message": {
                    "raw": "Q29udGVudC1UeXBlOiB0ZXh0L3BsYWluOyBjaGFyc2V0PSJ1cy1hc2NpaSIKTUlNRS1WZXJzaW9uOiAxLjAKQ29udGVudC1UcmFuc2Zlci1FbmNvZGluZzogN2JpdAp0bzogInRvIiA8dG9AeHh4Lnh4Pgpmcm9tOiAiZnJvbSIgPGZyb21AeHh4Lnh4PgpzdWJqZWN0OiB0aGlzIGlzIGEgc3ViamVjdAoKdGhpcyBpcyB0aGUgbWVzc2FnZSBib2R5Lg",
                    "subject": "邮件标题",
                    "to": [
                        {
                            "mail_address": "mike@outlook.com",
                            "name": "Mike"
                        }
                    ],
                    "cc": [
                        {
                            "mail_address": "mike@outlook.com",
                            "name": "Mike"
                        }
                    ],
                    "bcc": [
                        {
                            "mail_address": "mike@outlook.com",
                            "name": "Mike"
                        }
                    ],
                    "head_from": {
                        "mail_address": "mike@outlook.com",
                        "name": "Mike"
                    },
                    "body_html": "xxxx",
                    "internal_date": "1682377086000",
                    "message_state": 1,
                    "smtp_message_id": "ay0azrJDvbs3FJAg@outlook.com",
                    "message_id": "tfuh9N4WnzU6jdDw=",
                    "attachments": [
                        {
                            "body": "aGVsbG8gd29ybGQK",
                            "filename": "helloworld.txt",
                            "id": "YQqYbQHoQoDqXjxWKhJbo8Gicjf",
                            "attachment_type": 1,
                            "is_inline": false,
                            "cid": "image1@example.com"
                        }
                    ],
                    "body_plain_text": "xxxxx",
                    "thread_id": "tfuh9N4WnzU6jdDw=",
                    "body_preview": "xxxxx",
                    "label_ids": [
                        "FLAGGED"
                    ],
                    "folder_id": "INBOX",
                    "in_reply_to": "06d20.dbf451a3.808a.475a.acc9.1363dfd20f36@larksuite.com",
                    "reply_to": "06d20.dbf451a3.808a.475a.acc9.1363dfd20f36@larksuite.com",
                    "priority_type": "0",
                    "security_level": {
                        "is_risk": false,
                        "risk_banner_level": "WARNING",
                        "risk_banner_reason": "IMPERSONATE_DOMAIN",
                        "is_header_from_external": false,
                        "via_domain": "larksuite.com",
                        "spam_banner_type": "USER_REPORT",
                        "spam_user_rule_id": "7618365627924925388",
                        "spam_banner_info": "larksuite.com"
                    }
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1UserMailboxesByUserMailboxIdThreadsByThreadIdMessagesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}