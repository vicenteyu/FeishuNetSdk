// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-11
//
// Last Modified By : yxr
// Last Modified On : 2026-05-11
// ************************************************************************
// <copyright file="Test_PutMailV1UserMailboxesByUserMailboxIdTemplatesByTemplateIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新邮件模板 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 更新邮件模板 请求体
/// <para>接口ID：7636620599011904463</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-template/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-template%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutMailV1UserMailboxesByUserMailboxIdTemplatesByTemplateIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "template": {
        "name": "销售跟进模板",
        "subject": "关于本周订单跟进",
        "template_content": "<p>Hi ${name},</p>",
        "is_plain_text_mode": false,
        "tos": [
            {
                "mail_address": "mike@outlook.com",
                "name": "Mike"
            }
        ],
        "ccs": [
            {
                "mail_address": "mike@outlook.com",
                "name": "Mike"
            }
        ],
        "bccs": [
            {
                "mail_address": "mike@outlook.com",
                "name": "Mike"
            }
        ],
        "attachments": [
            {
                "filename": "plan.xlsx",
                "id": "boxcnrHpsg1QDqXPrJXWPwbqsKh",
                "attachment_type": 1,
                "is_inline": false,
                "cid": "image1@example.com"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PutMailV1UserMailboxesByUserMailboxIdTemplatesByTemplateIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}