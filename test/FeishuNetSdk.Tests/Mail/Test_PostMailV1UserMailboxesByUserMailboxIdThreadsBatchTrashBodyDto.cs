// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="Test_PostMailV1UserMailboxesByUserMailboxIdThreadsBatchTrashBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量删除邮件会话 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 批量删除邮件会话 请求体
/// <para>接口ID：7626215228942912468</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-thread/batch_trash</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-thread%2fbatch_trash</para>
/// </summary>
[TestClass]
public class Test_PostMailV1UserMailboxesByUserMailboxIdThreadsBatchTrashBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "thread_ids": [
        "NzR3Zkd5NGhBTS9NVkZnSklidDVGT3VoQmM4PQ=="
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PostMailV1UserMailboxesByUserMailboxIdThreadsBatchTrashBodyDto>(json);
        Assert.IsNotNull(result);
    }
}