// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-20
//
// Last Modified By : yxr
// Last Modified On : 2026-11-20
// ************************************************************************
// <copyright file="Test_PostMailV1UserMailboxesByUserMailboxIdBlockedSendersBatchCreateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量创建拦截发件人 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 批量创建拦截发件人 响应体
/// <para>接口ID：7695747058686971093</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-blocked_sender/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-blocked_sender%2fbatch_create</para>
/// </summary>
[TestClass]
public class Test_PostMailV1UserMailboxesByUserMailboxIdBlockedSendersBatchCreateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "failed_items": [
            {
                "sender": "bad-format",
                "reason_code": "INVALID"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.PostMailV1UserMailboxesByUserMailboxIdBlockedSendersBatchCreateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}