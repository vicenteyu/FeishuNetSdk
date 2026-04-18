// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="Test_PostMailV1UserMailboxesByUserMailboxIdThreadsBatchModifyBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量修改邮件会话 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 批量修改邮件会话 请求体
/// <para>接口ID：7626215228942846932</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-thread/batch_modify</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-thread%2fbatch_modify</para>
/// </summary>
[TestClass]
public class Test_PostMailV1UserMailboxesByUserMailboxIdThreadsBatchModifyBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "add_label_ids": [
        "UNREAD"
    ],
    "remove_label_ids": [
        "UNREAD"
    ],
    "add_folder": "INBOX",
    "thread_ids": [
        "dXNCbmZydHpBOWNBOXNmTFU0NDdkYjlSRzlZPQ=="
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PostMailV1UserMailboxesByUserMailboxIdThreadsBatchModifyBodyDto>(json);
        Assert.IsNotNull(result);
    }
}