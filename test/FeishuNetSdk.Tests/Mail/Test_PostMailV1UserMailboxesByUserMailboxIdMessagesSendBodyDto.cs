// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-08-10
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
    "raw": "U3ViamVjdDogSGVsbG8hCkZyb206ICJtaWtlIiA8bWlrZUBtaWtlLmNvbT4KTWltZS1WZXJzaW9uOiAxLjAKQ29udGVudC1UeXBlOiBtdWx0aXBhcnQvYWx0ZXJuYXRpdmU7CiBib3VuZGFyeT1iMjhmYTIyNGExZWU2ZDY3ZjE3OTViNGUxZDEwM2Q3MTBlNzM5ZWVmYjFmZjlmOWQ4NWI4M2NlOTRmMTEKRGF0ZTogV2VkLCAyMyBKdWwgMjAyNSAxNTo0NDoxOCArMDgwMApNZXNzYWdlLUlkOiA8bW9ja3V1aWRtZXNzYWdlX2lkQGxhcmsuY29tPgpUbzogImphY2siIDxqYWNrQGphY2suY29tPgoKLS1iMjhmYTIyNGExZWU2ZDY3ZjE3OTViNGUxZDEwM2Q3MTBlNzM5ZWVmYjFmZjlmOWQ4NWI4M2NlOTRmMTEKQ29udGVudC1UcmFuc2Zlci1FbmNvZGluZzogN2JpdApDb250ZW50LVR5cGU6IHRleHQvcGxhaW47IGNoYXJzZXQ9VVRGLTgKCldlbGNvbWUgdG8gTGFyayBtYWlsIQotLWIyOGZhMjI0YTFlZTZkNjdmMTc5NWI0ZTFkMTAzZDcxMGU3MzllZWZiMWZmOWY5ZDg1YjgzY2U5NGYxMQo=",
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
    "body_html": "xxxx",
    "body_plain_text": "xxxx",
    "attachments": [
        {
            "body": "aGVsbG8gd29ybGQK",
            "filename": "helloworld.txt",
            "is_inline": false,
            "cid": "image1@example.com"
        }
    ],
    "dedupe_key": "abc-ddd-eee-fff-ggg",
    "head_from": {
        "name": "Mike"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PostMailV1UserMailboxesByUserMailboxIdMessagesSendBodyDto>(json);
        Assert.IsNotNull(result);
    }
}