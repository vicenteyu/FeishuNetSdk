// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="Test_PostMailV1UserMailboxesByUserMailboxIdDraftsByDraftIdSendResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 发送草稿 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 发送草稿 响应体
/// <para>接口ID：7620478754624424892</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-draft/send</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-draft%2fsend</para>
/// </summary>
[TestClass]
public class Test_PostMailV1UserMailboxesByUserMailboxIdDraftsByDraftIdSendResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "message_id": "xxxx",
        "thread_id": "xxxx"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.PostMailV1UserMailboxesByUserMailboxIdDraftsByDraftIdSendResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}