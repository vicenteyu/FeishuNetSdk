// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取邮件详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 获取邮件详情 响应体
/// <para>接口ID：7275929163676139523</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-message/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-message%2fget</para>
/// </summary>
[TestClass]
public class Test_GetMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "message": {
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
            "body_plain_text": "xxxxx",
            "attachments": [
                {
                    "filename": "helloworld.txt",
                    "id": "YQqYbQHoQoDqXjxWKhJbo8Gicjf",
                    "attachment_type": 1
                }
            ],
            "thread_id": "tfuh9N4WnzU6jdDw="
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}