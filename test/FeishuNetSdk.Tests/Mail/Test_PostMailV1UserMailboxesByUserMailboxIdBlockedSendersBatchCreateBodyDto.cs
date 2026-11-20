// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-20
//
// Last Modified By : yxr
// Last Modified On : 2026-11-20
// ************************************************************************
// <copyright file="Test_PostMailV1UserMailboxesByUserMailboxIdBlockedSendersBatchCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量创建拦截发件人 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 批量创建拦截发件人 请求体
/// <para>接口ID：7695747058686971093</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-blocked_sender/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-blocked_sender%2fbatch_create</para>
/// </summary>
[TestClass]
public class Test_PostMailV1UserMailboxesByUserMailboxIdBlockedSendersBatchCreateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "items": [
        {
            "sender": "marketing@example.com",
            "sender_type": 1
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PostMailV1UserMailboxesByUserMailboxIdBlockedSendersBatchCreateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}