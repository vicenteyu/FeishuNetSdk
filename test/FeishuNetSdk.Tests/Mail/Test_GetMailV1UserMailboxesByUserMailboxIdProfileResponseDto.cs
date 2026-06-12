// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="Test_GetMailV1UserMailboxesByUserMailboxIdProfileResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取用户邮箱信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 获取用户邮箱信息 响应体
/// <para>接口ID：7620282151846448348</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox/profile</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox%2fprofile</para>
/// </summary>
[TestClass]
public class Test_GetMailV1UserMailboxesByUserMailboxIdProfileResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "primary_email_address": "abc@abc.com"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1UserMailboxesByUserMailboxIdProfileResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}