// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="Test_GetMailV1UserMailboxesByUserMailboxIdSettingsSendAsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 列出可发信邮箱 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 列出可发信邮箱 响应体
/// <para>接口ID：7626215228942896084</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-setting/send_as</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-setting%2fsend_as</para>
/// </summary>
[TestClass]
public class Test_GetMailV1UserMailboxesByUserMailboxIdSettingsSendAsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "sendable_addresses": [
            {
                "email_address": "abc@abc.com",
                "email_type": "USER_PRIMARY",
                "name": "Mike"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1UserMailboxesByUserMailboxIdSettingsSendAsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}