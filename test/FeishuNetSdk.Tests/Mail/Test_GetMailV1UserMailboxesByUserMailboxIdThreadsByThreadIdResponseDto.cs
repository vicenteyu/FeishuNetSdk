// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="Test_GetMailV1UserMailboxesByUserMailboxIdThreadsByThreadIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取邮件会话详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 获取邮件会话详情 响应体
/// <para>接口ID：7626215228943027156</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-thread/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-thread%2fget</para>
/// </summary>
[TestClass]
public class Test_GetMailV1UserMailboxesByUserMailboxIdThreadsByThreadIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "thread": {
            "id": "xx",
            "body_preview": "hello world",
            "messages": [
                {
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
                    },
                    "references": "<5678.abcd@test.com>\r\n\t<1234.abcd@message-id>"
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1UserMailboxesByUserMailboxIdThreadsByThreadIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}