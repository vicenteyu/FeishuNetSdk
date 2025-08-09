// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-10
//
// Last Modified By : yxr
// Last Modified On : 2025-08-10
// ************************************************************************
// <copyright file="Test_PostMailV1UserMailboxesByUserMailboxIdMessagesSendResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 发送邮件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 发送邮件 响应体
/// <para>接口ID：7205136193486356481</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/user_mailbox-message/send</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-message%2fsend</para>
/// </summary>
[TestClass]
public class Test_PostMailV1UserMailboxesByUserMailboxIdMessagesSendResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "message_id": "48451e97-4743-4a55-a9a3-b5c656b69c05",
        "thread_id": "14151e97-4743-4a55-a9a3-b5c656b69c05"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.PostMailV1UserMailboxesByUserMailboxIdMessagesSendResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}