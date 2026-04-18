// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="Test_GetMailV1UserMailboxesByUserMailboxIdAccessibleMailboxesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 列出可访问的邮箱 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 列出可访问的邮箱 响应体
/// <para>接口ID：7626215228942994388</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox/accessible_mailboxes</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox%2faccessible_mailboxes</para>
/// </summary>
[TestClass]
public class Test_GetMailV1UserMailboxesByUserMailboxIdAccessibleMailboxesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "accessible_mailboxes": [
            {
                "email_address": "abc@abc.com",
                "email_type": "USER_PRIMARY"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1UserMailboxesByUserMailboxIdAccessibleMailboxesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}