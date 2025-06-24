// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostMailV1UserMailboxesByUserMailboxIdMessagesSendBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 发送邮件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 发送邮件 请求体
/// <para>接口ID：7205136193486356481</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/user_mailbox-message/send</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-message%2fsend</para>
/// </summary>
[TestClass]
public class Test_PostMailV1UserMailboxesByUserMailboxIdMessagesSendBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "subject": "邮件标题",
    "to": [
        {
            "mail_address": "user@xxx.xx",
            "name": "Mike"
        }
    ],
    "cc": [
        {
            "mail_address": "user@xxx.xx",
            "name": "Mike"
        }
    ],
    "bcc": [
        {
            "mail_address": "user@xxx.xx",
            "name": "Mike"
        }
    ],
    "head_from": {
        "name": "Mike"
    },
    "body_html": "xxxx",
    "body_plain_text": "xxxxx",
    "attachments": [
        {
            "body": "aGVsbG8gd29ybGQK",
            "filename": "helloworld.txt"
        }
    ],
    "thread_id": "tfuh9N4WnzU6jdDw="
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PostMailV1UserMailboxesByUserMailboxIdMessagesSendBodyDto>(json);
        Assert.IsNotNull(result);
    }
}