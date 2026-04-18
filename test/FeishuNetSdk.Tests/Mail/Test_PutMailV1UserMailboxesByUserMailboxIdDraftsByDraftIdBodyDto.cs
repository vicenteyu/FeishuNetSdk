// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="Test_PutMailV1UserMailboxesByUserMailboxIdDraftsByDraftIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新草稿 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 更新草稿 请求体
/// <para>接口ID：7620478754624490428</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-draft/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-draft%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutMailV1UserMailboxesByUserMailboxIdDraftsByDraftIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "raw": "Q29udGVudC1UeXBlOiB0ZXh0L3BsYWluOyBjaGFyc2V0PSJ1cy1hc2NpaSIKTUlNRS1WZXJzaW9uOiAxLjAKQ29udGVudC1UcmFuc2Zlci1FbmNvZGluZzogN2JpdAp0bzogInRvIiA8dG9AeHh4Lnh4Pgpmcm9tOiAiZnJvbSIgPGZyb21AeHh4Lnh4PgpzdWJqZWN0OiB0aGlzIGlzIGEgc3ViamVjdAoKdGhpcyBpcyB0aGUgbWVzc2FnZSBib2R5Lg"
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PutMailV1UserMailboxesByUserMailboxIdDraftsByDraftIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}