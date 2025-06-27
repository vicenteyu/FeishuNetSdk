// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetMailV1UserMailboxesByUserMailboxIdEventSubscriptionResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取订阅状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 获取订阅状态 响应体
/// <para>接口ID：7275929163676237827</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-event/subscription</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-event%2fsubscription</para>
/// </summary>
[TestClass]
public class Test_GetMailV1UserMailboxesByUserMailboxIdEventSubscriptionResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "event_types": [
            1
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1UserMailboxesByUserMailboxIdEventSubscriptionResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}