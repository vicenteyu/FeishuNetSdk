// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="Test_GetMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdSendStatusResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询邮件发送状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 查询邮件发送状态 响应体
/// <para>接口ID：7649297073556982987</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-message/send_status</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-message%2fsend_status</para>
/// </summary>
[TestClass]
public class Test_GetMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdSendStatusResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "message_id": "197c5d72e22e1d78",
        "details": [
            {
                "recipient": {
                    "mail_address": "mike@outlook.com",
                    "name": "Mike"
                },
                "status": 1,
                "last_updated_time": 1700000000
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdSendStatusResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}