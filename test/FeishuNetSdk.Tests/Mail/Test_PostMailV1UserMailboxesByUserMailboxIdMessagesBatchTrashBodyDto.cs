// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="Test_PostMailV1UserMailboxesByUserMailboxIdMessagesBatchTrashBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量删除邮件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 批量删除邮件 请求体
/// <para>接口ID：7626215228942978004</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-message/batch_trash</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-message%2fbatch_trash</para>
/// </summary>
[TestClass]
public class Test_PostMailV1UserMailboxesByUserMailboxIdMessagesBatchTrashBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "message_ids": [
        "NzR3Zkd5NGhBTS9NVkZnSklidDVGT3VoQmM4PQ=="
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PostMailV1UserMailboxesByUserMailboxIdMessagesBatchTrashBodyDto>(json);
        Assert.IsNotNull(result);
    }
}